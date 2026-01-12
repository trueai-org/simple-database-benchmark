# 数据库基准测试报告

**测试时间**: 2026-01-12 14:04:08

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
| 采集时间 | 2026-01-12 14:04:08 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, MariaDB, SQLServer, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 6 |
| 总测试用例数 | 402 |
| 成功用例数 | 402 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.00 | 3.40 | 4.80 | 1.60 | 2.60 | 30.00 | **PostgreSQL** |
| Aggregation | Statistics | 5.40 | 7.80 | 10.00 | 5.80 | 2.40 | 9.00 | **SQLite** |
| Batch | Delete | 58.80 | 38.20 | 103.00 | 18.80 | 59.40 | 210.40 | **PostgreSQL** |
| Batch | Insert | 1611.40 | 44.80 | 1669.00 | 1026.60 | 960.80 | 4861.80 | **MongoDB** |
| Batch | Select | 12.80 | 31.20 | 14.00 | 70.60 | 20.00 | 18.40 | **MariaDB** |
| Batch | Update | 1607.20 | 209.60 | 1561.60 | 657.80 | 508.80 | 2587.60 | **MongoDB** |
| IndexQuery | ComplexCondition | 9835.00 | 3454.00 | 2509.00 | 228.00 | 59587.00 | 1657.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 84.00 | 115.00 | 99.00 | 61.00 | 108.00 | 174.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 102.00 | 119.00 | 116.00 | 78.00 | 148.00 | 190.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 5554.00 | 4407.00 | 5506.00 | 504.00 | 6812.00 | 2574.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10171.00 | 35597.00 | 47196.00 | 2076.00 | 65124.00 | 4118.00 | **PostgreSQL** |
| IndexQuery | Pagination | 166.00 | 228.00 | 240.00 | 79.00 | 205.00 | 225.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 42734.00 | 64.00 | 58388.00 | 6621.00 | 57473.00 | 15750.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 55.00 | 55.00 | 54.00 | 43.00 | 24.00 | 110.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 91.00 | 126.00 | 105.00 | 70.00 | 159.00 | 192.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 97.00 | 128.00 | 109.00 | 68.00 | 194.00 | 186.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 100.00 | 133.00 | 107.00 | 65.00 | 188.00 | 187.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 81.00 | 124.00 | 101.00 | 60.00 | 74.00 | 109.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 87.00 | 133.00 | 98.00 | 55.00 | 76.00 | 423.00 | **PostgreSQL** |
| MillionData | Aggregation | 447.00 | 861.00 | 469.00 | 196.00 | 855.00 | 442.00 | **PostgreSQL** |
| MillionData | Cleanup | 18131.00 | 21389.00 | 22815.00 | 4618.00 | 112386.00 | 22358.00 | **PostgreSQL** |
| MillionData | GroupBy | 1780.00 | 1166.00 | 2572.00 | 190.00 | 13014.00 | 115.00 | **SQLServer** |
| MillionData | PrepareData | 24261.00 | 10782.00 | 31143.00 | 34033.00 | 154887.00 | 30428.00 | **MongoDB** |
| Single | Delete | 1108.00 | 540.80 | 2703.00 | 891.40 | 3308.60 | 1560.40 | **MongoDB** |
| Single | Insert | 1288.60 | 389.80 | 2738.00 | 1057.00 | 3342.60 | 1537.20 | **MongoDB** |
| Single | Select | 507.60 | 533.60 | 567.00 | 397.40 | 235.60 | 1077.60 | **SQLite** |
| Single | Update | 1469.40 | 593.80 | 2862.60 | 1110.40 | 3394.00 | 4563.80 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 333.33 | 300.00 | 253.33 | 700.00 | 440.00 | 33.38 | **PostgreSQL** |
| Aggregation | Statistics | 1120.00 | 208.70 | 895.87 | 1189.09 | 2700.00 | 727.62 | **SQLite** |
| Batch | Delete | 85151.27 | 131403.44 | 48767.51 | 266374.27 | 84190.53 | 23767.62 | **PostgreSQL** |
| Batch | Insert | 3103.16 | 112962.96 | 3002.77 | 4912.44 | 5204.84 | 1028.57 | **MongoDB** |
| Batch | Select | 391025.64 | 160477.76 | 357875.46 | 475357.02 | 250000.00 | 272566.22 | **PostgreSQL** |
| Batch | Update | 3128.64 | 24772.48 | 3207.03 | 7635.48 | 9827.46 | 1933.46 | **MongoDB** |
| IndexQuery | ComplexCondition | 10.17 | 28.95 | 39.86 | 438.60 | 1.68 | 60.35 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 1190.48 | 869.57 | 1010.10 | 1639.34 | 925.93 | 574.71 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 980.39 | 840.34 | 862.07 | 1282.05 | 675.68 | 526.32 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 1.80 | 2.27 | 1.82 | 19.84 | 1.47 | 3.89 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.83 | 2.81 | 2.12 | 48.17 | 1.54 | 24.28 | **PostgreSQL** |
| IndexQuery | Pagination | 602.41 | 438.60 | 416.67 | 1265.82 | 487.80 | 444.44 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.34 | 1562.50 | 1.71 | 15.10 | 1.74 | 6.35 | **MongoDB** |
| IndexQuery | PrimaryKey | 1818.18 | 1818.18 | 1851.85 | 2325.58 | 4166.67 | 909.09 | **SQLite** |
| IndexQuery | RangeQuery_Date | 1098.90 | 793.65 | 952.38 | 1428.57 | 628.93 | 520.83 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 1030.93 | 781.25 | 917.43 | 1470.59 | 515.46 | 537.63 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 1000.00 | 751.88 | 934.58 | 1538.46 | 531.91 | 534.76 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 1234.57 | 806.45 | 990.10 | 1666.67 | 1351.35 | 917.43 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 1149.43 | 751.88 | 1020.41 | 1818.18 | 1315.79 | 236.41 | **PostgreSQL** |
| MillionData | Aggregation | 17.90 | 9.29 | 17.06 | 40.82 | 9.36 | 18.10 | **PostgreSQL** |
| MillionData | Cleanup | 55154.16 | 46753.00 | 43830.81 | 216543.96 | 8897.91 | 44726.72 | **PostgreSQL** |
| MillionData | GroupBy | 2.25 | 3.43 | 1.56 | 21.05 | 0.31 | 34.78 | **SQLServer** |
| MillionData | PrepareData | 41218.42 | 92747.17 | 32109.94 | 29383.25 | 6456.32 | 32864.47 | **MongoDB** |
| Single | Delete | 902.67 | 1849.20 | 370.01 | 1122.45 | 302.34 | 641.09 | **MongoDB** |
| Single | Insert | 778.59 | 2576.58 | 365.25 | 946.35 | 299.23 | 651.00 | **MongoDB** |
| Single | Select | 1977.97 | 1878.53 | 1763.83 | 2518.69 | 4245.41 | 928.12 | **SQLite** |
| Single | Update | 681.03 | 1685.10 | 349.38 | 901.17 | 294.76 | 243.35 | **MongoDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 84 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 18.29 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.43 | 348 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 18.99 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 36 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 11.60 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 1.43 MB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 1.03 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 2.17 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 57 | 87719.30 | 1.14 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 57 | 87719.30 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 1.11 | 1.83 MB | ✅ |
| Batch | Insert | 5,000 | 1,596 | 3132.83 | 0.82 | 1.48 MB | ✅ |
| Batch | Insert | 5,000 | 1,608 | 3109.45 | 0.73 | 4.28 MB | ✅ |
| Batch | Insert | 5,000 | 1,628 | 3071.25 | 0.64 | 1.91 MB | ✅ |
| Batch | Insert | 5,000 | 1,630 | 3067.48 | 0.80 | 1.89 MB | ✅ |
| Batch | Insert | 5,000 | 1,595 | 3134.80 | 0.82 | 3.29 MB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.94 | 12 KB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.94 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.80 | 0 B | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 5.36 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,862 | 2685.28 | 0.38 | 1.1 MB | ✅ |
| Batch | Update | 5,000 | 1,555 | 3215.43 | 0.63 | 12 KB | ✅ |
| Batch | Update | 5,000 | 1,545 | 3236.25 | 0.55 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,532 | 3263.71 | 0.47 | 3.86 MB | ✅ |
| Batch | Update | 5,000 | 1,542 | 3242.54 | 0.76 | 3.84 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 9,835 | 10.17 | 0.03 | 4.86 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 84 | 1190.48 | 1.54 | 248 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 102 | 980.39 | 1.91 | 1.15 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,554 | 1.80 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 10,171 | 9.83 | 0.00 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 166 | 602.41 | 0.78 | 1.63 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 42,734 | 2.34 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 55 | 1818.18 | 2.35 | 2.76 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 91 | 1098.90 | 4.29 | 20 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 97 | 1030.93 | 4.69 | 56 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 100 | 1000.00 | 4.54 | 3.24 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 81 | 1234.57 | 4.80 | 32 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 87 | 1149.43 | 2.23 | 4.18 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 447 | 17.90 | 0.15 | 0 B | ✅ |
| MillionData | Cleanup | 1,000,000 | 18,131 | 55154.16 | 0.01 | 1.34 MB | ✅ |
| MillionData | GroupBy | 32 | 1,780 | 2.25 | 0.00 | 32 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 24,261 | 41218.42 | 1.95 | 52.91 MB | ✅ |
| Single | Delete | 1,000 | 1,103 | 906.62 | 0.88 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,111 | 900.09 | 1.17 | 100 KB | ✅ |
| Single | Delete | 1,000 | 1,107 | 903.34 | 0.76 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,131 | 884.17 | 0.46 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,088 | 919.12 | 0.72 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,266 | 789.89 | 1.28 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,440 | 694.44 | 1.27 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,264 | 791.14 | 0.93 | 56 KB | ✅ |
| Single | Insert | 1,000 | 1,231 | 812.35 | 1.00 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,242 | 805.15 | 1.31 | 2.74 MB | ✅ |
| Single | Select | 1,000 | 497 | 2012.07 | 2.62 | 0 B | ✅ |
| Single | Select | 1,000 | 524 | 1908.40 | 2.86 | 88 KB | ✅ |
| Single | Select | 1,000 | 481 | 2079.00 | 2.43 | 0 B | ✅ |
| Single | Select | 1,000 | 563 | 1776.20 | 2.43 | 8 KB | ✅ |
| Single | Select | 1,000 | 473 | 2114.16 | 2.47 | 28 KB | ✅ |
| Single | Update | 1,000 | 1,509 | 662.69 | 1.42 | 0 B | ✅ |
| Single | Update | 1,000 | 1,504 | 664.89 | 1.17 | 0 B | ✅ |
| Single | Update | 1,000 | 1,478 | 676.59 | 1.36 | 0 B | ✅ |
| Single | Update | 1,000 | 1,453 | 688.23 | 0.99 | 4 KB | ✅ |
| Single | Update | 1,000 | 1,403 | 712.76 | 0.93 | 0 B | ✅ |

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.67 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.77 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.34 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 23 | 43.48 | 2.83 | 716 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.96 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 3.50 | 40 KB | ✅ |
| Batch | Delete | 5,000 | 43 | 116279.07 | 2.99 | 160 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 1.76 | 0 B | ✅ |
| Batch | Delete | 5,000 | 38 | 131578.95 | 1.67 | 1.48 MB | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 3.51 | 8 KB | ✅ |
| Batch | Insert | 5,000 | 54 | 92592.59 | 1.20 | 0 B | ✅ |
| Batch | Insert | 5,000 | 45 | 111111.11 | 1.45 | 348 KB | ✅ |
| Batch | Insert | 5,000 | 45 | 111111.11 | 1.44 | 360 KB | ✅ |
| Batch | Insert | 5,000 | 40 | 125000.00 | 4.85 | 304 KB | ✅ |
| Batch | Insert | 5,000 | 40 | 125000.00 | 4.83 | 360 KB | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 5.87 | 4 KB | ✅ |
| Batch | Select | 5,000 | 32 | 156250.00 | 4.04 | 12 KB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 2.14 | 0 B | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 6.22 | 0 B | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.22 | 0 B | ✅ |
| Batch | Update | 5,000 | 302 | 16556.29 | 1.51 | 4.07 MB | ✅ |
| Batch | Update | 5,000 | 194 | 25773.20 | 2.67 | 5.62 MB | ✅ |
| Batch | Update | 5,000 | 187 | 26737.97 | 2.09 | 3.64 MB | ✅ |
| Batch | Update | 5,000 | 182 | 27472.53 | 2.49 | 4.08 MB | ✅ |
| Batch | Update | 5,000 | 183 | 27322.40 | 1.42 | 3.63 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,454 | 28.95 | 0.11 | 12.89 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 115 | 869.57 | 2.26 | 328 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 119 | 840.34 | 1.09 | 240 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 4,407 | 2.27 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 35,597 | 2.81 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 228 | 438.60 | 1.14 | 516 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 64 | 1562.50 | 3.01 | 112 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 55 | 1818.18 | 3.49 | 560 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 126 | 793.65 | 1.03 | 100 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 128 | 781.25 | 1.01 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 133 | 751.88 | 2.44 | 396 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 124 | 806.45 | 1.04 | 880 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 133 | 751.88 | 2.93 | 4.71 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 861 | 9.29 | 0.08 | 384 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 21,389 | 46753.00 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,166 | 3.43 | 0.00 | 108 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 10,782 | 92747.17 | 2.17 | 42.71 MB | ✅ |
| Single | Delete | 1,000 | 542 | 1845.02 | 2.64 | 4.25 MB | ✅ |
| Single | Delete | 1,000 | 537 | 1862.20 | 3.03 | 11.37 MB | ✅ |
| Single | Delete | 1,000 | 545 | 1834.86 | 1.91 | 6.14 MB | ✅ |
| Single | Delete | 1,000 | 536 | 1865.67 | 3.28 | 10.17 MB | ✅ |
| Single | Delete | 1,000 | 544 | 1838.24 | 2.27 | 10.18 MB | ✅ |
| Single | Insert | 1,000 | 429 | 2331.00 | 4.09 | 14.83 MB | ✅ |
| Single | Insert | 1,000 | 365 | 2739.73 | 2.85 | 9.62 MB | ✅ |
| Single | Insert | 1,000 | 370 | 2702.70 | 1.23 | 5.92 MB | ✅ |
| Single | Insert | 1,000 | 413 | 2421.31 | 2.05 | 5.92 MB | ✅ |
| Single | Insert | 1,000 | 372 | 2688.17 | 1.57 | 5.92 MB | ✅ |
| Single | Select | 1,000 | 587 | 1703.58 | 5.76 | 7 MB | ✅ |
| Single | Select | 1,000 | 521 | 1919.39 | 2.50 | 5.25 MB | ✅ |
| Single | Select | 1,000 | 515 | 1941.75 | 3.28 | 5.32 MB | ✅ |
| Single | Select | 1,000 | 526 | 1901.14 | 2.72 | 5.33 MB | ✅ |
| Single | Select | 1,000 | 519 | 1926.78 | 3.39 | 5.33 MB | ✅ |
| Single | Update | 1,000 | 622 | 1607.72 | 3.77 | 0 B | ✅ |
| Single | Update | 1,000 | 585 | 1709.40 | 2.45 | 9.68 MB | ✅ |
| Single | Update | 1,000 | 587 | 1703.58 | 2.44 | 12.26 MB | ✅ |
| Single | Update | 1,000 | 580 | 1724.14 | 2.47 | 10.61 MB | ✅ |
| Single | Update | 1,000 | 595 | 1680.67 | 2.84 | 11.27 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 10 | 100.00 | 5.95 | 160 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 16.11 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 48.61 | 20 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 27 | 222.22 | 4.67 | 808 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 11.15 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 10.89 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 107 | 46728.97 | 0.61 | 44 KB | ✅ |
| Batch | Delete | 5,000 | 113 | 44247.79 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 98 | 51020.41 | 0.00 | 1.84 MB | ✅ |
| Batch | Delete | 5,000 | 93 | 53763.44 | 1.39 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 104 | 48076.92 | 1.25 | 0 B | ✅ |
| Batch | Insert | 5,000 | 1,539 | 3248.86 | 0.59 | 3.42 MB | ✅ |
| Batch | Insert | 5,000 | 1,731 | 2888.50 | 0.94 | 6.2 MB | ✅ |
| Batch | Insert | 5,000 | 1,768 | 2828.05 | 0.96 | 6.11 MB | ✅ |
| Batch | Insert | 5,000 | 1,636 | 3056.23 | 0.72 | 2.38 MB | ✅ |
| Batch | Insert | 5,000 | 1,671 | 2992.22 | 0.74 | 3.22 MB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 0.00 | 32 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.43 | 0 B | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.57 | 220 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.48 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.61 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,447 | 3455.43 | 0.40 | 88 KB | ✅ |
| Batch | Update | 5,000 | 1,549 | 3227.89 | 0.63 | 3.74 MB | ✅ |
| Batch | Update | 5,000 | 1,599 | 3126.95 | 0.53 | 4.25 MB | ✅ |
| Batch | Update | 5,000 | 1,598 | 3128.91 | 0.57 | 60 KB | ✅ |
| Batch | Update | 5,000 | 1,615 | 3095.98 | 0.64 | 796 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 2,509 | 39.86 | 0.16 | 6.62 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 99 | 1010.10 | 1.96 | 68 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 116 | 862.07 | 2.24 | 188 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,506 | 1.82 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 47,196 | 2.12 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 240 | 416.67 | 2.16 | 104 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 58,388 | 1.71 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 54 | 1851.85 | 3.57 | 264 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 105 | 952.38 | 6.18 | 16 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 109 | 917.43 | 3.55 | 32 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 107 | 934.58 | 1.21 | 16 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 101 | 990.10 | 1.92 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 98 | 1020.41 | 2.65 | 3.69 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 469 | 17.06 | 0.00 | 300 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 22,815 | 43830.81 | 0.01 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 2,572 | 1.56 | 0.00 | 184 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 31,143 | 32109.94 | 1.57 | 45.89 MB | ✅ |
| Single | Delete | 1,000 | 2,669 | 374.67 | 0.56 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,736 | 365.50 | 0.64 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,682 | 372.86 | 0.92 | 192 KB | ✅ |
| Single | Delete | 1,000 | 2,745 | 364.30 | 0.40 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,683 | 372.72 | 0.66 | 288 KB | ✅ |
| Single | Insert | 1,000 | 2,761 | 362.19 | 1.30 | 12.53 MB | ✅ |
| Single | Insert | 1,000 | 2,720 | 367.65 | 1.01 | 460 KB | ✅ |
| Single | Insert | 1,000 | 2,710 | 369.00 | 0.46 | 10 MB | ✅ |
| Single | Insert | 1,000 | 2,762 | 362.06 | 0.40 | 14.74 MB | ✅ |
| Single | Insert | 1,000 | 2,737 | 365.36 | 0.50 | 896 KB | ✅ |
| Single | Select | 1,000 | 569 | 1757.47 | 2.86 | 2.4 MB | ✅ |
| Single | Select | 1,000 | 571 | 1751.31 | 2.62 | 0 B | ✅ |
| Single | Select | 1,000 | 572 | 1748.25 | 2.39 | 3 MB | ✅ |
| Single | Select | 1,000 | 566 | 1766.78 | 2.76 | 2.87 MB | ✅ |
| Single | Select | 1,000 | 557 | 1795.33 | 2.10 | 0 B | ✅ |
| Single | Update | 1,000 | 2,813 | 355.49 | 0.81 | 368 KB | ✅ |
| Single | Update | 1,000 | 2,917 | 342.82 | 0.65 | 0 B | ✅ |
| Single | Update | 1,000 | 2,847 | 351.25 | 0.57 | 1.69 MB | ✅ |
| Single | Update | 1,000 | 2,865 | 349.04 | 0.64 | 0 B | ✅ |
| Single | Update | 1,000 | 2,871 | 348.31 | 0.45 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 33.35 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 48 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 260 KB | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 5.89 | 24 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 13.15 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 12.21 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 12.62 | 0 B | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.60 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.36 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 0.00 | 2.24 MB | ✅ |
| Batch | Insert | 5,000 | 1,161 | 4306.63 | 1.91 | 7 MB | ✅ |
| Batch | Insert | 5,000 | 1,059 | 4721.44 | 1.66 | 11.02 MB | ✅ |
| Batch | Insert | 5,000 | 1,050 | 4761.90 | 1.92 | 10.55 MB | ✅ |
| Batch | Insert | 5,000 | 986 | 5070.99 | 2.18 | 10.86 MB | ✅ |
| Batch | Insert | 5,000 | 877 | 5701.25 | 2.45 | 10.5 MB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.57 | 0 B | ✅ |
| Batch | Select | 5,000 | 319 | 15673.98 | 0.20 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.74 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 631 | 7923.93 | 2.68 | 0 B | ✅ |
| Batch | Update | 5,000 | 663 | 7541.48 | 1.96 | 0 B | ✅ |
| Batch | Update | 5,000 | 726 | 6887.05 | 1.26 | 3.6 MB | ✅ |
| Batch | Update | 5,000 | 594 | 8417.51 | 2.63 | 0 B | ✅ |
| Batch | Update | 5,000 | 675 | 7407.41 | 0.67 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 228 | 438.60 | 1.14 | 136 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 61 | 1639.34 | 5.33 | 568 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 78 | 1282.05 | 4.96 | 580 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 504 | 19.84 | 0.13 | 600 KB | ✅ |
| IndexQuery | OrderBy | 100 | 2,076 | 48.17 | 0.06 | 324 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 79 | 1265.82 | 3.29 | 2.14 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 6,621 | 15.10 | 0.05 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 43 | 2325.58 | 3.02 | 824 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 70 | 1428.57 | 3.72 | 156 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 68 | 1470.59 | 6.61 | 20 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 65 | 1538.46 | 3.98 | 36 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 60 | 1666.67 | 2.16 | 888 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 55 | 1818.18 | 3.54 | 1.05 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 196 | 40.82 | 0.00 | 1.38 MB | ✅ |
| MillionData | Cleanup | 1,000,000 | 4,618 | 216543.96 | 0.06 | 128 KB | ✅ |
| MillionData | GroupBy | 32 | 190 | 21.05 | 0.34 | 2.29 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 34,033 | 29383.25 | 3.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 883 | 1132.50 | 0.96 | 0 B | ✅ |
| Single | Delete | 1,000 | 930 | 1075.27 | 0.98 | 0 B | ✅ |
| Single | Delete | 1,000 | 868 | 1152.07 | 1.27 | 1.46 MB | ✅ |
| Single | Delete | 1,000 | 881 | 1135.07 | 0.89 | 1.39 MB | ✅ |
| Single | Delete | 1,000 | 895 | 1117.32 | 1.31 | 1.44 MB | ✅ |
| Single | Insert | 1,000 | 1,047 | 955.11 | 1.06 | 236 KB | ✅ |
| Single | Insert | 1,000 | 1,092 | 915.75 | 1.49 | 3.62 MB | ✅ |
| Single | Insert | 1,000 | 1,039 | 962.46 | 1.32 | 3.03 MB | ✅ |
| Single | Insert | 1,000 | 1,050 | 952.38 | 1.67 | 6.89 MB | ✅ |
| Single | Insert | 1,000 | 1,057 | 946.07 | 1.48 | 6.88 MB | ✅ |
| Single | Select | 1,000 | 381 | 2624.67 | 3.75 | 0 B | ✅ |
| Single | Select | 1,000 | 395 | 2531.65 | 2.96 | 3.96 MB | ✅ |
| Single | Select | 1,000 | 418 | 2392.34 | 2.96 | 4.83 MB | ✅ |
| Single | Select | 1,000 | 392 | 2551.02 | 2.66 | 6.99 MB | ✅ |
| Single | Select | 1,000 | 401 | 2493.77 | 2.76 | 11.07 MB | ✅ |
| Single | Update | 1,000 | 1,075 | 930.23 | 1.39 | 52 KB | ✅ |
| Single | Update | 1,000 | 1,163 | 859.85 | 1.29 | 0 B | ✅ |
| Single | Update | 1,000 | 1,099 | 909.92 | 1.72 | 0 B | ✅ |
| Single | Update | 1,000 | 1,108 | 902.53 | 1.29 | 0 B | ✅ |
| Single | Update | 1,000 | 1,107 | 903.34 | 1.06 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 300 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 25.75 | 208 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 52.58 | 364 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 14.04 | 328 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 25.61 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 28.63 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 60 | 83333.33 | 3.21 | 0 B | ✅ |
| Batch | Delete | 5,000 | 60 | 83333.33 | 2.14 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 4.38 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 3.35 | 0 B | ✅ |
| Batch | Delete | 5,000 | 60 | 83333.33 | 3.25 | 0 B | ✅ |
| Batch | Insert | 5,000 | 985 | 5076.14 | 4.09 | 5.39 MB | ✅ |
| Batch | Insert | 5,000 | 958 | 5219.21 | 4.35 | 0 B | ✅ |
| Batch | Insert | 5,000 | 951 | 5257.62 | 4.17 | 0 B | ✅ |
| Batch | Insert | 5,000 | 956 | 5230.13 | 4.22 | 228 KB | ✅ |
| Batch | Insert | 5,000 | 954 | 5241.09 | 4.09 | 4.07 MB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.24 | 4 KB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.35 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.14 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.32 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.19 | 0 B | ✅ |
| Batch | Update | 5,000 | 515 | 9708.74 | 4.04 | 688 KB | ✅ |
| Batch | Update | 5,000 | 508 | 9842.52 | 4.23 | 620 KB | ✅ |
| Batch | Update | 5,000 | 508 | 9842.52 | 4.10 | 220 KB | ✅ |
| Batch | Update | 5,000 | 505 | 9900.99 | 4.00 | 424 KB | ✅ |
| Batch | Update | 5,000 | 508 | 9842.52 | 4.10 | 4.25 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 59,587 | 1.68 | 4.16 | 596 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 108 | 925.93 | 4.21 | 12 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 148 | 675.68 | 4.39 | 0 B | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,812 | 1.47 | 4.17 | 16 KB | ✅ |
| IndexQuery | OrderBy | 100 | 65,124 | 1.54 | 4.16 | 860 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 205 | 487.80 | 4.12 | 4 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 57,473 | 1.74 | 4.16 | 2.6 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 24 | 4166.67 | 5.22 | 220 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 159 | 628.93 | 4.07 | 984 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 194 | 515.46 | 4.35 | 4.01 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 188 | 531.91 | 4.50 | 4 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 74 | 1351.35 | 4.36 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 76 | 1315.79 | 4.26 | 3.8 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 855 | 9.36 | 4.26 | 904 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 112,386 | 8897.91 | 3.53 | 5.71 MB | ✅ |
| MillionData | GroupBy | 32 | 13,014 | 0.31 | 4.17 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 154,887 | 6456.32 | 3.73 | 35.69 MB | ✅ |
| Single | Delete | 1,000 | 3,231 | 309.50 | 3.38 | 2.98 MB | ✅ |
| Single | Delete | 1,000 | 3,356 | 297.97 | 3.36 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,332 | 300.12 | 3.13 | 12 KB | ✅ |
| Single | Delete | 1,000 | 3,247 | 307.98 | 3.77 | 28 KB | ✅ |
| Single | Delete | 1,000 | 3,377 | 296.12 | 2.89 | 2.74 MB | ✅ |
| Single | Insert | 1,000 | 3,265 | 306.28 | 3.51 | 13.19 MB | ✅ |
| Single | Insert | 1,000 | 3,315 | 301.66 | 3.38 | 480 KB | ✅ |
| Single | Insert | 1,000 | 3,379 | 295.95 | 3.20 | 28 KB | ✅ |
| Single | Insert | 1,000 | 3,370 | 296.74 | 3.36 | 28 KB | ✅ |
| Single | Insert | 1,000 | 3,384 | 295.51 | 3.81 | 16 KB | ✅ |
| Single | Select | 1,000 | 242 | 4132.23 | 3.76 | 5.24 MB | ✅ |
| Single | Select | 1,000 | 236 | 4237.29 | 4.13 | 84 KB | ✅ |
| Single | Select | 1,000 | 232 | 4310.34 | 4.21 | 4 KB | ✅ |
| Single | Select | 1,000 | 235 | 4255.32 | 3.87 | 4 KB | ✅ |
| Single | Select | 1,000 | 233 | 4291.85 | 4.47 | 4 KB | ✅ |
| Single | Update | 1,000 | 3,444 | 290.36 | 3.63 | 2.68 MB | ✅ |
| Single | Update | 1,000 | 3,379 | 295.95 | 3.68 | 0 B | ✅ |
| Single | Update | 1,000 | 3,360 | 297.62 | 3.41 | 0 B | ✅ |
| Single | Update | 1,000 | 3,492 | 286.37 | 3.49 | 0 B | ✅ |
| Single | Update | 1,000 | 3,295 | 303.49 | 3.42 | 8 KB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 31 | 32.26 | 2.08 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 0.00 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 31 | 32.26 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 0.00 | 92 KB | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 2.25 | 32 KB | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 4.09 | 168 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.62 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 144 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.20 | 0 B | ✅ |
| Batch | Delete | 5,000 | 208 | 24038.46 | 0.31 | 744 KB | ✅ |
| Batch | Delete | 5,000 | 207 | 24154.59 | 0.31 | 132 KB | ✅ |
| Batch | Delete | 5,000 | 213 | 23474.18 | 0.61 | 344 KB | ✅ |
| Batch | Delete | 5,000 | 211 | 23696.68 | 0.31 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 213 | 23474.18 | 0.31 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,890 | 1022.49 | 0.15 | 6.11 MB | ✅ |
| Batch | Insert | 5,000 | 4,907 | 1018.95 | 0.19 | 440 KB | ✅ |
| Batch | Insert | 5,000 | 4,904 | 1019.58 | 0.13 | 616 KB | ✅ |
| Batch | Insert | 5,000 | 4,856 | 1029.65 | 0.12 | 2.04 MB | ✅ |
| Batch | Insert | 5,000 | 4,752 | 1052.19 | 0.15 | 1.16 MB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.34 | 16 KB | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 6.81 | 0 B | ✅ |
| Batch | Select | 5,000 | 18 | 277777.78 | 6.90 | 12 KB | ✅ |
| Batch | Select | 5,000 | 18 | 277777.78 | 3.53 | 0 B | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 0.00 | 440 KB | ✅ |
| Batch | Update | 5,000 | 2,671 | 1871.96 | 0.22 | 1.01 MB | ✅ |
| Batch | Update | 5,000 | 2,626 | 1904.04 | 0.27 | 68 KB | ✅ |
| Batch | Update | 5,000 | 2,573 | 1943.26 | 0.23 | 460 KB | ✅ |
| Batch | Update | 5,000 | 2,587 | 1932.74 | 0.35 | 2.61 MB | ✅ |
| Batch | Update | 5,000 | 2,481 | 2015.32 | 0.21 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,657 | 60.35 | 0.16 | 56 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 174 | 574.71 | 0.74 | 624 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 190 | 526.32 | 2.05 | 480 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,574 | 3.89 | 0.03 | 340 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,118 | 24.28 | 0.14 | 2.92 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 225 | 444.44 | 0.29 | 36 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,750 | 6.35 | 0.02 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 110 | 909.09 | 0.59 | 700 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 192 | 520.83 | 2.71 | 5.99 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 186 | 537.63 | 1.40 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 187 | 534.76 | 1.73 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 109 | 917.43 | 2.38 | 72 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 423 | 236.41 | 0.31 | 7.18 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 442 | 18.10 | 0.00 | 656 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 22,358 | 44726.72 | 0.01 | 408 KB | ✅ |
| MillionData | GroupBy | 32 | 115 | 34.78 | 1.12 | 12 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 30,428 | 32864.47 | 1.83 | 58.02 MB | ✅ |
| Single | Delete | 1,000 | 1,564 | 639.39 | 0.50 | 412 KB | ✅ |
| Single | Delete | 1,000 | 1,551 | 644.75 | 0.34 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,512 | 661.38 | 0.82 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,573 | 635.73 | 0.37 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,602 | 624.22 | 0.69 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,543 | 648.09 | 1.56 | 16.25 MB | ✅ |
| Single | Insert | 1,000 | 1,487 | 672.49 | 0.35 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,590 | 628.93 | 0.61 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,494 | 669.34 | 0.65 | 3.99 MB | ✅ |
| Single | Insert | 1,000 | 1,572 | 636.13 | 0.33 | 0 B | ✅ |
| Single | Select | 1,000 | 1,100 | 909.09 | 1.36 | 4.98 MB | ✅ |
| Single | Select | 1,000 | 1,077 | 928.51 | 0.79 | 0 B | ✅ |
| Single | Select | 1,000 | 1,073 | 931.97 | 0.85 | 0 B | ✅ |
| Single | Select | 1,000 | 1,078 | 927.64 | 0.60 | 7 MB | ✅ |
| Single | Select | 1,000 | 1,060 | 943.40 | 0.80 | 124 KB | ✅ |
| Single | Update | 1,000 | 3,617 | 276.47 | 0.31 | 3.97 MB | ✅ |
| Single | Update | 1,000 | 3,582 | 279.17 | 0.24 | 0 B | ✅ |
| Single | Update | 1,000 | 3,605 | 277.39 | 0.36 | 68 KB | ✅ |
| Single | Update | 1,000 | 3,822 | 261.64 | 0.32 | 3.31 MB | ✅ |
| Single | Update | 1,000 | 8,193 | 122.06 | 0.10 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 11.34 | 9.76 | 14.13 | 6.67 | 15.67 | 0.87 |
| Aggregation | Statistics | 2.32 | 3.56 | 5.34 | 8.77 | 13.66 | 4.18 |
| Batch | Delete | 1.09 | 2.69 | 0.65 | 1.39 | 3.27 | 0.37 |
| Batch | Insert | 0.76 | 2.75 | 0.79 | 2.02 | 4.18 | 0.15 |
| Batch | Select | 4.01 | 4.50 | 4.42 | 2.90 | 5.05 | 4.72 |
| Batch | Update | 0.56 | 2.04 | 0.55 | 1.84 | 4.09 | 0.26 |
| IndexQuery | ComplexCondition | 0.03 | 0.11 | 0.16 | 1.14 | 4.16 | 0.16 |
| IndexQuery | CompositeIndex_RegionDept | 1.54 | 2.26 | 1.96 | 5.33 | 4.21 | 0.74 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.91 | 1.09 | 2.24 | 4.96 | 4.39 | 2.05 |
| IndexQuery | NoIndex_FullScan | 0.00 | 0.00 | 0.00 | 0.13 | 4.17 | 0.03 |
| IndexQuery | OrderBy | 0.00 | 0.01 | 0.01 | 0.06 | 4.16 | 0.14 |
| IndexQuery | Pagination | 0.78 | 1.14 | 2.16 | 3.29 | 4.12 | 0.29 |
| IndexQuery | PrefixQuery_Name | 0.01 | 3.01 | 0.01 | 0.05 | 4.16 | 0.02 |
| IndexQuery | PrimaryKey | 2.35 | 3.49 | 3.57 | 3.02 | 5.22 | 0.59 |
| IndexQuery | RangeQuery_Date | 4.29 | 1.03 | 6.18 | 3.72 | 4.07 | 2.71 |
| IndexQuery | RangeQuery_Salary | 4.69 | 1.01 | 3.55 | 6.61 | 4.35 | 1.40 |
| IndexQuery | RangeQuery_Score | 4.54 | 2.44 | 1.21 | 3.98 | 4.50 | 1.73 |
| IndexQuery | SingleIndex_Category | 4.80 | 1.04 | 1.92 | 2.16 | 4.36 | 2.38 |
| IndexQuery | SingleIndex_Status | 2.23 | 2.93 | 2.65 | 3.54 | 4.26 | 0.31 |
| MillionData | Aggregation | 0.15 | 0.08 | 0.00 | 0.00 | 4.26 | 0.00 |
| MillionData | Cleanup | 0.01 | 0.00 | 0.01 | 0.06 | 3.53 | 0.01 |
| MillionData | GroupBy | 0.00 | 0.00 | 0.00 | 0.34 | 4.17 | 1.12 |
| MillionData | PrepareData | 1.95 | 2.17 | 1.57 | 3.45 | 3.73 | 1.83 |
| Single | Delete | 0.80 | 2.63 | 0.64 | 1.08 | 3.31 | 0.54 |
| Single | Insert | 1.16 | 2.36 | 0.73 | 1.40 | 3.45 | 0.70 |
| Single | Select | 2.56 | 3.53 | 2.55 | 3.02 | 4.09 | 0.88 |
| Single | Update | 1.17 | 2.79 | 0.62 | 1.35 | 3.53 | 0.27 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 348 KB | 12 KB | 160 KB | 260 KB | 364 KB | 92 KB |
| Aggregation | Statistics | 1.43 MB | 716 KB | 808 KB | 24 KB | 328 KB | 168 KB |
| Batch | Delete | 1.83 MB | 1.48 MB | 1.84 MB | 2.24 MB | 0 B | 744 KB |
| Batch | Insert | 4.28 MB | 360 KB | 6.2 MB | 11.02 MB | 5.39 MB | 6.11 MB |
| Batch | Select | 12 KB | 12 KB | 220 KB | 4 KB | 4 KB | 440 KB |
| Batch | Update | 3.86 MB | 5.62 MB | 4.25 MB | 3.6 MB | 4.25 MB | 2.61 MB |
| IndexQuery | ComplexCondition | 4.86 MB | 12.89 MB | 6.62 MB | 136 KB | 596 KB | 56 KB |
| IndexQuery | CompositeIndex_RegionDept | 248 KB | 328 KB | 68 KB | 568 KB | 12 KB | 624 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.15 MB | 240 KB | 188 KB | 580 KB | 0 B | 480 KB |
| IndexQuery | NoIndex_FullScan | 0 B | 0 B | 0 B | 600 KB | 16 KB | 340 KB |
| IndexQuery | OrderBy | 0 B | 0 B | 0 B | 324 KB | 860 KB | 2.92 MB |
| IndexQuery | Pagination | 1.63 MB | 516 KB | 104 KB | 2.14 MB | 4 KB | 36 KB |
| IndexQuery | PrefixQuery_Name | 0 B | 112 KB | 0 B | 0 B | 2.6 MB | 0 B |
| IndexQuery | PrimaryKey | 2.76 MB | 560 KB | 264 KB | 824 KB | 220 KB | 700 KB |
| IndexQuery | RangeQuery_Date | 20 KB | 100 KB | 16 KB | 156 KB | 984 KB | 5.99 MB |
| IndexQuery | RangeQuery_Salary | 56 KB | 0 B | 32 KB | 20 KB | 4.01 MB | 0 B |
| IndexQuery | RangeQuery_Score | 3.24 MB | 396 KB | 16 KB | 36 KB | 4 KB | 0 B |
| IndexQuery | SingleIndex_Category | 32 KB | 880 KB | 0 B | 888 KB | 0 B | 72 KB |
| IndexQuery | SingleIndex_Status | 4.18 MB | 4.71 MB | 3.69 MB | 1.05 MB | 3.8 MB | 7.18 MB |
| MillionData | Aggregation | 0 B | 384 KB | 300 KB | 1.38 MB | 904 KB | 656 KB |
| MillionData | Cleanup | 1.34 MB | 0 B | 0 B | 128 KB | 5.71 MB | 408 KB |
| MillionData | GroupBy | 32 KB | 108 KB | 184 KB | 2.29 MB | 0 B | 12 KB |
| MillionData | PrepareData | 52.91 MB | 42.71 MB | 45.89 MB | 0 B | 35.69 MB | 58.02 MB |
| Single | Delete | 100 KB | 11.37 MB | 288 KB | 1.46 MB | 2.98 MB | 412 KB |
| Single | Insert | 2.74 MB | 14.83 MB | 14.74 MB | 6.89 MB | 13.19 MB | 16.25 MB |
| Single | Select | 88 KB | 7 MB | 3 MB | 11.07 MB | 5.24 MB | 7 MB |
| Single | Update | 4 KB | 12.26 MB | 1.69 MB | 52 KB | 2.68 MB | 3.97 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 14:04:08*
