# SimpleDatabaseBenchmark - 数据库基准测试工具

一个用于对比测试多种数据库性能的 .NET 控制台应用程序。

## 🏆 性能对比分析

### 📈 综合排名

| 排名 | 数据库 | 综合评分 | 适用场景 |
|------|--------|----------|----------|
| 🥇 | **MongoDB 8.0** | ⭐⭐⭐⭐⭐ | 高并发写入、NoSQL 场景、10万+/s |
| 🥈 | **PostgreSQL 18** | ⭐⭐⭐⭐⭐ | 通用场景、数据分析 |
| 🥉 | **SQLite 3** | ⭐⭐⭐⭐ | 轻量级、嵌入式、读多写少 |
| 4 | **MariaDB 11** | ⭐⭐⭐⭐ | 略优于 MySQL |
| 5 | **MySQL 8.4** | ⭐⭐⭐⭐ | 传统 Web 应用 |
| 6 | **SQL Server 2022** | ⭐⭐⭐ | 企业级 Windows 生态 |

### 最终容器状态

| NAME             | MEM USAGE / LIMIT     | AVG CPU % |
|------------------|-----------------------|-----------|
| bench_postgresql | 313.7MiB / 15.52GiB   | 20%       |
| bench_mysql      | 1.342GiB / 15.52GiB   | 16%       |
| bench_mongodb    | 904.8MiB / 15.52GiB   | 32%       |
| bench_sqlserver  | 4.582GiB / 15.52GiB   | 86%       |
| bench_mariadb    | 798.2MiB / 15.52GiB   | 13%       |

### 关系型数据库 - 单条/批量/聚合/百万数据索引性能 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MySQL | PostgreSQL | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.40 | 5.60 | 1.20 | 29.20 | **PostgreSQL** |
| Aggregation | Statistics | 8.80 | 13.60 | 5.60 | 8.20 | **PostgreSQL** |
| Batch | Delete | 63.40 | 110.00 | 18.00 | 210.40 | **PostgreSQL** |
| Batch | Insert | 365.40 | 406.40 | 489.40 | 4833.60 | **MariaDB** |
| Batch | Select | 25.80 | 28.20 | 75.40 | 15.80 | **SQLServer** |
| Batch | Update | 253.00 | 324.60 | 369.20 | 2587.40 | **MariaDB** |
| IndexQuery | ComplexCondition | 9773.00 | 1576.00 | 7705.00 | 1393.00 | **SQLServer** |
| IndexQuery | CompositeIndex_RegionDept | 166.00 | 202.00 | 61.00 | 180.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 173.00 | 194.00 | 64.00 | 197.00 | **PostgreSQL** |
| IndexQuery | NoIndex_FullScan | 5958.00 | 5964.00 | 522.00 | 2509.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10451.00 | 47803.00 | 9271.00 | 4056.00 | **SQLServer** |
| IndexQuery | Pagination | 300.00 | 339.00 | 74.00 | 230.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 43227.00 | 61143.00 | 9938.00 | 15387.00 | **PostgreSQL** |
| IndexQuery | PrimaryKey | 104.00 | 112.00 | 48.00 | 120.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Date | 171.00 | 191.00 | 64.00 | 193.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Salary | 172.00 | 200.00 | 96.00 | 189.00 | **PostgreSQL** |
| IndexQuery | RangeQuery_Score | 175.00 | 191.00 | 113.00 | 185.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 165.00 | 190.00 | 733.00 | 112.00 | **SQLServer** |
| IndexQuery | SingleIndex_Status | 168.00 | 183.00 | 1051.00 | 425.00 | **MariaDB** |
| MillionData | Aggregation | 455.00 | 483.00 | 201.00 | 444.00 | **PostgreSQL** |
| MillionData | GroupBy | 1802.00 | 2590.00 | 184.00 | 116.00 | **SQLServer** |
| MillionData | PrepareData | 23937.00 | 31095.00 | 21006.00 | 27040.00 | **PostgreSQL** |
| MillionData | Cleanup | 18964.00 | 22492.00 | 4987.00 | 22724.00 | **PostgreSQL** |
| Single | Delete | 1532.00 | 3060.80 | 831.60 | 1537.80 | **PostgreSQL** |
| Single | Insert | 1718.40 | 3226.40 | 962.40 | 1491.40 | **PostgreSQL** |
| Single | Select | 1003.00 | 1062.40 | 393.40 | 1055.40 | **PostgreSQL** |
| Single | Update | 2316.40 | 3344.20 | 966.40 | 3575.00 | **PostgreSQL** |

