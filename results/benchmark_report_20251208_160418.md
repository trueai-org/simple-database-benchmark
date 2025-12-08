# 数据库基准测试报告

**测试时间**: 2025-12-08 16:04:18

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
| 采集时间 | 2025-12-08 16:04:18 |


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
| Aggregation | GroupBy | 0.80 | 1.80 | 0.20 | 0.00 | **SQLite** |
| Aggregation | Statistics | 3.00 | 9.20 | 3.00 | 0.20 | **SQLite** |
| Batch | Delete | 4.20 | 7.60 | 3.20 | 1.00 | **SQLite** |
| Batch | Select | 3.40 | 8.20 | 3.00 | 1.00 | **SQLite** |
| Batch | Update | 3.60 | 9.40 | 3.40 | 1.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 800.00 | 840.00 | 200.00 | 0.00 | **MySQL** |
| Aggregation | Statistics | 818.18 | 1181.38 | 2571.43 | 1200.00 | **PostgreSQL** |
| Batch | Delete | 2400000.00 | 1329365.08 | 3166666.66 | 10000000.00 | **SQLite** |
| Batch | Select | 3000000.00 | 1230158.73 | 3333333.33 | 10000000.00 | **SQLite** |
| Batch | Update | 2900000.00 | 1111782.66 | 3000000.00 | 10000000.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 20 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 76 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 58.37 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 11 | 90.91 | 5.51 | 728 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 15.59 | 0 B | ✅ |
| Batch | Delete | 10,000 | 5 | 2000000.00 | 11.04 | 16 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 17.47 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 8 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 16.38 | 0 B | ✅ |
| Batch | Update | 10,000 | 5 | 2000000.00 | 0.00 | 104 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 5 | 200.00 | 11.48 | 200 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 108 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 29 | 206.90 | 4.35 | 1.02 MB | ✅ |
| Aggregation | Statistics | 0 | 5 | 1200.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 8 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 14.50 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 9 | 1111111.11 | 7.04 | 0 B | ✅ |
| Batch | Delete | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 9 | 1111111.11 | 6.89 | 0 B | ✅ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 9 | 1111111.11 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 13 | 769230.77 | 0.00 | 280 KB | ✅ |
| Batch | Update | 10,000 | 9 | 1111111.11 | 7.09 | 0 B | ✅ |
| Batch | Update | 10,000 | 7 | 1428571.43 | 8.26 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 10 | 1000000.00 | 12.86 | 476 KB | ✅ |
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
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 28 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 32 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 100.00 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 7 | 857.14 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 26.10 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 30.71 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 14.84 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 52 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 34.33 | 56 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 32 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
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
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 28 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 6000.00 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 74.35 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 24 KB | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 48 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 60.54 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 100.00 | 8 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 60 KB | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 56 KB | ✅ |
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
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 11.67 | 2.30 | 20.00 | 60.00 |
| Aggregation | Statistics | 1.10 | 3.77 | 11.36 | 14.87 |
| Batch | Delete | 5.33 | 1.41 | 9.83 | 0.00 |
| Batch | Select | 3.49 | 1.38 | 0.00 | 32.11 |
| Batch | Update | 3.28 | 5.64 | 0.00 | 0.00 |
| Single | Delete | 40.00 | 0.00 | 40.00 | 0.00 |
| Single | Select | 0.00 | 40.00 | 40.00 | 40.00 |
| Single | Update | 40.00 | 20.00 | 0.00 | 0.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 76 KB | 200 KB | 32 KB | 28 KB |
| Aggregation | Statistics | 728 KB | 1.02 MB | 12 KB | 24 KB |
| Batch | Delete | 16 KB | 0 B | 56 KB | 48 KB |
| Batch | Select | 4 KB | 4 KB | 0 B | 8 KB |
| Batch | Update | 104 KB | 476 KB | 32 KB | 60 KB |
| Single | Delete | 0 B | 0 B | 0 B | 0 B |
| Single | Select | 0 B | 0 B | 0 B | 0 B |
| Single | Update | 0 B | 28 KB | 0 B | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:15 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:16 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:17 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 16:04:18*
