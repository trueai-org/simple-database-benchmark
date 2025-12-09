# 数据库基准测试报告

**测试时间**: 2025-12-09 12:41:11

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
| 采集时间 | 2025-12-09 12:41:11 |


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
| Aggregation | GroupBy | 5.20 | 8.40 | 2.00 | 3.40 | 11.40 | **PostgreSQL** |
| Aggregation | Statistics | 8.80 | 19.20 | 9.00 | 10.80 | 11.00 | **MongoDB** |
| Batch | Delete | 73.60 | 103.40 | 37.00 | 39.80 | 271.60 | **PostgreSQL** |
| Batch | Insert | 54.40 | 846.60 | 1338.40 | 553.20 | 4774.40 | **MongoDB** |
| Batch | Select | 36.40 | 57.00 | 74.00 | 15.80 | 29.60 | **SQLite** |
| Batch | Update | 253.20 | 789.00 | 1593.40 | 645.00 | 5571.40 | **MongoDB** |
| Single | Delete | 550.80 | 3449.20 | 872.00 | 2173.20 | 1468.40 | **MongoDB** |
| Single | Insert | 402.20 | 3585.00 | 913.00 | 2177.80 | 1438.80 | **MongoDB** |
| Single | Select | 529.80 | 1084.60 | 370.80 | 109.40 | 941.20 | **SQLite** |
| Single | Update | 590.00 | 3593.00 | 938.60 | 2222.00 | 2391.40 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 193.33 | 144.45 | 500.00 | 306.66 | 87.88 | **PostgreSQL** |
| Aggregation | Statistics | 126.79 | 426.40 | 688.10 | 558.18 | 554.73 | **PostgreSQL** |
| Batch | Delete | 136057.29 | 97557.70 | 270501.27 | 251532.68 | 36826.97 | **PostgreSQL** |
| Batch | Insert | 184108.68 | 13355.01 | 7515.40 | 18077.60 | 2094.53 | **MongoDB** |
| Batch | Select | 274939.60 | 182523.53 | 636306.22 | 633333.33 | 339051.04 | **PostgreSQL** |
| Batch | Update | 39655.68 | 13593.64 | 6316.68 | 15505.57 | 1795.15 | **MongoDB** |
| Single | Delete | 1815.70 | 289.94 | 1146.91 | 460.20 | 681.30 | **MongoDB** |
| Single | Insert | 2497.93 | 279.13 | 1095.40 | 459.22 | 695.42 | **MongoDB** |
| Single | Select | 1888.53 | 922.41 | 2697.67 | 9178.57 | 1062.59 | **SQLite** |
| Single | Update | 1695.30 | 278.37 | 1065.56 | 450.13 | 418.34 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 16 | 62.50 | 4.04 | 648 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 76 | 131578.95 | 0.00 | 56 KB | ✅ |
| Batch | Delete | 10,000 | 70 | 142857.14 | 0.92 | 44 KB | ✅ |
| Batch | Delete | 10,000 | 77 | 129870.13 | 0.84 | 1.8 MB | ✅ |
| Batch | Delete | 10,000 | 74 | 135135.14 | 0.88 | 36 KB | ✅ |
| Batch | Delete | 10,000 | 71 | 140845.07 | 1.83 | 412 KB | ✅ |
| Batch | Insert | 10,000 | 57 | 175438.60 | 0.00 | 16 KB | ✅ |
| Batch | Insert | 10,000 | 53 | 188679.25 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 52 | 192307.69 | 1.24 | 0 B | ✅ |
| Batch | Insert | 10,000 | 53 | 188679.25 | 2.45 | 0 B | ✅ |
| Batch | Insert | 10,000 | 57 | 175438.60 | 3.41 | 0 B | ✅ |
| Batch | Select | 10,000 | 38 | 263157.89 | 1.68 | 16 KB | ✅ |
| Batch | Select | 10,000 | 37 | 270270.27 | 5.20 | 12 KB | ✅ |
| Batch | Select | 10,000 | 36 | 277777.78 | 5.31 | 4 KB | ✅ |
| Batch | Select | 10,000 | 36 | 277777.78 | 1.79 | 24 KB | ✅ |
| Batch | Select | 10,000 | 35 | 285714.29 | 1.85 | 0 B | ✅ |
| Batch | Update | 10,000 | 254 | 39370.08 | 1.28 | 3.11 MB | ✅ |
| Batch | Update | 10,000 | 241 | 41493.78 | 0.81 | 4.01 MB | ✅ |
| Batch | Update | 10,000 | 239 | 41841.00 | 1.36 | 4.01 MB | ✅ |
| Batch | Update | 10,000 | 247 | 40485.83 | 1.58 | 4.96 MB | ✅ |
| Batch | Update | 10,000 | 285 | 35087.72 | 0.91 | 1012 KB | ✅ |
| Single | Delete | 1,000 | 557 | 1795.33 | 1.63 | 380 KB | ✅ |
| Single | Delete | 1,000 | 557 | 1795.33 | 1.28 | 232 KB | ✅ |
| Single | Delete | 1,000 | 545 | 1834.86 | 2.39 | 204 KB | ✅ |
| Single | Delete | 1,000 | 549 | 1821.49 | 2.84 | 216 KB | ✅ |
| Single | Delete | 1,000 | 546 | 1831.50 | 1.43 | 196 KB | ✅ |
| Single | Insert | 1,000 | 445 | 2247.19 | 3.95 | 1.95 MB | ✅ |
| Single | Insert | 1,000 | 377 | 2652.52 | 1.90 | 2.91 MB | ✅ |
| Single | Insert | 1,000 | 420 | 2380.95 | 1.08 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 370 | 2702.70 | 1.23 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 399 | 2506.27 | 1.63 | 2.89 MB | ✅ |
| Single | Select | 1,000 | 553 | 1808.32 | 3.76 | 1.76 MB | ✅ |
| Single | Select | 1,000 | 523 | 1912.05 | 2.11 | 292 KB | ✅ |
| Single | Select | 1,000 | 530 | 1886.79 | 2.33 | 372 KB | ✅ |
| Single | Select | 1,000 | 527 | 1897.53 | 2.84 | 280 KB | ✅ |
| Single | Select | 1,000 | 516 | 1937.98 | 2.52 | 284 KB | ✅ |
| Single | Update | 1,000 | 604 | 1655.63 | 2.91 | 1.38 MB | ✅ |
| Single | Update | 1,000 | 594 | 1683.50 | 1.75 | 140 KB | ✅ |
| Single | Update | 1,000 | 586 | 1706.48 | 2.00 | 100 KB | ✅ |
| Single | Update | 1,000 | 577 | 1733.10 | 2.93 | 184 KB | ✅ |
| Single | Update | 1,000 | 589 | 1697.79 | 1.66 | 84 KB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 220 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 192 KB | ✅ |
| Aggregation | Statistics | 10,000 | 48 | 125.00 | 4.01 | 788 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.21 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.92 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 114 | 87719.30 | 1.14 | 6.21 MB | ✅ |
| Batch | Delete | 10,000 | 110 | 90909.09 | 1.18 | 6.18 MB | ✅ |
| Batch | Delete | 10,000 | 109 | 91743.12 | 1.79 | 52 KB | ✅ |
| Batch | Delete | 10,000 | 91 | 109890.11 | 1.43 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 93 | 107526.88 | 1.39 | 16 KB | ✅ |
| Batch | Insert | 10,000 | 1,004 | 9960.16 | 2.98 | 6.82 MB | ✅ |
| Batch | Insert | 10,000 | 742 | 13477.09 | 3.51 | 4.27 MB | ✅ |
| Batch | Insert | 10,000 | 1,245 | 8032.13 | 2.72 | 7.57 MB | ✅ |
| Batch | Insert | 10,000 | 805 | 12422.36 | 2.42 | 8.39 MB | ✅ |
| Batch | Insert | 10,000 | 437 | 22883.30 | 2.98 | 7.57 MB | ✅ |
| Batch | Select | 10,000 | 63 | 158730.16 | 3.06 | 16 KB | ✅ |
| Batch | Select | 10,000 | 70 | 142857.14 | 2.76 | 4.82 MB | ✅ |
| Batch | Select | 10,000 | 64 | 156250.00 | 5.07 | 568 KB | ✅ |
| Batch | Select | 10,000 | 43 | 232558.14 | 0.00 | 32 KB | ✅ |
| Batch | Select | 10,000 | 45 | 222222.22 | 1.43 | 0 B | ✅ |
| Batch | Update | 10,000 | 1,010 | 9900.99 | 2.90 | 3 MB | ✅ |
| Batch | Update | 10,000 | 884 | 11312.22 | 3.02 | 1.23 MB | ✅ |
| Batch | Update | 10,000 | 941 | 10626.99 | 3.04 | 4.96 MB | ✅ |
| Batch | Update | 10,000 | 583 | 17152.66 | 2.57 | 1.8 MB | ✅ |
| Batch | Update | 10,000 | 527 | 18975.33 | 2.96 | 3 MB | ✅ |
| Single | Delete | 1,000 | 3,470 | 288.18 | 0.60 | 984 KB | ✅ |
| Single | Delete | 1,000 | 3,494 | 286.20 | 0.63 | 2.41 MB | ✅ |
| Single | Delete | 1,000 | 3,405 | 293.69 | 0.61 | 1.18 MB | ✅ |
| Single | Delete | 1,000 | 3,438 | 290.87 | 0.59 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,439 | 290.78 | 0.59 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,646 | 274.27 | 1.23 | 5.33 MB | ✅ |
| Single | Insert | 1,000 | 3,709 | 269.61 | 0.97 | 8.94 MB | ✅ |
| Single | Insert | 1,000 | 3,528 | 283.45 | 0.72 | 7.66 MB | ✅ |
| Single | Insert | 1,000 | 3,602 | 277.62 | 0.60 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,440 | 290.70 | 0.51 | 0 B | ✅ |
| Single | Select | 1,000 | 1,105 | 904.98 | 2.59 | 3.31 MB | ✅ |
| Single | Select | 1,000 | 1,083 | 923.36 | 2.28 | 3.89 MB | ✅ |
| Single | Select | 1,000 | 1,091 | 916.59 | 1.61 | 4.36 MB | ✅ |
| Single | Select | 1,000 | 1,102 | 907.44 | 2.30 | 0 B | ✅ |
| Single | Select | 1,000 | 1,042 | 959.69 | 1.94 | 0 B | ✅ |
| Single | Update | 1,000 | 3,643 | 274.50 | 0.43 | 0 B | ✅ |
| Single | Update | 1,000 | 3,646 | 274.27 | 0.46 | 4.69 MB | ✅ |
| Single | Update | 1,000 | 3,575 | 279.72 | 0.60 | 12 KB | ✅ |
| Single | Update | 1,000 | 3,580 | 279.33 | 0.65 | 256 KB | ✅ |
| Single | Update | 1,000 | 3,521 | 284.01 | 0.72 | 112 KB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 2 | 500.00 | 24.91 | 52 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 32 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 28 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 72 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 7.07 | 48 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 328 KB | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 1.80 | 32 KB | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 3.49 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 1.76 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 39 | 256410.26 | 1.63 | 2.64 MB | ✅ |
| Batch | Insert | 10,000 | 1,373 | 7283.32 | 0.90 | 4.8 MB | ✅ |
| Batch | Insert | 10,000 | 1,178 | 8488.96 | 1.49 | 6.89 MB | ✅ |
| Batch | Insert | 10,000 | 1,493 | 6697.92 | 0.87 | 7.04 MB | ✅ |
| Batch | Insert | 10,000 | 1,313 | 7616.15 | 0.94 | 7.29 MB | ✅ |
| Batch | Insert | 10,000 | 1,335 | 7490.64 | 1.02 | 6.84 MB | ✅ |
| Batch | Select | 10,000 | 13 | 769230.77 | 9.75 | 2.15 MB | ✅ |
| Batch | Select | 10,000 | 12 | 833333.33 | 5.02 | 2.14 MB | ✅ |
| Batch | Select | 10,000 | 12 | 833333.33 | 5.22 | 288 KB | ✅ |
| Batch | Select | 10,000 | 319 | 31347.96 | 0.20 | 288 KB | ✅ |
| Batch | Select | 10,000 | 14 | 714285.71 | 4.48 | 0 B | ✅ |
| Batch | Update | 10,000 | 1,662 | 6016.85 | 0.63 | 3.8 MB | ✅ |
| Batch | Update | 10,000 | 1,565 | 6389.78 | 0.62 | 3.7 MB | ✅ |
| Batch | Update | 10,000 | 1,371 | 7293.95 | 1.00 | 2.18 MB | ✅ |
| Batch | Update | 10,000 | 1,636 | 6112.47 | 0.60 | 616 KB | ✅ |
| Batch | Update | 10,000 | 1,733 | 5770.34 | 0.71 | 5.45 MB | ✅ |
| Single | Delete | 1,000 | 863 | 1158.75 | 1.43 | 8 KB | ✅ |
| Single | Delete | 1,000 | 871 | 1148.11 | 0.90 | 0 B | ✅ |
| Single | Delete | 1,000 | 879 | 1137.66 | 1.04 | 0 B | ✅ |
| Single | Delete | 1,000 | 862 | 1160.09 | 1.13 | 0 B | ✅ |
| Single | Delete | 1,000 | 885 | 1129.94 | 0.37 | 0 B | ✅ |
| Single | Insert | 1,000 | 905 | 1104.97 | 1.87 | 1.06 MB | ✅ |
| Single | Insert | 1,000 | 921 | 1085.78 | 0.85 | 232 KB | ✅ |
| Single | Insert | 1,000 | 916 | 1091.70 | 1.35 | 0 B | ✅ |
| Single | Insert | 1,000 | 900 | 1111.11 | 0.87 | 4 KB | ✅ |
| Single | Insert | 1,000 | 923 | 1083.42 | 0.99 | 0 B | ✅ |
| Single | Select | 1,000 | 364 | 2747.25 | 2.50 | 88 KB | ✅ |
| Single | Select | 1,000 | 381 | 2624.67 | 2.22 | 0 B | ✅ |
| Single | Select | 1,000 | 375 | 2666.67 | 2.60 | 4 KB | ✅ |
| Single | Select | 1,000 | 369 | 2710.03 | 2.82 | 0 B | ✅ |
| Single | Select | 1,000 | 365 | 2739.73 | 2.67 | 0 B | ✅ |
| Single | Update | 1,000 | 932 | 1072.96 | 1.82 | 32 KB | ✅ |
| Single | Update | 1,000 | 933 | 1071.81 | 1.40 | 0 B | ✅ |
| Single | Update | 1,000 | 959 | 1042.75 | 2.24 | 0 B | ✅ |
| Single | Update | 1,000 | 929 | 1076.43 | 2.03 | 0 B | ✅ |
| Single | Update | 1,000 | 940 | 1063.83 | 1.18 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.30 | 592 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 16.61 | 416 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.10 | 412 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.02 | 616 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.13 | 316 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.01 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.79 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.04 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 5.58 | 0 B | ✅ |
| Batch | Delete | 10,000 | 42 | 238095.24 | 3.05 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 39 | 256410.26 | 1.64 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 5.03 | 0 B | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 3.20 | 0 B | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 3.18 | 4 KB | ✅ |
| Batch | Insert | 10,000 | 559 | 17889.09 | 4.07 | 2.33 MB | ✅ |
| Batch | Insert | 10,000 | 557 | 17953.32 | 4.21 | 0 B | ✅ |
| Batch | Insert | 10,000 | 549 | 18214.94 | 4.26 | 0 B | ✅ |
| Batch | Insert | 10,000 | 550 | 18181.82 | 3.90 | 424 KB | ✅ |
| Batch | Insert | 10,000 | 551 | 18148.82 | 3.90 | 152 KB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.95 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.88 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.06 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.93 | 0 B | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.08 | 0 B | ✅ |
| Batch | Update | 10,000 | 653 | 15313.94 | 4.08 | 596 KB | ✅ |
| Batch | Update | 10,000 | 649 | 15408.32 | 4.31 | 76 KB | ✅ |
| Batch | Update | 10,000 | 641 | 15600.62 | 4.26 | 436 KB | ✅ |
| Batch | Update | 10,000 | 648 | 15432.10 | 4.22 | 144 KB | ✅ |
| Batch | Update | 10,000 | 634 | 15772.87 | 4.21 | 248 KB | ✅ |
| Single | Delete | 1,000 | 2,180 | 458.72 | 3.14 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,184 | 457.88 | 3.43 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,132 | 469.04 | 3.02 | 112 KB | ✅ |
| Single | Delete | 1,000 | 2,170 | 460.83 | 3.30 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,200 | 454.55 | 3.43 | 8 KB | ✅ |
| Single | Insert | 1,000 | 2,210 | 452.49 | 3.36 | 396 KB | ✅ |
| Single | Insert | 1,000 | 2,194 | 455.79 | 3.29 | 144 KB | ✅ |
| Single | Insert | 1,000 | 2,160 | 462.96 | 2.74 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,160 | 462.96 | 3.25 | 16 KB | ✅ |
| Single | Insert | 1,000 | 2,165 | 461.89 | 3.49 | 0 B | ✅ |
| Single | Select | 1,000 | 117 | 8547.01 | 4.42 | 96 KB | ✅ |
| Single | Select | 1,000 | 114 | 8771.93 | 4.55 | 0 B | ✅ |
| Single | Select | 1,000 | 101 | 9900.99 | 4.50 | 0 B | ✅ |
| Single | Select | 1,000 | 101 | 9900.99 | 4.51 | 4 KB | ✅ |
| Single | Select | 1,000 | 114 | 8771.93 | 3.97 | 4 KB | ✅ |
| Single | Update | 1,000 | 2,203 | 453.93 | 2.95 | 120 KB | ✅ |
| Single | Update | 1,000 | 2,254 | 443.66 | 3.84 | 920 KB | ✅ |
| Single | Update | 1,000 | 2,238 | 446.83 | 3.40 | 0 B | ✅ |
| Single | Update | 1,000 | 2,243 | 445.83 | 2.90 | 0 B | ✅ |
| Single | Update | 1,000 | 2,172 | 460.41 | 3.27 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 12 | 83.33 | 10.04 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 11 | 90.91 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 11 | 90.91 | 5.71 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 11 | 90.91 | 5.55 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.71 | 964 KB | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 17.64 | 24 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.27 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 68 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.25 | 1.98 MB | ✅ |
| Batch | Delete | 10,000 | 267 | 37453.18 | 0.24 | 32 KB | ✅ |
| Batch | Delete | 10,000 | 267 | 37453.18 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 276 | 36231.88 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 272 | 36764.71 | 0.24 | 0 B | ✅ |
| Batch | Delete | 10,000 | 276 | 36231.88 | 0.00 | 32 KB | ✅ |
| Batch | Insert | 10,000 | 4,760 | 2100.84 | 0.11 | 2.46 MB | ✅ |
| Batch | Insert | 10,000 | 4,760 | 2100.84 | 0.07 | 3.32 MB | ✅ |
| Batch | Insert | 10,000 | 4,794 | 2085.94 | 0.05 | 2.83 MB | ✅ |
| Batch | Insert | 10,000 | 4,760 | 2100.84 | 0.11 | 3.96 MB | ✅ |
| Batch | Insert | 10,000 | 4,798 | 2084.20 | 0.14 | 4.13 MB | ✅ |
| Batch | Select | 10,000 | 31 | 322580.65 | 6.15 | 8 KB | ✅ |
| Batch | Select | 10,000 | 31 | 322580.65 | 4.08 | 24 KB | ✅ |
| Batch | Select | 10,000 | 31 | 322580.65 | 2.08 | 456 KB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 4.58 | 0 B | ✅ |
| Batch | Select | 10,000 | 27 | 370370.37 | 11.80 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,477 | 1825.82 | 0.14 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,541 | 1804.73 | 0.09 | 2.15 MB | ✅ |
| Batch | Update | 10,000 | 5,633 | 1775.25 | 0.06 | 1.51 MB | ✅ |
| Batch | Update | 10,000 | 5,665 | 1765.23 | 0.09 | 348 KB | ✅ |
| Batch | Update | 10,000 | 5,541 | 1804.73 | 0.13 | 3.69 MB | ✅ |
| Single | Delete | 1,000 | 1,457 | 686.34 | 0.89 | 32 KB | ✅ |
| Single | Delete | 1,000 | 1,454 | 687.76 | 0.45 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,529 | 654.02 | 0.26 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,450 | 689.66 | 0.49 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,452 | 688.71 | 0.54 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,449 | 690.13 | 1.03 | 1.46 MB | ✅ |
| Single | Insert | 1,000 | 1,393 | 717.88 | 0.23 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,433 | 697.84 | 0.41 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,422 | 703.23 | 0.64 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,497 | 668.00 | 0.48 | 112 KB | ✅ |
| Single | Select | 1,000 | 929 | 1076.43 | 0.77 | 108 KB | ✅ |
| Single | Select | 1,000 | 949 | 1053.74 | 1.03 | 0 B | ✅ |
| Single | Select | 1,000 | 956 | 1046.03 | 1.22 | 4 KB | ✅ |
| Single | Select | 1,000 | 939 | 1064.96 | 0.76 | 0 B | ✅ |
| Single | Select | 1,000 | 933 | 1071.81 | 0.98 | 3 MB | ✅ |
| Single | Update | 1,000 | 2,478 | 403.55 | 0.55 | 0 B | ✅ |
| Single | Update | 1,000 | 2,335 | 428.27 | 0.36 | 0 B | ✅ |
| Single | Update | 1,000 | 2,411 | 414.77 | 0.35 | 0 B | ✅ |
| Single | Update | 1,000 | 2,366 | 422.65 | 0.52 | 0 B | ✅ |
| Single | Update | 1,000 | 2,367 | 422.48 | 0.33 | 3 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 0.00 | 0.00 | 4.98 | 13.61 | 4.26 |
| Aggregation | Statistics | 0.81 | 2.83 | 1.41 | 5.71 | 6.77 |
| Batch | Delete | 0.89 | 1.39 | 1.74 | 3.22 | 0.10 |
| Batch | Insert | 1.42 | 2.92 | 1.04 | 4.07 | 0.10 |
| Batch | Select | 3.17 | 2.46 | 4.93 | 3.98 | 5.74 |
| Batch | Update | 1.19 | 2.90 | 0.71 | 4.22 | 0.10 |
| Single | Delete | 1.91 | 0.60 | 0.97 | 3.26 | 0.53 |
| Single | Insert | 1.96 | 0.81 | 1.19 | 3.23 | 0.56 |
| Single | Select | 2.71 | 2.14 | 2.56 | 4.39 | 0.95 |
| Single | Update | 2.25 | 0.57 | 1.73 | 3.27 | 0.42 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 16 KB | 220 KB | 72 KB | 616 KB | 56 KB |
| Aggregation | Statistics | 648 KB | 788 KB | 328 KB | 316 KB | 1.98 MB |
| Batch | Delete | 1.8 MB | 6.21 MB | 2.64 MB | 16 KB | 32 KB |
| Batch | Insert | 16 KB | 8.39 MB | 7.29 MB | 2.33 MB | 4.13 MB |
| Batch | Select | 24 KB | 4.82 MB | 2.15 MB | 0 B | 456 KB |
| Batch | Update | 4.96 MB | 4.96 MB | 5.45 MB | 596 KB | 3.69 MB |
| Single | Delete | 380 KB | 2.41 MB | 8 KB | 112 KB | 32 KB |
| Single | Insert | 2.91 MB | 8.94 MB | 1.06 MB | 396 KB | 1.46 MB |
| Single | Select | 1.76 MB | 4.36 MB | 88 KB | 96 KB | 3 MB |
| Single | Update | 1.38 MB | 4.69 MB | 32 KB | 920 KB | 3 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251209.log` 文件。

---

*报告生成时间: 2025-12-09 12:41:11*