### 所有数据库 - 单条/批量/聚合/百万数据索引性能 (毫秒 - 越小越好)

| 操作类型 | 操作名称 | MariaDB | MongoDB | MySQL | PostgreSQL | SQLite | SQLServer | 最快 |
|:---------|:---------|-------:|-------:|-------:|-------:|-------:|-------:|:-------|
| Aggregation | GroupBy | 3.00 | 3.40 | 4.80 | 1.40 | 2.00 | 29.60 | **PostgreSQL** |
| Aggregation | Statistics | 6.20 | 7.40 | 10.20 | 5.80 | 1.80 | 8.20 | **SQLite** |
| Batch | Delete | 59.40 | 38.00 | 101.20 | 20.40 | 52.80 | 213.00 | **PostgreSQL** |
| Batch | Insert | 1646.20 | 43.40 | 1576.80 | 651.80 | 699.60 | 4820.40 | **MongoDB** |
| Batch | Select | 12.20 | 31.00 | 12.60 | 8.00 | 13.80 | 14.60 | **PostgreSQL** |
| Batch | Update | 1538.60 | 205.00 | 1539.80 | 451.00 | 423.60 | 2593.40 | **MongoDB** |
| IndexQuery | ComplexCondition | 9216.00 | 4153.00 | 1447.00 | 308.00 | 42055.00 | 1536.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_RegionDept | 82.00 | 110.00 | 92.00 | 63.00 | 103.00 | 194.00 | **PostgreSQL** |
| IndexQuery | CompositeIndex_StatusCatPri | 89.00 | 118.00 | 108.00 | 133.00 | 147.00 | 218.00 | **MariaDB** |
| IndexQuery | NoIndex_FullScan | 5584.00 | 4439.00 | 6337.00 | 588.00 | 3360.00 | 2527.00 | **PostgreSQL** |
| IndexQuery | OrderBy | 10242.00 | 35976.00 | 47429.00 | 4579.00 | 58981.00 | 4129.00 | **SQLServer** |
| IndexQuery | Pagination | 168.00 | 221.00 | 244.00 | 74.00 | 112.00 | 231.00 | **PostgreSQL** |
| IndexQuery | PrefixQuery_Name | 42596.00 | 62.00 | 63630.00 | 9058.00 | 43427.00 | 15478.00 | **MongoDB** |
| IndexQuery | PrimaryKey | 63.00 | 57.00 | 52.00 | 50.00 | 23.00 | 113.00 | **SQLite** |
| IndexQuery | RangeQuery_Date | 86.00 | 119.00 | 101.00 | 121.00 | 164.00 | 215.00 | **MariaDB** |
| IndexQuery | RangeQuery_Salary | 89.00 | 126.00 | 102.00 | 114.00 | 194.00 | 208.00 | **MariaDB** |
| IndexQuery | RangeQuery_Score | 88.00 | 131.00 | 108.00 | 84.00 | 185.00 | 207.00 | **PostgreSQL** |
| IndexQuery | SingleIndex_Category | 76.00 | 138.00 | 86.00 | 113.00 | 72.00 | 114.00 | **SQLite** |
| IndexQuery | SingleIndex_Status | 75.00 | 133.00 | 94.00 | 61.00 | 76.00 | 436.00 | **PostgreSQL** |
| MillionData | Aggregation | 450.00 | 858.00 | 463.00 | 246.00 | 445.00 | 447.00 | **PostgreSQL** |
| MillionData | Cleanup | 18201.00 | 21513.00 | 22950.00 | 2874.00 | 123834.00 | 22662.00 | **PostgreSQL** |
| MillionData | GroupBy | 1749.00 | 1147.00 | 2577.00 | 213.00 | 8377.00 | 115.00 | **SQLServer** |
| MillionData | PrepareData | 23937.00 | 10714.00 | 31095.00 | 35022.00 | 150564.00 | 30819.00 | **MongoDB** |
| Single | Delete | 1110.40 | 544.40 | 2713.00 | 882.80 | 2992.60 | 1630.60 | **MongoDB** |
| Single | Insert | 1243.80 | 399.60 | 2780.40 | 1016.60 | 3127.80 | 1564.60 | **MongoDB** |
| Single | Select | 518.60 | 539.40 | 582.40 | 409.40 | 167.20 | 1087.40 | **SQLite** |
| Single | Update | 1421.80 | 604.60 | 2812.60 | 1026.20 | 3041.20 | 3723.20 | **MongoDB** |


