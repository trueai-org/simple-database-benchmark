# SimpleDatabaseBenchmark - 数据库基准测试工具

一个用于对比测试多种数据库性能的 .NET 控制台应用程序。

## 🏆 性能对比分析

### 📈 综合排名

| 排名 | 数据库 | 综合评分 | 适用场景 |
|------|--------|----------|----------|
| 🥇 | **MongoDB** | ⭐⭐⭐⭐⭐ | 高并发写入、NoSQL 场景 |
| 🥈 | **PostgreSQL** | ⭐⭐⭐⭐ | 通用场景、数据分析 |
| 🥉 | **SQLite** | ⭐⭐⭐⭐ | 轻量级、嵌入式、读多写少 |
| 4 | **MySQL** | ⭐⭐⭐ | 传统 Web 应用、LAMP 架构 |
| 5 | **SQL Server** | ⭐⭐⭐ | 企业级 Windows 生态 |

### 最终容器状态

| NAME             | CPU % | MEM USAGE / LIMIT     | MEM %  | NET I/O           | AVG CPU % |
|------------------|-------|-----------------------|--------|-------------------|-----------|
| bench_postgresql | 0.00% | 54.27MiB / 15.52GiB   | 0.34%  | 50.8MB / 32.6MB   | 18%       |
| bench_mysql      | 0.23% | 421.5MiB / 15.52GiB   | 2.65%  | 41.9MB / 34.9MB   | 16%       |
| bench_mongodb    | 0.09% | 137.9MiB / 15.52GiB   | 0.87%  | 29.4MB / 41.8MB   | 32%       |
| bench_sqlserver  | 1.15% | 3.251GiB / 15.52GiB   | 20.95% | 144MB / 44.9MB    | 86%       |

### 一、单条操作性能 (越小越好)

| 操作 | 🥇 第一名 | 🥈 第二名 | 🥉 第三名 | 最慢 |
|------|---------|---------|---------|------|
| **Insert** | MongoDB (251ms) | SQLServer (1131ms) | PostgreSQL (1557ms) | MySQL (4455ms) |
| **Select** | SQLite (98ms) | PostgreSQL (319ms) | MongoDB (390ms) | SQLServer (984ms) |
| **Update** | MongoDB (435ms) | PostgreSQL (1603ms) | SQLite (2094ms) | MySQL (5344ms) |
| **Delete** | MongoDB (381ms) | SQLServer (1141ms) | PostgreSQL (1533ms) | MySQL (6283ms) |

**结论**: 单条操作中，**MongoDB 在写入操作（Insert/Update/Delete）上表现最优**，SQLite 在单条查询上速度最快。

---

### 二、批量操作性能 (越小越好)

| 操作 | 🥇 第一名 | 🥈 第二名 | 🥉 第三名 | 最慢 |
|------|---------|---------|---------|------|
| **Insert** | MongoDB (96ms) | MySQL (503ms) | PostgreSQL (517ms) | SQLServer (7907ms) |
| **Select** | SQLite (16ms) | PostgreSQL (28ms) | SQLServer (48ms) | MongoDB (60ms) |
| **Update** | MongoDB (585ms) | SQLite (667ms) | MySQL (716ms) | SQLServer (10189ms) |
| **Delete** | SQLite (38ms) | PostgreSQL (124ms) | MongoDB (141ms) | SQLServer (811ms) |

**结论**: 批量操作中，**MongoDB 批量写入性能卓越**，**SQLite 在批量读取和删除上最快**。

---

### 三、聚合查询性能 (越小越好)

| 操作 | 🥇 第一名 | 🥈 第二名 | 🥉 第三名 |
|------|---------|---------|---------|
| **GroupBy** | PostgreSQL (3. 2ms) | SQLite (3.4ms) | MongoDB (9.2ms) |
| **Statistics** | SQLite (9.6ms) | PostgreSQL (10.8ms) | MongoDB (13.8ms) |

**结论**: **PostgreSQL 和 SQLite 在聚合分析场景表现最优**。

---

