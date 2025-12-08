# 数据库基准测试报告

**测试时间**: 2025-12-08 16:04:41

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
| 采集时间 | 2025-12-08 16:04:41 |


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
| Aggregation | GroupBy | 1.00 | 1.60 | 0.00 | 0.00 | **PostgreSQL** |
| Aggregation | Statistics | 3.20 | 9.20 | 3.00 | 0.20 | **SQLite** |
| Batch | Delete | 4.40 | 7.60 | 3.00 | 1.00 | **SQLite** |
| Batch | Select | 4.40 | 8.60 | 3.20 | 1.00 | **SQLite** |
| Batch | Update | 3.80 | 8.80 | 3.00 | 1.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 1000.00 | 850.00 | 0.00 | 0.00 | **MongoDB** |
| Aggregation | Statistics | 816.67 | 1181.38 | 2571.43 | 1200.00 | **PostgreSQL** |
| Batch | Delete | 2300000.00 | 1354761.91 | 3333333.33 | 10000000.00 | **SQLite** |
| Batch | Select | 2300000.00 | 1189754.69 | 3166666.66 | 10000000.00 | **SQLite** |
| Batch | Update | 2666666.67 | 1214285.71 | 3333333.33 | 10000000.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | 0.00 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 48.69 | 8 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 52.64 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 96.53 | 72 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 12 | 83.33 | 5.40 | 636 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 58.26 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 5 | 2000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 14.49 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 14.50 | 0 B | ✅ |
| Batch | Delete | 10,000 | 5 | 2000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 12.41 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 22.11 | 296 KB | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 15.84 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 15.95 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 15.79 | 8 KB | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 28 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 15.77 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
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
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### MySQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 4 | 250.00 | 0.00 | 224 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 164 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 29 | 206.90 | 4.46 | 1.07 MB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 4 | 1500.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 5 | 1200.00 | 23.61 | 276 KB | ✅ |
| Batch | Delete | 10,000 | 10 | 1000000.00 | 6.26 | 0 B | ✅ |
| Batch | Delete | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 11 | 909090.91 | 5.68 | 4 KB | ✅ |
| Batch | Select | 10,000 | 9 | 1111111.11 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 7 | 1428571.43 | 0.00 | 24 KB | ✅ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 14 | 714285.71 | 4.49 | 272 KB | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 7.40 | 0 B | ✅ |
| Batch | Update | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 7 | 1428571.43 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 8 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 400 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 4 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 44 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 7 | 857.14 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 27.31 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 17.54 | 80 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 21.68 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 18.05 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 14.45 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 32 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 18.40 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
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
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Aggregation | Statistics | 0 | 1 | 6000.00 | 0.00 | 32 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 128 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 54.14 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 55.78 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 40 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 62.68 | 4 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 54.31 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 100.00 | 72 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 58.26 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 57.92 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-------:|-------:|-------:|-------:|
| Aggregation | GroupBy | 39.57 | 0.00 | 0.00 | 0.00 |
| Aggregation | Statistics | 12.73 | 5.61 | 5.46 | 0.00 |
| Batch | Delete | 5.80 | 1.25 | 7.84 | 21.98 |
| Batch | Select | 13.26 | 1.14 | 6.50 | 43.40 |
| Batch | Update | 6.31 | 2.38 | 3.68 | 23.24 |
| Single | Delete | 20.00 | 0.00 | 20.00 | 20.00 |
| Single | Select | 20.00 | 60.00 | 20.00 | 0.00 |
| Single | Update | 40.00 | 40.00 | 0.00 | 60.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite |
|:---------|:---------|-----------:|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 72 KB | 224 KB | 44 KB | 16 KB |
| Aggregation | Statistics | 636 KB | 1.07 MB | 24 KB | 128 KB |
| Batch | Delete | 4 KB | 12 KB | 80 KB | 40 KB |
| Batch | Select | 296 KB | 24 KB | 0 B | 72 KB |
| Batch | Update | 28 KB | 272 KB | 32 KB | 0 B |
| Single | Delete | 0 B | 8 KB | 0 B | 0 B |
| Single | Select | 0 B | 0 B | 0 B | 0 B |
| Single | Update | 0 B | 400 KB | 0 B | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 16:04:41 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:38 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| MySQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:39 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| PostgreSQL | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 16:04:40 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 16:04:41*
