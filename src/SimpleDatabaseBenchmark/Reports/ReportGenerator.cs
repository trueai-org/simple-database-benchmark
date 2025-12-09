using Microsoft.Extensions.Configuration;
using Serilog;
using SimpleDatabaseBenchmark.Models;
using SimpleDatabaseBenchmark.Utils;
using System.Text;

namespace SimpleDatabaseBenchmark.Reports;

/// <summary>
/// 报告生成器
/// </summary>
public class ReportGenerator
{
    private readonly ILogger _logger;
    private readonly string _resultsDirectory;
    private readonly string _projectRootDirectory;

    public ReportGenerator()
    {
        _logger = Log.ForContext<ReportGenerator>();

        // 结果目录
        _resultsDirectory = Path.Combine(AppContext.BaseDirectory, "results");
        if (!Directory.Exists(_resultsDirectory))
        {
            Directory.CreateDirectory(_resultsDirectory);
        }

        // 项目根目录（用于更新 README）
        _projectRootDirectory = FindProjectRoot();
    }

    /// <summary>
    /// 查找项目根目录
    /// </summary>
    private string FindProjectRoot()
    {
        var currentDir = AppContext.BaseDirectory;

        // 向上查找包含 README. md 或 . sln 文件的目录
        for (int i = 0; i < 10; i++)
        {
            var parentDir = Path.GetDirectoryName(currentDir);
            if (string.IsNullOrEmpty(parentDir))
                break;

            if (File.Exists(Path.Combine(parentDir, "README.md")) ||
                Directory.GetFiles(parentDir, "*.sln").Any())
            {
                return parentDir;
            }
            currentDir = parentDir;
        }

        // 如果找不到，使用输出目录
        return AppContext.BaseDirectory;
    }

