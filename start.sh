#!/bin/bash

echo "启动数据库..."
docker compose up -d

echo "等待数据库就绪..."
sleep 15

# 创建 SQL Server 数据库
echo "创建 SQL Server 数据库..."
docker exec bench_sqlserver /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "Benchmark@123" -C -Q "CREATE DATABASE benchmark_test" 2>/dev/null || true

echo ""
echo "✅ 数据库已启动!"
echo ""
echo "连接信息:"
echo "  MySQL:      localhost:3306  root/123456"
echo "  SQLServer:  localhost:1433  sa/Benchmark@123"
echo "  PostgreSQL: localhost:5432  postgres/123456"
echo "  MongoDB:    localhost:27017"
echo "  SQLite:     自动创建 benchmark_test. db"
echo ""
echo "运行测试: dotnet run"