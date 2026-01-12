# 数据库基准测试报告

**测试时间**: 2026-01-12 23:44:00

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
| 采集时间 | 2026-01-12 23:44:00 |


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
| Aggregation | GroupBy | 3.20 | 2.60 | 6.20 | 2.20 | 1.80 | 2.00 | 31.40 | **PostgreSQL** |
| Aggregation | Statistics | 5.60 | 6.00 | 13.00 | 7.00 | 6.20 | 1.80 | 9.00 | **SQLite** |
| Batch | Delete | 55.00 | 30.40 | 98.60 | 498.80 | 18.40 | 54.20 | 212.00 | **PostgreSQL** |
| Batch | Insert | 1445.40 | 32.20 | 1632.80 | 4409.20 | 577.60 | 843.20 | 4813.60 | **MongoDB** |
| Batch | Select | 10.80 | 25.20 | 14.80 | 44.20 | 70.80 | 15.80 | 15.60 | **MariaDB** |
| Batch | Update | 1420.40 | 146.20 | 1516.00 | 4618.80 | 359.00 | 423.40 | 2645.40 | **MongoDB** |
| IndexQuery | ComplexCondition | 10160.00 | 3736.00 | 1559.00 | 1664.00 | 4427.00 | 58613.00 | 1190.00 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 90.00 | 102.00 | 94.00 | 561.00 | 63.00 | 104.00 | 188.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 107.00 | 96.00 | 101.00 | 605.00 | 71.00 | 148.00 | 197.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 5892.00 | 2869.00 | 5511.00 | 2482.00 | 516.00 | 6717.00 | 2476.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10174.00 | 25846.00 | 47402.00 | 32376.00 | 3900.00 | 61260.00 | 4186.00 | **PostgreSQL** |
| IndexQuery | Pagination | 182.00 | 166.00 | 254.00 | 388.00 | 79.00 | 102.00 | 272.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 42167.00 | 54.00 | 60472.00 | 21074.00 | 7745.00 | 37612.00 | 15196.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 57.00 | 55.00 | 63.00 | 207.00 | 45.00 | 24.00 | 115.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 89.00 | 99.00 | 96.00 | 701.00 | 64.00 | 161.00 | 200.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 96.00 | 107.00 | 104.00 | 1634.00 | 82.00 | 189.00 | 192.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 98.00 | 107.00 | 116.00 | 1733.00 | 84.00 | 188.00 | 192.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 82.00 | 112.00 | 88.00 | 1190.00 | 741.00 | 73.00 | 121.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 86.00 | 115.00 | 88.00 | 116.00 | 1106.00 | 75.00 | 428.00 | **SQLite** |
| MillionData | Aggregation | 454.00 | 561.00 | 478.00 | 269.00 | 197.00 | 834.00 | 456.00 | **PostgreSQL** |
| MillionData | Cleanup | 18202.00 | 14862.00 | 25360.00 | 1838724.00 | 3699.00 | 132571.00 | 21157.00 | **PostgreSQL** |
| MillionData | GroupBy | 1767.00 | 997.00 | 2645.00 | 1423.00 | 174.00 | 12615.00 | 116.00 | **SQLServer** |
| MillionData | PrepareData | 24269.00 | 9346.00 | 25807.00 | 1759340.00 | 34346.00 | 139529.00 | 30947.00 | **MongoDB** |
| Single | Delete | 1092.20 | 538.40 | 2711.60 | 1609.20 | 847.60 | 3140.00 | 1567.60 | **MongoDB** |
| Single | Insert | 1189.00 | 393.80 | 2789.80 | 1142.00 | 971.00 | 3115.20 | 1516.40 | **MongoDB** |
| Single | Select | 508.00 | 526.60 | 582.80 | 1013.20 | 394.40 | 193.80 | 1063.40 | **SQLite** |
| Single | Update | 1357.80 | 585.80 | 2885.40 | 1767.20 | 993.60 | 3142.20 | 4297.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 316.66 | 400.00 | 261.11 | 466.67 | 666.67 | 566.67 | 31.90 | **PostgreSQL** |
| Aggregation | Statistics | 1100.00 | 277.78 | 812.86 | 864.28 | 1120.00 | 3600.00 | 722.86 | **SQLite** |
| Batch | Delete | 90957.87 | 165001.30 | 50808.35 | 11943.13 | 273109.25 | 95460.83 | 23590.37 | **PostgreSQL** |
| Batch | Insert | 3460.07 | 156071.63 | 3073.14 | 1134.15 | 9547.82 | 6257.38 | 1038.82 | **MongoDB** |
| Batch | Select | 463636.36 | 206581.66 | 343837.54 | 113565.51 | 538800.70 | 361111.11 | 323004.20 | **PostgreSQL** |
| Batch | Update | 3520.30 | 38958.34 | 3302.01 | 1082.64 | 14121.50 | 12853.29 | 1891.28 | **MongoDB** |
| IndexQuery | ComplexCondition | 9.84 | 26.77 | 64.14 | 60.10 | 22.59 | 1.71 | 84.03 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 1111.11 | 980.39 | 1063.83 | 178.25 | 1587.30 | 961.54 | 531.91 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 934.58 | 1041.67 | 990.10 | 165.29 | 1408.45 | 675.68 | 507.61 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 1.70 | 3.49 | 1.81 | 4.03 | 19.38 | 1.49 | 4.04 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.83 | 3.87 | 2.11 | 3.09 | 25.64 | 1.63 | 23.89 | **PostgreSQL** |
| IndexQuery | Pagination | 549.45 | 602.41 | 393.70 | 257.73 | 1265.82 | 980.39 | 367.65 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.37 | 1851.85 | 1.65 | 4.75 | 12.91 | 2.66 | 6.58 | **MongoDB** |
| IndexQuery | PrimaryKey | 1754.39 | 1818.18 | 1587.30 | 483.09 | 2222.22 | 4166.67 | 869.57 | **SQLite** |
| IndexQuery | RangeQuery_Date | 1123.60 | 1010.10 | 1041.67 | 142.65 | 1562.50 | 621.12 | 500.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 1041.67 | 934.58 | 961.54 | 61.20 | 1219.51 | 529.10 | 520.83 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 1020.41 | 934.58 | 862.07 | 57.70 | 1190.48 | 531.91 | 520.83 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 1219.51 | 892.86 | 1136.36 | 84.03 | 134.95 | 1369.86 | 826.45 | **SQLite** |
| IndexQuery | SingleIndex_Status | 1162.79 | 869.57 | 1136.36 | 862.07 | 90.42 | 1333.33 | 233.64 | **SQLite** |
| MillionData | Aggregation | 17.62 | 14.26 | 16.74 | 29.74 | 40.61 | 9.59 | 17.54 | **PostgreSQL** |
| MillionData | Cleanup | 54939.02 | 67285.70 | 39432.18 | 543.86 | 270343.34 | 7543.13 | 47265.68 | **PostgreSQL** |
| MillionData | GroupBy | 2.26 | 4.01 | 1.51 | 2.81 | 22.99 | 0.32 | 34.48 | **SQLServer** |
| MillionData | PrepareData | 41204.83 | 106997.65 | 38749.18 | 568.39 | 29115.47 | 7166.97 | 32313.31 | **MongoDB** |
| Single | Delete | 915.87 | 1858.66 | 368.82 | 622.35 | 1180.05 | 321.42 | 638.39 | **MongoDB** |
| Single | Insert | 841.12 | 2547.71 | 358.79 | 888.48 | 1031.08 | 324.55 | 659.78 | **MongoDB** |
| Single | Select | 1968.77 | 1900.76 | 1719.00 | 987.41 | 2536.65 | 5813.74 | 941.13 | **SQLite** |
| Single | Update | 736.80 | 1707.66 | 346.71 | 567.76 | 1006.60 | 323.49 | 250.55 | **MongoDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 20.12 | 424 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.03 | 104 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 80 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.76 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.96 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 1.5 MB | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 2.31 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 53 | 94339.62 | 1.21 | 0 B | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 54 | 92592.59 | 1.20 | 0 B | ✅ |
| Batch | Insert | 5,000 | 1,481 | 3376.10 | 0.44 | 5.82 MB | ✅ |
| Batch | Insert | 5,000 | 1,447 | 3455.43 | 0.76 | 5.32 MB | ✅ |
| Batch | Insert | 5,000 | 1,411 | 3543.59 | 0.46 | 4.68 MB | ✅ |
| Batch | Insert | 5,000 | 1,443 | 3465.00 | 0.54 | 4.76 MB | ✅ |
| Batch | Insert | 5,000 | 1,445 | 3460.21 | 0.59 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.58 | 8 KB | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.35 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.71 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.57 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,424 | 3511.24 | 0.27 | 1.18 MB | ✅ |
| Batch | Update | 5,000 | 1,409 | 3548.62 | 0.23 | 12 KB | ✅ |
| Batch | Update | 5,000 | 1,421 | 3518.65 | 0.05 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,436 | 3481.89 | 0.14 | 3.05 MB | ✅ |
| Batch | Update | 5,000 | 1,412 | 3541.08 | 0.14 | 7.42 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 10,160 | 9.84 | 0.08 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 90 | 1111.11 | 5.02 | 240 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 107 | 934.58 | 1.81 | 1.21 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,892 | 1.70 | 0.02 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 10,174 | 9.83 | 0.03 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 182 | 549.45 | 1.07 | 1.52 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 42,167 | 2.37 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 57 | 1754.39 | 4.51 | 2.88 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 89 | 1123.60 | 2.19 | 40 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 96 | 1041.67 | 3.39 | 40 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 98 | 1020.41 | 3.29 | 3.09 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 82 | 1219.51 | 4.72 | 32 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 86 | 1162.79 | 3.02 | 40 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 454 | 17.62 | 0.00 | 60 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 18,202 | 54939.02 | 0.03 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,767 | 2.26 | 0.00 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 24,269 | 41204.83 | 1.91 | 80.63 MB | ✅ |
| Single | Delete | 1,000 | 1,118 | 894.45 | 1.40 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,093 | 914.91 | 1.19 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,061 | 942.51 | 1.04 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,084 | 922.51 | 0.78 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,105 | 904.98 | 1.12 | 8 KB | ✅ |
| Single | Insert | 1,000 | 1,205 | 829.88 | 1.35 | 11.96 MB | ✅ |
| Single | Insert | 1,000 | 1,185 | 843.88 | 1.26 | 3.5 MB | ✅ |
| Single | Insert | 1,000 | 1,178 | 848.90 | 1.33 | 3.53 MB | ✅ |
| Single | Insert | 1,000 | 1,200 | 833.33 | 0.70 | 4.74 MB | ✅ |
| Single | Insert | 1,000 | 1,177 | 849.62 | 1.00 | 3.6 MB | ✅ |
| Single | Select | 1,000 | 507 | 1972.39 | 3.47 | 5.96 MB | ✅ |
| Single | Select | 1,000 | 508 | 1968.50 | 2.69 | 0 B | ✅ |
| Single | Select | 1,000 | 504 | 1984.13 | 1.93 | 0 B | ✅ |
| Single | Select | 1,000 | 519 | 1926.78 | 2.26 | 0 B | ✅ |
| Single | Select | 1,000 | 502 | 1992.03 | 2.59 | 32 KB | ✅ |
| Single | Update | 1,000 | 1,359 | 735.84 | 0.91 | 84 KB | ✅ |
| Single | Update | 1,000 | 1,304 | 766.87 | 0.85 | 84 KB | ✅ |
| Single | Update | 1,000 | 1,382 | 723.59 | 0.47 | 92 KB | ✅ |
| Single | Update | 1,000 | 1,371 | 729.39 | 0.90 | 88 KB | ✅ |
| Single | Update | 1,000 | 1,373 | 728.33 | 1.00 | 0 B | ✅ |

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 24 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 22.26 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 20.51 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 16 KB | ✅ |
| Aggregation | Statistics | 5,000 | 18 | 55.56 | 7.04 | 656 KB | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 19.31 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 3 | 333.33 | 19.90 | 0 B | ✅ |
| Batch | Delete | 5,000 | 29 | 172413.79 | 2.19 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 33 | 151515.15 | 3.84 | 40 KB | ✅ |
| Batch | Delete | 5,000 | 29 | 172413.79 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 32 | 156250.00 | 3.95 | 1.42 MB | ✅ |
| Batch | Delete | 5,000 | 29 | 172413.79 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 29 | 172413.79 | 4.39 | 20 KB | ✅ |
| Batch | Insert | 5,000 | 31 | 161290.32 | 0.00 | 56 KB | ✅ |
| Batch | Insert | 5,000 | 32 | 156250.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 36 | 138888.89 | 3.61 | 0 B | ✅ |
| Batch | Insert | 5,000 | 33 | 151515.15 | 1.94 | 0 B | ✅ |
| Batch | Select | 5,000 | 22 | 227272.73 | 5.88 | 12 KB | ✅ |
| Batch | Select | 5,000 | 21 | 238095.24 | 3.02 | 8 KB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 4.18 | 524 KB | ✅ |
| Batch | Select | 5,000 | 32 | 156250.00 | 4.01 | 0 B | ✅ |
| Batch | Update | 5,000 | 105 | 47619.05 | 2.46 | 40 KB | ✅ |
| Batch | Update | 5,000 | 108 | 46296.30 | 2.40 | 580 KB | ✅ |
| Batch | Update | 5,000 | 100 | 50000.00 | 2.59 | 12 KB | ✅ |
| Batch | Update | 5,000 | 158 | 31645.57 | 2.05 | 1.15 MB | ✅ |
| Batch | Update | 5,000 | 260 | 19230.77 | 1.50 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,736 | 26.77 | 0.10 | 11.05 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 102 | 980.39 | 3.17 | 6.73 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 96 | 1041.67 | 1.35 | 8.45 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,869 | 3.49 | 0.00 | 84 KB | ✅ |
| IndexQuery | OrderBy | 100 | 25,846 | 3.87 | 0.02 | 9.64 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 166 | 602.41 | 0.39 | 12.63 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 54 | 1851.85 | 0.00 | 148 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 55 | 1818.18 | 1.17 | 1.62 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 99 | 1010.10 | 2.61 | 8.2 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 107 | 934.58 | 2.41 | 8.06 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 107 | 934.58 | 2.42 | 8.89 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 112 | 892.86 | 0.58 | 8.07 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 115 | 869.57 | 1.13 | 5.11 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 561 | 14.26 | 0.00 | 3.23 MB | ✅ |
| MillionData | Cleanup | 1,000,000 | 14,862 | 67285.70 | 0.00 | 28 KB | ✅ |
| MillionData | GroupBy | 32 | 997 | 4.01 | 0.00 | 152 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 9,346 | 106997.65 | 2.24 | 0 B | ✅ |
| Single | Delete | 1,000 | 561 | 1782.53 | 2.43 | 1020 KB | ✅ |
| Single | Delete | 1,000 | 539 | 1855.29 | 1.33 | 836 KB | ✅ |
| Single | Delete | 1,000 | 536 | 1865.67 | 2.31 | 828 KB | ✅ |
| Single | Delete | 1,000 | 540 | 1851.85 | 2.29 | 84 KB | ✅ |
| Single | Delete | 1,000 | 516 | 1937.98 | 2.65 | 1.2 MB | ✅ |
| Single | Insert | 1,000 | 433 | 2309.47 | 3.00 | 6.01 MB | ✅ |
| Single | Insert | 1,000 | 401 | 2493.77 | 1.30 | 0 B | ✅ |
| Single | Insert | 1,000 | 364 | 2747.25 | 1.25 | 0 B | ✅ |
| Single | Insert | 1,000 | 385 | 2597.40 | 1.18 | 0 B | ✅ |
| Single | Insert | 1,000 | 386 | 2590.67 | 1.68 | 0 B | ✅ |
| Single | Select | 1,000 | 555 | 1801.80 | 4.45 | 1.64 MB | ✅ |
| Single | Select | 1,000 | 531 | 1883.24 | 2.94 | 320 KB | ✅ |
| Single | Select | 1,000 | 522 | 1915.71 | 1.99 | 236 KB | ✅ |
| Single | Select | 1,000 | 519 | 1926.78 | 2.00 | 296 KB | ✅ |
| Single | Select | 1,000 | 506 | 1976.28 | 2.31 | 348 KB | ✅ |
| Single | Update | 1,000 | 593 | 1686.34 | 2.09 | 10.2 MB | ✅ |
| Single | Update | 1,000 | 602 | 1661.13 | 2.70 | 8.26 MB | ✅ |
| Single | Update | 1,000 | 578 | 1730.10 | 2.37 | 8.27 MB | ✅ |
| Single | Update | 1,000 | 571 | 1751.31 | 3.41 | 7.24 MB | ✅ |
| Single | Update | 1,000 | 585 | 1709.40 | 1.78 | 7.29 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 18 | 55.56 | 7.03 | 212 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.38 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 34.64 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 84 KB | ✅ |
| Aggregation | Statistics | 5,000 | 40 | 150.00 | 3.22 | 672 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 18.45 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 10.96 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 94 | 53191.49 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 101 | 49504.95 | 0.64 | 0 B | ✅ |
| Batch | Delete | 5,000 | 93 | 53763.44 | 0.70 | 0 B | ✅ |
| Batch | Delete | 5,000 | 101 | 49504.95 | 0.00 | 68 KB | ✅ |
| Batch | Delete | 5,000 | 104 | 48076.92 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 1,807 | 2767.02 | 1.08 | 6.96 MB | ✅ |
| Batch | Insert | 5,000 | 1,662 | 3008.42 | 0.74 | 9.45 MB | ✅ |
| Batch | Insert | 5,000 | 1,589 | 3146.63 | 0.78 | 1.9 MB | ✅ |
| Batch | Insert | 5,000 | 1,594 | 3136.76 | 0.65 | 6.6 MB | ✅ |
| Batch | Insert | 5,000 | 1,512 | 3306.88 | 0.22 | 6.06 MB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.61 | 0 B | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 3.75 | 4 KB | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 3.77 | 1.12 MB | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 5.25 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.42 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,569 | 3186.74 | 0.66 | 156 KB | ✅ |
| Batch | Update | 5,000 | 1,587 | 3150.60 | 0.57 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,459 | 3427.00 | 0.18 | 480 KB | ✅ |
| Batch | Update | 5,000 | 1,472 | 3396.74 | 0.35 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,493 | 3348.96 | 0.31 | 3.09 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,559 | 64.14 | 0.17 | 6.23 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 94 | 1063.83 | 2.75 | 60 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 101 | 990.10 | 1.92 | 68 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,511 | 1.81 | 0.01 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 47,402 | 2.11 | 0.00 | 788 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 254 | 393.70 | 1.54 | 84 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 60,472 | 1.65 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 63 | 1587.30 | 1.03 | 44 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 96 | 1041.67 | 2.02 | 4 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 104 | 961.54 | 1.87 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 116 | 862.07 | 2.79 | 16 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 88 | 1136.36 | 2.22 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 88 | 1136.36 | 2.22 | 12 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 478 | 16.74 | 0.27 | 904 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 25,360 | 39432.18 | 0.02 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 2,645 | 1.51 | 0.02 | 76 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 25,807 | 38749.18 | 0.97 | 79.71 MB | ✅ |
| Single | Delete | 1,000 | 2,680 | 373.13 | 0.87 | 4.36 MB | ✅ |
| Single | Delete | 1,000 | 2,743 | 364.56 | 0.76 | 7.32 MB | ✅ |
| Single | Delete | 1,000 | 2,728 | 366.57 | 0.33 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,726 | 366.84 | 0.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,681 | 373.00 | 0.56 | 460 KB | ✅ |
| Single | Insert | 1,000 | 2,941 | 340.02 | 1.33 | 8.19 MB | ✅ |
| Single | Insert | 1,000 | 2,776 | 360.23 | 0.68 | 4 MB | ✅ |
| Single | Insert | 1,000 | 2,819 | 354.74 | 0.76 | 9.07 MB | ✅ |
| Single | Insert | 1,000 | 2,718 | 367.92 | 0.55 | 4.98 MB | ✅ |
| Single | Insert | 1,000 | 2,695 | 371.06 | 0.72 | 9.97 MB | ✅ |
| Single | Select | 1,000 | 629 | 1589.83 | 2.90 | 908 KB | ✅ |
| Single | Select | 1,000 | 554 | 1805.05 | 2.93 | 892 KB | ✅ |
| Single | Select | 1,000 | 574 | 1742.16 | 2.15 | 7.8 MB | ✅ |
| Single | Select | 1,000 | 570 | 1754.39 | 2.51 | 6.81 MB | ✅ |
| Single | Select | 1,000 | 587 | 1703.58 | 1.77 | 3 MB | ✅ |
| Single | Update | 1,000 | 2,983 | 335.23 | 0.65 | 0 B | ✅ |
| Single | Update | 1,000 | 2,906 | 344.12 | 0.81 | 0 B | ✅ |
| Single | Update | 1,000 | 2,879 | 347.34 | 0.59 | 20 KB | ✅ |
| Single | Update | 1,000 | 2,845 | 351.49 | 0.53 | 3 MB | ✅ |
| Single | Update | 1,000 | 2,814 | 355.37 | 0.79 | 3 MB | ✅ |

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 748 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 24.41 | 452 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 304 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 8.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 9.30 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 10.08 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.31 | 0 B | ✅ |
| Batch | Delete | 5,000 | 294 | 17006.80 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 640 | 7812.50 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 296 | 16891.89 | 0.22 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 852 | 5868.54 | 0.08 | 2.88 MB | ✅ |
| Batch | Delete | 5,000 | 412 | 12135.92 | 0.00 | 2.88 MB | ✅ |
| Batch | Insert | 5,000 | 4,446 | 1124.61 | 0.23 | 1.04 MB | ✅ |
| Batch | Insert | 5,000 | 4,389 | 1139.21 | 0.16 | 5.43 MB | ✅ |
| Batch | Insert | 5,000 | 4,338 | 1152.60 | 0.32 | 3.91 MB | ✅ |
| Batch | Insert | 5,000 | 4,384 | 1140.51 | 0.30 | 10.85 MB | ✅ |
| Batch | Insert | 5,000 | 4,489 | 1113.83 | 0.26 | 6.65 MB | ✅ |
| Batch | Select | 5,000 | 47 | 106382.98 | 2.75 | 0 B | ✅ |
| Batch | Select | 5,000 | 43 | 116279.07 | 3.01 | 0 B | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 0.00 | 160 KB | ✅ |
| Batch | Select | 5,000 | 48 | 104166.67 | 2.70 | 0 B | ✅ |
| Batch | Select | 5,000 | 41 | 121951.22 | 3.14 | 0 B | ✅ |
| Batch | Update | 5,000 | 4,622 | 1081.78 | 0.17 | 14.12 MB | ✅ |
| Batch | Update | 5,000 | 4,629 | 1080.15 | 0.15 | 10.75 MB | ✅ |
| Batch | Update | 5,000 | 4,576 | 1092.66 | 0.26 | 18.58 MB | ✅ |
| Batch | Update | 5,000 | 4,698 | 1064.28 | 0.19 | 12.77 MB | ✅ |
| Batch | Update | 5,000 | 4,569 | 1094.33 | 0.24 | 11.14 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,664 | 60.10 | 0.20 | 64 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 561 | 178.25 | 0.12 | 92 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 605 | 165.29 | 0.43 | 36 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,482 | 4.03 | 0.03 | 16 KB | ✅ |
| IndexQuery | OrderBy | 100 | 32,376 | 3.09 | 0.02 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 388 | 257.73 | 0.50 | 64 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 21,074 | 4.75 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 207 | 483.09 | 0.00 | 248 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 701 | 142.65 | 1.02 | 28 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 1,634 | 61.20 | 0.28 | 44 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 1,733 | 57.70 | 0.38 | 4 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 1,190 | 84.03 | 0.33 | 48 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 116 | 862.07 | 0.56 | 6.08 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 269 | 29.74 | 0.24 | 332 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 1,838,724 | 543.86 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,423 | 2.81 | 0.05 | 628 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 1,759,340 | 568.39 | 0.15 | 38.69 MB | ✅ |
| Single | Delete | 1,000 | 1,693 | 590.67 | 0.46 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,591 | 628.54 | 0.65 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,622 | 616.52 | 0.52 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,634 | 612.00 | 0.92 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,506 | 664.01 | 0.35 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,276 | 783.70 | 1.17 | 7.68 MB | ✅ |
| Single | Insert | 1,000 | 977 | 1023.54 | 1.46 | 13.75 MB | ✅ |
| Single | Insert | 1,000 | 1,327 | 753.58 | 0.88 | 13.48 MB | ✅ |
| Single | Insert | 1,000 | 1,112 | 899.28 | 1.05 | 17.55 MB | ✅ |
| Single | Insert | 1,000 | 1,018 | 982.32 | 0.64 | 16.25 MB | ✅ |
| Single | Select | 1,000 | 1,048 | 954.20 | 1.06 | 3.91 MB | ✅ |
| Single | Select | 1,000 | 1,004 | 996.02 | 1.30 | 14.73 MB | ✅ |
| Single | Select | 1,000 | 998 | 1002.00 | 1.24 | 14.72 MB | ✅ |
| Single | Select | 1,000 | 1,027 | 973.71 | 1.33 | 984 KB | ✅ |
| Single | Select | 1,000 | 989 | 1011.12 | 1.18 | 14.73 MB | ✅ |
| Single | Update | 1,000 | 1,948 | 513.35 | 0.87 | 0 B | ✅ |
| Single | Update | 1,000 | 1,703 | 587.20 | 0.76 | 0 B | ✅ |
| Single | Update | 1,000 | 1,696 | 589.62 | 0.58 | 0 B | ✅ |
| Single | Update | 1,000 | 1,820 | 549.45 | 0.75 | 0 B | ✅ |
| Single | Update | 1,000 | 1,669 | 599.16 | 0.27 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 128 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 30.74 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 180 KB | ✅ |
| Aggregation | Statistics | 5,000 | 12 | 500.00 | 10.82 | 16 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.47 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 21 | 238095.24 | 0.00 | 8 KB | ✅ |
| Batch | Insert | 5,000 | 976 | 5122.95 | 1.00 | 15.02 MB | ✅ |
| Batch | Insert | 5,000 | 383 | 13054.83 | 2.38 | 14.07 MB | ✅ |
| Batch | Insert | 5,000 | 553 | 9041.59 | 2.00 | 14.75 MB | ✅ |
| Batch | Insert | 5,000 | 506 | 9881.42 | 1.67 | 15.06 MB | ✅ |
| Batch | Insert | 5,000 | 470 | 10638.30 | 1.80 | 14.14 MB | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.42 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.15 | 0 B | ✅ |
| Batch | Select | 5,000 | 324 | 15432.10 | 0.20 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.66 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.23 | 0 B | ✅ |
| Batch | Update | 5,000 | 370 | 13513.51 | 1.93 | 1.42 MB | ✅ |
| Batch | Update | 5,000 | 294 | 17006.80 | 1.55 | 2.21 MB | ✅ |
| Batch | Update | 5,000 | 423 | 11820.33 | 1.23 | 2.77 MB | ✅ |
| Batch | Update | 5,000 | 345 | 14492.75 | 2.07 | 0 B | ✅ |
| Batch | Update | 5,000 | 363 | 13774.10 | 1.61 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 4,427 | 22.59 | 0.07 | 36 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 63 | 1587.30 | 4.13 | 0 B | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 71 | 1408.45 | 3.65 | 4 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 516 | 19.38 | 0.13 | 164 KB | ✅ |
| IndexQuery | OrderBy | 100 | 3,900 | 25.64 | 0.10 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 79 | 1265.82 | 2.45 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 7,745 | 12.91 | 0.02 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 45 | 2222.22 | 2.89 | 0 B | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 64 | 1562.50 | 2.01 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 82 | 1219.51 | 4.75 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 84 | 1190.48 | 5.38 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 741 | 134.95 | 0.35 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 1,106 | 90.42 | 0.18 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 197 | 40.61 | 0.66 | 236 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 3,699 | 270343.34 | 0.05 | 1.32 MB | ✅ |
| MillionData | GroupBy | 32 | 174 | 22.99 | 0.37 | 1.13 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 34,346 | 29115.47 | 3.52 | 67.62 MB | ✅ |
| Single | Delete | 1,000 | 869 | 1150.75 | 1.35 | 4 KB | ✅ |
| Single | Delete | 1,000 | 833 | 1200.48 | 1.09 | 0 B | ✅ |
| Single | Delete | 1,000 | 842 | 1187.65 | 0.85 | 0 B | ✅ |
| Single | Delete | 1,000 | 842 | 1187.65 | 1.08 | 0 B | ✅ |
| Single | Delete | 1,000 | 852 | 1173.71 | 0.53 | 0 B | ✅ |
| Single | Insert | 1,000 | 947 | 1055.97 | 1.31 | 11.32 MB | ✅ |
| Single | Insert | 1,000 | 942 | 1061.57 | 1.45 | 5.88 MB | ✅ |
| Single | Insert | 1,000 | 1,010 | 990.10 | 1.03 | 11.04 MB | ✅ |
| Single | Insert | 1,000 | 942 | 1061.57 | 1.04 | 11.04 MB | ✅ |
| Single | Insert | 1,000 | 1,014 | 986.19 | 1.35 | 11.57 MB | ✅ |
| Single | Select | 1,000 | 402 | 2487.56 | 2.75 | 7.72 MB | ✅ |
| Single | Select | 1,000 | 397 | 2518.89 | 1.80 | 4 MB | ✅ |
| Single | Select | 1,000 | 379 | 2638.52 | 3.09 | 7.96 MB | ✅ |
| Single | Select | 1,000 | 401 | 2493.77 | 3.24 | 7.96 MB | ✅ |
| Single | Select | 1,000 | 393 | 2544.53 | 2.48 | 0 B | ✅ |
| Single | Update | 1,000 | 1,001 | 999.00 | 1.11 | 0 B | ✅ |
| Single | Update | 1,000 | 1,005 | 995.02 | 1.94 | 0 B | ✅ |
| Single | Update | 1,000 | 970 | 1030.93 | 1.14 | 0 B | ✅ |
| Single | Update | 1,000 | 996 | 1004.02 | 1.31 | 0 B | ✅ |
| Single | Update | 1,000 | 996 | 1004.02 | 1.11 | 72 KB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 340 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 380 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 25.52 | 264 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 24.90 | 368 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 328 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 22.71 | 248 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 27.16 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 42 | 119047.62 | 3.06 | 0 B | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 2.06 | 0 B | ✅ |
| Batch | Delete | 5,000 | 61 | 81967.21 | 7.44 | 0 B | ✅ |
| Batch | Delete | 5,000 | 62 | 80645.16 | 6.28 | 0 B | ✅ |
| Batch | Delete | 5,000 | 43 | 116279.07 | 4.51 | 0 B | ✅ |
| Batch | Insert | 5,000 | 535 | 9345.79 | 4.01 | 2.07 MB | ✅ |
| Batch | Insert | 5,000 | 991 | 5045.41 | 4.01 | 0 B | ✅ |
| Batch | Insert | 5,000 | 953 | 5246.59 | 4.03 | 188 KB | ✅ |
| Batch | Insert | 5,000 | 962 | 5197.51 | 4.06 | 436 KB | ✅ |
| Batch | Insert | 5,000 | 775 | 6451.61 | 4.20 | 300 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.11 | 8 KB | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.44 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.33 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.48 | 0 B | ✅ |
| Batch | Update | 5,000 | 286 | 17482.52 | 4.09 | 396 KB | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 4.06 | 192 KB | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 4.56 | 224 KB | ✅ |
| Batch | Update | 5,000 | 523 | 9560.23 | 4.10 | 1.07 MB | ✅ |
| Batch | Update | 5,000 | 282 | 17730.50 | 3.91 | 1.36 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 58,613 | 1.71 | 4.16 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 104 | 961.54 | 4.35 | 0 B | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 148 | 675.68 | 4.39 | 0 B | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,717 | 1.49 | 4.18 | 28 KB | ✅ |
| IndexQuery | OrderBy | 100 | 61,260 | 1.63 | 4.16 | 348 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 102 | 980.39 | 4.45 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 37,612 | 2.66 | 4.16 | 88 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 24 | 4166.67 | 5.36 | 0 B | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 161 | 621.12 | 4.04 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 189 | 529.10 | 4.46 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 188 | 531.91 | 4.49 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 73 | 1369.86 | 4.43 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 75 | 1333.33 | 4.34 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 834 | 9.59 | 4.21 | 0 B | ✅ |
| MillionData | Cleanup | 1,000,000 | 132,571 | 7543.13 | 3.49 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 12,615 | 0.32 | 4.17 | 1020 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 139,529 | 7166.97 | 3.70 | 52.28 MB | ✅ |
| Single | Delete | 1,000 | 2,643 | 378.36 | 3.28 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,994 | 334.00 | 3.57 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,432 | 291.38 | 3.26 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,364 | 297.27 | 3.52 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,267 | 306.09 | 3.33 | 4 KB | ✅ |
| Single | Insert | 1,000 | 2,718 | 367.92 | 3.02 | 12.43 MB | ✅ |
| Single | Insert | 1,000 | 2,735 | 365.63 | 2.57 | 12.11 MB | ✅ |
| Single | Insert | 1,000 | 3,365 | 297.18 | 3.75 | 4.12 MB | ✅ |
| Single | Insert | 1,000 | 3,326 | 300.66 | 3.46 | 11.24 MB | ✅ |
| Single | Insert | 1,000 | 3,432 | 291.38 | 3.58 | 3.83 MB | ✅ |
| Single | Select | 1,000 | 121 | 8264.46 | 4.30 | 2.91 MB | ✅ |
| Single | Select | 1,000 | 118 | 8474.58 | 4.38 | 7.32 MB | ✅ |
| Single | Select | 1,000 | 246 | 4065.04 | 4.23 | 0 B | ✅ |
| Single | Select | 1,000 | 243 | 4115.23 | 4.27 | 6.62 MB | ✅ |
| Single | Select | 1,000 | 241 | 4149.38 | 4.31 | 0 B | ✅ |
| Single | Update | 1,000 | 2,609 | 383.29 | 3.47 | 4.41 MB | ✅ |
| Single | Update | 1,000 | 2,728 | 366.57 | 3.29 | 9 MB | ✅ |
| Single | Update | 1,000 | 3,481 | 287.27 | 3.42 | 8.01 MB | ✅ |
| Single | Update | 1,000 | 3,448 | 290.02 | 3.59 | 7.98 MB | ✅ |
| Single | Update | 1,000 | 3,445 | 290.28 | 3.51 | 10.98 MB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 31 | 32.26 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 31 | 32.26 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 34 | 29.41 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 0.00 | 84 KB | ✅ |
| Aggregation | GroupBy | 8 | 31 | 32.26 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 8.28 | 96 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.34 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.91 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 217 | 23041.47 | 0.00 | 844 KB | ✅ |
| Batch | Delete | 5,000 | 212 | 23584.91 | 0.31 | 120 KB | ✅ |
| Batch | Delete | 5,000 | 211 | 23696.68 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 213 | 23474.18 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 207 | 24154.59 | 0.31 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,836 | 1033.91 | 0.11 | 7.52 MB | ✅ |
| Batch | Insert | 5,000 | 4,860 | 1028.81 | 0.09 | 4.5 MB | ✅ |
| Batch | Insert | 5,000 | 4,813 | 1038.85 | 0.07 | 3.69 MB | ✅ |
| Batch | Insert | 5,000 | 4,833 | 1034.55 | 0.07 | 1.7 MB | ✅ |
| Batch | Insert | 5,000 | 4,726 | 1057.98 | 0.08 | 3.93 MB | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 0.00 | 372 KB | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 8.87 | 0 B | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 9.01 | 396 KB | ✅ |
| Batch | Update | 5,000 | 2,747 | 1820.17 | 0.12 | 7.26 MB | ✅ |
| Batch | Update | 5,000 | 2,647 | 1888.93 | 0.05 | 3.27 MB | ✅ |
| Batch | Update | 5,000 | 2,642 | 1892.51 | 0.22 | 1.72 MB | ✅ |
| Batch | Update | 5,000 | 2,537 | 1970.83 | 0.13 | 0 B | ✅ |
| Batch | Update | 5,000 | 2,654 | 1883.95 | 0.12 | 5.49 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,190 | 84.03 | 0.11 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 188 | 531.91 | 1.73 | 24 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 197 | 507.61 | 0.33 | 32 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,476 | 4.04 | 0.03 | 384 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,186 | 23.89 | 0.05 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 272 | 367.65 | 0.96 | 1.7 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,196 | 6.58 | 0.02 | 312 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 115 | 869.57 | 1.12 | 24 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 200 | 500.00 | 1.62 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 192 | 520.83 | 1.35 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 192 | 520.83 | 1.02 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 121 | 826.45 | 2.69 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 428 | 233.64 | 1.06 | 1.72 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 456 | 17.54 | 0.29 | 40 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 21,157 | 47265.68 | 0.01 | 960 KB | ✅ |
| MillionData | GroupBy | 32 | 116 | 34.48 | 0.56 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 30,947 | 32313.31 | 1.75 | 67.66 MB | ✅ |
| Single | Delete | 1,000 | 1,596 | 626.57 | 0.61 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,626 | 615.01 | 0.56 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,576 | 634.52 | 0.33 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,531 | 653.17 | 0.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,509 | 662.69 | 0.65 | 1.28 MB | ✅ |
| Single | Insert | 1,000 | 1,582 | 632.11 | 1.03 | 9.07 MB | ✅ |
| Single | Insert | 1,000 | 1,490 | 671.14 | 0.66 | 11.04 MB | ✅ |
| Single | Insert | 1,000 | 1,512 | 661.38 | 0.65 | 3.21 MB | ✅ |
| Single | Insert | 1,000 | 1,507 | 663.57 | 0.52 | 8.84 MB | ✅ |
| Single | Insert | 1,000 | 1,491 | 670.69 | 0.79 | 0 B | ✅ |
| Single | Select | 1,000 | 1,108 | 902.53 | 0.76 | 5.27 MB | ✅ |
| Single | Select | 1,000 | 1,060 | 943.40 | 0.43 | 11.81 MB | ✅ |
| Single | Select | 1,000 | 1,073 | 931.97 | 0.91 | 28 KB | ✅ |
| Single | Select | 1,000 | 1,061 | 942.51 | 0.98 | 3 MB | ✅ |
| Single | Select | 1,000 | 1,015 | 985.22 | 1.15 | 0 B | ✅ |
| Single | Update | 1,000 | 3,723 | 268.60 | 0.42 | 0 B | ✅ |
| Single | Update | 1,000 | 3,679 | 271.81 | 0.19 | 128 KB | ✅ |
| Single | Update | 1,000 | 7,069 | 141.46 | 0.16 | 0 B | ✅ |
| Single | Update | 1,000 | 3,619 | 276.32 | 0.20 | 2.45 MB | ✅ |
| Single | Update | 1,000 | 3,395 | 294.55 | 0.25 | 3.62 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 7.83 | 8.55 | 11.81 | 4.88 | 6.15 | 10.08 | 0.00 |
| Aggregation | Statistics | 3.94 | 9.25 | 6.53 | 7.14 | 2.16 | 9.97 | 4.91 |
| Batch | Delete | 0.94 | 2.00 | 0.27 | 0.06 | 0.69 | 4.67 | 0.12 |
| Batch | Insert | 0.56 | 1.99 | 0.69 | 0.25 | 1.77 | 4.06 | 0.08 |
| Batch | Select | 4.64 | 3.42 | 4.36 | 2.32 | 6.33 | 4.47 | 3.58 |
| Batch | Update | 0.17 | 2.20 | 0.41 | 0.20 | 1.68 | 4.14 | 0.13 |
| IndexQuery | ComplexCondition | 0.08 | 0.10 | 0.17 | 0.20 | 0.07 | 4.16 | 0.11 |
| IndexQuery | CompositeIndex_RegionDept | 5.02 | 3.17 | 2.75 | 0.12 | 4.13 | 4.35 | 1.73 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.81 | 1.35 | 1.92 | 0.43 | 3.65 | 4.39 | 0.33 |
| IndexQuery | NoIndex_FullScan | 0.02 | 0.00 | 0.01 | 0.03 | 0.13 | 4.18 | 0.03 |
| IndexQuery | OrderBy | 0.03 | 0.02 | 0.00 | 0.02 | 0.10 | 4.16 | 0.05 |
| IndexQuery | Pagination | 1.07 | 0.39 | 1.54 | 0.50 | 2.45 | 4.45 | 0.96 |
| IndexQuery | PrefixQuery_Name | 0.01 | 0.00 | 0.01 | 0.01 | 0.02 | 4.16 | 0.02 |
| IndexQuery | PrimaryKey | 4.51 | 1.17 | 1.03 | 0.00 | 2.89 | 5.36 | 1.12 |
| IndexQuery | RangeQuery_Date | 2.19 | 2.61 | 2.02 | 1.02 | 2.01 | 4.04 | 1.62 |
| IndexQuery | RangeQuery_Salary | 3.39 | 2.41 | 1.87 | 0.28 | 4.75 | 4.46 | 1.35 |
| IndexQuery | RangeQuery_Score | 3.29 | 2.42 | 2.79 | 0.38 | 5.38 | 4.49 | 1.02 |
| IndexQuery | SingleIndex_Category | 4.72 | 0.58 | 2.22 | 0.33 | 0.35 | 4.43 | 2.69 |
| IndexQuery | SingleIndex_Status | 3.02 | 1.13 | 2.22 | 0.56 | 0.18 | 4.34 | 1.06 |
| MillionData | Aggregation | 0.00 | 0.00 | 0.27 | 0.24 | 0.66 | 4.21 | 0.29 |
| MillionData | Cleanup | 0.03 | 0.00 | 0.02 | 0.00 | 0.05 | 3.49 | 0.01 |
| MillionData | GroupBy | 0.00 | 0.00 | 0.02 | 0.05 | 0.37 | 4.17 | 0.56 |
| MillionData | PrepareData | 1.91 | 2.24 | 0.97 | 0.15 | 3.52 | 3.70 | 1.75 |
| Single | Delete | 1.11 | 2.20 | 0.59 | 0.58 | 0.98 | 3.39 | 0.52 |
| Single | Insert | 1.13 | 1.68 | 0.81 | 1.04 | 1.24 | 3.28 | 0.73 |
| Single | Select | 2.59 | 2.74 | 2.45 | 1.22 | 2.67 | 4.30 | 0.85 |
| Single | Update | 0.83 | 2.47 | 0.67 | 0.65 | 1.32 | 3.46 | 0.24 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | Oracle | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 424 KB | 24 KB | 212 KB | 748 KB | 180 KB | 380 KB | 84 KB |
| Aggregation | Statistics | 1.5 MB | 656 KB | 672 KB | 8 KB | 16 KB | 248 KB | 96 KB |
| Batch | Delete | 24 KB | 1.42 MB | 68 KB | 2.88 MB | 16 KB | 0 B | 844 KB |
| Batch | Insert | 5.82 MB | 56 KB | 9.45 MB | 10.85 MB | 15.06 MB | 2.07 MB | 7.52 MB |
| Batch | Select | 8 KB | 524 KB | 1.12 MB | 160 KB | 0 B | 8 KB | 396 KB |
| Batch | Update | 7.42 MB | 1.15 MB | 3.09 MB | 18.58 MB | 2.77 MB | 1.36 MB | 7.26 MB |
| IndexQuery | ComplexCondition | 0 B | 11.05 MB | 6.23 MB | 64 KB | 36 KB | 0 B | 0 B |
| IndexQuery | CompositeIndex_RegionDept | 240 KB | 6.73 MB | 60 KB | 92 KB | 0 B | 0 B | 24 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.21 MB | 8.45 MB | 68 KB | 36 KB | 4 KB | 0 B | 32 KB |
| IndexQuery | NoIndex_FullScan | 0 B | 84 KB | 0 B | 16 KB | 164 KB | 28 KB | 384 KB |
| IndexQuery | OrderBy | 0 B | 9.64 MB | 788 KB | 0 B | 0 B | 348 KB | 0 B |
| IndexQuery | Pagination | 1.52 MB | 12.63 MB | 84 KB | 64 KB | 0 B | 0 B | 1.7 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 148 KB | 0 B | 0 B | 0 B | 88 KB | 312 KB |
| IndexQuery | PrimaryKey | 2.88 MB | 1.62 MB | 44 KB | 248 KB | 0 B | 0 B | 24 KB |
| IndexQuery | RangeQuery_Date | 40 KB | 8.2 MB | 4 KB | 28 KB | 0 B | 0 B | 0 B |
| IndexQuery | RangeQuery_Salary | 40 KB | 8.06 MB | 0 B | 44 KB | 0 B | 0 B | 0 B |
| IndexQuery | RangeQuery_Score | 3.09 MB | 8.89 MB | 16 KB | 4 KB | 0 B | 0 B | 0 B |
| IndexQuery | SingleIndex_Category | 32 KB | 8.07 MB | 8 KB | 48 KB | 0 B | 0 B | 0 B |
| IndexQuery | SingleIndex_Status | 40 KB | 5.11 MB | 12 KB | 6.08 MB | 0 B | 0 B | 1.72 MB |
| MillionData | Aggregation | 60 KB | 3.23 MB | 904 KB | 332 KB | 236 KB | 0 B | 40 KB |
| MillionData | Cleanup | 0 B | 28 KB | 0 B | 0 B | 1.32 MB | 0 B | 960 KB |
| MillionData | GroupBy | 0 B | 152 KB | 76 KB | 628 KB | 1.13 MB | 1020 KB | 0 B |
| MillionData | PrepareData | 80.63 MB | 0 B | 79.71 MB | 38.69 MB | 67.62 MB | 52.28 MB | 67.66 MB |
| Single | Delete | 8 KB | 1.2 MB | 7.32 MB | 0 B | 4 KB | 4 KB | 1.28 MB |
| Single | Insert | 11.96 MB | 6.01 MB | 9.97 MB | 17.55 MB | 11.57 MB | 12.43 MB | 11.04 MB |
| Single | Select | 5.96 MB | 1.64 MB | 7.8 MB | 14.73 MB | 7.96 MB | 7.32 MB | 11.81 MB |
| Single | Update | 92 KB | 10.2 MB | 3 MB | 0 B | 72 KB | 10.98 MB | 3.62 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 23:44:00*
