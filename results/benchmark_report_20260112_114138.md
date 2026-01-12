# 数据库基准测试报告

**测试时间**: 2026-01-12 11:41:38

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
| 采集时间 | 2026-01-12 11:41:38 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, MariaDB |
| 数据库数量 | 2 |
| 总测试用例数 | 134 |
| 成功用例数 | 130 |
| 失败用例数 | 4 |
| 成功率 | 97.01% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MySQL | 最快 |
|:---------|:---------|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.20 | 5.20 | **MariaDB** |
| Aggregation | Statistics | 8.80 | 12.80 | **MariaDB** |
| Batch | Delete | 60.80 | 116.60 | **MariaDB** |
| Batch | Insert | 363.20 | 416.80 | **MariaDB** |
| Batch | Select | 26.00 | 27.60 | **MariaDB** |
| Batch | Update | 270.20 | 309.40 | **MariaDB** |
| IndexQuery | ComplexCondition | 121.00 | 123.00 | **MariaDB** |
| IndexQuery | CompositeIndex_RegionDept | 105.00 | 106.00 | **MariaDB** |
| IndexQuery | CompositeIndex_StatusCatPri | 111.00 | 111.00 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 14.00 | 11.00 | **MySQL** |
| IndexQuery | OrderBy | 102.00 | 104.00 | **MariaDB** |
| IndexQuery | Pagination | 102.00 | 100.00 | **MySQL** |
| IndexQuery | PrefixQuery_Name | 102.00 | 105.00 | **MariaDB** |
| IndexQuery | RangeQuery_Date | 108.00 | 113.00 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 117.00 | 105.00 | **MySQL** |
| IndexQuery | RangeQuery_Score | 112.00 | 109.00 | **MySQL** |
| IndexQuery | SingleIndex_Category | 108.00 | 102.00 | **MySQL** |
| IndexQuery | SingleIndex_Status | 111.00 | 110.00 | **MySQL** |
| MillionData | Aggregation | 7.00 | 11.00 | **MariaDB** |
| MillionData | Cleanup | 1.00 | 1.00 | **MariaDB** |
| MillionData | GroupBy | 4.00 | 6.00 | **MariaDB** |
| Single | Delete | 1538.80 | 3063.00 | **MariaDB** |
| Single | Insert | 1618.00 | 3226.00 | **MariaDB** |
| Single | Select | 1043.80 | 1081.40 | **MariaDB** |
| Single | Update | 1644.20 | 3283.40 | **MariaDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MariaDB | MySQL | 最快 |
|:---------|:---------|-------:|-------:|:-------|
| Aggregation | GroupBy | 316.66 | 234.85 | **MariaDB** |
| Aggregation | Statistics | 697.19 | 642.26 | **MariaDB** |
| Batch | Delete | 82357.82 | 43086.72 | **MariaDB** |
| Batch | Insert | 13770.21 | 12002.51 | **MariaDB** |
| Batch | Select | 192944.30 | 181481.49 | **MariaDB** |
| Batch | Update | 18815.12 | 16167.19 | **MariaDB** |
| IndexQuery | ComplexCondition | 826.45 | 813.01 | **MariaDB** |
| IndexQuery | CompositeIndex_RegionDept | 952.38 | 943.40 | **MariaDB** |
| IndexQuery | CompositeIndex_StatusCatPri | 900.90 | 900.90 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 714.29 | 909.09 | **MySQL** |
| IndexQuery | OrderBy | 980.39 | 961.54 | **MariaDB** |
| IndexQuery | Pagination | 980.39 | 1000.00 | **MySQL** |
| IndexQuery | PrefixQuery_Name | 980.39 | 952.38 | **MariaDB** |
| IndexQuery | RangeQuery_Date | 925.93 | 884.96 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 854.70 | 952.38 | **MySQL** |
| IndexQuery | RangeQuery_Score | 892.86 | 917.43 | **MySQL** |
| IndexQuery | SingleIndex_Category | 925.93 | 980.39 | **MySQL** |
| IndexQuery | SingleIndex_Status | 900.90 | 909.09 | **MySQL** |
| MillionData | Aggregation | 1142.86 | 727.27 | **MariaDB** |
| MillionData | Cleanup | 0.00 | 0.00 | **MariaDB** |
| MillionData | GroupBy | 1000.00 | 666.67 | **MariaDB** |
| Single | Delete | 650.33 | 326.55 | **MariaDB** |
| Single | Insert | 618.61 | 310.10 | **MariaDB** |
| Single | Select | 958.63 | 925.72 | **MariaDB** |
| Single | Update | 608.69 | 304.69 | **MariaDB** |

