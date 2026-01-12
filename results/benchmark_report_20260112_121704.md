# 数据库基准测试报告

**测试时间**: 2026-01-12 12:17:04

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
| 采集时间 | 2026-01-12 12:17:04 |


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
| Aggregation | GroupBy | 3.00 | 3.40 | 4.80 | 1.40 | 2.00 | 29.60 | **PostgreSQL** |
| Aggregation | Statistics | 6.20 | 7.40 | 10.20 | 5.80 | 1.80 | 8.20 | **SQLite** |
| Batch | Delete | 59.40 | 38.00 | 101.20 | 20.40 | 52.80 | 213.00 | **PostgreSQL** |
| Batch | Insert | 1646.20 | 43.40 | 1576.80 | 651.80 | 699.60 | 4820.40 | **MongoDB** |
| Batch | Select | 12.20 | 31.00 | 12.60 | 8.00 | 13.80 | 14.60 | **PostgreSQL** |
| Batch | Update | 1538.60 | 205.00 | 1539.80 | 451.00 | 423.60 | 2593.40 | **MongoDB** |
| IndexQuery | ComplexCondition | 9216.00 | 4153.00 | 1447.00 | 308.00 | 42055.00 | 1536.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 82.00 | 110.00 | 92.00 | 63.00 | 103.00 | 194.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 89.00 | 118.00 | 108.00 | 133.00 | 147.00 | 218.00 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 5584.00 | 4439.00 | 6337.00 | 588.00 | 3360.00 | 2527.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10242.00 | 35976.00 | 47429.00 | 4579.00 | 58981.00 | 4129.00 | **SQLServer** |
| IndexQuery | Pagination | 168.00 | 221.00 | 244.00 | 74.00 | 112.00 | 231.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 42596.00 | 62.00 | 63630.00 | 9058.00 | 43427.00 | 15478.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 63.00 | 57.00 | 52.00 | 50.00 | 23.00 | 113.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 86.00 | 119.00 | 101.00 | 121.00 | 164.00 | 215.00 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 89.00 | 126.00 | 102.00 | 114.00 | 194.00 | 208.00 | **MariaDB** |
| IndexQuery | RangeQuery_Score | 88.00 | 131.00 | 108.00 | 84.00 | 185.00 | 207.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 76.00 | 138.00 | 86.00 | 113.00 | 72.00 | 114.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 75.00 | 133.00 | 94.00 | 61.00 | 76.00 | 436.00 | **PostgreSQL** |
| MillionData | Aggregation | 450.00 | 858.00 | 463.00 | 246.00 | 445.00 | 447.00 | **PostgreSQL** |
| MillionData | Cleanup | 18201.00 | 21513.00 | 22950.00 | 2874.00 | 123834.00 | 22662.00 | **PostgreSQL** |
| MillionData | GroupBy | 1749.00 | 1147.00 | 2577.00 | 213.00 | 8377.00 | 115.00 | **SQLServer** |
| MillionData | PrepareData | 23937.00 | 10714.00 | 31095.00 | 35022.00 | 150564.00 | 30819.00 | **MongoDB** |
| Single | Delete | 1110.40 | 544.40 | 2713.00 | 882.80 | 2992.60 | 1630.60 | **MongoDB** |
| Single | Insert | 1243.80 | 399.60 | 2780.40 | 1016.60 | 3127.80 | 1564.60 | **MongoDB** |
| Single | Select | 518.60 | 539.40 | 582.40 | 409.40 | 167.20 | 1087.40 | **SQLite** |
| Single | Update | 1421.80 | 604.60 | 2812.60 | 1026.20 | 3041.20 | 3723.20 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 333.33 | 300.00 | 268.18 | 800.00 | 566.67 | 33.93 | **PostgreSQL** |
| Aggregation | Statistics | 982.86 | 209.52 | 855.87 | 1140.00 | 3600.00 | 807.14 | **SQLite** |
| Batch | Delete | 84589.64 | 131996.66 | 49955.60 | 258500.75 | 97655.32 | 23477.71 | **PostgreSQL** |
| Batch | Insert | 3037.48 | 116296.11 | 3177.98 | 8029.75 | 7738.65 | 1037.42 | **MongoDB** |
| Batch | Select | 411421.91 | 161743.98 | 403113.55 | 628968.25 | 404651.78 | 344780.22 | **PostgreSQL** |
| Batch | Update | 3249.84 | 25220.71 | 3251.55 | 12013.23 | 12799.98 | 1928.56 | **MongoDB** |
| IndexQuery | ComplexCondition | 10.85 | 24.08 | 69.11 | 324.68 | 2.38 | 65.10 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 1219.51 | 909.09 | 1086.96 | 1587.30 | 970.87 | 515.46 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 1123.60 | 847.46 | 925.93 | 751.88 | 680.27 | 458.72 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 1.79 | 2.25 | 1.58 | 17.01 | 2.98 | 3.96 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.76 | 2.78 | 2.11 | 21.84 | 1.70 | 24.22 | **SQLServer** |
| IndexQuery | Pagination | 595.24 | 452.49 | 409.84 | 1351.35 | 892.86 | 432.90 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.35 | 1612.90 | 1.57 | 11.04 | 2.30 | 6.46 | **MongoDB** |
| IndexQuery | PrimaryKey | 1587.30 | 1754.39 | 1923.08 | 2000.00 | 4347.83 | 884.96 | **SQLite** |
| IndexQuery | RangeQuery_Date | 1162.79 | 840.34 | 990.10 | 826.45 | 609.76 | 465.12 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 1123.60 | 793.65 | 980.39 | 877.19 | 515.46 | 480.77 | **MariaDB** |
| IndexQuery | RangeQuery_Score | 1136.36 | 763.36 | 925.93 | 1190.48 | 540.54 | 483.09 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 1315.79 | 724.64 | 1162.79 | 884.96 | 1388.89 | 877.19 | **SQLite** |
| IndexQuery | SingleIndex_Status | 1333.33 | 751.88 | 1063.83 | 1639.34 | 1315.79 | 229.36 | **PostgreSQL** |
| MillionData | Aggregation | 17.78 | 9.32 | 17.28 | 32.52 | 17.98 | 17.90 | **PostgreSQL** |
| MillionData | Cleanup | 54942.04 | 46483.52 | 43572.98 | 347947.11 | 8075.33 | 44126.73 | **PostgreSQL** |
| MillionData | GroupBy | 2.29 | 3.49 | 1.55 | 18.78 | 0.48 | 34.78 | **SQLServer** |
| MillionData | PrepareData | 41776.33 | 93335.82 | 32159.51 | 28553.48 | 6641.69 | 32447.52 | **MongoDB** |
| Single | Delete | 900.70 | 1838.13 | 368.63 | 1133.22 | 337.86 | 613.55 | **MongoDB** |
| Single | Insert | 804.03 | 2507.90 | 359.76 | 984.65 | 323.33 | 639.25 | **MongoDB** |
| Single | Select | 1928.78 | 1856.26 | 1717.15 | 2444.36 | 6615.97 | 919.71 | **SQLite** |
| Single | Update | 703.96 | 1654.84 | 355.58 | 974.79 | 332.84 | 268.66 | **MongoDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.42 | 24 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 284 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.25 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 10.39 | 40 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 9.25 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 10.63 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 80 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 11.34 | 1.45 MB | ✅ |
| Batch | Delete | 5,000 | 56 | 89285.71 | 2.29 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 1.12 | 0 B | ✅ |
| Batch | Delete | 5,000 | 57 | 87719.30 | 0.00 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 68 | 73529.41 | 0.95 | 0 B | ✅ |
| Batch | Insert | 5,000 | 1,670 | 2994.01 | 0.82 | 5.98 MB | ✅ |
| Batch | Insert | 5,000 | 1,633 | 3061.85 | 0.80 | 4.54 MB | ✅ |
| Batch | Insert | 5,000 | 1,642 | 3045.07 | 0.79 | 2.04 MB | ✅ |
| Batch | Insert | 5,000 | 1,638 | 3052.50 | 0.79 | 1.91 MB | ✅ |
| Batch | Insert | 5,000 | 1,648 | 3033.98 | 0.79 | 2.13 MB | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 10.85 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.88 | 0 B | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 5.01 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.49 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.89 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,533 | 3261.58 | 0.64 | 3.95 MB | ✅ |
| Batch | Update | 5,000 | 1,543 | 3240.44 | 0.51 | 52 KB | ✅ |
| Batch | Update | 5,000 | 1,533 | 3261.58 | 0.59 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,528 | 3272.25 | 0.51 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,556 | 3213.37 | 0.67 | 84 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 9,216 | 10.85 | 0.05 | 56 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 82 | 1219.51 | 3.95 | 408 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 89 | 1123.60 | 3.62 | 364 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,584 | 1.79 | 0.01 | 52 KB | ✅ |
| IndexQuery | OrderBy | 100 | 10,242 | 9.76 | 0.03 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 168 | 595.24 | 1.55 | 892 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 42,596 | 2.35 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 63 | 1587.30 | 1.03 | 2.68 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 86 | 1162.79 | 3.02 | 80 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 89 | 1123.60 | 2.17 | 940 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 88 | 1136.36 | 2.94 | 3.24 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 76 | 1315.79 | 0.86 | 32 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 75 | 1333.33 | 3.45 | 4.78 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 450 | 17.78 | 0.00 | 0 B | ✅ |
| MillionData | Cleanup | 1,000,000 | 18,201 | 54942.04 | 0.00 | 1.64 MB | ✅ |
| MillionData | GroupBy | 32 | 1,749 | 2.29 | 0.00 | 40 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 23,937 | 41776.33 | 1.95 | 39.44 MB | ✅ |
| Single | Delete | 1,000 | 1,108 | 902.53 | 0.71 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,101 | 908.27 | 1.54 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,133 | 882.61 | 0.75 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,114 | 897.67 | 1.17 | 828 KB | ✅ |
| Single | Delete | 1,000 | 1,096 | 912.41 | 1.13 | 8 KB | ✅ |
| Single | Insert | 1,000 | 1,254 | 797.45 | 1.04 | 15.41 MB | ✅ |
| Single | Insert | 1,000 | 1,247 | 801.92 | 0.83 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,245 | 803.21 | 1.20 | 24 KB | ✅ |
| Single | Insert | 1,000 | 1,247 | 801.92 | 1.15 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,226 | 815.66 | 1.38 | 28 KB | ✅ |
| Single | Select | 1,000 | 529 | 1890.36 | 2.95 | 4 MB | ✅ |
| Single | Select | 1,000 | 520 | 1923.08 | 1.50 | 0 B | ✅ |
| Single | Select | 1,000 | 507 | 1972.39 | 1.28 | 0 B | ✅ |
| Single | Select | 1,000 | 526 | 1901.14 | 2.60 | 12 KB | ✅ |
| Single | Select | 1,000 | 511 | 1956.95 | 2.42 | 0 B | ✅ |
| Single | Update | 1,000 | 1,462 | 683.99 | 0.85 | 4 MB | ✅ |
| Single | Update | 1,000 | 1,478 | 676.59 | 1.01 | 0 B | ✅ |
| Single | Update | 1,000 | 1,364 | 733.14 | 1.29 | 0 B | ✅ |
| Single | Update | 1,000 | 1,393 | 717.88 | 0.79 | 0 B | ✅ |
| Single | Update | 1,000 | 1,412 | 708.22 | 1.06 | 0 B | ✅ |

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.34 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 21 | 47.62 | 5.99 | 720 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.56 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.32 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 38 | 131578.95 | 0.00 | 48 KB | ✅ |
| Batch | Delete | 5,000 | 42 | 119047.62 | 0.00 | 92 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 1.77 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 1.77 | 1.39 MB | ✅ |
| Batch | Delete | 5,000 | 38 | 131578.95 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 52 | 96153.85 | 3.70 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 40 | 125000.00 | 4.81 | 0 B | ✅ |
| Batch | Insert | 5,000 | 43 | 116279.07 | 4.44 | 0 B | ✅ |
| Batch | Insert | 5,000 | 42 | 119047.62 | 3.06 | 0 B | ✅ |
| Batch | Insert | 5,000 | 40 | 125000.00 | 4.82 | 0 B | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 4.16 | 8 KB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 8.83 | 20 KB | ✅ |
| Batch | Select | 5,000 | 34 | 147058.82 | 3.82 | 0 B | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 4.19 | 0 B | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.33 | 0 B | ✅ |
| Batch | Update | 5,000 | 187 | 26737.97 | 2.78 | 3.15 MB | ✅ |
| Batch | Update | 5,000 | 192 | 26041.67 | 2.03 | 3.88 MB | ✅ |
| Batch | Update | 5,000 | 289 | 17301.04 | 1.58 | 3.03 MB | ✅ |
| Batch | Update | 5,000 | 178 | 28089.89 | 2.91 | 3.61 MB | ✅ |
| Batch | Update | 5,000 | 179 | 27932.96 | 2.53 | 6.38 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 4,153 | 24.08 | 0.19 | 6.79 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 110 | 909.09 | 3.55 | 0 B | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 118 | 847.46 | 1.09 | 7.27 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 4,439 | 2.25 | 0.01 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 35,976 | 2.78 | 0.01 | 6.68 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 221 | 452.49 | 2.06 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 62 | 1612.90 | 1.03 | 88 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 57 | 1754.39 | 4.51 | 548 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 119 | 840.34 | 2.73 | 7.01 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 126 | 793.65 | 2.06 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 131 | 763.36 | 1.98 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 138 | 724.64 | 1.89 | 4.78 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 133 | 751.88 | 2.93 | 7.43 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 858 | 9.32 | 0.00 | 444 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 21,513 | 46483.52 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,147 | 3.49 | 0.11 | 148 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 10,714 | 93335.82 | 2.18 | 30.37 MB | ✅ |
| Single | Delete | 1,000 | 537 | 1862.20 | 3.03 | 484 KB | ✅ |
| Single | Delete | 1,000 | 531 | 1883.24 | 2.57 | 372 KB | ✅ |
| Single | Delete | 1,000 | 531 | 1883.24 | 2.33 | 472 KB | ✅ |
| Single | Delete | 1,000 | 564 | 1773.05 | 2.31 | 312 KB | ✅ |
| Single | Delete | 1,000 | 559 | 1788.91 | 2.68 | 584 KB | ✅ |
| Single | Insert | 1,000 | 428 | 2336.45 | 4.71 | 1.48 MB | ✅ |
| Single | Insert | 1,000 | 405 | 2469.14 | 2.09 | 2.91 MB | ✅ |
| Single | Insert | 1,000 | 384 | 2604.17 | 2.20 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 406 | 2463.05 | 0.96 | 2.88 MB | ✅ |
| Single | Insert | 1,000 | 375 | 2666.67 | 1.73 | 3 MB | ✅ |
| Single | Select | 1,000 | 564 | 1773.05 | 6.00 | 1.98 MB | ✅ |
| Single | Select | 1,000 | 540 | 1851.85 | 1.81 | 256 KB | ✅ |
| Single | Select | 1,000 | 548 | 1824.82 | 2.61 | 272 KB | ✅ |
| Single | Select | 1,000 | 539 | 1855.29 | 2.65 | 308 KB | ✅ |
| Single | Select | 1,000 | 506 | 1976.28 | 2.57 | 3.72 MB | ✅ |
| Single | Update | 1,000 | 616 | 1623.38 | 3.49 | 6.21 MB | ✅ |
| Single | Update | 1,000 | 607 | 1647.45 | 1.93 | 5.25 MB | ✅ |
| Single | Update | 1,000 | 579 | 1727.12 | 2.81 | 5.26 MB | ✅ |
| Single | Update | 1,000 | 605 | 1652.89 | 2.80 | 4.29 MB | ✅ |
| Single | Update | 1,000 | 616 | 1623.38 | 2.64 | 8.28 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 11 | 90.91 | 5.57 | 224 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 31.46 | 352 KB | ✅ |
| Aggregation | Statistics | 5,000 | 27 | 222.22 | 4.68 | 1.53 MB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.67 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.97 | 0 B | ✅ |
| Batch | Delete | 5,000 | 93 | 53763.44 | 0.00 | 1.82 MB | ✅ |
| Batch | Delete | 5,000 | 110 | 45454.55 | 0.59 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 90 | 55555.56 | 0.72 | 0 B | ✅ |
| Batch | Delete | 5,000 | 95 | 52631.58 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 118 | 42372.88 | 0.55 | 1.88 MB | ✅ |
| Batch | Insert | 5,000 | 1,522 | 3285.15 | 0.38 | 7.34 MB | ✅ |
| Batch | Insert | 5,000 | 1,519 | 3291.64 | 0.39 | 6.92 MB | ✅ |
| Batch | Insert | 5,000 | 1,507 | 3317.85 | 0.35 | 1.5 MB | ✅ |
| Batch | Insert | 5,000 | 1,674 | 2986.86 | 0.78 | 2.3 MB | ✅ |
| Batch | Insert | 5,000 | 1,662 | 3008.42 | 0.86 | 6.41 MB | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.11 | 12 KB | ✅ |
| Batch | Select | 5,000 | 12 | 416666.67 | 0.00 | 72 KB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.94 | 528 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.42 | 8 KB | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 0.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,485 | 3367.00 | 0.22 | 2.43 MB | ✅ |
| Batch | Update | 5,000 | 1,491 | 3353.45 | 0.44 | 88 KB | ✅ |
| Batch | Update | 5,000 | 1,510 | 3311.26 | 0.65 | 1.03 MB | ✅ |
| Batch | Update | 5,000 | 1,630 | 3067.48 | 0.56 | 0 B | ✅ |
| Batch | Update | 5,000 | 1,583 | 3158.56 | 0.53 | 4.62 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,447 | 69.11 | 0.27 | 7.51 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 92 | 1086.96 | 2.11 | 60 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 108 | 925.93 | 3.00 | 648 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,337 | 1.58 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 47,429 | 2.11 | 0.01 | 260 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 244 | 409.84 | 1.33 | 2.63 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 63,630 | 1.57 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 52 | 1923.08 | 1.24 | 16 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 101 | 990.10 | 2.56 | 8 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 102 | 980.39 | 3.17 | 16 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 108 | 925.93 | 3.59 | 16 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 86 | 1162.79 | 3.74 | 12 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 94 | 1063.83 | 2.75 | 4.6 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 463 | 17.28 | 0.00 | 36 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 22,950 | 43572.98 | 0.02 | 64 KB | ✅ |
| MillionData | GroupBy | 32 | 2,577 | 1.55 | 0.00 | 24 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 31,095 | 32159.51 | 1.55 | 40.14 MB | ✅ |
| Single | Delete | 1,000 | 2,729 | 366.43 | 0.48 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,687 | 372.16 | 0.56 | 280 KB | ✅ |
| Single | Delete | 1,000 | 2,756 | 362.84 | 0.47 | 8 KB | ✅ |
| Single | Delete | 1,000 | 2,712 | 368.73 | 0.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,681 | 373.00 | 0.80 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,763 | 361.93 | 0.85 | 8.75 MB | ✅ |
| Single | Insert | 1,000 | 2,749 | 363.77 | 0.71 | 16.09 MB | ✅ |
| Single | Insert | 1,000 | 2,788 | 358.68 | 0.37 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,867 | 348.80 | 0.61 | 116 KB | ✅ |
| Single | Insert | 1,000 | 2,735 | 365.63 | 0.69 | 20 KB | ✅ |
| Single | Select | 1,000 | 576 | 1736.11 | 2.49 | 1.95 MB | ✅ |
| Single | Select | 1,000 | 579 | 1727.12 | 3.37 | 7 MB | ✅ |
| Single | Select | 1,000 | 590 | 1694.92 | 2.09 | 4 KB | ✅ |
| Single | Select | 1,000 | 585 | 1709.40 | 2.11 | 0 B | ✅ |
| Single | Select | 1,000 | 582 | 1718.21 | 2.79 | 7 MB | ✅ |
| Single | Update | 1,000 | 2,838 | 352.36 | 0.57 | 360 KB | ✅ |
| Single | Update | 1,000 | 2,833 | 352.98 | 0.60 | 4 MB | ✅ |
| Single | Update | 1,000 | 2,768 | 361.27 | 0.73 | 8 KB | ✅ |
| Single | Update | 1,000 | 2,840 | 352.11 | 0.50 | 0 B | ✅ |
| Single | Update | 1,000 | 2,784 | 359.20 | 0.47 | 1.16 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 48 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 5.96 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 11.05 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 16 | 312500.00 | 3.93 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.56 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.56 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 31 | 161290.32 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 8 KB | ✅ |
| Batch | Insert | 5,000 | 890 | 5617.98 | 1.02 | 6.57 MB | ✅ |
| Batch | Insert | 5,000 | 545 | 9174.31 | 2.98 | 7.06 MB | ✅ |
| Batch | Insert | 5,000 | 622 | 8038.59 | 2.30 | 6.21 MB | ✅ |
| Batch | Insert | 5,000 | 482 | 10373.44 | 2.16 | 7.3 MB | ✅ |
| Batch | Insert | 5,000 | 720 | 6944.44 | 1.99 | 6.99 MB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 8.11 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 8.13 | 4 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.62 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.91 | 0 B | ✅ |
| Batch | Update | 5,000 | 312 | 16025.64 | 2.50 | 0 B | ✅ |
| Batch | Update | 5,000 | 714 | 7002.80 | 1.19 | 4.04 MB | ✅ |
| Batch | Update | 5,000 | 386 | 12953.37 | 2.02 | 3.98 MB | ✅ |
| Batch | Update | 5,000 | 370 | 13513.51 | 2.11 | 0 B | ✅ |
| Batch | Update | 5,000 | 473 | 10570.82 | 1.92 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 308 | 324.68 | 1.69 | 4.1 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 63 | 1587.30 | 3.06 | 552 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 133 | 751.88 | 1.95 | 468 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 588 | 17.01 | 0.11 | 748 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,579 | 21.84 | 0.07 | 752 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 74 | 1351.35 | 0.87 | 528 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 9,058 | 11.04 | 0.01 | 520 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 50 | 2000.00 | 0.00 | 700 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 121 | 826.45 | 3.22 | 64 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 114 | 877.19 | 1.14 | 12 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 84 | 1190.48 | 5.41 | 44 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 113 | 884.96 | 1.72 | 244 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 61 | 1639.34 | 1.05 | 1.5 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 246 | 32.52 | 0.26 | 1.72 MB | ✅ |
| MillionData | Cleanup | 1,000,000 | 2,874 | 347947.11 | 0.02 | 68 KB | ✅ |
| MillionData | GroupBy | 32 | 213 | 18.78 | 0.00 | 2.2 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 35,022 | 28553.48 | 3.49 | 0 B | ✅ |
| Single | Delete | 1,000 | 873 | 1145.48 | 1.19 | 0 B | ✅ |
| Single | Delete | 1,000 | 900 | 1111.11 | 0.87 | 0 B | ✅ |
| Single | Delete | 1,000 | 903 | 1107.42 | 1.23 | 0 B | ✅ |
| Single | Delete | 1,000 | 883 | 1132.50 | 1.55 | 0 B | ✅ |
| Single | Delete | 1,000 | 855 | 1169.59 | 1.29 | 0 B | ✅ |
| Single | Insert | 1,000 | 969 | 1031.99 | 1.14 | 36 KB | ✅ |
| Single | Insert | 1,000 | 1,061 | 942.51 | 0.86 | 920 KB | ✅ |
| Single | Insert | 1,000 | 1,011 | 989.12 | 1.35 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,001 | 999.00 | 1.62 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,041 | 960.61 | 1.63 | 0 B | ✅ |
| Single | Select | 1,000 | 397 | 2518.89 | 2.94 | 0 B | ✅ |
| Single | Select | 1,000 | 430 | 2325.58 | 3.18 | 0 B | ✅ |
| Single | Select | 1,000 | 404 | 2475.25 | 2.42 | 0 B | ✅ |
| Single | Select | 1,000 | 410 | 2439.02 | 2.54 | 0 B | ✅ |
| Single | Select | 1,000 | 406 | 2463.05 | 1.76 | 0 B | ✅ |
| Single | Update | 1,000 | 999 | 1001.00 | 1.56 | 36 KB | ✅ |
| Single | Update | 1,000 | 1,020 | 980.39 | 0.77 | 0 B | ✅ |
| Single | Update | 1,000 | 1,028 | 972.76 | 1.58 | 0 B | ✅ |
| Single | Update | 1,000 | 1,027 | 973.71 | 1.58 | 0 B | ✅ |
| Single | Update | 1,000 | 1,057 | 946.07 | 1.05 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.66 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 320 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 248 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 26.02 | 236 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 316 KB | ✅ |
| Aggregation | Statistics | 5,000 | 1 | 6000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 24.29 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 28.73 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 41 | 121951.22 | 1.56 | 280 KB | ✅ |
| Batch | Delete | 5,000 | 43 | 116279.07 | 2.99 | 48 KB | ✅ |
| Batch | Delete | 5,000 | 61 | 81967.21 | 5.27 | 0 B | ✅ |
| Batch | Delete | 5,000 | 59 | 84745.76 | 4.37 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 60 | 83333.33 | 5.42 | 0 B | ✅ |
| Batch | Insert | 5,000 | 523 | 9560.23 | 4.11 | 3.8 MB | ✅ |
| Batch | Insert | 5,000 | 543 | 9208.10 | 4.07 | 2.44 MB | ✅ |
| Batch | Insert | 5,000 | 532 | 9398.50 | 4.04 | 0 B | ✅ |
| Batch | Insert | 5,000 | 953 | 5246.59 | 4.16 | 540 KB | ✅ |
| Batch | Insert | 5,000 | 947 | 5279.83 | 4.12 | 344 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.59 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.33 | 0 B | ✅ |
| Batch | Select | 5,000 | 11 | 454545.45 | 5.81 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.47 | 0 B | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 6.52 | 0 B | ✅ |
| Batch | Update | 5,000 | 282 | 17730.50 | 3.68 | 3.98 MB | ✅ |
| Batch | Update | 5,000 | 292 | 17123.29 | 3.78 | 196 KB | ✅ |
| Batch | Update | 5,000 | 519 | 9633.91 | 4.14 | 192 KB | ✅ |
| Batch | Update | 5,000 | 512 | 9765.62 | 4.06 | 124 KB | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 3.93 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 42,055 | 2.38 | 4.16 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 103 | 970.87 | 4.39 | 4 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 147 | 680.27 | 4.41 | 3.64 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 3,360 | 2.98 | 4.13 | 12 KB | ✅ |
| IndexQuery | OrderBy | 100 | 58,981 | 1.70 | 4.16 | 5.05 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 112 | 892.86 | 4.62 | 8 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 43,427 | 2.30 | 4.16 | 1.63 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 23 | 4347.83 | 5.56 | 0 B | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 164 | 609.76 | 4.34 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 194 | 515.46 | 4.34 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 185 | 540.54 | 4.22 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 72 | 1388.89 | 4.47 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 76 | 1315.79 | 4.27 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 445 | 17.98 | 4.09 | 20 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 123,834 | 8075.33 | 3.52 | 312 KB | ✅ |
| MillionData | GroupBy | 32 | 8,377 | 0.48 | 4.14 | 1.14 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 150,564 | 6641.69 | 3.70 | 30.56 MB | ✅ |
| Single | Delete | 1,000 | 2,558 | 390.93 | 3.10 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,864 | 349.16 | 3.14 | 32 KB | ✅ |
| Single | Delete | 1,000 | 2,839 | 352.24 | 3.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,399 | 294.20 | 3.20 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,303 | 302.76 | 3.67 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,335 | 299.85 | 2.26 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,860 | 349.65 | 3.14 | 10.75 MB | ✅ |
| Single | Insert | 1,000 | 2,632 | 379.94 | 3.29 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,403 | 293.86 | 3.25 | 28 KB | ✅ |
| Single | Insert | 1,000 | 3,409 | 293.34 | 3.36 | 4 KB | ✅ |
| Single | Select | 1,000 | 120 | 8333.33 | 4.33 | 4.01 MB | ✅ |
| Single | Select | 1,000 | 128 | 7812.50 | 4.06 | 3.06 MB | ✅ |
| Single | Select | 1,000 | 119 | 8403.36 | 4.37 | 0 B | ✅ |
| Single | Select | 1,000 | 231 | 4329.00 | 4.49 | 4 KB | ✅ |
| Single | Select | 1,000 | 238 | 4201.68 | 4.36 | 4 KB | ✅ |
| Single | Update | 1,000 | 2,842 | 351.86 | 3.27 | 960 KB | ✅ |
| Single | Update | 1,000 | 2,681 | 373.00 | 3.08 | 0 B | ✅ |
| Single | Update | 1,000 | 2,780 | 359.71 | 3.28 | 204 KB | ✅ |
| Single | Update | 1,000 | 3,397 | 294.38 | 3.56 | 388 KB | ✅ |
| Single | Update | 1,000 | 3,506 | 285.23 | 3.18 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 33 | 30.30 | 0.00 | 88 KB | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 2.14 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 2.18 | 248 KB | ✅ |
| Aggregation | GroupBy | 8 | 27 | 37.04 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 2.22 | 32 KB | ✅ |
| Aggregation | Statistics | 5,000 | 14 | 428.57 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.57 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 9.21 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 214 | 23364.49 | 0.30 | 816 KB | ✅ |
| Batch | Delete | 5,000 | 209 | 23923.44 | 0.31 | 2.09 MB | ✅ |
| Batch | Delete | 5,000 | 215 | 23255.81 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 216 | 23148.15 | 0.30 | 0 B | ✅ |
| Batch | Delete | 5,000 | 211 | 23696.68 | 0.00 | 264 KB | ✅ |
| Batch | Insert | 5,000 | 4,855 | 1029.87 | 0.12 | 2.34 MB | ✅ |
| Batch | Insert | 5,000 | 4,828 | 1035.63 | 0.12 | 1.25 MB | ✅ |
| Batch | Insert | 5,000 | 4,807 | 1040.15 | 0.08 | 4.12 MB | ✅ |
| Batch | Insert | 5,000 | 4,895 | 1021.45 | 0.11 | 1000 KB | ✅ |
| Batch | Insert | 5,000 | 4,717 | 1060.00 | 0.07 | 424 KB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 0.00 | 12 KB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.80 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 4.50 | 8 KB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 11.70 | 0 B | ✅ |
| Batch | Select | 5,000 | 14 | 357142.86 | 0.00 | 436 KB | ✅ |
| Batch | Update | 5,000 | 2,577 | 1940.24 | 0.08 | 0 B | ✅ |
| Batch | Update | 5,000 | 2,553 | 1958.48 | 0.15 | 4.01 MB | ✅ |
| Batch | Update | 5,000 | 2,593 | 1928.27 | 0.18 | 1.39 MB | ✅ |
| Batch | Update | 5,000 | 2,681 | 1864.98 | 0.05 | 64 KB | ✅ |
| Batch | Update | 5,000 | 2,563 | 1950.84 | 0.15 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,536 | 65.10 | 0.08 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 194 | 515.46 | 1.67 | 28 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 218 | 458.72 | 1.49 | 28 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,527 | 3.96 | 0.03 | 388 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,129 | 24.22 | 0.16 | 1.54 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 231 | 432.90 | 0.56 | 1.33 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,478 | 6.46 | 0.05 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 113 | 884.96 | 0.57 | 0 B | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 215 | 465.12 | 2.12 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 208 | 480.77 | 1.25 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 207 | 483.09 | 1.88 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 114 | 877.19 | 2.83 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 436 | 229.36 | 0.90 | 3.82 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 447 | 17.90 | 0.00 | 592 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 22,662 | 44126.73 | 0.01 | 652 KB | ✅ |
| MillionData | GroupBy | 32 | 115 | 34.78 | 0.57 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 30,819 | 32447.52 | 1.78 | 46.66 MB | ✅ |
| Single | Delete | 1,000 | 1,636 | 611.25 | 0.68 | 788 KB | ✅ |
| Single | Delete | 1,000 | 1,620 | 617.28 | 0.28 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,675 | 597.01 | 0.54 | 12 KB | ✅ |
| Single | Delete | 1,000 | 1,572 | 636.13 | 0.46 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,650 | 606.06 | 0.24 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,555 | 643.09 | 1.09 | 976 KB | ✅ |
| Single | Insert | 1,000 | 1,574 | 635.32 | 0.45 | 12 KB | ✅ |
| Single | Insert | 1,000 | 1,595 | 626.96 | 0.98 | 15.1 MB | ✅ |
| Single | Insert | 1,000 | 1,533 | 652.32 | 0.59 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,566 | 638.57 | 0.37 | 0 B | ✅ |
| Single | Select | 1,000 | 1,075 | 930.23 | 1.21 | 0 B | ✅ |
| Single | Select | 1,000 | 1,081 | 925.07 | 0.42 | 0 B | ✅ |
| Single | Select | 1,000 | 1,081 | 925.07 | 0.78 | 4 MB | ✅ |
| Single | Select | 1,000 | 1,097 | 911.58 | 0.65 | 0 B | ✅ |
| Single | Select | 1,000 | 1,103 | 906.62 | 0.59 | 0 B | ✅ |
| Single | Update | 1,000 | 3,737 | 267.59 | 0.17 | 0 B | ✅ |
| Single | Update | 1,000 | 3,810 | 262.47 | 0.19 | 0 B | ✅ |
| Single | Update | 1,000 | 3,628 | 275.63 | 0.23 | 4.07 MB | ✅ |
| Single | Update | 1,000 | 3,685 | 271.37 | 0.21 | 0 B | ✅ |
| Single | Update | 1,000 | 3,756 | 266.24 | 0.21 | 120 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 7.33 | 3.47 | 7.41 | 0.00 | 9.14 | 1.31 |
| Aggregation | Statistics | 8.32 | 6.97 | 4.66 | 3.40 | 10.60 | 3.36 |
| Batch | Delete | 0.87 | 0.71 | 0.37 | 2.21 | 3.92 | 0.18 |
| Batch | Insert | 0.80 | 4.17 | 0.55 | 2.09 | 4.10 | 0.10 |
| Batch | Select | 6.22 | 5.07 | 3.09 | 6.15 | 6.34 | 4.20 |
| Batch | Update | 0.58 | 2.37 | 0.48 | 1.95 | 3.92 | 0.12 |
| IndexQuery | ComplexCondition | 0.05 | 0.19 | 0.27 | 1.69 | 4.16 | 0.08 |
| IndexQuery | CompositeIndex_RegionDept | 3.95 | 3.55 | 2.11 | 3.06 | 4.39 | 1.67 |
| IndexQuery | CompositeIndex_StatusCatPri | 3.62 | 1.09 | 3.00 | 1.95 | 4.41 | 1.49 |
| IndexQuery | NoIndex_FullScan | 0.01 | 0.01 | 0.00 | 0.11 | 4.13 | 0.03 |
| IndexQuery | OrderBy | 0.03 | 0.01 | 0.01 | 0.07 | 4.16 | 0.16 |
| IndexQuery | Pagination | 1.55 | 2.06 | 1.33 | 0.87 | 4.62 | 0.56 |
| IndexQuery | PrefixQuery_Name | 0.01 | 1.03 | 0.01 | 0.01 | 4.16 | 0.05 |
| IndexQuery | PrimaryKey | 1.03 | 4.51 | 1.24 | 0.00 | 5.56 | 0.57 |
| IndexQuery | RangeQuery_Date | 3.02 | 2.73 | 2.56 | 3.22 | 4.34 | 2.12 |
| IndexQuery | RangeQuery_Salary | 2.17 | 2.06 | 3.17 | 1.14 | 4.34 | 1.25 |
| IndexQuery | RangeQuery_Score | 2.94 | 1.98 | 3.59 | 5.41 | 4.22 | 1.88 |
| IndexQuery | SingleIndex_Category | 0.86 | 1.89 | 3.74 | 1.72 | 4.47 | 2.83 |
| IndexQuery | SingleIndex_Status | 3.45 | 2.93 | 2.75 | 1.05 | 4.27 | 0.90 |
| MillionData | Aggregation | 0.00 | 0.00 | 0.00 | 0.26 | 4.09 | 0.00 |
| MillionData | Cleanup | 0.00 | 0.00 | 0.02 | 0.02 | 3.52 | 0.01 |
| MillionData | GroupBy | 0.00 | 0.11 | 0.00 | 0.00 | 4.14 | 0.57 |
| MillionData | PrepareData | 1.95 | 2.18 | 1.55 | 3.49 | 3.70 | 1.78 |
| Single | Delete | 1.06 | 2.58 | 0.55 | 1.23 | 3.22 | 0.44 |
| Single | Insert | 1.12 | 2.34 | 0.65 | 1.32 | 3.06 | 0.70 |
| Single | Select | 2.15 | 3.13 | 2.57 | 2.57 | 4.32 | 0.73 |
| Single | Update | 1.00 | 2.73 | 0.57 | 1.31 | 3.27 | 0.20 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 284 KB | 16 KB | 352 KB | 48 KB | 320 KB | 248 KB |
| Aggregation | Statistics | 1.45 MB | 720 KB | 1.53 MB | 8 KB | 316 KB | 28 KB |
| Batch | Delete | 20 KB | 1.39 MB | 1.88 MB | 32 KB | 280 KB | 2.09 MB |
| Batch | Insert | 5.98 MB | 12 KB | 7.34 MB | 7.3 MB | 3.8 MB | 4.12 MB |
| Batch | Select | 0 B | 20 KB | 528 KB | 4 KB | 0 B | 436 KB |
| Batch | Update | 3.95 MB | 6.38 MB | 4.62 MB | 4.04 MB | 3.98 MB | 4.01 MB |
| IndexQuery | ComplexCondition | 56 KB | 6.79 MB | 7.51 MB | 4.1 MB | 0 B | 0 B |
| IndexQuery | CompositeIndex_RegionDept | 408 KB | 0 B | 60 KB | 552 KB | 4 KB | 28 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 364 KB | 7.27 MB | 648 KB | 468 KB | 3.64 MB | 28 KB |
| IndexQuery | NoIndex_FullScan | 52 KB | 0 B | 0 B | 748 KB | 12 KB | 388 KB |
| IndexQuery | OrderBy | 0 B | 6.68 MB | 260 KB | 752 KB | 5.05 MB | 1.54 MB |
| IndexQuery | Pagination | 892 KB | 0 B | 2.63 MB | 528 KB | 8 KB | 1.33 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 88 KB | 0 B | 520 KB | 1.63 MB | 0 B |
| IndexQuery | PrimaryKey | 2.68 MB | 548 KB | 16 KB | 700 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Date | 80 KB | 7.01 MB | 8 KB | 64 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Salary | 940 KB | 0 B | 16 KB | 12 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Score | 3.24 MB | 0 B | 16 KB | 44 KB | 8 KB | 0 B |
| IndexQuery | SingleIndex_Category | 32 KB | 4.78 MB | 12 KB | 244 KB | 0 B | 0 B |
| IndexQuery | SingleIndex_Status | 4.78 MB | 7.43 MB | 4.6 MB | 1.5 MB | 0 B | 3.82 MB |
| MillionData | Aggregation | 0 B | 444 KB | 36 KB | 1.72 MB | 20 KB | 592 KB |
| MillionData | Cleanup | 1.64 MB | 0 B | 64 KB | 68 KB | 312 KB | 652 KB |
| MillionData | GroupBy | 40 KB | 148 KB | 24 KB | 2.2 MB | 1.14 MB | 0 B |
| MillionData | PrepareData | 39.44 MB | 30.37 MB | 40.14 MB | 0 B | 30.56 MB | 46.66 MB |
| Single | Delete | 828 KB | 584 KB | 280 KB | 0 B | 32 KB | 788 KB |
| Single | Insert | 15.41 MB | 3 MB | 16.09 MB | 920 KB | 10.75 MB | 15.1 MB |
| Single | Select | 4 MB | 3.72 MB | 7 MB | 0 B | 4.01 MB | 4 MB |
| Single | Update | 4 MB | 8.28 MB | 4 MB | 36 KB | 960 KB | 4.07 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 12:17:04*