## 🔴 存在明显性能问题的数据库

### 1. **SQL Server** - 最严重的性能问题

| 问题类型 | 具体表现 |
|----------|----------|
| **批量写入极慢** | Batch Insert: 4833.60ms（MariaDB 仅 365.40ms，**慢 13 倍**） |
| **批量更新极慢** | Batch Update: 2587.40ms（MariaDB 仅 253.00ms，**慢 10 倍**） |
| **单条更新慢** | Single Update: 3575.00ms（PostgreSQL 仅 966.40ms，**慢 3.7 倍**） |
| **聚合分组慢** | GroupBy: 29.20ms（PostgreSQL 仅 1.20ms，**慢 24 倍**） |
| **资源消耗巨大** | 内存占用 3.251GiB，CPU 占用 86%（远超其他数据库） |

### 2. **MySQL** - 中等性能问题

| 问题类型 | 具体表现 |
|----------|----------|
| **单条操作慢** | Single Insert: 3226.40ms（PostgreSQL 仅 962.40ms，**慢 3.4 倍**） |
| **单条删除慢** | Single Delete: 3060.80ms（PostgreSQL 仅 831.60ms，**慢 3.7 倍**） |
| **排序查询极慢** | OrderBy: 47803.00ms（SQL Server 4056.00ms，**慢 12 倍**） |
| **前缀查询慢** | PrefixQuery_Name: 61143.00ms（PostgreSQL 9938.00ms，**慢 6 倍**） |
| **百万数据准备慢** | PrepareData: 98087.00ms（PostgreSQL 21006.00ms，**慢 4.7 倍**） |

### 3. **MariaDB** - 部分性能问题

| 问题类型 | 具体表现 |
|----------|----------|
| **全表扫描慢** | NoIndex_FullScan: 5958.00ms（PostgreSQL 522.00ms，**慢 11 倍**） |
| **排序查询慢** | OrderBy: 10451.00ms（SQL Server 4056.00ms，**慢 2.6 倍**） |
| **前缀查询慢** | PrefixQuery_Name: 43227.00ms（PostgreSQL 9938.00ms，**慢 4.3 倍**） |
| **百万数据准备慢** | PrepareData: 98749.00ms（PostgreSQL 21006.00ms，**慢 4.7 倍**） |


### 4. 性能表现优秀的数据库

**PostgreSQL** - 综合最佳
- 在 **28 项测试中赢得 20 项**
- 全表扫描仅 522ms（其他数据库 2500-6000ms）
- 百万数据准备仅 21006ms（MySQL/MariaDB 约 98000ms）
- 内存占用仅 80.43MiB，CPU 仅 20%

### 5. 综合评价

| 数据库 | 性能问题严重程度 | 主要问题 |
|--------|------------------|----------|
| **SQL Server** | 🔴 严重 | 批量操作极慢、资源消耗巨大 |
| **MySQL** | 🟠 中等 | 单条操作慢、排序/前缀查询极慢 |
| **MariaDB** | 🟡 轻微 | 无索引查询慢、排序查询较慢 |
| **PostgreSQL** | 🟢 无 | 综合性能最佳 |
| **SQLite** | 🟢 无 | 轻量场景表现良好 |
| **MongoDB** | 🟢 无 | NoSQL 场景最佳 |

