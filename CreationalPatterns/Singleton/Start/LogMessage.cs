namespace Singleton.Start;
public class LogMessage
{
    public string Message { get; set; }
    public LogTypeEnum LogType { get; set; }
    public DateTime CreatedAt { get; set; }
    public override string ToString() 
    {
        string timeStamp = CreatedAt.ToString("yyyy-MM-dd hh:mm:ss");
        return $"{LogType.ToString().PadLeft(7, ' ')} [{timeStamp}] {Message}";
    }
}