### 四、百万数据索引查询性能 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|:-------|
| IndexQuery | ComplexCondition | 3329.00 | 43911.00 | 3922.00 | 24742.00 | 1481.00 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 95.00 | 457.00 | 155.00 | 54.00 | 188.00 | **SQLite** |
| IndexQuery | CompositeIndex_StatusCatPri | 99.00 | 867.00 | 256.00 | 71.00 | 184.00 | **SQLite** |
| IndexQuery | NoIndex_FullScan | 4152.00 | 7324.00 | 531.00 | 3023.00 | 2634.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 36034.00 | 55827.00 | 3952.00 | 28808.00 | 4463.00 | **PostgreSQL** |
| IndexQuery | Pagination | 204.00 | 345.00 | 75.00 | 90.00 | 231.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 58.00 | 67525.00 | 8984.00 | 24050.00 | 15437.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 53.00 | 113.00 | 44.00 | 12.00 | 118.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 102.00 | 418.00 | 122.00 | 76.00 | 201.00 | **SQLite** |
| IndexQuery | RangeQuery_Salary | 106.00 | 406.00 | 113.00 | 95.00 | 186.00 | **SQLite** |
| IndexQuery | RangeQuery_Score | 112.00 | 546.00 | 88.00 | 95.00 | 183.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 101.00 | 201.00 | 110.00 | 39.00 | 105.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 109.00 | 188.00 | 62.00 | 42.00 | 108.00 | **SQLite** |
| MillionData | Aggregation | 846.00 | 1550.00 | 282.00 | 366.00 | 457.00 | **PostgreSQL** |
| MillionData | GroupBy | 1175.00 | 1707.00 | 198.00 | 5377.00 | 117.00 | **SQLServer** |
| MillionData | PrepareData | 8559.00 | 78290.00 | 125044.00 | 103747.00 | 949774.00 | **MongoDB** |

## 功能特点

- **支持多种数据库**: MySQL, SQL Server, PostgreSQL, SQLite, MongoDB
- **多种测试场景**: 
  - 单条增删改查 (CRUD)
  - 批量增删改查
  - 统计汇总 (Count, Sum, Avg, Max, Min)
  - 分组汇总 (Group By)
- **百万级数据索引测试**:
  - 主键查询、单字段索引查询、复合索引查询
  - 范围查询 (评分、日期、薪资)
  - 前缀模糊查询、分页查询、排序查询
  - 复杂条件组合查询
  - 无索引全表扫描对比测试
  - 百万级数据聚合统计和分组统计
- **性能监控**: 
  - 操作耗时 (毫秒)
  - 每秒操作数 (OPS)
  - CPU 消耗 (%)
  - 内存消耗
- **详细日志**: 使用 Serilog，同时输出到控制台和文件
- **自动报告**: 生成 Markdown 格式的测试报告

## 技术栈

- **.NET 8.0**
- **FreeSql**: MySQL, SQL Server, PostgreSQL, SQLite 的 ORM
- **MongoDB Driver**: MongoDB 官方驱动
- **Serilog**: 日志框架

## 项目结构

```
SimpleDatabaseBenchmark/
├── src/
│   └── SimpleDatabaseBenchmark/
│       ├── Models/           # 数据模型
│       ├── Services/         # 测试服务
│       ├── Reports/          # 报告生成
│       ├── Utils/            # 工具类
│       ├── Program.cs        # 程序入口
│       └── appsettings.json  # 配置文件
├── results/                  # 测试报告
└── README.md
```

## 快速开始

### 1. 环境要求

- .NET 8. 0 SDK
- 至少一个数据库服务（MySQL/SQL Server/PostgreSQL/MongoDB）
- SQLite 无需额外安装

### 2. 启动数据库

使用 Docker 快速启动所有测试数据库：

> SQL Server 启动容器后需要手动创建 benchmark_test 数据库。

```bash
# Linux/macOS
chmod +x start.sh
./start.sh

# Windows (PowerShell)
.\start.ps1
```

### 3. 数据库连接信息

| 数据库 | 地址 | 端口 | 用户名 | 密码 | 数据库名 |
|--------|------|------|--------|------|----------|
| MySQL | localhost | 3306 | root | 123456 | benchmark_test |
| SQL Server | localhost | 1433 | sa | Benchmark@123 | benchmark_test |
| PostgreSQL | localhost | 5432 | postgres | 123456 | benchmark_test |
| MongoDB | localhost | 7017 | - | - | benchmark_test |
| SQLite | - | - | - | - | benchmark_test. db |

编辑 `appsettings.json` 文件，配置各数据库的连接字符串：

```json
{
  "ConnectionStrings": {
    "MySql": "Server=localhost;Port=3306;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;",
    "SqlServer": "Server=localhost,1433;Database=benchmark_test;User Id=sa;Password=Benchmark@123;Persist Security Info=True;TrustServerCertificate=True;",
    "PostgreSql": "Host=localhost;Port=5432;Database=benchmark_test;Username=postgres;Password=123456;",
    "Sqlite": "Data Source=benchmark_test.db;",
    "MongoDb": "mongodb://localhost:27017"
  }
}
```

