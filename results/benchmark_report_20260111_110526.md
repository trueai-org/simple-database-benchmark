# 数据库基准测试报告

**测试时间**: 2026-01-11 11:05:26

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
| 采集时间 | 2026-01-11 11:05:26 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, SQLServer, PostgreSQL |
| 数据库数量 | 3 |
| 总测试用例数 | 198 |
| 成功用例数 | 198 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MySQL | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 5.60 | 1.00 | 30.20 | **PostgreSQL** |
| Aggregation | Statistics | 14.40 | 5.40 | 10.00 | **PostgreSQL** |
| Batch | Delete | 89.80 | 18.20 | 236.80 | **PostgreSQL** |
| Batch | Insert | 405.20 | 540.60 | 5205.20 | **MySQL** |
| Batch | Select | 27.00 | 7.40 | 14.40 | **PostgreSQL** |
| Batch | Update | 343.20 | 378.20 | 2730.00 | **MySQL** |
| IndexQuery | ComplexCondition | 4498.00 | 296.00 | 1454.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 180.00 | 61.00 | 201.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 280.00 | 94.00 | 243.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 7185.00 | 579.00 | 2590.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 53743.00 | 4530.00 | 4250.00 | **SQLServer** |
| IndexQuery | Pagination | 324.00 | 71.00 | 268.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 68208.00 | 9325.00 | 15843.00 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 108.00 | 42.00 | 145.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 857.00 | 128.00 | 236.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 1170.00 | 100.00 | 214.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 1171.00 | 91.00 | 219.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 166.00 | 121.00 | 111.00 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 168.00 | 70.00 | 462.00 | **PostgreSQL** |
| MillionData | Aggregation | 569.00 | 217.00 | 445.00 | **PostgreSQL** |
| MillionData | GroupBy | 7873.00 | 209.00 | 115.00 | **SQLServer** |
| MillionData | PrepareData | 95025.00 | 20588.00 | 27392.00 | **PostgreSQL** |
| Single | Delete | 3451.40 | 834.00 | 1569.40 | **PostgreSQL** |
| Single | Insert | 3582.40 | 937.40 | 1510.40 | **PostgreSQL** |
| Single | Select | 1061.60 | 392.80 | 1267.20 | **PostgreSQL** |
| Single | Update | 3574.80 | 964.60 | 3809.80 | **PostgreSQL** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MySQL | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 216.67 | 1000.00 | 33.61 | **PostgreSQL** |
| Aggregation | Statistics | 545.34 | 1170.00 | 728.57 | **PostgreSQL** |
| Batch | Delete | 56122.10 | 274853.80 | 21225.93 | **PostgreSQL** |
| Batch | Insert | 12365.59 | 9894.64 | 962.91 | **MySQL** |
| Batch | Select | 185388.69 | 678571.43 | 352092.76 | **PostgreSQL** |
| Batch | Update | 14852.26 | 13667.68 | 1846.18 | **MySQL** |
| IndexQuery | ComplexCondition | 22.23 | 337.84 | 68.78 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 555.56 | 1639.34 | 497.51 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 357.14 | 1063.83 | 411.52 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 1.39 | 17.27 | 3.86 | **PostgreSQL** |
| IndexQuery | OrderBy | 1.86 | 22.08 | 23.53 | **SQLServer** |
| IndexQuery | Pagination | 308.64 | 1408.45 | 373.13 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 1.47 | 10.72 | 6.31 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 925.93 | 2380.95 | 689.66 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 116.69 | 781.25 | 423.73 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 85.47 | 1000.00 | 467.29 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 85.40 | 1098.90 | 456.62 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 602.41 | 826.45 | 900.90 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 595.24 | 1428.57 | 216.45 | **PostgreSQL** |
| MillionData | Aggregation | 14.06 | 36.87 | 17.98 | **PostgreSQL** |
| MillionData | GroupBy | 0.51 | 19.14 | 34.78 | **SQLServer** |
| MillionData | PrepareData | 10523.55 | 48571.98 | 36507.01 | **PostgreSQL** |
| Single | Delete | 289.78 | 1199.17 | 638.97 | **PostgreSQL** |
| Single | Insert | 279.54 | 1067.15 | 662.80 | **PostgreSQL** |
| Single | Select | 942.64 | 2546.04 | 817.75 | **PostgreSQL** |
| Single | Update | 279.86 | 1037.11 | 266.57 | **PostgreSQL** |

