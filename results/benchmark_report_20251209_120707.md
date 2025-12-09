# 数据库基准测试报告

**测试时间**: 2025-12-09 12:07:07

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
| 采集时间 | 2025-12-09 12:07:07 |


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
| Aggregation | GroupBy | 5.20 | 7.80 | 2.00 | 3.60 | 12.00 | **PostgreSQL** |
| Aggregation | Statistics | 9.40 | 16.60 | 9.20 | 10.60 | 10.60 | **PostgreSQL** |
| Batch | Delete | 74.00 | 108.00 | 37.20 | 39.40 | 274.00 | **PostgreSQL** |
| Batch | Insert | 57.00 | 549.20 | 1323.60 | 569.60 | 4950.00 | **MongoDB** |
| Batch | Select | 35.80 | 44.60 | 146.40 | 16.00 | 30.80 | **SQLite** |
| Batch | Update | 274.00 | 645.60 | 1508.20 | 663.00 | 5672.40 | **MongoDB** |
| Single | Delete | 554.80 | 3521.40 | 896.40 | 2084.00 | 1474.40 | **MongoDB** |
| Single | Insert | 400.20 | 3584.80 | 930.60 | 2149.80 | 1466.80 | **MongoDB** |
| Single | Select | 543.20 | 1051.80 | 367.60 | 102.00 | 979.20 | **SQLite** |
| Single | Update | 591.80 | 3635.60 | 946.40 | 2115.20 | 2539.60 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 193.33 | 146.67 | 500.00 | 300.00 | 83.56 | **PostgreSQL** |
| Aggregation | Statistics | 124.81 | 435.68 | 701.43 | 572.31 | 595.00 | **PostgreSQL** |
| Batch | Delete | 135386.16 | 92675.95 | 270851.37 | 254246.61 | 36554.09 | **PostgreSQL** |
| Batch | Insert | 175720.03 | 18626.24 | 7651.74 | 17561.76 | 2020.28 | **MongoDB** |
| Batch | Select | 279709.08 | 225086.75 | 337204.39 | 625000.00 | 325148.31 | **SQLite** |
| Batch | Update | 37252.93 | 15912.73 | 6732.20 | 15083.99 | 1763.00 | **MongoDB** |
| Single | Delete | 1802.94 | 284.01 | 1116.52 | 479.87 | 678.36 | **MongoDB** |
| Single | Insert | 2511.60 | 279.04 | 1076.89 | 465.27 | 682.58 | **MongoDB** |
| Single | Select | 1841.86 | 951.29 | 2720.45 | 9805.04 | 1021.75 | **SQLite** |
| Single | Update | 1690.38 | 275.08 | 1058.06 | 472.77 | 394.16 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 10.51 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 5 | 200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 19 | 52.63 | 0.00 | 668 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 8.59 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 8.95 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 142.86 | 9.05 | 0 B | ✅ |
| Batch | Delete | 10,000 | 74 | 135135.14 | 1.75 | 20 KB | ✅ |
| Batch | Delete | 10,000 | 68 | 147058.82 | 0.95 | 48 KB | ✅ |
| Batch | Delete | 10,000 | 76 | 131578.95 | 2.55 | 2.36 MB | ✅ |
| Batch | Delete | 10,000 | 76 | 131578.95 | 0.85 | 36 KB | ✅ |
| Batch | Delete | 10,000 | 76 | 131578.95 | 0.85 | 1.76 MB | ✅ |
| Batch | Insert | 10,000 | 55 | 181818.18 | 1.17 | 0 B | ✅ |
| Batch | Insert | 10,000 | 54 | 185185.19 | 2.40 | 0 B | ✅ |
| Batch | Insert | 10,000 | 59 | 169491.53 | 2.20 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 57 | 175438.60 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 60 | 166666.67 | 0.00 | 7.39 MB | ✅ |
| Batch | Select | 10,000 | 38 | 263157.89 | 1.69 | 0 B | ✅ |
| Batch | Select | 10,000 | 35 | 285714.29 | 7.40 | 48 KB | ✅ |
| Batch | Select | 10,000 | 34 | 294117.65 | 3.73 | 0 B | ✅ |
| Batch | Select | 10,000 | 36 | 277777.78 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 36 | 277777.78 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 248 | 40322.58 | 1.05 | 6.28 MB | ✅ |
| Batch | Update | 10,000 | 357 | 28011.20 | 1.09 | 4 MB | ✅ |
| Batch | Update | 10,000 | 246 | 40650.41 | 1.05 | 3.94 MB | ✅ |
| Batch | Update | 10,000 | 273 | 36630.04 | 0.95 | 960 KB | ✅ |
| Batch | Update | 10,000 | 246 | 40650.41 | 1.06 | 0 B | ✅ |
| Single | Delete | 1,000 | 544 | 1838.24 | 1.20 | 440 KB | ✅ |
| Single | Delete | 1,000 | 550 | 1818.18 | 2.25 | 52 KB | ✅ |
| Single | Delete | 1,000 | 558 | 1792.11 | 2.22 | 52 KB | ✅ |
| Single | Delete | 1,000 | 571 | 1751.31 | 1.82 | 52 KB | ✅ |
| Single | Delete | 1,000 | 551 | 1814.88 | 1.30 | 52 KB | ✅ |
| Single | Insert | 1,000 | 457 | 2188.18 | 5.27 | 12.83 MB | ✅ |
| Single | Insert | 1,000 | 398 | 2512.56 | 1.31 | 2.96 MB | ✅ |
| Single | Insert | 1,000 | 375 | 2666.67 | 0.87 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 394 | 2538.07 | 1.98 | 2.87 MB | ✅ |
| Single | Insert | 1,000 | 377 | 2652.52 | 0.86 | 2.89 MB | ✅ |
| Single | Select | 1,000 | 565 | 1769.91 | 4.14 | 4.36 MB | ✅ |
| Single | Select | 1,000 | 529 | 1890.36 | 1.35 | 220 KB | ✅ |
| Single | Select | 1,000 | 542 | 1845.02 | 2.40 | 260 KB | ✅ |
| Single | Select | 1,000 | 545 | 1834.86 | 2.51 | 256 KB | ✅ |
| Single | Select | 1,000 | 535 | 1869.16 | 3.16 | 168 KB | ✅ |
| Single | Update | 1,000 | 612 | 1633.99 | 2.66 | 4.02 MB | ✅ |
| Single | Update | 1,000 | 591 | 1692.05 | 2.20 | 20 KB | ✅ |
| Single | Update | 1,000 | 581 | 1721.17 | 2.13 | 80 KB | ✅ |
| Single | Update | 1,000 | 594 | 1683.50 | 2.30 | 92 KB | ✅ |
| Single | Update | 1,000 | 581 | 1721.17 | 2.13 | 0 B | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 15 | 66.67 | 0.00 | 152 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 10.18 | 60 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 64 KB | ✅ |
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 132 KB | ✅ |
| Aggregation | Statistics | 10,000 | 35 | 171.43 | 5.56 | 756 KB | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 5.31 | 68 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 12 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 11 | 545.45 | 0.00 | 20 KB | ✅ |
| Batch | Delete | 10,000 | 114 | 87719.30 | 1.71 | 5.26 MB | ✅ |
| Batch | Delete | 10,000 | 106 | 94339.62 | 0.00 | 20 KB | ✅ |
| Batch | Delete | 10,000 | 105 | 95238.10 | 0.00 | 28 KB | ✅ |
| Batch | Delete | 10,000 | 109 | 91743.12 | 0.60 | 1.73 MB | ✅ |
| Batch | Delete | 10,000 | 106 | 94339.62 | 0.00 | 16 KB | ✅ |
| Batch | Insert | 10,000 | 667 | 14992.50 | 2.73 | 8.45 MB | ✅ |
| Batch | Insert | 10,000 | 606 | 16501.65 | 3.65 | 7.49 MB | ✅ |
| Batch | Insert | 10,000 | 457 | 21881.84 | 3.56 | 6.84 MB | ✅ |
| Batch | Insert | 10,000 | 458 | 21834.06 | 2.70 | 8.52 MB | ✅ |
| Batch | Insert | 10,000 | 558 | 17921.15 | 2.45 | 7.51 MB | ✅ |
| Batch | Select | 10,000 | 45 | 222222.22 | 1.42 | 0 B | ✅ |
| Batch | Select | 10,000 | 43 | 232558.14 | 1.48 | 0 B | ✅ |
| Batch | Select | 10,000 | 43 | 232558.14 | 1.49 | 288 KB | ✅ |
| Batch | Select | 10,000 | 50 | 200000.00 | 3.90 | 0 B | ✅ |
| Batch | Select | 10,000 | 42 | 238095.24 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 638 | 15673.98 | 2.96 | 6.32 MB | ✅ |
| Batch | Update | 10,000 | 558 | 17921.15 | 2.33 | 3.5 MB | ✅ |
| Batch | Update | 10,000 | 583 | 17152.66 | 1.90 | 3.75 MB | ✅ |
| Batch | Update | 10,000 | 576 | 17361.11 | 2.14 | 2.36 MB | ✅ |
| Batch | Update | 10,000 | 873 | 11454.75 | 1.49 | 788 KB | ✅ |
| Single | Delete | 1,000 | 3,520 | 284.09 | 0.44 | 140 KB | ✅ |
| Single | Delete | 1,000 | 3,465 | 288.60 | 0.51 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,573 | 279.88 | 0.64 | 0 B | ✅ |
| Single | Delete | 1,000 | 3,543 | 282.25 | 0.50 | 148 KB | ✅ |
| Single | Delete | 1,000 | 3,506 | 285.23 | 0.56 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,634 | 275.18 | 1.27 | 6.36 MB | ✅ |
| Single | Insert | 1,000 | 3,512 | 284.74 | 0.85 | 2.29 MB | ✅ |
| Single | Insert | 1,000 | 3,563 | 280.66 | 0.77 | 24 KB | ✅ |
| Single | Insert | 1,000 | 3,536 | 282.81 | 0.61 | 0 B | ✅ |
| Single | Insert | 1,000 | 3,679 | 271.81 | 0.57 | 2.49 MB | ✅ |
| Single | Select | 1,000 | 1,089 | 918.27 | 2.27 | 1.46 MB | ✅ |
| Single | Select | 1,000 | 1,016 | 984.25 | 2.43 | 6.35 MB | ✅ |
| Single | Select | 1,000 | 1,034 | 967.12 | 1.70 | 12 KB | ✅ |
| Single | Select | 1,000 | 1,059 | 944.29 | 1.60 | 0 B | ✅ |
| Single | Select | 1,000 | 1,061 | 942.51 | 0.92 | 80 KB | ✅ |
| Single | Update | 1,000 | 3,660 | 273.22 | 0.66 | 0 B | ✅ |
| Single | Update | 1,000 | 3,631 | 275.41 | 0.70 | 0 B | ✅ |
| Single | Update | 1,000 | 3,603 | 277.55 | 0.61 | 96 KB | ✅ |
| Single | Update | 1,000 | 3,604 | 277.47 | 0.52 | 36 KB | ✅ |
| Single | Update | 1,000 | 3,680 | 271.74 | 0.71 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 2 | 500.00 | 22.19 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 28.05 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 2 | 500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 4.25 | 28 KB | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 10,000 | 7 | 857.14 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 7.72 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 8 | 750.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 1.79 | 28 KB | ✅ |
| Batch | Delete | 10,000 | 36 | 277777.78 | 1.77 | 52 KB | ✅ |
| Batch | Delete | 10,000 | 35 | 285714.29 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 44 | 227272.73 | 1.46 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 35 | 285714.29 | 1.83 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 1,323 | 7558.58 | 0.98 | 6.06 MB | ✅ |
| Batch | Insert | 10,000 | 1,531 | 6531.68 | 0.72 | 10.63 MB | ✅ |
| Batch | Insert | 10,000 | 1,419 | 7047.22 | 0.69 | 6.96 MB | ✅ |
| Batch | Insert | 10,000 | 1,101 | 9082.65 | 0.71 | 6.34 MB | ✅ |
| Batch | Insert | 10,000 | 1,244 | 8038.59 | 0.89 | 7 MB | ✅ |
| Batch | Select | 10,000 | 13 | 769230.77 | 4.91 | 0 B | ✅ |
| Batch | Select | 10,000 | 327 | 30581.04 | 0.20 | 0 B | ✅ |
| Batch | Select | 10,000 | 324 | 30864.20 | 0.20 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 53 | 188679.25 | 1.22 | 2.5 MB | ✅ |
| Batch | Select | 10,000 | 15 | 666666.67 | 4.15 | 2.5 MB | ✅ |
| Batch | Update | 10,000 | 1,812 | 5518.76 | 0.68 | 2.57 MB | ✅ |
| Batch | Update | 10,000 | 1,250 | 8000.00 | 0.73 | 4.72 MB | ✅ |
| Batch | Update | 10,000 | 1,578 | 6337.14 | 0.78 | 1.27 MB | ✅ |
| Batch | Update | 10,000 | 1,501 | 6662.23 | 0.61 | 2.29 MB | ✅ |
| Batch | Update | 10,000 | 1,400 | 7142.86 | 0.79 | 2.23 MB | ✅ |
| Single | Delete | 1,000 | 942 | 1061.57 | 0.90 | 0 B | ✅ |
| Single | Delete | 1,000 | 903 | 1107.42 | 0.65 | 1.37 MB | ✅ |
| Single | Delete | 1,000 | 893 | 1119.82 | 1.09 | 0 B | ✅ |
| Single | Delete | 1,000 | 864 | 1157.41 | 0.90 | 0 B | ✅ |
| Single | Delete | 1,000 | 880 | 1136.36 | 0.96 | 0 B | ✅ |
| Single | Insert | 1,000 | 914 | 1094.09 | 1.78 | 1.06 MB | ✅ |
| Single | Insert | 1,000 | 1,013 | 987.17 | 1.48 | 8.29 MB | ✅ |
| Single | Insert | 1,000 | 929 | 1076.43 | 1.12 | 8.13 MB | ✅ |
| Single | Insert | 1,000 | 916 | 1091.70 | 1.21 | 0 B | ✅ |
| Single | Insert | 1,000 | 881 | 1135.07 | 1.25 | 0 B | ✅ |
| Single | Select | 1,000 | 368 | 2717.39 | 3.18 | 76 KB | ✅ |
| Single | Select | 1,000 | 364 | 2747.25 | 3.03 | 4 MB | ✅ |
| Single | Select | 1,000 | 371 | 2695.42 | 2.45 | 3.82 MB | ✅ |
| Single | Select | 1,000 | 368 | 2717.39 | 3.00 | 0 B | ✅ |
| Single | Select | 1,000 | 367 | 2724.80 | 3.01 | 0 B | ✅ |
| Single | Update | 1,000 | 920 | 1086.96 | 2.33 | 32 KB | ✅ |
| Single | Update | 1,000 | 1,008 | 992.06 | 1.23 | 1.51 MB | ✅ |
| Single | Update | 1,000 | 964 | 1037.34 | 1.62 | 1.13 MB | ✅ |
| Single | Update | 1,000 | 920 | 1086.96 | 0.85 | 0 B | ✅ |
| Single | Update | 1,000 | 920 | 1086.96 | 1.56 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 6 | 166.67 | 0.00 | 760 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 17.21 | 408 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 264 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 280 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 428 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.96 | 320 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.06 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.08 | 28 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.08 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 3.21 | 0 B | ✅ |
| Batch | Delete | 10,000 | 41 | 243902.44 | 3.15 | 0 B | ✅ |
| Batch | Delete | 10,000 | 41 | 243902.44 | 3.16 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 3.37 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 5.15 | 220 KB | ✅ |
| Batch | Insert | 10,000 | 590 | 16949.15 | 4.19 | 2.14 MB | ✅ |
| Batch | Insert | 10,000 | 566 | 17667.84 | 4.25 | 0 B | ✅ |
| Batch | Insert | 10,000 | 563 | 17761.99 | 4.16 | 0 B | ✅ |
| Batch | Insert | 10,000 | 563 | 17761.99 | 4.16 | 448 KB | ✅ |
| Batch | Insert | 10,000 | 566 | 17667.84 | 4.14 | 4.31 MB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.92 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.88 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.92 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 7.80 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 7.84 | 0 B | ✅ |
| Batch | Update | 10,000 | 669 | 14947.68 | 3.89 | 660 KB | ✅ |
| Batch | Update | 10,000 | 666 | 15015.02 | 4.10 | 372 KB | ✅ |
| Batch | Update | 10,000 | 667 | 14992.50 | 4.10 | 488 KB | ✅ |
| Batch | Update | 10,000 | 658 | 15197.57 | 4.25 | 148 KB | ✅ |
| Batch | Update | 10,000 | 655 | 15267.18 | 4.17 | 172 KB | ✅ |
| Single | Delete | 1,000 | 2,090 | 478.47 | 2.71 | 4 KB | ✅ |
| Single | Delete | 1,000 | 2,093 | 477.78 | 3.27 | 4 KB | ✅ |
| Single | Delete | 1,000 | 2,100 | 476.19 | 3.25 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,066 | 484.03 | 3.50 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,071 | 482.86 | 3.33 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,098 | 476.64 | 3.29 | 296 KB | ✅ |
| Single | Insert | 1,000 | 2,138 | 467.73 | 3.32 | 88 KB | ✅ |
| Single | Insert | 1,000 | 2,179 | 458.93 | 2.96 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,142 | 466.85 | 3.01 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,192 | 456.20 | 2.85 | 0 B | ✅ |
| Single | Select | 1,000 | 104 | 9615.38 | 4.35 | 112 KB | ✅ |
| Single | Select | 1,000 | 101 | 9900.99 | 4.50 | 4 KB | ✅ |
| Single | Select | 1,000 | 102 | 9803.92 | 3.82 | 0 B | ✅ |
| Single | Select | 1,000 | 101 | 9900.99 | 4.49 | 4 KB | ✅ |
| Single | Select | 1,000 | 102 | 9803.92 | 4.44 | 1.98 MB | ✅ |
| Single | Update | 1,000 | 2,107 | 474.61 | 3.31 | 96 KB | ✅ |
| Single | Update | 1,000 | 2,112 | 473.48 | 3.05 | 756 KB | ✅ |
| Single | Update | 1,000 | 2,112 | 473.48 | 3.21 | 0 B | ✅ |
| Single | Update | 1,000 | 2,116 | 472.59 | 3.01 | 0 B | ✅ |
| Single | Update | 1,000 | 2,129 | 469.70 | 3.18 | 1.34 MB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 13 | 76.92 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.40 | 32 KB | ✅ |
| Aggregation | GroupBy | 8 | 11 | 90.91 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 12 | 83.33 | 5.42 | 244 KB | ✅ |
| Aggregation | Statistics | 10,000 | 16 | 375.00 | 0.00 | 628 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.33 | 20 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 265 | 37735.85 | 0.74 | 92 KB | ✅ |
| Batch | Delete | 10,000 | 268 | 37313.43 | 0.00 | 1.07 MB | ✅ |
| Batch | Delete | 10,000 | 296 | 33783.78 | 0.22 | 0 B | ✅ |
| Batch | Delete | 10,000 | 270 | 37037.04 | 0.24 | 3.14 MB | ✅ |
| Batch | Delete | 10,000 | 271 | 36900.37 | 0.24 | 0 B | ✅ |
| Batch | Insert | 10,000 | 4,927 | 2029.63 | 0.18 | 2.9 MB | ✅ |
| Batch | Insert | 10,000 | 4,912 | 2035.83 | 0.07 | 5.89 MB | ✅ |
| Batch | Insert | 10,000 | 4,965 | 2014.10 | 0.10 | 4.78 MB | ✅ |
| Batch | Insert | 10,000 | 4,998 | 2000.80 | 0.13 | 2.8 MB | ✅ |
| Batch | Insert | 10,000 | 4,948 | 2021.02 | 0.08 | 2.46 MB | ✅ |
| Batch | Select | 10,000 | 32 | 312500.00 | 3.98 | 12 KB | ✅ |
| Batch | Select | 10,000 | 32 | 312500.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 29 | 344827.59 | 4.47 | 400 KB | ✅ |
| Batch | Select | 10,000 | 31 | 322580.65 | 4.18 | 2.15 MB | ✅ |
| Batch | Select | 10,000 | 30 | 333333.33 | 6.32 | 4 KB | ✅ |
| Batch | Update | 10,000 | 5,636 | 1774.31 | 0.08 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,746 | 1740.34 | 0.12 | 1.66 MB | ✅ |
| Batch | Update | 10,000 | 5,657 | 1767.72 | 0.07 | 2.81 MB | ✅ |
| Batch | Update | 10,000 | 5,655 | 1768.35 | 0.09 | 0 B | ✅ |
| Batch | Update | 10,000 | 5,668 | 1764.29 | 0.08 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,462 | 683.99 | 0.62 | 676 KB | ✅ |
| Single | Delete | 1,000 | 1,447 | 691.09 | 0.58 | 92 KB | ✅ |
| Single | Delete | 1,000 | 1,478 | 676.59 | 0.79 | 1.23 MB | ✅ |
| Single | Delete | 1,000 | 1,480 | 675.68 | 0.66 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,505 | 664.45 | 0.56 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,496 | 668.45 | 0.87 | 1.39 MB | ✅ |
| Single | Insert | 1,000 | 1,432 | 698.32 | 0.27 | 5.54 MB | ✅ |
| Single | Insert | 1,000 | 1,453 | 688.23 | 0.54 | 6.54 MB | ✅ |
| Single | Insert | 1,000 | 1,403 | 712.76 | 0.28 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,550 | 645.16 | 0.50 | 7.97 MB | ✅ |
| Single | Select | 1,000 | 992 | 1008.06 | 0.72 | 172 KB | ✅ |
| Single | Select | 1,000 | 944 | 1059.32 | 0.83 | 2.2 MB | ✅ |
| Single | Select | 1,000 | 988 | 1012.15 | 0.86 | 7.01 MB | ✅ |
| Single | Select | 1,000 | 966 | 1035.20 | 1.01 | 4 KB | ✅ |
| Single | Select | 1,000 | 1,006 | 994.04 | 0.84 | 7.11 MB | ✅ |
| Single | Update | 1,000 | 2,597 | 385.06 | 0.30 | 24 KB | ✅ |
| Single | Update | 1,000 | 2,465 | 405.68 | 0.29 | 3.01 MB | ✅ |
| Single | Update | 1,000 | 2,491 | 401.45 | 0.16 | 3.41 MB | ✅ |
| Single | Update | 1,000 | 2,473 | 404.37 | 0.29 | 0 B | ✅ |
| Single | Update | 1,000 | 2,672 | 374.25 | 0.24 | 4.84 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 2.10 | 2.04 | 10.05 | 3.44 | 2.16 |
| Aggregation | Statistics | 5.32 | 2.17 | 2.39 | 4.64 | 1.27 |
| Batch | Delete | 1.39 | 0.46 | 1.37 | 3.61 | 0.29 |
| Batch | Insert | 1.15 | 3.02 | 0.80 | 4.18 | 0.11 |
| Batch | Select | 2.56 | 1.66 | 2.14 | 5.47 | 3.79 |
| Batch | Update | 1.04 | 2.16 | 0.72 | 4.10 | 0.09 |
| Single | Delete | 1.76 | 0.53 | 0.90 | 3.21 | 0.64 |
| Single | Insert | 2.06 | 0.81 | 1.37 | 3.09 | 0.49 |
| Single | Select | 2.71 | 1.78 | 2.93 | 4.32 | 0.85 |
| Single | Update | 2.28 | 0.64 | 1.52 | 3.15 | 0.26 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 16 KB | 152 KB | 4 KB | 760 KB | 244 KB |
| Aggregation | Statistics | 668 KB | 756 KB | 28 KB | 320 KB | 628 KB |
| Batch | Delete | 2.36 MB | 5.26 MB | 52 KB | 220 KB | 3.14 MB |
| Batch | Insert | 7.39 MB | 8.52 MB | 10.63 MB | 4.31 MB | 5.89 MB |
| Batch | Select | 48 KB | 288 KB | 3.51 MB | 0 B | 2.15 MB |
| Batch | Update | 6.28 MB | 6.32 MB | 4.72 MB | 660 KB | 2.81 MB |
| Single | Delete | 440 KB | 148 KB | 1.37 MB | 4 KB | 1.23 MB |
| Single | Insert | 12.83 MB | 6.36 MB | 8.29 MB | 296 KB | 7.97 MB |
| Single | Select | 4.36 MB | 6.35 MB | 4 MB | 1.98 MB | 7.11 MB |
| Single | Update | 4.02 MB | 96 KB | 1.51 MB | 1.34 MB | 4.84 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251209.log` 文件。

---

*报告生成时间: 2025-12-09 12:07:07*
