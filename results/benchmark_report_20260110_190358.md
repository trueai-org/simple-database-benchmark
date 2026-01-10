# 数据库基准测试报告

**测试时间**: 2026-01-10 19:03:58

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
| 采集时间 | 2026-01-10 19:03:58 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, SQLServer, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 5 |
| 总测试用例数 | 330 |
| 成功用例数 | 330 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.20 | 5.60 | 1.40 | 1.40 | 28.40 | **PostgreSQL** |
| Aggregation | Statistics | 6.40 | 13.60 | 6.80 | 1.20 | 9.20 | **SQLite** |
| Batch | Delete | 37.60 | 86.20 | 18.40 | 40.40 | 215.60 | **PostgreSQL** |
| Batch | Insert | 33.80 | 411.40 | 583.60 | 574.00 | 5059.20 | **MongoDB** |
| Batch | Select | 22.60 | 27.80 | 70.20 | 9.40 | 15.00 | **SQLite** |
| Batch | Update | 142.40 | 322.80 | 371.60 | 288.40 | 2771.20 | **MongoDB** |
| IndexQuery | ComplexCondition | 2647.00 | 3546.00 | 297.00 | 48627.00 | 1530.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 113.00 | 179.00 | 60.00 | 102.00 | 183.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 118.00 | 309.00 | 147.00 | 141.00 | 201.00 | **MongoDB** |
| IndexQuery | NoIndex_FullScan | 4374.00 | 6088.00 | 566.00 | 5780.00 | 2497.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 35574.00 | 54171.00 | 4671.00 | 55015.00 | 4051.00 | **SQLServer** |
| IndexQuery | Pagination | 225.00 | 328.00 | 78.00 | 180.00 | 232.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 62.00 | 68393.00 | 8974.00 | 48788.00 | 15278.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 60.00 | 122.00 | 48.00 | 24.00 | 113.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 119.00 | 902.00 | 115.00 | 154.00 | 200.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 134.00 | 1195.00 | 94.00 | 190.00 | 190.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 135.00 | 1197.00 | 95.00 | 188.00 | 186.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 127.00 | 183.00 | 99.00 | 75.00 | 116.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 136.00 | 184.00 | 67.00 | 72.00 | 455.00 | **PostgreSQL** |
| MillionData | Aggregation | 845.00 | 570.00 | 215.00 | 752.00 | 488.00 | **PostgreSQL** |
| MillionData | GroupBy | 1177.00 | 8093.00 | 203.00 | 10843.00 | 117.00 | **SQLServer** |
| MillionData | PrepareData | 11037.00 | 89712.00 | 116406.00 | 262806.00 | 983162.00 | **MongoDB** |
| Single | Delete | 554.80 | 3423.00 | 869.80 | 2630.60 | 1581.00 | **MongoDB** |
| Single | Insert | 406.00 | 3578.60 | 988.80 | 2756.60 | 1570.60 | **MongoDB** |
| Single | Select | 546.20 | 1101.20 | 406.40 | 114.20 | 1195.40 | **SQLite** |
| Single | Update | 604.00 | 3584.20 | 1015.40 | 2765.20 | 3884.40 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 316.66 | 216.67 | 800.00 | 866.67 | 35.25 | **SQLite** |
| Aggregation | Statistics | 212.50 | 610.06 | 973.33 | 5400.00 | 701.43 | **SQLite** |
| Batch | Delete | 133376.23 | 58450.16 | 272273.82 | 124022.15 | 23204.76 | **PostgreSQL** |
| Batch | Insert | 150517.04 | 12167.67 | 9231.07 | 8760.01 | 989.27 | **MongoDB** |
| Batch | Select | 222411.07 | 180178.38 | 496001.80 | 533333.34 | 334523.81 | **SQLite** |
| Batch | Update | 35232.98 | 15738.34 | 13604.18 | 17340.99 | 1806.70 | **MongoDB** |
| IndexQuery | ComplexCondition | 37.78 | 28.20 | 336.70 | 2.06 | 65.36 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 884.96 | 558.66 | 1666.67 | 980.39 | 546.45 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 847.46 | 323.62 | 680.27 | 709.22 | 497.51 | **MongoDB** |
| IndexQuery | NoIndex_FullScan | 2.29 | 1.64 | 17.67 | 1.73 | 4.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 2.81 | 1.85 | 21.41 | 1.82 | 24.69 | **SQLServer** |
| IndexQuery | Pagination | 444.44 | 304.88 | 1282.05 | 555.56 | 431.03 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 1612.90 | 1.46 | 11.14 | 2.05 | 6.55 | **MongoDB** |
| IndexQuery | PrimaryKey | 1666.67 | 819.67 | 2083.33 | 4166.67 | 884.96 | **SQLite** |
| IndexQuery | RangeQuery_Date | 840.34 | 110.86 | 869.57 | 649.35 | 500.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 746.27 | 83.68 | 1063.83 | 526.32 | 526.32 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 740.74 | 83.54 | 1052.63 | 531.91 | 537.63 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 787.40 | 546.45 | 1010.10 | 1333.33 | 862.07 | **SQLite** |
| IndexQuery | SingleIndex_Status | 735.29 | 543.48 | 1492.54 | 1388.89 | 219.78 | **PostgreSQL** |
| MillionData | Aggregation | 9.47 | 14.04 | 37.21 | 10.64 | 16.39 | **PostgreSQL** |
| MillionData | GroupBy | 3.40 | 0.49 | 19.70 | 0.37 | 34.19 | **SQLServer** |
| MillionData | PrepareData | 90604.33 | 11146.78 | 8590.62 | 3805.09 | 1017.13 | **MongoDB** |
| Single | Delete | 1802.93 | 292.26 | 1149.84 | 380.51 | 632.92 | **MongoDB** |
| Single | Insert | 2471.67 | 279.78 | 1012.91 | 362.99 | 637.39 | **MongoDB** |
| Single | Select | 1832.15 | 910.97 | 2461.93 | 8761.79 | 856.63 | **SQLite** |
| Single | Update | 1656.64 | 279.06 | 985.51 | 361.96 | 258.95 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 24 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 18.51 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 34.92 | 44 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 16 | 62.50 | 7.68 | 676 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.29 | 16 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.98 | 0 B | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 1.62 | 0 B | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 0.00 | 120 KB | ✅ |
| Batch | Delete | 5,000 | 35 | 142857.14 | 1.84 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 0.00 | 1.38 MB | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 43 | 116279.07 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 34 | 147058.82 | 3.82 | 0 B | ✅ |
| Batch | Insert | 5,000 | 30 | 166666.67 | 4.20 | 28 KB | ✅ |
| Batch | Insert | 5,000 | 31 | 161290.32 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 31 | 161290.32 | 2.04 | 0 B | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 5.20 | 0 B | ✅ |
| Batch | Select | 5,000 | 23 | 217391.30 | 2.77 | 8 KB | ✅ |
| Batch | Select | 5,000 | 22 | 227272.73 | 5.66 | 0 B | ✅ |
| Batch | Select | 5,000 | 23 | 217391.30 | 2.83 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.22 | 0 B | ✅ |
| Batch | Update | 5,000 | 148 | 33783.78 | 1.31 | 3.05 MB | ✅ |
| Batch | Update | 5,000 | 147 | 34013.61 | 1.32 | 3.59 MB | ✅ |
| Batch | Update | 5,000 | 133 | 37593.98 | 1.96 | 4 MB | ✅ |
| Batch | Update | 5,000 | 132 | 37878.79 | 0.98 | 4 MB | ✅ |
| Batch | Update | 5,000 | 152 | 32894.74 | 0.43 | 4 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 2,647 | 37.78 | 0.30 | 13.2 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 113 | 884.96 | 4.02 | 612 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 118 | 847.46 | 1.65 | 1.1 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 4,374 | 2.29 | 0.06 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 35,574 | 2.81 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 225 | 444.44 | 0.87 | 460 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 62 | 1612.90 | 2.08 | 24 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 60 | 1666.67 | 3.23 | 172 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 119 | 840.34 | 1.09 | 108 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 134 | 746.27 | 0.97 | 28 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 135 | 740.74 | 1.93 | 3.46 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 127 | 787.40 | 3.56 | 1.16 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 136 | 735.29 | 2.39 | 1.64 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 845 | 9.47 | 0.08 | 400 KB | ✅ |
| MillionData | GroupBy | 32 | 1,177 | 3.40 | 0.06 | 64 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 11,037 | 90604.33 | 2.01 | 44.32 MB | ✅ |
| Single | Delete | 1,000 | 550 | 1818.18 | 2.49 | 420 KB | ✅ |
| Single | Delete | 1,000 | 562 | 1779.36 | 1.62 | 292 KB | ✅ |
| Single | Delete | 1,000 | 546 | 1831.50 | 1.91 | 268 KB | ✅ |
| Single | Delete | 1,000 | 547 | 1828.15 | 2.02 | 9.91 MB | ✅ |
| Single | Delete | 1,000 | 569 | 1757.47 | 2.06 | 15.11 MB | ✅ |
| Single | Insert | 1,000 | 440 | 2272.73 | 4.28 | 2.47 MB | ✅ |
| Single | Insert | 1,000 | 384 | 2604.17 | 2.20 | 3.02 MB | ✅ |
| Single | Insert | 1,000 | 380 | 2631.58 | 2.23 | 0 B | ✅ |
| Single | Insert | 1,000 | 429 | 2331.00 | 1.06 | 5.68 MB | ✅ |
| Single | Insert | 1,000 | 397 | 2518.89 | 0.98 | 5.68 MB | ✅ |
| Single | Select | 1,000 | 575 | 1739.13 | 3.17 | 1.5 MB | ✅ |
| Single | Select | 1,000 | 540 | 1851.85 | 1.93 | 272 KB | ✅ |
| Single | Select | 1,000 | 533 | 1876.17 | 2.07 | 208 KB | ✅ |
| Single | Select | 1,000 | 538 | 1858.74 | 2.54 | 5.37 MB | ✅ |
| Single | Select | 1,000 | 545 | 1834.86 | 1.19 | 5.29 MB | ✅ |
| Single | Update | 1,000 | 619 | 1615.51 | 2.84 | 6.17 MB | ✅ |
| Single | Update | 1,000 | 587 | 1703.58 | 1.22 | 5.23 MB | ✅ |
| Single | Update | 1,000 | 586 | 1706.48 | 2.44 | 5.25 MB | ✅ |
| Single | Update | 1,000 | 608 | 1644.74 | 1.92 | 11.29 MB | ✅ |
| Single | Update | 1,000 | 620 | 1612.90 | 2.41 | 11.27 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.21 | 144 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 15.47 | 36 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.37 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 348 KB | ✅ |
| Aggregation | Statistics | 5,000 | 34 | 176.47 | 3.77 | 836 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.15 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 6.46 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.61 | 0 B | ✅ |
| Batch | Delete | 5,000 | 93 | 53763.44 | 2.08 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 77 | 64935.06 | 0.00 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 95 | 52631.58 | 1.37 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 88 | 56818.18 | 0.00 | 948 KB | ✅ |
| Batch | Delete | 5,000 | 78 | 64102.56 | 1.65 | 236 KB | ✅ |
| Batch | Insert | 5,000 | 430 | 11627.91 | 3.33 | 9.01 MB | ✅ |
| Batch | Insert | 5,000 | 396 | 12626.26 | 3.78 | 7.63 MB | ✅ |
| Batch | Insert | 5,000 | 424 | 11792.45 | 2.61 | 7.71 MB | ✅ |
| Batch | Insert | 5,000 | 411 | 12165.45 | 3.16 | 7.59 MB | ✅ |
| Batch | Insert | 5,000 | 396 | 12626.26 | 3.28 | 7.32 MB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 2.22 | 2.46 MB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 0.00 | 2.54 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 2.33 | 2.84 MB | ✅ |
| Batch | Select | 5,000 | 28 | 178571.43 | 2.30 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 26 | 192307.69 | 0.00 | 2.45 MB | ✅ |
| Batch | Update | 5,000 | 311 | 16077.17 | 3.13 | 3.04 MB | ✅ |
| Batch | Update | 5,000 | 298 | 16778.52 | 2.40 | 5.69 MB | ✅ |
| Batch | Update | 5,000 | 289 | 17301.04 | 2.25 | 4.87 MB | ✅ |
| Batch | Update | 5,000 | 306 | 16339.87 | 2.13 | 6.25 MB | ✅ |
| Batch | Update | 5,000 | 410 | 12195.12 | 2.38 | 6.28 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,546 | 28.20 | 0.22 | 6.62 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 179 | 558.66 | 2.91 | 40 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 309 | 323.62 | 1.89 | 3.33 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,088 | 1.64 | 0.01 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 54,171 | 1.85 | 0.01 | 628 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 328 | 304.88 | 0.59 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 68,393 | 1.46 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 122 | 819.67 | 1.07 | 3.81 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 902 | 110.86 | 0.43 | 112 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 1,195 | 83.68 | 0.33 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 1,197 | 83.54 | 0.49 | 3.34 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 183 | 546.45 | 2.49 | 4.66 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 184 | 543.48 | 2.12 | 2.56 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 570 | 14.04 | 0.11 | 1.04 MB | ✅ |
| MillionData | GroupBy | 32 | 8,093 | 0.49 | 0.02 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 89,712 | 11146.78 | 2.62 | 19.6 MB | ✅ |
| Single | Delete | 1,000 | 3,463 | 288.77 | 0.64 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,343 | 299.13 | 0.62 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,366 | 297.09 | 0.64 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,530 | 283.29 | 0.52 | 604 KB | ✅ |
| Single | Delete | 1,000 | 3,413 | 293.00 | 0.59 | 4.32 MB | ✅ |
| Single | Insert | 1,000 | 3,824 | 261.51 | 1.29 | 5.51 MB | ✅ |
| Single | Insert | 1,000 | 3,459 | 289.10 | 0.75 | 200 KB | ✅ |
| Single | Insert | 1,000 | 3,543 | 282.25 | 0.59 | 1.13 MB | ✅ |
| Single | Insert | 1,000 | 3,541 | 282.41 | 0.46 | 1.65 MB | ✅ |
| Single | Insert | 1,000 | 3,526 | 283.61 | 0.72 | 4.7 MB | ✅ |
| Single | Select | 1,000 | 1,229 | 813.67 | 1.75 | 2.36 MB | ✅ |
| Single | Select | 1,000 | 1,057 | 946.07 | 1.97 | 1.92 MB | ✅ |
| Single | Select | 1,000 | 1,069 | 935.45 | 1.83 | 108 KB | ✅ |
| Single | Select | 1,000 | 1,080 | 925.93 | 1.51 | 1012 KB | ✅ |
| Single | Select | 1,000 | 1,071 | 933.71 | 1.58 | 0 B | ✅ |
| Single | Update | 1,000 | 3,645 | 274.35 | 0.55 | 20 KB | ✅ |
| Single | Update | 1,000 | 3,546 | 282.01 | 0.62 | 124 KB | ✅ |
| Single | Update | 1,000 | 3,538 | 282.65 | 0.68 | 1.09 MB | ✅ |
| Single | Update | 1,000 | 3,649 | 274.05 | 0.57 | 0 B | ✅ |
| Single | Update | 1,000 | 3,543 | 282.25 | 0.57 | 1.75 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 33.44 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 33.86 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.92 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 13.18 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 14.97 | 0 B | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 3.82 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 10.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.31 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.30 | 0 B | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 795 | 6289.31 | 1.39 | 8.43 MB | ✅ |
| Batch | Insert | 5,000 | 645 | 7751.94 | 1.51 | 7.66 MB | ✅ |
| Batch | Insert | 5,000 | 368 | 13586.96 | 2.29 | 8.26 MB | ✅ |
| Batch | Insert | 5,000 | 647 | 7727.98 | 2.21 | 7.35 MB | ✅ |
| Batch | Insert | 5,000 | 463 | 10799.14 | 1.97 | 8.26 MB | ✅ |
| Batch | Select | 5,000 | 318 | 15723.27 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.84 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.40 | 8 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 8.10 | 0 B | ✅ |
| Batch | Update | 5,000 | 323 | 15479.88 | 2.42 | 3.86 MB | ✅ |
| Batch | Update | 5,000 | 355 | 14084.51 | 2.20 | 0 B | ✅ |
| Batch | Update | 5,000 | 348 | 14367.82 | 1.12 | 3.86 MB | ✅ |
| Batch | Update | 5,000 | 435 | 11494.25 | 2.09 | 0 B | ✅ |
| Batch | Update | 5,000 | 397 | 12594.46 | 1.64 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 297 | 336.70 | 1.09 | 52 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 60 | 1666.67 | 3.24 | 132 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 147 | 680.27 | 0.44 | 100 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 566 | 17.67 | 0.23 | 824 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,671 | 21.41 | 0.06 | 104 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 78 | 1282.05 | 1.66 | 52 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 8,974 | 11.14 | 0.07 | 1.27 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 48 | 2083.33 | 2.66 | 516 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 115 | 869.57 | 2.26 | 60 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 94 | 1063.83 | 3.46 | 20 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 95 | 1052.63 | 3.40 | 52 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 99 | 1010.10 | 5.87 | 20 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 67 | 1492.54 | 0.00 | 5.48 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 215 | 37.21 | 0.30 | 1.54 MB | ✅ |
| MillionData | GroupBy | 32 | 203 | 19.70 | 0.32 | 1.54 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 116,406 | 8590.62 | 1.54 | 0 B | ✅ |
| Single | Delete | 1,000 | 866 | 1154.73 | 1.58 | 0 B | ✅ |
| Single | Delete | 1,000 | 862 | 1160.09 | 1.28 | 0 B | ✅ |
| Single | Delete | 1,000 | 887 | 1127.40 | 1.25 | 0 B | ✅ |
| Single | Delete | 1,000 | 859 | 1164.14 | 1.21 | 0 B | ✅ |
| Single | Delete | 1,000 | 875 | 1142.86 | 0.97 | 0 B | ✅ |
| Single | Insert | 1,000 | 962 | 1039.50 | 1.49 | 48 KB | ✅ |
| Single | Insert | 1,000 | 1,028 | 972.76 | 1.20 | 256 KB | ✅ |
| Single | Insert | 1,000 | 1,013 | 987.17 | 0.71 | 0 B | ✅ |
| Single | Insert | 1,000 | 926 | 1079.91 | 1.62 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,015 | 985.22 | 1.73 | 0 B | ✅ |
| Single | Select | 1,000 | 404 | 2475.25 | 2.74 | 68 KB | ✅ |
| Single | Select | 1,000 | 406 | 2463.05 | 2.56 | 0 B | ✅ |
| Single | Select | 1,000 | 412 | 2427.18 | 2.37 | 0 B | ✅ |
| Single | Select | 1,000 | 391 | 2557.54 | 2.66 | 0 B | ✅ |
| Single | Select | 1,000 | 419 | 2386.63 | 3.26 | 0 B | ✅ |
| Single | Update | 1,000 | 1,069 | 935.45 | 1.16 | 36 KB | ✅ |
| Single | Update | 1,000 | 1,010 | 990.10 | 0.97 | 0 B | ✅ |
| Single | Update | 1,000 | 1,002 | 998.00 | 1.49 | 0 B | ✅ |
| Single | Update | 1,000 | 999 | 1001.00 | 1.56 | 4 KB | ✅ |
| Single | Update | 1,000 | 997 | 1003.01 | 1.50 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.85 | 276 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 204 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 42.22 | 304 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 42.94 | 264 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 87.21 | 164 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 22.83 | 320 KB | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 53.74 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 38 | 131578.95 | 5.02 | 0 B | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 3.25 | 0 B | ✅ |
| Batch | Delete | 5,000 | 42 | 119047.62 | 3.08 | 0 B | ✅ |
| Batch | Delete | 5,000 | 39 | 128205.13 | 4.93 | 0 B | ✅ |
| Batch | Delete | 5,000 | 43 | 116279.07 | 5.96 | 0 B | ✅ |
| Batch | Insert | 5,000 | 552 | 9057.97 | 4.48 | 5.47 MB | ✅ |
| Batch | Insert | 5,000 | 552 | 9057.97 | 4.24 | 3.73 MB | ✅ |
| Batch | Insert | 5,000 | 550 | 9090.91 | 4.25 | 4.95 MB | ✅ |
| Batch | Insert | 5,000 | 665 | 7518.80 | 3.52 | 3.64 MB | ✅ |
| Batch | Insert | 5,000 | 551 | 9074.41 | 4.25 | 36 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.61 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.49 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.61 | 12 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.56 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.43 | 0 B | ✅ |
| Batch | Update | 5,000 | 293 | 17064.85 | 4.22 | 4.2 MB | ✅ |
| Batch | Update | 5,000 | 287 | 17421.60 | 4.30 | 116 KB | ✅ |
| Batch | Update | 5,000 | 283 | 17667.84 | 3.90 | 3.84 MB | ✅ |
| Batch | Update | 5,000 | 285 | 17543.86 | 4.34 | 172 KB | ✅ |
| Batch | Update | 5,000 | 294 | 17006.80 | 3.98 | 12 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 48,627 | 2.06 | 4.17 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 102 | 980.39 | 4.44 | 4 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 141 | 709.22 | 4.60 | 4 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,780 | 1.73 | 4.17 | 260 KB | ✅ |
| IndexQuery | OrderBy | 100 | 55,015 | 1.82 | 4.16 | 3.95 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 180 | 555.56 | 4.33 | 4 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 48,788 | 2.05 | 4.16 | 1.25 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 24 | 4166.67 | 5.31 | 232 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 154 | 649.35 | 4.64 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 190 | 526.32 | 4.10 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 188 | 531.91 | 4.14 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 75 | 1333.33 | 4.32 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 72 | 1388.89 | 4.47 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 752 | 10.64 | 4.24 | 112 KB | ✅ |
| MillionData | GroupBy | 32 | 10,843 | 0.37 | 4.17 | 2.21 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 262,806 | 3805.09 | 3.99 | 26.29 MB | ✅ |
| Single | Delete | 1,000 | 2,602 | 384.32 | 3.55 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,587 | 386.55 | 3.72 | 16 KB | ✅ |
| Single | Delete | 1,000 | 2,796 | 357.65 | 2.96 | 2.75 MB | ✅ |
| Single | Delete | 1,000 | 2,601 | 384.47 | 3.18 | 4 KB | ✅ |
| Single | Delete | 1,000 | 2,567 | 389.56 | 3.42 | 16 KB | ✅ |
| Single | Insert | 1,000 | 2,674 | 373.97 | 2.99 | 608 KB | ✅ |
| Single | Insert | 1,000 | 2,877 | 347.58 | 3.08 | 7.05 MB | ✅ |
| Single | Insert | 1,000 | 2,780 | 359.71 | 3.00 | 24 KB | ✅ |
| Single | Insert | 1,000 | 2,742 | 364.70 | 2.83 | 12.28 MB | ✅ |
| Single | Insert | 1,000 | 2,710 | 369.00 | 2.67 | 36 KB | ✅ |
| Single | Select | 1,000 | 116 | 8620.69 | 4.47 | 4.09 MB | ✅ |
| Single | Select | 1,000 | 115 | 8695.65 | 3.96 | 3.07 MB | ✅ |
| Single | Select | 1,000 | 111 | 9009.01 | 4.68 | 16 KB | ✅ |
| Single | Select | 1,000 | 118 | 8474.58 | 4.41 | 4.02 MB | ✅ |
| Single | Select | 1,000 | 111 | 9009.01 | 4.66 | 4 KB | ✅ |
| Single | Update | 1,000 | 2,888 | 346.26 | 3.34 | 1.05 MB | ✅ |
| Single | Update | 1,000 | 2,799 | 357.27 | 3.28 | 1.01 MB | ✅ |
| Single | Update | 1,000 | 2,635 | 379.51 | 3.16 | 360 KB | ✅ |
| Single | Update | 1,000 | 2,732 | 366.03 | 2.86 | 2.47 MB | ✅ |
| Single | Update | 1,000 | 2,772 | 360.75 | 2.98 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 30 | 33.33 | 0.00 | 80 KB | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 2.30 | 48 KB | ✅ |
| Aggregation | GroupBy | 8 | 27 | 37.04 | 0.00 | 56 KB | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 0.00 | 36 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 1.45 MB | ✅ |
| Batch | Delete | 5,000 | 216 | 23148.15 | 0.30 | 112 KB | ✅ |
| Batch | Delete | 5,000 | 209 | 23923.44 | 0.31 | 1.18 MB | ✅ |
| Batch | Delete | 5,000 | 225 | 22222.22 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 215 | 23255.81 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 213 | 23474.18 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 5,197 | 962.09 | 0.09 | 4.44 MB | ✅ |
| Batch | Insert | 5,000 | 5,125 | 975.61 | 0.11 | 1.39 MB | ✅ |
| Batch | Insert | 5,000 | 5,040 | 992.06 | 0.13 | 1.34 MB | ✅ |
| Batch | Insert | 5,000 | 4,766 | 1049.10 | 0.22 | 2.56 MB | ✅ |
| Batch | Insert | 5,000 | 5,168 | 967.49 | 0.10 | 1.59 MB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 3.93 | 4 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 0.00 | 8 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 0.00 | 48 KB | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.63 | 0 B | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 2,911 | 1717.62 | 0.07 | 4.98 MB | ✅ |
| Batch | Update | 5,000 | 2,649 | 1887.50 | 0.17 | 64 KB | ✅ |
| Batch | Update | 5,000 | 2,872 | 1740.95 | 0.09 | 3.52 MB | ✅ |
| Batch | Update | 5,000 | 2,697 | 1853.91 | 0.10 | 3.25 MB | ✅ |
| Batch | Update | 5,000 | 2,727 | 1833.52 | 0.12 | 708 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,530 | 65.36 | 0.13 | 348 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 183 | 546.45 | 2.13 | 500 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 201 | 497.51 | 2.58 | 576 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,497 | 4.00 | 0.00 | 36 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,051 | 24.69 | 0.06 | 3.41 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 232 | 431.03 | 2.24 | 3.41 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,278 | 6.55 | 0.02 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 113 | 884.96 | 1.15 | 2.63 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 200 | 500.00 | 1.30 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 190 | 526.32 | 1.02 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 186 | 537.63 | 1.40 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 116 | 862.07 | 1.67 | 48 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 455 | 219.78 | 0.43 | 4.56 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 488 | 16.39 | 0.00 | 32 KB | ✅ |
| MillionData | GroupBy | 32 | 117 | 34.19 | 0.00 | 16 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 983,162 | 1017.13 | 0.07 | 15.96 MB | ✅ |
| Single | Delete | 1,000 | 1,633 | 612.37 | 0.36 | 920 KB | ✅ |
| Single | Delete | 1,000 | 1,574 | 635.32 | 0.66 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,538 | 650.20 | 0.34 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,538 | 650.20 | 0.30 | 192 KB | ✅ |
| Single | Delete | 1,000 | 1,622 | 616.52 | 0.44 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,674 | 597.37 | 0.74 | 10.35 MB | ✅ |
| Single | Insert | 1,000 | 1,546 | 646.83 | 0.25 | 3.64 MB | ✅ |
| Single | Insert | 1,000 | 1,552 | 644.33 | 0.50 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,557 | 642.26 | 0.67 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,524 | 656.17 | 0.60 | 2.51 MB | ✅ |
| Single | Select | 1,000 | 1,575 | 634.92 | 0.54 | 3.1 MB | ✅ |
| Single | Select | 1,000 | 1,117 | 895.26 | 1.11 | 0 B | ✅ |
| Single | Select | 1,000 | 1,040 | 961.54 | 1.44 | 32 KB | ✅ |
| Single | Select | 1,000 | 1,205 | 829.88 | 0.59 | 28 KB | ✅ |
| Single | Select | 1,000 | 1,040 | 961.54 | 0.69 | 0 B | ✅ |
| Single | Update | 1,000 | 3,947 | 253.36 | 0.25 | 356 KB | ✅ |
| Single | Update | 1,000 | 4,427 | 225.89 | 0.16 | 0 B | ✅ |
| Single | Update | 1,000 | 3,523 | 283.85 | 0.22 | 4 MB | ✅ |
| Single | Update | 1,000 | 3,713 | 269.32 | 0.19 | 4 KB | ✅ |
| Single | Update | 1,000 | 3,812 | 262.33 | 0.20 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 10.69 | 7.01 | 13.46 | 38.44 | 0.46 |
| Aggregation | Statistics | 7.39 | 5.20 | 7.01 | 15.31 | 0.00 |
| Batch | Delete | 0.69 | 1.02 | 4.09 | 4.45 | 0.12 |
| Batch | Insert | 2.01 | 3.23 | 1.87 | 4.15 | 0.13 |
| Batch | Select | 4.54 | 1.37 | 4.47 | 6.54 | 2.51 |
| Batch | Update | 1.20 | 2.46 | 1.89 | 4.15 | 0.11 |
| IndexQuery | ComplexCondition | 0.30 | 0.22 | 1.09 | 4.17 | 0.13 |
| IndexQuery | CompositeIndex_RegionDept | 4.02 | 2.91 | 3.24 | 4.44 | 2.13 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.65 | 1.89 | 0.44 | 4.60 | 2.58 |
| IndexQuery | NoIndex_FullScan | 0.06 | 0.01 | 0.23 | 4.17 | 0.00 |
| IndexQuery | OrderBy | 0.01 | 0.01 | 0.06 | 4.16 | 0.06 |
| IndexQuery | Pagination | 0.87 | 0.59 | 1.66 | 4.33 | 2.24 |
| IndexQuery | PrefixQuery_Name | 2.08 | 0.01 | 0.07 | 4.16 | 0.02 |
| IndexQuery | PrimaryKey | 3.23 | 1.07 | 2.66 | 5.31 | 1.15 |
| IndexQuery | RangeQuery_Date | 1.09 | 0.43 | 2.26 | 4.64 | 1.30 |
| IndexQuery | RangeQuery_Salary | 0.97 | 0.33 | 3.46 | 4.10 | 1.02 |
| IndexQuery | RangeQuery_Score | 1.93 | 0.49 | 3.40 | 4.14 | 1.40 |
| IndexQuery | SingleIndex_Category | 3.56 | 2.49 | 5.87 | 4.32 | 1.67 |
| IndexQuery | SingleIndex_Status | 2.39 | 2.12 | 0.00 | 4.47 | 0.43 |
| MillionData | Aggregation | 0.08 | 0.11 | 0.30 | 4.24 | 0.00 |
| MillionData | GroupBy | 0.06 | 0.02 | 0.32 | 4.17 | 0.00 |
| MillionData | PrepareData | 2.01 | 2.62 | 1.54 | 3.99 | 0.07 |
| Single | Delete | 2.02 | 0.60 | 1.26 | 3.37 | 0.42 |
| Single | Insert | 2.15 | 0.76 | 1.35 | 2.91 | 0.55 |
| Single | Select | 2.18 | 1.73 | 2.72 | 4.44 | 0.87 |
| Single | Update | 2.17 | 0.60 | 1.34 | 3.12 | 0.20 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 44 KB | 348 KB | 16 KB | 304 KB | 80 KB |
| Aggregation | Statistics | 676 KB | 836 KB | 4 KB | 320 KB | 1.45 MB |
| Batch | Delete | 1.38 MB | 948 KB | 16 KB | 0 B | 1.18 MB |
| Batch | Insert | 28 KB | 9.01 MB | 8.43 MB | 5.47 MB | 4.44 MB |
| Batch | Select | 8 KB | 2.84 MB | 8 KB | 12 KB | 48 KB |
| Batch | Update | 4 MB | 6.28 MB | 3.86 MB | 4.2 MB | 4.98 MB |
| IndexQuery | ComplexCondition | 13.2 MB | 6.62 MB | 52 KB | 0 B | 348 KB |
| IndexQuery | CompositeIndex_RegionDept | 612 KB | 40 KB | 132 KB | 4 KB | 500 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.1 MB | 3.33 MB | 100 KB | 4 KB | 576 KB |
| IndexQuery | NoIndex_FullScan | 0 B | 0 B | 824 KB | 260 KB | 36 KB |
| IndexQuery | OrderBy | 0 B | 628 KB | 104 KB | 3.95 MB | 3.41 MB |
| IndexQuery | Pagination | 460 KB | 0 B | 52 KB | 4 KB | 3.41 MB |
| IndexQuery | PrefixQuery_Name | 24 KB | 0 B | 1.27 MB | 1.25 MB | 0 B |
| IndexQuery | PrimaryKey | 172 KB | 3.81 MB | 516 KB | 232 KB | 2.63 MB |
| IndexQuery | RangeQuery_Date | 108 KB | 112 KB | 60 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Salary | 28 KB | 0 B | 20 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Score | 3.46 MB | 3.34 MB | 52 KB | 0 B | 0 B |
| IndexQuery | SingleIndex_Category | 1.16 MB | 4.66 MB | 20 KB | 0 B | 48 KB |
| IndexQuery | SingleIndex_Status | 1.64 MB | 2.56 MB | 5.48 MB | 0 B | 4.56 MB |
| MillionData | Aggregation | 400 KB | 1.04 MB | 1.54 MB | 112 KB | 32 KB |
| MillionData | GroupBy | 64 KB | 0 B | 1.54 MB | 2.21 MB | 16 KB |
| MillionData | PrepareData | 44.32 MB | 19.6 MB | 0 B | 26.29 MB | 15.96 MB |
| Single | Delete | 15.11 MB | 4.32 MB | 0 B | 2.75 MB | 920 KB |
| Single | Insert | 5.68 MB | 5.51 MB | 256 KB | 12.28 MB | 10.35 MB |
| Single | Select | 5.37 MB | 2.36 MB | 68 KB | 4.09 MB | 3.1 MB |
| Single | Update | 11.29 MB | 1.75 MB | 36 KB | 2.47 MB | 4 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260110.log` 文件。

---

*报告生成时间: 2026-01-10 19:03:58*
