# 数据库基准测试报告

**测试时间**: 2025-12-08 11:46:29

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
| 采集时间 | 2025-12-08 11:46:29 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | SQLite |
| 数据库数量 | 1 |
| 总测试用例数 | 50 |
| 成功用例数 | 40 |
| 失败用例数 | 10 |
| 成功率 | 80.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | SQLite | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 0.80 | **SQLite** |
| Aggregation | Statistics | 5.00 | **SQLite** |
| Batch | Delete | 1.00 | **SQLite** |
| Batch | Select | 0.60 | **SQLite** |
| Batch | Update | 2.00 | **SQLite** |
| Single | Delete | 0.00 | **SQLite** |
| Single | Select | 0.00 | **SQLite** |
| Single | Update | 0.00 | **SQLite** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | SQLite | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 50.00 | **SQLite** |
| Aggregation | Statistics | 48.00 | **SQLite** |
| Batch | Delete | 10000000.00 | **SQLite** |
| Batch | Select | 6000000.00 | **SQLite** |
| Batch | Update | 8333333.33 | **SQLite** |
| Single | Delete | 0.00 | **SQLite** |
| Single | Select | 0.00 | **SQLite** |
| Single | Update | 0.00 | **SQLite** |

## 各数据库详细结果

### SQLite

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 0 | 4 | 250.00 | 13.64 | 128 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 100.00 | 8 KB | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 0 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Aggregation | Statistics | 0 | 25 | 240.00 | 2.56 | 740 KB | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 0 | 0 | 0.00 | 80.14 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 56.51 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Delete | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Insert | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 4 KB | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 1 | 10000000.00 | 60.74 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Select | 10,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 6 | 1666666.67 | 0.00 | 260 KB | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 61.59 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 60.79 | 0 B | ✅ |
| Batch | Update | 10,000 | 1 | 10000000.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Delete | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Insert | 1,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 12 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 16 KB | ✅ |
| Single | Select | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 100.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |
| Single | Update | 1,000 | 0 | 0.00 | 0.00 | 0 B | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | SQLite |
|:---------|:---------|-------:|
| Aggregation | GroupBy | 22.73 |
| Aggregation | Statistics | 16.54 |
| Batch | Delete | 11.30 |
| Batch | Select | 12.15 |
| Batch | Update | 24.48 |
| Single | Delete | 20.00 |
| Single | Select | 20.00 |
| Single | Update | 20.00 |

## 内存消耗对比

| 操作类型 | 操作名称 | SQLite |
|:---------|:---------|-----------:|
| Aggregation | GroupBy | 128 KB |
| Aggregation | Statistics | 740 KB |
| Batch | Delete | 4 KB |
| Batch | Select | 4 KB |
| Batch | Update | 260 KB |
| Single | Delete | 0 B |
| Single | Select | 16 KB |
| Single | Update | 0 B |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| SQLite | Single | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Single | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |
| SQLite | Batch | Insert | 11:46:29 | Index and length must refer to a location within the string. (Parameter 'length') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20251208. log` 文件。

---

*报告生成时间: 2025-12-08 11:46:29*
