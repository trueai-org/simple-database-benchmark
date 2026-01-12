# 数据库基准测试报告

**测试时间**: 2026-01-12 13:26:28

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
| 采集时间 | 2026-01-12 13:26:28 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | PostgreSQL |
| 数据库数量 | 1 |
| 总测试用例数 | 67 |
| 成功用例数 | 67 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | PostgreSQL | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 3.00 | **PostgreSQL** |
| Aggregation | Statistics | 10.20 | **PostgreSQL** |
| Batch | Delete | 19.20 | **PostgreSQL** |
| Batch | Insert | 536.80 | **PostgreSQL** |
| Batch | Select | 69.20 | **PostgreSQL** |
| Batch | Update | 344.40 | **PostgreSQL** |
| IndexQuery | ComplexCondition | 2168.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 66.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 65.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 524.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 3758.00 | **PostgreSQL** |
| IndexQuery | Pagination | 83.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 7468.00 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 40.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 65.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 80.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 82.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 733.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 1070.00 | **PostgreSQL** |
| MillionData | Aggregation | 209.00 | **PostgreSQL** |
| MillionData | Cleanup | 1460.00 | **PostgreSQL** |
| MillionData | GroupBy | 179.00 | **PostgreSQL** |
| MillionData | PrepareData | 21098.00 | **PostgreSQL** |
| Single | Delete | 853.40 | **PostgreSQL** |
| Single | Insert | 990.00 | **PostgreSQL** |
| Single | Select | 396.80 | **PostgreSQL** |
| Single | Update | 989.80 | **PostgreSQL** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | PostgreSQL | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 622.22 | **PostgreSQL** |
| Aggregation | Statistics | 998.71 | **PostgreSQL** |
| Batch | Delete | 263120.50 | **PostgreSQL** |
| Batch | Insert | 9419.45 | **PostgreSQL** |
| Batch | Select | 496052.03 | **PostgreSQL** |
| Batch | Update | 14623.82 | **PostgreSQL** |
| IndexQuery | ComplexCondition | 46.13 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 1515.15 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 1538.46 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 19.08 | **PostgreSQL** |
| IndexQuery | OrderBy | 26.61 | **PostgreSQL** |
| IndexQuery | Pagination | 1204.82 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 13.39 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 2500.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 1538.46 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 1250.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 1219.51 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 136.43 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 93.46 | **PostgreSQL** |
| MillionData | Aggregation | 38.28 | **PostgreSQL** |
| MillionData | Cleanup | 684931.51 | **PostgreSQL** |
| MillionData | GroupBy | 22.35 | **PostgreSQL** |
| MillionData | PrepareData | 47397.86 | **PostgreSQL** |
| Single | Delete | 1172.09 | **PostgreSQL** |
| Single | Insert | 1011.93 | **PostgreSQL** |
| Single | Select | 2523.70 | **PostgreSQL** |
| Single | Update | 1011.65 | **PostgreSQL** |

