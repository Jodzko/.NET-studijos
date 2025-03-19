namespace _2_paskaita_DI_IOC.Services
{
    public class DevConsoleLogger : IConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }
    }
}
