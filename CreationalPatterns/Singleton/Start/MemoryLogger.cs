namespace Singleton.Start;
public class MemoryLogger
{
    private int _InfoCount;
    private int _WarningCount;
    private int _ErrorCount;

    private List<LogMessage> _logs = new();
    public IReadOnlyCollection<LogMessage> Logs => _logs;
    private void Log(string message, LogTypeEnum logType) => _logs.Add(new LogMessage()
    {
        Message = message,
        LogType = logType,
        CreatedAt = DateTime.UtcNow
    });
    public void LogInfo(string message) 
    {
        ++_InfoCount;
        Log(message, LogTypeEnum.INFO);
    }
    public void LogWarning(string message) 
    {
        ++_WarningCount;
        Log(message, LogTypeEnum.WARNING);
    }
    public void LogError(string message) 
    {
        ++_ErrorCount;
        Log(message, LogTypeEnum.ERROR);
    }
    public void ShowLog() 
    {
        _logs.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"Info ({_InfoCount}) | Warning ({_WarningCount}) | Error ({_ErrorCount}) | Logs ({_logs.Count})");
    }
}