## 各数据库详细结果

### MariaDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.32 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.32 | 40 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 44 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 11 | 545.45 | 5.83 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 56 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.54 | 1.77 MB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 2.06 | 612 KB | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 1.11 | 676 KB | ✅ |
| Batch | Delete | 5,000 | 62 | 80645.16 | 3.14 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 63 | 79365.08 | 2.07 | 12 KB | ✅ |
| Batch | Delete | 5,000 | 58 | 86206.90 | 1.11 | 16 KB | ✅ |
| Batch | Insert | 5,000 | 371 | 13477.09 | 3.51 | 5.52 MB | ✅ |
| Batch | Insert | 5,000 | 360 | 13888.89 | 3.07 | 6.42 MB | ✅ |
| Batch | Insert | 5,000 | 369 | 13550.14 | 2.82 | 5.09 MB | ✅ |
| Batch | Insert | 5,000 | 355 | 14084.51 | 3.11 | 5.02 MB | ✅ |
| Batch | Insert | 5,000 | 361 | 13850.42 | 3.43 | 5.09 MB | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 5.19 | 0 B | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 2.55 | 0 B | ✅ |
| Batch | Select | 5,000 | 26 | 192307.69 | 4.90 | 0 B | ✅ |
| Batch | Select | 5,000 | 25 | 200000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 29 | 172413.79 | 4.36 | 0 B | ✅ |
| Batch | Update | 5,000 | 254 | 19685.04 | 4.09 | 7.7 MB | ✅ |
| Batch | Update | 5,000 | 244 | 20491.80 | 2.66 | 4.99 MB | ✅ |
| Batch | Update | 5,000 | 346 | 14450.87 | 1.32 | 5 MB | ✅ |
| Batch | Update | 5,000 | 253 | 19762.85 | 2.31 | 5.04 MB | ✅ |
| Batch | Update | 5,000 | 254 | 19685.04 | 2.81 | 4.89 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 121 | 826.45 | 2.68 | 4.35 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 105 | 952.38 | 3.09 | 1.29 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 111 | 900.90 | 1.17 | 1.17 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 14 | 714.29 | 13.81 | 100 KB | ✅ |
| IndexQuery | OrderBy | 100 | 102 | 980.39 | 1.90 | 40 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 102 | 980.39 | 2.55 | 44 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 102 | 980.39 | 3.17 | 2.04 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 0 | N/A | N/A | N/A | ❌ |
| IndexQuery | RangeQuery_Date | 100 | 108 | 925.93 | 1.80 | 132 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 117 | 854.70 | 2.78 | 388 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 112 | 892.86 | 1.74 | 3.25 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 108 | 925.93 | 5.39 | 4.39 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 111 | 900.90 | 2.34 | 0 B | ✅ |
| MillionData | Aggregation | 0 | 7 | 1142.86 | 8.37 | 0 B | ✅ |
| MillionData | Cleanup | 0 | 1 | 0.00 | 0.00 | 0 B | ✅ |
| MillionData | GroupBy | 0 | 4 | 1000.00 | 0.00 | 112 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Delete | 1,000 | 1,544 | 647.67 | 0.80 | 2.23 MB | ✅ |
| Single | Delete | 1,000 | 1,547 | 646.41 | 1.18 | 2.13 MB | ✅ |
| Single | Delete | 1,000 | 1,585 | 630.91 | 0.94 | 3.36 MB | ✅ |
| Single | Delete | 1,000 | 1,556 | 642.67 | 0.71 | 3.21 MB | ✅ |
| Single | Delete | 1,000 | 1,462 | 683.99 | 1.20 | 3.21 MB | ✅ |
| Single | Insert | 1,000 | 1,567 | 638.16 | 1.12 | 11.88 MB | ✅ |
| Single | Insert | 1,000 | 1,695 | 589.97 | 1.50 | 6.49 MB | ✅ |
| Single | Insert | 1,000 | 1,564 | 639.39 | 1.29 | 2.28 MB | ✅ |
| Single | Insert | 1,000 | 1,643 | 608.64 | 0.99 | 3.01 MB | ✅ |
| Single | Insert | 1,000 | 1,621 | 616.90 | 0.96 | 2.3 MB | ✅ |
| Single | Select | 1,000 | 1,031 | 969.93 | 2.59 | 0 B | ✅ |
| Single | Select | 1,000 | 1,031 | 969.93 | 2.40 | 0 B | ✅ |
| Single | Select | 1,000 | 1,078 | 927.64 | 1.81 | 0 B | ✅ |
| Single | Select | 1,000 | 1,070 | 934.58 | 2.31 | 0 B | ✅ |
| Single | Select | 1,000 | 1,009 | 991.08 | 2.00 | 0 B | ✅ |
| Single | Update | 1,000 | 1,634 | 612.00 | 1.43 | 0 B | ✅ |
| Single | Update | 1,000 | 1,655 | 604.23 | 1.30 | 0 B | ✅ |
| Single | Update | 1,000 | 1,729 | 578.37 | 1.28 | 0 B | ✅ |
| Single | Update | 1,000 | 1,604 | 623.44 | 1.83 | 1020 KB | ✅ |
| Single | Update | 1,000 | 1,599 | 625.39 | 1.42 | 992 KB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 11 | 90.91 | 5.50 | 152 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.47 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 172 KB | ✅ |
| Aggregation | Statistics | 5,000 | 32 | 187.50 | 4.00 | 820 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 8.13 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 6.64 | 4 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 8.22 | 0 B | ✅ |
| Batch | Delete | 5,000 | 124 | 40322.58 | 0.00 | 44 KB | ✅ |
| Batch | Delete | 5,000 | 106 | 47169.81 | 0.61 | 576 KB | ✅ |
| Batch | Delete | 5,000 | 108 | 46296.30 | 0.00 | 596 KB | ✅ |
| Batch | Delete | 5,000 | 121 | 41322.31 | 2.14 | 692 KB | ✅ |
| Batch | Delete | 5,000 | 124 | 40322.58 | 0.00 | 1.13 MB | ✅ |
| Batch | Insert | 5,000 | 436 | 11467.89 | 3.43 | 5.39 MB | ✅ |
| Batch | Insert | 5,000 | 415 | 12048.19 | 2.97 | 6.63 MB | ✅ |
| Batch | Insert | 5,000 | 412 | 12135.92 | 2.84 | 5.56 MB | ✅ |
| Batch | Insert | 5,000 | 411 | 12165.45 | 3.01 | 5.14 MB | ✅ |
| Batch | Insert | 5,000 | 410 | 12195.12 | 2.70 | 5.01 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 2.34 | 16 KB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 4.74 | 0 B | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 4.66 | 1012 KB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 2.33 | 0 B | ✅ |
| Batch | Select | 5,000 | 30 | 166666.67 | 4.32 | 184 KB | ✅ |
| Batch | Update | 5,000 | 322 | 15527.95 | 1.82 | 5.09 MB | ✅ |
| Batch | Update | 5,000 | 305 | 16393.44 | 1.28 | 5.17 MB | ✅ |
| Batch | Update | 5,000 | 305 | 16393.44 | 1.07 | 4.9 MB | ✅ |
| Batch | Update | 5,000 | 306 | 16339.87 | 2.33 | 5.12 MB | ✅ |
| Batch | Update | 5,000 | 309 | 16181.23 | 1.47 | 4.97 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 123 | 813.01 | 1.06 | 4 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 106 | 943.40 | 2.44 | 12 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 111 | 900.90 | 0.00 | 8 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 11 | 909.09 | 11.52 | 16 KB | ✅ |
| IndexQuery | OrderBy | 100 | 104 | 961.54 | 0.62 | 16 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 100 | 1000.00 | 1.95 | 16 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 105 | 952.38 | 0.62 | 56 KB | ✅ |
| IndexQuery | PrimaryKey | 100 | 0 | N/A | N/A | N/A | ❌ |
| IndexQuery | RangeQuery_Date | 100 | 113 | 884.96 | 1.15 | 8 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 105 | 952.38 | 0.62 | 12 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 109 | 917.43 | 1.79 | 12 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 102 | 980.39 | 1.91 | 3.34 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 110 | 909.09 | 1.77 | 0 B | ✅ |
| MillionData | Aggregation | 0 | 11 | 727.27 | 5.88 | 0 B | ✅ |
| MillionData | Cleanup | 0 | 1 | 0.00 | 0.00 | 20 KB | ✅ |
| MillionData | GroupBy | 0 | 6 | 666.67 | 20.19 | 44 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Delete | 1,000 | 3,082 | 324.46 | 0.82 | 5.59 MB | ✅ |
| Single | Delete | 1,000 | 3,135 | 318.98 | 0.42 | 3.08 MB | ✅ |
| Single | Delete | 1,000 | 3,017 | 331.46 | 0.82 | 3.23 MB | ✅ |
| Single | Delete | 1,000 | 3,018 | 331.35 | 0.47 | 3.21 MB | ✅ |
| Single | Delete | 1,000 | 3,063 | 326.48 | 0.85 | 3.21 MB | ✅ |
| Single | Insert | 1,000 | 3,343 | 299.13 | 1.23 | 9.38 MB | ✅ |
| Single | Insert | 1,000 | 3,248 | 307.88 | 0.58 | 4.5 MB | ✅ |
| Single | Insert | 1,000 | 3,164 | 316.06 | 0.60 | 4.13 MB | ✅ |
| Single | Insert | 1,000 | 3,178 | 314.66 | 0.66 | 5.68 MB | ✅ |
| Single | Insert | 1,000 | 3,197 | 312.79 | 0.63 | 8.04 MB | ✅ |
| Single | Select | 1,000 | 1,150 | 869.57 | 1.75 | 3.18 MB | ✅ |
| Single | Select | 1,000 | 1,079 | 926.78 | 1.87 | 3.93 MB | ✅ |
| Single | Select | 1,000 | 1,069 | 935.45 | 1.77 | 3 MB | ✅ |
| Single | Select | 1,000 | 1,065 | 938.97 | 2.08 | 3.4 MB | ✅ |
| Single | Select | 1,000 | 1,044 | 957.85 | 1.62 | 0 B | ✅ |
| Single | Update | 1,000 | 3,408 | 293.43 | 0.53 | 2.18 MB | ✅ |
| Single | Update | 1,000 | 3,242 | 308.45 | 0.66 | 0 B | ✅ |
| Single | Update | 1,000 | 3,272 | 305.62 | 0.82 | 1.05 MB | ✅ |
| Single | Update | 1,000 | 3,287 | 304.23 | 0.48 | 0 B | ✅ |
| Single | Update | 1,000 | 3,208 | 311.72 | 0.79 | 1020 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MariaDB | MySQL |
|:---------|:---------|-------:|-------:|
| Aggregation | GroupBy | 6.73 | 3.99 |
| Aggregation | Statistics | 2.47 | 5.40 |
| Batch | Delete | 1.90 | 0.55 |
| Batch | Insert | 3.19 | 2.99 |
| Batch | Select | 3.40 | 3.68 |
| Batch | Update | 2.64 | 1.59 |
| IndexQuery | ComplexCondition | 2.68 | 1.06 |
| IndexQuery | CompositeIndex_RegionDept | 3.09 | 2.44 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.17 | 0.00 |
| IndexQuery | NoIndex_FullScan | 13.81 | 11.52 |
| IndexQuery | OrderBy | 1.90 | 0.62 |
| IndexQuery | Pagination | 2.55 | 1.95 |
| IndexQuery | PrefixQuery_Name | 3.17 | 0.62 |
| IndexQuery | RangeQuery_Date | 1.80 | 1.15 |
| IndexQuery | RangeQuery_Salary | 2.78 | 0.62 |
| IndexQuery | RangeQuery_Score | 1.74 | 1.79 |
| IndexQuery | SingleIndex_Category | 5.39 | 1.91 |
| IndexQuery | SingleIndex_Status | 2.34 | 1.77 |
| MillionData | Aggregation | 8.37 | 5.88 |
| MillionData | Cleanup | 0.00 | 0.00 |
| MillionData | GroupBy | 0.00 | 20.19 |
| Single | Delete | 0.97 | 0.68 |
| Single | Insert | 1.17 | 0.74 |
| Single | Select | 2.22 | 1.82 |
| Single | Update | 1.45 | 0.66 |

