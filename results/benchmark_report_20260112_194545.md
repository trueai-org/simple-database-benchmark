# 数据库基准测试报告

**测试时间**: 2026-01-12 19:45:45

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
| 采集时间 | 2026-01-12 19:45:45 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, MariaDB, SQLServer, PostgreSQL, SQLite, MongoDB, Oracle |
| 数据库数量 | 7 |
| 总测试用例数 | 469 |
| 成功用例数 | 469 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.00 | 3.00 | 5.00 | 2.60 | 1.40 | 2.20 | 30.00 | **PostgreSQL** |
| Aggregation | Statistics | 6.40 | 6.80 | 9.60 | 7.40 | 6.00 | 2.20 | 9.20 | **SQLite** |
| Batch | Delete | 59.40 | 33.20 | 111.60 | 348.00 | 18.80 | 55.00 | 214.80 | **PostgreSQL** |
| Batch | Insert | 1470.60 | 35.20 | 1565.00 | 4406.00 | 522.60 | 887.00 | 4782.60 | **MongoDB** |
| Batch | Select | 11.40 | 31.80 | 12.60 | 49.60 | 69.80 | 18.00 | 16.40 | **MariaDB** |
| Batch | Update | 1451.80 | 159.40 | 1475.20 | 4681.00 | 368.80 | 469.40 | 2549.60 | **MongoDB** |
| IndexQuery | ComplexCondition | 9971.00 | 2199.00 | 1488.00 | 1893.00 | 303.00 | 58388.00 | 2283.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 91.00 | 121.00 | 101.00 | 528.00 | 65.00 | 104.00 | 192.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 110.00 | 125.00 | 105.00 | 470.00 | 97.00 | 146.00 | 220.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 5214.00 | 3046.00 | 6305.00 | 2232.00 | 545.00 | 6698.00 | 2670.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10212.00 | 25902.00 | 47123.00 | 32010.00 | 2101.00 | 63959.00 | 5019.00 | **PostgreSQL** |
| IndexQuery | Pagination | 176.00 | 198.00 | 244.00 | 320.00 | 72.00 | 195.00 | 234.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 44722.00 | 65.00 | 59204.00 | 18424.00 | 6879.00 | 57011.00 | 15203.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 53.00 | 60.00 | 72.00 | 124.00 | 46.00 | 23.00 | 143.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 96.00 | 117.00 | 98.00 | 791.00 | 70.00 | 157.00 | 211.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 99.00 | 142.00 | 115.00 | 1055.00 | 70.00 | 188.00 | 210.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 101.00 | 150.00 | 108.00 | 1571.00 | 65.00 | 184.00 | 195.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 88.00 | 130.00 | 94.00 | 531.00 | 61.00 | 74.00 | 115.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 81.00 | 124.00 | 90.00 | 109.00 | 741.00 | 72.00 | 422.00 | **SQLite** |
| MillionData | Aggregation | 457.00 | 538.00 | 479.00 | 235.00 | 203.00 | 838.00 | 489.00 | **PostgreSQL** |
| MillionData | Cleanup | 18442.00 | 15330.00 | 24265.00 | 864394.00 | 4165.00 | 138003.00 | 31906.00 | **PostgreSQL** |
| MillionData | GroupBy | 1888.00 | 985.00 | 2640.00 | 587.00 | 199.00 | 12641.00 | 237.00 | **PostgreSQL** |
| MillionData | PrepareData | 25048.00 | 9611.00 | 30963.00 | 1602236.00 | 33625.00 | 149614.00 | 30841.00 | **MongoDB** |
| Single | Delete | 1136.20 | 535.20 | 2767.80 | 1562.60 | 872.20 | 3210.00 | 1596.60 | **MongoDB** |
| Single | Insert | 1236.20 | 427.40 | 2803.80 | 1245.00 | 984.00 | 3160.40 | 1591.80 | **MongoDB** |
| Single | Select | 516.60 | 540.00 | 612.20 | 1028.80 | 402.40 | 190.80 | 1058.80 | **SQLite** |
| Single | Update | 1425.40 | 595.00 | 2886.80 | 1955.20 | 1043.60 | 3149.40 | 3690.60 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 333.33 | 333.33 | 266.66 | 416.67 | 800.00 | 466.67 | 33.51 | **PostgreSQL** |
| Aggregation | Statistics | 954.28 | 259.52 | 899.43 | 814.28 | 1053.33 | 2800.00 | 706.19 | **SQLite** |
| Batch | Delete | 85162.01 | 151646.20 | 44916.80 | 14970.40 | 267897.69 | 93088.84 | 23280.77 | **PostgreSQL** |
| Batch | Insert | 3402.89 | 142282.17 | 3199.60 | 1134.82 | 9704.31 | 5919.29 | 1045.83 | **MongoDB** |
| Batch | Select | 445671.00 | 157575.76 | 398351.65 | 100985.91 | 507122.83 | 300000.00 | 308782.37 | **PostgreSQL** |
| Batch | Update | 3444.64 | 31415.99 | 3389.96 | 1068.59 | 13804.90 | 11236.35 | 1961.88 | **MongoDB** |
| IndexQuery | ComplexCondition | 10.03 | 45.48 | 67.20 | 52.83 | 330.03 | 1.71 | 43.80 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 1098.90 | 826.45 | 990.10 | 189.39 | 1538.46 | 961.54 | 520.83 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 909.09 | 800.00 | 952.38 | 212.77 | 1030.93 | 684.93 | 454.55 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 1.92 | 3.28 | 1.59 | 4.48 | 18.35 | 1.49 | 3.75 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.79 | 3.86 | 2.12 | 3.12 | 47.60 | 1.56 | 19.92 | **PostgreSQL** |
| IndexQuery | Pagination | 568.18 | 505.05 | 409.84 | 312.50 | 1388.89 | 512.82 | 427.35 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.24 | 1538.46 | 1.69 | 5.43 | 14.54 | 1.75 | 6.58 | **MongoDB** |
| IndexQuery | PrimaryKey | 1886.79 | 1666.67 | 1388.89 | 806.45 | 2173.91 | 4347.83 | 699.30 | **SQLite** |
| IndexQuery | RangeQuery_Date | 1041.67 | 854.70 | 1020.41 | 126.42 | 1428.57 | 636.94 | 473.93 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 1010.10 | 704.23 | 869.57 | 94.79 | 1428.57 | 531.91 | 476.19 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 990.10 | 666.67 | 925.93 | 63.65 | 1538.46 | 543.48 | 512.82 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 1136.36 | 769.23 | 1063.83 | 188.32 | 1639.34 | 1351.35 | 869.57 | **PostgreSQL** |
| IndexQuery | SingleIndex_Status | 1234.57 | 806.45 | 1111.11 | 917.43 | 134.95 | 1388.89 | 236.97 | **SQLite** |
| MillionData | Aggregation | 17.51 | 14.87 | 16.70 | 34.04 | 39.41 | 9.55 | 16.36 | **PostgreSQL** |
| MillionData | Cleanup | 54224.05 | 65231.57 | 41211.62 | 1156.88 | 240096.04 | 7246.22 | 31342.07 | **PostgreSQL** |
| MillionData | GroupBy | 2.12 | 4.06 | 1.52 | 6.81 | 20.10 | 0.32 | 16.88 | **PostgreSQL** |
| MillionData | PrepareData | 39923.35 | 104047.45 | 32296.61 | 624.13 | 29739.78 | 6683.87 | 32424.37 | **MongoDB** |
| Single | Delete | 880.49 | 1869.81 | 361.39 | 641.96 | 1148.34 | 313.39 | 627.74 | **MongoDB** |
| Single | Insert | 809.34 | 2385.00 | 356.68 | 858.26 | 1017.22 | 320.97 | 628.54 | **MongoDB** |
| Single | Select | 1936.18 | 1863.66 | 1634.81 | 972.20 | 2485.51 | 5977.14 | 946.24 | **SQLite** |
| Single | Update | 701.82 | 1684.53 | 346.49 | 520.89 | 963.57 | 321.54 | 272.30 | **MongoDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 18.71 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 364 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 104 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 17.56 | 36 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.62 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 10.99 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.96 | 1.42 MB | ✅ |
| Batch | Delete | 5,000 | 54 | 92592.59 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 73 | 68493.15 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 2.31 | 0 B | ✅ |
| Batch | Delete | 5,000 | 57 | 87719.30 | 2.25 | 0 B | ✅ |
| Batch | Delete | 5,000 | 57 | 87719.30 | 1.13 | 0 B | ✅ |
| Batch | Insert | 5,000 | 1,474 | 3392.13 | 0.31 | 3.89 MB | ✅ |
| Batch | Insert | 5,000 | 1,488 | 3360.22 | 0.39 | 7.1 MB | ✅ |
| Batch | Insert | 5,000 | 1,410 | 3546.10 | 0.60 | 1.33 MB | ✅ |
| Batch | Insert | 5,000 | 1,443 | 3465.00 | 0.23 | 2.04 MB | ✅ |
| Batch | Insert | 5,000 | 1,538 | 3250.98 | 0.42 | 2.09 MB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.57 | 4 KB | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 0.00 | 28 KB | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.21 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.90 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,466 | 3410.64 | 0.13 | 2.8 MB | ✅ |
| Batch | Update | 5,000 | 1,479 | 3380.66 | 0.66 | 8 KB | ✅ |
| Batch | Update | 5,000 | 1,432 | 3491.62 | 0.45 | 4.05 MB | ✅ |
| Batch | Update | 5,000 | 1,427 | 3503.85 | 0.36 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,455 | 3436.43 | 0.18 | 8.08 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 9,971 | 10.03 | 0.01 | 260 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 91 | 1098.90 | 5.70 | 620 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 110 | 909.09 | 1.77 | 1.74 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,214 | 1.92 | 0.01 | 184 KB | ✅ |
| IndexQuery | OrderBy | 100 | 10,212 | 9.79 | 0.04 | 3.83 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 176 | 568.18 | 0.74 | 1.14 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 44,722 | 2.24 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 53 | 1886.79 | 3.62 | 4.96 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 96 | 1041.67 | 1.35 | 240 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 99 | 1010.10 | 1.31 | 168 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 101 | 990.10 | 1.29 | 3.94 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 88 | 1136.36 | 3.69 | 344 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 81 | 1234.57 | 2.40 | 588 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 457 | 17.51 | 0.14 | 368 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 18,442 | 54224.05 | 0.02 | 636 KB | ✅ |
| MillionData | GroupBy | 32 | 1,888 | 2.12 | 0.03 | 1 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 25,048 | 39923.35 | 1.98 | 96.76 MB | ✅ |
| Single | Delete | 1,000 | 1,174 | 851.79 | 0.83 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,122 | 891.27 | 0.87 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,152 | 868.06 | 1.02 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,120 | 892.86 | 1.63 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,113 | 898.47 | 0.58 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,254 | 797.45 | 1.04 | 10.82 MB | ✅ |
| Single | Insert | 1,000 | 1,203 | 831.26 | 0.81 | 4.99 MB | ✅ |
| Single | Insert | 1,000 | 1,276 | 783.70 | 1.07 | 4.63 MB | ✅ |
| Single | Insert | 1,000 | 1,207 | 828.50 | 1.29 | 3.8 MB | ✅ |
| Single | Insert | 1,000 | 1,241 | 805.80 | 0.84 | 8.57 MB | ✅ |
| Single | Select | 1,000 | 525 | 1904.76 | 2.60 | 5.98 MB | ✅ |
| Single | Select | 1,000 | 521 | 1919.39 | 1.75 | 0 B | ✅ |
| Single | Select | 1,000 | 517 | 1934.24 | 2.64 | 2.17 MB | ✅ |
| Single | Select | 1,000 | 502 | 1992.03 | 2.85 | 0 B | ✅ |
| Single | Select | 1,000 | 518 | 1930.50 | 1.88 | 0 B | ✅ |
| Single | Update | 1,000 | 1,433 | 697.84 | 1.27 | 92 KB | ✅ |
| Single | Update | 1,000 | 1,398 | 715.31 | 1.44 | 92 KB | ✅ |
| Single | Update | 1,000 | 1,424 | 702.25 | 0.91 | 0 B | ✅ |
| Single | Update | 1,000 | 1,473 | 678.89 | 0.97 | 0 B | ✅ |
| Single | Update | 1,000 | 1,399 | 714.80 | 0.74 | 0 B | ✅ |

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.96 | 24 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 39.55 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 21 | 47.62 | 3.03 | 660 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 15.96 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 19.52 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 37 | 135135.14 | 0.00 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 3.52 | 60 KB | ✅ |
| Batch | Delete | 5,000 | 31 | 161290.32 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 32 | 156250.00 | 2.02 | 1.48 MB | ✅ |
| Batch | Delete | 5,000 | 30 | 166666.67 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 38 | 131578.95 | 5.08 | 0 B | ✅ |
| Batch | Insert | 5,000 | 35 | 142857.14 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 34 | 147058.82 | 1.90 | 0 B | ✅ |
| Batch | Insert | 5,000 | 34 | 147058.82 | 3.80 | 0 B | ✅ |
| Batch | Insert | 5,000 | 35 | 142857.14 | 3.66 | 0 B | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 3.94 | 12 KB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 10.53 | 8 KB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.28 | 0 B | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 3.89 | 456 KB | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 3.89 | 0 B | ✅ |
| Batch | Update | 5,000 | 161 | 31055.90 | 2.02 | 36 KB | ✅ |
| Batch | Update | 5,000 | 170 | 29411.76 | 3.06 | 0 B | ✅ |
| Batch | Update | 5,000 | 160 | 31250.00 | 2.03 | 24 KB | ✅ |
| Batch | Update | 5,000 | 154 | 32467.53 | 2.10 | 24 KB | ✅ |
| Batch | Update | 5,000 | 152 | 32894.74 | 3.83 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 2,199 | 45.48 | 0.18 | 9.32 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 121 | 826.45 | 2.14 | 6 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 125 | 800.00 | 1.04 | 8.14 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 3,046 | 3.28 | 0.02 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 25,902 | 3.86 | 0.03 | 3 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 198 | 505.05 | 0.66 | 10 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 65 | 1538.46 | 0.00 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 60 | 1666.67 | 4.34 | 484 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 117 | 854.70 | 2.22 | 8.07 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 142 | 704.23 | 2.28 | 8.02 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 150 | 666.67 | 1.73 | 8.31 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 130 | 769.23 | 2.50 | 972 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 124 | 806.45 | 3.67 | 372 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 538 | 14.87 | 0.00 | 408 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 15,330 | 65231.57 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 985 | 4.06 | 0.00 | 964 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 9,611 | 104047.45 | 2.36 | 55.09 MB | ✅ |
| Single | Delete | 1,000 | 560 | 1785.71 | 1.86 | 2.72 MB | ✅ |
| Single | Delete | 1,000 | 542 | 1845.02 | 2.40 | 2.55 MB | ✅ |
| Single | Delete | 1,000 | 525 | 1904.76 | 2.35 | 2.51 MB | ✅ |
| Single | Delete | 1,000 | 530 | 1886.79 | 2.21 | 2.75 MB | ✅ |
| Single | Delete | 1,000 | 519 | 1926.78 | 2.13 | 3.71 MB | ✅ |
| Single | Insert | 1,000 | 437 | 2288.33 | 5.36 | 12.77 MB | ✅ |
| Single | Insert | 1,000 | 543 | 1841.62 | 1.08 | 13.65 MB | ✅ |
| Single | Insert | 1,000 | 382 | 2617.80 | 1.87 | 13.8 MB | ✅ |
| Single | Insert | 1,000 | 409 | 2444.99 | 1.27 | 13.8 MB | ✅ |
| Single | Insert | 1,000 | 366 | 2732.24 | 1.07 | 13.81 MB | ✅ |
| Single | Select | 1,000 | 568 | 1760.56 | 6.42 | 4.23 MB | ✅ |
| Single | Select | 1,000 | 613 | 1631.32 | 2.86 | 5.52 MB | ✅ |
| Single | Select | 1,000 | 498 | 2008.03 | 1.70 | 5.55 MB | ✅ |
| Single | Select | 1,000 | 517 | 1934.24 | 2.39 | 6.8 MB | ✅ |
| Single | Select | 1,000 | 504 | 1984.13 | 2.58 | 6.7 MB | ✅ |
| Single | Update | 1,000 | 651 | 1536.10 | 3.99 | 10.68 MB | ✅ |
| Single | Update | 1,000 | 587 | 1703.58 | 2.55 | 8.5 MB | ✅ |
| Single | Update | 1,000 | 580 | 1724.14 | 2.24 | 8.51 MB | ✅ |
| Single | Update | 1,000 | 591 | 1692.05 | 2.53 | 7.52 MB | ✅ |
| Single | Update | 1,000 | 566 | 1766.78 | 2.18 | 7.51 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.36 | 208 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 76 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 92 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 25 | 240.00 | 5.07 | 688 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.65 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 102 | 49019.61 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 119 | 42016.81 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 111 | 45045.05 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 112 | 44642.86 | 1.16 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 114 | 43859.65 | 0.57 | 4 KB | ✅ |
| Batch | Insert | 5,000 | 1,673 | 2988.64 | 0.78 | 6.13 MB | ✅ |
| Batch | Insert | 5,000 | 1,569 | 3186.74 | 0.71 | 4.15 MB | ✅ |
| Batch | Insert | 5,000 | 1,486 | 3364.74 | 0.66 | 4.74 MB | ✅ |
| Batch | Insert | 5,000 | 1,546 | 3234.15 | 0.59 | 5.95 MB | ✅ |
| Batch | Insert | 5,000 | 1,551 | 3223.73 | 0.50 | 2.13 MB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 10.37 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.86 | 1.04 MB | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,482 | 3373.82 | 0.44 | 224 KB | ✅ |
| Batch | Update | 5,000 | 1,464 | 3415.30 | 0.53 | 68 KB | ✅ |
| Batch | Update | 5,000 | 1,469 | 3403.68 | 0.35 | 472 KB | ✅ |
| Batch | Update | 5,000 | 1,452 | 3443.53 | 0.40 | 7.15 MB | ✅ |
| Batch | Update | 5,000 | 1,509 | 3313.45 | 0.26 | 1.76 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,488 | 67.20 | 0.52 | 6.86 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 101 | 990.10 | 1.29 | 32 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 105 | 952.38 | 1.23 | 48 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,305 | 1.59 | 0.01 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 47,123 | 2.12 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 244 | 409.84 | 1.33 | 20 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 59,204 | 1.69 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 72 | 1388.89 | 0.90 | 72 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 98 | 1020.41 | 3.31 | 4 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 115 | 869.57 | 2.25 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 108 | 925.93 | 1.80 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 94 | 1063.83 | 2.74 | 16 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 90 | 1111.11 | 0.72 | 4 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 479 | 16.70 | 0.41 | 920 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 24,265 | 41211.62 | 0.02 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 2,640 | 1.52 | 0.05 | 196 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 30,963 | 32296.61 | 1.54 | 60.75 MB | ✅ |
| Single | Delete | 1,000 | 2,704 | 369.82 | 0.65 | 4.34 MB | ✅ |
| Single | Delete | 1,000 | 2,770 | 361.01 | 0.49 | 8 KB | ✅ |
| Single | Delete | 1,000 | 2,756 | 362.84 | 0.54 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,846 | 351.37 | 0.34 | 216 KB | ✅ |
| Single | Delete | 1,000 | 2,763 | 361.93 | 0.45 | 344 KB | ✅ |
| Single | Insert | 1,000 | 2,832 | 353.11 | 1.47 | 9.42 MB | ✅ |
| Single | Insert | 1,000 | 2,811 | 355.75 | 0.63 | 5.4 MB | ✅ |
| Single | Insert | 1,000 | 2,814 | 355.37 | 0.39 | 3.57 MB | ✅ |
| Single | Insert | 1,000 | 2,781 | 359.58 | 0.51 | 2.79 MB | ✅ |
| Single | Insert | 1,000 | 2,781 | 359.58 | 0.66 | 8.54 MB | ✅ |
| Single | Select | 1,000 | 605 | 1652.89 | 2.26 | 744 KB | ✅ |
| Single | Select | 1,000 | 598 | 1672.24 | 3.70 | 0 B | ✅ |
| Single | Select | 1,000 | 647 | 1545.60 | 1.81 | 0 B | ✅ |
| Single | Select | 1,000 | 611 | 1636.66 | 3.09 | 2.25 MB | ✅ |
| Single | Select | 1,000 | 600 | 1666.67 | 2.28 | 16 KB | ✅ |
| Single | Update | 1,000 | 2,838 | 352.36 | 0.53 | 0 B | ✅ |
| Single | Update | 1,000 | 2,852 | 350.63 | 0.59 | 0 B | ✅ |
| Single | Update | 1,000 | 2,890 | 346.02 | 0.79 | 332 KB | ✅ |
| Single | Update | 1,000 | 2,970 | 336.70 | 0.88 | 88 KB | ✅ |
| Single | Update | 1,000 | 2,884 | 346.74 | 0.50 | 88 KB | ✅ |

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 15.50 | 744 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 472 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 47.57 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 23.56 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 24.58 | 296 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 16.01 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.61 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.49 | 0 B | ✅ |
| Batch | Delete | 5,000 | 466 | 10729.61 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 386 | 12953.37 | 0.17 | 0 B | ✅ |
| Batch | Delete | 5,000 | 267 | 18726.59 | 0.00 | 2.89 MB | ✅ |
| Batch | Delete | 5,000 | 284 | 17605.63 | 0.23 | 2.89 MB | ✅ |
| Batch | Delete | 5,000 | 337 | 14836.80 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,425 | 1129.94 | 0.35 | 2.75 MB | ✅ |
| Batch | Insert | 5,000 | 4,389 | 1139.21 | 0.28 | 5.65 MB | ✅ |
| Batch | Insert | 5,000 | 4,397 | 1137.14 | 0.34 | 2.68 MB | ✅ |
| Batch | Insert | 5,000 | 4,409 | 1134.04 | 0.18 | 1.33 MB | ✅ |
| Batch | Insert | 5,000 | 4,410 | 1133.79 | 0.44 | 4.27 MB | ✅ |
| Batch | Select | 5,000 | 51 | 98039.22 | 3.80 | 0 B | ✅ |
| Batch | Select | 5,000 | 52 | 96153.85 | 1.24 | 0 B | ✅ |
| Batch | Select | 5,000 | 49 | 102040.82 | 3.94 | 0 B | ✅ |
| Batch | Select | 5,000 | 46 | 108695.65 | 4.20 | 344 KB | ✅ |
| Batch | Select | 5,000 | 50 | 100000.00 | 2.60 | 44 KB | ✅ |
| Batch | Update | 5,000 | 4,868 | 1027.12 | 0.39 | 15.47 MB | ✅ |
| Batch | Update | 5,000 | 4,597 | 1087.67 | 0.28 | 18.18 MB | ✅ |
| Batch | Update | 5,000 | 4,662 | 1072.50 | 0.27 | 12.34 MB | ✅ |
| Batch | Update | 5,000 | 4,630 | 1079.91 | 0.34 | 12.32 MB | ✅ |
| Batch | Update | 5,000 | 4,648 | 1075.73 | 0.27 | 18.57 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,893 | 52.83 | 0.24 | 84 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 528 | 189.39 | 0.74 | 136 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 470 | 212.77 | 0.55 | 32 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,232 | 4.48 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 32,010 | 3.12 | 0.01 | 76 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 320 | 312.50 | 0.61 | 6.45 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 18,424 | 5.43 | 0.01 | 160 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 124 | 806.45 | 1.57 | 44 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 791 | 126.42 | 0.49 | 8 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 1,055 | 94.79 | 0.37 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 1,571 | 63.65 | 0.21 | 32 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 531 | 188.32 | 0.61 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 109 | 917.43 | 1.78 | 4.65 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 235 | 34.04 | 0.00 | 16 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 864,394 | 1156.88 | 0.00 | 2.24 MB | ✅ |
| MillionData | GroupBy | 32 | 587 | 6.81 | 0.00 | 136 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 1,602,236 | 624.13 | 0.18 | 26.15 MB | ✅ |
| Single | Delete | 1,000 | 1,537 | 650.62 | 0.59 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,494 | 669.34 | 0.61 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,739 | 575.04 | 0.26 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,499 | 667.11 | 0.56 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,544 | 647.67 | 0.80 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,028 | 972.76 | 2.22 | 7.21 MB | ✅ |
| Single | Insert | 1,000 | 1,991 | 502.26 | 0.56 | 13.71 MB | ✅ |
| Single | Insert | 1,000 | 1,045 | 956.94 | 0.87 | 13.27 MB | ✅ |
| Single | Insert | 1,000 | 1,153 | 867.30 | 0.90 | 17.55 MB | ✅ |
| Single | Insert | 1,000 | 1,008 | 992.06 | 0.84 | 17.55 MB | ✅ |
| Single | Select | 1,000 | 1,047 | 955.11 | 1.12 | 6.04 MB | ✅ |
| Single | Select | 1,000 | 1,014 | 986.19 | 0.96 | 14.73 MB | ✅ |
| Single | Select | 1,000 | 1,039 | 962.46 | 1.32 | 14.73 MB | ✅ |
| Single | Select | 1,000 | 1,010 | 990.10 | 0.90 | 2.53 MB | ✅ |
| Single | Select | 1,000 | 1,034 | 967.12 | 0.76 | 2.53 MB | ✅ |
| Single | Update | 1,000 | 2,516 | 397.46 | 0.83 | 0 B | ✅ |
| Single | Update | 1,000 | 1,855 | 539.08 | 0.56 | 0 B | ✅ |
| Single | Update | 1,000 | 1,728 | 578.70 | 0.60 | 0 B | ✅ |
| Single | Update | 1,000 | 1,774 | 563.70 | 0.92 | 6.47 MB | ✅ |
| Single | Update | 1,000 | 1,903 | 525.49 | 1.03 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 32 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 32.93 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.87 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 12.64 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 3.72 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 6.50 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 21 | 238095.24 | 0.00 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 614 | 8143.32 | 1.91 | 13.95 MB | ✅ |
| Batch | Insert | 5,000 | 518 | 9652.51 | 2.76 | 14.22 MB | ✅ |
| Batch | Insert | 5,000 | 447 | 11185.68 | 1.75 | 13.67 MB | ✅ |
| Batch | Insert | 5,000 | 569 | 8787.35 | 1.60 | 18.59 MB | ✅ |
| Batch | Insert | 5,000 | 465 | 10752.69 | 1.68 | 13.72 MB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.38 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 317 | 15772.87 | 0.41 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 298 | 16778.52 | 1.74 | 564 KB | ✅ |
| Batch | Update | 5,000 | 441 | 11337.87 | 1.47 | 0 B | ✅ |
| Batch | Update | 5,000 | 361 | 13850.42 | 1.44 | 0 B | ✅ |
| Batch | Update | 5,000 | 342 | 14619.88 | 1.33 | 3.08 MB | ✅ |
| Batch | Update | 5,000 | 402 | 12437.81 | 1.45 | 8.09 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 303 | 330.03 | 0.64 | 72 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 65 | 1538.46 | 1.99 | 56 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 97 | 1030.93 | 4.00 | 56 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 545 | 18.35 | 0.24 | 148 KB | ✅ |
| IndexQuery | OrderBy | 100 | 2,101 | 47.60 | 0.09 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 72 | 1388.89 | 2.71 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 6,879 | 14.54 | 0.04 | 1.65 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 46 | 2173.91 | 5.65 | 60 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 70 | 1428.57 | 3.67 | 4 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 70 | 1428.57 | 2.77 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 65 | 1538.46 | 1.99 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 61 | 1639.34 | 0.00 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 741 | 134.95 | 0.18 | 100 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 203 | 39.41 | 0.32 | 260 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 4,165 | 240096.04 | 0.06 | 748 KB | ✅ |
| MillionData | GroupBy | 32 | 199 | 20.10 | 0.00 | 1.44 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 33,625 | 29739.78 | 3.44 | 57.9 MB | ✅ |
| Single | Delete | 1,000 | 835 | 1197.60 | 0.86 | 0 B | ✅ |
| Single | Delete | 1,000 | 935 | 1069.52 | 0.90 | 0 B | ✅ |
| Single | Delete | 1,000 | 843 | 1186.24 | 1.39 | 0 B | ✅ |
| Single | Delete | 1,000 | 876 | 1141.55 | 1.11 | 0 B | ✅ |
| Single | Delete | 1,000 | 872 | 1146.79 | 0.97 | 0 B | ✅ |
| Single | Insert | 1,000 | 967 | 1034.13 | 1.55 | 6.93 MB | ✅ |
| Single | Insert | 1,000 | 987 | 1013.17 | 1.19 | 4.1 MB | ✅ |
| Single | Insert | 1,000 | 973 | 1027.75 | 1.47 | 2.8 MB | ✅ |
| Single | Insert | 1,000 | 952 | 1050.42 | 1.71 | 15.04 MB | ✅ |
| Single | Insert | 1,000 | 1,041 | 960.61 | 1.37 | 16.17 MB | ✅ |
| Single | Select | 1,000 | 399 | 2506.27 | 2.44 | 4.04 MB | ✅ |
| Single | Select | 1,000 | 396 | 2525.25 | 2.30 | 3.98 MB | ✅ |
| Single | Select | 1,000 | 407 | 2457.00 | 3.03 | 7.98 MB | ✅ |
| Single | Select | 1,000 | 400 | 2500.00 | 2.93 | 0 B | ✅ |
| Single | Select | 1,000 | 410 | 2439.02 | 1.91 | 0 B | ✅ |
| Single | Update | 1,000 | 972 | 1028.81 | 1.27 | 0 B | ✅ |
| Single | Update | 1,000 | 1,201 | 832.64 | 0.87 | 0 B | ✅ |
| Single | Update | 1,000 | 1,005 | 995.02 | 1.36 | 0 B | ✅ |
| Single | Update | 1,000 | 1,002 | 998.00 | 1.10 | 0 B | ✅ |
| Single | Update | 1,000 | 1,038 | 963.39 | 1.25 | 1020 KB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.35 | 268 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 25.32 | 276 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 156 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 25.98 | 372 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 25.13 | 200 KB | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 2000.00 | 19.65 | 312 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 27.16 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 27.75 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 28.18 | 0 B | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 4.77 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 4.39 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 4.45 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 8.71 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 3.31 | 0 B | ✅ |
| Batch | Insert | 5,000 | 558 | 8960.57 | 4.08 | 5.75 MB | ✅ |
| Batch | Insert | 5,000 | 971 | 5149.33 | 4.15 | 6.79 MB | ✅ |
| Batch | Insert | 5,000 | 970 | 5154.64 | 4.09 | 288 KB | ✅ |
| Batch | Insert | 5,000 | 957 | 5224.66 | 4.21 | 2.02 MB | ✅ |
| Batch | Insert | 5,000 | 979 | 5107.25 | 4.06 | 1.85 MB | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.43 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.46 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.33 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.43 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.39 | 0 B | ✅ |
| Batch | Update | 5,000 | 289 | 17301.04 | 4.28 | 0 B | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 3.93 | 188 KB | ✅ |
| Batch | Update | 5,000 | 510 | 9803.92 | 3.95 | 132 KB | ✅ |
| Batch | Update | 5,000 | 508 | 9842.52 | 3.97 | 0 B | ✅ |
| Batch | Update | 5,000 | 527 | 9487.67 | 4.07 | 216 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 58,388 | 1.71 | 4.16 | 16 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 104 | 961.54 | 4.37 | 4 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 146 | 684.93 | 4.43 | 0 B | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,698 | 1.49 | 4.17 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 63,959 | 1.56 | 4.16 | 236 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 195 | 512.82 | 4.33 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 57,011 | 1.75 | 4.16 | 1.77 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 23 | 4347.83 | 5.65 | 88 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 157 | 636.94 | 4.54 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 188 | 531.91 | 4.14 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 184 | 543.48 | 4.58 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 74 | 1351.35 | 4.39 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 72 | 1388.89 | 3.57 | 308 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 838 | 9.55 | 4.19 | 24 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 138,003 | 7246.22 | 3.46 | 4.64 MB | ✅ |
| MillionData | GroupBy | 32 | 12,641 | 0.32 | 4.16 | 1.14 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 149,614 | 6683.87 | 3.69 | 59.95 MB | ✅ |
| Single | Delete | 1,000 | 2,751 | 363.50 | 3.19 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,294 | 303.58 | 3.89 | 48 KB | ✅ |
| Single | Delete | 1,000 | 3,413 | 293.00 | 3.55 | 8 KB | ✅ |
| Single | Delete | 1,000 | 3,328 | 300.48 | 3.64 | 4 KB | ✅ |
| Single | Delete | 1,000 | 3,264 | 306.37 | 3.83 | 12 KB | ✅ |
| Single | Insert | 1,000 | 2,652 | 377.07 | 3.66 | 12.93 MB | ✅ |
| Single | Insert | 1,000 | 2,780 | 359.71 | 2.83 | 7.38 MB | ✅ |
| Single | Insert | 1,000 | 3,394 | 294.64 | 3.28 | 4.34 MB | ✅ |
| Single | Insert | 1,000 | 3,459 | 289.10 | 3.54 | 6.7 MB | ✅ |
| Single | Insert | 1,000 | 3,517 | 284.33 | 3.54 | 2.83 MB | ✅ |
| Single | Select | 1,000 | 114 | 8771.93 | 4.54 | 136 KB | ✅ |
| Single | Select | 1,000 | 115 | 8695.65 | 4.51 | 64 KB | ✅ |
| Single | Select | 1,000 | 242 | 4132.23 | 4.29 | 24 KB | ✅ |
| Single | Select | 1,000 | 236 | 4237.29 | 4.40 | 4 KB | ✅ |
| Single | Select | 1,000 | 247 | 4048.58 | 4.21 | 1.9 MB | ✅ |
| Single | Update | 1,000 | 2,693 | 371.33 | 3.12 | 9 MB | ✅ |
| Single | Update | 1,000 | 2,767 | 361.40 | 3.25 | 8.96 MB | ✅ |
| Single | Update | 1,000 | 3,435 | 291.12 | 3.60 | 4 KB | ✅ |
| Single | Update | 1,000 | 3,386 | 295.33 | 3.94 | 6.98 MB | ✅ |
| Single | Update | 1,000 | 3,466 | 288.52 | 3.29 | 7.97 MB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 34 | 29.41 | 1.86 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 31 | 32.26 | 2.09 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 0.00 | 88 KB | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 0.00 | 56 KB | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 0.00 | 100 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.34 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 211 | 23696.68 | 0.62 | 632 KB | ✅ |
| Batch | Delete | 5,000 | 214 | 23364.49 | 0.61 | 136 KB | ✅ |
| Batch | Delete | 5,000 | 215 | 23255.81 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 215 | 23255.81 | 0.60 | 76 KB | ✅ |
| Batch | Delete | 5,000 | 219 | 22831.05 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,892 | 1022.08 | 0.05 | 7.07 MB | ✅ |
| Batch | Insert | 5,000 | 4,886 | 1023.33 | 0.16 | 1.8 MB | ✅ |
| Batch | Insert | 5,000 | 4,753 | 1051.97 | 0.12 | 5.27 MB | ✅ |
| Batch | Insert | 5,000 | 4,680 | 1068.38 | 0.10 | 3.5 MB | ✅ |
| Batch | Insert | 5,000 | 4,702 | 1063.38 | 0.04 | 3.99 MB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 8.01 | 4 KB | ✅ |
| Batch | Select | 5,000 | 18 | 277777.78 | 6.88 | 4 KB | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 3.37 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 8.87 | 0 B | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.29 | 448 KB | ✅ |
| Batch | Update | 5,000 | 2,534 | 1973.16 | 0.26 | 4.84 MB | ✅ |
| Batch | Update | 5,000 | 2,645 | 1890.36 | 0.27 | 3.97 MB | ✅ |
| Batch | Update | 5,000 | 2,496 | 2003.21 | 0.34 | 4.08 MB | ✅ |
| Batch | Update | 5,000 | 2,556 | 1956.18 | 0.08 | 4.89 MB | ✅ |
| Batch | Update | 5,000 | 2,517 | 1986.49 | 0.13 | 3.11 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 2,283 | 43.80 | 0.20 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 192 | 520.83 | 1.02 | 32 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 220 | 454.55 | 1.48 | 32 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,670 | 3.75 | 0.02 | 392 KB | ✅ |
| IndexQuery | OrderBy | 100 | 5,019 | 19.92 | 0.13 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 234 | 427.35 | 1.66 | 6.06 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,203 | 6.58 | 0.02 | 268 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 143 | 699.30 | 0.91 | 32 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 211 | 473.93 | 2.15 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 210 | 476.19 | 1.24 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 195 | 512.82 | 1.67 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 115 | 869.57 | 2.25 | 32 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 422 | 236.97 | 0.46 | 4.73 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 489 | 16.36 | 0.27 | 68 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 31,906 | 31342.07 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 237 | 16.88 | 0.00 | 200 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 30,841 | 32424.37 | 1.77 | 78.77 MB | ✅ |
| Single | Delete | 1,000 | 1,620 | 617.28 | 0.56 | 16 KB | ✅ |
| Single | Delete | 1,000 | 1,726 | 579.37 | 0.72 | 24 KB | ✅ |
| Single | Delete | 1,000 | 1,585 | 630.91 | 0.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,556 | 642.67 | 0.75 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,496 | 668.45 | 0.52 | 1.28 MB | ✅ |
| Single | Insert | 1,000 | 1,575 | 634.92 | 0.74 | 11.68 MB | ✅ |
| Single | Insert | 1,000 | 1,648 | 606.80 | 0.67 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,609 | 621.50 | 0.36 | 6.75 MB | ✅ |
| Single | Insert | 1,000 | 1,588 | 629.72 | 0.70 | 8.89 MB | ✅ |
| Single | Insert | 1,000 | 1,539 | 649.77 | 0.55 | 10.13 MB | ✅ |
| Single | Select | 1,000 | 1,117 | 895.26 | 0.82 | 8.38 MB | ✅ |
| Single | Select | 1,000 | 1,087 | 919.96 | 0.90 | 4 KB | ✅ |
| Single | Select | 1,000 | 1,080 | 925.93 | 1.08 | 460 KB | ✅ |
| Single | Select | 1,000 | 1,008 | 992.06 | 0.84 | 3 MB | ✅ |
| Single | Select | 1,000 | 1,002 | 998.00 | 0.84 | 3 MB | ✅ |
| Single | Update | 1,000 | 3,769 | 265.32 | 0.24 | 0 B | ✅ |
| Single | Update | 1,000 | 3,701 | 270.20 | 0.30 | 0 B | ✅ |
| Single | Update | 1,000 | 4,131 | 242.07 | 0.22 | 3.13 MB | ✅ |
| Single | Update | 1,000 | 3,483 | 287.11 | 0.41 | 0 B | ✅ |
| Single | Update | 1,000 | 3,369 | 296.82 | 0.37 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 3.74 | 11.30 | 1.07 | 22.24 | 6.59 | 18.56 | 0.79 |
| Aggregation | Statistics | 9.43 | 7.70 | 2.94 | 6.42 | 3.90 | 20.55 | 1.67 |
| Batch | Delete | 1.14 | 1.11 | 0.35 | 0.08 | 2.04 | 5.13 | 0.37 |
| Batch | Insert | 0.39 | 2.89 | 0.65 | 0.32 | 1.94 | 4.12 | 0.09 |
| Batch | Select | 3.34 | 5.31 | 3.05 | 3.16 | 1.76 | 6.41 | 7.08 |
| Batch | Update | 0.36 | 2.61 | 0.40 | 0.31 | 1.49 | 4.04 | 0.22 |
| IndexQuery | ComplexCondition | 0.01 | 0.18 | 0.52 | 0.24 | 0.64 | 4.16 | 0.20 |
| IndexQuery | CompositeIndex_RegionDept | 5.70 | 2.14 | 1.29 | 0.74 | 1.99 | 4.37 | 1.02 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.77 | 1.04 | 1.23 | 0.55 | 4.00 | 4.43 | 1.48 |
| IndexQuery | NoIndex_FullScan | 0.01 | 0.02 | 0.01 | 0.00 | 0.24 | 4.17 | 0.02 |
| IndexQuery | OrderBy | 0.04 | 0.03 | 0.01 | 0.01 | 0.09 | 4.16 | 0.13 |
| IndexQuery | Pagination | 0.74 | 0.66 | 1.33 | 0.61 | 2.71 | 4.33 | 1.66 |
| IndexQuery | PrefixQuery_Name | 0.01 | 0.00 | 0.01 | 0.01 | 0.04 | 4.16 | 0.02 |
| IndexQuery | PrimaryKey | 3.62 | 4.34 | 0.90 | 1.57 | 5.65 | 5.65 | 0.91 |
| IndexQuery | RangeQuery_Date | 1.35 | 2.22 | 3.31 | 0.49 | 3.67 | 4.54 | 2.15 |
| IndexQuery | RangeQuery_Salary | 1.31 | 2.28 | 2.25 | 0.37 | 2.77 | 4.14 | 1.24 |
| IndexQuery | RangeQuery_Score | 1.29 | 1.73 | 1.80 | 0.21 | 1.99 | 4.58 | 1.67 |
| IndexQuery | SingleIndex_Category | 3.69 | 2.50 | 2.74 | 0.61 | 0.00 | 4.39 | 2.25 |
| IndexQuery | SingleIndex_Status | 2.40 | 3.67 | 0.72 | 1.78 | 0.18 | 3.57 | 0.46 |
| MillionData | Aggregation | 0.14 | 0.00 | 0.41 | 0.00 | 0.32 | 4.19 | 0.27 |
| MillionData | Cleanup | 0.02 | 0.00 | 0.02 | 0.00 | 0.06 | 3.46 | 0.00 |
| MillionData | GroupBy | 0.03 | 0.00 | 0.05 | 0.00 | 0.00 | 4.16 | 0.00 |
| MillionData | PrepareData | 1.98 | 2.36 | 1.54 | 0.18 | 3.44 | 3.69 | 1.77 |
| Single | Delete | 0.99 | 2.19 | 0.49 | 0.56 | 1.05 | 3.62 | 0.60 |
| Single | Insert | 1.01 | 2.13 | 0.73 | 1.08 | 1.46 | 3.37 | 0.60 |
| Single | Select | 2.34 | 3.19 | 2.63 | 1.01 | 2.52 | 4.39 | 0.90 |
| Single | Update | 1.07 | 2.70 | 0.66 | 0.79 | 1.17 | 3.44 | 0.31 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 364 KB | 24 KB | 208 KB | 744 KB | 60 KB | 372 KB | 88 KB |
| Aggregation | Statistics | 1.42 MB | 660 KB | 688 KB | 0 B | 4 KB | 312 KB | 100 KB |
| Batch | Delete | 12 KB | 1.48 MB | 36 KB | 2.89 MB | 24 KB | 0 B | 632 KB |
| Batch | Insert | 7.1 MB | 0 B | 6.13 MB | 5.65 MB | 18.59 MB | 6.79 MB | 7.07 MB |
| Batch | Select | 28 KB | 456 KB | 1.04 MB | 344 KB | 0 B | 0 B | 448 KB |
| Batch | Update | 8.08 MB | 36 KB | 7.15 MB | 18.57 MB | 8.09 MB | 216 KB | 4.89 MB |
| IndexQuery | ComplexCondition | 260 KB | 9.32 MB | 6.86 MB | 84 KB | 72 KB | 16 KB | 0 B |
| IndexQuery | CompositeIndex_RegionDept | 620 KB | 6 MB | 32 KB | 136 KB | 56 KB | 4 KB | 32 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.74 MB | 8.14 MB | 48 KB | 32 KB | 56 KB | 0 B | 32 KB |
| IndexQuery | NoIndex_FullScan | 184 KB | 0 B | 0 B | 0 B | 148 KB | 0 B | 392 KB |
| IndexQuery | OrderBy | 3.83 MB | 3 MB | 0 B | 76 KB | 0 B | 236 KB | 0 B |
| IndexQuery | Pagination | 1.14 MB | 10 MB | 20 KB | 6.45 MB | 0 B | 0 B | 6.06 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 0 B | 0 B | 160 KB | 1.65 MB | 1.77 MB | 268 KB |
| IndexQuery | PrimaryKey | 4.96 MB | 484 KB | 72 KB | 44 KB | 60 KB | 88 KB | 32 KB |
| IndexQuery | RangeQuery_Date | 240 KB | 8.07 MB | 4 KB | 8 KB | 4 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Salary | 168 KB | 8.02 MB | 0 B | 0 B | 0 B | 0 B | 0 B |
| IndexQuery | RangeQuery_Score | 3.94 MB | 8.31 MB | 8 KB | 32 KB | 0 B | 0 B | 0 B |
| IndexQuery | SingleIndex_Category | 344 KB | 972 KB | 16 KB | 0 B | 0 B | 0 B | 32 KB |
| IndexQuery | SingleIndex_Status | 588 KB | 372 KB | 4 KB | 4.65 MB | 100 KB | 308 KB | 4.73 MB |
| MillionData | Aggregation | 368 KB | 408 KB | 920 KB | 16 KB | 260 KB | 24 KB | 68 KB |
| MillionData | Cleanup | 636 KB | 0 B | 0 B | 2.24 MB | 748 KB | 4.64 MB | 0 B |
| MillionData | GroupBy | 1 MB | 964 KB | 196 KB | 136 KB | 1.44 MB | 1.14 MB | 200 KB |
| MillionData | PrepareData | 96.76 MB | 55.09 MB | 60.75 MB | 26.15 MB | 57.9 MB | 59.95 MB | 78.77 MB |
| Single | Delete | 8 KB | 3.71 MB | 4.34 MB | 0 B | 0 B | 48 KB | 1.28 MB |
| Single | Insert | 10.82 MB | 13.81 MB | 9.42 MB | 17.55 MB | 16.17 MB | 12.93 MB | 11.68 MB |
| Single | Select | 5.98 MB | 6.8 MB | 2.25 MB | 14.73 MB | 7.98 MB | 1.9 MB | 8.38 MB |
| Single | Update | 92 KB | 10.68 MB | 332 KB | 6.47 MB | 1020 KB | 9 MB | 3.13 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 19:45:45*
