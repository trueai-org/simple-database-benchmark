# 数据库基准测试报告

**测试时间**: 2025-12-09 12:23:47

## 服务器信息

| 项目 | 值 |
|------|-----|
| 机器名称 | DESKTOP-RLEON3G |
| 操作系统 | Microsoft Windows 10.0.19045 |
| OS 架构 | X64 |
| 进程架构 | X64 |
| 处理器数量 | 24 |
| .NET 版本 | .NET 8.0.20 |
| 总内存 | 31.81 GB |
| 采集时间 | 2025-12-09 12:23:47 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, SQLServer, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 5 |
| 总测试用例数 | 250 |
| 成功用例数 | 250 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 5.40 | 7.40 | 2.00 | 3.60 | 11.80 | **PostgreSQL** |
| Aggregation | Statistics | 8.80 | 15.80 | 8.40 | 10.60 | 11.20 | **PostgreSQL** |
| Batch | Delete | 73.60 | 103.20 | 35.00 | 41.20 | 282.40 | **PostgreSQL** |
| Batch | Insert | 54.40 | 484.40 | 1306.60 | 560.00 | 4816.60 | **MongoDB** |
| Batch | Select | 36.20 | 44.20 | 77.80 | 15.80 | 30.60 | **SQLite** |
| Batch | Update | 265.60 | 560.20 | 1383.20 | 657.60 | 5520.40 | **MongoDB** |
| Single | Delete | 558.00 | 3526.80 | 881.00 | 2175.60 | 1541.20 | **MongoDB** |
| Single | Insert | 390.40 | 3669.20 | 926.60 | 2190.60 | 1445.80 | **MongoDB** |
| Single | Select | 535.20 | 1081.60 | 375.00 | 110.00 | 951.00 | **SQLite** |
| Single | Update | 592.00 | 3688.40 | 972.20 | 2197.20 | 2412.40 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 186.67 | 148.72 | 500.00 | 290.00 | 84.85 | **PostgreSQL** |
| Aggregation | Statistics | 126.79 | 462.56 | 742.86 | 569.09 | 558.98 | **PostgreSQL** |
| Batch | Delete | 135953.87 | 96907.89 | 286542.11 | 242911.16 | 35457.23 | **PostgreSQL** |
| Batch | Insert | 184193.52 | 20904.87 | 7844.60 | 17858.10 | 2076.51 | **MongoDB** |
| Batch | Select | 276706.07 | 226309.61 | 544053.03 | 633333.33 | 329135.85 | **SQLite** |
| Batch | Update | 38340.49 | 17872.14 | 7311.87 | 15208.58 | 1811.72 | **MongoDB** |
| Single | Delete | 1794.56 | 283.55 | 1136.32 | 459.88 | 649.93 | **MongoDB** |
| Single | Insert | 2575.37 | 272.59 | 1079.65 | 456.57 | 692.05 | **MongoDB** |
| Single | Select | 1870.01 | 925.52 | 2668.57 | 9105.61 | 1052.99 | **SQLite** |
| Single | Update | 1690.44 | 271.21 | 1031.19 | 455.14 | 415.08 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 36 KB | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 11.15 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 11.02 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 16 | 62.50 | 0.00 | 636 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 8.84 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 8.82 | 0 B | ✅ |
| Batch | Delete | 10,000 | 72 | 138888.89 | 0.00 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 72 | 138888.89 | 1.78 | 48 KB | ✅ |
| Batch | Delete | 10,000 | 77 | 129870.13 | 2.53 | 1.93 MB | ✅ |
| Batch | Delete | 10,000 | 74 | 135135.14 | 1.75 | 76 KB | ✅ |
| Batch | Delete | 10,000 | 73 | 136986.30 | 1.77 | 1.32 MB | ✅ |
| Batch | Insert | 10,000 | 56 | 178571.43 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 57 | 175438.60 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 56 | 178571.43 | 1.15 | 0 B | ✅ |
| Batch | Insert | 10,000 | 52 | 192307.69 | 6.20 | 0 B | ✅ |
| Batch | Insert | 10,000 | 51 | 196078.43 | 5.01 | 0 B | ✅ |
| Batch | Select | 10,000 | 38 | 263157.89 | 3.38 | 2.13 MB | ✅ |
| Batch | Select | 10,000 | 37 | 270270.27 | 5.25 | 8 KB | ✅ |
| Batch | Select | 10,000 | 35 | 285714.29 | 1.83 | 16 KB | ✅ |
| Batch | Select | 10,000 | 34 | 294117.65 | 1.88 | 0 B | ✅ |
| Batch | Select | 10,000 | 37 | 270270.27 | 5.27 | 0 B | ✅ |
| Batch | Update | 10,000 | 250 | 40000.00 | 1.30 | 2.02 MB | ✅ |
| Batch | Update | 10,000 | 241 | 41493.78 | 1.08 | 5.86 MB | ✅ |
| Batch | Update | 10,000 | 344 | 29069.77 | 1.32 | 4.02 MB | ✅ |
| Batch | Update | 10,000 | 248 | 40322.58 | 1.31 | 4.83 MB | ✅ |
| Batch | Update | 10,000 | 245 | 40816.33 | 1.59 | 4 MB | ✅ |
| Single | Delete | 1,000 | 548 | 1824.82 | 1.30 | 7.38 MB | ✅ |
| Single | Delete | 1,000 | 543 | 1841.62 | 1.68 | 212 KB | ✅ |
| Single | Delete | 1,000 | 541 | 1848.43 | 1.32 | 200 KB | ✅ |
| Single | Delete | 1,000 | 560 | 1785.71 | 1.39 | 228 KB | ✅ |
| Single | Delete | 1,000 | 598 | 1672.24 | 1.74 | 136 KB | ✅ |
| Single | Insert | 1,000 | 448 | 2232.14 | 4.50 | 11.63 MB | ✅ |
| Single | Insert | 1,000 | 365 | 2739.73 | 0.71 | 9.43 MB | ✅ |
| Single | Insert | 1,000 | 369 | 2710.03 | 1.58 | 2.88 MB | ✅ |
| Single | Insert | 1,000 | 383 | 2610.97 | 1.36 | 2.88 MB | ✅ |
| Single | Insert | 1,000 | 387 | 2583.98 | 0.50 | 2.87 MB | ✅ |
| Single | Select | 1,000 | 560 | 1785.71 | 3.60 | 7.07 MB | ✅ |
| Single | Select | 1,000 | 524 | 1908.40 | 1.99 | 9.55 MB | ✅ |
| Single | Select | 1,000 | 516 | 1937.98 | 2.14 | 404 KB | ✅ |
| Single | Select | 1,000 | 532 | 1879.70 | 2.57 | 300 KB | ✅ |
| Single | Select | 1,000 | 544 | 1838.24 | 1.79 | 296 KB | ✅ |
| Single | Update | 1,000 | 603 | 1658.37 | 2.16 | 1.28 MB | ✅ |
| Single | Update | 1,000 | 574 | 1742.16 | 2.27 | 96 KB | ✅ |
| Single | Update | 1,000 | 574 | 1742.16 | 1.70 | 80 KB | ✅ |
| Single | Update | 1,000 | 594 | 1683.50 | 1.86 | 136 KB | ✅ |
| Single | Update | 1,000 | 615 | 1626.02 | 1.48 | 112 KB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 13 | 76.92 | 0.00 | 212 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 9.91 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 80 KB | ✅ |
| Aggregation | Statistics | 10,000 | 34 | 176.47 | 5.64 | 708 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.45 | 12 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.45 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.38 | 0 B | ✅ |
| Batch | Delete | 10,000 | 103 | 97087.38 | 0.63 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 103 | 97087.38 | 1.25 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 102 | 98039.22 | 1.91 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 103 | 97087.38 | 0.00 | 5.68 MB | ✅ |
| Batch | Delete | 10,000 | 105 | 95238.10 | 0.00 | 1.87 MB | ✅ |
| Batch | Insert | 10,000 | 442 | 22624.43 | 2.94 | 9.11 MB | ✅ |
| Batch | Insert | 10,000 | 552 | 18115.94 | 2.47 | 8.24 MB | ✅ |
| Batch | Insert | 10,000 | 433 | 23094.69 | 3.31 | 6.82 MB | ✅ |
| Batch | Insert | 10,000 | 552 | 18115.94 | 2.59 | 12.16 MB | ✅ |
| Batch | Insert | 10,000 | 443 | 22573.36 | 3.23 | 8.49 MB | ✅ |
| Batch | Select | 10,000 | 44 | 227272.73 | 2.93 | 24 KB | ✅ |
| Batch | Select | 10,000 | 43 | 232558.14 | 1.49 | 4 KB | ✅ |
| Batch | Select | 10,000 | 44 | 227272.73 | 1.45 | 532 KB | ✅ |
| Batch | Select | 10,000 | 45 | 222222.22 | 0.00 | 16 KB | ✅ |
| Batch | Select | 10,000 | 45 | 222222.22 | 2.87 | 0 B | ✅ |
| Batch | Update | 10,000 | 597 | 16750.42 | 3.49 | 5.75 MB | ✅ |
| Batch | Update | 10,000 | 540 | 18518.52 | 2.53 | 776 KB | ✅ |
| Batch | Update | 10,000 | 558 | 17921.15 | 2.22 | 4.57 MB | ✅ |
| Batch | Update | 10,000 | 547 | 18281.54 | 2.85 | 604 KB | ✅ |
| Batch | Update | 10,000 | 559 | 17889.09 | 2.33 | 3.57 MB | ✅ |
| Single | Delete | 1,000 | 3,560 | 280.90 | 0.57 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,513 | 284.66 | 0.74 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,518 | 284.25 | 0.52 | 80 KB | ✅ |
| Single | Delete | 1,000 | 3,500 | 285.71 | 0.39 | 3.02 MB | ✅ |
| Single | Delete | 1,000 | 3,543 | 282.25 | 0.61 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,719 | 268.89 | 1.10 | 5.22 MB | ✅ |
| Single | Insert | 1,000 | 3,724 | 268.53 | 0.56 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,595 | 278.16 | 0.69 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,620 | 276.24 | 0.68 | 3.15 MB | ✅ |
| Single | Insert | 1,000 | 3,688 | 271.15 | 0.60 | 7.27 MB | ✅ |
| Single | Select | 1,000 | 1,107 | 903.34 | 2.47 | 2.83 MB | ✅ |
| Single | Select | 1,000 | 1,045 | 956.94 | 2.06 | 956 KB | ✅ |
| Single | Select | 1,000 | 1,100 | 909.09 | 2.31 | 0 B | ✅ |
| Single | Select | 1,000 | 1,035 | 966.18 | 2.64 | 2.59 MB | ✅ |
| Single | Select | 1,000 | 1,121 | 892.06 | 1.97 | 4.6 MB | ✅ |
| Single | Update | 1,000 | 3,796 | 263.44 | 0.46 | 0 B | ✅ |
| Single | Update | 1,000 | 3,605 | 277.39 | 0.42 | 0 B | ✅ |
| Single | Update | 1,000 | 3,688 | 271.15 | 0.64 | 96 KB | ✅ |
| Single | Update | 1,000 | 3,636 | 275.03 | 0.54 | 4.8 MB | ✅ |
| Single | Update | 1,000 | 3,717 | 269.03 | 0.72 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 40 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 26.07 | 48 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.34 | 20 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 35 | 285714.29 | 0.00 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 33 | 303030.30 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 33 | 303030.30 | 1.93 | 0 B | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 0.00 | 8 KB | ✅ |
| Batch | Insert | 10,000 | 1,560 | 6410.26 | 0.71 | 3.33 MB | ✅ |
| Batch | Insert | 10,000 | 1,390 | 7194.24 | 0.89 | 4.58 MB | ✅ |
| Batch | Insert | 10,000 | 1,408 | 7102.27 | 0.74 | 4.69 MB | ✅ |
| Batch | Insert | 10,000 | 998 | 10020.04 | 1.30 | 5.05 MB | ✅ |
| Batch | Insert | 10,000 | 1,177 | 8496.18 | 0.83 | 4.46 MB | ✅ |
| Batch | Select | 10,000 | 13 | 769230.77 | 4.87 | 2.92 MB | ✅ |
| Batch | Select | 10,000 | 13 | 769230.77 | 0.00 | 760 KB | ✅ |
| Batch | Select | 10,000 | 19 | 526315.79 | 0.00 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.91 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 328 | 30487.80 | 0.20 | 1.78 MB | ✅ |
| Batch | Update | 10,000 | 1,275 | 7843.14 | 1.12 | 516 KB | ✅ |
| Batch | Update | 10,000 | 1,238 | 8077.54 | 0.84 | 296 KB | ✅ |
| Batch | Update | 10,000 | 1,625 | 6153.85 | 0.60 | 68 KB | ✅ |
| Batch | Update | 10,000 | 1,282 | 7800.31 | 1.01 | 80 KB | ✅ |
| Batch | Update | 10,000 | 1,496 | 6684.49 | 0.78 | 16 KB | ✅ |
| Single | Delete | 1,000 | 938 | 1066.10 | 1.25 | 0 B | ✅ |
| Single | Delete | 1,000 | 861 | 1161.44 | 1.28 | 0 B | ✅ |
| Single | Delete | 1,000 | 871 | 1148.11 | 1.20 | 0 B | ✅ |
| Single | Delete | 1,000 | 855 | 1169.59 | 0.69 | 0 B | ✅ |
| Single | Delete | 1,000 | 880 | 1136.36 | 1.18 | 0 B | ✅ |
| Single | Insert | 1,000 | 931 | 1074.11 | 0.91 | 996 KB | ✅ |
| Single | Insert | 1,000 | 928 | 1077.59 | 1.19 | 0 B | ✅ |
| Single | Insert | 1,000 | 931 | 1074.11 | 1.19 | 0 B | ✅ |
| Single | Insert | 1,000 | 893 | 1119.82 | 1.17 | 0 B | ✅ |
| Single | Insert | 1,000 | 950 | 1052.63 | 1.03 | 0 B | ✅ |
| Single | Select | 1,000 | 385 | 2597.40 | 3.71 | 52 KB | ✅ |
| Single | Select | 1,000 | 367 | 2724.80 | 2.12 | 0 B | ✅ |
| Single | Select | 1,000 | 389 | 2570.69 | 3.68 | 0 B | ✅ |
| Single | Select | 1,000 | 364 | 2747.25 | 3.21 | 0 B | ✅ |
| Single | Select | 1,000 | 370 | 2702.70 | 3.34 | 0 B | ✅ |
| Single | Update | 1,000 | 1,066 | 938.09 | 1.34 | 40 KB | ✅ |
| Single | Update | 1,000 | 961 | 1040.58 | 0.61 | 0 B | ✅ |
| Single | Update | 1,000 | 916 | 1091.70 | 1.14 | 0 B | ✅ |
| Single | Update | 1,000 | 953 | 1049.32 | 0.89 | 0 B | ✅ |
| Single | Update | 1,000 | 965 | 1036.27 | 0.88 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 11.09 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 536 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 440 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 332 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 572 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.11 | 308 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.52 | 28 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 41 | 243902.44 | 3.11 | 20 KB | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 4.81 | 0 B | ✅ |
| Batch | Delete | 10,000 | 42 | 238095.24 | 3.06 | 0 B | ✅ |
| Batch | Delete | 10,000 | 43 | 232558.14 | 3.01 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 3.25 | 0 B | ✅ |
| Batch | Insert | 10,000 | 565 | 17699.12 | 4.14 | 2.21 MB | ✅ |
| Batch | Insert | 10,000 | 560 | 17857.14 | 4.18 | 3.53 MB | ✅ |
| Batch | Insert | 10,000 | 563 | 17761.99 | 4.16 | 4.89 MB | ✅ |
| Batch | Insert | 10,000 | 553 | 18083.18 | 4.00 | 1.04 MB | ✅ |
| Batch | Insert | 10,000 | 559 | 17889.09 | 4.19 | 3.36 MB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 7.94 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.92 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 7.80 | 4 KB | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.08 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.95 | 4 KB | ✅ |
| Batch | Update | 10,000 | 661 | 15128.59 | 4.04 | 496 KB | ✅ |
| Batch | Update | 10,000 | 660 | 15151.52 | 4.14 | 212 KB | ✅ |
| Batch | Update | 10,000 | 666 | 15015.02 | 4.10 | 276 KB | ✅ |
| Batch | Update | 10,000 | 645 | 15503.88 | 4.13 | 212 KB | ✅ |
| Batch | Update | 10,000 | 656 | 15243.90 | 4.16 | 220 KB | ✅ |
| Single | Delete | 1,000 | 2,224 | 449.64 | 2.49 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,246 | 445.24 | 3.27 | 964 KB | ✅ |
| Single | Delete | 1,000 | 2,143 | 466.64 | 3.52 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,126 | 470.37 | 3.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,139 | 467.51 | 2.46 | 2.99 MB | ✅ |
| Single | Insert | 1,000 | 2,228 | 448.83 | 3.07 | 292 KB | ✅ |
| Single | Insert | 1,000 | 2,142 | 466.85 | 3.34 | 128 KB | ✅ |
| Single | Insert | 1,000 | 2,202 | 454.13 | 3.87 | 6.43 MB | ✅ |
| Single | Insert | 1,000 | 2,182 | 458.30 | 3.52 | 2.88 MB | ✅ |
| Single | Insert | 1,000 | 2,199 | 454.75 | 2.96 | 0 B | ✅ |
| Single | Select | 1,000 | 110 | 9090.91 | 4.13 | 104 KB | ✅ |
| Single | Select | 1,000 | 115 | 8695.65 | 3.93 | 8 KB | ✅ |
| Single | Select | 1,000 | 111 | 9009.01 | 4.67 | 1.99 MB | ✅ |
| Single | Select | 1,000 | 102 | 9803.92 | 4.44 | 4 KB | ✅ |
| Single | Select | 1,000 | 112 | 8928.57 | 4.06 | 4 KB | ✅ |
| Single | Update | 1,000 | 2,194 | 455.79 | 3.20 | 192 KB | ✅ |
| Single | Update | 1,000 | 2,194 | 455.79 | 3.83 | 0 B | ✅ |
| Single | Update | 1,000 | 2,196 | 455.37 | 2.82 | 4.87 MB | ✅ |
| Single | Update | 1,000 | 2,223 | 449.84 | 3.84 | 3.01 MB | ✅ |
| Single | Update | 1,000 | 2,179 | 458.93 | 2.99 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 11 | 90.91 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.40 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 16 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 4.34 | 332 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.35 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 64 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.71 | 2.04 MB | ✅ |
| Batch | Delete | 10,000 | 281 | 35587.19 | 0.23 | 248 KB | ✅ |
| Batch | Delete | 10,000 | 276 | 36231.88 | 0.24 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 303 | 33003.30 | 0.21 | 180 KB | ✅ |
| Batch | Delete | 10,000 | 276 | 36231.88 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 276 | 36231.88 | 0.47 | 0 B | ✅ |
| Batch | Insert | 10,000 | 4,939 | 2024.70 | 0.04 | 3.84 MB | ✅ |
| Batch | Insert | 10,000 | 4,765 | 2098.64 | 0.08 | 6.03 MB | ✅ |
| Batch | Insert | 10,000 | 4,776 | 2093.80 | 0.08 | 3.7 MB | ✅ |
| Batch | Insert | 10,000 | 4,784 | 2090.30 | 0.08 | 3.94 MB | ✅ |
| Batch | Insert | 10,000 | 4,819 | 2075.12 | 0.07 | 2 MB | ✅ |
| Batch | Select | 10,000 | 27 | 370370.37 | 7.22 | 1.2 MB | ✅ |
| Batch | Select | 10,000 | 29 | 344827.59 | 4.35 | 12 KB | ✅ |
| Batch | Select | 10,000 | 30 | 333333.33 | 4.27 | 440 KB | ✅ |
| Batch | Select | 10,000 | 34 | 294117.65 | 3.78 | 0 B | ✅ |
| Batch | Select | 10,000 | 33 | 303030.30 | 3.88 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,502 | 1817.52 | 0.12 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,476 | 1826.15 | 0.08 | 1.05 MB | ✅ |
| Batch | Update | 10,000 | 5,459 | 1831.84 | 0.06 | 2.12 MB | ✅ |
| Batch | Update | 10,000 | 5,519 | 1811.92 | 0.12 | 1.93 MB | ✅ |
| Batch | Update | 10,000 | 5,646 | 1771.17 | 0.12 | 1.51 MB | ✅ |
| Single | Delete | 1,000 | 1,557 | 642.26 | 0.54 | 1.23 MB | ✅ |
| Single | Delete | 1,000 | 1,508 | 663.13 | 0.39 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,488 | 672.04 | 0.39 | 1.18 MB | ✅ |
| Single | Delete | 1,000 | 1,493 | 669.79 | 0.48 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,660 | 602.41 | 0.55 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,449 | 690.13 | 0.58 | 1.07 MB | ✅ |
| Single | Insert | 1,000 | 1,434 | 697.35 | 0.50 | 7.07 MB | ✅ |
| Single | Insert | 1,000 | 1,451 | 689.18 | 0.27 | 4.97 MB | ✅ |
| Single | Insert | 1,000 | 1,394 | 717.36 | 0.70 | 6.81 MB | ✅ |
| Single | Insert | 1,000 | 1,501 | 666.22 | 0.43 | 28 KB | ✅ |
| Single | Select | 1,000 | 1,020 | 980.39 | 0.77 | 164 KB | ✅ |
| Single | Select | 1,000 | 931 | 1074.11 | 0.49 | 3.98 MB | ✅ |
| Single | Select | 1,000 | 929 | 1076.43 | 0.98 | 7.01 MB | ✅ |
| Single | Select | 1,000 | 921 | 1085.78 | 0.78 | 3 MB | ✅ |
| Single | Select | 1,000 | 954 | 1048.22 | 0.82 | 0 B | ✅ |
| Single | Update | 1,000 | 2,584 | 387.00 | 0.40 | 4.04 MB | ✅ |
| Single | Update | 1,000 | 2,341 | 427.17 | 0.19 | 7.62 MB | ✅ |
| Single | Update | 1,000 | 2,341 | 427.17 | 0.39 | 4 MB | ✅ |
| Single | Update | 1,000 | 2,391 | 418.24 | 0.27 | 3 MB | ✅ |
| Single | Update | 1,000 | 2,405 | 415.80 | 0.22 | 32 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 4.43 | 1.98 | 5.21 | 2.22 | 1.08 |
| Aggregation | Statistics | 3.53 | 4.38 | 1.07 | 2.13 | 3.08 |
| Batch | Delete | 1.57 | 0.76 | 0.39 | 3.45 | 0.23 |
| Batch | Insert | 2.47 | 2.91 | 0.89 | 4.13 | 0.07 |
| Batch | Select | 3.52 | 1.75 | 1.80 | 5.54 | 4.70 |
| Batch | Update | 1.32 | 2.68 | 0.87 | 4.11 | 0.10 |
| Single | Delete | 1.49 | 0.57 | 1.12 | 3.03 | 0.47 |
| Single | Insert | 1.73 | 0.73 | 1.10 | 3.35 | 0.50 |
| Single | Select | 2.42 | 2.29 | 3.21 | 4.25 | 0.77 |
| Single | Update | 1.89 | 0.56 | 0.97 | 3.34 | 0.29 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 36 KB | 212 KB | 48 KB | 572 KB | 60 KB |
| Aggregation | Statistics | 636 KB | 708 KB | 20 KB | 308 KB | 2.04 MB |
| Batch | Delete | 1.93 MB | 5.68 MB | 16 KB | 20 KB | 248 KB |
| Batch | Insert | 0 B | 12.16 MB | 5.05 MB | 4.89 MB | 6.03 MB |
| Batch | Select | 2.13 MB | 532 KB | 3.51 MB | 4 KB | 1.2 MB |
| Batch | Update | 5.86 MB | 5.75 MB | 516 KB | 496 KB | 2.12 MB |
| Single | Delete | 7.38 MB | 3.02 MB | 0 B | 2.99 MB | 1.23 MB |
| Single | Insert | 11.63 MB | 7.27 MB | 996 KB | 6.43 MB | 7.07 MB |
| Single | Select | 9.55 MB | 4.6 MB | 52 KB | 1.99 MB | 7.01 MB |
| Single | Update | 1.28 MB | 4.8 MB | 40 KB | 4.87 MB | 7.62 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251209.log` 文件。

---

*报告生成时间: 2025-12-09 12:23:47*