## 各数据库详细结果

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.24 | 236 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 100 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 14.75 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 33 | 181.82 | 5.77 | 784 KB | ✅ |
| Aggregation | Statistics | 5,000 | 13 | 461.54 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 9 | 666.67 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 5,000 | 101 | 49504.95 | 0.64 | 324 KB | ✅ |
| Batch | Delete | 5,000 | 83 | 60240.96 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 80 | 62500.00 | 0.00 | 248 KB | ✅ |
| Batch | Delete | 5,000 | 97 | 51546.39 | 0.00 | 104 KB | ✅ |
| Batch | Delete | 5,000 | 88 | 56818.18 | 0.73 | 196 KB | ✅ |
| Batch | Insert | 5,000 | 442 | 11312.22 | 2.21 | 10.35 MB | ✅ |
| Batch | Insert | 5,000 | 390 | 12820.51 | 3.00 | 11.12 MB | ✅ |
| Batch | Insert | 5,000 | 392 | 12755.10 | 2.98 | 10.98 MB | ✅ |
| Batch | Insert | 5,000 | 397 | 12594.46 | 2.95 | 11.11 MB | ✅ |
| Batch | Insert | 5,000 | 405 | 12345.68 | 3.21 | 10.81 MB | ✅ |
| Batch | Select | 5,000 | 28 | 178571.43 | 4.64 | 3.37 MB | ✅ |
| Batch | Select | 5,000 | 27 | 185185.19 | 4.70 | 3.35 MB | ✅ |
| Batch | Select | 5,000 | 26 | 192307.69 | 2.46 | 4.3 MB | ✅ |
| Batch | Select | 5,000 | 26 | 192307.69 | 4.89 | 3.37 MB | ✅ |
| Batch | Select | 5,000 | 28 | 178571.43 | 2.26 | 3.37 MB | ✅ |
| Batch | Update | 5,000 | 326 | 15337.42 | 1.99 | 5.8 MB | ✅ |
| Batch | Update | 5,000 | 398 | 12562.81 | 1.80 | 2.98 MB | ✅ |
| Batch | Update | 5,000 | 287 | 17421.60 | 2.04 | 5.33 MB | ✅ |
| Batch | Update | 5,000 | 402 | 12437.81 | 1.45 | 5.39 MB | ✅ |
| Batch | Update | 5,000 | 303 | 16501.65 | 2.14 | 5.34 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 4,498 | 22.23 | 0.20 | 9.61 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 180 | 555.56 | 2.17 | 500 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 280 | 357.14 | 0.93 | 3.21 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 7,185 | 1.39 | 0.05 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 53,743 | 1.86 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 324 | 308.64 | 1.00 | 2.01 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 68,208 | 1.47 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 108 | 925.93 | 3.00 | 340 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 857 | 116.69 | 0.68 | 160 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 1,170 | 85.47 | 0.39 | 72 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 1,171 | 85.40 | 0.39 | 7.39 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 166 | 602.41 | 3.13 | 8 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 168 | 595.24 | 3.10 | 5.93 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 569 | 14.06 | 0.23 | 1.25 MB | ✅ |
| MillionData | GroupBy | 32 | 7,873 | 0.51 | 0.00 | 124 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 95,025 | 10523.55 | 2.60 | 21.08 MB | ✅ |
| Single | Delete | 1,000 | 3,519 | 284.17 | 0.63 | 5.56 MB | ✅ |
| Single | Delete | 1,000 | 3,442 | 290.53 | 0.64 | 3.05 MB | ✅ |
| Single | Delete | 1,000 | 3,387 | 295.25 | 0.69 | 4.01 MB | ✅ |
| Single | Delete | 1,000 | 3,445 | 290.28 | 0.43 | 2.82 MB | ✅ |
| Single | Delete | 1,000 | 3,464 | 288.68 | 0.58 | 3.97 MB | ✅ |
| Single | Insert | 1,000 | 3,852 | 259.61 | 0.93 | 1.43 MB | ✅ |
| Single | Insert | 1,000 | 3,536 | 282.81 | 0.74 | 6.69 MB | ✅ |
| Single | Insert | 1,000 | 3,475 | 287.77 | 0.51 | 6.49 MB | ✅ |
| Single | Insert | 1,000 | 3,554 | 281.37 | 0.73 | 6.07 MB | ✅ |
| Single | Insert | 1,000 | 3,495 | 286.12 | 0.69 | 3.64 MB | ✅ |
| Single | Select | 1,000 | 1,111 | 900.09 | 2.11 | 3.53 MB | ✅ |
| Single | Select | 1,000 | 1,036 | 965.25 | 1.88 | 0 B | ✅ |
| Single | Select | 1,000 | 1,039 | 962.46 | 1.69 | 0 B | ✅ |
| Single | Select | 1,000 | 1,046 | 956.02 | 1.93 | 0 B | ✅ |
| Single | Select | 1,000 | 1,076 | 929.37 | 2.06 | 3 MB | ✅ |
| Single | Update | 1,000 | 3,719 | 268.89 | 0.72 | 0 B | ✅ |
| Single | Update | 1,000 | 3,560 | 280.90 | 0.57 | 116 KB | ✅ |
| Single | Update | 1,000 | 3,554 | 281.37 | 0.57 | 176 KB | ✅ |
| Single | Update | 1,000 | 3,556 | 281.21 | 0.66 | 448 KB | ✅ |
| Single | Update | 1,000 | 3,485 | 286.94 | 0.69 | 1.06 MB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 36.30 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 33.19 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.30 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 24.01 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 7.02 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 18 | 277777.78 | 3.56 | 16 KB | ✅ |
| Batch | Delete | 5,000 | 19 | 263157.89 | 0.00 | 16 KB | ✅ |
| Batch | Insert | 5,000 | 872 | 5733.94 | 1.19 | 8.18 MB | ✅ |
| Batch | Insert | 5,000 | 471 | 10615.71 | 1.24 | 10.92 MB | ✅ |
| Batch | Insert | 5,000 | 460 | 10869.57 | 1.70 | 11.37 MB | ✅ |
| Batch | Insert | 5,000 | 467 | 10706.64 | 1.81 | 11.3 MB | ✅ |
| Batch | Insert | 5,000 | 433 | 11547.34 | 1.95 | 11.29 MB | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 0.00 | 4 KB | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 8.25 | 0 B | ✅ |
| Batch | Select | 5,000 | 7 | 714285.71 | 0.00 | 12 KB | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.64 | 0 B | ✅ |
| Batch | Select | 5,000 | 8 | 625000.00 | 7.33 | 0 B | ✅ |
| Batch | Update | 5,000 | 443 | 11286.68 | 1.47 | 0 B | ✅ |
| Batch | Update | 5,000 | 444 | 11261.26 | 1.32 | 0 B | ✅ |
| Batch | Update | 5,000 | 407 | 12285.01 | 1.12 | 2.5 MB | ✅ |
| Batch | Update | 5,000 | 295 | 16949.15 | 1.98 | 0 B | ✅ |
| Batch | Update | 5,000 | 302 | 16556.29 | 1.94 | 0 B | ✅ |
| IndexQuery | ComplexCondition | 100 | 296 | 337.84 | 0.88 | 0 B | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 61 | 1639.34 | 2.11 | 368 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 94 | 1063.83 | 4.11 | 512 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 579 | 17.27 | 0.00 | 444 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,530 | 22.08 | 0.03 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 71 | 1408.45 | 3.66 | 0 B | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 9,325 | 10.72 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 42 | 2380.95 | 1.54 | 56 KB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 128 | 781.25 | 1.02 | 144 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 100 | 1000.00 | 2.60 | 984 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 91 | 1098.90 | 1.42 | 0 B | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 121 | 826.45 | 0.54 | 4.11 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 70 | 1428.57 | 1.84 | 3.86 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 217 | 36.87 | 0.00 | 144 KB | ✅ |
| MillionData | GroupBy | 32 | 209 | 19.14 | 0.00 | 48 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 20,588 | 48571.98 | 2.32 | 28.98 MB | ✅ |
| Single | Delete | 1,000 | 833 | 1200.48 | 1.41 | 0 B | ✅ |
| Single | Delete | 1,000 | 844 | 1184.83 | 0.93 | 0 B | ✅ |
| Single | Delete | 1,000 | 819 | 1221.00 | 0.64 | 0 B | ✅ |
| Single | Delete | 1,000 | 841 | 1189.06 | 1.32 | 0 B | ✅ |
| Single | Delete | 1,000 | 833 | 1200.48 | 1.64 | 0 B | ✅ |
| Single | Insert | 1,000 | 927 | 1078.75 | 1.26 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 966 | 1035.20 | 1.68 | 6.68 MB | ✅ |
| Single | Insert | 1,000 | 945 | 1058.20 | 1.03 | 6.78 MB | ✅ |
| Single | Insert | 1,000 | 935 | 1069.52 | 1.74 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 914 | 1094.09 | 1.14 | 6.77 MB | ✅ |
| Single | Select | 1,000 | 393 | 2544.53 | 2.32 | 4.08 MB | ✅ |
| Single | Select | 1,000 | 387 | 2583.98 | 3.02 | 4 MB | ✅ |
| Single | Select | 1,000 | 397 | 2518.89 | 2.62 | 4 MB | ✅ |
| Single | Select | 1,000 | 396 | 2525.25 | 3.28 | 4 MB | ✅ |
| Single | Select | 1,000 | 391 | 2557.54 | 3.49 | 4 MB | ✅ |
| Single | Update | 1,000 | 989 | 1011.12 | 1.45 | 36 KB | ✅ |
| Single | Update | 1,000 | 980 | 1020.41 | 1.59 | 0 B | ✅ |
| Single | Update | 1,000 | 950 | 1052.63 | 1.10 | 0 B | ✅ |
| Single | Update | 1,000 | 967 | 1034.13 | 0.87 | 0 B | ✅ |
| Single | Update | 1,000 | 937 | 1067.24 | 1.32 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 38 | 26.32 | 0.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 27 | 37.04 | 2.33 | 52 KB | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 29 | 34.48 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 8 | 28 | 35.71 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 5,000 | 21 | 285.71 | 5.97 | 124 KB | ✅ |
| Aggregation | Statistics | 5,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 8 | 750.00 | 7.62 | 20 KB | ✅ |
| Aggregation | Statistics | 5,000 | 6 | 1000.00 | 9.37 | 1.54 MB | ✅ |
| Batch | Delete | 5,000 | 272 | 18382.35 | 0.72 | 20 KB | ✅ |
| Batch | Delete | 5,000 | 227 | 22026.43 | 0.00 | 1.75 MB | ✅ |
| Batch | Delete | 5,000 | 233 | 21459.23 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 230 | 21739.13 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 222 | 22522.52 | 0.00 | 0 B | ✅ |
| Batch | Insert | 5,000 | 5,513 | 906.95 | 0.12 | 4.4 MB | ✅ |
| Batch | Insert | 5,000 | 5,342 | 935.98 | 0.12 | 2.79 MB | ✅ |
| Batch | Insert | 5,000 | 5,174 | 966.37 | 0.04 | 2.44 MB | ✅ |
| Batch | Insert | 5,000 | 5,239 | 954.38 | 0.07 | 4.03 MB | ✅ |
| Batch | Insert | 5,000 | 4,758 | 1050.86 | 0.08 | 2.72 MB | ✅ |
| Batch | Select | 5,000 | 16 | 312500.00 | 0.00 | 232 KB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 9.37 | 12 KB | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 4.74 | 64 KB | ✅ |
| Batch | Select | 5,000 | 17 | 294117.65 | 3.69 | 0 B | ✅ |
| Batch | Select | 5,000 | 13 | 384615.38 | 0.00 | 384 KB | ✅ |
| Batch | Update | 5,000 | 2,479 | 2016.94 | 0.11 | 5.02 MB | ✅ |
| Batch | Update | 5,000 | 3,006 | 1663.34 | 0.09 | 4.02 MB | ✅ |
| Batch | Update | 5,000 | 3,022 | 1654.53 | 0.15 | 4.61 MB | ✅ |
| Batch | Update | 5,000 | 2,683 | 1863.59 | 0.05 | 3.86 MB | ✅ |
| Batch | Update | 5,000 | 2,460 | 2032.52 | 0.13 | 4 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 1,454 | 68.78 | 0.09 | 12 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 201 | 497.51 | 1.61 | 2.45 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 243 | 411.52 | 1.60 | 3.83 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,590 | 3.86 | 0.03 | 88 KB | ✅ |
| IndexQuery | OrderBy | 100 | 4,250 | 23.53 | 0.06 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 268 | 373.13 | 0.97 | 2.96 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,843 | 6.31 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 145 | 689.66 | 0.45 | 3.21 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 236 | 423.73 | 0.83 | 2.28 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 214 | 467.29 | 0.61 | 1.19 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 219 | 456.62 | 1.48 | 2.2 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 111 | 900.90 | 0.58 | 1.62 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 462 | 216.45 | 0.42 | 2 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 445 | 17.98 | 0.00 | 2.16 MB | ✅ |
| MillionData | GroupBy | 32 | 115 | 34.78 | 0.00 | 216 KB | ✅ |
| MillionData | PrepareData | 1,000,000 | 27,392 | 36507.01 | 1.06 | 69.81 MB | ✅ |
| Single | Delete | 1,000 | 1,712 | 584.11 | 0.30 | 608 KB | ✅ |
| Single | Delete | 1,000 | 1,589 | 629.33 | 0.82 | 148 KB | ✅ |
| Single | Delete | 1,000 | 1,484 | 673.85 | 0.44 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,578 | 633.71 | 0.41 | 24 KB | ✅ |
| Single | Delete | 1,000 | 1,484 | 673.85 | 0.66 | 20 KB | ✅ |
| Single | Insert | 1,000 | 1,606 | 622.67 | 0.57 | 6.43 MB | ✅ |
| Single | Insert | 1,000 | 1,517 | 659.20 | 0.26 | 6.63 MB | ✅ |
| Single | Insert | 1,000 | 1,473 | 678.89 | 0.49 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 1,488 | 672.04 | 0.48 | 6.79 MB | ✅ |
| Single | Insert | 1,000 | 1,468 | 681.20 | 0.84 | 6.79 MB | ✅ |
| Single | Select | 1,000 | 1,610 | 621.12 | 0.73 | 1.39 MB | ✅ |
| Single | Select | 1,000 | 1,463 | 683.53 | 0.67 | 3 MB | ✅ |
| Single | Select | 1,000 | 1,017 | 983.28 | 0.90 | 3 MB | ✅ |
| Single | Select | 1,000 | 1,241 | 805.80 | 0.68 | 2.4 MB | ✅ |
| Single | Select | 1,000 | 1,005 | 995.02 | 0.65 | 3 MB | ✅ |
| Single | Update | 1,000 | 3,729 | 268.17 | 0.26 | 2.53 MB | ✅ |
| Single | Update | 1,000 | 4,538 | 220.36 | 0.33 | 1.61 MB | ✅ |
| Single | Update | 1,000 | 3,308 | 302.30 | 0.22 | 972 KB | ✅ |
| Single | Update | 1,000 | 4,156 | 240.62 | 0.16 | 2.98 MB | ✅ |
| Single | Update | 1,000 | 3,318 | 301.39 | 0.22 | 3.04 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MySQL | PostgreSQL | SQLServer |
|:---------|:---------|-------:|-------:|-------:|
| Aggregation | GroupBy | 4.00 | 13.90 | 0.47 |
| Aggregation | Statistics | 1.15 | 6.26 | 4.59 |
| Batch | Delete | 0.27 | 2.12 | 0.14 |
| Batch | Insert | 2.87 | 1.58 | 0.09 |
| Batch | Select | 3.79 | 4.64 | 3.56 |
| Batch | Update | 1.88 | 1.57 | 0.11 |
| IndexQuery | ComplexCondition | 0.20 | 0.88 | 0.09 |
| IndexQuery | CompositeIndex_RegionDept | 2.17 | 2.11 | 1.61 |
| IndexQuery | CompositeIndex_StatusCatPri | 0.93 | 4.11 | 1.60 |
| IndexQuery | NoIndex_FullScan | 0.05 | 0.00 | 0.03 |
| IndexQuery | OrderBy | 0.01 | 0.03 | 0.06 |
| IndexQuery | Pagination | 1.00 | 3.66 | 0.97 |
| IndexQuery | PrefixQuery_Name | 0.01 | 0.01 | 0.01 |
| IndexQuery | PrimaryKey | 3.00 | 1.54 | 0.45 |
| IndexQuery | RangeQuery_Date | 0.68 | 1.02 | 0.83 |
| IndexQuery | RangeQuery_Salary | 0.39 | 2.60 | 0.61 |
| IndexQuery | RangeQuery_Score | 0.39 | 1.42 | 1.48 |
| IndexQuery | SingleIndex_Category | 3.13 | 0.54 | 0.58 |
| IndexQuery | SingleIndex_Status | 3.10 | 1.84 | 0.42 |
| MillionData | Aggregation | 0.23 | 0.00 | 0.00 |
| MillionData | GroupBy | 0.00 | 0.00 | 0.00 |
| MillionData | PrepareData | 2.60 | 2.32 | 1.06 |
| Single | Delete | 0.59 | 1.19 | 0.53 |
| Single | Insert | 0.72 | 1.37 | 0.53 |
| Single | Select | 1.93 | 2.95 | 0.73 |
| Single | Update | 0.64 | 1.27 | 0.24 |