## 内存消耗对比

| 操作类型 | 操作名称 | MariaDB | MySQL |
|:---------|:---------|-----------:|-----------:|
| Aggregation | GroupBy | 68 KB | 172 KB |
| Aggregation | Statistics | 1.77 MB | 820 KB |
| Batch | Delete | 676 KB | 1.13 MB |
| Batch | Insert | 6.42 MB | 6.63 MB |
| Batch | Select | 0 B | 1012 KB |
| Batch | Update | 7.7 MB | 5.17 MB |
| IndexQuery | ComplexCondition | 4.35 MB | 4 KB |
| IndexQuery | CompositeIndex_RegionDept | 1.29 MB | 12 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 1.17 MB | 8 KB |
| IndexQuery | NoIndex_FullScan | 100 KB | 16 KB |
| IndexQuery | OrderBy | 40 KB | 16 KB |
| IndexQuery | Pagination | 44 KB | 16 KB |
| IndexQuery | PrefixQuery_Name | 2.04 MB | 56 KB |
| IndexQuery | RangeQuery_Date | 132 KB | 8 KB |
| IndexQuery | RangeQuery_Salary | 388 KB | 12 KB |
| IndexQuery | RangeQuery_Score | 3.25 MB | 12 KB |
| IndexQuery | SingleIndex_Category | 4.39 MB | 3.34 MB |
| IndexQuery | SingleIndex_Status | 0 B | 0 B |
| MillionData | Aggregation | 0 B | 0 B |
| MillionData | Cleanup | 0 B | 20 KB |
| MillionData | GroupBy | 112 KB | 44 KB |
| Single | Delete | 3.36 MB | 5.59 MB |
| Single | Insert | 11.88 MB | 9.38 MB |
| Single | Select | 0 B | 3.93 MB |
| Single | Update | 1020 KB | 2.18 MB |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MariaDB | MillionData | PrepareData | 11:38:06 | FreeSql: ExecuteMySqlBulkCopyAsync is FreeSql.Provider.MySqlConnector specific features |
| MariaDB | IndexQuery | PrimaryKey | 11:38:06 | 'minValue' cannot be greater than maxValue. (Parameter 'minValue') |
| MySQL | MillionData | PrepareData | 11:38:05 | FreeSql: ExecuteMySqlBulkCopyAsync is FreeSql.Provider.MySqlConnector specific features |
| MySQL | IndexQuery | PrimaryKey | 11:38:05 | 'minValue' cannot be greater than maxValue. (Parameter 'minValue') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 11:41:38*
