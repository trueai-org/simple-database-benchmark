# Windows 启动脚本

Write-Host "启动数据库..."
docker compose up -d

Write-Host "等待数据库就绪..."
Start-Sleep -Seconds 15

# 创建 SQL Server 数据库
Write-Host "创建 SQL Server 数据库..."
docker exec bench_sqlserver /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "Benchmark@123" -C -Q "CREATE DATABASE benchmark_test" 2>$null

Write-Host ""
Write-Host "✅ 数据库已启动!" -ForegroundColor Green
Write-Host ""
Write-Host "连接信息:"
Write-Host "  MySQL:      localhost:3306  root/123456"
Write-Host "  SQLServer:  localhost:1433  sa/Benchmark@123"
Write-Host "  PostgreSQL: localhost:5432  postgres/123456"
Write-Host "  MongoDB:    localhost:27017"
Write-Host "  SQLite:     自动创建 benchmark_test.db"
Write-Host ""
Write-Host "运行测试: dotnet run"
