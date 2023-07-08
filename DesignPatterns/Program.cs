using Singleton.Start;

namespace DesignPatterns;

internal class Program
{
    #region Creational Design Patterns
    #region 1- Singleton Pattern

    private static MemoryLogger Logger;

    private static void AssignVoucher(string email, string voucher) 
    {
        Logger = new MemoryLogger();

        Logger.LogInfo($"Voucher '{voucher}' Assigned");

        Logger.LogError($"Unable to Send Email '{email}'");

    }

    private static void UseVoucher(string voucher)
    {
        Logger = new MemoryLogger();

        Logger.LogWarning($"3 Attempts Made To Validate The Voucher {voucher}");

        Logger.LogInfo($"{voucher} Is Used!");
    }
    private static void SingletonDesignPattern() 
    {
        AssignVoucher("muhammadjammi18@gmail.com", "ABC123");
        
        UseVoucher("ABC123");
        
        Logger.ShowLog();
    }

    #endregion
        
    #endregion
    private static void Main(string[] args) 
    {
        SingletonDesignPattern();
        Console.ReadKey();
    }
}
