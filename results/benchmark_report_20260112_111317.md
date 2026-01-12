# 数据库基准测试报告

**测试时间**: 2026-01-12 11:13:17

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
| 采集时间 | 2026-01-12 11:13:17 |


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
| Aggregation | GroupBy | 4.20 | 3.20 | 7.00 | 2.20 | 2.60 | 31.60 | **PostgreSQL** |
| Aggregation | Statistics | 9.00 | 9.80 | 16.20 | 6.60 | 2.60 | 8.20 | **SQLite** |
| Batch | Delete | 63.00 | 39.00 | 129.80 | 20.00 | 71.60 | 244.60 | **PostgreSQL** |
| Batch | Insert | 680.00 | 42.80 | 806.80 | 1040.80 | 950.40 | 5004.00 | **MongoDB** |
| Batch | Select | 39.80 | 31.00 | 42.40 | 9.20 | 20.00 | 20.80 | **PostgreSQL** |
| Batch | Update | 486.60 | 238.60 | 570.80 | 693.60 | 512.60 | 2688.40 | **MongoDB** |
| IndexQuery | ComplexCondition | 10483.00 | 3096.00 | 1965.00 | 335.00 | 53208.00 | 1626.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 168.00 | 99.00 | 195.00 | 68.00 | 102.00 | 240.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 180.00 | 100.00 | 223.00 | 129.00 | 145.00 | 236.00 | **MongoDB** |
| IndexQuery | NoIndex_FullScan | 6054.00 | 4092.00 | 6488.00 | 639.00 | 6242.00 | 2554.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10857.00 | 35744.00 | 47889.00 | 4596.00 | 50744.00 | 4161.00 | **SQLServer** |
| IndexQuery | Pagination | 279.00 | 199.00 | 351.00 | 73.00 | 183.00 | 254.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 43285.00 | 60.00 | 60372.00 | 9567.00 | 51998.00 | 15585.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 104.00 | 57.00 | 113.00 | 51.00 | 23.00 | 175.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 178.00 | 94.00 | 184.00 | 136.00 | 155.00 | 249.00 | **MongoDB** |
| IndexQuery | RangeQuery_Salary | 175.00 | 108.00 | 242.00 | 102.00 | 186.00 | 195.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 181.00 | 124.00 | 301.00 | 109.00 | 186.00 | 217.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 161.00 | 111.00 | 175.00 | 141.00 | 73.00 | 125.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 161.00 | 113.00 | 185.00 | 79.00 | 72.00 | 489.00 | **SQLite** |
| MillionData | Aggregation | 469.00 | 855.00 | 473.00 | 229.00 | 812.00 | 456.00 | **PostgreSQL** |
| MillionData | Cleanup | 18949.00 | 20949.00 | 23521.00 | 32045.00 | 93503.00 | 23005.00 | **MariaDB** |
| MillionData | GroupBy | 1996.00 | 1164.00 | 2700.00 | 229.00 | 11895.00 | 119.00 | **SQLServer** |
| MillionData | PrepareData | 97247.00 | 8256.00 | 186893.00 | 23928.00 | 332344.00 | 28329.00 | **MongoDB** |
| Single | Delete | 1606.40 | 561.20 | 3266.60 | 890.40 | 3282.60 | 1796.80 | **MongoDB** |
| Single | Insert | 1746.40 | 409.20 | 3428.00 | 1039.80 | 3341.20 | 1741.60 | **MongoDB** |
| Single | Select | 1110.40 | 539.00 | 1191.20 | 401.60 | 233.60 | 1199.20 | **SQLite** |
| Single | Update | 1796.80 | 597.00 | 3560.60 | 1116.40 | 3371.80 | 4715.40 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 240.00 | 316.66 | 210.53 | 466.67 | 440.00 | 31.90 | **PostgreSQL** |
| Aggregation | Statistics | 675.76 | 206.06 | 560.00 | 1160.00 | 2640.00 | 822.86 | **SQLite** |
| Batch | Delete | 79420.02 | 128483.81 | 38636.73 | 251372.99 | 76902.03 | 20580.01 | **PostgreSQL** |
| Batch | Insert | 7364.87 | 118919.12 | 6270.10 | 4918.80 | 5260.97 | 1000.51 | **MongoDB** |
| Batch | Select | 125706.03 | 161755.49 | 118097.08 | 544444.45 | 250000.00 | 250051.60 | **PostgreSQL** |
| Batch | Update | 10365.06 | 22126.15 | 8901.16 | 7245.44 | 9754.35 | 1863.98 | **MongoDB** |
| IndexQuery | ComplexCondition | 9.54 | 32.30 | 50.89 | 298.51 | 1.88 | 61.50 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 595.24 | 1010.10 | 512.82 | 1470.59 | 980.39 | 416.67 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 555.56 | 1000.00 | 448.43 | 775.19 | 689.66 | 423.73 | **MongoDB** |
| IndexQuery | NoIndex_FullScan | 1.65 | 2.44 | 1.54 | 15.65 | 1.60 | 3.92 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.21 | 2.80 | 2.09 | 21.76 | 1.97 | 24.03 | **SQLServer** |
| IndexQuery | Pagination | 358.42 | 502.51 | 284.90 | 1369.86 | 546.45 | 393.70 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.31 | 1666.67 | 1.66 | 10.45 | 1.92 | 6.42 | **MongoDB** |
| IndexQuery | PrimaryKey | 961.54 | 1754.39 | 884.96 | 1960.78 | 4347.83 | 571.43 | **SQLite** |
| IndexQuery | RangeQuery_Date | 561.80 | 1063.83 | 543.48 | 735.29 | 645.16 | 401.61 | **MongoDB** |
| IndexQuery | RangeQuery_Salary | 571.43 | 925.93 | 413.22 | 980.39 | 537.63 | 512.82 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 552.49 | 806.45 | 332.23 | 917.43 | 537.63 | 460.83 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 621.12 | 900.90 | 571.43 | 709.22 | 1369.86 | 800.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 621.12 | 884.96 | 540.54 | 1265.82 | 1388.89 | 204.50 | **SQLite** |
| MillionData | Aggregation | 17.06 | 9.36 | 16.91 | 34.93 | 9.85 | 17.54 | **PostgreSQL** |
| MillionData | Cleanup | 52773.23 | 47734.98 | 42515.20 | 31206.12 | 10694.84 | 43468.81 | **MariaDB** |
| MillionData | GroupBy | 2.00 | 3.44 | 1.48 | 17.47 | 0.34 | 33.61 | **SQLServer** |
| MillionData | PrepareData | 10283.09 | 121124.03 | 5350.66 | 41792.04 | 3008.93 | 35299.52 | **MongoDB** |
| Single | Delete | 622.81 | 1783.91 | 306.41 | 1123.61 | 304.74 | 574.60 | **MongoDB** |
| Single | Insert | 573.02 | 2448.70 | 291.84 | 961.79 | 299.35 | 583.71 | **MongoDB** |
| Single | Select | 901.44 | 1857.33 | 840.14 | 2494.96 | 4280.97 | 838.46 | **SQLite** |
| Single | Update | 556.87 | 1675.77 | 280.92 | 896.81 | 296.65 | 224.28 | **MongoDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 15.78 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.11 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.86 | 32 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 22.35 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.46 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 14.35 | 1.68 MB | ✅ |
| Batch | Delete | 5,000 | 66 | 75757.58 | 3.91 | 588 KB | ✅ |
| Batch | Delete | 5,000 | 62 | 80645.16 | 1.04 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 61 | 81967.21 | 1.05 | 568 KB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 2.06 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 0.00 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 681 | 7342.14 | 3.63 | 10.2 MB | ✅ |
| Batch | Insert | 5,000 | 671 | 7451.56 | 3.69 | 7.48 MB | ✅ |
| Batch | Insert | 5,000 | 733 | 6821.28 | 3.64 | 7.28 MB | ✅ |
| Batch | Insert | 5,000 | 655 | 7633.59 | 4.17 | 10.63 MB | ✅ |
| Batch | Insert | 5,000 | 660 | 7575.76 | 3.75 | 7.35 MB | ✅ |
| Batch | Select | 5,000 | 40 | 125000.00 | 4.86 | 0 B | ✅ |
| Batch | Select | 5,000 | 40 | 125000.00 | 4.77 | 0 B | ✅ |
| Batch | Select | 5,000 | 38 | 131578.95 | 5.05 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 41 | 121951.22 | 3.13 | 372 KB | ✅ |
| Batch | Select | 5,000 | 40 | 125000.00 | 3.22 | 0 B | ✅ |
| Batch | Update | 5,000 | 452 | 11061.95 | 3.31 | 7.99 MB | ✅ |
| Batch | Update | 5,000 | 544 | 9191.18 | 2.75 | 4.86 MB | ✅ |
| Batch | Update | 5,000 | 450 | 11111.11 | 3.04 | 6.19 MB | ✅ |
| Batch | Update | 5,000 | 542 | 9225.09 | 2.52 | 5.79 MB | ✅ |
| Batch | Update | 5,000 | 445 | 11235.96 | 3.07 | 4.96 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 10,483 | 9.54 | 0.03 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 168 | 595.24 | 2.32 | 148 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 180 | 555.56 | 2.16 | 520 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,054 | 1.65 | 0.01 | 92 KB | ✅ |
| IndexQuery | OrderBy | 100 | 10,857 | 9.21 | 0.02 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 279 | 358.42 | 1.86 | 1.63 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 43,285 | 2.31 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 104 | 961.54 | 1.86 | 8.47 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 178 | 561.80 | 2.19 | 100 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 175 | 571.43 | 2.97 | 824 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 181 | 552.49 | 3.59 | 3.62 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 161 | 621.12 | 4.04 | 48 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 161 | 621.12 | 2.01 | 136 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 469 | 17.06 | 0.00 | 0 B | ✅ |
| MillionData | Cleanup | 1,000,000 | 18,949 | 52773.23 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,996 | 2.00 | 0.00 | 12 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 97,247 | 10283.09 | 2.44 | 19.79 MB | ✅ |
| Single | Delete | 1,000 | 1,634 | 612.00 | 1.31 | 4 MB | ✅ |
| Single | Delete | 1,000 | 1,623 | 616.14 | 1.16 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,615 | 619.20 | 1.57 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,538 | 650.20 | 1.69 | 3 MB | ✅ |
| Single | Delete | 1,000 | 1,622 | 616.52 | 1.36 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,799 | 555.86 | 1.56 | 2.38 MB | ✅ |
| Single | Insert | 1,000 | 1,808 | 553.10 | 1.01 | 7.94 MB | ✅ |
| Single | Insert | 1,000 | 1,707 | 585.82 | 1.30 | 2.93 MB | ✅ |
| Single | Insert | 1,000 | 1,700 | 588.24 | 1.26 | 7.2 MB | ✅ |
| Single | Insert | 1,000 | 1,718 | 582.07 | 1.44 | 2.35 MB | ✅ |
| Single | Select | 1,000 | 1,085 | 921.66 | 1.80 | 3.47 MB | ✅ |
| Single | Select | 1,000 | 1,153 | 867.30 | 1.69 | 16 KB | ✅ |
| Single | Select | 1,000 | 1,131 | 884.17 | 2.36 | 0 B | ✅ |
| Single | Select | 1,000 | 1,125 | 888.89 | 1.68 | 0 B | ✅ |
| Single | Select | 1,000 | 1,058 | 945.18 | 1.78 | 1012 KB | ✅ |
| Single | Update | 1,000 | 1,829 | 546.75 | 1.67 | 36 KB | ✅ |
| Single | Update | 1,000 | 1,864 | 536.48 | 1.54 | 3.16 MB | ✅ |
| Single | Update | 1,000 | 1,742 | 574.05 | 1.68 | 404 KB | ✅ |
| Single | Update | 1,000 | 1,780 | 561.80 | 1.50 | 3.29 MB | ✅ |
| Single | Update | 1,000 | 1,769 | 565.29 | 1.55 | 116 KB | ✅ |

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.76 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 33 | 30.30 | 3.91 | 688 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 13.85 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 250.00 | 14.83 | 0 B | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 1.59 | 44 KB | ✅ |
| Batch | Delete | 5,000 | 41 | 121951.22 | 3.16 | 100 KB | ✅ |
| Batch | Delete | 5,000 | 40 | 125000.00 | 1.59 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 36 | 138888.89 | 3.54 | 2.79 MB | ✅ |
| Batch | Delete | 5,000 | 38 | 131578.95 | 1.69 | 0 B | ✅ |
| Batch | Insert | 5,000 | 55 | 90909.09 | 3.51 | 0 B | ✅ |
| Batch | Insert | 5,000 | 41 | 121951.22 | 0.00 | 376 KB | ✅ |
| Batch | Insert | 5,000 | 41 | 121951.22 | 4.71 | 368 KB | ✅ |
| Batch | Insert | 5,000 | 39 | 128205.13 | 0.00 | 148 KB | ✅ |
| Batch | Insert | 5,000 | 38 | 131578.95 | 5.03 | 360 KB | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 1.96 | 12 KB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 2.18 | 0 B | ✅ |
| Batch | Select | 5,000 | 33 | 151515.15 | 1.94 | 0 B | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 8.55 | 524 KB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.28 | 0 B | ✅ |
| Batch | Update | 5,000 | 298 | 16778.52 | 1.31 | 3.11 MB | ✅ |
| Batch | Update | 5,000 | 319 | 15673.98 | 1.63 | 5.7 MB | ✅ |
| Batch | Update | 5,000 | 195 | 25641.03 | 2.33 | 3.65 MB | ✅ |
| Batch | Update | 5,000 | 185 | 27027.03 | 2.46 | 3.63 MB | ✅ |
| Batch | Update | 5,000 | 196 | 25510.20 | 1.98 | 3.66 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 3,096 | 32.30 | 0.11 | 6.3 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 99 | 1010.10 | 1.96 | 192 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 100 | 1000.00 | 0.65 | 124 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 4,092 | 2.44 | 0.02 | 20 KB | ✅ |
| IndexQuery | OrderBy | 100 | 35,744 | 2.80 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 199 | 502.51 | 0.65 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 60 | 1666.67 | 3.25 | 36 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 57 | 1754.39 | 2.25 | 400 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 94 | 1063.83 | 1.37 | 52 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 108 | 925.93 | 1.20 | 12 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 124 | 806.45 | 1.04 | 240 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 111 | 900.90 | 2.33 | 3.81 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 113 | 884.96 | 2.88 | 2.31 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 855 | 9.36 | 0.00 | 328 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 20,949 | 47734.98 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,164 | 3.44 | 0.00 | 100 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 8,256 | 121124.03 | 1.60 | 44.65 MB | ✅ |
| Single | Delete | 1,000 | 546 | 1831.50 | 2.62 | 416 KB | ✅ |
| Single | Delete | 1,000 | 572 | 1748.25 | 2.05 | 4.19 MB | ✅ |
| Single | Delete | 1,000 | 594 | 1683.50 | 2.08 | 6.38 MB | ✅ |
| Single | Delete | 1,000 | 547 | 1828.15 | 3.09 | 10.45 MB | ✅ |
| Single | Delete | 1,000 | 547 | 1828.15 | 3.33 | 15.61 MB | ✅ |
| Single | Insert | 1,000 | 433 | 2309.47 | 4.66 | 1.66 MB | ✅ |
| Single | Insert | 1,000 | 399 | 2506.27 | 1.79 | 2.94 MB | ✅ |
| Single | Insert | 1,000 | 416 | 2403.85 | 0.94 | 10.16 MB | ✅ |
| Single | Insert | 1,000 | 418 | 2392.34 | 2.02 | 6.16 MB | ✅ |
| Single | Insert | 1,000 | 380 | 2631.58 | 2.56 | 6.16 MB | ✅ |
| Single | Select | 1,000 | 569 | 1757.47 | 5.49 | 1.64 MB | ✅ |
| Single | Select | 1,000 | 515 | 1941.75 | 2.90 | 212 KB | ✅ |
| Single | Select | 1,000 | 537 | 1862.20 | 1.45 | 5.32 MB | ✅ |
| Single | Select | 1,000 | 545 | 1834.86 | 2.27 | 5.32 MB | ✅ |
| Single | Select | 1,000 | 529 | 1890.36 | 1.84 | 5.32 MB | ✅ |
| Single | Update | 1,000 | 621 | 1610.31 | 3.67 | 5.52 MB | ✅ |
| Single | Update | 1,000 | 598 | 1672.24 | 2.50 | 2.5 MB | ✅ |
| Single | Update | 1,000 | 587 | 1703.58 | 2.44 | 12.27 MB | ✅ |
| Single | Update | 1,000 | 588 | 1700.68 | 2.66 | 11.25 MB | ✅ |
| Single | Update | 1,000 | 591 | 1692.05 | 1.32 | 11.27 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 19 | 52.63 | 3.42 | 160 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 92 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.01 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 45 | 133.33 | 2.89 | 868 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.67 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.85 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.78 | 0 B | ✅ |
| Batch | Delete | 5,000 | 124 | 40322.58 | 0.00 | 1.3 MB | ✅ |
| Batch | Delete | 5,000 | 137 | 36496.35 | 1.42 | 1.27 MB | ✅ |
| Batch | Delete | 5,000 | 123 | 40650.41 | 1.05 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 140 | 35714.29 | 0.00 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 125 | 40000.00 | 0.52 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 899 | 5561.74 | 3.04 | 7.17 MB | ✅ |
| Batch | Insert | 5,000 | 706 | 7082.15 | 3.41 | 12.2 MB | ✅ |
| Batch | Insert | 5,000 | 708 | 7062.15 | 3.76 | 7.34 MB | ✅ |
| Batch | Insert | 5,000 | 822 | 6082.73 | 2.85 | 7.33 MB | ✅ |
| Batch | Insert | 5,000 | 899 | 5561.74 | 2.82 | 8.35 MB | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 4.55 | 2.47 MB | ✅ |
| Batch | Select | 5,000 | 40 | 125000.00 | 4.85 | 364 KB | ✅ |
| Batch | Select | 5,000 | 45 | 111111.11 | 5.74 | 0 B | ✅ |
| Batch | Select | 5,000 | 43 | 116279.07 | 4.49 | 0 B | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 1.51 | 0 B | ✅ |
| Batch | Update | 5,000 | 701 | 7132.67 | 2.32 | 6.32 MB | ✅ |
| Batch | Update | 5,000 | 611 | 8183.31 | 2.45 | 5.42 MB | ✅ |
| Batch | Update | 5,000 | 503 | 9940.36 | 2.72 | 4.88 MB | ✅ |
| Batch | Update | 5,000 | 518 | 9652.51 | 2.89 | 6.21 MB | ✅ |
| Batch | Update | 5,000 | 521 | 9596.93 | 2.62 | 6.7 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,965 | 50.89 | 0.20 | 6.5 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 195 | 512.82 | 0.66 | 436 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 223 | 448.43 | 1.75 | 172 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,488 | 1.54 | 0.03 | 3.48 MB | ✅ |
| IndexQuery | OrderBy | 100 | 47,889 | 2.09 | 0.01 | 4.79 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 351 | 284.90 | 1.67 | 156 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 60,372 | 1.66 | 0.01 | 1 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 113 | 884.96 | 2.87 | 7.38 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 184 | 543.48 | 1.41 | 1.44 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 242 | 413.22 | 0.80 | 232 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 301 | 332.23 | 1.94 | 1.46 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 175 | 571.43 | 1.49 | 3.52 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 185 | 540.54 | 3.85 | 456 KB | ✅ |
| MillionData | Aggregation | 1,000,000 | 473 | 16.91 | 0.27 | 484 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 23,521 | 42515.20 | 0.01 | 1.86 MB | ✅ |
| MillionData | GroupBy | 32 | 2,700 | 1.48 | 0.00 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 186,893 | 5350.66 | 2.35 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,237 | 308.93 | 0.56 | 4.81 MB | ✅ |
| Single | Delete | 1,000 | 3,178 | 314.66 | 0.74 | 2.95 MB | ✅ |
| Single | Delete | 1,000 | 3,154 | 317.06 | 0.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,399 | 294.20 | 0.56 | 1.64 MB | ✅ |
| Single | Delete | 1,000 | 3,365 | 297.18 | 0.60 | 2.29 MB | ✅ |
| Single | Insert | 1,000 | 3,399 | 294.20 | 1.28 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,353 | 298.24 | 0.93 | 6.95 MB | ✅ |
| Single | Insert | 1,000 | 3,366 | 297.09 | 0.60 | 7.35 MB | ✅ |
| Single | Insert | 1,000 | 3,523 | 283.85 | 0.78 | 1.95 MB | ✅ |
| Single | Insert | 1,000 | 3,499 | 285.80 | 0.78 | 0 B | ✅ |
| Single | Select | 1,000 | 1,138 | 878.73 | 2.63 | 8 MB | ✅ |
| Single | Select | 1,000 | 1,227 | 815.00 | 2.01 | 4.02 MB | ✅ |
| Single | Select | 1,000 | 1,171 | 853.97 | 2.22 | 2.04 MB | ✅ |
| Single | Select | 1,000 | 1,201 | 832.64 | 2.28 | 148 KB | ✅ |
| Single | Select | 1,000 | 1,219 | 820.34 | 1.60 | 56 KB | ✅ |
| Single | Update | 1,000 | 3,461 | 288.93 | 0.73 | 0 B | ✅ |
| Single | Update | 1,000 | 3,561 | 280.82 | 0.77 | 2.16 MB | ✅ |
| Single | Update | 1,000 | 3,612 | 276.85 | 0.85 | 116 KB | ✅ |
| Single | Update | 1,000 | 3,615 | 276.63 | 0.59 | 0 B | ✅ |
| Single | Update | 1,000 | 3,554 | 281.37 | 0.59 | 5.19 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 32 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 26.70 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 4.17 | 16 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 26.79 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 23.14 | 0 B | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 36 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.29 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 3.32 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 23 | 217391.30 | 2.73 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 1,164 | 4295.53 | 1.68 | 11.03 MB | ✅ |
| Batch | Insert | 5,000 | 805 | 6211.18 | 2.42 | 8.15 MB | ✅ |
| Batch | Insert | 5,000 | 1,191 | 4198.15 | 1.64 | 7.87 MB | ✅ |
| Batch | Insert | 5,000 | 1,127 | 4436.56 | 2.25 | 8.27 MB | ✅ |
| Batch | Insert | 5,000 | 917 | 5452.56 | 2.20 | 10.91 MB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.70 | 4 KB | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.85 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 7.08 | 0 B | ✅ |
| Batch | Select | 5,000 | 9 | 555555.56 | 6.70 | 0 B | ✅ |
| Batch | Select | 5,000 | 10 | 500000.00 | 6.11 | 0 B | ✅ |
| Batch | Update | 5,000 | 717 | 6973.50 | 2.00 | 0 B | ✅ |
| Batch | Update | 5,000 | 670 | 7462.69 | 2.43 | 0 B | ✅ |
| Batch | Update | 5,000 | 623 | 8025.68 | 2.92 | 0 B | ✅ |
| Batch | Update | 5,000 | 772 | 6476.68 | 1.77 | 0 B | ✅ |
| Batch | Update | 5,000 | 686 | 7288.63 | 1.90 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 335 | 298.51 | 0.78 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 68 | 1470.59 | 3.79 | 40 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 129 | 775.19 | 2.01 | 56 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 639 | 15.65 | 0.10 | 52 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,596 | 21.76 | 0.07 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 73 | 1369.86 | 2.66 | 4 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 9,567 | 10.45 | 0.00 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 51 | 1960.78 | 5.09 | 44 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 136 | 735.29 | 1.90 | 4 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 102 | 980.39 | 5.09 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 109 | 917.43 | 4.16 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 141 | 709.22 | 3.69 | 80 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 79 | 1265.82 | 3.26 | 3.85 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 229 | 34.93 | 0.28 | 460 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 32,045 | 31206.12 | 0.01 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 229 | 17.47 | 0.28 | 112 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 23,928 | 41792.04 | 2.33 | 31.02 MB | ✅ |
| Single | Delete | 1,000 | 926 | 1079.91 | 0.91 | 152 KB | ✅ |
| Single | Delete | 1,000 | 872 | 1146.79 | 1.42 | 0 B | ✅ |
| Single | Delete | 1,000 | 882 | 1133.79 | 0.96 | 0 B | ✅ |
| Single | Delete | 1,000 | 895 | 1117.32 | 1.24 | 0 B | ✅ |
| Single | Delete | 1,000 | 877 | 1140.25 | 1.41 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,042 | 959.69 | 1.75 | 15.63 MB | ✅ |
| Single | Insert | 1,000 | 1,024 | 976.56 | 1.59 | 620 KB | ✅ |
| Single | Insert | 1,000 | 1,051 | 951.47 | 1.18 | 12 KB | ✅ |
| Single | Insert | 1,000 | 1,042 | 959.69 | 1.00 | 2.86 MB | ✅ |
| Single | Insert | 1,000 | 1,040 | 961.54 | 0.88 | 2.85 MB | ✅ |
| Single | Select | 1,000 | 408 | 2450.98 | 2.87 | 7.07 MB | ✅ |
| Single | Select | 1,000 | 382 | 2617.80 | 3.07 | 0 B | ✅ |
| Single | Select | 1,000 | 387 | 2583.98 | 2.35 | 0 B | ✅ |
| Single | Select | 1,000 | 398 | 2512.56 | 3.43 | 0 B | ✅ |
| Single | Select | 1,000 | 433 | 2309.47 | 2.40 | 7.99 MB | ✅ |
| Single | Update | 1,000 | 1,187 | 842.46 | 1.43 | 604 KB | ✅ |
| Single | Update | 1,000 | 1,091 | 916.59 | 1.19 | 0 B | ✅ |
| Single | Update | 1,000 | 1,131 | 884.17 | 1.38 | 0 B | ✅ |
| Single | Update | 1,000 | 1,081 | 925.07 | 1.57 | 0 B | ✅ |
| Single | Update | 1,000 | 1,092 | 915.75 | 1.19 | 592 KB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 112 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 196 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 26.58 | 248 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 64 KB | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 12.70 | 316 KB | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 27.89 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 29.51 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 2 | 3000.00 | 28.43 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 3.32 | 188 KB | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 3.33 | 80 KB | ✅ |
| Batch | Delete | 5,000 | 126 | 39682.54 | 2.57 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 4.42 | 0 B | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 3.32 | 100 KB | ✅ |
| Batch | Insert | 5,000 | 951 | 5257.62 | 4.04 | 3.86 MB | ✅ |
| Batch | Insert | 5,000 | 949 | 5268.70 | 3.98 | 196 KB | ✅ |
| Batch | Insert | 5,000 | 954 | 5241.09 | 3.89 | 252 KB | ✅ |
| Batch | Insert | 5,000 | 950 | 5263.16 | 3.97 | 0 B | ✅ |
| Batch | Insert | 5,000 | 948 | 5274.26 | 4.12 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.49 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.24 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.45 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 3.15 | 0 B | ✅ |
| Batch | Select | 5,000 | 20 | 250000.00 | 6.48 | 0 B | ✅ |
| Batch | Update | 5,000 | 510 | 9803.92 | 4.08 | 512 KB | ✅ |
| Batch | Update | 5,000 | 516 | 9689.92 | 4.16 | 0 B | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 3.80 | 0 B | ✅ |
| Batch | Update | 5,000 | 513 | 9746.59 | 3.93 | 216 KB | ✅ |
| Batch | Update | 5,000 | 511 | 9784.74 | 4.07 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 53,208 | 1.88 | 4.16 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 102 | 980.39 | 4.45 | 4 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 145 | 689.66 | 4.46 | 8 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 6,242 | 1.60 | 4.17 | 16 KB | ✅ |
| IndexQuery | OrderBy | 100 | 50,744 | 1.97 | 4.16 | 136 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 183 | 546.45 | 4.25 | 3.8 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 51,998 | 1.92 | 4.16 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 23 | 4347.83 | 5.49 | 144 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 155 | 645.16 | 4.61 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 186 | 537.63 | 4.18 | 3.63 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 186 | 537.63 | 4.54 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 73 | 1369.86 | 4.44 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 72 | 1388.89 | 3.57 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 812 | 9.85 | 4.16 | 840 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 93,503 | 10694.84 | 3.48 | 5.24 MB | ✅ |
| MillionData | GroupBy | 32 | 11,895 | 0.34 | 4.17 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 332,344 | 3008.93 | 3.97 | 20.23 MB | ✅ |
| Single | Delete | 1,000 | 3,338 | 299.58 | 3.10 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,288 | 304.14 | 3.19 | 36 KB | ✅ |
| Single | Delete | 1,000 | 3,167 | 315.76 | 3.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,306 | 302.48 | 2.84 | 28 KB | ✅ |
| Single | Delete | 1,000 | 3,314 | 301.75 | 3.48 | 4 KB | ✅ |
| Single | Insert | 1,000 | 3,379 | 295.95 | 2.83 | 11.42 MB | ✅ |
| Single | Insert | 1,000 | 3,354 | 298.15 | 3.42 | 64 KB | ✅ |
| Single | Insert | 1,000 | 3,387 | 295.25 | 3.79 | 4 KB | ✅ |
| Single | Insert | 1,000 | 3,325 | 300.75 | 3.39 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,261 | 306.65 | 3.47 | 76 KB | ✅ |
| Single | Select | 1,000 | 236 | 4237.29 | 4.40 | 3.08 MB | ✅ |
| Single | Select | 1,000 | 232 | 4310.34 | 4.21 | 68 KB | ✅ |
| Single | Select | 1,000 | 233 | 4291.85 | 4.19 | 4 KB | ✅ |
| Single | Select | 1,000 | 234 | 4273.50 | 4.45 | 4 KB | ✅ |
| Single | Select | 1,000 | 233 | 4291.85 | 4.18 | 4 KB | ✅ |
| Single | Update | 1,000 | 3,361 | 297.53 | 3.18 | 84 KB | ✅ |
| Single | Update | 1,000 | 3,385 | 295.42 | 3.94 | 0 B | ✅ |
| Single | Update | 1,000 | 3,463 | 288.77 | 3.14 | 0 B | ✅ |
| Single | Update | 1,000 | 3,340 | 299.40 | 3.20 | 0 B | ✅ |
| Single | Update | 1,000 | 3,310 | 302.11 | 3.52 | 72 KB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 36 | 27.78 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 4.20 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 34 | 29.41 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 15 | 400.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.96 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 285 | 17543.86 | 0.46 | 1000 KB | ✅ |
| Batch | Delete | 5,000 | 245 | 20408.16 | 0.00 | 136 KB | ✅ |
| Batch | Delete | 5,000 | 231 | 21645.02 | 0.56 | 0 B | ✅ |
| Batch | Delete | 5,000 | 227 | 22026.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 235 | 21276.60 | 0.00 | 2.25 MB | ✅ |
| Batch | Insert | 5,000 | 5,280 | 946.97 | 0.17 | 3.46 MB | ✅ |
| Batch | Insert | 5,000 | 5,163 | 968.43 | 0.11 | 3.09 MB | ✅ |
| Batch | Insert | 5,000 | 4,891 | 1022.29 | 0.11 | 2.82 MB | ✅ |
| Batch | Insert | 5,000 | 4,849 | 1031.14 | 0.19 | 3.8 MB | ✅ |
| Batch | Insert | 5,000 | 4,837 | 1033.70 | 0.09 | 4.05 MB | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 9.90 | 12 KB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 2.14 | 0 B | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 3.41 | 12 KB | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 7.43 | 0 B | ✅ |
| Batch | Select | 5,000 | 19 | 263157.89 | 10.26 | 180 KB | ✅ |
| Batch | Update | 5,000 | 2,875 | 1739.13 | 0.20 | 992 KB | ✅ |
| Batch | Update | 5,000 | 2,795 | 1788.91 | 0.26 | 3.85 MB | ✅ |
| Batch | Update | 5,000 | 2,629 | 1901.86 | 0.20 | 996 KB | ✅ |
| Batch | Update | 5,000 | 2,526 | 1979.41 | 0.21 | 0 B | ✅ |
| Batch | Update | 5,000 | 2,617 | 1910.58 | 0.25 | 3.89 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,626 | 61.50 | 0.20 | 180 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 240 | 416.67 | 0.00 | 28 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 236 | 423.73 | 1.38 | 48 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,554 | 3.92 | 0.03 | 364 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,161 | 24.03 | 0.02 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 254 | 393.70 | 0.00 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,585 | 6.42 | 0.03 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 175 | 571.43 | 0.37 | 148 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 249 | 401.61 | 0.78 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 195 | 512.82 | 1.66 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 217 | 460.83 | 1.50 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 125 | 800.00 | 2.60 | 20 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 489 | 204.50 | 0.00 | 3.74 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 456 | 17.54 | 0.00 | 792 KB | ✅ |
| MillionData | Cleanup | 1,000,000 | 23,005 | 43468.81 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 119 | 33.61 | 1.09 | 60 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 28,329 | 35299.52 | 1.07 | 43.84 MB | ✅ |
| Single | Delete | 1,000 | 1,638 | 610.50 | 0.36 | 660 KB | ✅ |
| Single | Delete | 1,000 | 1,676 | 596.66 | 0.31 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,594 | 627.35 | 0.57 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,560 | 641.03 | 0.38 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,516 | 397.46 | 0.39 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,798 | 556.17 | 0.94 | 2.68 MB | ✅ |
| Single | Insert | 1,000 | 2,174 | 459.98 | 0.54 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,539 | 649.77 | 0.68 | 2.64 MB | ✅ |
| Single | Insert | 1,000 | 1,653 | 604.96 | 0.59 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,544 | 647.67 | 0.42 | 0 B | ✅ |
| Single | Select | 1,000 | 1,235 | 809.72 | 0.84 | 100 KB | ✅ |
| Single | Select | 1,000 | 1,264 | 791.14 | 0.46 | 44 KB | ✅ |
| Single | Select | 1,000 | 1,238 | 807.75 | 0.53 | 48 KB | ✅ |
| Single | Select | 1,000 | 1,033 | 968.05 | 1.26 | 0 B | ✅ |
| Single | Select | 1,000 | 1,226 | 815.66 | 0.80 | 0 B | ✅ |
| Single | Update | 1,000 | 4,315 | 231.75 | 0.27 | 0 B | ✅ |
| Single | Update | 1,000 | 4,402 | 227.17 | 0.30 | 0 B | ✅ |
| Single | Update | 1,000 | 4,111 | 243.25 | 0.25 | 604 KB | ✅ |
| Single | Update | 1,000 | 3,573 | 279.88 | 0.27 | 0 B | ✅ |
| Single | Update | 1,000 | 7,176 | 139.35 | 0.08 | 72 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 5.98 | 3.35 | 3.49 | 5.34 | 5.32 | 0.84 |
| Aggregation | Statistics | 10.20 | 6.52 | 4.64 | 10.82 | 19.71 | 1.79 |
| Batch | Delete | 1.61 | 2.31 | 0.60 | 1.87 | 3.39 | 0.20 |
| Batch | Insert | 3.78 | 2.65 | 3.18 | 2.04 | 4.00 | 0.13 |
| Batch | Select | 4.21 | 3.78 | 4.23 | 6.69 | 5.16 | 6.63 |
| Batch | Update | 2.94 | 1.94 | 2.60 | 2.20 | 4.01 | 0.22 |
| IndexQuery | ComplexCondition | 0.03 | 0.11 | 0.20 | 0.78 | 4.16 | 0.20 |
| IndexQuery | CompositeIndex_RegionDept | 2.32 | 1.96 | 0.66 | 3.79 | 4.45 | 0.00 |
| IndexQuery | CompositeIndex_StatusCatPri | 2.16 | 0.65 | 1.75 | 2.01 | 4.46 | 1.38 |
| IndexQuery | NoIndex_FullScan | 0.01 | 0.02 | 0.03 | 0.10 | 4.17 | 0.03 |
| IndexQuery | OrderBy | 0.02 | 0.01 | 0.01 | 0.07 | 4.16 | 0.02 |
| IndexQuery | Pagination | 1.86 | 0.65 | 1.67 | 2.66 | 4.25 | 0.00 |
| IndexQuery | PrefixQuery_Name | 0.01 | 3.25 | 0.01 | 0.00 | 4.16 | 0.03 |
| IndexQuery | PrimaryKey | 1.86 | 2.25 | 2.87 | 5.09 | 5.49 | 0.37 |
| IndexQuery | RangeQuery_Date | 2.19 | 1.37 | 1.41 | 1.90 | 4.61 | 0.78 |
| IndexQuery | RangeQuery_Salary | 2.97 | 1.20 | 0.80 | 5.09 | 4.18 | 1.66 |
| IndexQuery | RangeQuery_Score | 3.59 | 1.04 | 1.94 | 4.16 | 4.54 | 1.50 |
| IndexQuery | SingleIndex_Category | 4.04 | 2.33 | 1.49 | 3.69 | 4.44 | 2.60 |
| IndexQuery | SingleIndex_Status | 2.01 | 2.88 | 3.85 | 3.26 | 3.57 | 0.00 |
| MillionData | Aggregation | 0.00 | 0.00 | 0.27 | 0.28 | 4.16 | 0.00 |
| MillionData | Cleanup | 0.00 | 0.00 | 0.01 | 0.01 | 3.48 | 0.00 |
| MillionData | GroupBy | 0.00 | 0.00 | 0.00 | 0.28 | 4.17 | 1.09 |
| MillionData | PrepareData | 2.44 | 1.60 | 2.35 | 2.33 | 3.97 | 1.07 |
| Single | Delete | 1.42 | 2.63 | 0.58 | 1.19 | 3.21 | 0.40 |
| Single | Insert | 1.31 | 2.39 | 0.87 | 1.28 | 3.38 | 0.63 |
| Single | Select | 1.86 | 2.79 | 2.15 | 2.82 | 4.29 | 0.78 |
| Single | Update | 1.59 | 2.52 | 0.71 | 1.35 | 3.40 | 0.23 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 72 KB | 8 KB | 160 KB | 32 KB | 248 KB | 8 KB |
| Aggregation | Statistics | 1.68 MB | 688 KB | 868 KB | 16 KB | 316 KB | 0 B |
| Batch | Delete | 588 KB | 2.79 MB | 1.3 MB | 36 KB | 188 KB | 2.25 MB |
| Batch | Insert | 10.63 MB | 376 KB | 12.2 MB | 11.03 MB | 3.86 MB | 4.05 MB |
| Batch | Select | 2.45 MB | 524 KB | 2.47 MB | 4 KB | 0 B | 180 KB |
| Batch | Update | 7.99 MB | 5.7 MB | 6.7 MB | 0 B | 512 KB | 3.89 MB |
| IndexQuery | ComplexCondition | 0 B | 6.3 MB | 6.5 MB | 0 B | 0 B | 180 KB |
| IndexQuery | CompositeIndex_RegionDept | 148 KB | 192 KB | 436 KB | 40 KB | 4 KB | 28 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 520 KB | 124 KB | 172 KB | 56 KB | 8 KB | 48 KB |
| IndexQuery | NoIndex_FullScan | 92 KB | 20 KB | 3.48 MB | 52 KB | 16 KB | 364 KB |
| IndexQuery | OrderBy | 0 B | 0 B | 4.79 MB | 0 B | 136 KB | 0 B |
| IndexQuery | Pagination | 1.63 MB | 0 B | 156 KB | 4 KB | 3.8 MB | 0 B |
| IndexQuery | PrefixQuery_Name | 0 B | 36 KB | 1 MB | 0 B | 0 B | 0 B |
| IndexQuery | PrimaryKey | 8.47 MB | 400 KB | 7.38 MB | 44 KB | 144 KB | 148 KB |
| IndexQuery | RangeQuery_Date | 100 KB | 52 KB | 1.44 MB | 4 KB | 0 B | 0 B |
| IndexQuery | RangeQuery_Salary | 824 KB | 12 KB | 232 KB | 0 B | 3.63 MB | 0 B |
| IndexQuery | RangeQuery_Score | 3.62 MB | 240 KB | 1.46 MB | 0 B | 0 B | 8 KB |
| IndexQuery | SingleIndex_Category | 48 KB | 3.81 MB | 3.52 MB | 80 KB | 0 B | 20 KB |
| IndexQuery | SingleIndex_Status | 136 KB | 2.31 MB | 456 KB | 3.85 MB | 0 B | 3.74 MB |
| MillionData | Aggregation | 0 B | 328 KB | 484 KB | 460 KB | 840 KB | 792 KB |
| MillionData | Cleanup | 0 B | 0 B | 1.86 MB | 0 B | 5.24 MB | 0 B |
| MillionData | GroupBy | 12 KB | 100 KB | 0 B | 112 KB | 0 B | 60 KB |
| MillionData | PrepareData | 19.79 MB | 44.65 MB | 0 B | 31.02 MB | 20.23 MB | 43.84 MB |
| Single | Delete | 4 MB | 15.61 MB | 4.81 MB | 152 KB | 36 KB | 660 KB |
| Single | Insert | 7.94 MB | 10.16 MB | 7.35 MB | 15.63 MB | 11.42 MB | 2.68 MB |
| Single | Select | 3.47 MB | 5.32 MB | 8 MB | 7.99 MB | 3.08 MB | 100 KB |
| Single | Update | 3.29 MB | 12.27 MB | 5.19 MB | 604 KB | 84 KB | 604 KB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 11:13:17*