## 内存消耗对比

| 操作类型 | 操作名称 | MySQL | PostgreSQL | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 236 KB | 8 KB | 56 KB |
| Aggregation | Statistics | 784 KB | 0 B | 1.54 MB |
| Batch | Delete | 324 KB | 32 KB | 1.75 MB |
| Batch | Insert | 11.12 MB | 11.37 MB | 4.4 MB |
| Batch | Select | 4.3 MB | 12 KB | 384 KB |
| Batch | Update | 5.8 MB | 2.5 MB | 5.02 MB |
| IndexQuery | ComplexCondition | 9.61 MB | 0 B | 12 KB |
| IndexQuery | CompositeIndex_RegionDept | 500 KB | 368 KB | 2.45 MB |
| IndexQuery | CompositeIndex_StatusCatPri | 3.21 MB | 512 KB | 3.83 MB |
| IndexQuery | NoIndex_FullScan | 0 B | 444 KB | 88 KB |
| IndexQuery | OrderBy | 0 B | 0 B | 0 B |
| IndexQuery | Pagination | 2.01 MB | 0 B | 2.96 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 0 B | 0 B |
| IndexQuery | PrimaryKey | 340 KB | 56 KB | 3.21 MB |
| IndexQuery | RangeQuery_Date | 160 KB | 144 KB | 2.28 MB |
| IndexQuery | RangeQuery_Salary | 72 KB | 984 KB | 1.19 MB |
| IndexQuery | RangeQuery_Score | 7.39 MB | 0 B | 2.2 MB |
| IndexQuery | SingleIndex_Category | 8 KB | 4.11 MB | 1.62 MB |
| IndexQuery | SingleIndex_Status | 5.93 MB | 3.86 MB | 2 MB |
| MillionData | Aggregation | 1.25 MB | 144 KB | 2.16 MB |
| MillionData | GroupBy | 124 KB | 48 KB | 216 KB |
| MillionData | PrepareData | 21.08 MB | 28.98 MB | 69.81 MB |
| Single | Delete | 5.56 MB | 0 B | 608 KB |
| Single | Insert | 6.69 MB | 6.79 MB | 6.79 MB |
| Single | Select | 3.53 MB | 4.08 MB | 3 MB |
| Single | Update | 1.06 MB | 36 KB | 3.04 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260111.log` 文件。

---

*报告生成时间: 2026-01-11 11:05:26*
