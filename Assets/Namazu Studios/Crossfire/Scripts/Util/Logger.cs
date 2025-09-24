
namespace Elements.Crossfire
{
    public class Logger
    {
        public static bool LoggingEnabled;

        private string className;

        public Logger(string className)
        {
            this.className = className;
        }

        public void Log(string message)
        {
            if (LoggingEnabled)
                UnityEngine.Debug.Log($"[{className}] {message}");
        }

        public void LogWarning(string message)
        {
            if (LoggingEnabled)
                UnityEngine.Debug.LogWarning($"[{className}] {message}");
        }

        public void LogError(string message)
        {
            if (LoggingEnabled)
                UnityEngine.Debug.LogError($"[{className}] {message}");
        }
    }
}