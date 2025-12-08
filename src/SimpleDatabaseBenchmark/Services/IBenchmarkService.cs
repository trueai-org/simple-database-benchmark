using SimpleDatabaseBenchmark.Models;

namespace SimpleDatabaseBenchmark.Services;

/// <summary>
/// 基准测试服务接口
/// </summary>
public interface IBenchmarkService
{
    /// <summary>
    /// 数据库名称
    /// </summary>
    string DatabaseName { get; }

    /// <summary>
    /// 初始化数据库
    /// </summary>
    Task InitializeAsync();

    /// <summary>
    /// 清理数据
    /// </summary>
    Task CleanupAsync();

    /// <summary>
    /// 单条插入测试
    /// </summary>
    Task<BenchmarkResult> SingleInsertAsync(int count);

    /// <summary>
    /// 单条查询测试
    /// </summary>
    Task<BenchmarkResult> SingleSelectAsync(int count);

    /// <summary>
    /// 单条更新测试
    /// </summary>
    Task<BenchmarkResult> SingleUpdateAsync(int count);

    /// <summary>
    /// 单条删除测试
    /// </summary>
    Task<BenchmarkResult> SingleDeleteAsync(int count);

    /// <summary>
    /// 批量插入测试
    /// </summary>
    Task<BenchmarkResult> BatchInsertAsync(int batchSize, int batchCount);

    /// <summary>
    /// 批量查询测试
    /// </summary>
    Task<BenchmarkResult> BatchSelectAsync(int batchSize, int batchCount);

    /// <summary>
    /// 批量更新测试
    /// </summary>
    Task<BenchmarkResult> BatchUpdateAsync(int batchSize, int batchCount);

    /// <summary>
    /// 批量删除测试
    /// </summary>
    Task<BenchmarkResult> BatchDeleteAsync(int batchSize, int batchCount);

    /// <summary>
    /// 统计汇总测试
    /// </summary>
    Task<BenchmarkResult> AggregationAsync();

    /// <summary>
    /// 分组汇总测试
    /// </summary>
    Task<BenchmarkResult> GroupAggregationAsync();

    /// <summary>
    /// 释放资源
    /// </summary>
    Task DisposeAsync();
}