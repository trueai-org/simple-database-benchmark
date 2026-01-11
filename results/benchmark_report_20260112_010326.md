# 数据库基准测试报告

**测试时间**: 2026-01-12 01:03:26

## 测试配置

| 配置项 | 值 |
|--------|-----|
| 单次操作记录数 | 1,000 |
| 批量操作批次大小 | 1,000 |
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
| 采集时间 | 2026-01-12 01:03:26 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MariaDB |
| 数据库数量 | 1 |
| 总测试用例数 | 16 |
| 成功用例数 | 16 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | 最快 |
|:---------|:---------|-------:|:-------|
| IndexQuery | ComplexCondition | 10090.00 | **MariaDB** |
| IndexQuery | CompositeIndex_RegionDept | 205.00 | **MariaDB** |
| IndexQuery | CompositeIndex_StatusCatPri | 209.00 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 5890.00 | **MariaDB** |
| IndexQuery | OrderBy | 10334.00 | **MariaDB** |
| IndexQuery | Pagination | 271.00 | **MariaDB** |
| IndexQuery | PrefixQuery_Name | 42570.00 | **MariaDB** |
| IndexQuery | PrimaryKey | 137.00 | **MariaDB** |
| IndexQuery | RangeQuery_Date | 206.00 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 219.00 | **MariaDB** |
| IndexQuery | RangeQuery_Score | 215.00 | **MariaDB** |
| IndexQuery | SingleIndex_Category | 199.00 | **MariaDB** |
| IndexQuery | SingleIndex_Status | 200.00 | **MariaDB** |
| MillionData | Aggregation | 476.00 | **MariaDB** |
| MillionData | GroupBy | 1798.00 | **MariaDB** |
| MillionData | PrepareData | 118265.00 | **MariaDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | 最快 |
|:---------|:---------|-------:|:-------|
| IndexQuery | ComplexCondition | 9.91 | **MariaDB** |
| IndexQuery | CompositeIndex_RegionDept | 487.80 | **MariaDB** |
| IndexQuery | CompositeIndex_StatusCatPri | 478.47 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 1.70 | **MariaDB** |
| IndexQuery | OrderBy | 9.68 | **MariaDB** |
| IndexQuery | Pagination | 369.00 | **MariaDB** |
| IndexQuery | PrefixQuery_Name | 2.35 | **MariaDB** |
| IndexQuery | PrimaryKey | 729.93 | **MariaDB** |
| IndexQuery | RangeQuery_Date | 485.44 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 456.62 | **MariaDB** |
| IndexQuery | RangeQuery_Score | 465.12 | **MariaDB** |
| IndexQuery | SingleIndex_Category | 502.51 | **MariaDB** |
| IndexQuery | SingleIndex_Status | 500.00 | **MariaDB** |
| MillionData | Aggregation | 16.81 | **MariaDB** |
| MillionData | GroupBy | 2.22 | **MariaDB** |
| MillionData | PrepareData | 8455.59 | **MariaDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| IndexQuery | ComplexCondition | 100 | 10,090 | 9.91 | 0.05 | 9.96 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 205 | 487.80 | 3.17 | 3.37 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 209 | 478.47 | 2.49 | 3.26 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,890 | 1.70 | 0.01 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 10,334 | 9.68 | 0.04 | 488 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 271 | 369.00 | 0.48 | 3.15 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 42,570 | 2.35 | 0.03 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 137 | 729.93 | 2.85 | 5.23 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 206 | 485.44 | 1.89 | 32 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 219 | 456.62 | 2.08 | 3.51 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 215 | 465.12 | 3.33 | 3.45 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 199 | 502.51 | 2.61 | 4.32 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 200 | 500.00 | 2.28 | 480 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 476 | 16.81 | 0.55 | 1012 KB | ✅ |
| MillionData | GroupBy | 32 | 1,798 | 2.22 | 0.22 | 3.18 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 118,265 | 8455.59 | 2.58 | 24.66 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB |
|:---------|:---------|-------:|
| IndexQuery | ComplexCondition | 0.05 |
| IndexQuery | CompositeIndex_RegionDept | 3.17 |
| IndexQuery | CompositeIndex_StatusCatPri | 2.49 |
| IndexQuery | NoIndex_FullScan | 0.01 |
| IndexQuery | OrderBy | 0.04 |
| IndexQuery | Pagination | 0.48 |
| IndexQuery | PrefixQuery_Name | 0.03 |
| IndexQuery | PrimaryKey | 2.85 |
| IndexQuery | RangeQuery_Date | 1.89 |
| IndexQuery | RangeQuery_Salary | 2.08 |
| IndexQuery | RangeQuery_Score | 3.33 |
| IndexQuery | SingleIndex_Category | 2.61 |
| IndexQuery | SingleIndex_Status | 2.28 |
| MillionData | Aggregation | 0.55 |
| MillionData | GroupBy | 0.22 |
| MillionData | PrepareData | 2.58 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB |
|:---------|:---------|-----------:|
| IndexQuery | ComplexCondition | 9.96 MB |
| IndexQuery | CompositeIndex_RegionDept | 3.37 MB |
| IndexQuery | CompositeIndex_StatusCatPri | 3.26 MB |
| IndexQuery | NoIndex_FullScan | 0 B |
| IndexQuery | OrderBy | 488 KB |
| IndexQuery | Pagination | 3.15 MB |
| IndexQuery | PrefixQuery_Name | 0 B |
| IndexQuery | PrimaryKey | 5.23 MB |
| IndexQuery | RangeQuery_Date | 32 KB |
| IndexQuery | RangeQuery_Salary | 3.51 MB |
| IndexQuery | RangeQuery_Score | 3.45 MB |
| IndexQuery | SingleIndex_Category | 4.32 MB |
| IndexQuery | SingleIndex_Status | 480 KB |
| MillionData | Aggregation | 1012 KB |
| MillionData | GroupBy | 3.18 MB |
| MillionData | PrepareData | 24.66 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 01:03:27*
