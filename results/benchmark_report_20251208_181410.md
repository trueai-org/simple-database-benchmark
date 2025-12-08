# 数据库基准测试报告

**测试时间**: 2025-12-08 18:14:10

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
| 采集时间 | 2025-12-08 18:14:10 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, SQLServer, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 5 |
| 总测试用例数 | 250 |
| 成功用例数 | 240 |
| 失败用例数 | 10 |
| 成功率 | 96.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 0.60 | 10.60 | 3.40 | 3.40 | 18.20 | **MongoDB** |
| Aggregation | Statistics | 5.60 | 18.60 | 12.20 | 9.20 | 16.00 | **MongoDB** |
| Batch | Delete | 3.80 | 444.60 | 104.00 | 38.20 | 805.60 | **MongoDB** |
| Batch | Insert | N/A | 964.80 | 683.80 | 590.40 | 8010.60 | **SQLite** |
| Batch | Select | 3.80 | 47.60 | 30.80 | 16.00 | 46.20 | **MongoDB** |
| Batch | Update | 3.20 | 1211.60 | 938.20 | 682.80 | 10424.40 | **MongoDB** |
| Single | Delete | 0.00 | 7455.40 | 1460.20 | 1954.80 | 1193.60 | **MongoDB** |
| Single | Insert | N/A | 5568.40 | 2605.60 | 1982.80 | 1151.20 | **SQLServer** |
| Single | Select | 0.00 | 663.80 | 323.00 | 91.00 | 1033.20 | **MongoDB** |
| Single | Update | 0.00 | 7714.00 | 1638.40 | 2005.40 | 3023.20 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 600.00 | 99.17 | 300.00 | 306.66 | 55.28 | **MongoDB** |
| Aggregation | Statistics | 808.33 | 370.48 | 503.74 | 653.34 | 394.07 | **MongoDB** |
| Batch | Delete | 2666666.67 | 45919.84 | 123963.46 | 262021.74 | 16454.29 | **MongoDB** |
| Batch | Insert | N/A | 13638.77 | 16729.60 | 16938.14 | 1248.66 | **SQLite** |
| Batch | Select | 2666666.67 | 210142.57 | 327767.69 | 625000.00 | 216466.23 | **MongoDB** |
| Batch | Update | 3166666.66 | 9989.80 | 10933.44 | 14645.67 | 960.08 | **MongoDB** |
| Single | Delete | 0.00 | 259.12 | 978.79 | 511.59 | 838.94 | **PostgreSQL** |
| Single | Insert | N/A | 266.59 | 886.34 | 504.37 | 868.87 | **PostgreSQL** |
| Single | Select | 0.00 | 1507.56 | 3096.40 | 10991.12 | 969.55 | **SQLite** |
| Single | Update | 0.00 | 243.71 | 858.98 | 498.68 | 339.35 | **PostgreSQL** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 55.37 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 46.54 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 24 | 41.67 | 5.31 | 776 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 49.44 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 17.82 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 13.94 | 52 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 13.13 | 4 KB | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 4 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 19.72 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 472 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 20 KB | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 52 KB | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 16 | 62.50 | 7.88 | 232 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 52 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 0.00 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 9 | 111.11 | 13.62 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 10 | 100.00 | 13.01 | 216 KB | ✅ |
| Aggregation | Statistics | 10,000 | 36 | 166.67 | 1.80 | 780 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 4.55 | 8 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 4.35 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 15 | 400.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 887 | 11273.96 | 0.66 | 428 KB | ✅ |
| Batch | Delete | 10,000 | 133 | 75187.97 | 0.97 | 5.76 MB | ✅ |
| Batch | Delete | 10,000 | 153 | 65359.48 | 1.70 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 150 | 66666.67 | 1.30 | 5.79 MB | ✅ |
| Batch | Delete | 10,000 | 900 | 11111.11 | 0.07 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 1,636 | 6112.47 | 0.84 | 9.93 MB | ✅ |
| Batch | Insert | 10,000 | 625 | 16000.00 | 2.91 | 7.52 MB | ✅ |
| Batch | Insert | 10,000 | 509 | 19646.37 | 2.43 | 10.41 MB | ✅ |
| Batch | Insert | 10,000 | 500 | 20000.00 | 2.60 | 7.65 MB | ✅ |
| Batch | Insert | 10,000 | 1,554 | 6435.01 | 0.84 | 8.48 MB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 4.09 | 4 KB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 1.38 | 204 KB | ✅ |
| Batch | Select | 10,000 | 48 | 208333.33 | 2.66 | 0 B | ✅ |
| Batch | Select | 10,000 | 49 | 204081.63 | 3.95 | 20 KB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 1.38 | 0 B | ✅ |
| Batch | Update | 10,000 | 1,751 | 5711.02 | 1.15 | 4.15 MB | ✅ |
| Batch | Update | 10,000 | 763 | 13106.16 | 1.96 | 0 B | ✅ |
| Batch | Update | 10,000 | 778 | 12853.47 | 2.17 | 3.86 MB | ✅ |
| Batch | Update | 10,000 | 751 | 13315.58 | 1.73 | 0 B | ✅ |
| Batch | Update | 10,000 | 2,015 | 4962.78 | 0.84 | 3.51 MB | ✅ |
| Single | Delete | 1,000 | 12,675 | 78.90 | 0.17 | 2.11 MB | ✅ |
| Single | Delete | 1,000 | 2,561 | 390.47 | 0.56 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,568 | 389.41 | 0.58 | 8 KB | ✅ |
| Single | Delete | 1,000 | 2,650 | 377.36 | 0.52 | 44 KB | ✅ |
| Single | Delete | 1,000 | 16,823 | 59.44 | 0.10 | 3.79 MB | ✅ |
| Single | Insert | 1,000 | 12,473 | 80.17 | 0.15 | 3.74 MB | ✅ |
| Single | Insert | 1,000 | 7,303 | 136.93 | 0.26 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,688 | 372.02 | 0.82 | 9.44 MB | ✅ |
| Single | Insert | 1,000 | 2,712 | 368.73 | 0.53 | 0 B | ✅ |
| Single | Insert | 1,000 | 2,666 | 375.09 | 0.61 | 3.38 MB | ✅ |
| Single | Select | 1,000 | 631 | 1584.79 | 1.24 | 2.01 MB | ✅ |
| Single | Select | 1,000 | 665 | 1503.76 | 2.64 | 788 KB | ✅ |
| Single | Select | 1,000 | 675 | 1481.48 | 2.03 | 4 MB | ✅ |
| Single | Select | 1,000 | 682 | 1466.28 | 2.38 | 0 B | ✅ |
| Single | Select | 1,000 | 666 | 1501.50 | 2.15 | 3 MB | ✅ |
| Single | Update | 1,000 | 14,280 | 70.03 | 0.10 | 5.33 MB | ✅ |
| Single | Update | 1,000 | 2,692 | 371.47 | 0.48 | 148 KB | ✅ |
| Single | Update | 1,000 | 2,799 | 357.27 | 0.40 | 64 KB | ✅ |
| Single | Update | 1,000 | 2,799 | 357.27 | 0.65 | 1.18 MB | ✅ |
| Single | Update | 1,000 | 16,000 | 62.50 | 0.09 | 584 KB | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 19.66 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 13.88 | 68 KB | ✅ |
| Aggregation | GroupBy | 8 | 4 | 250.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 4.43 | 16 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 6.20 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 14 | 428.57 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 56 | 178571.43 | 2.31 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 59 | 169491.53 | 2.19 | 0 B | ✅ |
| Batch | Delete | 10,000 | 65 | 153846.15 | 0.99 | 0 B | ✅ |
| Batch | Delete | 10,000 | 178 | 56179.78 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 162 | 61728.40 | 0.80 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 431 | 23201.86 | 2.57 | 3.7 MB | ✅ |
| Batch | Insert | 10,000 | 399 | 25062.66 | 2.44 | 5.69 MB | ✅ |
| Batch | Insert | 10,000 | 804 | 12437.81 | 0.97 | 5.63 MB | ✅ |
| Batch | Insert | 10,000 | 756 | 13227.51 | 1.03 | 10.58 MB | ✅ |
| Batch | Insert | 10,000 | 1,029 | 9718.17 | 0.95 | 5.84 MB | ✅ |
| Batch | Select | 10,000 | 27 | 370370.37 | 7.21 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 28 | 357142.86 | 0.00 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 31 | 322580.65 | 4.20 | 3.51 MB | ✅ |
| Batch | Select | 10,000 | 33 | 303030.30 | 3.92 | 0 B | ✅ |
| Batch | Select | 10,000 | 35 | 285714.29 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 970 | 10309.28 | 1.41 | 0 B | ✅ |
| Batch | Update | 10,000 | 785 | 12738.85 | 1.24 | 1.06 MB | ✅ |
| Batch | Update | 10,000 | 754 | 13262.60 | 1.55 | 1.18 MB | ✅ |
| Batch | Update | 10,000 | 1,131 | 8841.73 | 1.15 | 4.63 MB | ✅ |
| Batch | Update | 10,000 | 1,051 | 9514.75 | 1.49 | 4.63 MB | ✅ |
| Single | Delete | 1,000 | 728 | 1373.63 | 1.16 | 4 KB | ✅ |
| Single | Delete | 1,000 | 734 | 1362.40 | 0.98 | 0 B | ✅ |
| Single | Delete | 1,000 | 730 | 1369.86 | 0.89 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,761 | 362.19 | 0.38 | 0 B | ✅ |
| Single | Delete | 1,000 | 2,348 | 425.89 | 0.30 | 712 KB | ✅ |
| Single | Insert | 1,000 | 1,472 | 679.35 | 0.57 | 116 KB | ✅ |
| Single | Insert | 1,000 | 844 | 1184.83 | 1.70 | 96 KB | ✅ |
| Single | Insert | 1,000 | 803 | 1245.33 | 1.30 | 0 B | ✅ |
| Single | Insert | 1,000 | 825 | 1212.12 | 0.79 | 0 B | ✅ |
| Single | Insert | 1,000 | 9,084 | 110.08 | 0.10 | 1.95 MB | ✅ |
| Single | Select | 1,000 | 323 | 3095.98 | 2.41 | 100 KB | ✅ |
| Single | Select | 1,000 | 329 | 3039.51 | 2.76 | 0 B | ✅ |
| Single | Select | 1,000 | 323 | 3095.98 | 2.62 | 0 B | ✅ |
| Single | Select | 1,000 | 323 | 3095.98 | 2.82 | 0 B | ✅ |
| Single | Select | 1,000 | 317 | 3154.57 | 2.05 | 0 B | ✅ |
| Single | Update | 1,000 | 824 | 1213.59 | 1.66 | 32 KB | ✅ |
| Single | Update | 1,000 | 827 | 1209.19 | 0.79 | 0 B | ✅ |
| Single | Update | 1,000 | 856 | 1168.22 | 0.46 | 0 B | ✅ |
| Single | Update | 1,000 | 2,786 | 358.94 | 0.30 | 3.95 MB | ✅ |
| Single | Update | 1,000 | 2,899 | 344.95 | 0.52 | 228 KB | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 5 | 200.00 | 11.78 | 100 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 18.10 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 240 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 200 KB | ✅ |
| Aggregation | GroupBy | 8 | 3 | 333.33 | 0.00 | 196 KB | ✅ |
| Aggregation | Statistics | 10,000 | 10 | 600.00 | 0.00 | 184 KB | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.79 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 9 | 666.67 | 6.99 | 0 B | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 5.15 | 192 KB | ✅ |
| Batch | Delete | 10,000 | 40 | 250000.00 | 3.25 | 208 KB | ✅ |
| Batch | Delete | 10,000 | 39 | 256410.26 | 3.32 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 37 | 270270.27 | 5.17 | 0 B | ✅ |
| Batch | Delete | 10,000 | 38 | 263157.89 | 3.37 | 4 KB | ✅ |
| Batch | Insert | 10,000 | 591 | 16920.47 | 4.18 | 2.32 MB | ✅ |
| Batch | Insert | 10,000 | 588 | 17006.80 | 4.21 | 52 KB | ✅ |
| Batch | Insert | 10,000 | 590 | 16949.15 | 4.19 | 4 KB | ✅ |
| Batch | Insert | 10,000 | 587 | 17035.78 | 4.10 | 392 KB | ✅ |
| Batch | Insert | 10,000 | 596 | 16778.52 | 4.04 | 196 KB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 8.04 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 8.13 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 4.01 | 0 B | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 8.13 | 12 KB | ✅ |
| Batch | Select | 10,000 | 16 | 625000.00 | 3.90 | 12 KB | ✅ |
| Batch | Update | 10,000 | 683 | 14641.29 | 4.10 | 432 KB | ✅ |
| Batch | Update | 10,000 | 685 | 14598.54 | 4.09 | 24 KB | ✅ |
| Batch | Update | 10,000 | 684 | 14619.88 | 4.09 | 104 KB | ✅ |
| Batch | Update | 10,000 | 680 | 14705.88 | 3.82 | 236 KB | ✅ |
| Batch | Update | 10,000 | 682 | 14662.76 | 4.10 | 200 KB | ✅ |
| Single | Delete | 1,000 | 1,950 | 512.82 | 3.67 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,949 | 513.08 | 3.17 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,932 | 517.60 | 3.20 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,973 | 506.84 | 2.90 | 0 B | ✅ |
| Single | Delete | 1,000 | 1,970 | 507.61 | 3.44 | 4 KB | ✅ |
| Single | Insert | 1,000 | 2,001 | 499.75 | 3.16 | 4.15 MB | ✅ |
| Single | Insert | 1,000 | 1,960 | 510.20 | 3.39 | 60 KB | ✅ |
| Single | Insert | 1,000 | 1,967 | 508.39 | 3.34 | 8 KB | ✅ |
| Single | Insert | 1,000 | 2,002 | 499.50 | 3.22 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,984 | 504.03 | 2.69 | 0 B | ✅ |
| Single | Select | 1,000 | 92 | 10869.57 | 4.24 | 64 KB | ✅ |
| Single | Select | 1,000 | 90 | 11111.11 | 4.31 | 4 KB | ✅ |
| Single | Select | 1,000 | 93 | 10752.69 | 4.85 | 4 KB | ✅ |
| Single | Select | 1,000 | 90 | 11111.11 | 4.33 | 4 KB | ✅ |
| Single | Select | 1,000 | 90 | 11111.11 | 4.30 | 4 KB | ✅ |
| Single | Update | 1,000 | 1,983 | 504.29 | 3.09 | 504 KB | ✅ |
| Single | Update | 1,000 | 2,023 | 494.32 | 2.51 | 0 B | ✅ |
| Single | Update | 1,000 | 2,014 | 496.52 | 3.39 | 0 B | ✅ |
| Single | Update | 1,000 | 2,003 | 499.25 | 3.51 | 0 B | ✅ |
| Single | Update | 1,000 | 2,004 | 499.00 | 4.00 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 21 | 47.62 | 0.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 8 | 17 | 58.82 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 3.46 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 17 | 58.82 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 18 | 55.56 | 0.00 | 68 KB | ✅ |
| Aggregation | Statistics | 10,000 | 21 | 285.71 | 6.17 | 352 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 10,000 | 13 | 461.54 | 4.77 | 24 KB | ✅ |
| Aggregation | Statistics | 10,000 | 20 | 300.00 | 0.00 | 32 KB | ✅ |
| Batch | Delete | 10,000 | 516 | 19379.84 | 0.25 | 72 KB | ✅ |
| Batch | Delete | 10,000 | 524 | 19083.97 | 0.12 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1,954 | 5117.71 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 511 | 19569.47 | 0.13 | 0 B | ✅ |
| Batch | Delete | 10,000 | 523 | 19120.46 | 0.12 | 0 B | ✅ |
| Batch | Insert | 10,000 | 8,189 | 1221.15 | 0.08 | 1.26 MB | ✅ |
| Batch | Insert | 10,000 | 8,133 | 1229.56 | 0.06 | 1.02 MB | ✅ |
| Batch | Insert | 10,000 | 7,863 | 1271.78 | 0.07 | 1.52 MB | ✅ |
| Batch | Insert | 10,000 | 7,939 | 1259.60 | 0.06 | 1.41 MB | ✅ |
| Batch | Insert | 10,000 | 7,929 | 1261.19 | 0.05 | 1.49 MB | ✅ |
| Batch | Select | 10,000 | 46 | 217391.30 | 0.00 | 1.66 MB | ✅ |
| Batch | Select | 10,000 | 46 | 217391.30 | 2.79 | 1.18 MB | ✅ |
| Batch | Select | 10,000 | 46 | 217391.30 | 1.40 | 68 KB | ✅ |
| Batch | Select | 10,000 | 47 | 212765.96 | 5.44 | 0 B | ✅ |
| Batch | Select | 10,000 | 46 | 217391.30 | 4.19 | 0 B | ✅ |
| Batch | Update | 10,000 | 10,568 | 946.25 | 0.07 | 516 KB | ✅ |
| Batch | Update | 10,000 | 10,953 | 912.99 | 0.10 | 660 KB | ✅ |
| Batch | Update | 10,000 | 10,182 | 982.13 | 0.06 | 436 KB | ✅ |
| Batch | Update | 10,000 | 10,261 | 974.56 | 0.05 | 420 KB | ✅ |
| Batch | Update | 10,000 | 10,158 | 984.45 | 0.08 | 400 KB | ✅ |
| Single | Delete | 1,000 | 1,199 | 834.03 | 0.33 | 648 KB | ✅ |
| Single | Delete | 1,000 | 1,275 | 784.31 | 0.20 | 80 KB | ✅ |
| Single | Delete | 1,000 | 1,175 | 851.06 | 0.39 | 4 KB | ✅ |
| Single | Delete | 1,000 | 1,141 | 876.42 | 0.34 | 1.02 MB | ✅ |
| Single | Delete | 1,000 | 1,178 | 848.90 | 0.44 | 0 B | ✅ |
| Single | Insert | 1,000 | 1,158 | 863.56 | 1.24 | 1.3 MB | ✅ |
| Single | Insert | 1,000 | 1,150 | 869.57 | 0.40 | 1.58 MB | ✅ |
| Single | Insert | 1,000 | 1,142 | 875.66 | 0.46 | 1.49 MB | ✅ |
| Single | Insert | 1,000 | 1,126 | 888.10 | 0.69 | 3.85 MB | ✅ |
| Single | Insert | 1,000 | 1,180 | 847.46 | 0.66 | 0 B | ✅ |
| Single | Select | 1,000 | 1,097 | 911.58 | 0.71 | 164 KB | ✅ |
| Single | Select | 1,000 | 1,073 | 931.97 | 0.49 | 0 B | ✅ |
| Single | Select | 1,000 | 998 | 1002.00 | 0.52 | 92 KB | ✅ |
| Single | Select | 1,000 | 1,009 | 991.08 | 0.71 | 0 B | ✅ |
| Single | Select | 1,000 | 989 | 1011.12 | 0.33 | 0 B | ✅ |
| Single | Update | 1,000 | 4,084 | 244.86 | 0.24 | 0 B | ✅ |
| Single | Update | 1,000 | 2,910 | 343.64 | 0.31 | 0 B | ✅ |
| Single | Update | 1,000 | 2,675 | 373.83 | 0.12 | 12 KB | ✅ |
| Single | Update | 1,000 | 2,750 | 363.64 | 0.38 | 0 B | ✅ |
| Single | Update | 1,000 | 2,697 | 370.78 | 0.29 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 20.38 | 6.90 | 6.71 | 5.98 | 0.69 |
| Aggregation | Statistics | 10.95 | 2.14 | 2.13 | 2.76 | 2.19 |
| Batch | Delete | 6.35 | 0.94 | 1.26 | 4.05 | 0.12 |
| Batch | Insert | N/A | 1.92 | 1.59 | 4.14 | 0.06 |
| Batch | Select | 2.63 | 2.69 | 3.07 | 6.44 | 2.76 |
| Batch | Update | 3.94 | 1.57 | 1.37 | 4.04 | 0.07 |
| Single | Delete | 0.00 | 0.39 | 0.74 | 3.28 | 0.34 |
| Single | Insert | N/A | 0.47 | 0.89 | 3.16 | 0.69 |
| Single | Select | 0.00 | 2.09 | 2.53 | 4.41 | 0.55 |
| Single | Update | 40.00 | 0.34 | 0.75 | 3.30 | 0.27 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 16 KB | 232 KB | 68 KB | 240 KB | 68 KB |
| Aggregation | Statistics | 776 KB | 780 KB | 16 KB | 184 KB | 352 KB |
| Batch | Delete | 52 KB | 5.79 MB | 24 KB | 208 KB | 72 KB |
| Batch | Insert | N/A | 10.41 MB | 10.58 MB | 2.32 MB | 1.52 MB |
| Batch | Select | 4 KB | 204 KB | 3.51 MB | 12 KB | 1.66 MB |
| Batch | Update | 4 KB | 4.15 MB | 4.63 MB | 432 KB | 660 KB |
| Single | Delete | 472 KB | 3.79 MB | 712 KB | 4 KB | 1.02 MB |
| Single | Insert | N/A | 9.44 MB | 1.95 MB | 4.15 MB | 3.85 MB |
| Single | Select | 0 B | 4 MB | 100 KB | 64 KB | 164 KB |
| Single | Update | 52 KB | 5.33 MB | 3.95 MB | 504 KB | 12 KB |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 18:14:09 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 18:14:10 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 18:14:10*
