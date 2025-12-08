# 数据库基准测试报告

**测试时间**: 2025-12-08 11:50:01

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
| 采集时间 | 2025-12-08 11:50:01 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | SQLServer, SQLite, MongoDB |
| 数据库数量 | 3 |
| 总测试用例数 | 150 |
| 成功用例数 | 120 |
| 失败用例数 | 30 |
| 成功率 | 80.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 0.40 | 0.00 | 1.40 | **SQLite** |
| Aggregation | Statistics | 2.60 | 1.40 | 9.00 | **SQLite** |
| Batch | Delete | 6.20 | 1.00 | 4.80 | **SQLite** |
| Batch | Select | 5.60 | 0.80 | 5.40 | **SQLite** |
| Batch | Update | 5.60 | 1.00 | 6.20 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 400.00 | 0.00 | 233.33 | **MongoDB** |
| Aggregation | Statistics | 15.38 | 171.43 | 2432.43 | **SQLServer** |
| Batch | Delete | 1619047.62 | 10000000.00 | 2233333.33 | **SQLite** |
| Batch | Select | 1819047.62 | 8000000.00 | 2100000.00 | **SQLite** |
| Batch | Update | 1800000.00 | 10000000.00 | 1931818.18 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 69.63 | 20 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 20 KB | ✅ |
| Aggregation | Statistics | 0 | 13 | 76.92 | 4.76 | 848 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 48 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 7 | 1428571.43 | 8.89 | 0 B | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 10.21 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 36 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 6 | 1666666.67 | 0.00 | 36 KB | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 11.42 | 0 B | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 11.46 | 0 B | ✅ |
| Batch | Select | 10,000 | 7 | 1428571.43 | 9.02 | 0 B | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 10.92 | 0 B | ✅ |
| Batch | Update | 10,000 | 5 | 2000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Update | 10,000 | 6 | 1666666.67 | 10.02 | 0 B | ✅ |
| Batch | Update | 10,000 | 6 | 1666666.67 | 10.84 | 0 B | ✅ |
| Batch | Update | 10,000 | 5 | 2000000.00 | 11.95 | 0 B | ✅ |
| Batch | Update | 10,000 | 6 | 1666666.67 | 20.99 | 64 KB | ✅ |
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
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 20 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 84 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Aggregation | Statistics | 0 | 7 | 857.14 | 0.00 | 52 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 72.74 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 28 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 60.82 | 4 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 100.00 | 36 KB | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 40 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 16 KB | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 72 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 4 KB | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 6 | 166.67 | 0.00 | 164 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 0 | 1 | 1000.00 | 0.00 | 96 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 28 KB | ✅ |
| Aggregation | Statistics | 0 | 37 | 162.16 | 3.44 | 836 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 200 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 96 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 0.00 | 8 KB | ✅ |
| Batch | Delete | 10,000 | 6 | 1666666.67 | 10.84 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 12 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 17.76 | 0 B | ✅ |
| Batch | Delete | 10,000 | 5 | 2000000.00 | 0.00 | 16 KB | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 10 | 1000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 16.10 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 12.85 | 0 B | ✅ |
| Batch | Update | 10,000 | 11 | 909090.91 | 5.74 | 272 KB | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 15.73 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 15.96 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 0.00 | 24 KB | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 29.25 | 948 KB | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|
| Aggregation | GroupBy | 13.93 | 40.00 | 0.00 |
| Aggregation | Statistics | 0.95 | 14.55 | 0.69 |
| Batch | Delete | 3.82 | 0.00 | 5.72 |
| Batch | Select | 8.56 | 32.16 | 5.79 |
| Batch | Update | 10.76 | 0.00 | 13.34 |
| Single | Delete | 40.00 | 20.00 | 40.00 |
| Single | Select | 20.00 | 20.00 | 0.00 |
| Single | Update | 20.00 | 0.00 | 20.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 20 KB | 84 KB | 164 KB |
| Aggregation | Statistics | 848 KB | 52 KB | 836 KB |
| Batch | Delete | 36 KB | 28 KB | 16 KB |
| Batch | Select | 36 KB | 36 KB | 0 B |
| Batch | Update | 64 KB | 40 KB | 948 KB |
| Single | Delete | 0 B | 16 KB | 0 B |
| Single | Select | 16 KB | 72 KB | 0 B |
| Single | Update | 20 KB | 12 KB | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 11:50:01 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:50:00 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 11:49:59 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 11:50:01*
