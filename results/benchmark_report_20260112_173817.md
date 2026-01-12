# 数据库基准测试报告

**测试时间**: 2026-01-12 17:38:17

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
| 采集时间 | 2026-01-12 17:38:17 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | Oracle |
| 数据库数量 | 1 |
| 总测试用例数 | 67 |
| 成功用例数 | 60 |
| 失败用例数 | 7 |
| 成功率 | 89.55% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | Statistics | 50.60 | **Oracle** |
| Batch | Delete | 864.00 | **Oracle** |
| Batch | Insert | 4715.40 | **Oracle** |
| Batch | Select | 42.40 | **Oracle** |
| Batch | Update | 4653.60 | **Oracle** |
| IndexQuery | ComplexCondition | 539.00 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 172.00 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 138.00 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 134.00 | **Oracle** |
| IndexQuery | OrderBy | 1113.00 | **Oracle** |
| IndexQuery | Pagination | 157.00 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 1277.00 | **Oracle** |
| IndexQuery | RangeQuery_Date | 308.00 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 158.00 | **Oracle** |
| IndexQuery | RangeQuery_Score | 164.00 | **Oracle** |
| IndexQuery | SingleIndex_Category | 98.00 | **Oracle** |
| IndexQuery | SingleIndex_Status | 85.00 | **Oracle** |
| MillionData | Aggregation | 34.00 | **Oracle** |
| MillionData | Cleanup | 3.00 | **Oracle** |
| MillionData | GroupBy | 44.00 | **Oracle** |
| Single | Delete | 1750.80 | **Oracle** |
| Single | Insert | 1246.60 | **Oracle** |
| Single | Select | 1027.20 | **Oracle** |
| Single | Update | 1751.40 | **Oracle** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | Statistics | 197.27 | **Oracle** |
| Batch | Delete | 8174.40 | **Oracle** |
| Batch | Insert | 1061.61 | **Oracle** |
| Batch | Select | 118330.62 | **Oracle** |
| Batch | Update | 1075.23 | **Oracle** |
| IndexQuery | ComplexCondition | 185.53 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 581.40 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 724.64 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 74.63 | **Oracle** |
| IndexQuery | OrderBy | 89.85 | **Oracle** |
| IndexQuery | Pagination | 636.94 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 78.31 | **Oracle** |
| IndexQuery | RangeQuery_Date | 324.68 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 632.91 | **Oracle** |
| IndexQuery | RangeQuery_Score | 609.76 | **Oracle** |
| IndexQuery | SingleIndex_Category | 1020.41 | **Oracle** |
| IndexQuery | SingleIndex_Status | 1176.47 | **Oracle** |
| MillionData | Aggregation | 235.29 | **Oracle** |
| MillionData | Cleanup | 0.00 | **Oracle** |
| MillionData | GroupBy | 90.91 | **Oracle** |
| Single | Delete | 578.15 | **Oracle** |
| Single | Insert | 804.14 | **Oracle** |
| Single | Select | 973.67 | **Oracle** |
| Single | Update | 571.29 | **Oracle** |

