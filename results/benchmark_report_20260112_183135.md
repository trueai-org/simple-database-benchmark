# 数据库基准测试报告

**测试时间**: 2026-01-12 18:31:35

## 测试配置

| 配置项 | 值 |
|--------|-----|
| 单次操作记录数 | 1,000 |
| 批量操作批次大小 | 100 |
| 批量操作批次数 | 5 |
| 预热迭代次数 | 3 |
| 测试迭代次数 | 5 |

## 服务器信息

| 项目 | 值 |
|------|-----|
| 机器名称 | DESKTOP-RLEON3G |
| 操作系统 | Microsoft Windows 10.0.19045 |
| OS 架构 | X64 |
| 进程架构 | X64 |
| 处理器数量 | 24 |
| .NET 版本 | .NET 8.0.22 |
| 总内存 | 31.81 GB |
| 采集时间 | 2026-01-12 18:31:35 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | Oracle |
| 数据库数量 | 1 |
| 总测试用例数 | 17 |
| 成功用例数 | 17 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| IndexQuery | ComplexCondition | 818.00 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 263.00 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 210.00 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 152.00 | **Oracle** |
| IndexQuery | OrderBy | 1486.00 | **Oracle** |
| IndexQuery | Pagination | 1857.00 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 1480.00 | **Oracle** |
| IndexQuery | PrimaryKey | 128.00 | **Oracle** |
| IndexQuery | RangeQuery_Date | 450.00 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 286.00 | **Oracle** |
| IndexQuery | RangeQuery_Score | 317.00 | **Oracle** |
| IndexQuery | SingleIndex_Category | 155.00 | **Oracle** |
| IndexQuery | SingleIndex_Status | 172.00 | **Oracle** |
| MillionData | Aggregation | 45.00 | **Oracle** |
| MillionData | Cleanup | 2279.00 | **Oracle** |
| MillionData | GroupBy | 61.00 | **Oracle** |
| MillionData | PrepareData | 10300.00 | **Oracle** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| IndexQuery | ComplexCondition | 122.25 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 380.23 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 476.19 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 65.79 | **Oracle** |
| IndexQuery | OrderBy | 67.29 | **Oracle** |
| IndexQuery | Pagination | 53.85 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 67.57 | **Oracle** |
| IndexQuery | PrimaryKey | 781.25 | **Oracle** |
| IndexQuery | RangeQuery_Date | 222.22 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 349.65 | **Oracle** |
| IndexQuery | RangeQuery_Score | 315.46 | **Oracle** |
| IndexQuery | SingleIndex_Category | 645.16 | **Oracle** |
| IndexQuery | SingleIndex_Status | 581.40 | **Oracle** |
| MillionData | Aggregation | 177.78 | **Oracle** |
| MillionData | Cleanup | 4387.89 | **Oracle** |
| MillionData | GroupBy | 65.57 | **Oracle** |
| MillionData | PrepareData | 970.87 | **Oracle** |

## 各数据库详细结果

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| IndexQuery | ComplexCondition | 100 | 818 | 122.25 | 0.80 | 1.18 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 263 | 380.23 | 2.97 | 432 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 210 | 476.19 | 1.24 | 136 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 152 | 65.79 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 1,486 | 67.29 | 0.26 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 1,857 | 53.85 | 0.18 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 1,480 | 67.57 | 0.13 | 92 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 128 | 781.25 | 2.52 | 668 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 450 | 222.22 | 2.02 | 812 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 286 | 349.65 | 4.54 | 1.45 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 317 | 315.46 | 1.85 | 12 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 155 | 645.16 | 4.60 | 676 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 172 | 581.40 | 3.78 | 4.91 MB | ✅ |
| MillionData | Aggregation | 10,000 | 45 | 177.78 | 1.43 | 532 KB | ✅ |
| MillionData | Cleanup | 10,000 | 2,279 | 4387.89 | 0.17 | 624 KB | ✅ |
| MillionData | GroupBy | 32 | 61 | 65.57 | 1.07 | 1.85 MB | ✅ |
| MillionData | PrepareData | 10,000 | 10,300 | 970.87 | 0.29 | 11.45 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-------:|
| IndexQuery | ComplexCondition | 0.80 |
| IndexQuery | CompositeIndex_RegionDept | 2.97 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.24 |
| IndexQuery | NoIndex_FullScan | 0.00 |
| IndexQuery | OrderBy | 0.26 |
| IndexQuery | Pagination | 0.18 |
| IndexQuery | PrefixQuery_Name | 0.13 |
| IndexQuery | PrimaryKey | 2.52 |
| IndexQuery | RangeQuery_Date | 2.02 |
| IndexQuery | RangeQuery_Salary | 4.54 |
| IndexQuery | RangeQuery_Score | 1.85 |
| IndexQuery | SingleIndex_Category | 4.60 |
| IndexQuery | SingleIndex_Status | 3.78 |
| MillionData | Aggregation | 1.43 |
| MillionData | Cleanup | 0.17 |
| MillionData | GroupBy | 1.07 |
| MillionData | PrepareData | 0.29 |

## 内存消耗对比

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-----------:|
| IndexQuery | ComplexCondition | 1.18 MB |
| IndexQuery | CompositeIndex_RegionDept | 432 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 136 KB |
| IndexQuery | NoIndex_FullScan | 0 B |
| IndexQuery | OrderBy | 0 B |
| IndexQuery | Pagination | 0 B |
| IndexQuery | PrefixQuery_Name | 92 KB |
| IndexQuery | PrimaryKey | 668 KB |
| IndexQuery | RangeQuery_Date | 812 KB |
| IndexQuery | RangeQuery_Salary | 1.45 MB |
| IndexQuery | RangeQuery_Score | 12 KB |
| IndexQuery | SingleIndex_Category | 676 KB |
| IndexQuery | SingleIndex_Status | 4.91 MB |
| MillionData | Aggregation | 532 KB |
| MillionData | Cleanup | 624 KB |
| MillionData | GroupBy | 1.85 MB |
| MillionData | PrepareData | 11.45 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 18:31:35*
