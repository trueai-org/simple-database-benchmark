# 数据库基准测试报告

**测试时间**: 2026-01-11 02:24:20

## 测试配置

| 配置项 | 值 |
|--------|-----|
| 单次操作记录数 | 1,000 |
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
| 采集时间 | 2026-01-11 02:24:20 |


## 测试概要

| 项目 | 值 |
|------|-----|
| 测试数据库 | SQLServer, PostgreSQL |
| 数据库数量 | 2 |
| 总测试用例数 | 32 |
| 成功用例数 | 32 |
| 失败用例数 | 0 |
| 成功率 | 100.00% |

## 性能对比总览

### 操作耗时对比 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|:-------|
| IndexQuery | ComplexCondition | 230.00 | 1548.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 74.00 | 291.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 84.00 | 339.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 533.00 | 2459.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 6978.00 | 4161.00 | **SQLServer** |
| IndexQuery | Pagination | 71.00 | 319.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 9832.00 | 15333.00 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 60.00 | 228.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 80.00 | 283.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 221.00 | 234.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 288.00 | 299.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 758.00 | 164.00 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 898.00 | 520.00 | **SQLServer** |
| MillionData | Aggregation | 212.00 | 511.00 | **PostgreSQL** |
| MillionData | GroupBy | 186.00 | 152.00 | **SQLServer** |
| MillionData | PrepareData | 21958.00 | 31072.00 | **PostgreSQL** |

### 每秒操作数对比 (OPS - 越大越好)

| 操作类型 | 操作名称 | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|:-------|
| IndexQuery | ComplexCondition | 434.78 | 64.60 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 1351.35 | 343.64 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 1190.48 | 294.99 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 18.76 | 4.07 | **PostgreSQL** |
| IndexQuery | OrderBy | 14.33 | 24.03 | **SQLServer** |
| IndexQuery | Pagination | 1408.45 | 313.48 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 10.17 | 6.52 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 1666.67 | 438.60 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 1250.00 | 353.36 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 452.49 | 427.35 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 347.22 | 334.45 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 131.93 | 609.76 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 111.36 | 192.31 | **SQLServer** |
| MillionData | Aggregation | 37.74 | 15.66 | **PostgreSQL** |
| MillionData | GroupBy | 21.51 | 26.32 | **SQLServer** |
| MillionData | PrepareData | 45541.49 | 32183.32 | **PostgreSQL** |

## 各数据库详细结果

### PostgreSQL

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| IndexQuery | ComplexCondition | 100 | 230 | 434.78 | 0.85 | 144 KB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 74 | 1351.35 | 4.34 | 148 KB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 84 | 1190.48 | 3.86 | 312 KB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 533 | 18.76 | 0.12 | 80 KB | ✅ |
| IndexQuery | OrderBy | 100 | 6,978 | 14.33 | 0.01 | 0 B | ✅ |
| IndexQuery | Pagination | 10,000 | 71 | 1408.45 | 2.72 | 1.31 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 9,832 | 10.17 | 0.01 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 60 | 1666.67 | 4.28 | 4.24 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 80 | 1250.00 | 5.65 | 104 KB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 221 | 452.49 | 1.77 | 56 KB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 288 | 347.22 | 1.58 | 80 KB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 758 | 131.93 | 0.00 | 80 KB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 898 | 111.36 | 0.72 | 8.29 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 212 | 37.74 | 0.61 | 576 KB | ✅ |
| MillionData | GroupBy | 32 | 186 | 21.51 | 1.05 | 1.07 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 21,958 | 45541.49 | 2.22 | 0 B | ✅ |

### SQLServer

| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |
|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|
| IndexQuery | ComplexCondition | 100 | 1,548 | 64.60 | 0.17 | 4.83 MB | ✅ |
| IndexQuery | CompositeIndex_RegionDept | 100 | 291 | 343.64 | 1.34 | 2.23 MB | ✅ |
| IndexQuery | CompositeIndex_StatusCatPri | 100 | 339 | 294.99 | 2.30 | 3.29 MB | ✅ |
| IndexQuery | NoIndex_FullScan | 10 | 2,459 | 4.07 | 0.00 | 0 B | ✅ |
| IndexQuery | OrderBy | 100 | 4,161 | 24.03 | 0.03 | 3.52 MB | ✅ |
| IndexQuery | Pagination | 10,000 | 319 | 313.48 | 2.45 | 1.71 MB | ✅ |
| IndexQuery | PrefixQuery_Name | 100 | 15,333 | 6.52 | 0.03 | 0 B | ✅ |
| IndexQuery | PrimaryKey | 100 | 228 | 438.60 | 0.86 | 4.9 MB | ✅ |
| IndexQuery | RangeQuery_Date | 100 | 283 | 353.36 | 2.29 | 2.58 MB | ✅ |
| IndexQuery | RangeQuery_Salary | 100 | 234 | 427.35 | 0.28 | 2.18 MB | ✅ |
| IndexQuery | RangeQuery_Score | 100 | 299 | 334.45 | 1.30 | 2.89 MB | ✅ |
| IndexQuery | SingleIndex_Category | 100 | 164 | 609.76 | 3.57 | 4.1 MB | ✅ |
| IndexQuery | SingleIndex_Status | 100 | 520 | 192.31 | 2.63 | 3.38 MB | ✅ |
| MillionData | Aggregation | 1,000,000 | 511 | 15.66 | 1.02 | 644 KB | ✅ |
| MillionData | GroupBy | 32 | 152 | 26.32 | 1.71 | 2.99 MB | ✅ |
| MillionData | PrepareData | 1,000,000 | 31,072 | 32183.32 | 1.45 | 50.69 MB | ✅ |

## CPU 消耗对比 (%)

| 操作类型 | 操作名称 | PostgreSQL | SQLServer |
|:---------|:---------|-------:|-------:|
| IndexQuery | ComplexCondition | 0.85 | 0.17 |
| IndexQuery | CompositeIndex_RegionDept | 4.34 | 1.34 |
| IndexQuery | CompositeIndex_StatusCatPri | 3.86 | 2.30 |
| IndexQuery | NoIndex_FullScan | 0.12 | 0.00 |
| IndexQuery | OrderBy | 0.01 | 0.03 |
| IndexQuery | Pagination | 2.72 | 2.45 |
| IndexQuery | PrefixQuery_Name | 0.01 | 0.03 |
| IndexQuery | PrimaryKey | 4.28 | 0.86 |
| IndexQuery | RangeQuery_Date | 5.65 | 2.29 |
| IndexQuery | RangeQuery_Salary | 1.77 | 0.28 |
| IndexQuery | RangeQuery_Score | 1.58 | 1.30 |
| IndexQuery | SingleIndex_Category | 0.00 | 3.57 |
| IndexQuery | SingleIndex_Status | 0.72 | 2.63 |
| MillionData | Aggregation | 0.61 | 1.02 |
| MillionData | GroupBy | 1.05 | 1.71 |
| MillionData | PrepareData | 2.22 | 1.45 |

## 内存消耗对比

| 操作类型 | 操作名称 | PostgreSQL | SQLServer |
|:---------|:---------|-----------:|-----------:|
| IndexQuery | ComplexCondition | 144 KB | 4.83 MB |
| IndexQuery | CompositeIndex_RegionDept | 148 KB | 2.23 MB |
| IndexQuery | CompositeIndex_StatusCatPri | 312 KB | 3.29 MB |
| IndexQuery | NoIndex_FullScan | 80 KB | 0 B |
| IndexQuery | OrderBy | 0 B | 3.52 MB |
| IndexQuery | Pagination | 1.31 MB | 1.71 MB |
| IndexQuery | PrefixQuery_Name | 0 B | 0 B |
| IndexQuery | PrimaryKey | 4.24 MB | 4.9 MB |
| IndexQuery | RangeQuery_Date | 104 KB | 2.58 MB |
| IndexQuery | RangeQuery_Salary | 56 KB | 2.18 MB |
| IndexQuery | RangeQuery_Score | 80 KB | 2.89 MB |
| IndexQuery | SingleIndex_Category | 80 KB | 4.1 MB |
| IndexQuery | SingleIndex_Status | 8.29 MB | 3.38 MB |
| MillionData | Aggregation | 576 KB | 644 KB |
| MillionData | GroupBy | 1.07 MB | 2.99 MB |
| MillionData | PrepareData | 0 B | 50.69 MB |

## 详细日志

完整的测试日志请查看 `logs/benchmark_20260111.log` 文件。

---

*报告生成时间: 2026-01-11 02:24:20*