> 提示：如果某个数据库未安装，可以将对应的连接字符串留空或删除，程序会自动跳过。

### 4. 停止数据库

```bash
# Linux/macOS
./stop.sh

# Windows (PowerShell)
.\stop.ps1
```

### 3.  运行测试

```bash
cd src/SimpleDatabaseBenchmark
dotnet run
```

或者使用 Release 模式运行以获得更准确的性能数据：

```bash
dotnet run -c Release
```

### 4. 查看结果

- **测试报告**: `results/` 目录下的 Markdown 文件
- **日志文件**: `logs/` 目录下的日志文件

## 测试配置

可以在 `appsettings.json` 中调整测试参数：

### 基础测试配置

```json
{
  "BenchmarkSettings": {
    "SingleOperationCount": 1000,
    "BatchSize": 1000,
    "BatchOperationCount": 10,
    "WarmupIterations": 3,
    "TestIterations": 5
  }
}
```

| 参数 | 说明 | 默认值 |
|------|------|--------|
| `SingleOperationCount` | 单条操作测试的记录数 | 1000 |
| `BatchSize` | 批量操作每批的记录数 | 1000 |
| `BatchOperationCount` | 批量操作的批次数 | 10 |
| `WarmupIterations` | 预热迭代次数 | 3 |
| `TestIterations` | 正式测试迭代次数 | 5 |

### 百万级数据索引测试配置

```json
{
  "BenchmarkSettings": {
    "EnableMillionDataTest": true,
    "MillionDataCount": 1000000,
    "MillionBatchSize": 10000,
    "IndexQueryCount": 100,
    "PageSize": 100,
    "PageCount": 100
  }
}
```

| 参数 | 说明 | 默认值 |
|------|------|--------|
| `EnableMillionDataTest` | 是否启用百万级数据索引测试 | false |
| `MillionDataCount` | 百万级测试的总数据量 | 1000000 |
| `MillionBatchSize` | 百万级数据插入的批次大小 | 10000 |
| `IndexQueryCount` | 索引查询测试的执行次数 | 100 |
| `PageSize` | 分页查询测试的每页记录数 | 100 |
| `PageCount` | 分页查询测试的总页数 | 100 |

### 完整配置示例

```json
{
  "ConnectionStrings": {
    "MySql": "Server=localhost;Port=3306;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;",
    "SqlServer": "Data Source=localhost;Initial Catalog=benchmark_test;User ID=sa;Password=Benchmark@123;Persist Security Info=True;TrustServerCertificate=True;",
    "PostgreSql": "Host=localhost;Port=5432;Database=benchmark_test;Username=postgres;Password=123456;",
    "Sqlite": "Data Source=benchmark_test.db;",
    "MongoDb": "mongodb://localhost:27017"
  },
  "BenchmarkSettings": {
    "SingleOperationCount": 1000,
    "BatchSize": 1000,
    "BatchOperationCount": 10,
    "WarmupIterations": 3,
    "TestIterations": 5,

    "EnableMillionDataTest": true,
    "MillionDataCount": 1000000,
    "MillionBatchSize": 10000,
    "IndexQueryCount": 100,
    "PageSize": 100,
    "PageCount": 100
  },
  "Serilog": {
    "MinimumLevel": {
      "Default": "Information",
      "Override": {
        "Microsoft": "Warning",
        "System": "Warning"
      }
    }
  }
}
```

> **注意**: 百万级数据测试会消耗较多时间和资源，建议在测试环境中运行。可根据实际需求调整 `MillionDataCount` 参数（如 100000、500000、1000000）。

## 百万级数据索引测试说明

当 `EnableMillionDataTest` 设置为 `true` 时，程序会在常规测试完成后执行以下索引性能测试：

### 测试流程

1. **数据准备**: 批量插入百万级测试数据
2. **创建索引**: 为各字段创建单字段和复合索引
3. **索引查询测试**: 执行多种索引查询场景
4. **聚合统计测试**: 百万级数据聚合和分组统计
5. **数据清理**: 清理测试数据

### 索引查询测试场景

