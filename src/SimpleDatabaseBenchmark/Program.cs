using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using SimpleDatabaseBenchmark.Services;

namespace SimpleDatabaseBenchmark;

internal class Program
{
    private static async Task<int> Main(string[] args)
    {
        // 创建必要的目录
        var baseDirectory = AppContext.BaseDirectory;
        var logDirectory = Path.Combine(baseDirectory, "logs");
        var resultsDirectory = Path.Combine(baseDirectory, "results");

        EnsureDirectoryExists(logDirectory);
        EnsureDirectoryExists(resultsDirectory);

        // 加载配置
        var configuration = new ConfigurationBuilder()
            .SetBasePath(baseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development"}.json", optional: true)
            .Build();

        // 配置 Serilog
        var logFilePath = Path.Combine(logDirectory, "benchmark_. log");

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("System", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .Enrich.WithProperty("Application", "SimpleDatabaseBenchmark")
            .WriteTo.Console(
                outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
                theme: Serilog.Sinks.SystemConsole.Themes.AnsiConsoleTheme.Code)
            .WriteTo.File(
                path: logFilePath,
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss. fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                retainedFileCountLimit: 30,
                fileSizeLimitBytes: 100 * 1024 * 1024,
                encoding: System.Text.Encoding.UTF8)
            .CreateLogger();

        try
        {
            PrintBanner();

            Log.Information("工作目录: {Directory}", baseDirectory);
            Log.Information("日志目录: {Directory}", logDirectory);
            Log.Information("结果目录: {Directory}", resultsDirectory);
            Log.Information("");

            // 检查是否有可用的数据库配置
            if (!HasAnyDatabaseConfiguration(configuration))
            {
                Log.Error("未找到任何有效的数据库连接配置，请检查 appsettings.json 文件");
                return 1;
            }

            // 创建测试运行器
            var runner = new BenchmarkRunner(configuration);

            // 初始化服务
            await runner.InitializeServicesAsync();

            // 检查是否有可用的数据库服务
            if (!runner.HasAvailableServices)
            {
                Log.Error("没有可用的数据库服务，请检查数据库连接配置和数据库服务状态");
                return 1;
            }

            // 运行测试
            await runner.RunAllBenchmarksAsync();

            // 生成报告
            await runner.GenerateReportAsync();

            // 清理资源
            await runner.DisposeAsync();

            PrintCompletionBanner();

            return 0;
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "程序执行过程中发生致命错误");
            return 1;
        }
        finally
        {
            await Log.CloseAndFlushAsync();
        }
    }

    /// <summary>
    /// 确保目录存在
    /// </summary>
    private static void EnsureDirectoryExists(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    /// <summary>
    /// 检查是否有任何数据库配置
    /// </summary>
    private static bool HasAnyDatabaseConfiguration(IConfiguration configuration)
    {
        var connectionStrings = configuration.GetSection("ConnectionStrings");
        var children = connectionStrings.GetChildren();

        return children.Any(c => !string.IsNullOrWhiteSpace(c.Value));
    }

    /// <summary>
    /// 打印启动横幅
    /// </summary>
    private static void PrintBanner()
    {
        var banner = @"
╔══════════════════════════════════════════════════════════════════╗
║                                                                  ║
║     ███████╗██╗███╗   ███╗██████╗ ██╗     ███████╗               ║
║     ██╔════╝██║████╗ ████║██╔══██╗██║     ██╔════╝               ║
║     ███████╗██║██╔████╔██║██████╔╝██║     █████╗                 ║
║     ╚════██║██║██║╚██╔╝██║██╔═══╝ ██║     ██╔══╝                 ║
║     ███████║██║██║ ╚═╝ ██║██║     ███████╗███████╗               ║
║     ╚══════╝╚═╝╚═╝     ╚═╝╚═╝     ╚══════╝╚══════╝               ║
║                                                                  ║
║     ██████╗ ███████╗███╗   ██╗ ██████╗██╗  ██╗                   ║
║     ██╔══██╗██╔════╝████╗  ██║██╔════╝██║  ██║                   ║
║     ██████╔╝█████╗  ██╔██╗ ██║██║     ███████║                   ║
║     ██╔══██╗██╔══╝  ██║╚██╗██║██║     ██╔══██║                   ║
║     ██████╔╝███████╗██║ ╚████║╚██████╗██║  ██║                   ║
║     ╚═════╝ ╚══════╝╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝                   ║
║                                                                  ║
║              Database Benchmark Tool v1.0. 0                      ║
║                                                                  ║
║     Databases: MySQL | SQL Server | PostgreSQL | SQLite | MongoDB║
║     ORM: FreeSql (SQL) | MongoDB.Driver (NoSQL)                  ║
║     Logging: Serilog                                             ║
║                                                                  ║
╚══════════════════════════════════════════════════════════════════╝
";
        Console.WriteLine(banner);
        Log.Information("SimpleDatabaseBenchmark v1.0.0 启动");
        Log.Information("========================================");
    }

    /// <summary>
    /// 打印完成横幅
    /// </summary>
    private static void PrintCompletionBanner()
    {
        Log.Information("");
        Log.Information("========================================");
        Log.Information("✅ 所有测试已完成!");
        Log.Information("========================================");
        Log.Information("");
        Log.Information("📊 测试报告位置: results/ 目录");
        Log.Information("📝 详细日志位置: logs/ 目录");
        Log.Information("");

        var completionBanner = @"
╔══════════════════════════════════════════════════════════════════╗
║                                                                  ║
║                    ✅ 测试完成 / Test Completed                  ║
║                                                                  ║
║     请查看 results/ 目录获取测试报告                             ║
║     Please check results/ directory for test reports             ║
║                                                                  ║
╚══════════════════════════════════════════════════════════════════╝
";
        Console.WriteLine(completionBanner);
    }
}