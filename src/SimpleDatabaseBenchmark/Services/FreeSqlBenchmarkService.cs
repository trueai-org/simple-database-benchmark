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

        // 清空数据
        await _freeSql.Delete<TestEntity>().Where("1=1").ExecuteAffrowsAsync();

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
}