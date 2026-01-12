# 数据库基准测试报告

**测试时间**: 2026-01-12 18:19:07

## 测试配置

| 配置项 | 值 |
|--------|-----|
| 单次操作记录数 | 100 |
| 批量操作批次大小 | 1,000 |
| 批量操作批次数 | 5 |
| 预热迭代次数 | 3 |
| 测试迭代次数 | 5 |

## 服务器信息

| 项目 | 值 |
|------|-----|
| 机器名称 | DESKTOP-RLEON3G |
| 操作系统 | Microsoft Windows 10.0.19045 |
| OS 架构 | X64 |
| 进程架构 | X64 |
| 处理器数量 | 24 |
| .NET 版本 | .NET 8.0.22 |
| 总内存 | 31.81 GB |
| 采集时间 | 2026-01-12 18:19:07 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | Oracle |
| 数据库数量 | 1 |
| 总测试用例数 | 67 |
| 成功用例数 | 65 |
| 失败用例数 | 2 |
| 成功率 | 97.01% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 15.60 | **Oracle** |
| Aggregation | Statistics | 27.40 | **Oracle** |
| Batch | Delete | 1217.40 | **Oracle** |
| Batch | Insert | 4711.80 | **Oracle** |
| Batch | Select | 45.00 | **Oracle** |
| Batch | Update | 4723.60 | **Oracle** |
| IndexQuery | ComplexCondition | 581.00 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 168.00 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 124.00 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 131.00 | **Oracle** |
| IndexQuery | OrderBy | 1207.00 | **Oracle** |
| IndexQuery | Pagination | 161.00 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 1364.00 | **Oracle** |
| IndexQuery | RangeQuery_Date | 338.00 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 172.00 | **Oracle** |
| IndexQuery | RangeQuery_Score | 179.00 | **Oracle** |
| IndexQuery | SingleIndex_Category | 109.00 | **Oracle** |
| IndexQuery | SingleIndex_Status | 105.00 | **Oracle** |
| MillionData | Aggregation | 27.00 | **Oracle** |
| MillionData | Cleanup | 3.00 | **Oracle** |
| MillionData | GroupBy | 44.00 | **Oracle** |
| Single | Delete | 165.20 | **Oracle** |
| Single | Insert | 108.00 | **Oracle** |
| Single | Select | 108.40 | **Oracle** |
| Single | Update | 179.40 | **Oracle** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | Oracle | 最快 |
|:---------|:---------|-------:|:-------|
| Aggregation | GroupBy | 66.23 | **Oracle** |
| Aggregation | Statistics | 274.22 | **Oracle** |
| Batch | Delete | 5044.59 | **Oracle** |
| Batch | Insert | 1063.34 | **Oracle** |
| Batch | Select | 114509.66 | **Oracle** |
| Batch | Update | 1061.88 | **Oracle** |
| IndexQuery | ComplexCondition | 172.12 | **Oracle** |
| IndexQuery | CompositeIndex_RegionDept | 595.24 | **Oracle** |
| IndexQuery | CompositeIndex_StatusCatPri | 806.45 | **Oracle** |
| IndexQuery | NoIndex_FullScan | 76.34 | **Oracle** |
| IndexQuery | OrderBy | 82.85 | **Oracle** |
| IndexQuery | Pagination | 621.12 | **Oracle** |
| IndexQuery | PrefixQuery_Name | 73.31 | **Oracle** |
| IndexQuery | RangeQuery_Date | 295.86 | **Oracle** |
| IndexQuery | RangeQuery_Salary | 581.40 | **Oracle** |
| IndexQuery | RangeQuery_Score | 558.66 | **Oracle** |
| IndexQuery | SingleIndex_Category | 917.43 | **Oracle** |
| IndexQuery | SingleIndex_Status | 952.38 | **Oracle** |
| MillionData | Aggregation | 296.30 | **Oracle** |
| MillionData | Cleanup | 0.00 | **Oracle** |
| MillionData | GroupBy | 90.91 | **Oracle** |
| Single | Delete | 606.43 | **Oracle** |
| Single | Insert | 926.95 | **Oracle** |
| Single | Select | 925.64 | **Oracle** |
| Single | Update | 559.67 | **Oracle** |

## 各数据库详细结果

