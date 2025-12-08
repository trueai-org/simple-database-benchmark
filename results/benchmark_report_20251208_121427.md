# 数据库基准测试报告

**测试时间**: 2025-12-08 12:14:27

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
| 采集时间 | 2025-12-08 12:14:27 |


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
| Aggregation | GroupBy | 0.00 | 0.00 | 0.80 | **MongoDB** |
| Aggregation | Statistics | 2.20 | 1.20 | 6.20 | **SQLite** |
| Batch | Delete | 4.20 | 1.00 | 3.20 | **SQLite** |
| Batch | Select | 3.00 | 0.60 | 3.80 | **SQLite** |
| Batch | Update | 3.40 | 1.00 | 4.20 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | **MongoDB** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 0.00 | 0.00 | 50.00 | **SQLServer** |
| Aggregation | Statistics | 18.18 | 200.00 | 2452.17 | **SQLServer** |
| Batch | Delete | 2400000.00 | 10000000.00 | 3166666.66 | **SQLite** |
| Batch | Select | 3333333.33 | 6000000.00 | 2733333.33 | **SQLite** |
| Batch | Update | 3000000.00 | 10000000.00 | 2750000.00 | **SQLite** |
| Single | Delete | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Select | 0.00 | 0.00 | 0.00 | **MongoDB** |
| Single | Update | 0.00 | 0.00 | 0.00 | **MongoDB** |

## 各数据库详细结果

### MongoDB

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 56 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 11 | 90.91 | 5.75 | 768 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 13.04 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 5 | 2000000.00 | 0.00 | 56 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 17.15 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 18.89 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 24 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 56 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 144 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 6 | 1000.00 | 0.00 | 56 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 76.04 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 54.04 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 28 KB | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 58.70 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 28 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 63.76 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 40.66 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 36 KB | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 24 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 156 KB | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 8 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 4 | 250.00 | 15.12 | 164 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 60 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 72 KB | ✅ |
| Aggregation | Statistics | 0 | 23 | 260.87 | 5.58 | 832 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 28.89 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 4 KB | ✅ |
| Aggregation | Statistics | 0 | 2 | 3000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 4 | 2500000.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 35.80 | 488 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 0.00 | 28 KB | ✅ |
| Batch | Delete | 10,000 | 3 | 3333333.33 | 17.41 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 5 | 2000000.00 | 0.00 | 8 KB | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 8 | 1250000.00 | 7.27 | 288 KB | ✅ |
| Batch | Update | 10,000 | 4 | 2500000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 0.00 | 940 KB | ✅ |
| Batch | Update | 10,000 | 3 | 3333333.33 | 16.73 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
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
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 8 KB | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer |
|:---------|:---------|-------:|-------:|-------:|
| Aggregation | GroupBy | 60.00 | 0.00 | 3.02 |
| Aggregation | Statistics | 21.15 | 35.21 | 6.89 |
| Batch | Delete | 2.61 | 22.55 | 10.64 |
| Batch | Select | 3.43 | 12.75 | 0.00 |
| Batch | Update | 3.78 | 8.13 | 4.80 |
| Single | Delete | 20.00 | 0.00 | 0.00 |
| Single | Select | 0.00 | 0.00 | 0.00 |
| Single | Update | 0.00 | 0.00 | 0.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | MongoDB | SQLite | SQLServer |
|:---------|:---------|-----------:|-----------:|-----------:|
| Aggregation | GroupBy | 56 KB | 144 KB | 164 KB |
| Aggregation | Statistics | 768 KB | 56 KB | 832 KB |
| Batch | Delete | 56 KB | 28 KB | 488 KB |
| Batch | Select | 0 B | 28 KB | 8 KB |
| Batch | Update | 0 B | 36 KB | 940 KB |
| Single | Delete | 24 KB | 156 KB | 12 KB |
| Single | Select | 16 KB | 16 KB | 0 B |
| Single | Update | 56 KB | 8 KB | 8 KB |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| MongoDB | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| MongoDB | Batch | Insert | 12:14:27 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 12:14:26 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Single | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLServer | Batch | Insert | 12:14:25 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208.log` 文件。

---

*报告生成时间: 2025-12-08 12:14:27*