    /// <summary>
    /// 生成报告
    /// </summary>
    public async Task GenerateReportAsync(List<BenchmarkResult> results, ServerInfo serverInfo, IConfiguration configuration)
    {
        var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        var reportFileName = $"benchmark_report_{timestamp}.md";
        var reportPath = Path.Combine(_resultsDirectory, reportFileName);
        var logFileName = $"benchmark_{DateTime.Now:yyyyMMdd}.log";

        _logger.Information("开始生成测试报告...");

        var sb = new StringBuilder();

        // 标题
        sb.AppendLine("# 数据库基准测试报告");
        sb.AppendLine();
        sb.AppendLine($"**测试时间**: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        sb.AppendLine();

        // 测试配置
        var singleCount = configuration.GetValue("BenchmarkSettings:SingleOperationCount", 1000);
        var batchSize = configuration.GetValue("BenchmarkSettings:BatchSize", 1000);
        var batchCount = configuration.GetValue("BenchmarkSettings:BatchOperationCount", 10);
        var warmupIterations = configuration.GetValue("BenchmarkSettings:WarmupIterations", 3);
        var testIterations = configuration.GetValue("BenchmarkSettings:TestIterations", 5);
        sb.AppendLine("## 测试配置");
        sb.AppendLine();
        sb.AppendLine("| 配置项 | 值 |");
        sb.AppendLine("|--------|-----|");
        sb.AppendLine($"| 单次操作记录数 | {singleCount:N0} |");
        sb.AppendLine($"| 批量操作批次大小 | {batchSize:N0} |");
        sb.AppendLine($"| 批量操作批次数 | {batchCount:N0} |");
        sb.AppendLine($"| 预热迭代次数 | {warmupIterations:N0} |");
        sb.AppendLine($"| 测试迭代次数 | {testIterations:N0} |");
        sb.AppendLine();

        // 服务器信息
        sb.AppendLine(serverInfo.ToMarkdown());
        sb.AppendLine();

        // 测试概要
        AppendTestSummary(sb, results);

        // 性能对比总览
        AppendPerformanceOverview(sb, results);

        // 各数据库详细结果
        AppendDatabaseDetails(sb, results);

        // CPU 消耗对比
        AppendCpuComparison(sb, results);

        // 内存消耗对比
        AppendMemoryComparison(sb, results);

        // 失败用例
        AppendFailedCases(sb, results);

        // 详细日志链接
        sb.AppendLine("## 详细日志");
        sb.AppendLine();
        sb.AppendLine($"完整的测试日志请查看 `logs/{logFileName}` 文件。");
        sb.AppendLine();
        sb.AppendLine("---");
        sb.AppendLine();
        sb.AppendLine($"*报告生成时间: {DateTime.Now:yyyy-MM-dd HH:mm:ss}*");

        // 写入报告文件
        await File.WriteAllTextAsync(reportPath, sb.ToString(), Encoding.UTF8);
        _logger.Information("测试报告已保存到: {Path}", reportPath);

        // 复制到项目根目录的 results 文件夹
        await CopyReportToProjectRoot(reportFileName, sb.ToString());

        // 更新 README
        await UpdateReadmeAsync(reportFileName, timestamp);
    }

    /// <summary>
    /// 复制报告到项目根目录
    /// </summary>
    private async Task CopyReportToProjectRoot(string reportFileName, string content)
    {
        try
        {
            var projectResultsDir = Path.Combine(_projectRootDirectory, "results");
            if (!Directory.Exists(projectResultsDir))
            {
                Directory.CreateDirectory(projectResultsDir);
            }

            var targetPath = Path.Combine(projectResultsDir, reportFileName);
            await File.WriteAllTextAsync(targetPath, content, Encoding.UTF8);
            _logger.Information("测试报告已复制到项目目录: {Path}", targetPath);
        }
        catch (Exception ex)
        {
            _logger.Warning(ex, "复制报告到项目根目录失败");
        }
    }

    /// <summary>
    /// 添加测试概要
    /// </summary>
    private void AppendTestSummary(StringBuilder sb, List<BenchmarkResult> results)
    {
        sb.AppendLine("## 测试概要");
        sb.AppendLine();

        var databases = results.Select(r => r.DatabaseName).Distinct().ToList();
        var successCount = results.Count(r => r.IsSuccess);
        var failedCount = results.Count(r => !r.IsSuccess);

        sb.AppendLine($"| 项目 | 值 |");
        sb.AppendLine($"|------|-----|");
        sb.AppendLine($"| 测试数据库 | {string.Join(", ", databases)} |");
        sb.AppendLine($"| 数据库数量 | {databases.Count} |");
        sb.AppendLine($"| 总测试用例数 | {results.Count} |");
        sb.AppendLine($"| 成功用例数 | {successCount} |");
        sb.AppendLine($"| 失败用例数 | {failedCount} |");
        sb.AppendLine($"| 成功率 | {(results.Count > 0 ? (double)successCount / results.Count * 100 : 0):F2}% |");
        sb.AppendLine();
    }

    /// <summary>
    /// 添加性能对比总览
    /// </summary>
    private void AppendPerformanceOverview(StringBuilder sb, List<BenchmarkResult> results)
    {
        sb.AppendLine("## 性能对比总览");
        sb.AppendLine();

        var operations = results
            .Where(r => r.IsSuccess)
            .GroupBy(r => new { r.OperationType, r.OperationName })
            .Select(g => g.Key)
            .OrderBy(o => o.OperationType)
            .ThenBy(o => o.OperationName)
            .ToList();

        var databases = results.Select(r => r.DatabaseName).Distinct().OrderBy(d => d).ToList();

        if (!operations.Any() || !databases.Any())
        {
            sb.AppendLine("*暂无有效测试数据*");
            sb.AppendLine();
            return;
        }

        // 耗时对比表
        sb.AppendLine("### 操作耗时对比 (毫秒 - 越小越好)");
        sb.AppendLine();

        sb.Append("| 操作类型 | 操作名称 |");
        foreach (var db in databases)
        {
            sb.Append($" {db} |");
        }
        sb.AppendLine(" 最快 |");

        sb.Append("|:---------|:---------|");
        foreach (var _ in databases)
        {
            sb.Append("-------:|");
        }
        sb.AppendLine(":-------|");

        foreach (var op in operations)
        {
            sb.Append($"| {op.OperationType} | {op.OperationName} |");

            var times = new Dictionary<string, double>();
            foreach (var db in databases)
            {
                var avgTime = results
                    .Where(r => r.DatabaseName == db &&
                               r.OperationType == op.OperationType &&
                               r.OperationName == op.OperationName &&
                               r.IsSuccess)
                    .Select(r => (double)r.ElapsedMilliseconds)
                    .DefaultIfEmpty(-1)
                    .Average();

                times[db] = avgTime;
                sb.Append($" {(avgTime >= 0 ? avgTime.ToString("F2") : "N/A")} |");
            }

            // 找出最快的数据库
            var validTimes = times.Where(t => t.Value >= 0).ToList();
            var fastest = validTimes.Any()
                ? validTimes.OrderBy(t => t.Value).First().Key
                : "N/A";
            sb.AppendLine($" **{fastest}** |");
        }

        sb.AppendLine();

        // OPS 对比表
        sb.AppendLine("### 每秒操作数对比 (OPS - 越大越好)");
        sb.AppendLine();

        sb.Append("| 操作类型 | 操作名称 |");
        foreach (var db in databases)
        {
            sb.Append($" {db} |");
        }
        sb.AppendLine(" 最快 |");

        sb.Append("|:---------|:---------|");
        foreach (var _ in databases)
        {
            sb.Append("-------:|");
        }
        sb.AppendLine(":-------|");

        foreach (var op in operations)
        {
            sb.Append($"| {op.OperationType} | {op.OperationName} |");

            var opsValues = new Dictionary<string, double>();
            foreach (var db in databases)
            {
                var avgOps = results
                    .Where(r => r.DatabaseName == db &&
                               r.OperationType == op.OperationType &&
                               r.OperationName == op.OperationName &&
                               r.IsSuccess)
                    .Select(r => r.OperationsPerSecond)
                    .DefaultIfEmpty(-1)
                    .Average();

                opsValues[db] = avgOps;
                sb.Append($" {(avgOps >= 0 ? avgOps.ToString("F2") : "N/A")} |");
            }

            // 找出最快的数据库（OPS 最高）
            var validOps = opsValues.Where(t => t.Value >= 0).ToList();
            var fastest = validOps.Any()
                ? validOps.OrderByDescending(t => t.Value).First().Key
                : "N/A";
            sb.AppendLine($" **{fastest}** |");
        }

        sb.AppendLine();
    }

    /// <summary>
    /// 添加各数据库详细结果
    /// </summary>
    private void AppendDatabaseDetails(StringBuilder sb, List<BenchmarkResult> results)
    {
        sb.AppendLine("## 各数据库详细结果");
        sb.AppendLine();

        var groupedByDb = results
            .GroupBy(r => r.DatabaseName)
            .OrderBy(g => g.Key);

        foreach (var dbGroup in groupedByDb)
        {
            sb.AppendLine($"### {dbGroup.Key}");
            sb.AppendLine();

            sb.AppendLine("| 操作类型 | 操作名称 | 记录数 | 耗时(ms) | OPS | CPU(%) | 内存增量 | 状态 |");
            sb.AppendLine("|:---------|:---------|-------:|--------:|----:|-------:|---------:|:----:|");

            foreach (var r in dbGroup.OrderBy(r => r.OperationType).ThenBy(r => r.OperationName).ThenBy(r => r.TestTime))
            {
                var status = r.IsSuccess ? "✅" : "❌";
                var ops = r.IsSuccess ? r.OperationsPerSecond.ToString("F2") : "N/A";
                var cpu = r.IsSuccess ? r.CpuUsagePercent.ToString("F2") : "N/A";
                var memory = r.IsSuccess ? r.MemoryUsedFormatted : "N/A";

                sb.AppendLine($"| {r.OperationType} | {r.OperationName} | {r.RecordCount:N0} | {r.ElapsedMilliseconds:N0} | {ops} | {cpu} | {memory} | {status} |");
            }

            sb.AppendLine();
        }
    }

    /// <summary>
    /// 添加 CPU 消耗对比
    /// </summary>
    private void AppendCpuComparison(StringBuilder sb, List<BenchmarkResult> results)
    {
        sb.AppendLine("## CPU 消耗对比 (%)");
        sb.AppendLine();

        var operations = results
            .Where(r => r.IsSuccess)
            .GroupBy(r => new { r.OperationType, r.OperationName })
            .Select(g => g.Key)
            .OrderBy(o => o.OperationType)
            .ThenBy(o => o.OperationName)
            .ToList();

        var databases = results.Select(r => r.DatabaseName).Distinct().OrderBy(d => d).ToList();

        if (!operations.Any() || !databases.Any())
        {
            sb.AppendLine("*暂无有效测试数据*");
            sb.AppendLine();
            return;
        }

        sb.Append("| 操作类型 | 操作名称 |");
        foreach (var db in databases)
        {
            sb.Append($" {db} |");
        }
        sb.AppendLine();

        sb.Append("|:---------|:---------|");
        foreach (var _ in databases)
        {
            sb.Append("-------:|");
        }
        sb.AppendLine();

        foreach (var op in operations)
        {
            sb.Append($"| {op.OperationType} | {op.OperationName} |");
            foreach (var db in databases)
            {
                var avgCpu = results
                    .Where(r => r.DatabaseName == db &&
                               r.OperationType == op.OperationType &&
                               r.OperationName == op.OperationName &&
                               r.IsSuccess)
                    .Select(r => r.CpuUsagePercent)
                    .DefaultIfEmpty(-1)
                    .Average();

                sb.Append($" {(avgCpu >= 0 ? avgCpu.ToString("F2") : "N/A")} |");
            }
            sb.AppendLine();
        }

        sb.AppendLine();
    }

    /// <summary>
    /// 添加内存消耗对比
    /// </summary>
    private void AppendMemoryComparison(StringBuilder sb, List<BenchmarkResult> results)
    {
        sb.AppendLine("## 内存消耗对比");
        sb.AppendLine();

        var operations = results
            .Where(r => r.IsSuccess)
            .GroupBy(r => new { r.OperationType, r.OperationName })
            .Select(g => g.Key)
            .OrderBy(o => o.OperationType)
            .ThenBy(o => o.OperationName)
            .ToList();

        var databases = results.Select(r => r.DatabaseName).Distinct().OrderBy(d => d).ToList();

        if (!operations.Any() || !databases.Any())
        {
            sb.AppendLine("*暂无有效测试数据*");
            sb.AppendLine();
            return;
        }

        sb.Append("| 操作类型 | 操作名称 |");
        foreach (var db in databases)
        {
            sb.Append($" {db} |");
        }
        sb.AppendLine();

        sb.Append("|:---------|:---------|");
        foreach (var _ in databases)
        {
            sb.Append("-----------:|");
        }
        sb.AppendLine();

        foreach (var op in operations)
        {
            sb.Append($"| {op.OperationType} | {op.OperationName} |");
            foreach (var db in databases)
            {
                var maxMemory = results
                    .Where(r => r.DatabaseName == db &&
                               r.OperationType == op.OperationType &&
                               r.OperationName == op.OperationName &&
                               r.IsSuccess)
                    .OrderByDescending(r => r.MemoryUsedBytes)
                    .FirstOrDefault();

                var memory = maxMemory?.MemoryUsedFormatted ?? "N/A";
                sb.Append($" {memory} |");
            }
            sb.AppendLine();
        }

        sb.AppendLine();
    }

    /// <summary>
    /// 添加失败用例
    /// </summary>
    private void AppendFailedCases(StringBuilder sb, List<BenchmarkResult> results)
    {
        var failedResults = results.Where(r => !r.IsSuccess).ToList();

        if (!failedResults.Any())
        {
            return;
        }

        sb.AppendLine("## 失败用例");
        sb.AppendLine();
        sb.AppendLine("| 数据库 | 操作类型 | 操作名称 | 测试时间 | 错误信息 |");
        sb.AppendLine("|:-------|:---------|:---------|:---------|:---------|");

        foreach (var r in failedResults.OrderBy(r => r.DatabaseName).ThenBy(r => r.TestTime))
        {
            var errorMsg = r.ErrorMessage?.Replace("|", "\\|").Replace("\n", " ").Replace("\r", "") ?? "Unknown error";
            if (errorMsg.Length > 100)
            {
                errorMsg = errorMsg[..100] + "...";
            }
            sb.AppendLine($"| {r.DatabaseName} | {r.OperationType} | {r.OperationName} | {r.TestTime:HH:mm:ss} | {errorMsg} |");
        }

        sb.AppendLine();
    }

    /// <summary>
    /// 更新 README 文件
    /// </summary>
    private async Task UpdateReadmeAsync(string reportFileName, string timestamp)
    {
        try
        {
            var readmePath = Path.Combine(_projectRootDirectory, "README.md");

            string content = "";
            if (File.Exists(readmePath))
            {
                content = await File.ReadAllTextAsync(readmePath, Encoding.UTF8);
            }
            else
            {
                ArgumentNullException.ThrowIfNull(readmePath, "README.md 文件不存在，无法更新测试报告链接");
            }

            const string startMarker = "<!-- BENCHMARK_RESULTS_START -->";
            const string endMarker = "<!-- BENCHMARK_RESULTS_END -->";

            var formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var newLink = $"- [{formattedTime}](results/{reportFileName}) - 基准测试报告";

            var startIndex = content.IndexOf(startMarker);
            var endIndex = content.IndexOf(endMarker);

            if (startIndex >= 0 && endIndex >= 0 && endIndex > startIndex)
            {
                var beforeMarker = content[..(startIndex + startMarker.Length)];
                var afterMarker = content[endIndex..];

                // 获取现有链接（最多保留最近 20 条）
                var existingContent = content[(startIndex + startMarker.Length)..endIndex];
                var existingLines = existingContent
                    .Split('\n', StringSplitOptions.RemoveEmptyEntries)
                    .Where(l => l.Trim().StartsWith("-"))
                    .Take(19)
                    .ToList();

                var sb = new StringBuilder();
                sb.AppendLine();
                sb.AppendLine(newLink);
                foreach (var line in existingLines)
                {
                    sb.AppendLine(line.Trim());
                }

                content = $"{beforeMarker}{sb}{afterMarker}";
            }
            else
            {
                // 添加标记区域
                content += $@"

## 测试结果历史

{startMarker}
{newLink}
{endMarker}
";
            }

            await File.WriteAllTextAsync(readmePath, content, Encoding.UTF8);
            _logger.Information("README 已更新，添加了测试报告链接: {FileName}", reportFileName);
        }
        catch (Exception ex)
        {
            _logger.Warning(ex, "更新 README 文件失败");
        }
    }
}