using FreeSql;
using Serilog;
using SimpleDatabaseBenchmark.Models;
using SimpleDatabaseBenchmark.Utils;

namespace SimpleDatabaseBenchmark.Services;

/// <summary>
/// FreeSql 基准测试服务
/// </summary>
public class FreeSqlBenchmarkService : IBenchmarkService
{
    private readonly IFreeSql _freeSql;
    private readonly ILogger _logger;
    private readonly string[] _departments = { "Engineering", "Sales", "Marketing", "HR", "Finance", "IT", "Operations", "Legal" };
    private readonly Random _random = new();

    public string DatabaseName { get; }

    public FreeSqlBenchmarkService(string databaseName, DataType dataType, string connectionString)
    {
        DatabaseName = databaseName;
        _logger = Log.ForContext<FreeSqlBenchmarkService>().ForContext("Database", databaseName);

        _freeSql = new FreeSqlBuilder()
            .UseConnectionString(dataType, connectionString)
            .UseAutoSyncStructure(true)
            .UseMonitorCommand(cmd => _logger.Debug("SQL: {Sql}", cmd.CommandText))
            .Build();

        _logger.Information("FreeSql 实例已创建: {DatabaseName}", databaseName);
    }

    public async Task InitializeAsync()
    {
        _logger.Information("初始化数据库: {DatabaseName}", DatabaseName);

        // 同步表结构
        _freeSql.CodeFirst.SyncStructure<TestEntity>();

        //// 清空数据
        //await _freeSql.Delete<TestEntity>().Where("1=1").ExecuteAffrowsAsync();

        // 每次删除 1万
        const int batchSize = 10000;
        while (true)
        {
            var deleted = await _freeSql.Select<TestEntity>()
                .Where(a => true)  // 或者你的条件
                .Limit(batchSize)
                .ToDelete()
                .ExecuteAffrowsAsync();

            if (deleted == 0)
                break;
        }

        _logger.Information("数据库初始化完成: {DatabaseName}", DatabaseName);
    }

    public async Task CleanupAsync()
    {
        _logger.Information("清理数据: {DatabaseName}", DatabaseName);
        await _freeSql.Delete<TestEntity>().Where("1=1").ExecuteAffrowsAsync();
        _logger.Information("数据清理完成: {DatabaseName}", DatabaseName);
    }

    public async Task<BenchmarkResult> SingleInsertAsync(int count)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Single",
            OperationName = "Insert",
            RecordCount = count,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单条插入测试, 数量: {Count}", DatabaseName, count);

            monitor.Start();

