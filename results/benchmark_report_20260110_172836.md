# 数据库基准测试报告

**测试时间**: 2026-01-10 17:28:36

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
| 采集时间 | 2026-01-10 17:28:36 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, SQLServer, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 5 |
| 总测试用例数 | 335 |
| 成功用例数 | 335 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.20 | 5.80 | 1.20 | 1.40 | 9.40 | **PostgreSQL** |
| Aggregation | Statistics | 6.60 | 15.20 | 7.00 | 1.40 | 12.00 | **SQLite** |
| Batch | Delete | 37.40 | 55.00 | 18.40 | 20.00 | 136.00 | **PostgreSQL** |
| Batch | Insert | 34.40 | 374.60 | 524.20 | 524.20 | 4743.00 | **MongoDB** |
| Batch | Select | 21.60 | 29.80 | 7.80 | 9.20 | 15.60 | **PostgreSQL** |
| Batch | Update | 156.20 | 297.80 | 452.80 | 239.80 | 2408.00 | **MongoDB** |
| IndexQuery | ComplexCondition | 3329.00 | 43911.00 | 3922.00 | 24742.00 | 1481.00 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 95.00 | 457.00 | 155.00 | 54.00 | 188.00 | **SQLite** |
| IndexQuery | CompositeIndex_StatusCatPri | 99.00 | 867.00 | 256.00 | 71.00 | 184.00 | **SQLite** |
| IndexQuery | NoIndex_FullScan | 4152.00 | 7324.00 | 531.00 | 3023.00 | 2634.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 36034.00 | 55827.00 | 3952.00 | 28808.00 | 4463.00 | **PostgreSQL** |
| IndexQuery | Pagination | 204.00 | 345.00 | 75.00 | 90.00 | 231.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 58.00 | 67525.00 | 8984.00 | 24050.00 | 15437.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 53.00 | 113.00 | 44.00 | 12.00 | 118.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 102.00 | 418.00 | 122.00 | 76.00 | 201.00 | **SQLite** |
| IndexQuery | RangeQuery_Salary | 106.00 | 406.00 | 113.00 | 95.00 | 186.00 | **SQLite** |
| IndexQuery | RangeQuery_Score | 112.00 | 546.00 | 88.00 | 95.00 | 183.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 101.00 | 201.00 | 110.00 | 39.00 | 105.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 109.00 | 188.00 | 62.00 | 42.00 | 108.00 | **SQLite** |
| MillionData | Aggregation | 846.00 | 1550.00 | 282.00 | 366.00 | 457.00 | **PostgreSQL** |
| MillionData | CreateIndexes | 8988.00 | 25.00 | 11.00 | 5023.00 | 3547.00 | **PostgreSQL** |
| MillionData | GroupBy | 1175.00 | 1707.00 | 198.00 | 5377.00 | 117.00 | **SQLServer** |
| MillionData | PrepareData | 8559.00 | 78290.00 | 125044.00 | 103747.00 | 949774.00 | **MongoDB** |
| Single | Delete | 552.60 | 3417.40 | 900.40 | 2346.00 | 1530.80 | **MongoDB** |
| Single | Insert | 406.20 | 3556.20 | 994.60 | 2397.00 | 1523.40 | **MongoDB** |
| Single | Select | 534.60 | 1116.60 | 398.20 | 120.20 | 1073.00 | **SQLite** |
| Single | Update | 599.20 | 3551.80 | 1003.00 | 2388.20 | 3247.60 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 316.66 | 206.67 | 900.00 | 866.67 | 107.07 | **PostgreSQL** |
| Aggregation | Statistics | 211.76 | 497.84 | 951.43 | 5200.00 | 532.25 | **SQLite** |
| Batch | Delete | 134042.76 | 91329.87 | 271929.82 | 250250.63 | 36890.51 | **PostgreSQL** |
| Batch | Insert | 145582.40 | 13367.30 | 9895.47 | 9539.23 | 1054.22 | **MongoDB** |
| Batch | Select | 232006.40 | 167972.35 | 652777.78 | 544444.45 | 323004.20 | **PostgreSQL** |
| Batch | Update | 33837.78 | 17099.05 | 12485.81 | 20858.19 | 2078.88 | **MongoDB** |
| IndexQuery | ComplexCondition | 30.04 | 2.28 | 25.50 | 4.04 | 67.52 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 1052.63 | 218.82 | 645.16 | 1851.85 | 531.91 | **SQLite** |
| IndexQuery | CompositeIndex_StatusCatPri | 1010.10 | 115.34 | 390.62 | 1408.45 | 543.48 | **SQLite** |
| IndexQuery | NoIndex_FullScan | 2.41 | 1.37 | 18.83 | 3.31 | 3.80 | **PostgreSQL** |
| IndexQuery | OrderBy | 2.78 | 1.79 | 25.30 | 3.47 | 22.41 | **PostgreSQL** |
| IndexQuery | Pagination | 490.20 | 289.86 | 1333.33 | 1111.11 | 432.90 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 1724.14 | 1.48 | 11.13 | 4.16 | 6.48 | **MongoDB** |
| IndexQuery | PrimaryKey | 1886.79 | 884.96 | 2272.73 | 8333.33 | 847.46 | **SQLite** |
| IndexQuery | RangeQuery_Date | 980.39 | 239.23 | 819.67 | 1315.79 | 497.51 | **SQLite** |
| IndexQuery | RangeQuery_Salary | 943.40 | 246.31 | 884.96 | 1052.63 | 537.63 | **SQLite** |
| IndexQuery | RangeQuery_Score | 892.86 | 183.15 | 1136.36 | 1052.63 | 546.45 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 990.10 | 497.51 | 909.09 | 2564.10 | 952.38 | **SQLite** |
| IndexQuery | SingleIndex_Status | 917.43 | 531.91 | 1612.90 | 2380.95 | 925.93 | **SQLite** |
| MillionData | Aggregation | 9.46 | 5.16 | 28.37 | 21.86 | 17.51 | **PostgreSQL** |
| MillionData | CreateIndexes | 1.00 | 360.00 | 818.18 | 1.79 | 2.54 | **PostgreSQL** |
| MillionData | GroupBy | 3.40 | 2.34 | 20.20 | 0.74 | 34.19 | **SQLServer** |
| MillionData | PrepareData | 116836.08 | 12773.02 | 7997.18 | 9638.83 | 1052.88 | **MongoDB** |
| Single | Delete | 1809.68 | 292.70 | 1112.12 | 426.32 | 653.39 | **MongoDB** |
| Single | Insert | 2480.85 | 281.43 | 1005.96 | 417.34 | 657.24 | **MongoDB** |
| Single | Select | 1871.94 | 896.15 | 2514.76 | 8334.02 | 932.07 | **SQLite** |
| Single | Update | 1669.49 | 281.57 | 997.38 | 419.09 | 316.11 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 32 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.50 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.33 | 16 KB | ✅ |
| Aggregation | Statistics | 5,000 | 17 | 58.82 | 0.00 | 648 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.99 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.56 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 0.00 | 28 KB | ✅ |
| Batch | Delete | 5,000 | 41 | 121951.22 | 3.17 | 76 KB | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 0.00 | 1.66 MB | ✅ |
| Batch | Delete | 5,000 | 35 | 142857.14 | 1.81 | 548 KB | ✅ |
| Batch | Insert | 5,000 | 32 | 156250.00 | 4.04 | 16 KB | ✅ |
| Batch | Insert | 5,000 | 35 | 142857.14 | 1.85 | 0 B | ✅ |
| Batch | Insert | 5,000 | 35 | 142857.14 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 36 | 138888.89 | 1.80 | 0 B | ✅ |
| Batch | Insert | 5,000 | 34 | 147058.82 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 22 | 227272.73 | 0.00 | 12 KB | ✅ |
| Batch | Select | 5,000 | 22 | 227272.73 | 2.86 | 68 KB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.11 | 0 B | ✅ |
| Batch | Select | 5,000 | 21 | 238095.24 | 6.12 | 404 KB | ✅ |
| Batch | Select | 5,000 | 23 | 217391.30 | 5.49 | 0 B | ✅ |
| Batch | Update | 5,000 | 133 | 37593.98 | 2.44 | 3.09 MB | ✅ |
| Batch | Update | 5,000 | 141 | 35460.99 | 1.84 | 3.18 MB | ✅ |
| Batch | Update | 5,000 | 132 | 37878.79 | 0.98 | 3.03 MB | ✅ |
| Batch | Update | 5,000 | 133 | 37593.98 | 1.95 | 4.01 MB | ✅ |
| Batch | Update | 5,000 | 242 | 20661.16 | 0.81 | 4 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,329 | 30.04 | 0.20 | 9.29 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 95 | 1052.63 | 1.36 | 8.52 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 99 | 1010.10 | 1.30 | 8.27 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 4,152 | 2.41 | 0.03 | 92 KB | ✅ |
| IndexQuery | OrderBy | 100 | 36,034 | 2.78 | 0.01 | 6.46 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 204 | 490.20 | 1.59 | 1.74 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 58 | 1724.14 | 4.44 | 132 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 53 | 1886.79 | 4.85 | 1.13 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 102 | 980.39 | 5.06 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 106 | 943.40 | 1.84 | 5.06 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 112 | 892.86 | 1.74 | 8.63 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 101 | 990.10 | 2.56 | 8.93 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 109 | 917.43 | 1.19 | 820 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 846 | 9.46 | 0.08 | 388 KB | ✅ |
| MillionData | CreateIndexes | 9 | 8,988 | 1.00 | 0.00 | 132 KB | ✅ |
| MillionData | GroupBy | 32 | 1,175 | 3.40 | 0.00 | 164 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 8,559 | 116836.08 | 1.54 | 54.23 MB | ✅ |
| Single | Delete | 1,000 | 557 | 1795.33 | 1.87 | 416 KB | ✅ |
| Single | Delete | 1,000 | 554 | 1805.05 | 2.23 | 420 KB | ✅ |
| Single | Delete | 1,000 | 548 | 1824.82 | 2.02 | 0 B | ✅ |
| Single | Delete | 1,000 | 551 | 1814.88 | 2.13 | 0 B | ✅ |
| Single | Delete | 1,000 | 553 | 1808.32 | 1.53 | 4.22 MB | ✅ |
| Single | Insert | 1,000 | 472 | 2118.64 | 5.37 | 2.48 MB | ✅ |
| Single | Insert | 1,000 | 371 | 2695.42 | 1.93 | 2.89 MB | ✅ |
| Single | Insert | 1,000 | 377 | 2652.52 | 2.24 | 0 B | ✅ |
| Single | Insert | 1,000 | 392 | 2551.02 | 1.33 | 0 B | ✅ |
| Single | Insert | 1,000 | 419 | 2386.63 | 1.71 | 2.12 MB | ✅ |
| Single | Select | 1,000 | 563 | 1776.20 | 3.23 | 1.33 MB | ✅ |
| Single | Select | 1,000 | 523 | 1912.05 | 1.87 | 280 KB | ✅ |
| Single | Select | 1,000 | 525 | 1904.76 | 2.11 | 192 KB | ✅ |
| Single | Select | 1,000 | 527 | 1897.53 | 2.22 | 288 KB | ✅ |
| Single | Select | 1,000 | 535 | 1869.16 | 1.58 | 284 KB | ✅ |
| Single | Update | 1,000 | 613 | 1631.32 | 2.12 | 6.31 MB | ✅ |
| Single | Update | 1,000 | 598 | 1672.24 | 1.74 | 4.28 MB | ✅ |
| Single | Update | 1,000 | 582 | 1718.21 | 2.35 | 5.25 MB | ✅ |
| Single | Update | 1,000 | 610 | 1639.34 | 2.24 | 4.27 MB | ✅ |
| Single | Update | 1,000 | 593 | 1686.34 | 2.85 | 8.71 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 120 KB | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 33 | 181.82 | 3.86 | 740 KB | ✅ |
| Aggregation | Statistics | 5,000 | 14 | 428.57 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.51 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 340 KB | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 5.88 | 0 B | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 2.32 | 28 KB | ✅ |
| Batch | Delete | 5,000 | 62 | 80645.16 | 0.00 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 53 | 94339.62 | 1.21 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 51 | 98039.22 | 1.26 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 53 | 94339.62 | 1.22 | 1.27 MB | ✅ |
| Batch | Insert | 5,000 | 397 | 12594.46 | 3.27 | 9.2 MB | ✅ |
| Batch | Insert | 5,000 | 376 | 13297.87 | 2.77 | 7.57 MB | ✅ |
| Batch | Insert | 5,000 | 359 | 13927.58 | 3.62 | 7.61 MB | ✅ |
| Batch | Insert | 5,000 | 359 | 13927.58 | 3.26 | 8.36 MB | ✅ |
| Batch | Insert | 5,000 | 382 | 13089.01 | 2.72 | 10.55 MB | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 4.19 | 2.46 MB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 2.13 | 2.5 MB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 6.40 | 2.85 MB | ✅ |
| Batch | Select | 5,000 | 28 | 178571.43 | 2.25 | 2.46 MB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.23 | 2.45 MB | ✅ |
| Batch | Update | 5,000 | 274 | 18248.18 | 2.13 | 3.46 MB | ✅ |
| Batch | Update | 5,000 | 386 | 12953.37 | 2.02 | 5.74 MB | ✅ |
| Batch | Update | 5,000 | 274 | 18248.18 | 1.89 | 4.7 MB | ✅ |
| Batch | Update | 5,000 | 273 | 18315.02 | 2.62 | 6.17 MB | ✅ |
| Batch | Update | 5,000 | 282 | 17730.50 | 3.23 | 6.3 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 43,911 | 2.28 | 0.01 | 2.45 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 457 | 218.82 | 0.71 | 240 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 867 | 115.34 | 0.45 | 4.61 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 7,324 | 1.37 | 0.00 | 40 KB | ✅ |
| IndexQuery | OrderBy | 100 | 55,827 | 1.79 | 0.01 | 1.14 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 345 | 289.86 | 0.57 | 4.07 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 67,525 | 1.48 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 113 | 884.96 | 1.15 | 3.66 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 418 | 239.23 | 0.62 | 2.86 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 406 | 246.31 | 1.28 | 160 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 546 | 183.15 | 0.95 | 436 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 201 | 497.51 | 0.97 | 40 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 188 | 531.91 | 2.41 | 4.58 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 1,550 | 5.16 | 0.04 | 2.09 MB | ✅ |
| MillionData | CreateIndexes | 9 | 25 | 360.00 | 2.58 | 9.36 MB | ✅ |
| MillionData | GroupBy | 32 | 1,707 | 2.34 | 0.08 | 852 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 78,290 | 12773.02 | 3.05 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,334 | 299.94 | 0.66 | 892 KB | ✅ |
| Single | Delete | 1,000 | 3,498 | 285.88 | 0.47 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,450 | 289.86 | 0.74 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,414 | 292.91 | 0.46 | 3.16 MB | ✅ |
| Single | Delete | 1,000 | 3,391 | 294.90 | 0.61 | 4 MB | ✅ |
| Single | Insert | 1,000 | 3,661 | 273.15 | 1.32 | 4.57 MB | ✅ |
| Single | Insert | 1,000 | 3,412 | 293.08 | 0.63 | 2.72 MB | ✅ |
| Single | Insert | 1,000 | 3,670 | 272.48 | 0.30 | 1.93 MB | ✅ |
| Single | Insert | 1,000 | 3,563 | 280.66 | 0.66 | 2.29 MB | ✅ |
| Single | Insert | 1,000 | 3,475 | 287.77 | 0.54 | 2.31 MB | ✅ |
| Single | Select | 1,000 | 1,111 | 900.09 | 2.11 | 2.34 MB | ✅ |
| Single | Select | 1,000 | 1,134 | 881.83 | 1.66 | 0 B | ✅ |
| Single | Select | 1,000 | 1,086 | 920.81 | 1.98 | 8 KB | ✅ |
| Single | Select | 1,000 | 1,162 | 860.59 | 2.13 | 3.3 MB | ✅ |
| Single | Select | 1,000 | 1,090 | 917.43 | 2.03 | 0 B | ✅ |
| Single | Update | 1,000 | 3,517 | 284.33 | 0.78 | 0 B | ✅ |
| Single | Update | 1,000 | 3,546 | 282.01 | 0.46 | 680 KB | ✅ |
| Single | Update | 1,000 | 3,582 | 279.17 | 0.64 | 124 KB | ✅ |
| Single | Update | 1,000 | 3,593 | 278.32 | 0.54 | 0 B | ✅ |
| Single | Update | 1,000 | 3,521 | 284.01 | 0.67 | 5.28 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 34.86 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 5,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 12.15 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 7.14 | 2.28 MB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.51 | 2.29 MB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 2.26 MB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 2.25 MB | ✅ |
| Batch | Insert | 5,000 | 735 | 6802.72 | 1.42 | 12.38 MB | ✅ |
| Batch | Insert | 5,000 | 461 | 10845.99 | 1.98 | 11.96 MB | ✅ |
| Batch | Insert | 5,000 | 527 | 9487.67 | 1.85 | 12.2 MB | ✅ |
| Batch | Insert | 5,000 | 424 | 11792.45 | 2.61 | 11.9 MB | ✅ |
| Batch | Insert | 5,000 | 474 | 10548.52 | 2.47 | 11.95 MB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.71 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 8.10 | 0 B | ✅ |
| Batch | Select | 5,000 | 6 | 833333.33 | 9.39 | 16 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 7.11 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.38 | 0 B | ✅ |
| Batch | Update | 5,000 | 355 | 14084.51 | 2.20 | 0 B | ✅ |
| Batch | Update | 5,000 | 315 | 15873.02 | 1.86 | 0 B | ✅ |
| Batch | Update | 5,000 | 591 | 8460.24 | 0.88 | 0 B | ✅ |
| Batch | Update | 5,000 | 708 | 7062.15 | 0.74 | 0 B | ✅ |
| Batch | Update | 5,000 | 295 | 16949.15 | 1.76 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,922 | 25.50 | 0.08 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 155 | 645.16 | 2.92 | 660 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 256 | 390.62 | 0.76 | 164 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 531 | 18.83 | 0.00 | 224 KB | ✅ |
| IndexQuery | OrderBy | 100 | 3,952 | 25.30 | 0.07 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 75 | 1333.33 | 1.72 | 3.63 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 8,984 | 11.13 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 44 | 2272.73 | 0.00 | 64 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 122 | 819.67 | 2.65 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 113 | 884.96 | 1.72 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 88 | 1136.36 | 3.68 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 110 | 909.09 | 3.54 | 212 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 62 | 1612.90 | 2.10 | 764 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 282 | 28.37 | 0.00 | 348 KB | ✅ |
| MillionData | CreateIndexes | 9 | 11 | 818.18 | 5.58 | 508 KB | ✅ |
| MillionData | GroupBy | 32 | 198 | 20.20 | 0.33 | 8 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 125,044 | 7997.18 | 1.70 | 27.84 MB | ✅ |
| Single | Delete | 1,000 | 949 | 1053.74 | 0.82 | 0 B | ✅ |
| Single | Delete | 1,000 | 918 | 1089.32 | 0.78 | 0 B | ✅ |
| Single | Delete | 1,000 | 851 | 1175.09 | 1.30 | 0 B | ✅ |
| Single | Delete | 1,000 | 902 | 1108.65 | 1.80 | 0 B | ✅ |
| Single | Delete | 1,000 | 882 | 1133.79 | 1.03 | 0 B | ✅ |
| Single | Insert | 1,000 | 974 | 1026.69 | 1.54 | 11.98 MB | ✅ |
| Single | Insert | 1,000 | 1,010 | 990.10 | 1.03 | 11.03 MB | ✅ |
| Single | Insert | 1,000 | 1,018 | 982.32 | 1.73 | 12.51 MB | ✅ |
| Single | Insert | 1,000 | 1,010 | 990.10 | 0.45 | 12.62 MB | ✅ |
| Single | Insert | 1,000 | 961 | 1040.58 | 1.22 | 12.59 MB | ✅ |
| Single | Select | 1,000 | 386 | 2590.67 | 2.69 | 7.07 MB | ✅ |
| Single | Select | 1,000 | 395 | 2531.65 | 2.63 | 7 MB | ✅ |
| Single | Select | 1,000 | 402 | 2487.56 | 3.56 | 7 MB | ✅ |
| Single | Select | 1,000 | 425 | 2352.94 | 2.75 | 7 MB | ✅ |
| Single | Select | 1,000 | 383 | 2610.97 | 1.70 | 11.01 MB | ✅ |
| Single | Update | 1,000 | 1,012 | 988.14 | 0.84 | 0 B | ✅ |
| Single | Update | 1,000 | 971 | 1029.87 | 2.01 | 4 KB | ✅ |
| Single | Update | 1,000 | 992 | 1008.06 | 1.70 | 4 KB | ✅ |
| Single | Update | 1,000 | 1,014 | 986.19 | 1.35 | 132 KB | ✅ |
| Single | Update | 1,000 | 1,026 | 974.66 | 1.08 | 15 MB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 408 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 356 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 44.82 | 364 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 284 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 224 KB | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 2000.00 | 0.00 | 328 KB | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 35.74 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 3.25 | 0 B | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 6.34 | 0 B | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 3.15 | 0 B | ✅ |
| Batch | Delete | 5,000 | 21 | 238095.24 | 6.07 | 0 B | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 524 | 9541.98 | 4.10 | 5.36 MB | ✅ |
| Batch | Insert | 5,000 | 527 | 9487.67 | 4.19 | 4.17 MB | ✅ |
| Batch | Insert | 5,000 | 525 | 9523.81 | 4.09 | 5.45 MB | ✅ |
| Batch | Insert | 5,000 | 530 | 9433.96 | 4.05 | 4.9 MB | ✅ |
| Batch | Insert | 5,000 | 515 | 9708.74 | 4.04 | 4.91 MB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.72 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.59 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.63 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.47 | 0 B | ✅ |
| Batch | Update | 5,000 | 245 | 20408.16 | 4.24 | 4.29 MB | ✅ |
| Batch | Update | 5,000 | 241 | 20746.89 | 4.05 | 3.79 MB | ✅ |
| Batch | Update | 5,000 | 244 | 20491.80 | 4.27 | 3.72 MB | ✅ |
| Batch | Update | 5,000 | 235 | 21276.60 | 4.43 | 196 KB | ✅ |
| Batch | Update | 5,000 | 234 | 21367.52 | 3.33 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 24,742 | 4.04 | 4.11 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 54 | 1851.85 | 4.81 | 4.57 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 71 | 1408.45 | 3.65 | 532 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 3,023 | 3.31 | 4.13 | 44 KB | ✅ |
| IndexQuery | OrderBy | 100 | 28,808 | 3.47 | 4.13 | 2.51 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 90 | 1111.11 | 5.06 | 3.8 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 24,050 | 4.16 | 4.14 | 444 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 12 | 8333.33 | 5.18 | 1.37 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 76 | 1315.79 | 4.24 | 3.62 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 95 | 1052.63 | 4.76 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 95 | 1052.63 | 4.78 | 3.62 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 39 | 2564.10 | 4.94 | 40 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 42 | 2380.95 | 4.56 | 6.33 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 366 | 21.86 | 4.08 | 12 KB | ✅ |
| MillionData | CreateIndexes | 9 | 5,023 | 1.79 | 4.12 | 1.77 MB | ✅ |
| MillionData | GroupBy | 32 | 5,377 | 0.74 | 4.14 | 788 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 103,747 | 9638.83 | 4.12 | 38.05 MB | ✅ |
| Single | Delete | 1,000 | 2,351 | 425.35 | 2.63 | 2.66 MB | ✅ |
| Single | Delete | 1,000 | 2,346 | 426.26 | 3.30 | 2.73 MB | ✅ |
| Single | Delete | 1,000 | 2,393 | 417.89 | 3.05 | 3.94 MB | ✅ |
| Single | Delete | 1,000 | 2,331 | 429.00 | 3.49 | 2.71 MB | ✅ |
| Single | Delete | 1,000 | 2,309 | 433.09 | 3.36 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,362 | 423.37 | 3.47 | 12.48 MB | ✅ |
| Single | Insert | 1,000 | 2,379 | 420.34 | 3.78 | 11.36 MB | ✅ |
| Single | Insert | 1,000 | 2,404 | 415.97 | 3.09 | 14.83 MB | ✅ |
| Single | Insert | 1,000 | 2,483 | 402.74 | 3.23 | 12.36 MB | ✅ |
| Single | Insert | 1,000 | 2,357 | 424.27 | 4.11 | 572 KB | ✅ |
| Single | Select | 1,000 | 123 | 8130.08 | 4.22 | 4.09 MB | ✅ |
| Single | Select | 1,000 | 128 | 7812.50 | 4.57 | 4.83 MB | ✅ |
| Single | Select | 1,000 | 113 | 8849.56 | 4.00 | 4.01 MB | ✅ |
| Single | Select | 1,000 | 119 | 8403.36 | 4.37 | 3.78 MB | ✅ |
| Single | Select | 1,000 | 118 | 8474.58 | 4.39 | 16 KB | ✅ |
| Single | Update | 1,000 | 2,380 | 420.17 | 3.66 | 36 KB | ✅ |
| Single | Update | 1,000 | 2,433 | 411.02 | 3.18 | 3.04 MB | ✅ |
| Single | Update | 1,000 | 2,330 | 429.18 | 3.41 | 0 B | ✅ |
| Single | Update | 1,000 | 2,497 | 400.48 | 3.18 | 856 KB | ✅ |
| Single | Update | 1,000 | 2,301 | 434.59 | 3.14 | 4.46 MB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 11 | 90.91 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 6.73 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 44 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 19 | 315.79 | 3.26 | 72 KB | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 6.01 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 6.06 | 1.44 MB | ✅ |
| Batch | Delete | 5,000 | 134 | 37313.43 | 0.48 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 130 | 38461.54 | 0.00 | 1.7 MB | ✅ |
| Batch | Delete | 5,000 | 126 | 39682.54 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 142 | 35211.27 | 0.91 | 0 B | ✅ |
| Batch | Delete | 5,000 | 148 | 33783.78 | 0.44 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,720 | 1059.32 | 0.07 | 3.37 MB | ✅ |
| Batch | Insert | 5,000 | 4,711 | 1061.35 | 0.06 | 2.28 MB | ✅ |
| Batch | Insert | 5,000 | 4,732 | 1056.64 | 0.06 | 7.52 MB | ✅ |
| Batch | Insert | 5,000 | 4,768 | 1048.66 | 0.08 | 1.93 MB | ✅ |
| Batch | Insert | 5,000 | 4,784 | 1045.15 | 0.07 | 0 B | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 3.83 | 0 B | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 3.73 | 12 KB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 3.83 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 8.93 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 8.92 | 68 KB | ✅ |
| Batch | Update | 5,000 | 2,311 | 2163.57 | 0.25 | 572 KB | ✅ |
| Batch | Update | 5,000 | 2,309 | 2165.44 | 0.14 | 4 MB | ✅ |
| Batch | Update | 5,000 | 2,511 | 1991.24 | 0.03 | 192 KB | ✅ |
| Batch | Update | 5,000 | 2,450 | 2040.82 | 0.05 | 2.85 MB | ✅ |
| Batch | Update | 5,000 | 2,459 | 2033.35 | 0.24 | 2.99 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,481 | 67.52 | 0.04 | 2.07 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 188 | 531.91 | 2.76 | 892 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 184 | 543.48 | 2.47 | 524 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,634 | 3.80 | 0.00 | 20 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,463 | 22.41 | 0.09 | 7.08 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 231 | 432.90 | 1.41 | 1.4 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,437 | 6.48 | 0.02 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 118 | 847.46 | 2.75 | 2.62 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 201 | 497.51 | 1.94 | 252 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 186 | 537.63 | 3.13 | 164 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 183 | 546.45 | 1.42 | 3.4 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 105 | 952.38 | 1.85 | 64 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 108 | 925.93 | 3.61 | 5.96 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 457 | 17.51 | 0.00 | 608 KB | ✅ |
| MillionData | CreateIndexes | 9 | 3,547 | 2.54 | 0.00 | 100 KB | ✅ |
| MillionData | GroupBy | 32 | 117 | 34.19 | 0.55 | 40 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 949,774 | 1052.88 | 0.08 | 16.8 MB | ✅ |
| Single | Delete | 1,000 | 1,504 | 664.89 | 0.74 | 4.61 MB | ✅ |
| Single | Delete | 1,000 | 1,510 | 662.25 | 0.43 | 20 KB | ✅ |
| Single | Delete | 1,000 | 1,528 | 654.45 | 0.38 | 100 KB | ✅ |
| Single | Delete | 1,000 | 1,558 | 641.85 | 0.67 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,554 | 643.50 | 0.38 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,606 | 622.67 | 1.01 | 10.96 MB | ✅ |
| Single | Insert | 1,000 | 1,483 | 674.31 | 0.66 | 412 KB | ✅ |
| Single | Insert | 1,000 | 1,451 | 689.18 | 0.54 | 6.78 MB | ✅ |
| Single | Insert | 1,000 | 1,551 | 644.75 | 0.42 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,526 | 655.31 | 0.64 | 0 B | ✅ |
| Single | Select | 1,000 | 1,078 | 927.64 | 0.85 | 1.19 MB | ✅ |
| Single | Select | 1,000 | 1,055 | 947.87 | 1.30 | 3.01 MB | ✅ |
| Single | Select | 1,000 | 1,068 | 936.33 | 0.79 | 3.57 MB | ✅ |
| Single | Select | 1,000 | 1,088 | 919.12 | 0.54 | 4 MB | ✅ |
| Single | Select | 1,000 | 1,076 | 929.37 | 0.67 | 0 B | ✅ |
| Single | Update | 1,000 | 2,874 | 347.95 | 0.29 | 88 KB | ✅ |
| Single | Update | 1,000 | 2,833 | 352.98 | 0.30 | 3.18 MB | ✅ |
| Single | Update | 1,000 | 4,377 | 228.47 | 0.18 | 3.02 MB | ✅ |
| Single | Update | 1,000 | 2,947 | 339.33 | 0.35 | 3.94 MB | ✅ |
| Single | Update | 1,000 | 3,207 | 311.82 | 0.24 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 6.97 | 0.00 | 6.97 | 8.96 | 1.35 |
| Aggregation | Statistics | 5.91 | 3.25 | 2.43 | 7.15 | 3.07 |
| Batch | Delete | 1.00 | 1.20 | 2.13 | 3.76 | 0.37 |
| Batch | Insert | 1.54 | 3.13 | 2.07 | 4.09 | 0.07 |
| Batch | Select | 3.52 | 3.84 | 7.94 | 5.28 | 5.85 |
| Batch | Update | 1.60 | 2.38 | 1.49 | 4.06 | 0.14 |
| IndexQuery | ComplexCondition | 0.20 | 0.01 | 0.08 | 4.11 | 0.04 |
| IndexQuery | CompositeIndex_RegionDept | 1.36 | 0.71 | 2.92 | 4.81 | 2.76 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.30 | 0.45 | 0.76 | 3.65 | 2.47 |
| IndexQuery | NoIndex_FullScan | 0.03 | 0.00 | 0.00 | 4.13 | 0.00 |
| IndexQuery | OrderBy | 0.01 | 0.01 | 0.07 | 4.13 | 0.09 |
| IndexQuery | Pagination | 1.59 | 0.57 | 1.72 | 5.06 | 1.41 |
| IndexQuery | PrefixQuery_Name | 4.44 | 0.01 | 0.01 | 4.14 | 0.02 |
| IndexQuery | PrimaryKey | 4.85 | 1.15 | 0.00 | 5.18 | 2.75 |
| IndexQuery | RangeQuery_Date | 5.06 | 0.62 | 2.65 | 4.24 | 1.94 |
| IndexQuery | RangeQuery_Salary | 1.84 | 1.28 | 1.72 | 4.76 | 3.13 |
| IndexQuery | RangeQuery_Score | 1.74 | 0.95 | 3.68 | 4.78 | 1.42 |
| IndexQuery | SingleIndex_Category | 2.56 | 0.97 | 3.54 | 4.94 | 1.85 |
| IndexQuery | SingleIndex_Status | 1.19 | 2.41 | 2.10 | 4.56 | 3.61 |
| MillionData | Aggregation | 0.08 | 0.04 | 0.00 | 4.08 | 0.00 |
| MillionData | CreateIndexes | 0.00 | 2.58 | 5.58 | 4.12 | 0.00 |
| MillionData | GroupBy | 0.00 | 0.08 | 0.33 | 4.14 | 0.55 |
| MillionData | PrepareData | 1.54 | 3.05 | 1.70 | 4.12 | 0.08 |
| Single | Delete | 1.96 | 0.59 | 1.15 | 3.17 | 0.52 |
| Single | Insert | 2.52 | 0.69 | 1.19 | 3.54 | 0.65 |
| Single | Select | 2.20 | 1.98 | 2.67 | 4.31 | 0.83 |
| Single | Update | 2.26 | 0.62 | 1.40 | 3.31 | 0.27 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 32 KB | 120 KB | 28 KB | 408 KB | 44 KB |
| Aggregation | Statistics | 648 KB | 740 KB | 0 B | 328 KB | 1.44 MB |
| Batch | Delete | 1.66 MB | 1.27 MB | 2.29 MB | 0 B | 1.7 MB |
| Batch | Insert | 16 KB | 10.55 MB | 12.38 MB | 5.45 MB | 7.52 MB |
| Batch | Select | 404 KB | 2.85 MB | 16 KB | 0 B | 68 KB |
| Batch | Update | 4.01 MB | 6.3 MB | 0 B | 4.29 MB | 4 MB |
| IndexQuery | ComplexCondition | 9.29 MB | 2.45 MB | 0 B | 0 B | 2.07 MB |
| IndexQuery | CompositeIndex_RegionDept | 8.52 MB | 240 KB | 660 KB | 4.57 MB | 892 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 8.27 MB | 4.61 MB | 164 KB | 532 KB | 524 KB |
| IndexQuery | NoIndex_FullScan | 92 KB | 40 KB | 224 KB | 44 KB | 20 KB |
| IndexQuery | OrderBy | 6.46 MB | 1.14 MB | 0 B | 2.51 MB | 7.08 MB |
| IndexQuery | Pagination | 1.74 MB | 4.07 MB | 3.63 MB | 3.8 MB | 1.4 MB |
| IndexQuery | PrefixQuery_Name | 132 KB | 0 B | 0 B | 444 KB | 0 B |
| IndexQuery | PrimaryKey | 1.13 MB | 3.66 MB | 64 KB | 1.37 MB | 2.62 MB |
| IndexQuery | RangeQuery_Date | 0 B | 2.86 MB | 0 B | 3.62 MB | 252 KB |
| IndexQuery | RangeQuery_Salary | 5.06 MB | 160 KB | 0 B | 0 B | 164 KB |
| IndexQuery | RangeQuery_Score | 8.63 MB | 436 KB | 0 B | 3.62 MB | 3.4 MB |
| IndexQuery | SingleIndex_Category | 8.93 MB | 40 KB | 212 KB | 40 KB | 64 KB |
| IndexQuery | SingleIndex_Status | 820 KB | 4.58 MB | 764 KB | 6.33 MB | 5.96 MB |
| MillionData | Aggregation | 388 KB | 2.09 MB | 348 KB | 12 KB | 608 KB |
| MillionData | CreateIndexes | 132 KB | 9.36 MB | 508 KB | 1.77 MB | 100 KB |
| MillionData | GroupBy | 164 KB | 852 KB | 8 KB | 788 KB | 40 KB |
| MillionData | PrepareData | 54.23 MB | 0 B | 27.84 MB | 38.05 MB | 16.8 MB |
| Single | Delete | 4.22 MB | 4 MB | 0 B | 3.94 MB | 4.61 MB |
| Single | Insert | 2.89 MB | 4.57 MB | 12.62 MB | 14.83 MB | 10.96 MB |
| Single | Select | 1.33 MB | 3.3 MB | 11.01 MB | 4.83 MB | 4 MB |
| Single | Update | 8.71 MB | 5.28 MB | 15 MB | 4.46 MB | 3.94 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260110.log` 文件。

---

*报告生成时间: 2026-01-10 17:28:36*
