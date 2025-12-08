using System.Diagnostics;

namespace SimpleDatabaseBenchmark.Utils;

/// <summary>
/// 性能监控器
/// </summary>
public class PerformanceMonitor : IDisposable
{
    private readonly Stopwatch _stopwatch;
    private readonly Process _process;
    private long _startMemory;
    private long _endMemory;
    private TimeSpan _startCpuTime;
    private TimeSpan _endCpuTime;
    private DateTime _startTime;
    private DateTime _endTime;

    public PerformanceMonitor()
    {
        _stopwatch = new Stopwatch();
        _process = Process.GetCurrentProcess();
    }

    /// <summary>
    /// 开始监控
    /// </summary>
    public void Start()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        _process.Refresh();
        _startMemory = _process.WorkingSet64;
        _startCpuTime = _process.TotalProcessorTime;
        _startTime = DateTime.UtcNow;
        _stopwatch.Restart();
    }

    /// <summary>
    /// 停止监控
    /// </summary>
    public void Stop()
    {
        _stopwatch.Stop();
        _endTime = DateTime.UtcNow;
        _process.Refresh();
        _endMemory = _process.WorkingSet64;
        _endCpuTime = _process.TotalProcessorTime;
    }

    /// <summary>
    /// 获取耗时（毫秒）
    /// </summary>
    public long ElapsedMilliseconds => _stopwatch.ElapsedMilliseconds;

    /// <summary>
    /// 获取内存使用量（字节）
    /// </summary>
    public long MemoryUsedBytes => Math.Max(0, _endMemory - _startMemory);

    /// <summary>
    /// 获取格式化的内存使用量
    /// </summary>
    public string MemoryUsedFormatted => FormatBytes(MemoryUsedBytes);

    /// <summary>
    /// 获取 CPU 使用率（百分比）
    /// </summary>
    public double CpuUsagePercent
    {
        get
        {
            var cpuUsed = (_endCpuTime - _startCpuTime).TotalMilliseconds;
            var totalTime = (_endTime - _startTime).TotalMilliseconds;
            if (totalTime <= 0) return 0;

            var cpuUsage = (cpuUsed / (Environment.ProcessorCount * totalTime)) * 100;
            return Math.Round(Math.Min(100, Math.Max(0, cpuUsage)), 2);
        }
    }

    /// <summary>
    /// 计算每秒操作数
    /// </summary>
    public double CalculateOperationsPerSecond(int operationCount)
    {
        if (ElapsedMilliseconds <= 0) return 0;
        return Math.Round(operationCount / (ElapsedMilliseconds / 1000.0), 2);
    }

    /// <summary>
    /// 格式化字节数
    /// </summary>
    private static string FormatBytes(long bytes)
    {
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

    public void Dispose()
    {
        _process?.Dispose();
    }
}

/// <summary>
/// 性能监控结果
/// </summary>
public class PerformanceResult
{
    public long ElapsedMilliseconds { get; set; }
    public long MemoryUsedBytes { get; set; }
    public string MemoryUsedFormatted { get; set; } = string.Empty;
    public double CpuUsagePercent { get; set; }
    public double OperationsPerSecond { get; set; }
}