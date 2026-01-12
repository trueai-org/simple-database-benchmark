# 数据库基准测试报告

**测试时间**: 2026-01-12 17:40:51

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
| 采集时间 | 2026-01-12 17:40:51 |


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
| Aggregation | Statistics | 29.60 | **Oracle** |
| Batch | Delete | 704.40 | **Oracle** |
| Batch | Insert | 4650.80 | **Oracle** |
| Batch | Select | 43.80 | **Oracle** |
| Batch | Update | 4659.60 | **Oracle** |
| IndexQuery | ComplexCondition | 527.00 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 112.00 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 229.00 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 124.00 | **Oracle** |
| IndexQuery | OrderBy | 1393.00 | **Oracle** |
| IndexQuery | Pagination | 184.00 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 1482.00 | **Oracle** |
| IndexQuery | RangeQuery_Date | 289.00 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 158.00 | **Oracle** |
| IndexQuery | RangeQuery_Score | 161.00 | **Oracle** |
| IndexQuery | SingleIndex_Category | 59.00 | **Oracle** |
| IndexQuery | SingleIndex_Status | 63.00 | **Oracle** |
| MillionData | Aggregation | 26.00 | **Oracle** |
| MillionData | Cleanup | 7.00 | **Oracle** |
| MillionData | GroupBy | 36.00 | **Oracle** |
| Single | Delete | 1721.40 | **Oracle** |
| Single | Insert | 1384.20 | **Oracle** |
| Single | Select | 1007.00 | **Oracle** |
| Single | Update | 2122.00 | **Oracle** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | Statistics | 240.45 | **Oracle** |
| Batch | Delete | 7474.96 | **Oracle** |
| Batch | Insert | 1077.47 | **Oracle** |
| Batch | Select | 115192.95 | **Oracle** |
| Batch | Update | 1075.43 | **Oracle** |
| IndexQuery | ComplexCondition | 189.75 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 892.86 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 436.68 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 80.65 | **Oracle** |
| IndexQuery | OrderBy | 71.79 | **Oracle** |
| IndexQuery | Pagination | 543.48 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 67.48 | **Oracle** |
| IndexQuery | RangeQuery_Date | 346.02 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 632.91 | **Oracle** |
| IndexQuery | RangeQuery_Score | 621.12 | **Oracle** |
| IndexQuery | SingleIndex_Category | 1694.92 | **Oracle** |
| IndexQuery | SingleIndex_Status | 1587.30 | **Oracle** |
| MillionData | Aggregation | 307.69 | **Oracle** |
| MillionData | Cleanup | 0.00 | **Oracle** |
| MillionData | GroupBy | 111.11 | **Oracle** |
| Single | Delete | 587.47 | **Oracle** |
| Single | Insert | 725.34 | **Oracle** |
| Single | Select | 993.95 | **Oracle** |
| Single | Update | 517.07 | **Oracle** |

