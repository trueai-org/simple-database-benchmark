# 数据库基准测试报告

**测试时间**: 2025-12-08 18:21:00

## 测试结束容器状态
| CONTAINER ID | NAME             | CPU % | MEM USAGE / LIMIT     | MEM %  | NET I/O           | BLOCK I/O        | PIDS |
|--------------|------------------|-------|------------------------|--------|-------------------|------------------|------|
| 080d4f4aaa3c | bench_postgresql | 0.00% | 54.27MiB / 15.52GiB   | 0.34%  | 50.8MB / 32.6MB   | 10.8MB / 302MB   | 9    |
| effe122b9b96 | bench_mysql      | 0.23% | 421.5MiB / 15.52GiB   | 2.65%  | 41.9MB / 34.9MB   | 73.9MB / 742MB   | 38   |
| 107c7ca82e1b | bench_mongodb    | 0.09% | 137.9MiB / 15.52GiB   | 0.87%  | 29.4MB / 41.8MB   | 122MB / 34.9MB   | 43   |
| 4a38527c9e51 | bench_sqlserver  | 1.15% | 3.251GiB / 15.52GiB   | 20.95% | 144MB / 44.9MB    | 148MB / 403MB    | 321  |

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
| 采集时间 | 2025-12-08 18:21:00 |


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
| Aggregation | GroupBy | 9.20 | 10.60 | 3.20 | 3.40 | 17.80 | **PostgreSQL** |
| Aggregation | Statistics | 13.80 | 18.60 | 10.80 | 9.60 | 16.00 | **SQLite** |
| Batch | Delete | 141.40 | 207.60 | 124.00 | 37.80 | 811.40 | **SQLite** |
| Batch | Insert | 95.80 | 503.40 | 516.60 | 577.60 | 7907.00 | **MongoDB** |
| Batch | Select | 60.20 | 47.80 | 28.40 | 15.60 | 47.60 | **SQLite** |
| Batch | Update | 585.00 | 715.80 | 944.40 | 667.40 | 10188.80 | **MongoDB** |
| Single | Delete | 381.20 | 6282.80 | 1533.00 | 2056.40 | 1140.80 | **MongoDB** |
| Single | Insert | 251.60 | 4455.40 | 1557.20 | 2048.60 | 1131.20 | **MongoDB** |
| Single | Select | 390.00 | 651.40 | 318.80 | 97.60 | 984.40 | **SQLite** |
| Single | Update | 434.60 | 5344.00 | 1603.40 | 2093.60 | 2838.60 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 108.89 | 100.65 | 316.66 | 306.66 | 56.28 | **PostgreSQL** |
| Aggregation | Statistics | 78.63 | 377.05 | 572.38 | 629.09 | 388.42 | **SQLite** |
| Batch | Delete | 73625.53 | 62991.36 | 111289.54 | 265154.76 | 16370.46 | **SQLite** |
| Batch | Insert | 104983.95 | 19868.53 | 21184.71 | 17316.17 | 1264.74 | **MongoDB** |
| Batch | Select | 166138.75 | 209326.24 | 353113.55 | 641666.67 | 210507.91 | **SQLite** |
| Batch | Update | 17246.55 | 13974.07 | 10846.47 | 14983.77 | 981.49 | **MongoDB** |
| Single | Delete | 2624.45 | 318.01 | 959.19 | 486.40 | 876.66 | **MongoDB** |
| Single | Insert | 4002.70 | 321.33 | 891.17 | 488.19 | 884.55 | **MongoDB** |
| Single | Select | 2585.57 | 1535.50 | 3138.84 | 10257.40 | 1015.93 | **SQLite** |
| Single | Update | 2309.24 | 292.64 | 851.50 | 477.66 | 354.45 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 24 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 6.69 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 10 | 100.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 23 | 43.48 | 2.82 | 672 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 5.56 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 0.00 | 1004 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 90.91 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 76.92 | 4.69 | 0 B | ✅ |
| Batch | Delete | 10,000 | 132 | 75757.58 | 0.49 | 32 KB | ✅ |
| Batch | Delete | 10,000 | 112 | 89285.71 | 1.74 | 44 KB | ✅ |
| Batch | Delete | 10,000 | 166 | 60240.96 | 0.78 | 228 KB | ✅ |
| Batch | Delete | 10,000 | 113 | 88495.58 | 0.00 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 184 | 54347.83 | 1.41 | 4.01 MB | ✅ |
| Batch | Insert | 10,000 | 110 | 90909.09 | 1.18 | 0 B | ✅ |
| Batch | Insert | 10,000 | 97 | 103092.78 | 1.33 | 0 B | ✅ |
| Batch | Insert | 10,000 | 92 | 108695.65 | 1.40 | 0 B | ✅ |
| Batch | Insert | 10,000 | 90 | 111111.11 | 2.15 | 0 B | ✅ |
| Batch | Insert | 10,000 | 90 | 111111.11 | 0.72 | 0 B | ✅ |
| Batch | Select | 10,000 | 60 | 166666.67 | 2.14 | 4 KB | ✅ |
| Batch | Select | 10,000 | 61 | 163934.43 | 0.00 | 20 KB | ✅ |
| Batch | Select | 10,000 | 59 | 169491.53 | 2.19 | 0 B | ✅ |
| Batch | Select | 10,000 | 61 | 163934.43 | 2.12 | 8 KB | ✅ |
| Batch | Select | 10,000 | 60 | 166666.67 | 1.07 | 0 B | ✅ |
| Batch | Update | 10,000 | 555 | 18018.02 | 0.94 | 648 KB | ✅ |
| Batch | Update | 10,000 | 698 | 14326.65 | 0.47 | 28 KB | ✅ |
| Batch | Update | 10,000 | 578 | 17301.04 | 0.90 | 1.42 MB | ✅ |
| Batch | Update | 10,000 | 533 | 18761.73 | 0.49 | 1.29 MB | ✅ |
| Batch | Update | 10,000 | 561 | 17825.31 | 0.58 | 1012 KB | ✅ |
| Single | Delete | 1,000 | 387 | 2583.98 | 2.18 | 464 KB | ✅ |
| Single | Delete | 1,000 | 381 | 2624.67 | 1.88 | 1.11 MB | ✅ |
| Single | Delete | 1,000 | 385 | 2597.40 | 2.53 | 1.11 MB | ✅ |
| Single | Delete | 1,000 | 366 | 2732.24 | 1.96 | 72 KB | ✅ |
| Single | Delete | 1,000 | 387 | 2583.98 | 2.02 | 132 KB | ✅ |
| Single | Insert | 1,000 | 291 | 3436.43 | 3.13 | 1004 KB | ✅ |
| Single | Insert | 1,000 | 242 | 4132.23 | 2.42 | 3.12 MB | ✅ |
| Single | Insert | 1,000 | 234 | 4273.50 | 2.50 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 259 | 3861.00 | 1.25 | 2.88 MB | ✅ |
| Single | Insert | 1,000 | 232 | 4310.34 | 1.96 | 2.88 MB | ✅ |
| Single | Select | 1,000 | 459 | 2178.65 | 3.82 | 1.66 MB | ✅ |
| Single | Select | 1,000 | 379 | 2638.52 | 2.92 | 336 KB | ✅ |
| Single | Select | 1,000 | 353 | 2832.86 | 2.76 | 1.15 MB | ✅ |
| Single | Select | 1,000 | 365 | 2739.73 | 2.85 | 276 KB | ✅ |
| Single | Select | 1,000 | 394 | 2538.07 | 3.63 | 272 KB | ✅ |
| Single | Update | 1,000 | 487 | 2053.39 | 4.80 | 1.31 MB | ✅ |
| Single | Update | 1,000 | 432 | 2314.81 | 3.01 | 628 KB | ✅ |
| Single | Update | 1,000 | 418 | 2392.34 | 2.49 | 0 B | ✅ |
| Single | Update | 1,000 | 412 | 2427.18 | 2.84 | 4 KB | ✅ |
| Single | Update | 1,000 | 424 | 2358.49 | 2.30 | 20 KB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 17 | 58.82 | 3.77 | 176 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 13.79 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 132 KB | ✅ |
| Aggregation | Statistics | 10,000 | 37 | 162.16 | 1.76 | 732 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 4.14 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.66 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 490 | 20408.16 | 1.06 | 576 KB | ✅ |
| Batch | Delete | 10,000 | 157 | 63694.27 | 0.83 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 128 | 78125.00 | 1.01 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 140 | 71428.57 | 0.93 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 123 | 81300.81 | 0.53 | 24 KB | ✅ |
| Batch | Insert | 10,000 | 498 | 20080.32 | 3.27 | 9.02 MB | ✅ |
| Batch | Insert | 10,000 | 510 | 19607.84 | 2.68 | 7.48 MB | ✅ |
| Batch | Insert | 10,000 | 513 | 19493.18 | 2.53 | 7.44 MB | ✅ |
| Batch | Insert | 10,000 | 496 | 20161.29 | 2.88 | 5.08 MB | ✅ |
| Batch | Insert | 10,000 | 500 | 20000.00 | 2.73 | 7.34 MB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 4.09 | 20 KB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 5.37 | 60 KB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 5.45 | 0 B | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 1.36 | 24 KB | ✅ |
| Batch | Select | 10,000 | 50 | 200000.00 | 2.57 | 0 B | ✅ |
| Batch | Update | 10,000 | 736 | 13586.96 | 2.12 | 4.12 MB | ✅ |
| Batch | Update | 10,000 | 708 | 14124.29 | 1.56 | 876 KB | ✅ |
| Batch | Update | 10,000 | 722 | 13850.42 | 1.89 | 4.48 MB | ✅ |
| Batch | Update | 10,000 | 708 | 14124.29 | 1.93 | 4.85 MB | ✅ |
| Batch | Update | 10,000 | 705 | 14184.40 | 2.03 | 1.01 MB | ✅ |
| Single | Delete | 1,000 | 2,595 | 385.36 | 0.48 | 4.3 MB | ✅ |
| Single | Delete | 1,000 | 2,619 | 381.83 | 0.47 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,632 | 379.94 | 0.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,529 | 395.41 | 0.51 | 0 B | ✅ |
| Single | Delete | 1,000 | 21,039 | 47.53 | 0.06 | 424 KB | ✅ |
| Single | Insert | 1,000 | 11,759 | 85.04 | 0.13 | 3.76 MB | ✅ |
| Single | Insert | 1,000 | 2,699 | 370.51 | 0.60 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,600 | 384.62 | 0.50 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,592 | 385.80 | 0.50 | 4 KB | ✅ |
| Single | Insert | 1,000 | 2,627 | 380.66 | 0.94 | 980 KB | ✅ |
| Single | Select | 1,000 | 647 | 1545.60 | 2.11 | 5.23 MB | ✅ |
| Single | Select | 1,000 | 659 | 1517.45 | 1.78 | 812 KB | ✅ |
| Single | Select | 1,000 | 636 | 1572.33 | 1.84 | 0 B | ✅ |
| Single | Select | 1,000 | 651 | 1536.10 | 2.20 | 0 B | ✅ |
| Single | Select | 1,000 | 664 | 1506.02 | 2.55 | 0 B | ✅ |
| Single | Update | 1,000 | 3,406 | 293.60 | 0.23 | 592 KB | ✅ |
| Single | Update | 1,000 | 2,755 | 362.98 | 0.52 | 92 KB | ✅ |
| Single | Update | 1,000 | 2,727 | 366.70 | 0.50 | 0 B | ✅ |
| Single | Update | 1,000 | 2,674 | 373.97 | 0.83 | 0 B | ✅ |
| Single | Update | 1,000 | 15,158 | 65.97 | 0.09 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 20.37 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 128 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 96 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 0.00 | 32 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.77 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.54 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 54 | 185185.19 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 51 | 196078.43 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 160 | 62500.00 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 179 | 55865.92 | 0.36 | 48 KB | ✅ |
| Batch | Delete | 10,000 | 176 | 56818.18 | 0.37 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 397 | 25188.92 | 2.29 | 9.16 MB | ✅ |
| Batch | Insert | 10,000 | 388 | 25773.20 | 2.01 | 8.76 MB | ✅ |
| Batch | Insert | 10,000 | 372 | 26881.72 | 2.27 | 4.83 MB | ✅ |
| Batch | Insert | 10,000 | 736 | 13586.96 | 1.24 | 9.46 MB | ✅ |
| Batch | Insert | 10,000 | 690 | 14492.75 | 1.60 | 8.69 MB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 4.64 | 0 B | ✅ |
| Batch | Select | 10,000 | 30 | 333333.33 | 0.00 | 3.01 MB | ✅ |
| Batch | Select | 10,000 | 26 | 384615.38 | 2.44 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 4.56 | 0 B | ✅ |
| Batch | Select | 10,000 | 30 | 333333.33 | 2.12 | 3 MB | ✅ |
| Batch | Update | 10,000 | 811 | 12330.46 | 1.28 | 4.39 MB | ✅ |
| Batch | Update | 10,000 | 740 | 13513.51 | 1.50 | 860 KB | ✅ |
| Batch | Update | 10,000 | 1,055 | 9478.67 | 1.48 | 644 KB | ✅ |
| Batch | Update | 10,000 | 1,077 | 9285.05 | 1.15 | 4.22 MB | ✅ |
| Batch | Update | 10,000 | 1,039 | 9624.64 | 1.06 | 920 KB | ✅ |
| Single | Delete | 1,000 | 768 | 1302.08 | 0.51 | 0 B | ✅ |
| Single | Delete | 1,000 | 734 | 1362.40 | 1.06 | 0 B | ✅ |
| Single | Delete | 1,000 | 716 | 1396.65 | 0.82 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,653 | 376.93 | 0.56 | 1.32 MB | ✅ |
| Single | Delete | 1,000 | 2,794 | 357.91 | 0.35 | 0 B | ✅ |
| Single | Insert | 1,000 | 857 | 1166.86 | 1.14 | 10.8 MB | ✅ |
| Single | Insert | 1,000 | 798 | 1253.13 | 0.82 | 10.67 MB | ✅ |
| Single | Insert | 1,000 | 776 | 1288.66 | 1.01 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,628 | 380.52 | 0.17 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,727 | 366.70 | 0.19 | 8.52 MB | ✅ |
| Single | Select | 1,000 | 307 | 3257.33 | 4.23 | 3.08 MB | ✅ |
| Single | Select | 1,000 | 317 | 3154.57 | 1.23 | 3 MB | ✅ |
| Single | Select | 1,000 | 329 | 3039.51 | 3.16 | 0 B | ✅ |
| Single | Select | 1,000 | 314 | 3184.71 | 1.24 | 8 KB | ✅ |
| Single | Select | 1,000 | 327 | 3058.10 | 3.18 | 3.83 MB | ✅ |
| Single | Update | 1,000 | 875 | 1142.86 | 1.19 | 28 KB | ✅ |
| Single | Update | 1,000 | 844 | 1184.83 | 0.31 | 0 B | ✅ |
| Single | Update | 1,000 | 835 | 1197.60 | 0.62 | 0 B | ✅ |
| Single | Update | 1,000 | 2,743 | 364.56 | 0.45 | 12 KB | ✅ |
| Single | Update | 1,000 | 2,720 | 367.65 | 0.33 | 2.23 MB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 11.78 | 788 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 500 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 416 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 408 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.60 | 656 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.74 | 308 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.05 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.56 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 7.05 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.75 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 6.75 | 0 B | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 7.08 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 1.71 | 3.28 MB | ✅ |
| Batch | Delete | 10,000 | 41 | 243902.44 | 3.11 | 3.24 MB | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 3.52 | 0 B | ✅ |
| Batch | Insert | 10,000 | 593 | 16863.41 | 4.28 | 2.36 MB | ✅ |
| Batch | Insert | 10,000 | 576 | 17361.11 | 4.29 | 3.93 MB | ✅ |
| Batch | Insert | 10,000 | 574 | 17421.60 | 4.08 | 4.09 MB | ✅ |
| Batch | Insert | 10,000 | 571 | 17513.13 | 4.10 | 4.48 MB | ✅ |
| Batch | Insert | 10,000 | 574 | 17421.60 | 4.19 | 688 KB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 8.13 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.02 | 4 KB | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.20 | 4 KB | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.14 | 0 B | ✅ |
| Batch | Update | 10,000 | 670 | 14925.37 | 4.08 | 512 KB | ✅ |
| Batch | Update | 10,000 | 665 | 15037.59 | 4.11 | 0 B | ✅ |
| Batch | Update | 10,000 | 671 | 14903.13 | 4.07 | 112 KB | ✅ |
| Batch | Update | 10,000 | 667 | 14992.50 | 4.09 | 44 KB | ✅ |
| Batch | Update | 10,000 | 664 | 15060.24 | 3.92 | 112 KB | ✅ |
| Single | Delete | 1,000 | 2,030 | 492.61 | 2.98 | 4 KB | ✅ |
| Single | Delete | 1,000 | 2,058 | 485.91 | 3.23 | 4 KB | ✅ |
| Single | Delete | 1,000 | 2,018 | 495.54 | 3.61 | 3.64 MB | ✅ |
| Single | Delete | 1,000 | 2,072 | 482.63 | 2.67 | 3.62 MB | ✅ |
| Single | Delete | 1,000 | 2,104 | 475.29 | 3.12 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,012 | 497.02 | 3.72 | 444 KB | ✅ |
| Single | Insert | 1,000 | 2,064 | 484.50 | 2.84 | 92 KB | ✅ |
| Single | Insert | 1,000 | 2,037 | 490.92 | 3.23 | 3.01 MB | ✅ |
| Single | Insert | 1,000 | 2,061 | 485.20 | 2.81 | 5.2 MB | ✅ |
| Single | Insert | 1,000 | 2,069 | 483.33 | 3.02 | 3.08 MB | ✅ |
| Single | Select | 1,000 | 100 | 10000.00 | 3.91 | 92 KB | ✅ |
| Single | Select | 1,000 | 93 | 10752.69 | 4.85 | 0 B | ✅ |
| Single | Select | 1,000 | 102 | 9803.92 | 3.80 | 5.93 MB | ✅ |
| Single | Select | 1,000 | 95 | 10526.32 | 4.07 | 5.95 MB | ✅ |
| Single | Select | 1,000 | 98 | 10204.08 | 4.62 | 9.22 MB | ✅ |
| Single | Update | 1,000 | 2,078 | 481.23 | 3.13 | 144 KB | ✅ |
| Single | Update | 1,000 | 2,105 | 475.06 | 3.12 | 0 B | ✅ |
| Single | Update | 1,000 | 2,090 | 478.47 | 3.33 | 8.38 MB | ✅ |
| Single | Update | 1,000 | 2,104 | 475.29 | 3.47 | 7.64 MB | ✅ |
| Single | Update | 1,000 | 2,091 | 478.24 | 3.08 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 19 | 52.63 | 3.26 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 17 | 58.82 | 0.00 | 176 KB | ✅ |
| Aggregation | GroupBy | 8 | 17 | 58.82 | 7.32 | 52 KB | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 3.58 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 56 KB | ✅ |
| Aggregation | Statistics | 10,000 | 21 | 285.71 | 9.27 | 468 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 84 KB | ✅ |
| Aggregation | Statistics | 10,000 | 18 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.94 | 144 KB | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 4.27 | 1.79 MB | ✅ |
| Batch | Delete | 10,000 | 529 | 18903.59 | 0.12 | 100 KB | ✅ |
| Batch | Delete | 10,000 | 523 | 19120.46 | 0.12 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1,973 | 5068.42 | 0.07 | 0 B | ✅ |
| Batch | Delete | 10,000 | 515 | 19417.48 | 0.25 | 40 KB | ✅ |
| Batch | Delete | 10,000 | 517 | 19342.36 | 0.13 | 496 KB | ✅ |
| Batch | Insert | 10,000 | 7,883 | 1268.55 | 0.12 | 1.64 MB | ✅ |
| Batch | Insert | 10,000 | 7,878 | 1269.36 | 0.05 | 1 MB | ✅ |
| Batch | Insert | 10,000 | 7,917 | 1263.10 | 0.07 | 128 KB | ✅ |
| Batch | Insert | 10,000 | 7,864 | 1271.62 | 0.06 | 1.28 MB | ✅ |
| Batch | Insert | 10,000 | 7,993 | 1251.09 | 0.07 | 792 KB | ✅ |
| Batch | Select | 10,000 | 49 | 204081.63 | 5.23 | 20 KB | ✅ |
| Batch | Select | 10,000 | 51 | 196078.43 | 0.00 | 16 KB | ✅ |
| Batch | Select | 10,000 | 45 | 222222.22 | 0.00 | 1.24 MB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 46 | 217391.30 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 10,146 | 985.61 | 0.10 | 120 KB | ✅ |
| Batch | Update | 10,000 | 10,178 | 982.51 | 0.07 | 0 B | ✅ |
| Batch | Update | 10,000 | 10,240 | 976.56 | 0.11 | 60 KB | ✅ |
| Batch | Update | 10,000 | 10,252 | 975.42 | 0.07 | 124 KB | ✅ |
| Batch | Update | 10,000 | 10,128 | 987.36 | 0.06 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,160 | 862.07 | 0.50 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,134 | 881.83 | 0.34 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,134 | 881.83 | 0.52 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,130 | 884.96 | 0.40 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,146 | 872.60 | 0.45 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,181 | 846.74 | 1.10 | 1012 KB | ✅ |
| Single | Insert | 1,000 | 1,130 | 884.96 | 0.00 | 4 KB | ✅ |
| Single | Insert | 1,000 | 1,096 | 912.41 | 0.18 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,130 | 884.96 | 0.40 | 1.65 MB | ✅ |
| Single | Insert | 1,000 | 1,119 | 893.66 | 0.41 | 52 KB | ✅ |
| Single | Select | 1,000 | 999 | 1001.00 | 0.39 | 140 KB | ✅ |
| Single | Select | 1,000 | 975 | 1025.64 | 0.53 | 0 B | ✅ |
| Single | Select | 1,000 | 981 | 1019.37 | 0.80 | 0 B | ✅ |
| Single | Select | 1,000 | 977 | 1023.54 | 0.53 | 12 KB | ✅ |
| Single | Select | 1,000 | 990 | 1010.10 | 1.05 | 1.07 MB | ✅ |
| Single | Update | 1,000 | 2,784 | 359.20 | 0.40 | 36 KB | ✅ |
| Single | Update | 1,000 | 3,296 | 303.40 | 0.30 | 0 B | ✅ |
| Single | Update | 1,000 | 2,691 | 371.61 | 0.31 | 884 KB | ✅ |
| Single | Update | 1,000 | 2,655 | 376.65 | 0.42 | 0 B | ✅ |
| Single | Update | 1,000 | 2,767 | 361.40 | 0.24 | 840 KB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 1.34 | 3.51 | 4.07 | 5.88 | 2.83 |
| Aggregation | Statistics | 2.61 | 2.11 | 2.66 | 6.43 | 3.70 |
| Batch | Delete | 0.88 | 0.87 | 0.15 | 4.43 | 0.14 |
| Batch | Insert | 1.36 | 2.82 | 1.88 | 4.19 | 0.07 |
| Batch | Select | 1.50 | 3.77 | 2.75 | 4.90 | 1.05 |
| Batch | Update | 0.68 | 1.91 | 1.29 | 4.05 | 0.08 |
| Single | Delete | 2.11 | 0.39 | 0.66 | 3.12 | 0.44 |
| Single | Insert | 2.25 | 0.53 | 0.67 | 3.12 | 0.42 |
| Single | Select | 3.20 | 2.10 | 2.61 | 4.25 | 0.66 |
| Single | Update | 3.09 | 0.43 | 0.58 | 3.23 | 0.33 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 24 KB | 176 KB | 128 KB | 788 KB | 176 KB |
| Aggregation | Statistics | 1004 KB | 732 KB | 32 KB | 308 KB | 1.79 MB |
| Batch | Delete | 4.01 MB | 576 KB | 48 KB | 3.28 MB | 496 KB |
| Batch | Insert | 0 B | 9.02 MB | 9.46 MB | 4.48 MB | 1.64 MB |
| Batch | Select | 20 KB | 60 KB | 3.51 MB | 4 KB | 1.24 MB |
| Batch | Update | 1.42 MB | 4.85 MB | 4.39 MB | 512 KB | 124 KB |
| Single | Delete | 1.11 MB | 4.3 MB | 1.32 MB | 3.64 MB | 0 B |
| Single | Insert | 3.12 MB | 3.76 MB | 10.8 MB | 5.2 MB | 1.65 MB |
| Single | Select | 1.66 MB | 5.23 MB | 3.83 MB | 9.22 MB | 1.07 MB |
| Single | Update | 1.31 MB | 592 KB | 2.23 MB | 8.38 MB | 884 KB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 18:21:00*