## 各数据库详细结果

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 9 | 111.11 | 7.03 | 224 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 76 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 31 | 193.55 | 2.07 | 848 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 25.60 | 20 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 1.05 MB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 23 | 217391.30 | 2.73 | 60 KB | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.61 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 40 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.38 | 28 KB | ✅ |
| Batch | Insert | 5,000 | 607 | 8237.23 | 1.50 | 14.04 MB | ✅ |
| Batch | Insert | 5,000 | 569 | 8787.35 | 1.37 | 12.91 MB | ✅ |
| Batch | Insert | 5,000 | 449 | 11135.86 | 2.46 | 15.16 MB | ✅ |
| Batch | Insert | 5,000 | 557 | 8976.66 | 1.87 | 12.7 MB | ✅ |
| Batch | Insert | 5,000 | 502 | 9960.16 | 1.55 | 13.61 MB | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 0.00 | 12 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 313 | 15974.44 | 0.00 | 8 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.33 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.47 | 0 B | ✅ |
| Batch | Update | 5,000 | 353 | 14164.31 | 2.21 | 0 B | ✅ |
| Batch | Update | 5,000 | 295 | 16949.15 | 2.42 | 0 B | ✅ |
| Batch | Update | 5,000 | 371 | 13477.09 | 1.40 | 4.13 MB | ✅ |
| Batch | Update | 5,000 | 370 | 13513.51 | 1.41 | 0 B | ✅ |
| Batch | Update | 5,000 | 333 | 15015.02 | 1.56 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 2,168 | 46.13 | 0.24 | 4.46 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 66 | 1515.15 | 0.98 | 3.72 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 65 | 1538.46 | 2.98 | 564 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 524 | 19.08 | 0.12 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 3,758 | 26.61 | 0.05 | 68 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 83 | 1204.82 | 1.56 | 16 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 7,468 | 13.39 | 0.05 | 144 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 40 | 2500.00 | 1.61 | 72 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 65 | 1538.46 | 1.99 | 8 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 80 | 1250.00 | 2.43 | 8 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 82 | 1219.51 | 2.36 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 733 | 136.43 | 0.18 | 152 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 1,070 | 93.46 | 0.24 | 2.26 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 209 | 38.28 | 0.62 | 24 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 1,460 | 684931.51 | 0.13 | 300 KB | ✅ |
| MillionData | GroupBy | 32 | 179 | 22.35 | 0.00 | 24 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 21,098 | 47397.86 | 2.29 | 36.02 MB | ✅ |
| Single | Delete | 1,000 | 850 | 1176.47 | 1.07 | 240 KB | ✅ |
| Single | Delete | 1,000 | 853 | 1172.33 | 0.99 | 0 B | ✅ |
| Single | Delete | 1,000 | 835 | 1197.60 | 1.87 | 0 B | ✅ |
| Single | Delete | 1,000 | 878 | 1138.95 | 0.89 | 0 B | ✅ |
| Single | Delete | 1,000 | 851 | 1175.09 | 0.92 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,066 | 938.09 | 2.20 | 15.3 MB | ✅ |
| Single | Insert | 1,000 | 989 | 1011.12 | 1.65 | 7.35 MB | ✅ |
| Single | Insert | 1,000 | 993 | 1007.05 | 1.18 | 6.73 MB | ✅ |
| Single | Insert | 1,000 | 963 | 1038.42 | 1.42 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 939 | 1064.96 | 1.25 | 6.79 MB | ✅ |
| Single | Select | 1,000 | 427 | 2341.92 | 4.57 | 4.82 MB | ✅ |
| Single | Select | 1,000 | 387 | 2583.98 | 2.35 | 4.05 MB | ✅ |
| Single | Select | 1,000 | 390 | 2564.10 | 2.16 | 8 MB | ✅ |
| Single | Select | 1,000 | 387 | 2583.98 | 3.02 | 4 MB | ✅ |
| Single | Select | 1,000 | 393 | 2544.53 | 2.98 | 4 MB | ✅ |
| Single | Update | 1,000 | 971 | 1029.87 | 1.41 | 452 KB | ✅ |
| Single | Update | 1,000 | 971 | 1029.87 | 1.07 | 140 KB | ✅ |
| Single | Update | 1,000 | 969 | 1031.99 | 1.34 | 0 B | ✅ |
| Single | Update | 1,000 | 1,064 | 939.85 | 1.90 | 0 B | ✅ |
| Single | Update | 1,000 | 974 | 1026.69 | 1.47 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | PostgreSQL |
|:---------|:---------|-------:|
| Aggregation | GroupBy | 1.41 |
| Aggregation | Statistics | 5.53 |
| Batch | Delete | 1.94 |
| Batch | Insert | 1.75 |
| Batch | Select | 2.76 |
| Batch | Update | 1.80 |
| IndexQuery | ComplexCondition | 0.24 |
| IndexQuery | CompositeIndex_RegionDept | 0.98 |
| IndexQuery | CompositeIndex_StatusCatPri | 2.98 |
| IndexQuery | NoIndex_FullScan | 0.12 |
| IndexQuery | OrderBy | 0.05 |
| IndexQuery | Pagination | 1.56 |
| IndexQuery | PrefixQuery_Name | 0.05 |
| IndexQuery | PrimaryKey | 1.61 |
| IndexQuery | RangeQuery_Date | 1.99 |
| IndexQuery | RangeQuery_Salary | 2.43 |
| IndexQuery | RangeQuery_Score | 2.36 |
| IndexQuery | SingleIndex_Category | 0.18 |
| IndexQuery | SingleIndex_Status | 0.24 |
| MillionData | Aggregation | 0.62 |
| MillionData | Cleanup | 0.13 |
| MillionData | GroupBy | 0.00 |
| MillionData | PrepareData | 2.29 |
| Single | Delete | 1.15 |
| Single | Insert | 1.54 |
| Single | Select | 3.02 |
| Single | Update | 1.44 |

## 内存消耗对比

| 操作类型 | 操作名称 | PostgreSQL |
|:---------|:---------|-----------:|
| Aggregation | GroupBy | 224 KB |
| Aggregation | Statistics | 1.05 MB |
| Batch | Delete | 60 KB |
| Batch | Insert | 15.16 MB |
| Batch | Select | 12 KB |
| Batch | Update | 4.13 MB |
| IndexQuery | ComplexCondition | 4.46 MB |
| IndexQuery | CompositeIndex_RegionDept | 3.72 MB |
| IndexQuery | CompositeIndex_StatusCatPri | 564 KB |
| IndexQuery | NoIndex_FullScan | 0 B |
| IndexQuery | OrderBy | 68 KB |
| IndexQuery | Pagination | 16 KB |
| IndexQuery | PrefixQuery_Name | 144 KB |
| IndexQuery | PrimaryKey | 72 KB |
| IndexQuery | RangeQuery_Date | 8 KB |
| IndexQuery | RangeQuery_Salary | 8 KB |
| IndexQuery | RangeQuery_Score | 8 KB |
| IndexQuery | SingleIndex_Category | 152 KB |
| IndexQuery | SingleIndex_Status | 2.26 MB |
| MillionData | Aggregation | 24 KB |
| MillionData | Cleanup | 300 KB |
| MillionData | GroupBy | 24 KB |
| MillionData | PrepareData | 36.02 MB |
| Single | Delete | 240 KB |
| Single | Insert | 15.3 MB |
| Single | Select | 8 MB |
| Single | Update | 452 KB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 13:26:28*
