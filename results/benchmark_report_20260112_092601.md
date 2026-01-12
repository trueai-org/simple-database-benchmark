# 数据库基准测试报告

**测试时间**: 2026-01-12 09:26:01

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
| 采集时间 | 2026-01-12 09:26:01 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, MariaDB, SQLServer, PostgreSQL |
| 数据库数量 | 4 |
| 总测试用例数 | 268 |
| 成功用例数 | 268 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MySQL | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.40 | 5.60 | 1.20 | 29.20 | **PostgreSQL** |
| Aggregation | Statistics | 8.80 | 13.60 | 5.60 | 8.20 | **PostgreSQL** |
| Batch | Delete | 63.40 | 110.00 | 18.00 | 210.40 | **PostgreSQL** |
| Batch | Insert | 365.40 | 406.40 | 489.40 | 4833.60 | **MariaDB** |
| Batch | Select | 25.80 | 28.20 | 75.40 | 15.80 | **SQLServer** |
| Batch | Update | 253.00 | 324.60 | 369.20 | 2587.40 | **MariaDB** |
| IndexQuery | ComplexCondition | 9773.00 | 1576.00 | 7705.00 | 1393.00 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 166.00 | 202.00 | 61.00 | 180.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 173.00 | 194.00 | 64.00 | 197.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 5958.00 | 5964.00 | 522.00 | 2509.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10451.00 | 47803.00 | 9271.00 | 4056.00 | **SQLServer** |
| IndexQuery | Pagination | 300.00 | 339.00 | 74.00 | 230.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 43227.00 | 61143.00 | 9938.00 | 15387.00 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 104.00 | 112.00 | 48.00 | 120.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 171.00 | 191.00 | 64.00 | 193.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 172.00 | 200.00 | 96.00 | 189.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 175.00 | 191.00 | 113.00 | 185.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 165.00 | 190.00 | 733.00 | 112.00 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 168.00 | 183.00 | 1051.00 | 425.00 | **MariaDB** |
| MillionData | Aggregation | 455.00 | 483.00 | 201.00 | 444.00 | **PostgreSQL** |
| MillionData | GroupBy | 1802.00 | 2590.00 | 184.00 | 116.00 | **SQLServer** |
| MillionData | PrepareData | 98749.00 | 98087.00 | 21006.00 | 27040.00 | **PostgreSQL** |
| MillionData | Cleanup | 18964.00 | 22492.00 | 4987.00 | 22724.00 | **PostgreSQL** |
| Single | Delete | 1532.00 | 3060.80 | 831.60 | 1537.80 | **PostgreSQL** |
| Single | Insert | 1718.40 | 3226.40 | 962.40 | 1491.40 | **PostgreSQL** |
| Single | Select | 1003.00 | 1062.40 | 393.40 | 1055.40 | **PostgreSQL** |
| Single | Update | 2316.40 | 3344.20 | 966.40 | 3575.00 | **PostgreSQL** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MySQL | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 300.00 | 216.67 | 900.00 | 34.36 | **PostgreSQL** |
| Aggregation | Statistics | 683.34 | 552.42 | 1249.09 | 785.16 | **PostgreSQL** |
| Batch | Delete | 78877.05 | 45714.99 | 278758.17 | 23766.52 | **PostgreSQL** |
| Batch | Insert | 13699.74 | 12324.54 | 10492.07 | 1034.55 | **MariaDB** |
| Batch | Select | 194074.08 | 177797.43 | 446058.77 | 318055.55 | **PostgreSQL** |
| Batch | Update | 19766.89 | 15685.80 | 13640.67 | 1934.97 | **MariaDB** |
| Cleanup | MillionData_Cleanup | 52731.49 | 44460.25 | 200521.36 | 44006.34 | **PostgreSQL** |
| IndexQuery | ComplexCondition | 10.23 | 63.45 | 12.98 | 71.79 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 602.41 | 495.05 | 1639.34 | 555.56 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 578.03 | 515.46 | 1562.50 | 507.61 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 1.68 | 1.68 | 19.16 | 3.99 | **PostgreSQL** |
| IndexQuery | OrderBy | 9.57 | 2.09 | 10.79 | 24.65 | **SQLServer** |
| IndexQuery | Pagination | 333.33 | 294.99 | 1351.35 | 434.78 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 2.31 | 1.64 | 10.06 | 6.50 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 961.54 | 892.86 | 2083.33 | 833.33 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 584.80 | 523.56 | 1562.50 | 518.13 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 581.40 | 500.00 | 1041.67 | 529.10 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 571.43 | 523.56 | 884.96 | 540.54 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 606.06 | 526.32 | 136.43 | 892.86 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 595.24 | 546.45 | 95.15 | 235.29 | **MariaDB** |
| MillionData | Aggregation | 17.58 | 16.56 | 39.80 | 18.02 | **PostgreSQL** |
| MillionData | GroupBy | 2.22 | 1.54 | 21.74 | 34.48 | **SQLServer** |
| MillionData | PrepareData | 10126.68 | 10195.03 | 47605.45 | 36982.25 | **PostgreSQL** |
| Single | Delete | 652.79 | 326.73 | 1202.80 | 650.53 | **PostgreSQL** |
| Single | Insert | 582.13 | 310.19 | 1039.51 | 671.07 | **PostgreSQL** |
| Single | Select | 997.49 | 942.19 | 2543.03 | 947.99 | **PostgreSQL** |
| Single | Update | 477.99 | 299.19 | 1035.02 | 279.77 | **PostgreSQL** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 16.27 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 32 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.89 | 32 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 1.73 MB | ✅ |
| Batch | Delete | 5,000 | 64 | 78125.00 | 0.00 | 720 KB | ✅ |
| Batch | Delete | 5,000 | 64 | 78125.00 | 1.01 | 916 KB | ✅ |
| Batch | Delete | 5,000 | 62 | 80645.16 | 1.03 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 1.02 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 64 | 78125.00 | 0.00 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 391 | 12787.72 | 2.66 | 11.23 MB | ✅ |
| Batch | Insert | 5,000 | 357 | 14005.60 | 2.18 | 11.32 MB | ✅ |
| Batch | Insert | 5,000 | 360 | 13888.89 | 3.25 | 10.82 MB | ✅ |
| Batch | Insert | 5,000 | 359 | 13927.58 | 3.44 | 10.84 MB | ✅ |
| Batch | Insert | 5,000 | 360 | 13888.89 | 3.07 | 10.79 MB | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 2.52 | 2.46 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 7.12 | 2.48 MB | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 5.02 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 0.00 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 2.37 | 2.45 MB | ✅ |
| Batch | Update | 5,000 | 259 | 19305.02 | 2.01 | 7.96 MB | ✅ |
| Batch | Update | 5,000 | 250 | 20000.00 | 3.12 | 7.16 MB | ✅ |
| Batch | Update | 5,000 | 249 | 20080.32 | 2.35 | 6.3 MB | ✅ |
| Batch | Update | 5,000 | 255 | 19607.84 | 1.53 | 6.31 MB | ✅ |
| Batch | Update | 5,000 | 252 | 19841.27 | 2.32 | 6.29 MB | ✅ |
| Cleanup | MillionData_Cleanup | 1,000,000 | 18,964 | 52731.49 | 0.01 | 104 KB | ✅ |
| IndexQuery | ComplexCondition | 100 | 9,773 | 10.23 | 0.06 | 3.15 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 166 | 602.41 | 1.56 | 252 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 173 | 578.03 | 2.25 | 1.18 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,958 | 1.68 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 10,451 | 9.57 | 0.06 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 300 | 333.33 | 0.87 | 4.36 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 43,227 | 2.31 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 104 | 961.54 | 3.11 | 3.12 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 171 | 584.80 | 2.66 | 52 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 172 | 581.40 | 1.13 | 56 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 175 | 571.43 | 4.08 | 740 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 165 | 606.06 | 2.36 | 112 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 168 | 595.24 | 1.93 | 4.75 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 455 | 17.58 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 32 | 1,802 | 2.22 | 0.00 | 32 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 98,749 | 10126.68 | 2.62 | 26.34 MB | ✅ |
| Single | Delete | 1,000 | 1,545 | 647.25 | 0.97 | 2.99 MB | ✅ |
| Single | Delete | 1,000 | 1,543 | 648.09 | 1.05 | 4.03 MB | ✅ |
| Single | Delete | 1,000 | 1,540 | 649.35 | 1.14 | 2.8 MB | ✅ |
| Single | Delete | 1,000 | 1,511 | 661.81 | 0.78 | 3 MB | ✅ |
| Single | Delete | 1,000 | 1,521 | 657.46 | 0.86 | 3.25 MB | ✅ |
| Single | Insert | 1,000 | 1,677 | 596.30 | 1.01 | 4.47 MB | ✅ |
| Single | Insert | 1,000 | 1,747 | 572.41 | 1.60 | 3.3 MB | ✅ |
| Single | Insert | 1,000 | 1,762 | 567.54 | 0.85 | 3.24 MB | ✅ |
| Single | Insert | 1,000 | 1,703 | 587.20 | 1.38 | 4.47 MB | ✅ |
| Single | Insert | 1,000 | 1,703 | 587.20 | 1.38 | 4.49 MB | ✅ |
| Single | Select | 1,000 | 989 | 1011.12 | 2.37 | 0 B | ✅ |
| Single | Select | 1,000 | 985 | 1015.23 | 2.05 | 0 B | ✅ |
| Single | Select | 1,000 | 1,042 | 959.69 | 2.00 | 1020 KB | ✅ |
| Single | Select | 1,000 | 985 | 1015.23 | 2.11 | 0 B | ✅ |
| Single | Select | 1,000 | 1,014 | 986.19 | 2.18 | 0 B | ✅ |
| Single | Update | 1,000 | 1,879 | 532.20 | 1.04 | 2.77 MB | ✅ |
| Single | Update | 1,000 | 4,131 | 242.07 | 0.27 | 1.53 MB | ✅ |
| Single | Update | 1,000 | 1,892 | 528.54 | 0.52 | 396 KB | ✅ |
| Single | Update | 1,000 | 1,816 | 550.66 | 0.68 | 3.41 MB | ✅ |
| Single | Update | 1,000 | 1,864 | 536.48 | 1.08 | 3.42 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.42 | 208 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 52 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.91 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 15.88 | 128 KB | ✅ |
| Aggregation | Statistics | 5,000 | 30 | 200.00 | 4.23 | 824 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 5,000 | 122 | 40983.61 | 1.07 | 820 KB | ✅ |
| Batch | Delete | 5,000 | 103 | 48543.69 | 0.00 | 852 KB | ✅ |
| Batch | Delete | 5,000 | 106 | 47169.81 | 0.00 | 912 KB | ✅ |
| Batch | Delete | 5,000 | 101 | 49504.95 | 1.28 | 96 KB | ✅ |
| Batch | Delete | 5,000 | 118 | 42372.88 | 0.55 | 896 KB | ✅ |
| Batch | Insert | 5,000 | 441 | 11337.87 | 3.10 | 9.1 MB | ✅ |
| Batch | Insert | 5,000 | 400 | 12500.00 | 2.92 | 12.36 MB | ✅ |
| Batch | Insert | 5,000 | 400 | 12500.00 | 3.42 | 10.79 MB | ✅ |
| Batch | Insert | 5,000 | 397 | 12594.46 | 3.11 | 10.78 MB | ✅ |
| Batch | Insert | 5,000 | 394 | 12690.36 | 2.80 | 10.64 MB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 2.20 | 3.38 MB | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 4.46 | 2.45 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 7.12 | 3.48 MB | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 2.12 | 2.49 MB | ✅ |
| Batch | Select | 5,000 | 26 | 192307.69 | 4.83 | 2.45 MB | ✅ |
| Batch | Update | 5,000 | 415 | 12048.19 | 2.66 | 6.89 MB | ✅ |
| Batch | Update | 5,000 | 294 | 17006.80 | 0.88 | 6.41 MB | ✅ |
| Batch | Update | 5,000 | 292 | 17123.29 | 1.78 | 6.42 MB | ✅ |
| Batch | Update | 5,000 | 328 | 15243.90 | 2.38 | 6.4 MB | ✅ |
| Batch | Update | 5,000 | 294 | 17006.80 | 2.21 | 6.25 MB | ✅ |
| Cleanup | MillionData_Cleanup | 1,000,000 | 22,492 | 44460.25 | 0.01 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,576 | 63.45 | 0.29 | 9.3 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 202 | 495.05 | 1.61 | 196 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 194 | 515.46 | 2.68 | 0 B | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 5,964 | 1.68 | 0.02 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 47,803 | 2.09 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 339 | 294.99 | 0.57 | 3.17 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 61,143 | 1.64 | 0.00 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 112 | 892.86 | 1.15 | 92 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 191 | 523.56 | 3.41 | 12 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 200 | 500.00 | 2.60 | 132 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 191 | 523.56 | 0.68 | 284 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 190 | 526.32 | 2.39 | 152 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 183 | 546.45 | 1.42 | 3.41 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 483 | 16.56 | 0.40 | 192 KB | ✅ |
| MillionData | GroupBy | 32 | 2,590 | 1.54 | 0.05 | 92 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 98,087 | 10195.03 | 2.41 | 25.78 MB | ✅ |
| Single | Delete | 1,000 | 3,085 | 324.15 | 0.53 | 5.18 MB | ✅ |
| Single | Delete | 1,000 | 3,087 | 323.94 | 0.51 | 3.02 MB | ✅ |
| Single | Delete | 1,000 | 3,067 | 326.05 | 0.64 | 3 MB | ✅ |
| Single | Delete | 1,000 | 3,028 | 330.25 | 0.67 | 3 MB | ✅ |
| Single | Delete | 1,000 | 3,037 | 329.27 | 0.47 | 2.69 MB | ✅ |
| Single | Insert | 1,000 | 3,391 | 294.90 | 1.31 | 7.17 MB | ✅ |
| Single | Insert | 1,000 | 3,242 | 308.45 | 0.66 | 4.98 MB | ✅ |
| Single | Insert | 1,000 | 3,149 | 317.56 | 0.89 | 9.1 MB | ✅ |
| Single | Insert | 1,000 | 3,215 | 311.04 | 0.55 | 4.47 MB | ✅ |
| Single | Insert | 1,000 | 3,135 | 318.98 | 0.66 | 6.62 MB | ✅ |
| Single | Select | 1,000 | 1,076 | 929.37 | 2.18 | 1.64 MB | ✅ |
| Single | Select | 1,000 | 1,053 | 949.67 | 2.10 | 0 B | ✅ |
| Single | Select | 1,000 | 1,061 | 942.51 | 1.90 | 0 B | ✅ |
| Single | Select | 1,000 | 1,010 | 990.10 | 1.67 | 0 B | ✅ |
| Single | Select | 1,000 | 1,112 | 899.28 | 1.87 | 0 B | ✅ |
| Single | Update | 1,000 | 3,489 | 286.62 | 0.45 | 412 KB | ✅ |
| Single | Update | 1,000 | 3,360 | 297.62 | 0.64 | 2.77 MB | ✅ |
| Single | Update | 1,000 | 3,268 | 306.00 | 0.68 | 2.45 MB | ✅ |
| Single | Update | 1,000 | 3,297 | 303.31 | 0.43 | 2.69 MB | ✅ |
| Single | Update | 1,000 | 3,307 | 302.39 | 0.63 | 2.31 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 36.05 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 112 KB | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 5.58 | 12 KB | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 11.54 | 0 B | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 3.74 | 24 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 17 | 294117.65 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 20 | 250000.00 | 0.00 | 12 KB | ✅ |
| Batch | Insert | 5,000 | 642 | 7788.16 | 1.01 | 13.95 MB | ✅ |
| Batch | Insert | 5,000 | 391 | 12787.72 | 2.16 | 13.33 MB | ✅ |
| Batch | Insert | 5,000 | 462 | 10822.51 | 1.55 | 10.42 MB | ✅ |
| Batch | Insert | 5,000 | 452 | 11061.95 | 2.73 | 13.41 MB | ✅ |
| Batch | Insert | 5,000 | 500 | 10000.00 | 1.69 | 10.45 MB | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.93 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.40 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 324 | 15432.10 | 0.20 | 0 B | ✅ |
| Batch | Select | 5,000 | 31 | 161290.32 | 2.06 | 0 B | ✅ |
| Batch | Update | 5,000 | 385 | 12987.01 | 1.18 | 3.92 MB | ✅ |
| Batch | Update | 5,000 | 345 | 14492.75 | 1.69 | 4.19 MB | ✅ |
| Batch | Update | 5,000 | 347 | 14409.22 | 1.12 | 156 KB | ✅ |
| Batch | Update | 5,000 | 343 | 14577.26 | 1.52 | 4 MB | ✅ |
| Batch | Update | 5,000 | 426 | 11737.09 | 1.37 | 4 MB | ✅ |
| Cleanup | MillionData_Cleanup | 1,000,000 | 4,987 | 200521.36 | 0.05 | 1.36 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 7,705 | 12.98 | 0.03 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 61 | 1639.34 | 5.31 | 0 B | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 64 | 1562.50 | 2.03 | 192 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 522 | 19.16 | 0.00 | 88 KB | ✅ |
| IndexQuery | OrderBy | 100 | 9,271 | 10.79 | 0.06 | 48 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 74 | 1351.35 | 0.00 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 9,938 | 10.06 | 0.00 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 48 | 2083.33 | 4.02 | 84 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 64 | 1562.50 | 6.05 | 0 B | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 96 | 1041.67 | 3.39 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 113 | 884.96 | 2.30 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 733 | 136.43 | 0.27 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 1,051 | 95.15 | 0.37 | 0 B | ✅ |
| MillionData | Aggregation | 1,000,000 | 201 | 39.80 | 0.00 | 700 KB | ✅ |
| MillionData | GroupBy | 32 | 184 | 21.74 | 0.35 | 0 B | ✅ |
| MillionData | PrepareData | 1,000,000 | 21,006 | 47605.45 | 2.27 | 41.11 MB | ✅ |
| Single | Delete | 1,000 | 809 | 1236.09 | 0.96 | 0 B | ✅ |
| Single | Delete | 1,000 | 829 | 1206.27 | 0.86 | 0 B | ✅ |
| Single | Delete | 1,000 | 849 | 1177.86 | 1.07 | 0 B | ✅ |
| Single | Delete | 1,000 | 835 | 1197.60 | 1.32 | 0 B | ✅ |
| Single | Delete | 1,000 | 836 | 1196.17 | 0.93 | 0 B | ✅ |
| Single | Insert | 1,000 | 927 | 1078.75 | 1.26 | 7.05 MB | ✅ |
| Single | Insert | 1,000 | 972 | 1028.81 | 1.61 | 7.49 MB | ✅ |
| Single | Insert | 1,000 | 957 | 1044.93 | 0.41 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 972 | 1028.81 | 0.80 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 984 | 1016.26 | 1.52 | 6.79 MB | ✅ |
| Single | Select | 1,000 | 384 | 2604.17 | 3.38 | 8.05 MB | ✅ |
| Single | Select | 1,000 | 385 | 2597.40 | 3.38 | 8 MB | ✅ |
| Single | Select | 1,000 | 395 | 2531.65 | 2.47 | 8 MB | ✅ |
| Single | Select | 1,000 | 397 | 2518.89 | 1.97 | 8.01 MB | ✅ |
| Single | Select | 1,000 | 406 | 2463.05 | 1.92 | 7.99 MB | ✅ |
| Single | Update | 1,000 | 951 | 1051.52 | 1.03 | 0 B | ✅ |
| Single | Update | 1,000 | 978 | 1022.49 | 1.06 | 0 B | ✅ |
| Single | Update | 1,000 | 990 | 1010.10 | 1.18 | 0 B | ✅ |
| Single | Update | 1,000 | 953 | 1049.32 | 1.09 | 0 B | ✅ |
| Single | Update | 1,000 | 960 | 1041.67 | 1.63 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 32 | 31.25 | 2.03 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 30 | 33.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 27 | 37.04 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 13 | 461.54 | 0.00 | 188 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.21 | 0 B | ✅ |
| Batch | Delete | 5,000 | 214 | 23364.49 | 0.30 | 588 KB | ✅ |
| Batch | Delete | 5,000 | 210 | 23809.52 | 0.62 | 124 KB | ✅ |
| Batch | Delete | 5,000 | 208 | 24038.46 | 0.31 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 209 | 23923.44 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 211 | 23696.68 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 4,781 | 1045.81 | 0.08 | 7.74 MB | ✅ |
| Batch | Insert | 5,000 | 4,933 | 1013.58 | 0.05 | 7.24 MB | ✅ |
| Batch | Insert | 5,000 | 4,845 | 1031.99 | 0.08 | 5.2 MB | ✅ |
| Batch | Insert | 5,000 | 4,814 | 1038.64 | 0.11 | 7.42 MB | ✅ |
| Batch | Insert | 5,000 | 4,795 | 1042.75 | 0.12 | 6.27 MB | ✅ |
| Batch | Select | 5,000 | 18 | 277777.78 | 3.52 | 4 KB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 7.67 | 12 KB | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.47 | 0 B | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.20 | 0 B | ✅ |
| Batch | Select | 5,000 | 15 | 333333.33 | 8.17 | 212 KB | ✅ |
| Batch | Update | 5,000 | 2,503 | 1997.60 | 0.13 | 3.79 MB | ✅ |
| Batch | Update | 5,000 | 2,634 | 1898.25 | 0.12 | 4.18 MB | ✅ |
| Batch | Update | 5,000 | 2,641 | 1893.22 | 0.07 | 4.21 MB | ✅ |
| Batch | Update | 5,000 | 2,704 | 1849.11 | 0.17 | 2.07 MB | ✅ |
| Batch | Update | 5,000 | 2,455 | 2036.66 | 0.08 | 4 MB | ✅ |
| Cleanup | MillionData_Cleanup | 1,000,000 | 22,724 | 44006.34 | 0.00 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,393 | 71.79 | 0.09 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 180 | 555.56 | 2.16 | 2.16 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 197 | 507.61 | 1.65 | 2.66 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,509 | 3.99 | 0.00 | 444 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,056 | 24.65 | 0.10 | 1.56 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 230 | 434.78 | 0.85 | 1.1 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,387 | 6.50 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 120 | 833.33 | 1.08 | 24 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 193 | 518.13 | 0.00 | 2.24 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 189 | 529.10 | 1.03 | 2.15 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 185 | 540.54 | 0.35 | 2.13 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 112 | 892.86 | 2.31 | 1.57 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 425 | 235.29 | 0.46 | 5.27 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 444 | 18.02 | 0.00 | 16 KB | ✅ |
| MillionData | GroupBy | 32 | 116 | 34.48 | 0.56 | 1.97 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 27,040 | 36982.25 | 1.23 | 43.25 MB | ✅ |
| Single | Delete | 1,000 | 1,597 | 626.17 | 0.33 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,537 | 650.62 | 0.30 | 160 KB | ✅ |
| Single | Delete | 1,000 | 1,522 | 657.03 | 0.17 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,512 | 661.38 | 0.39 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,521 | 657.46 | 0.30 | 20 KB | ✅ |
| Single | Insert | 1,000 | 1,496 | 668.45 | 1.04 | 3.81 MB | ✅ |
| Single | Insert | 1,000 | 1,572 | 636.13 | 0.29 | 6.62 MB | ✅ |
| Single | Insert | 1,000 | 1,449 | 690.13 | 0.67 | 6.78 MB | ✅ |
| Single | Insert | 1,000 | 1,459 | 685.40 | 0.40 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 1,481 | 675.22 | 0.84 | 6.78 MB | ✅ |
| Single | Select | 1,000 | 1,098 | 910.75 | 0.53 | 3.76 MB | ✅ |
| Single | Select | 1,000 | 1,066 | 938.09 | 0.79 | 3.57 MB | ✅ |
| Single | Select | 1,000 | 1,035 | 966.18 | 0.69 | 3.56 MB | ✅ |
| Single | Select | 1,000 | 1,036 | 965.25 | 0.69 | 3.56 MB | ✅ |
| Single | Select | 1,000 | 1,042 | 959.69 | 0.75 | 3.7 MB | ✅ |
| Single | Update | 1,000 | 3,617 | 276.47 | 0.31 | 176 KB | ✅ |
| Single | Update | 1,000 | 3,562 | 280.74 | 0.24 | 1.63 MB | ✅ |
| Single | Update | 1,000 | 3,637 | 274.95 | 0.25 | 2.88 MB | ✅ |
| Single | Update | 1,000 | 3,502 | 285.55 | 0.26 | 2.97 MB | ✅ |
| Single | Update | 1,000 | 3,557 | 281.14 | 0.37 | 3.03 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MySQL | PostgreSQL | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 3.25 | 7.24 | 7.21 | 0.41 |
| Aggregation | Statistics | 1.38 | 0.85 | 3.42 | 1.64 |
| Batch | Delete | 0.61 | 0.58 | 0.75 | 0.25 |
| Batch | Insert | 2.92 | 3.07 | 1.83 | 0.09 |
| Batch | Select | 3.41 | 4.15 | 3.92 | 7.21 |
| Batch | Update | 2.27 | 1.98 | 1.38 | 0.11 |
| Cleanup | MillionData_Cleanup | 0.01 | 0.01 | 0.05 | 0.00 |
| IndexQuery | ComplexCondition | 0.06 | 0.29 | 0.03 | 0.09 |
| IndexQuery | CompositeIndex_RegionDept | 1.56 | 1.61 | 5.31 | 2.16 |
| IndexQuery | CompositeIndex_StatusCatPri | 2.25 | 2.68 | 2.03 | 1.65 |
| IndexQuery | NoIndex_FullScan | 0.00 | 0.02 | 0.00 | 0.00 |
| IndexQuery | OrderBy | 0.06 | 0.01 | 0.06 | 0.10 |
| IndexQuery | Pagination | 0.87 | 0.57 | 0.00 | 0.85 |
| IndexQuery | PrefixQuery_Name | 0.01 | 0.00 | 0.00 | 0.01 |
| IndexQuery | PrimaryKey | 3.11 | 1.15 | 4.02 | 1.08 |
| IndexQuery | RangeQuery_Date | 2.66 | 3.41 | 6.05 | 0.00 |
| IndexQuery | RangeQuery_Salary | 1.13 | 2.60 | 3.39 | 1.03 |
| IndexQuery | RangeQuery_Score | 4.08 | 0.68 | 2.30 | 0.35 |
| IndexQuery | SingleIndex_Category | 2.36 | 2.39 | 0.27 | 2.31 |
| IndexQuery | SingleIndex_Status | 1.93 | 1.42 | 0.37 | 0.46 |
| MillionData | Aggregation | 0.00 | 0.40 | 0.00 | 0.00 |
| MillionData | GroupBy | 0.00 | 0.05 | 0.35 | 0.56 |
| MillionData | PrepareData | 2.62 | 2.41 | 2.27 | 1.23 |
| Single | Delete | 0.96 | 0.56 | 1.03 | 0.30 |
| Single | Insert | 1.24 | 0.81 | 1.12 | 0.65 |
| Single | Select | 2.14 | 1.94 | 2.62 | 0.69 |
| Single | Update | 0.72 | 0.57 | 1.20 | 0.29 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MySQL | PostgreSQL | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 32 KB | 208 KB | 112 KB | 68 KB |
| Aggregation | Statistics | 1.73 MB | 824 KB | 12 KB | 188 KB |
| Batch | Delete | 916 KB | 912 KB | 24 KB | 588 KB |
| Batch | Insert | 11.32 MB | 12.36 MB | 13.95 MB | 7.74 MB |
| Batch | Select | 2.48 MB | 3.48 MB | 0 B | 212 KB |
| Batch | Update | 7.96 MB | 6.89 MB | 4.19 MB | 4.21 MB |
| Cleanup | MillionData_Cleanup | 104 KB | 0 B | 1.36 MB | 0 B |
| IndexQuery | ComplexCondition | 3.15 MB | 9.3 MB | 0 B | 0 B |
| IndexQuery | CompositeIndex_RegionDept | 252 KB | 196 KB | 0 B | 2.16 MB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.18 MB | 0 B | 192 KB | 2.66 MB |
| IndexQuery | NoIndex_FullScan | 0 B | 0 B | 88 KB | 444 KB |
| IndexQuery | OrderBy | 0 B | 0 B | 48 KB | 1.56 MB |
| IndexQuery | Pagination | 4.36 MB | 3.17 MB | 0 B | 1.1 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 0 B | 0 B | 0 B |
| IndexQuery | PrimaryKey | 3.12 MB | 92 KB | 84 KB | 24 KB |
| IndexQuery | RangeQuery_Date | 52 KB | 12 KB | 0 B | 2.24 MB |
| IndexQuery | RangeQuery_Salary | 56 KB | 132 KB | 0 B | 2.15 MB |
| IndexQuery | RangeQuery_Score | 740 KB | 284 KB | 0 B | 2.13 MB |
| IndexQuery | SingleIndex_Category | 112 KB | 152 KB | 0 B | 1.57 MB |
| IndexQuery | SingleIndex_Status | 4.75 MB | 3.41 MB | 0 B | 5.27 MB |
| MillionData | Aggregation | 0 B | 192 KB | 700 KB | 16 KB |
| MillionData | GroupBy | 32 KB | 92 KB | 0 B | 1.97 MB |
| MillionData | PrepareData | 26.34 MB | 25.78 MB | 41.11 MB | 43.25 MB |
| Single | Delete | 4.03 MB | 5.18 MB | 0 B | 160 KB |
| Single | Insert | 4.49 MB | 9.1 MB | 7.49 MB | 6.79 MB |
| Single | Select | 1020 KB | 1.64 MB | 8.05 MB | 3.76 MB |
| Single | Update | 3.42 MB | 2.77 MB | 0 B | 3.03 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 09:26:01*