### Oracle

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| Aggregation | GroupBy | 8 | 22 | 45.45 | 0.00 | 288 KB | ✅ |
| Aggregation | GroupBy | 8 | 14 | 71.43 | 0.00 | 132 KB | ✅ |
| Aggregation | GroupBy | 8 | 14 | 71.43 | 0.00 | 0 B | ✅ |
| Aggregation | GroupBy | 8 | 14 | 71.43 | 0.00 | 280 KB | ✅ |
| Aggregation | GroupBy | 8 | 14 | 71.43 | 0.00 | 36 KB | ✅ |
| Aggregation | Statistics | 5,000 | 61 | 98.36 | 2.11 | 608 KB | ✅ |
| Aggregation | Statistics | 5,000 | 18 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 18 | 333.33 | 0.00 | 0 B | ✅ |
| Aggregation | Statistics | 5,000 | 18 | 333.33 | 0.00 | 24 KB | ✅ |
| Aggregation | Statistics | 5,000 | 22 | 272.73 | 0.00 | 0 B | ✅ |
| Batch | Delete | 5,000 | 1,310 | 3816.79 | 0.30 | 5.07 MB | ✅ |
| Batch | Delete | 5,000 | 1,063 | 4703.67 | 0.00 | 3.14 MB | ✅ |
| Batch | Delete | 5,000 | 687 | 7278.02 | 0.00 | 3.1 MB | ✅ |
| Batch | Delete | 5,000 | 686 | 7288.63 | 0.00 | 3.13 MB | ✅ |
| Batch | Delete | 5,000 | 2,341 | 2135.84 | 0.00 | 3.08 MB | ✅ |
| Batch | Insert | 5,000 | 4,473 | 1117.82 | 0.83 | 14.24 MB | ✅ |
| Batch | Insert | 5,000 | 4,444 | 1125.11 | 0.31 | 8.66 MB | ✅ |
| Batch | Insert | 5,000 | 4,805 | 1040.58 | 0.11 | 7.8 MB | ✅ |
| Batch | Insert | 5,000 | 4,941 | 1011.94 | 0.16 | 10.64 MB | ✅ |
| Batch | Insert | 5,000 | 4,896 | 1021.24 | 0.21 | 10.13 MB | ✅ |
| Batch | Select | 5,000 | 59 | 84745.76 | 1.09 | 60 KB | ✅ |
| Batch | Select | 5,000 | 49 | 102040.82 | 2.65 | 0 B | ✅ |
| Batch | Select | 5,000 | 37 | 135135.14 | 0.00 | 0 B | ✅ |
| Batch | Select | 5,000 | 42 | 119047.62 | 1.53 | 176 KB | ✅ |
| Batch | Select | 5,000 | 38 | 131578.95 | 0.00 | 88 KB | ✅ |
| Batch | Update | 5,000 | 4,713 | 1060.90 | 0.28 | 10.58 MB | ✅ |
| Batch | Update | 5,000 | 4,707 | 1062.25 | 0.12 | 12.54 MB | ✅ |
| Batch | Update | 5,000 | 4,509 | 1108.89 | 0.22 | 17.06 MB | ✅ |
| Batch | Update | 5,000 | 4,459 | 1121.33 | 0.09 | 16.99 MB | ✅ |
| Batch | Update | 5,000 | 5,230 | 956.02 | 0.17 | 21.79 MB | ✅ |
| IndexQuery | ComplexCondition | 100 | 581 | 172.12 | 0.45 | 5.16 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 168 | 595.24 | 1.94 | 208 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 124 | 806.45 | 1.05 | 20 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 131 | 76.34 | 0.49 | 8 KB | ✅ |
| IndexQuery | OrderBy | 100 | 1,207 | 82.85 | 0.16 | 56 KB | ✅ |
| IndexQuery | Pagination | 10,000 | 161 | 621.12 | 0.81 | 20 KB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 1,364 | 73.31 | 0.14 | 3.61 MB | ✅ |
| IndexQuery | PrimaryKey | 100 | 0 | N/A | N/A | N/A | ❌ |
| IndexQuery | RangeQuery_Date | 100 | 338 | 295.86 | 0.77 | 364 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 172 | 581.40 | 0.38 | 0 B | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 179 | 558.66 | 2.54 | 192 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 109 | 917.43 | 2.39 | 0 B | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 105 | 952.38 | 0.61 | 4 KB | ✅ |
| MillionData | Aggregation | 0 | 27 | 296.30 | 0.00 | 28 KB | ✅ |
| MillionData | Cleanup | 0 | 3 | 0.00 | 16.97 | 0 B | ✅ |
| MillionData | GroupBy | 0 | 44 | 90.91 | 1.47 | 4 KB | ✅ |
| MillionData | PrepareData | 10,000 | 0 | N/A | N/A | N/A | ❌ |
| Single | Delete | 100 | 172 | 581.40 | 1.14 | 188 KB | ✅ |
| Single | Delete | 100 | 159 | 628.93 | 0.00 | 0 B | ✅ |
| Single | Delete | 100 | 172 | 581.40 | 0.76 | 1.73 MB | ✅ |
| Single | Delete | 100 | 155 | 645.16 | 0.42 | 0 B | ✅ |
| Single | Delete | 100 | 168 | 595.24 | 1.54 | 0 B | ✅ |
| Single | Insert | 100 | 113 | 884.96 | 0.57 | 0 B | ✅ |
| Single | Insert | 100 | 109 | 917.43 | 0.60 | 3.41 MB | ✅ |
| Single | Insert | 100 | 103 | 970.87 | 0.63 | 3.43 MB | ✅ |
| Single | Insert | 100 | 105 | 952.38 | 2.47 | 3.43 MB | ✅ |
| Single | Insert | 100 | 110 | 909.09 | 0.59 | 3.43 MB | ✅ |
| Single | Select | 100 | 121 | 826.45 | 1.61 | 736 KB | ✅ |
| Single | Select | 100 | 108 | 925.93 | 1.80 | 252 KB | ✅ |
| Single | Select | 100 | 103 | 970.87 | 0.63 | 4 KB | ✅ |
| Single | Select | 100 | 106 | 943.40 | 1.84 | 0 B | ✅ |
| Single | Select | 100 | 104 | 961.54 | 1.24 | 0 B | ✅ |
| Single | Update | 100 | 201 | 497.51 | 0.65 | 2.14 MB | ✅ |
| Single | Update | 100 | 168 | 595.24 | 0.77 | 3.57 MB | ✅ |
| Single | Update | 100 | 170 | 588.24 | 1.15 | 1.98 MB | ✅ |
| Single | Update | 100 | 178 | 561.80 | 1.09 | 2.04 MB | ✅ |
| Single | Update | 100 | 180 | 555.56 | 0.36 | 2.06 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-------:|
| Aggregation | GroupBy | 0.00 |
| Aggregation | Statistics | 0.42 |
| Batch | Delete | 0.06 |
| Batch | Insert | 0.32 |
| Batch | Select | 1.05 |
| Batch | Update | 0.18 |
| IndexQuery | ComplexCondition | 0.45 |
| IndexQuery | CompositeIndex_RegionDept | 1.94 |
| IndexQuery | CompositeIndex_StatusCatPri | 1.05 |
| IndexQuery | NoIndex_FullScan | 0.49 |
| IndexQuery | OrderBy | 0.16 |
| IndexQuery | Pagination | 0.81 |
| IndexQuery | PrefixQuery_Name | 0.14 |
| IndexQuery | RangeQuery_Date | 0.77 |
| IndexQuery | RangeQuery_Salary | 0.38 |
| IndexQuery | RangeQuery_Score | 2.54 |
| IndexQuery | SingleIndex_Category | 2.39 |
| IndexQuery | SingleIndex_Status | 0.61 |
| MillionData | Aggregation | 0.00 |
| MillionData | Cleanup | 16.97 |
| MillionData | GroupBy | 1.47 |
| Single | Delete | 0.77 |
| Single | Insert | 0.97 |
| Single | Select | 1.42 |
| Single | Update | 0.80 |