## 各数据库详细结果

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | GroupBy | 0 | 0 | N/A | N/A | N/A | ❌ |
| Aggregation | Statistics | 5,000 | 61 | 98.36 | 2.10 | 1.05 MB | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 21 | 285.71 | 2.96 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 2.92 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 2.85 | 0 B | ✅ |
| Batch | Delete | 5,000 | 868 | 5760.37 | 0.37 | 4.4 MB | ✅ |
| Batch | Delete | 5,000 | 765 | 6535.95 | 0.17 | 3.38 MB | ✅ |
| Batch | Delete | 5,000 | 450 | 11111.11 | 0.14 | 3.99 MB | ✅ |
| Batch | Delete | 5,000 | 770 | 6493.51 | 0.08 | 3.36 MB | ✅ |
| Batch | Delete | 5,000 | 669 | 7473.84 | 0.10 | 3.1 MB | ✅ |
| Batch | Insert | 5,000 | 5,060 | 988.14 | 0.18 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,499 | 1111.36 | 0.17 | 9.06 MB | ✅ |
| Batch | Insert | 5,000 | 4,546 | 1099.87 | 0.17 | 5.25 MB | ✅ |
| Batch | Insert | 5,000 | 4,711 | 1061.35 | 0.15 | 5.35 MB | ✅ |
| Batch | Insert | 5,000 | 4,438 | 1126.63 | 0.29 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 52 | 96153.85 | 2.50 | 32 KB | ✅ |
| Batch | Select | 5,000 | 43 | 116279.07 | 2.99 | 0 B | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 1.54 | 184 KB | ✅ |
| Batch | Select | 5,000 | 43 | 116279.07 | 1.49 | 44 KB | ✅ |
| Batch | Select | 5,000 | 39 | 128205.13 | 1.63 | 0 B | ✅ |
| Batch | Update | 5,000 | 4,781 | 1045.81 | 0.25 | 14.91 MB | ✅ |
| Batch | Update | 5,000 | 4,525 | 1104.97 | 0.20 | 15.18 MB | ✅ |
| Batch | Update | 5,000 | 5,041 | 991.87 | 0.17 | 14.15 MB | ✅ |
| Batch | Update | 5,000 | 4,506 | 1109.63 | 0.25 | 14.29 MB | ✅ |
| Batch | Update | 5,000 | 4,445 | 1124.86 | 0.13 | 14.61 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 527 | 189.75 | 0.25 | 52 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 112 | 892.86 | 1.16 | 12 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 229 | 436.68 | 1.13 | 288 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 124 | 80.65 | 0.00 | 2.25 MB | ✅ |
| IndexQuery | OrderBy | 100 | 1,393 | 71.79 | 0.14 | 64 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 184 | 543.48 | 0.35 | 12 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 1,482 | 67.48 | 0.18 | 3.54 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 0 | N/A | N/A | N/A | ❌ |
| IndexQuery | RangeQuery_Date | 100 | 289 | 346.02 | 0.90 | 100 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 158 | 632.91 | 0.00 | 4 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 161 | 621.12 | 0.00 | 20 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 59 | 1694.92 | 0.00 | 4 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 63 | 1587.30 | 2.04 | 8 KB | ✅ |
| MillionData | Aggregation | 0 | 26 | 307.69 | 0.00 | 32 KB | ✅ |
| MillionData | Cleanup | 0 | 7 | 0.00 | 9.01 | 16 KB | ✅ |
| MillionData | GroupBy | 0 | 36 | 111.11 | 0.00 | 84 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Delete | 1,000 | 1,679 | 595.59 | 0.31 | 88 KB | ✅ |
| Single | Delete | 1,000 | 1,980 | 505.05 | 0.59 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,887 | 529.94 | 0.28 | 120 KB | ✅ |
| Single | Delete | 1,000 | 1,529 | 654.02 | 0.94 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,532 | 652.74 | 0.64 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,246 | 802.57 | 2.25 | 19.02 MB | ✅ |
| Single | Insert | 1,000 | 1,374 | 727.80 | 0.62 | 18.33 MB | ✅ |
| Single | Insert | 1,000 | 1,496 | 668.45 | 0.70 | 17 MB | ✅ |
| Single | Insert | 1,000 | 1,352 | 739.64 | 0.67 | 17.56 MB | ✅ |
| Single | Insert | 1,000 | 1,453 | 688.23 | 0.85 | 17.55 MB | ✅ |
| Single | Select | 1,000 | 1,061 | 942.51 | 2.39 | 5.78 MB | ✅ |
| Single | Select | 1,000 | 983 | 1017.29 | 1.26 | 3.64 MB | ✅ |
| Single | Select | 1,000 | 1,013 | 987.17 | 1.28 | 2.31 MB | ✅ |
| Single | Select | 1,000 | 1,005 | 995.02 | 0.97 | 2.33 MB | ✅ |
| Single | Select | 1,000 | 973 | 1027.75 | 0.80 | 824 KB | ✅ |
| Single | Update | 1,000 | 1,819 | 549.75 | 1.22 | 0 B | ✅ |
| Single | Update | 1,000 | 1,685 | 593.47 | 0.66 | 0 B | ✅ |
| Single | Update | 1,000 | 1,729 | 578.37 | 0.87 | 0 B | ✅ |
| Single | Update | 1,000 | 1,687 | 592.77 | 0.42 | 0 B | ✅ |
| Single | Update | 1,000 | 3,690 | 271.00 | 0.26 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-------:|
| Aggregation | Statistics | 2.17 |
| Batch | Delete | 0.17 |
| Batch | Insert | 0.19 |
| Batch | Select | 2.03 |
| Batch | Update | 0.20 |
| IndexQuery | ComplexCondition | 0.25 |
| IndexQuery | CompositeIndex_RegionDept | 1.16 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.13 |
| IndexQuery | NoIndex_FullScan | 0.00 |
| IndexQuery | OrderBy | 0.14 |
| IndexQuery | Pagination | 0.35 |
| IndexQuery | PrefixQuery_Name | 0.18 |
| IndexQuery | RangeQuery_Date | 0.90 |
| IndexQuery | RangeQuery_Salary | 0.00 |
| IndexQuery | RangeQuery_Score | 0.00 |
| IndexQuery | SingleIndex_Category | 0.00 |
| IndexQuery | SingleIndex_Status | 2.04 |
| MillionData | Aggregation | 0.00 |
| MillionData | Cleanup | 9.01 |
| MillionData | GroupBy | 0.00 |
| Single | Delete | 0.55 |
| Single | Insert | 1.02 |
| Single | Select | 1.34 |
| Single | Update | 0.69 |

## 内存消耗对比

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-----------:|
| Aggregation | Statistics | 1.05 MB |
| Batch | Delete | 4.4 MB |
| Batch | Insert | 9.06 MB |
| Batch | Select | 184 KB |
| Batch | Update | 15.18 MB |
| IndexQuery | ComplexCondition | 52 KB |
| IndexQuery | CompositeIndex_RegionDept | 12 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 288 KB |
| IndexQuery | NoIndex_FullScan | 2.25 MB |
| IndexQuery | OrderBy | 64 KB |
| IndexQuery | Pagination | 12 KB |
| IndexQuery | PrefixQuery_Name | 3.54 MB |
| IndexQuery | RangeQuery_Date | 100 KB |
| IndexQuery | RangeQuery_Salary | 4 KB |
| IndexQuery | RangeQuery_Score | 20 KB |
| IndexQuery | SingleIndex_Category | 4 KB |
| IndexQuery | SingleIndex_Status | 8 KB |
| MillionData | Aggregation | 32 KB |
| MillionData | Cleanup | 16 KB |
| MillionData | GroupBy | 84 KB |
| Single | Delete | 120 KB |
| Single | Insert | 19.02 MB |
| Single | Select | 5.78 MB |
| Single | Update | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| Oracle | Aggregation | GroupBy | 17:39:39 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:39:56 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:40:12 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:40:28 | Specified cast is not valid. |
| Oracle | Aggregation | GroupBy | 17:40:45 | Specified cast is not valid. |
| Oracle | MillionData | PrepareData | 17:40:46 | ORA-39826: 无法解析视图或同义词 (BENCHMARK.TEST_ENTITY) 的直接路径加载。 https://docs.oracle.com/error-help/db/ora-398... |
| Oracle | IndexQuery | PrimaryKey | 17:40:46 | 'minValue' cannot be greater than maxValue. (Parameter 'minValue') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 17:40:51*