## 各数据库详细结果

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | Statistics | 5,000 | 48 | 125.00 | 2.69 | 764 KB | ✅ |
| Aggregation | Statistics | 5,000 | 139 | 43.17 | 1.87 | 5.28 MB | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 2.88 | 52 KB | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 1,633 | 3061.85 | 0.24 | 5.03 MB | ✅ |
| Batch | Delete | 5,000 | 264 | 18939.39 | 0.98 | 588 KB | ✅ |
| Batch | Delete | 5,000 | 899 | 5561.74 | 0.14 | 3.22 MB | ✅ |
| Batch | Delete | 5,000 | 672 | 7440.48 | 0.00 | 3.24 MB | ✅ |
| Batch | Delete | 5,000 | 852 | 5868.54 | 0.08 | 3.09 MB | ✅ |
| Batch | Insert | 5,000 | 4,878 | 1025.01 | 0.20 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,626 | 1080.85 | 0.10 | 9.05 MB | ✅ |
| Batch | Insert | 5,000 | 4,927 | 1014.82 | 0.24 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,649 | 1075.50 | 0.21 | 7.04 MB | ✅ |
| Batch | Insert | 5,000 | 4,497 | 1111.85 | 0.19 | 6.86 MB | ✅ |
| Batch | Select | 5,000 | 43 | 116279.07 | 5.99 | 12 KB | ✅ |
| Batch | Select | 5,000 | 44 | 113636.36 | 0.00 | 8 KB | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 3.05 | 0 B | ✅ |
| Batch | Select | 5,000 | 38 | 131578.95 | 1.68 | 0 B | ✅ |
| Batch | Select | 5,000 | 45 | 111111.11 | 4.30 | 1 MB | ✅ |
| Batch | Update | 5,000 | 4,678 | 1068.83 | 0.17 | 16.21 MB | ✅ |
| Batch | Update | 5,000 | 4,880 | 1024.59 | 0.20 | 15.16 MB | ✅ |
| Batch | Update | 5,000 | 4,501 | 1110.86 | 0.20 | 12.77 MB | ✅ |
| Batch | Update | 5,000 | 4,636 | 1078.52 | 0.18 | 11.02 MB | ✅ |
| Batch | Update | 5,000 | 4,573 | 1093.37 | 0.26 | 10.37 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 539 | 185.53 | 0.84 | 4.12 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 172 | 581.40 | 0.00 | 16 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 138 | 724.64 | 2.35 | 136 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 134 | 74.63 | 0.97 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 1,113 | 89.85 | 0.23 | 48 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 157 | 636.94 | 2.48 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 1,277 | 78.31 | 0.31 | 136 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 0 | N/A | N/A | N/A | ❌ |
| IndexQuery | RangeQuery_Date | 100 | 308 | 324.68 | 0.21 | 248 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 158 | 632.91 | 0.41 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 164 | 609.76 | 0.00 | 12 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 98 | 1020.41 | 0.00 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 85 | 1176.47 | 0.00 | 12 KB | ✅ |
| MillionData | Aggregation | 0 | 34 | 235.29 | 0.00 | 28 KB | ✅ |
| MillionData | Cleanup | 0 | 3 | 0.00 | 0.00 | 20 KB | ✅ |
| MillionData | GroupBy | 0 | 44 | 90.91 | 0.00 | 32 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Delete | 1,000 | 1,934 | 517.06 | 0.47 | 120 KB | ✅ |
| Single | Delete | 1,000 | 2,043 | 489.48 | 0.22 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,578 | 633.71 | 0.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,586 | 630.52 | 0.41 | 168 KB | ✅ |
| Single | Delete | 1,000 | 1,613 | 619.96 | 0.20 | 172 KB | ✅ |
| Single | Insert | 1,000 | 1,288 | 776.40 | 1.82 | 18.7 MB | ✅ |
| Single | Insert | 1,000 | 1,339 | 746.83 | 0.49 | 17.46 MB | ✅ |
| Single | Insert | 1,000 | 1,178 | 848.90 | 0.72 | 28 KB | ✅ |
| Single | Insert | 1,000 | 1,246 | 802.57 | 0.68 | 17.55 MB | ✅ |
| Single | Insert | 1,000 | 1,182 | 846.02 | 1.16 | 17.55 MB | ✅ |
| Single | Select | 1,000 | 1,036 | 965.25 | 1.70 | 5.43 MB | ✅ |
| Single | Select | 1,000 | 1,018 | 982.32 | 0.51 | 3.18 MB | ✅ |
| Single | Select | 1,000 | 1,044 | 957.85 | 0.81 | 4 KB | ✅ |
| Single | Select | 1,000 | 1,030 | 970.87 | 1.58 | 2.34 MB | ✅ |
| Single | Select | 1,000 | 1,008 | 992.06 | 1.29 | 2.33 MB | ✅ |
| Single | Update | 1,000 | 1,822 | 548.85 | 0.89 | 0 B | ✅ |
| Single | Update | 1,000 | 1,754 | 570.13 | 0.63 | 1.6 MB | ✅ |
| Single | Update | 1,000 | 1,704 | 586.85 | 0.69 | 0 B | ✅ |
| Single | Update | 1,000 | 1,716 | 582.75 | 0.76 | 1.01 MB | ✅ |
| Single | Update | 1,000 | 1,761 | 567.86 | 0.74 | 1020 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-------:|
| Aggregation | Statistics | 1.49 |
| Batch | Delete | 0.29 |
| Batch | Insert | 0.19 |
| Batch | Select | 3.00 |
| Batch | Update | 0.20 |
| IndexQuery | ComplexCondition | 0.84 |
| IndexQuery | CompositeIndex_RegionDept | 0.00 |
| IndexQuery | CompositeIndex_StatusCatPri | 2.35 |
| IndexQuery | NoIndex_FullScan | 0.97 |
| IndexQuery | OrderBy | 0.23 |
| IndexQuery | Pagination | 2.48 |
| IndexQuery | PrefixQuery_Name | 0.31 |
| IndexQuery | RangeQuery_Date | 0.21 |
| IndexQuery | RangeQuery_Salary | 0.41 |
| IndexQuery | RangeQuery_Score | 0.00 |
| IndexQuery | SingleIndex_Category | 0.00 |
| IndexQuery | SingleIndex_Status | 0.00 |
| MillionData | Aggregation | 0.00 |
| MillionData | Cleanup | 0.00 |
| MillionData | GroupBy | 0.00 |
| Single | Delete | 0.35 |
| Single | Insert | 0.97 |
| Single | Select | 1.18 |
| Single | Update | 0.74 |

## 内存消耗对比

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-----------:|
| Aggregation | Statistics | 5.28 MB |
| Batch | Delete | 5.03 MB |
| Batch | Insert | 9.05 MB |
| Batch | Select | 1 MB |
| Batch | Update | 16.21 MB |
| IndexQuery | ComplexCondition | 4.12 MB |
| IndexQuery | CompositeIndex_RegionDept | 16 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 136 KB |
| IndexQuery | NoIndex_FullScan | 0 B |
| IndexQuery | OrderBy | 48 KB |
| IndexQuery | Pagination | 0 B |
| IndexQuery | PrefixQuery_Name | 136 KB |
| IndexQuery | RangeQuery_Date | 248 KB |
| IndexQuery | RangeQuery_Salary | 0 B |
| IndexQuery | RangeQuery_Score | 12 KB |
| IndexQuery | SingleIndex_Category | 8 KB |
| IndexQuery | SingleIndex_Status | 12 KB |
| MillionData | Aggregation | 28 KB |
| MillionData | Cleanup | 20 KB |
| MillionData | GroupBy | 32 KB |
| Single | Delete | 172 KB |
| Single | Insert | 18.7 MB |
| Single | Select | 5.43 MB |
| Single | Update | 1.6 MB |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| Oracle | Aggregation | GroupBy | 17:33:41 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:37:24 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:37:39 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:37:55 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:38:11 | Specified cast is not valid. |
| Oracle | MillionData | PrepareData | 17:38:12 | ORA-39826: 无法解析视图或同义词 (BENCHMARK.TEST_ENTITY) 的直接路径加载。 https://docs.oracle.com/error-help/db/ora-398... |
| Oracle | IndexQuery | PrimaryKey | 17:38:12 | 'minValue' cannot be greater than maxValue. (Parameter 'minValue') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 17:38:17*
