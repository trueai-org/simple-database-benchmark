# 数据库基准测试报告

**测试时间**: 2025-12-08 15:52:39

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
| 采集时间 | 2025-12-08 15:52:38 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | MySQL, PostgreSQL, SQLite, MongoDB |
| 数据库数量 | 4 |
| 总测试用例数 | 200 |
| 成功用例数 | 160 |
| 失败用例数 | 40 |
| 成功率 | 80.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 0.60 | 2.00 | 0.20 | 0.00 | **SQLite** |
| Aggregation | Statistics | 5.60 | 9.00 | 3.00 | 0.40 | **SQLite** |
| Batch | Delete | 4.00 | 7.40 | 3.20 | 1.00 | **SQLite** |
| Batch | Select | 4.00 | 8.80 | 3.20 | 0.80 | **SQLite** |
| Batch | Update | 3.20 | 9.00 | 3.40 | 1.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 600.00 | 833.33 | 200.00 | 0.00 | **MySQL** |
| Aggregation | Statistics | 808.33 | 1241.38 | 3150.00 | 600.00 | **PostgreSQL** |
| Batch | Delete | 2500000.00 | 1376984.13 | 3166666.66 | 10000000.00 | **SQLite** |
| Batch | Select | 2566666.67 | 1144444.44 | 3166666.66 | 8000000.00 | **SQLite** |
| Batch | Update | 3166666.66 | 1161782.66 | 3000000.00 | 10000000.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 52 KB | ✅ |
| Aggregation | Statistics | 0 | 24 | 41.67 | 2.61 | 644 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 56.39 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 100.00 | 48 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 12 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 30.62 | 0 B | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 24.81 | 200 KB | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 18.12 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 18.65 | 20 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 18.77 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 6 | 166.67 | 0.00 | 196 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 29 | 206.90 | 6.59 | 1008 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 48 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 15.54 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 9 | 1111111.11 | 6.71 | 0 B | ✅ |
| Batch | Delete | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 9 | 1111111.11 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 10 | 1000000.00 | 6.42 | 0 B | ✅ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 7.93 | 32 KB | ✅ |
| Batch | Select | 10,000 | 9 | 1111111.11 | 7.10 | 0 B | ✅ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 15.06 | 612 KB | ✅ |
| Batch | Update | 10,000 | 13 | 769230.77 | 4.87 | 284 KB | ✅ |
| Batch | Update | 10,000 | 9 | 1111111.11 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 7.99 | 0 B | ✅ |
| Batch | Update | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 8.08 | 8 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 276 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 44.95 | 88 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 84.59 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 8 | 750.00 | 8.04 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 6000.00 | 34.75 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 17.79 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 15.70 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 16.76 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 19.30 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 16.61 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 18.15 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 48 KB | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 40 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 48 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 68 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 76.13 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 54.73 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 52 KB | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 24 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 62.84 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 40 KB | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 59.07 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 58.50 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 0.00 | 0.00 | 25.91 | 20.00 |
| Aggregation | Statistics | 31.80 | 4.43 | 8.56 | 15.23 |
| Batch | Delete | 0.00 | 1.34 | 17.23 | 10.95 |
| Batch | Select | 14.71 | 7.30 | 3.63 | 12.57 |
| Batch | Update | 7.48 | 4.19 | 0.00 | 23.51 |
| Single | Delete | 20.00 | 20.00 | 40.00 | 0.00 |
| Single | Select | 0.00 | 20.00 | 0.00 | 0.00 |
| Single | Update | 40.00 | 20.00 | 0.00 | 20.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 52 KB | 196 KB | 88 KB | 40 KB |
| Aggregation | Statistics | 644 KB | 1008 KB | 12 KB | 68 KB |
| Batch | Delete | 12 KB | 0 B | 0 B | 52 KB |
| Batch | Select | 200 KB | 612 KB | 0 B | 24 KB |
| Batch | Update | 20 KB | 284 KB | 48 KB | 40 KB |
| Single | Delete | 0 B | 276 KB | 0 B | 0 B |
| Single | Select | 0 B | 0 B | 0 B | 0 B |
| Single | Update | 0 B | 0 B | 0 B | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 15:52:36 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 15:52:37 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 15:52:38 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 15:52:39*
