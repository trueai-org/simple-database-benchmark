using SimpleDatabaseBenchmark.Models;
using SimpleDatabaseBenchmark.Utils;
using MongoDB.Driver;
using MongoDB.Bson;
using Serilog;

namespace SimpleDatabaseBenchmark.Services;

/// <summary>
/// MongoDB 基准测试服务
/// </summary>
public class MongoDbBenchmarkService : IBenchmarkService
{
    private readonly IMongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<MongoTestEntity> _collection;
    private readonly ILogger _logger;
    private readonly string[] _departments = { "Engineering", "Sales", "Marketing", "HR", "Finance", "IT", "Operations", "Legal" };
    private readonly Random _random = new();
    private long _sequenceId = 0;

    public string DatabaseName => "MongoDB";

    public MongoDbBenchmarkService(string connectionString)
    {
        _logger = Log.ForContext<MongoDbBenchmarkService>().ForContext("Database", DatabaseName);

        _client = new MongoClient(connectionString);
        _database = _client.GetDatabase("benchmark_test");
        _collection = _database.GetCollection<MongoTestEntity>("test_entity");

        _logger.Information("MongoDB 客户端已创建");
    }

    public async Task InitializeAsync()
    {
        _logger.Information("初始化数据库: {DatabaseName}", DatabaseName);

        // 删除集合重建
        await _database.DropCollectionAsync("test_entity");

        // 创建索引
        var indexKeys = Builders<MongoTestEntity>.IndexKeys
            .Ascending(x => x.SequenceId)
            .Ascending(x => x.Department);
        await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(indexKeys));

        _sequenceId = 0;
        _logger.Information("数据库初始化完成: {DatabaseName}", DatabaseName);
    }

    public async Task CleanupAsync()
    {
        _logger.Information("清理数据: {DatabaseName}", DatabaseName);
        await _collection.DeleteManyAsync(FilterDefinition<MongoTestEntity>.Empty);
        _sequenceId = 0;
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
                await _collection.InsertOneAsync(entity);
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

            var ids = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                .Limit(count)
                .Project(x => x.Id)
                .ToListAsync();

            monitor.Start();

            foreach (var id in ids)
            {
                await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
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

            var entities = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                .Limit(count)
                .ToListAsync();

            monitor.Start();

            foreach (var entity in entities)
            {
                var update = Builders<MongoTestEntity>.Update
                    .Set(x => x.Name, $"Updated_{entity.Name}")
                    .Set(x => x.UpdatedAt, DateTime.Now);

                await _collection.UpdateOneAsync(x => x.Id == entity.Id, update);
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

            var ids = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                .Limit(count)
                .Project(x => x.Id)
                .ToListAsync();

            monitor.Start();

            foreach (var id in ids)
            {
                await _collection.DeleteOneAsync(x => x.Id == id);
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

                await _collection.InsertManyAsync(entities);
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
                await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
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
                var entities = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                    .Skip(batch * batchSize)
                    .Limit(batchSize)
                    .ToListAsync();

                var updates = new List<WriteModel<MongoTestEntity>>();
                foreach (var entity in entities)
                {
                    var filter = Builders<MongoTestEntity>.Filter.Eq(x => x.Id, entity.Id);
                    var update = Builders<MongoTestEntity>.Update
                        .Set(x => x.Name, $"BatchUpdated_{entity.SequenceId}")
                        .Set(x => x.UpdatedAt, DateTime.Now);

                    updates.Add(new UpdateOneModel<MongoTestEntity>(filter, update));
                }

                if (updates.Any())
                {
                    await _collection.BulkWriteAsync(updates);
                }
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
                var ids = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                    .Limit(batchSize)
                    .Project(x => x.Id)
                    .ToListAsync();

                if (ids.Any())
                {
                    var filter = Builders<MongoTestEntity>.Filter.In(x => x.Id, ids);
                    await _collection.DeleteManyAsync(filter);
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

            // 使用聚合管道进行统计
            var aggregation = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", BsonNull.Value },
                    { "count", new BsonDocument("$sum", 1) },
                    { "totalSalary", new BsonDocument("$sum", "$salary") },
                    { "avgSalary", new BsonDocument("$avg", "$salary") },
                    { "maxSalary", new BsonDocument("$max", "$salary") },
                    { "minSalary", new BsonDocument("$min", "$salary") },
                    { "avgAge", new BsonDocument("$avg", "$age") }
                })
                .FirstOrDefaultAsync();

            monitor.Stop();

            if (aggregation != null)
            {
                var count = aggregation.GetValue("count", 0).ToInt32();
                var totalSalary = aggregation.GetValue("totalSalary", 0).ToDecimal();
                var avgSalary = aggregation.GetValue("avgSalary", 0).ToDecimal();
                var maxSalary = aggregation.GetValue("maxSalary", 0).ToDecimal();
                var minSalary = aggregation.GetValue("minSalary", 0).ToDecimal();
                var avgAge = aggregation.GetValue("avgAge", 0).ToDouble();

                result.RecordCount = count;

                _logger.Information("[{Database}] 统计汇总完成 - Count: {Count}, TotalSalary: {Total}, AvgSalary: {Avg}, MaxSalary: {Max}, MinSalary: {Min}, AvgAge: {Age}",
                    DatabaseName, count, totalSalary, avgSalary, maxSalary, minSalary, avgAge);
            }

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(1);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

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

            var groupResults = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", "$department" },
                    { "count", new BsonDocument("$sum", 1) },
                    { "totalSalary", new BsonDocument("$sum", "$salary") },
                    { "avgSalary", new BsonDocument("$avg", "$salary") },
                    { "avgAge", new BsonDocument("$avg", "$age") }
                })
                .ToListAsync();

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
                    DatabaseName, g.GetValue("_id", "Unknown").ToString(), g.GetValue("count", 0).ToInt32(), g.GetValue("avgSalary", 0).ToDecimal());
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
        _logger.Information("MongoDB 客户端已释放: {DatabaseName}", DatabaseName);
        return Task.CompletedTask;
    }

    private MongoTestEntity GenerateTestEntity(int index)
    {
        var seqId = Interlocked.Increment(ref _sequenceId);
        return new MongoTestEntity
        {
            SequenceId = seqId,
            Name = $"User_{index}_{Guid.NewGuid():N}"[..50],
            Email = $"user{index}@example.com",
            Age = _random.Next(18, 65),
            Salary = Math.Round((decimal)(_random.NextDouble() * 100000 + 30000), 2),
            Department = _departments[_random.Next(_departments.Length)],
            IsActive = _random.Next(2) == 1,
            CreatedAt = DateTime.Now,
            Description = $"This is a test description for user {index}.  Generated for benchmark testing purposes."
        };
    }
}