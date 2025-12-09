# 数据库基准测试报告

**测试时间**: 2025-12-09 09:22:18

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
| 采集时间 | 2025-12-09 09:22:18 |


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
| Aggregation | GroupBy | 8.80 | 10.40 | 3.20 | 4.00 | 18.80 | **PostgreSQL** |
| Aggregation | Statistics | 13.20 | 19.20 | 12.00 | 9.60 | 15.40 | **SQLite** |
| Batch | Delete | 118.20 | 291.20 | 53.20 | 39.40 | 490.20 | **SQLite** |
| Batch | Insert | 93.80 | 698.60 | 384.40 | 551.60 | 13597.00 | **MongoDB** |
| Batch | Select | 62.60 | 48.60 | 30.60 | 16.20 | 48.20 | **SQLite** |
| Batch | Update | 548.00 | 990.00 | 733.00 | 651.40 | 14405.80 | **MongoDB** |
| Single | Delete | 387.60 | 6062.00 | 726.60 | 2024.20 | 1330.60 | **MongoDB** |
| Single | Insert | 282.80 | 3588.80 | 903.00 | 2037.80 | 1635.80 | **MongoDB** |
| Single | Select | 398.00 | 827.20 | 315.40 | 94.40 | 745.00 | **SQLite** |
| Single | Update | 432.40 | 5318.60 | 803.60 | 2056.40 | 2409.80 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 113.89 | 101.39 | 316.66 | 263.33 | 53.54 | **PostgreSQL** |
| Aggregation | Statistics | 80.74 | 353.33 | 507.11 | 629.09 | 394.59 | **SQLite** |
| Batch | Delete | 84764.67 | 59970.50 | 188275.31 | 254628.26 | 20451.58 | **SQLite** |
| Batch | Insert | 107163.21 | 17916.34 | 26035.39 | 18134.58 | 752.73 | **MongoDB** |
| Batch | Select | 160391.62 | 205816.32 | 328953.40 | 619444.45 | 207519.18 | **SQLite** |
| Batch | Update | 18256.50 | 12216.65 | 13643.75 | 15373.65 | 695.51 | **MongoDB** |
| Single | Delete | 2581.43 | 298.24 | 1376.84 | 494.24 | 928.96 | **MongoDB** |
| Single | Insert | 3541.01 | 319.16 | 1164.15 | 490.79 | 895.07 | **MongoDB** |
| Single | Select | 2531.19 | 1209.11 | 3171.17 | 10600.95 | 1345.27 | **SQLite** |
| Single | Update | 2321.65 | 293.03 | 1245.00 | 486.34 | 446.44 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 36 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 8 | 125.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 21 | 47.62 | 0.00 | 620 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 5.57 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 83.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 117 | 85470.09 | 1.11 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 120 | 83333.33 | 0.54 | 60 KB | ✅ |
| Batch | Delete | 10,000 | 126 | 79365.08 | 1.03 | 176 KB | ✅ |
| Batch | Delete | 10,000 | 110 | 90909.09 | 1.18 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 118 | 84745.76 | 1.10 | 1.49 MB | ✅ |
| Batch | Insert | 10,000 | 108 | 92592.59 | 0.60 | 7.51 MB | ✅ |
| Batch | Insert | 10,000 | 90 | 111111.11 | 2.16 | 6.38 MB | ✅ |
| Batch | Insert | 10,000 | 90 | 111111.11 | 1.44 | 6.41 MB | ✅ |
| Batch | Insert | 10,000 | 91 | 109890.11 | 0.71 | 6.38 MB | ✅ |
| Batch | Insert | 10,000 | 90 | 111111.11 | 0.72 | 0 B | ✅ |
| Batch | Select | 10,000 | 70 | 142857.14 | 0.92 | 2.15 MB | ✅ |
| Batch | Select | 10,000 | 62 | 161290.32 | 2.08 | 2.13 MB | ✅ |
| Batch | Select | 10,000 | 58 | 172413.79 | 0.00 | 2.13 MB | ✅ |
| Batch | Select | 10,000 | 63 | 158730.16 | 3.08 | 2.13 MB | ✅ |
| Batch | Select | 10,000 | 60 | 166666.67 | 2.15 | 2.06 MB | ✅ |
| Batch | Update | 10,000 | 566 | 17667.84 | 1.03 | 2.11 MB | ✅ |
| Batch | Update | 10,000 | 534 | 18726.59 | 0.49 | 1.89 MB | ✅ |
| Batch | Update | 10,000 | 540 | 18518.52 | 0.24 | 4.08 MB | ✅ |
| Batch | Update | 10,000 | 543 | 18416.21 | 0.84 | 2.29 MB | ✅ |
| Batch | Update | 10,000 | 557 | 17953.32 | 0.35 | 1.87 MB | ✅ |
| Single | Delete | 1,000 | 403 | 2481.39 | 3.39 | 2.88 MB | ✅ |
| Single | Delete | 1,000 | 379 | 2638.52 | 1.89 | 0 B | ✅ |
| Single | Delete | 1,000 | 384 | 2604.17 | 1.86 | 0 B | ✅ |
| Single | Delete | 1,000 | 393 | 2544.53 | 2.98 | 1.08 MB | ✅ |
| Single | Delete | 1,000 | 379 | 2638.52 | 2.23 | 0 B | ✅ |
| Single | Insert | 1,000 | 304 | 3289.47 | 2.99 | 11.07 MB | ✅ |
| Single | Insert | 1,000 | 278 | 3597.12 | 1.87 | 10.19 MB | ✅ |
| Single | Insert | 1,000 | 274 | 3649.64 | 1.19 | 10.02 MB | ✅ |
| Single | Insert | 1,000 | 281 | 3558.72 | 1.16 | 10.03 MB | ✅ |
| Single | Insert | 1,000 | 277 | 3610.11 | 1.88 | 10.03 MB | ✅ |
| Single | Select | 1,000 | 464 | 2155.17 | 4.49 | 4.66 MB | ✅ |
| Single | Select | 1,000 | 392 | 2551.02 | 1.66 | 1.47 MB | ✅ |
| Single | Select | 1,000 | 369 | 2710.03 | 1.94 | 1.43 MB | ✅ |
| Single | Select | 1,000 | 400 | 2500.00 | 1.79 | 1.46 MB | ✅ |
| Single | Select | 1,000 | 365 | 2739.73 | 2.14 | 1.45 MB | ✅ |
| Single | Update | 1,000 | 481 | 2079.00 | 4.19 | 9.76 MB | ✅ |
| Single | Update | 1,000 | 411 | 2433.09 | 3.32 | 6.96 MB | ✅ |
| Single | Update | 1,000 | 443 | 2257.34 | 2.79 | 6.7 MB | ✅ |
| Single | Update | 1,000 | 422 | 2369.67 | 2.31 | 7.02 MB | ✅ |
| Single | Update | 1,000 | 405 | 2469.14 | 1.76 | 7.02 MB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 16 | 62.50 | 0.00 | 212 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 76 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 36 | 166.67 | 3.53 | 700 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 148 | 67567.57 | 1.32 | 140 KB | ✅ |
| Batch | Delete | 10,000 | 132 | 75757.58 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 130 | 76923.08 | 0.50 | 36 KB | ✅ |
| Batch | Delete | 10,000 | 146 | 68493.15 | 0.44 | 36 KB | ✅ |
| Batch | Delete | 10,000 | 900 | 11111.11 | 0.22 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 480 | 20833.33 | 3.25 | 7.86 MB | ✅ |
| Batch | Insert | 10,000 | 486 | 20576.13 | 2.54 | 7.51 MB | ✅ |
| Batch | Insert | 10,000 | 473 | 21141.65 | 2.34 | 7.48 MB | ✅ |
| Batch | Insert | 10,000 | 484 | 20661.16 | 2.68 | 5.21 MB | ✅ |
| Batch | Insert | 10,000 | 1,570 | 6369.43 | 0.75 | 6.4 MB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 1.34 | 8 KB | ✅ |
| Batch | Select | 10,000 | 49 | 204081.63 | 3.95 | 100 KB | ✅ |
| Batch | Select | 10,000 | 50 | 200000.00 | 0.00 | 12 KB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 0.00 | 20 KB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 5.36 | 0 B | ✅ |
| Batch | Update | 10,000 | 698 | 14326.65 | 1.96 | 4.66 MB | ✅ |
| Batch | Update | 10,000 | 751 | 13315.58 | 2.16 | 824 KB | ✅ |
| Batch | Update | 10,000 | 694 | 14409.22 | 1.59 | 4.45 MB | ✅ |
| Batch | Update | 10,000 | 700 | 14285.71 | 1.58 | 4.84 MB | ✅ |
| Batch | Update | 10,000 | 2,107 | 4746.08 | 0.62 | 4.07 MB | ✅ |
| Single | Delete | 1,000 | 3,220 | 310.56 | 0.34 | 2.19 MB | ✅ |
| Single | Delete | 1,000 | 2,650 | 377.36 | 0.20 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,638 | 379.08 | 0.47 | 56 KB | ✅ |
| Single | Delete | 1,000 | 2,689 | 371.89 | 0.65 | 0 B | ✅ |
| Single | Delete | 1,000 | 19,113 | 52.32 | 0.07 | 140 KB | ✅ |
| Single | Insert | 1,000 | 6,918 | 144.55 | 0.28 | 4.7 MB | ✅ |
| Single | Insert | 1,000 | 2,715 | 368.32 | 0.77 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,775 | 360.36 | 0.61 | 16 KB | ✅ |
| Single | Insert | 1,000 | 2,773 | 360.62 | 0.47 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,763 | 361.93 | 0.38 | 916 KB | ✅ |
| Single | Select | 1,000 | 815 | 1226.99 | 1.76 | 3 MB | ✅ |
| Single | Select | 1,000 | 835 | 1197.60 | 1.79 | 100 KB | ✅ |
| Single | Select | 1,000 | 813 | 1230.01 | 1.52 | 0 B | ✅ |
| Single | Select | 1,000 | 840 | 1190.48 | 1.32 | 0 B | ✅ |
| Single | Select | 1,000 | 833 | 1200.48 | 2.11 | 0 B | ✅ |
| Single | Update | 1,000 | 2,854 | 350.39 | 0.46 | 2.91 MB | ✅ |
| Single | Update | 1,000 | 2,885 | 346.62 | 0.41 | 0 B | ✅ |
| Single | Update | 1,000 | 2,834 | 352.86 | 0.51 | 0 B | ✅ |
| Single | Update | 1,000 | 2,863 | 349.28 | 0.45 | 100 KB | ✅ |
| Single | Update | 1,000 | 15,157 | 65.98 | 0.15 | 492 KB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 36 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.83 | 24 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 55 | 181818.18 | 1.17 | 28 KB | ✅ |
| Batch | Delete | 10,000 | 52 | 192307.69 | 2.47 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 50 | 200000.00 | 0.00 | 2.55 MB | ✅ |
| Batch | Delete | 10,000 | 53 | 188679.25 | 0.00 | 2.55 MB | ✅ |
| Batch | Delete | 10,000 | 56 | 178571.43 | 0.00 | 16 KB | ✅ |
| Batch | Insert | 10,000 | 403 | 24813.90 | 2.10 | 8.12 MB | ✅ |
| Batch | Insert | 10,000 | 391 | 25575.45 | 2.16 | 6.97 MB | ✅ |
| Batch | Insert | 10,000 | 375 | 26666.67 | 2.43 | 6.95 MB | ✅ |
| Batch | Insert | 10,000 | 376 | 26595.74 | 2.07 | 7.49 MB | ✅ |
| Batch | Insert | 10,000 | 377 | 26525.20 | 2.41 | 6.86 MB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 0.00 | 2.16 MB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 4.51 | 2.55 MB | ✅ |
| Batch | Select | 10,000 | 30 | 333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 33 | 303030.30 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 34 | 294117.65 | 3.73 | 0 B | ✅ |
| Batch | Update | 10,000 | 741 | 13495.28 | 1.49 | 3.32 MB | ✅ |
| Batch | Update | 10,000 | 729 | 13717.42 | 1.34 | 304 KB | ✅ |
| Batch | Update | 10,000 | 724 | 13812.15 | 1.35 | 5.38 MB | ✅ |
| Batch | Update | 10,000 | 730 | 13698.63 | 1.34 | 5.38 MB | ✅ |
| Batch | Update | 10,000 | 741 | 13495.28 | 1.14 | 5.43 MB | ✅ |
| Single | Delete | 1,000 | 739 | 1353.18 | 1.14 | 0 B | ✅ |
| Single | Delete | 1,000 | 747 | 1338.69 | 1.22 | 4 KB | ✅ |
| Single | Delete | 1,000 | 718 | 1392.76 | 1.18 | 0 B | ✅ |
| Single | Delete | 1,000 | 706 | 1416.43 | 1.20 | 0 B | ✅ |
| Single | Delete | 1,000 | 723 | 1383.13 | 0.81 | 0 B | ✅ |
| Single | Insert | 1,000 | 826 | 1210.65 | 0.55 | 3.88 MB | ✅ |
| Single | Insert | 1,000 | 764 | 1308.90 | 0.85 | 88 KB | ✅ |
| Single | Insert | 1,000 | 774 | 1291.99 | 1.09 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,369 | 730.46 | 0.43 | 148 KB | ✅ |
| Single | Insert | 1,000 | 782 | 1278.77 | 0.42 | 136 KB | ✅ |
| Single | Select | 1,000 | 324 | 3086.42 | 2.81 | 8 KB | ✅ |
| Single | Select | 1,000 | 312 | 3205.13 | 2.08 | 0 B | ✅ |
| Single | Select | 1,000 | 314 | 3184.71 | 2.69 | 0 B | ✅ |
| Single | Select | 1,000 | 314 | 3184.71 | 1.86 | 0 B | ✅ |
| Single | Select | 1,000 | 313 | 3194.89 | 1.87 | 0 B | ✅ |
| Single | Update | 1,000 | 812 | 1231.53 | 1.04 | 32 KB | ✅ |
| Single | Update | 1,000 | 790 | 1265.82 | 1.40 | 0 B | ✅ |
| Single | Update | 1,000 | 835 | 1197.60 | 1.01 | 0 B | ✅ |
| Single | Update | 1,000 | 788 | 1269.04 | 1.16 | 0 B | ✅ |
| Single | Update | 1,000 | 793 | 1261.03 | 0.90 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 744 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 35.54 | 532 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.84 | 280 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 504 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.63 | 312 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.76 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.74 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.63 | 936 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.20 | 0 B | ✅ |
| Batch | Delete | 10,000 | 42 | 238095.24 | 1.53 | 0 B | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 3.47 | 0 B | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 6.99 | 0 B | ✅ |
| Batch | Delete | 10,000 | 39 | 256410.26 | 8.35 | 140 KB | ✅ |
| Batch | Delete | 10,000 | 42 | 238095.24 | 3.06 | 0 B | ✅ |
| Batch | Insert | 10,000 | 560 | 17857.14 | 4.30 | 7.16 MB | ✅ |
| Batch | Insert | 10,000 | 545 | 18348.62 | 4.30 | 764 KB | ✅ |
| Batch | Insert | 10,000 | 546 | 18315.02 | 4.17 | 0 B | ✅ |
| Batch | Insert | 10,000 | 541 | 18484.29 | 4.21 | 0 B | ✅ |
| Batch | Insert | 10,000 | 566 | 17667.84 | 3.91 | 4.88 MB | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.13 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.06 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.04 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 18 | 555555.56 | 3.53 | 0 B | ✅ |
| Batch | Update | 10,000 | 638 | 15673.98 | 4.08 | 892 KB | ✅ |
| Batch | Update | 10,000 | 637 | 15698.59 | 4.08 | 452 KB | ✅ |
| Batch | Update | 10,000 | 637 | 15698.59 | 4.49 | 524 KB | ✅ |
| Batch | Update | 10,000 | 643 | 15552.10 | 4.15 | 3.86 MB | ✅ |
| Batch | Update | 10,000 | 702 | 14245.01 | 3.80 | 312 KB | ✅ |
| Single | Delete | 1,000 | 1,977 | 505.82 | 3.03 | 8 KB | ✅ |
| Single | Delete | 1,000 | 1,990 | 502.51 | 2.94 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,055 | 486.62 | 3.33 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,007 | 498.26 | 3.44 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,092 | 478.01 | 3.39 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,017 | 495.79 | 3.10 | 11.29 MB | ✅ |
| Single | Insert | 1,000 | 2,029 | 492.85 | 3.24 | 8.88 MB | ✅ |
| Single | Insert | 1,000 | 2,012 | 497.02 | 3.11 | 4 KB | ✅ |
| Single | Insert | 1,000 | 2,057 | 486.14 | 3.45 | 12 KB | ✅ |
| Single | Insert | 1,000 | 2,074 | 482.16 | 3.14 | 6.15 MB | ✅ |
| Single | Select | 1,000 | 99 | 10101.01 | 3.93 | 2.05 MB | ✅ |
| Single | Select | 1,000 | 95 | 10526.32 | 4.10 | 6.62 MB | ✅ |
| Single | Select | 1,000 | 94 | 10638.30 | 4.12 | 4 KB | ✅ |
| Single | Select | 1,000 | 92 | 10869.57 | 4.24 | 4 KB | ✅ |
| Single | Select | 1,000 | 92 | 10869.57 | 4.20 | 1.98 MB | ✅ |
| Single | Update | 1,000 | 2,086 | 479.39 | 3.40 | 3.18 MB | ✅ |
| Single | Update | 1,000 | 2,060 | 485.44 | 2.75 | 3.02 MB | ✅ |
| Single | Update | 1,000 | 2,021 | 494.80 | 3.09 | 0 B | ✅ |
| Single | Update | 1,000 | 2,063 | 484.73 | 2.65 | 0 B | ✅ |
| Single | Update | 1,000 | 2,052 | 487.33 | 2.85 | 3.41 MB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 22 | 45.45 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 3.54 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 10,000 | 19 | 315.79 | 0.00 | 944 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 4.40 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 0.00 | 1.99 MB | ✅ |
| Batch | Delete | 10,000 | 519 | 19267.82 | 0.25 | 192 KB | ✅ |
| Batch | Delete | 10,000 | 487 | 20533.88 | 0.13 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 466 | 21459.23 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 518 | 19305.02 | 0.13 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 461 | 21691.97 | 0.00 | 52 KB | ✅ |
| Batch | Insert | 10,000 | 18,060 | 553.71 | 0.03 | 2.95 MB | ✅ |
| Batch | Insert | 10,000 | 13,363 | 748.33 | 0.07 | 3.28 MB | ✅ |
| Batch | Insert | 10,000 | 12,232 | 817.53 | 0.05 | 3.01 MB | ✅ |
| Batch | Insert | 10,000 | 12,118 | 825.22 | 0.05 | 3.28 MB | ✅ |
| Batch | Insert | 10,000 | 12,212 | 818.87 | 0.04 | 5.54 MB | ✅ |
| Batch | Select | 10,000 | 49 | 204081.63 | 1.32 | 36 KB | ✅ |
| Batch | Select | 10,000 | 49 | 204081.63 | 3.94 | 1.2 MB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 0.00 | 192 KB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 5.39 | 0 B | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 2.74 | 0 B | ✅ |
| Batch | Update | 10,000 | 14,097 | 709.37 | 0.04 | 0 B | ✅ |
| Batch | Update | 10,000 | 14,090 | 709.72 | 0.10 | 1.05 MB | ✅ |
| Batch | Update | 10,000 | 13,962 | 716.23 | 0.03 | 2.01 MB | ✅ |
| Batch | Update | 10,000 | 14,175 | 705.47 | 0.06 | 1.13 MB | ✅ |
| Batch | Update | 10,000 | 15,705 | 636.74 | 0.06 | 968 KB | ✅ |
| Single | Delete | 1,000 | 2,934 | 340.83 | 0.09 | 492 KB | ✅ |
| Single | Delete | 1,000 | 959 | 1042.75 | 0.61 | 0 B | ✅ |
| Single | Delete | 1,000 | 907 | 1102.54 | 0.86 | 0 B | ✅ |
| Single | Delete | 1,000 | 924 | 1082.25 | 0.49 | 0 B | ✅ |
| Single | Delete | 1,000 | 929 | 1076.43 | 0.98 | 1.25 MB | ✅ |
| Single | Insert | 1,000 | 4,408 | 226.86 | 0.12 | 112 KB | ✅ |
| Single | Insert | 1,000 | 919 | 1088.14 | 0.42 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,003 | 997.01 | 0.58 | 1.64 MB | ✅ |
| Single | Insert | 1,000 | 927 | 1078.75 | 0.91 | 36 KB | ✅ |
| Single | Insert | 1,000 | 922 | 1084.60 | 1.27 | 4.95 MB | ✅ |
| Single | Select | 1,000 | 811 | 1233.05 | 0.48 | 216 KB | ✅ |
| Single | Select | 1,000 | 705 | 1418.44 | 0.18 | 0 B | ✅ |
| Single | Select | 1,000 | 744 | 1344.09 | 0.26 | 48 KB | ✅ |
| Single | Select | 1,000 | 741 | 1349.53 | 0.79 | 52 KB | ✅ |
| Single | Select | 1,000 | 724 | 1381.22 | 0.63 | 7 MB | ✅ |
| Single | Update | 1,000 | 3,969 | 251.95 | 0.21 | 0 B | ✅ |
| Single | Update | 1,000 | 2,010 | 497.51 | 0.29 | 0 B | ✅ |
| Single | Update | 1,000 | 2,017 | 495.79 | 0.48 | 0 B | ✅ |
| Single | Update | 1,000 | 2,038 | 490.68 | 0.19 | 0 B | ✅ |
| Single | Update | 1,000 | 2,015 | 496.28 | 0.36 | 4.11 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 0.00 | 0.00 | 0.00 | 10.68 | 0.71 |
| Aggregation | Statistics | 1.11 | 0.71 | 0.97 | 6.39 | 0.88 |
| Batch | Delete | 0.99 | 0.50 | 0.73 | 4.68 | 0.10 |
| Batch | Insert | 1.13 | 2.31 | 2.23 | 4.18 | 0.05 |
| Batch | Select | 1.65 | 2.13 | 1.65 | 3.95 | 2.68 |
| Batch | Update | 0.59 | 1.58 | 1.33 | 4.12 | 0.06 |
| Single | Delete | 2.47 | 0.35 | 1.11 | 3.23 | 0.61 |
| Single | Insert | 1.82 | 0.50 | 0.67 | 3.21 | 0.66 |
| Single | Select | 2.40 | 1.70 | 2.26 | 4.12 | 0.47 |
| Single | Update | 2.87 | 0.40 | 1.10 | 2.95 | 0.31 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 36 KB | 212 KB | 60 KB | 744 KB | 60 KB |
| Aggregation | Statistics | 620 KB | 700 KB | 24 KB | 936 KB | 1.99 MB |
| Batch | Delete | 1.49 MB | 140 KB | 2.55 MB | 140 KB | 192 KB |
| Batch | Insert | 7.51 MB | 7.86 MB | 8.12 MB | 7.16 MB | 5.54 MB |
| Batch | Select | 2.15 MB | 100 KB | 2.55 MB | 0 B | 1.2 MB |
| Batch | Update | 4.08 MB | 4.84 MB | 5.43 MB | 3.86 MB | 2.01 MB |
| Single | Delete | 2.88 MB | 2.19 MB | 4 KB | 8 KB | 1.25 MB |
| Single | Insert | 11.07 MB | 4.7 MB | 3.88 MB | 11.29 MB | 4.95 MB |
| Single | Select | 4.66 MB | 3 MB | 8 KB | 6.62 MB | 7 MB |
| Single | Update | 9.76 MB | 2.91 MB | 32 KB | 3.41 MB | 4.11 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251209.log` 文件。

---

*报告生成时间: 2025-12-09 09:22:18*
