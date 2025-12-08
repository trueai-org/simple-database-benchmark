# SimpleDatabaseBenchmark - 数据库基准测试工具

一个用于对比测试多种数据库性能的 .NET 控制台应用程序。

## 功能特点

- **支持多种数据库**: MySQL, SQL Server, PostgreSQL, SQLite, MongoDB
- **多种测试场景**: 
  - 单条增删改查 (CRUD)
  - 批量增删改查
  - 统计汇总 (Count, Sum, Avg, Max, Min)
  - 分组汇总 (Group By)
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
- [2025-12-08 18:21:00](results/benchmark_report_20251208_182100.md) - 基准测试报告
<!-- BENCHMARK_RESULTS_END -->