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
            await _collection.DeleteManyAsync(FilterDefinition<MongoTestEntity>.Empty);
            _sequenceId = 0;

            monitor.Start();

            var batchCount = (totalCount + batchSize - 1) / batchSize;
            for (int batch = 0; batch < batchCount; batch++)
            {
                var currentBatchSize = Math.Min(batchSize, totalCount - batch * batchSize);
                var entities = Enumerable.Range(0, currentBatchSize)
                    .Select(i => GenerateTestEntityWithIndex(batch * batchSize + i))
                    .ToList();

                await _collection.InsertManyAsync(entities);

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

    public async Task CreateIndexesAsync()
    {
        _logger.Information("[{Database}] 开始创建索引", DatabaseName);

        try
        {
            // 单字段索引
            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Status)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Category)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Score)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.CreatedAt)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Salary)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Priority)));

            // 复合索引
            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys
                    .Ascending(x => x.Region)
                    .Ascending(x => x.Department)));

            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys
                    .Ascending(x => x.Status)
                    .Ascending(x => x.Category)
                    .Ascending(x => x.Priority)));

            // 名称索引用于前缀查询
            await _collection.Indexes.CreateOneAsync(new CreateIndexModel<MongoTestEntity>(
                Builders<MongoTestEntity>.IndexKeys.Ascending(x => x.Name)));

            _logger.Information("[{Database}] 索引创建完成", DatabaseName);
        }
        catch (Exception ex)
        {
            _logger.Warning("[{Database}] 创建索引警告: {Message}", DatabaseName, ex.Message);
        }
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

            var ids = await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                .Limit(queryCount)
                .Project(x => x.Id)
                .ToListAsync();

            monitor.Start();

            foreach (var id in ids)
            {
                await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
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
                await _collection.Find(x => x.Status == status).Limit(100).ToListAsync();
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
                await _collection.Find(x => x.Category == category).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Region, region),
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Department, dept));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Status, status),
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Category, category),
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Priority, priority));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Gte(x => x.Score, minScore),
                    Builders<MongoTestEntity>.Filter.Lte(x => x.Score, maxScore));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Gte(x => x.CreatedAt, startDate),
                    Builders<MongoTestEntity>.Filter.Lte(x => x.CreatedAt, endDate));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Gte(x => x.Salary, minSalary),
                    Builders<MongoTestEntity>.Filter.Lte(x => x.Salary, maxSalary));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                var filter = Builders<MongoTestEntity>.Filter.Regex(x => x.Name, new BsonRegularExpression($"^{prefix}"));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
                await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                    .Sort(Builders<MongoTestEntity>.Sort.Ascending(x => x.SequenceId))
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
                await _collection.Find(FilterDefinition<MongoTestEntity>.Empty)
                    .Sort(Builders<MongoTestEntity>.Sort
                        .Descending(x => x.Priority)
                        .Ascending(x => x.CreatedAt))
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

                var filter = Builders<MongoTestEntity>.Filter.And(
                    Builders<MongoTestEntity>.Filter.Eq(x => x.Status, status),
                    Builders<MongoTestEntity>.Filter.Or(
                        Builders<MongoTestEntity>.Filter.Eq(x => x.Category, category),
                        Builders<MongoTestEntity>.Filter.Eq(x => x.Region, region)),
                    Builders<MongoTestEntity>.Filter.Gte(x => x.Salary, minSalary),
                    Builders<MongoTestEntity>.Filter.Gte(x => x.CreatedAt, startDate),
                    Builders<MongoTestEntity>.Filter.Eq(x => x.IsActive, true));

                await _collection.Find(filter)
                    .Sort(Builders<MongoTestEntity>.Sort.Descending(x => x.Priority))
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

            var aggregation = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                        { "_id", BsonNull.Value },
                        { "count", new BsonDocument("$sum", 1) },
                        { "totalSalary", new BsonDocument("$sum", "$salary") },
                        { "avgSalary", new BsonDocument("$avg", "$salary") },
                        { "maxSalary", new BsonDocument("$max", "$salary") },
                        { "minSalary", new BsonDocument("$min", "$salary") },
                        { "totalScore", new BsonDocument("$sum", "$score") },
                        { "avgScore", new BsonDocument("$avg", "$score") },
                        { "avgQuantity", new BsonDocument("$avg", "$quantity") }
                })
                .FirstOrDefaultAsync();

            monitor.Stop();

            if (aggregation != null)
            {
                var count = aggregation.GetValue("count", 0).ToInt32();
                var avgSalary = aggregation.GetValue("avgSalary", 0).ToDecimal();
                var avgScore = aggregation.GetValue("avgScore", 0).ToDouble();

                result.RecordCount = count;

                _logger.Information("[{Database}] 百万级数据聚合完成 - Count: {Count}, AvgSalary: {AvgSalary}, AvgScore: {AvgScore}",
                    DatabaseName, count, avgSalary, avgScore);
            }

            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(8);
            result.CpuUsagePercent = monitor.CpuUsagePercent;
            result.MemoryUsedBytes = monitor.MemoryUsedBytes;
            result.MemoryUsedFormatted = monitor.MemoryUsedFormatted;
            result.IsSuccess = true;

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
            var deptStats = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                        { "_id", "$department" },
                        { "count", new BsonDocument("$sum", 1) },
                        { "avgSalary", new BsonDocument("$avg", "$salary") },
                        { "totalSalary", new BsonDocument("$sum", "$salary") }
                })
                .ToListAsync();

            // 按分类分组统计
            var categoryStats = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                        { "_id", "$category" },
                        { "count", new BsonDocument("$sum", 1) },
                        { "avgScore", new BsonDocument("$avg", "$score") }
                })
                .ToListAsync();

            // 按地区分组统计
            var regionStats = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                        { "_id", "$region" },
                        { "count", new BsonDocument("$sum", 1) },
                        { "avgQuantity", new BsonDocument("$avg", "$quantity") }
                })
                .ToListAsync();

            // 按状态分组统计
            var statusStats = await _collection.Aggregate()
                .Group(new BsonDocument
                {
                        { "_id", "$status" },
                        { "count", new BsonDocument("$sum", 1) }
                })
                .ToListAsync();

            monitor.Stop();

            result.RecordCount = deptStats.Count + categoryStats.Count + regionStats.Count + statusStats.Count;
            result.ElapsedMilliseconds = monitor.ElapsedMilliseconds;
            result.OperationsPerSecond = monitor.CalculateOperationsPerSecond(4);
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
                var keyword = $"user {_random.Next(0, 100000)}";
                var filter = Builders<MongoTestEntity>.Filter.Regex(x => x.Description, new BsonRegularExpression(keyword, "i"));
                await _collection.Find(filter).Limit(100).ToListAsync();
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
        await _collection.DeleteManyAsync(FilterDefinition<MongoTestEntity>.Empty);
        _sequenceId = 0;
        _logger.Information("[{Database}] 百万级测试数据清理完成", DatabaseName);
    }

    #endregion 百万级数据索引测试

    private MongoTestEntity GenerateTestEntity(int index)
    {
        var seqId = Interlocked.Increment(ref _sequenceId);
        var guid = Guid.NewGuid().ToString("N");
        return new MongoTestEntity
        {
            SequenceId = seqId,
            Name = $"User_{index}_{guid}".PadRight(50, '_').Substring(0, 50),
            Email = $"user{index}@example.com",
            Age = _random.Next(18, 65),
            Salary = Math.Round((decimal)(_random.NextDouble() * 100000 + 30000), 2),
            Department = _departments[_random.Next(_departments.Length)],
            IsActive = _random.Next(2) == 1,
            CreatedAt = DateTime.Now,
            Description = $"This is a test description for user {index}.  Generated for benchmark testing purposes."
        };
    }

    private MongoTestEntity GenerateTestEntityWithIndex(int index)
    {
        var seqId = Interlocked.Increment(ref _sequenceId);
        var guid = Guid.NewGuid().ToString("N");
        var now = DateTime.Now;
        return new MongoTestEntity
        {
            SequenceId = seqId,
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