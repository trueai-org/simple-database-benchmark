using FreeSql.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleDatabaseBenchmark.Models;

/// <summary>
/// FreeSql 测试实体
/// </summary>
[Table(Name = "test_entity")]
public class TestEntity
{
    [Column(IsIdentity = true, IsPrimary = true)]
    public long Id { get; set; }

    [Column(StringLength = 100)]
    public string Name { get; set; } = string.Empty;

    [Column(StringLength = 200)]
    public string Email { get; set; } = string.Empty;

    public int Age { get; set; }

    [Column(Precision = 18, Scale = 2)]
    public decimal Salary { get; set; }

    [Column(StringLength = 50)]
    public string Department { get; set; } = string.Empty;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    [Column(StringLength = 500)]
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// MongoDB 测试实体
/// </summary>
public class MongoTestEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("sequenceId")]
    public long SequenceId { get; set; }

    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("email")]
    public string Email { get; set; } = string.Empty;

    [BsonElement("age")]
    public int Age { get; set; }

    [BsonElement("salary")]
    public decimal Salary { get; set; }

    [BsonElement("department")]
    public string Department { get; set; } = string.Empty;

    [BsonElement("isActive")]
    public bool IsActive { get; set; }

    [BsonElement("createdAt")]
    public DateTime CreatedAt { get; set; }

    [BsonElement("updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    [BsonElement("description")]
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// 测试结果
/// </summary>
public class BenchmarkResult
{
    public string DatabaseName { get; set; } = string.Empty;
    public string OperationType { get; set; } = string.Empty;
    public string OperationName { get; set; } = string.Empty;
    public int RecordCount { get; set; }
    public long ElapsedMilliseconds { get; set; }
    public double OperationsPerSecond { get; set; }
    public double CpuUsagePercent { get; set; }
    public long MemoryUsedBytes { get; set; }
    public string MemoryUsedFormatted { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime TestTime { get; set; }
}

/// <summary>
/// 统计汇总结果
/// </summary>
public class AggregationResult
{
    public int TotalCount { get; set; }
    public decimal TotalSalary { get; set; }
    public decimal AvgSalary { get; set; }
    public decimal MaxSalary { get; set; }
    public decimal MinSalary { get; set; }
    public int AvgAge { get; set; }
}

/// <summary>
/// 分组汇总结果
/// </summary>
public class GroupAggregationResult
{
    public string Department { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal TotalSalary { get; set; }
    public decimal AvgSalary { get; set; }
    public int AvgAge { get; set; }
}