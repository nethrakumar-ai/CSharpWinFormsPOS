using System;
using System.IO;

namespace CSharpWinFormsPOS
{
    public static class Logger
    {
        public static string LogFilePath { get; set; }
        public static string SessionId { get; private set; }

        static Logger()
        {
            SessionId = Guid.NewGuid().ToString();
        }

        public static void Log(string message, string level = "INFO")
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] [Session: {SessionId}] {message}";
            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }

        public static void LogException(Exception ex, string context = "")
        {
            Log($"{context} Exception: {ex.GetType().Name} - {ex.Message}\n{ex.StackTrace}", "ERROR");
        }

        public static void LogEnvironmentInfo()
        {
            try
            {
                Log("Environment Info:", "INFO");
                Log($"MachineName: {Environment.MachineName}", "INFO");
                Log($"OSVersion: {Environment.OSVersion}", "INFO");
                Log($".NET Version: {Environment.Version}", "INFO");
                Log($"User: {Environment.UserName}", "INFO");
                Log($"CurrentDirectory: {Environment.CurrentDirectory}", "INFO");
            }
            catch (Exception ex)
            {
                LogException(ex, "Failed to log environment info");
            }
        }
    }
}
