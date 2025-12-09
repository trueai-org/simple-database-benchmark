using SimpleDatabaseBenchmark.Models;
using SimpleDatabaseBenchmark.Reports;
using SimpleDatabaseBenchmark.Utils;
using FreeSql;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SimpleDatabaseBenchmark.Services;

/// <summary>
/// 基准测试运行器
/// </summary>
public class BenchmarkRunner
{
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;
    private readonly List<IBenchmarkService> _services = new();
    private readonly List<BenchmarkResult> _allResults = new();

    public BenchmarkRunner(IConfiguration configuration)
    {
        _configuration = configuration;
        _logger = Log.ForContext<BenchmarkRunner>();
    }

    /// <summary>
    /// 是否有可用的数据库服务
    /// </summary>
    public bool HasAvailableServices => _services.Count > 0;

    /// <summary>
    /// 初始化所有数据库服务
    /// </summary>
    public async Task InitializeServicesAsync()
    {
        _logger.Information("========== 初始化数据库服务 ==========");

        // MySQL
        var mysqlConnStr = _configuration.GetConnectionString("MySql");
        if (!string.IsNullOrEmpty(mysqlConnStr))
        {
            try
            {
                var mysqlService = new FreeSqlBenchmarkService("MySQL", DataType.MySql, mysqlConnStr);
                await mysqlService.InitializeAsync();
                _services.Add(mysqlService);
                _logger.Information("MySQL 服务初始化成功");
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "MySQL 服务初始化失败，跳过该数据库测试");
            }
        }