**建议**：对于通用场景优先选择 **PostgreSQL**；如果必须使用 SQL Server，需要优化批量操作策略；MySQL/MariaDB 需要注意索引优化和排序查询的性能。

## 功能特点

- **支持多种数据库**: MySQL, MariaDB, SQL Server, PostgreSQL, SQLite, MongoDB
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
- **FreeSql**: MySQL, MariaDB, SQL Server, PostgreSQL, SQLite 的 ORM
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

### 1. 环境要求/准备

- .NET 8.0
- 至少一个数据库服务（MySQL/MariaDB/SQL Server/PostgreSQL/MongoDB）
- SQLite 无需额外安装
- MySQL/MariaDB 配置 1G buffer pool，并开启 local_infile
- PostgreSQL shared_buffers 配置为 1G
- SQL Server 如果不是通过脚本启动，请手动创建数据库 benchmark_test
- 完全模拟生产环境
- 初始化百万数据默认使用 BulkCopy 方式插入

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
| MariaDB | localhost | 3307 | root | 123456 | benchmark_test |
| SQL Server | localhost | 1433 | sa | Benchmark@123 | benchmark_test |
| PostgreSQL | localhost | 5432 | postgres | 123456 | benchmark_test |
| MongoDB | localhost | 27017 | - | - | benchmark_test |
| SQLite | - | - | - | - | benchmark_test.db |

编辑 `appsettings.json` 文件，配置各数据库的连接字符串：

```json
{
  "ConnectionStrings": {
    "MySql": "Server=localhost;Port=3306;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;AllowLoadLocalInfile=true;",
    "MariaDb": "Server=localhost;Port=3307;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;AllowLoadLocalInfile=true;",
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
    "MySql": "Server=localhost;Port=3306;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;AllowLoadLocalInfile=true;",
    "MariaDb": "Server=localhost;Port=3307;Database=benchmark_test;Uid=root;Pwd=123456;Charset=utf8mb4;AllowPublicKeyRetrieval=true;AllowLoadLocalInfile=true;",
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
5. **数据清理**: 清理测试数据（记录性能指标）

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
| **百万数据清理** | MillionData_Cleanup | 百万级数据清理（删除所有测试数据） |
| **百万数据分组** | MillionData_GroupBy | 百万级数据按分组统计 |
| **百万数据聚合** | MillionData_Aggregation | 百万级数据聚合统计 |
| **百万数据准备** | MillionData_PrepareData | 批量插入百万级测试数据 |

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
2. 请在测试环境运行，避免影响生产数据
3. 首次运行会自动创建测试数据库和表
4. 每轮测试前会清空测试数据

## 性能参数

```bask
# 数据库参数说明
# Buffer Pool（数据库专用服务器）
innodb_buffer_pool_size = 服务器内存 × 0.7

# Log File Size (MariaDB 11)
innodb_log_file_size = innodb_buffer_pool_size × 0.25

# Redo Log Capacity (MySQL 8.4) 
innodb_redo_log_capacity = innodb_log_file_size × 2
```

## 许可证

MIT License

## 测试结果历史

<!-- BENCHMARK_RESULTS_START -->
- [2026-01-12 13:26:28](results/benchmark_report_20260112_132628.md) - 基准测试报告
- [2026-01-12 12:17:04](results/benchmark_report_20260112_121704.md) - 基准测试报告
- [2026-01-12 11:41:38](results/benchmark_report_20260112_114138.md) - 基准测试报告
- [2026-01-12 11:13:17](results/benchmark_report_20260112_111317.md) - 基准测试报告
- [关系型数据库 PK 2026-01-12 09:26:01](results/benchmark_report_20260112_092601.md) - 基准测试报告
- [MariaDB 2026-01-12 01:03:27](results/benchmark_report_20260112_010326.md) - 基准测试报告
- [PG VS 其他 2026-01-11 11:05:26](results/benchmark_report_20260111_110526.md) - 基准测试报告
- [PG VS SQLServer 2026-01-11 02:24:20](results/benchmark_report_20260111_022420.md) - 基准测试报告
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