## 内存消耗对比

| 操作类型 | 操作名称 | Oracle |
|:---------|:---------|-----------:|
| Aggregation | GroupBy | 288 KB |
| Aggregation | Statistics | 608 KB |
| Batch | Delete | 5.07 MB |
| Batch | Insert | 14.24 MB |
| Batch | Select | 176 KB |
| Batch | Update | 21.79 MB |
| IndexQuery | ComplexCondition | 5.16 MB |
| IndexQuery | CompositeIndex_RegionDept | 208 KB |
| IndexQuery | CompositeIndex_StatusCatPri | 20 KB |
| IndexQuery | NoIndex_FullScan | 8 KB |
| IndexQuery | OrderBy | 56 KB |
| IndexQuery | Pagination | 20 KB |
| IndexQuery | PrefixQuery_Name | 3.61 MB |
| IndexQuery | RangeQuery_Date | 364 KB |
| IndexQuery | RangeQuery_Salary | 0 B |
| IndexQuery | RangeQuery_Score | 192 KB |
| IndexQuery | SingleIndex_Category | 0 B |
| IndexQuery | SingleIndex_Status | 4 KB |
| MillionData | Aggregation | 28 KB |
| MillionData | Cleanup | 0 B |
| MillionData | GroupBy | 4 KB |
| Single | Delete | 1.73 MB |
| Single | Insert | 3.43 MB |
| Single | Select | 736 KB |
| Single | Update | 3.57 MB |

## 失败用例

| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |
|:-------|:---------|:---------|:---------|:---------|
| Oracle | MillionData | PrepareData | 18:19:02 | ORA-39826: 无法解析视图或同义词 (BENCHMARK.TEST_ENTITY) 的直接路径加载。 https://docs.oracle.com/error-help/db/ora-398... |
| Oracle | IndexQuery | PrimaryKey | 18:19:02 | 'minValue' cannot be greater than maxValue. (Parameter 'minValue') |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260112.log` 文件。

---

*报告生成时间: 2026-01-12 18:19:07*