            for (int i = 0; i < count; i++)
            {
                var entity = GenerateTestEntity(i);
                await _freeSql.Insert(entity).ExecuteAffrowsAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(count);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单条插入完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单条插入失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> SingleSelectAsync(int count)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Single",
            OperationName = "Select",
            RecordCount = count,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单条查询测试, 数量: {Count}", DatabaseName, count);

            // 先获取已有数据的ID
            var ids = await _freeSql.Select<TestEntity>().Limit(count).ToListAsync(x => x.Id);

            monitor.Start();

            foreach (var id in ids)
            {
                await _freeSql.Select<TestEntity>().Where(x => x.Id == id).FirstAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(ids.Count);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单条查询完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单条查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> SingleUpdateAsync(int count)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Single",
            OperationName = "Update",
            RecordCount = count,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单条更新测试, 数量: {Count}", DatabaseName, count);

            var entities = await _freeSql.Select<TestEntity>().Limit(count).ToListAsync();

            monitor.Start();

            foreach (var entity in entities)
            {
                entity.Name = $"Updated_{entity.Name}";
                entity.UpdatedAt = DateTime.Now;
                await _freeSql.Update<TestEntity>().SetSource(entity).ExecuteAffrowsAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(entities.Count);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单条更新完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单条更新失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> SingleDeleteAsync(int count)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Single",
            OperationName = "Delete",
            RecordCount = count,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单条删除测试, 数量: {Count}", DatabaseName, count);

            var ids = await _freeSql.Select<TestEntity>().Limit(count).ToListAsync(x => x.Id);

            monitor.Start();

            foreach (var id in ids)
            {
                await _freeSql.Delete<TestEntity>().Where(x => x.Id == id).ExecuteAffrowsAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(ids.Count);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单条删除完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单条删除失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> BatchInsertAsync(int batchSize, int batchCount)
    {
        var totalCount = batchSize * batchCount;
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Batch",
            OperationName = "Insert",
            RecordCount = totalCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始批量插入测试, 批次大小: {BatchSize}, 批次数: {BatchCount}, 总数: {Total}",
                DatabaseName, batchSize, batchCount, totalCount);

            monitor.Start();

            for (int batch = 0; batch < batchCount; batch++)
            {
                var entities = Enumerable.Range(0, batchSize)
                    .Select(i => GenerateTestEntity(batch * batchSize + i))
                    .ToList();

                await _freeSql.Insert(entities).ExecuteAffrowsAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(totalCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 批量插入完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 批量插入失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> BatchSelectAsync(int batchSize, int batchCount)
    {
        var totalCount = batchSize * batchCount;
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Batch",
            OperationName = "Select",
            RecordCount = totalCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始批量查询测试, 批次大小: {BatchSize}, 批次数: {BatchCount}",
                DatabaseName, batchSize, batchCount);

            monitor.Start();

            for (int batch = 0; batch < batchCount; batch++)
            {
                await _freeSql.Select<TestEntity>()
                    .Skip(batch * batchSize)
                    .Limit(batchSize)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(totalCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 批量查询完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 批量查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> BatchUpdateAsync(int batchSize, int batchCount)
    {
        var totalCount = batchSize * batchCount;
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Batch",
            OperationName = "Update",
            RecordCount = totalCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始批量更新测试, 批次大小: {BatchSize}, 批次数: {BatchCount}",
                DatabaseName, batchSize, batchCount);

            monitor.Start();

            for (int batch = 0; batch < batchCount; batch++)
            {
                var entities = await _freeSql.Select<TestEntity>()
                    .Skip(batch * batchSize)
                    .Limit(batchSize)
                    .ToListAsync();

                foreach (var entity in entities)
                {
                    entity.Name = $"BatchUpdated_{entity.Id}";
                    entity.UpdatedAt = DateTime.Now;
                }

                await _freeSql.Update<TestEntity>().SetSource(entities).ExecuteAffrowsAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(totalCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 批量更新完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 批量更新失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> BatchDeleteAsync(int batchSize, int batchCount)
    {
        var totalCount = batchSize * batchCount;
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Batch",
            OperationName = "Delete",
            RecordCount = totalCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始批量删除测试, 批次大小: {BatchSize}, 批次数: {BatchCount}",
                DatabaseName, batchSize, batchCount);

            monitor.Start();

            for (int batch = 0; batch < batchCount; batch++)
            {
                var ids = await _freeSql.Select<TestEntity>()
                    .Limit(batchSize)
                    .ToListAsync(x => x.Id);

                if (ids.Any())
                {
                    await _freeSql.Delete<TestEntity>().Where(x => ids.Contains(x.Id)).ExecuteAffrowsAsync();
                }
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(totalCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 批量删除完成, 耗时: {Elapsed}ms, OPS: {OPS}, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 批量删除失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> AggregationAsync()
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Aggregation",
            OperationName = "Statistics",
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始统计汇总测试", DatabaseName);

            monitor.Start();

            var count = await _freeSql.Select<TestEntity>().CountAsync();
            var totalSalary = await _freeSql.Select<TestEntity>().SumAsync(x => x.Salary);
            var avgSalary = await _freeSql.Select<TestEntity>().AvgAsync(x => x.Salary);
            var maxSalary = await _freeSql.Select<TestEntity>().MaxAsync(x => x.Salary);
            var minSalary = await _freeSql.Select<TestEntity>().MinAsync(x => x.Salary);
            var avgAge = await _freeSql.Select<TestEntity>().AvgAsync(x => x.Age);

            monitor.Stop();

            result.RecordCount = (int)count;
            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(6); // 6个聚合操作
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 统计汇总完成 - Count: {Count}, TotalSalary: {Total}, AvgSalary: {Avg}, MaxSalary: {Max}, MinSalary: {Min}, AvgAge: {Age}",
                DatabaseName, count, totalSalary, avgSalary, maxSalary, minSalary, avgAge);
            _logger.Information("[{Database}] 统计汇总耗时: {Elapsed}ms, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 统计汇总失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> GroupAggregationAsync()
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "Aggregation",
            OperationName = "GroupBy",
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始分组汇总测试", DatabaseName);

            monitor.Start();

            var groupResults = await _freeSql.Select<TestEntity>()
                .GroupBy(x => x.Department)
                .ToListAsync(g => new GroupAggregationResult
                {
                    Department = g.Key,
                    Count = (int)g.Count(),
                    TotalSalary = g.Sum(g.Value.Salary),
                    AvgSalary = g.Avg(g.Value.Salary),
                    AvgAge = (int)g.Avg(g.Value.Age)
                });

            monitor.Stop();

            result.RecordCount = groupResults.Count;
            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(1);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 分组汇总完成, 分组数: {GroupCount}", DatabaseName, groupResults.Count);
            foreach (var g in groupResults)
            {
                _logger.Debug("[{Database}] 部门: {Dept}, 人数: {Count}, 平均薪资: {AvgSalary}",
                    DatabaseName, g.Department, g.Count, g.AvgSalary);
            }
            _logger.Information("[{Database}] 分组汇总耗时: {Elapsed}ms, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 分组汇总失败", DatabaseName);
        }

        return result;
    }

    public Task DisposeAsync()
    {
        _freeSql?.Dispose();
        _logger.Information("FreeSql 实例已释放: {DatabaseName}", DatabaseName);
        return Task.CompletedTask;
    }

    #region 百万级数据索引测试

    private readonly string[] _categories = { "Electronics", "Clothing", "Food", "Books", "Sports", "Home", "Beauty", "Toys", "Automotive", "Garden" };
    private readonly string[] _regions = { "North", "South", "East", "West", "Central", "Northeast", "Northwest", "Southeast", "Southwest", "Overseas" };
    private readonly string[] _tagsList = { "hot,new", "sale,popular", "premium,quality", "budget,value", "trending,featured", "classic,reliable", "eco,green", "luxury,exclusive" };

    public async Task<BenchmarkResult> PrepareMillionDataAsync(int totalCount, int batchSize)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "MillionData",
            OperationName = "PrepareData",
            RecordCount = totalCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始准备百万级测试数据, 总数: {Total}, 批次大小: {BatchSize}", DatabaseName, totalCount, batchSize);

            // 清理现有数据
            await _freeSql.Delete<TestEntity>().Where("1=1").ExecuteAffrowsAsync();

            monitor.Start();

            var batchCount = (totalCount + batchSize - 1) / batchSize;
            for (int batch = 0; batch < batchCount; batch++)
            {
                var currentBatchSize = Math.Min(batchSize, totalCount - batch * batchSize);
                var entities = Enumerable.Range(0, currentBatchSize)
                    .Select(i => GenerateTestEntityWithIndex(batch * batchSize + i))
                    .ToList();

                // 如果是sqlserver 则使用 BulkCopy 插入以提升性能，否则将会非常慢 100 倍
                if (DatabaseName == "SQLServer")
                {
                    await _freeSql.Insert(entities).ExecuteSqlBulkCopyAsync();
                }
                // PG
                else if (DatabaseName == "PostgreSQL")
                {
                    await _freeSql.Insert(entities).ExecutePgCopyAsync();
                }
                else
                {
                    //await _freeSql.Insert(entities).ExecuteAffrowsAsync();
                    await _freeSql.Insert(entities).ExecuteSqlBulkCopyAsync();
                }

                if ((batch + 1) % 100 == 0)
                {
                    _logger.Information("[{Database}] 已插入 {Count}/{Total} 条数据", DatabaseName, (batch + 1) * batchSize, totalCount);
                }
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(totalCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 百万级数据准备完成, 耗时: {Elapsed}ms, OPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 百万级数据准备失败", DatabaseName);
        }

        return result;
    }

    public Task CreateIndexesAsync()
    {
        _logger.Information("[{Database}] 通过 FreeSql 特性自动同步索引", DatabaseName);

        // 使用 FreeSql CodeFirst 同步索引（索引已通过 TestEntity 上的 Index 特性定义）
        _freeSql.CodeFirst.SyncStructure<TestEntity>();

        _logger.Information("[{Database}] 索引同步完成", DatabaseName);

        return Task.CompletedTask;
    }

    public async Task<BenchmarkResult> IndexQueryByPrimaryKeyAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "PrimaryKey",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始主键索引查询测试, 查询次数: {Count}", DatabaseName, queryCount);

            var maxId = await _freeSql.Select<TestEntity>().MaxAsync(x => x.Id);
            var ids = Enumerable.Range(0, queryCount).Select(_ => (long)_random.Next(1, (int)maxId)).ToList();

            monitor.Start();

            foreach (var id in ids)
            {
                await _freeSql.Select<TestEntity>().Where(x => x.Id == id).FirstAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 主键索引查询完成, 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 主键索引查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByStatusAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "SingleIndex_Status",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单字段索引查询测试(Status), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var status = _random.Next(0, 4);
                await _freeSql.Select<TestEntity>().Where(x => x.Status == status).Limit(100).ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单字段索引查询完成(Status), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单字段索引查询失败(Status)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByCategoryAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "SingleIndex_Category",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始单字段索引查询测试(Category), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var category = _categories[_random.Next(_categories.Length)];
                await _freeSql.Select<TestEntity>().Where(x => x.Category == category).Limit(100).ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 单字段索引查询完成(Category), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 单字段索引查询失败(Category)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByRegionAndDepartmentAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "CompositeIndex_RegionDept",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始复合索引查询测试(Region+Department), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var region = _regions[_random.Next(_regions.Length)];
                var dept = _departments[_random.Next(_departments.Length)];
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Region == region && x.Department == dept)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 复合索引查询完成(Region+Department), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 复合索引查询失败(Region+Department)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByStatusCategoryPriorityAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "CompositeIndex_StatusCatPri",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始复合索引查询测试(Status+Category+Priority), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var status = _random.Next(0, 4);
                var category = _categories[_random.Next(_categories.Length)];
                var priority = _random.Next(1, 6);
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Status == status && x.Category == category && x.Priority == priority)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 复合索引查询完成(Status+Category+Priority), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 复合索引查询失败(Status+Category+Priority)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByScoreRangeAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "RangeQuery_Score",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始范围查询测试(Score), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var minScore = (decimal)(_random.NextDouble() * 50);
                var maxScore = minScore + (decimal)(_random.NextDouble() * 50);
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Score >= minScore && x.Score <= maxScore)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 范围查询完成(Score), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 范围查询失败(Score)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByDateRangeAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "RangeQuery_Date",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始范围查询测试(CreatedAt), 查询次数: {Count}", DatabaseName, queryCount);

            var now = DateTime.Now;

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var daysAgo = _random.Next(1, 365);
                var startDate = now.AddDays(-daysAgo);
                var endDate = startDate.AddDays(_random.Next(1, 30));
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.CreatedAt >= startDate && x.CreatedAt <= endDate)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 范围查询完成(CreatedAt), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 范围查询失败(CreatedAt)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryBySalaryRangeAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "RangeQuery_Salary",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始范围查询测试(Salary), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var minSalary = (decimal)(_random.NextDouble() * 50000 + 30000);
                var maxSalary = minSalary + (decimal)(_random.NextDouble() * 30000);
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Salary >= minSalary && x.Salary <= maxSalary)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 范围查询完成(Salary), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 范围查询失败(Salary)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryByNamePrefixAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "PrefixQuery_Name",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始前缀查询测试(Name), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var prefix = $"User_{_random.Next(0, 100000)}";
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Name.StartsWith(prefix))
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 前缀查询完成(Name), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 前缀查询失败(Name)", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryWithPaginationAsync(int pageSize, int pageCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "Pagination",
            RecordCount = pageSize * pageCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始分页查询测试, 页大小: {PageSize}, 页数: {PageCount}", DatabaseName, pageSize, pageCount);

            monitor.Start();

            for (int page = 0; page < pageCount; page++)
            {
                await _freeSql.Select<TestEntity>()
                    .OrderBy(x => x.Id)
                    .Skip(page * pageSize)
                    .Limit(pageSize)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(pageCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 分页查询完成, 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 分页查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryWithOrderByAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "OrderBy",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始排序查询测试, 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                await _freeSql.Select<TestEntity>()
                    .OrderByDescending(x => x.Priority)
                    .OrderBy(x => x.CreatedAt)
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 排序查询完成, 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 排序查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> IndexQueryComplexConditionAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "ComplexCondition",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始复杂条件查询测试, 查询次数: {Count}", DatabaseName, queryCount);

            var now = DateTime.Now;

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                var status = _random.Next(0, 4);
                var category = _categories[_random.Next(_categories.Length)];
                var region = _regions[_random.Next(_regions.Length)];
                var minSalary = (decimal)(_random.NextDouble() * 50000 + 30000);
                var startDate = now.AddDays(-_random.Next(1, 365));

                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Status == status)
                    .Where(x => x.Category == category || x.Region == region)
                    .Where(x => x.Salary >= minSalary)
                    .Where(x => x.CreatedAt >= startDate)
                    .Where(x => x.IsActive == true)
                    .OrderByDescending(x => x.Priority)
                    .Limit(50)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 复杂条件查询完成, 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 复杂条件查询失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> MillionDataAggregationAsync()
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "MillionData",
            OperationName = "Aggregation",
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始百万级数据聚合测试", DatabaseName);

            monitor.Start();

            var count = await _freeSql.Select<TestEntity>().CountAsync();
            var totalSalary = await _freeSql.Select<TestEntity>().SumAsync(x => x.Salary);
            var avgSalary = await _freeSql.Select<TestEntity>().AvgAsync(x => x.Salary);
            var maxSalary = await _freeSql.Select<TestEntity>().MaxAsync(x => x.Salary);
            var minSalary = await _freeSql.Select<TestEntity>().MinAsync(x => x.Salary);
            var totalScore = await _freeSql.Select<TestEntity>().SumAsync(x => x.Score);
            var avgScore = await _freeSql.Select<TestEntity>().AvgAsync(x => x.Score);
            var avgQuantity = await _freeSql.Select<TestEntity>().AvgAsync(x => x.Quantity);

            monitor.Stop();

            result.RecordCount = (int)count;
            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(8); // 8个聚合操作
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 百万级数据聚合完成 - Count: {Count}, AvgSalary: {AvgSalary}, AvgScore: {AvgScore}",
                DatabaseName, count, avgSalary, avgScore);
            _logger.Information("[{Database}] 聚合测试耗时: {Elapsed}ms, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 百万级数据聚合失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> MillionDataGroupByAsync()
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "MillionData",
            OperationName = "GroupBy",
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始百万级数据分组统计测试", DatabaseName);

            monitor.Start();

            // 按部门分组统计
            var deptStats = await _freeSql.Select<TestEntity>()
                .GroupBy(x => x.Department)
                .ToListAsync(g => new
                {
                    Department = g.Key,
                    Count = g.Count(),
                    AvgSalary = g.Avg(g.Value.Salary),
                    TotalSalary = g.Sum(g.Value.Salary)
                });

            // 按分类分组统计
            var categoryStats = await _freeSql.Select<TestEntity>()
                .GroupBy(x => x.Category)
                .ToListAsync(g => new
                {
                    Category = g.Key,
                    Count = g.Count(),
                    AvgScore = g.Avg(g.Value.Score)
                });

            // 按地区分组统计
            var regionStats = await _freeSql.Select<TestEntity>()
                .GroupBy(x => x.Region)
                .ToListAsync(g => new
                {
                    Region = g.Key,
                    Count = g.Count(),
                    AvgQuantity = g.Avg(g.Value.Quantity)
                });

            // 按状态分组统计
            var statusStats = await _freeSql.Select<TestEntity>()
                .GroupBy(x => x.Status)
                .ToListAsync(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                });

            monitor.Stop();

            result.RecordCount = deptStats.Count + categoryStats.Count + regionStats.Count + statusStats.Count;
            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(4); // 4个分组查询
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 百万级数据分组统计完成, 部门组数: {DeptCount}, 分类组数: {CatCount}, 地区组数: {RegionCount}, 状态组数: {StatusCount}",
                DatabaseName, deptStats.Count, categoryStats.Count, regionStats.Count, statusStats.Count);
            _logger.Information("[{Database}] 分组统计耗时: {Elapsed}ms, CPU: {CPU}%, 内存: {Memory}",
                DatabaseName, result.ElapsedMilliseconds, result.CpuUsagePercent, result.MemoryUsedFormatted);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 百万级数据分组统计失败", DatabaseName);
        }

        return result;
    }

    public async Task<BenchmarkResult> NoIndexQueryAsync(int queryCount)
    {
        var result = new BenchmarkResult
        {
            DatabaseName = DatabaseName,
            OperationType = "IndexQuery",
            OperationName = "NoIndex_FullScan",
            RecordCount = queryCount,
            TestTime = DateTime.Now
        };

        using var monitor = new PerformanceMonitor();

        try
        {
            _logger.Information("[{Database}] 开始无索引查询测试(全表扫描), 查询次数: {Count}", DatabaseName, queryCount);

            monitor.Start();

            for (int i = 0; i < queryCount; i++)
            {
                // 使用Description字段进行模糊查询，通常没有索引
                var keyword = $"user {_random.Next(0, 100000)}";
                await _freeSql.Select<TestEntity>()
                    .Where(x => x.Description.Contains(keyword))
                    .Limit(100)
                    .ToListAsync();
            }

            monitor.Stop();

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(queryCount);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

            _logger.Information("[{Database}] 无索引查询完成(全表扫描), 耗时: {Elapsed}ms, QPS: {OPS}", DatabaseName, result.ElapsedMilliseconds, result.OperationsPerSecond);
        }
        catch (Exception ex)
        {
            monitor.Stop();
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            _logger.Error(ex, "[{Database}] 无索引查询失败", DatabaseName);
        }

        return result;
    }

    public async Task CleanupMillionDataAsync()
    {
        _logger.Information("[{Database}] 清理百万级测试数据", DatabaseName);

        //await _freeSql.Delete<TestEntity>().Where("1=1").ExecuteAffrowsAsync();

        // 每次删除 1万
        const int batchSize = 10000;
        while (true)
        {
            var deleted = await _freeSql.Select<TestEntity>()
                .Where(a => true)  // 或者你的条件
                .Limit(batchSize)
                .ToDelete()
                .ExecuteAffrowsAsync();

            if (deleted == 0)
                break;
        }

        _logger.Information("[{Database}] 百万级测试数据清理完成", DatabaseName);
    }

    #endregion 百万级数据索引测试

    private TestEntity GenerateTestEntity(int index)
    {
        var guid = Guid.NewGuid().ToString("N");
        return new TestEntity
        {
            Name = $"User_{index}_{guid}".PadRight(50, '_').Substring(0, 50),
            Email = $"user{index}@example.com",
            Age = _random.Next(18, 65),
            Salary = Math.Round((decimal)(_random.NextDouble() * 100000 + 30000), 2),
            Department = _departments[_random.Next(_departments.Length)],
            IsActive = _random.Next(2) == 1,
            CreatedAt = DateTime.Now,
            Description = $"This is a test description for user {index}.Generated for benchmark testing purposes."
        };
    }

    private TestEntity GenerateTestEntityWithIndex(int index)
    {
        var guid = Guid.NewGuid().ToString("N");
        var now = DateTime.Now;
        return new TestEntity
        {
            Name = $"User_{index}_{guid}".PadRight(50, '_').Substring(0, 50),
            Email = $"user{index}@example.com",
            Age = _random.Next(18, 65),
            Salary = Math.Round((decimal)(_random.NextDouble() * 100000 + 30000), 2),
            Department = _departments[_random.Next(_departments.Length)],
            IsActive = _random.Next(2) == 1,
            CreatedAt = now.AddDays(-_random.Next(0, 365)),
            Description = $"This is a test description for user {index}. Generated for benchmark testing purposes.",
            Category = _categories[_random.Next(_categories.Length)],
            Status = _random.Next(0, 4),
            Score = Math.Round((decimal)(_random.NextDouble() * 100), 2),
            Region = _regions[_random.Next(_regions.Length)],
            Tags = _tagsList[_random.Next(_tagsList.Length)],
            Priority = _random.Next(1, 6),
            Quantity = _random.Next(1, 1000),
            ExpireAt = _random.Next(2) == 1 ? now.AddDays(_random.Next(1, 365)) : null
        };
    }
}