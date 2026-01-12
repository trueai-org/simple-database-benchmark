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

    #region 百万级数据索引测试

    /// <summary>
    /// 准备百万级测试数据
    /// </summary>
    /// <param name="totalCount">总记录数</param>
    /// <param name="batchSize">每批次插入数量</param>
    Task<BenchmarkResult> PrepareMillionDataAsync(int totalCount, int batchSize);

    /// <summary>
    /// 创建索引（不计入性能统计）
    /// </summary>
    Task CreateIndexesAsync();

    /// <summary>
    /// 主键查询测试 (使用索引)
    /// </summary>
    Task<BenchmarkResult> IndexQueryByPrimaryKeyAsync(int queryCount);

    /// <summary>
    /// 单字段索引查询测试 - 按状态查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByStatusAsync(int queryCount);

    /// <summary>
    /// 单字段索引查询测试 - 按分类查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByCategoryAsync(int queryCount);

    /// <summary>
    /// 复合索引查询测试 - 按地区+部门查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByRegionAndDepartmentAsync(int queryCount);

    /// <summary>
    /// 复合索引查询测试 - 按状态+分类+优先级查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByStatusCategoryPriorityAsync(int queryCount);

    /// <summary>
    /// 范围查询测试 - 按评分范围查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByScoreRangeAsync(int queryCount);

    /// <summary>
    /// 范围查询测试 - 按创建时间范围查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByDateRangeAsync(int queryCount);

    /// <summary>
    /// 范围查询测试 - 按薪资范围查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryBySalaryRangeAsync(int queryCount);

    /// <summary>
    /// 模糊查询测试 - 按名称前缀查询
    /// </summary>
    Task<BenchmarkResult> IndexQueryByNamePrefixAsync(int queryCount);

    /// <summary>
    /// 分页查询测试 - 带排序的分页
    /// </summary>
    Task<BenchmarkResult> IndexQueryWithPaginationAsync(int pageSize, int pageCount);

    /// <summary>
    /// 排序查询测试 - 多字段排序
    /// </summary>
    Task<BenchmarkResult> IndexQueryWithOrderByAsync(int queryCount);

    /// <summary>
    /// 复杂条件组合查询测试
    /// </summary>
    Task<BenchmarkResult> IndexQueryComplexConditionAsync(int queryCount);

    /// <summary>
    /// 百万级数据聚合测试
    /// </summary>
    Task<BenchmarkResult> MillionDataAggregationAsync();

    /// <summary>
    /// 百万级数据分组统计测试
    /// </summary>
    Task<BenchmarkResult> MillionDataGroupByAsync();

    /// <summary>
    /// 无索引查询对比测试 - 全表扫描
    /// </summary>
    Task<BenchmarkResult> NoIndexQueryAsync(int queryCount);

    /// <summary>
    /// 清理百万级测试数据
    /// </summary>
    Task<BenchmarkResult> CleanupMillionDataAsync();

    #endregion 百万级数据索引测试

    /// <summary>
    /// 释放资源
    /// </summary>
    Task DisposeAsync();
}