        // SQL Server
        var sqlServerConnStr = _configuration.GetConnectionString("SqlServer");
        if (!string.IsNullOrEmpty(sqlServerConnStr))
        {
            try
            {
                var sqlServerService = new FreeSqlBenchmarkService("SQLServer", DataType.SqlServer, sqlServerConnStr);
                await sqlServerService.InitializeAsync();
                _services.Add(sqlServerService);
                _logger.Information("SQL Server 服务初始化成功");
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "SQL Server 服务初始化失败，跳过该数据库测试");
            }
        }

        // PostgreSQL
        var pgsqlConnStr = _configuration.GetConnectionString("PostgreSql");
        if (!string.IsNullOrEmpty(pgsqlConnStr))
        {
            try
            {
                var pgsqlService = new FreeSqlBenchmarkService("PostgreSQL", DataType.PostgreSQL, pgsqlConnStr);
                await pgsqlService.InitializeAsync();
                _services.Add(pgsqlService);
                _logger.Information("PostgreSQL 服务初始化成功");
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "PostgreSQL 服务初始化失败，跳过该数据库测试");
            }
        }

        // SQLite
        var sqliteConnStr = _configuration.GetConnectionString("Sqlite");
        if (!string.IsNullOrEmpty(sqliteConnStr))
        {
            try
            {
                var sqliteService = new FreeSqlBenchmarkService("SQLite", DataType.Sqlite, sqliteConnStr);
                await sqliteService.InitializeAsync();
                _services.Add(sqliteService);
                _logger.Information("SQLite 服务初始化成功");
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "SQLite 服务初始化失败，跳过该数据库测试");
            }
        }

        // MongoDB
        var mongoConnStr = _configuration.GetConnectionString("MongoDb");
        if (!string.IsNullOrEmpty(mongoConnStr))
        {
            try
            {
                var mongoService = new MongoDbBenchmarkService(mongoConnStr);
                await mongoService.InitializeAsync();
                _services.Add(mongoService);
                _logger.Information("MongoDB 服务初始化成功");
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "MongoDB 服务初始化失败，跳过该数据库测试");
            }
        }

        _logger.Information("已初始化 {Count} 个数据库服务", _services.Count);
    }

    /// <summary>
    /// 运行所有基准测试
    /// </summary>
    public async Task RunAllBenchmarksAsync()
    {
        var singleCount = _configuration.GetValue("BenchmarkSettings:SingleOperationCount", 1000);
        var batchSize = _configuration.GetValue("BenchmarkSettings:BatchSize", 1000);
        var batchCount = _configuration.GetValue("BenchmarkSettings:BatchOperationCount", 10);
        var warmupIterations = _configuration.GetValue("BenchmarkSettings:WarmupIterations", 3);
        var testIterations = _configuration.GetValue("BenchmarkSettings:TestIterations", 5);

        _logger.Information("========== 开始基准测试 ==========");
        _logger.Information("测试配置 - 单条操作数: {Single}, 批量大小: {BatchSize}, 批量次数: {BatchCount}, 预热次数: {Warmup}, 测试迭代: {Iterations}",
            singleCount, batchSize, batchCount, warmupIterations, testIterations);

        foreach (var service in _services)
        {
            _logger.Information("");
            _logger.Information("========== 测试数据库: {Database} ==========", service.DatabaseName);

            try
            {
                // 预热
                _logger.Information("[{Database}] 开始预热...", service.DatabaseName);
                for (int i = 0; i < warmupIterations; i++)
                {
                    await service.CleanupAsync();
                    await service.SingleInsertAsync(100);
                    await service.SingleSelectAsync(50);
                    await service.CleanupAsync();
                }
                _logger.Information("[{Database}] 预热完成", service.DatabaseName);

                // 正式测试
                for (int iteration = 1; iteration <= testIterations; iteration++)
                {
                    _logger.Information("");
                    _logger.Information("[{Database}] ===== 第 {Iteration}/{Total} 轮测试 =====",
                        service.DatabaseName, iteration, testIterations);

                    await service.CleanupAsync();

                    // 单条操作测试
                    _logger.Information("[{Database}] ----- 单条操作测试 -----", service.DatabaseName);
                    _allResults.Add(await service.SingleInsertAsync(singleCount));
                    _allResults.Add(await service.SingleSelectAsync(singleCount));
                    _allResults.Add(await service.SingleUpdateAsync(singleCount));
                    _allResults.Add(await service.SingleDeleteAsync(singleCount));

                    await service.CleanupAsync();

                    // 批量操作测试
                    _logger.Information("[{Database}] ----- 批量操作测试 -----", service.DatabaseName);
                    _allResults.Add(await service.BatchInsertAsync(batchSize, batchCount));
                    _allResults.Add(await service.BatchSelectAsync(batchSize, batchCount));
                    _allResults.Add(await service.BatchUpdateAsync(batchSize, batchCount));

                    // 统计汇总测试（在删除前进行）
                    _logger.Information("[{Database}] ----- 统计汇总测试 -----", service.DatabaseName);
                    _allResults.Add(await service.AggregationAsync());
                    _allResults.Add(await service.GroupAggregationAsync());

                    // 批量删除
                    _allResults.Add(await service.BatchDeleteAsync(batchSize, batchCount));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "[{Database}] 测试过程中发生错误", service.DatabaseName);
            }
        }

        _logger.Information("");
        _logger.Information("========== 基准测试完成 ==========");
    }

    /// <summary>
    /// 生成报告
    /// </summary>
    public async Task GenerateReportAsync()
    {
        _logger.Information("========== 生成测试报告 ==========");

        var serverInfo = ServerInfo.Collect();
        var reportGenerator = new ReportGenerator();

        await reportGenerator.GenerateReportAsync(_allResults, serverInfo, _configuration);

        _logger.Information("测试报告生成完成");
    }

    /// <summary>
    /// 清理资源
    /// </summary>
    public async Task DisposeAsync()
    {
        _logger.Information("========== 清理资源 ==========");

        foreach (var service in _services)
        {
            try
            {
                await service.DisposeAsync();
            }
            catch (Exception ex)
            {
                _logger.Warning(ex, "释放服务 {Database} 时发生错误", service.DatabaseName);
            }
        }

        _services.Clear();
        _logger.Information("资源清理完成");
    }
}