| 测试类型 | 测试名称 | 说明 |
|----------|----------|------|
| **主键查询** | PrimaryKey | 按主键 ID 查询单条记录 |
| **单字段索引** | SingleIndex_Status | 按状态字段查询 |
| **单字段索引** | SingleIndex_Category | 按分类字段查询 |
| **复合索引** | CompositeIndex_RegionDept | 按地区+部门复合条件查询 |
| **复合索引** | CompositeIndex_StatusCatPri | 按状态+分类+优先级复合条件查询 |
| **范围查询** | RangeQuery_Score | 按评分范围查询 |
| **范围查询** | RangeQuery_Date | 按创建时间范围查询 |
| **范围查询** | RangeQuery_Salary | 按薪资范围查询 |
| **前缀查询** | PrefixQuery_Name | 按名称前缀模糊查询 |
| **分页查询** | Pagination | 带排序的分页查询 |
| **排序查询** | OrderBy | 多字段排序查询 |
| **复杂查询** | ComplexCondition | 多条件组合查询 |
| **全表扫描** | NoIndex_FullScan | 无索引字段模糊查询（对比测试） |

### 创建的索引

程序会自动创建以下索引用于测试：

| 索引名称 | 索引字段 | 索引类型 |
|----------|----------|----------|
| idx_status | Status | 单字段索引 |
| idx_category | Category | 单字段索引 |
| idx_score | Score | 单字段索引 |
| idx_salary | Salary | 单字段索引 |
| idx_created_at | CreatedAt | 单字段索引 |
| idx_priority | Priority | 单字段索引 |
| idx_name | Name | 单字段索引（前缀） |
| idx_region_dept | Region, Department | 复合索引 |
| idx_status_cat_pri | Status, Category, Priority | 复合索引 |

### 测试数据字段

百万级测试数据包含以下字段，用于模拟真实业务场景：

| 字段名 | 类型 | 说明 | 示例值 |
|--------|------|------|--------|
| Id | long | 主键自增 ID | 1, 2, 3... |
| Name | string | 用户名 | User_12345_abc... |
| Email | string | 邮箱 | user123@example.com |
| Age | int | 年龄 | 18-65 |
| Salary | decimal | 薪资 | 30000-130000 |
| Department | string | 部门 | Engineering, Sales, HR... |
| Category | string | 分类 | Electronics, Clothing, Food... |
| Status | int | 状态 | 0-待处理, 1-处理中, 2-已完成, 3-已取消 |
| Score | decimal | 评分 | 0-100 |
| Region | string | 地区 | North, South, East, West... |
| Tags | string | 标签 | hot,new / sale,popular... |
| Priority | int | 优先级 | 1-5 |
| Quantity | int | 数量 | 1-1000 |
| IsActive | bool | 是否激活 | true/false |
| CreatedAt | DateTime | 创建时间 | 过去一年内随机日期 |
| ExpireAt | DateTime? | 过期时间 | 未来一年内随机日期或 null |
| Description | string | 描述 | 测试描述文本 |

## 测试用例说明

### 单条操作
- **Insert**: 逐条插入记录
- **Select**: 按主键逐条查询
- **Update**: 逐条更新记录
- **Delete**: 逐条删除记录

### 批量操作
- **Batch Insert**: 批量插入记录
- **Batch Select**: 分页批量查询
- **Batch Update**: 批量更新记录
- **Batch Delete**: 批量删除记录

### 统计汇总
- **Statistics**: Count, Sum, Avg, Max, Min 聚合查询
- **GroupBy**: 按部门分组统计

## 注意事项

1. 测试前请确保数据库服务已启动
2.  请在测试环境运行，避免影响生产数据
3.  首次运行会自动创建测试数据库和表
4. 每轮测试前会清空测试数据

## 许可证

MIT License

## 测试结果历史

<!-- BENCHMARK_RESULTS_START -->
- [2026-01-10 19:03:58](results/benchmark_report_20260110_190358.md) - 基准测试报告
- [百万数据索引性能 - 2026-01-10 17:28:36](results/benchmark_report_20260110_172836.md) - 基准测试报告
- [50万数据 - 2025-12-09 18:24:49](results/benchmark_report_20251209_182449.md) - 基准测试报告
- [10万数据 - 2025-12-09 13:22:41](results/benchmark_report_20251209_132241.md) - 基准测试报告
- [2025-12-09 12:41:11](results/benchmark_report_20251209_124111.md) - 基准测试报告
- [2025-12-09 12:23:47](results/benchmark_report_20251209_122347.md) - 基准测试报告
- [2025-12-09 12:07:07](results/benchmark_report_20251209_120707.md) - 基准测试报告
- [2025-12-09 09:22:18](results/benchmark_report_20251209_092218.md) - 基准测试报告
- [2025-12-08 18:21:00](results/benchmark_report_20251208_182100.md) - 基准测试报告
<!-- BENCHMARK_RESULTS_END -->