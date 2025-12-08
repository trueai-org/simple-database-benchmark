using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SimpleDatabaseBenchmark.Utils;

/// <summary>
/// 服务器信息
/// </summary>
public class ServerInfo
{
    public string MachineName { get; set; } = string.Empty;
    public string OSDescription { get; set; } = string.Empty;
    public string OSArchitecture { get; set; } = string.Empty;
    public string ProcessArchitecture { get; set; } = string.Empty;
    public int ProcessorCount { get; set; }
    public string DotNetVersion { get; set; } = string.Empty;
    public long TotalMemoryBytes { get; set; }
    public string TotalMemoryFormatted { get; set; } = string.Empty;
    public DateTime CollectedAt { get; set; }

    /// <summary>
    /// 收集服务器信息
    /// </summary>
    public static ServerInfo Collect()
    {
        var totalMemory = GetTotalPhysicalMemory();

        return new ServerInfo
        {
            MachineName = Environment.MachineName,
            OSDescription = RuntimeInformation.OSDescription,
            OSArchitecture = RuntimeInformation.OSArchitecture.ToString(),
            ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
            ProcessorCount = Environment.ProcessorCount,
            DotNetVersion = RuntimeInformation.FrameworkDescription,
            TotalMemoryBytes = totalMemory,
            TotalMemoryFormatted = FormatBytes(totalMemory),
            CollectedAt = DateTime.Now
        };
    }

    /// <summary>
    /// 获取总物理内存
    /// </summary>
    private static long GetTotalPhysicalMemory()
    {
        try
        {
            using var process = Process.GetCurrentProcess();
            // 使用 GC 获取总内存作为近似值
            return GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
        }
        catch
        {
            return 0;
        }
    }

    /// <summary>
    /// 格式化字节数
    /// </summary>
    private static string FormatBytes(long bytes)
    {
        if (bytes <= 0) return "Unknown";
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        double len = bytes;
        int order = 0;
        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len /= 1024;
        }
        return $"{len:0.##} {sizes[order]}";
    }

    /// <summary>
    /// 转换为 Markdown 格式
    /// </summary>
    public string ToMarkdown()
    {
        return $@"## 服务器信息

| 项目 | 值 |
|------|-----|
| 机器名称 | {MachineName} |
| 操作系统 | {OSDescription} |
| OS 架构 | {OSArchitecture} |
| 进程架构 | {ProcessArchitecture} |
| 处理器数量 | {ProcessorCount} |
| .NET 版本 | {DotNetVersion} |
| 总内存 | {TotalMemoryFormatted} |
| 采集时间 | {CollectedAt:yyyy-MM-dd HH:mm:ss} |
";
    }
}