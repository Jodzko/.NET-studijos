namespace _2_paskaita_web_API.Services
{
    public class DevConsoleLogger : IConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }
    }
}
