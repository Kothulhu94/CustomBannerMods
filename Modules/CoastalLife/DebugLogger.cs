using System;
using System.IO;
using TaleWorlds.Library;

namespace CoastalLife
{
    public static class DebugLogger
    {
        private static readonly string LogFilePath = GetLogFilePath("CoastalLife.log");
        private static readonly object _lock = new object();

        private static string GetLogFilePath(string filename)
        {
            try
            {
                 string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
                 string binDir = Path.GetDirectoryName(assemblyLocation);
                 DirectoryInfo dir = new DirectoryInfo(binDir);
                 
                 while (dir != null && dir.Name != "Modules")
                 {
                     dir = dir.Parent;
                 }
                 
                 if (dir != null && dir.Parent != null)
                 {
                     string logsDir = Path.Combine(dir.Parent.FullName, "logs");
                     if (Directory.Exists(logsDir)) return Path.Combine(logsDir, filename);
                 }
            }
            catch {}

            if (Directory.Exists(@"D:\Bannerlord_Mods\logs")) return @"D:\Bannerlord_Mods\logs\" + filename;
            if (Directory.Exists(@"E:\Bannerlord_Mods\logs")) return @"E:\Bannerlord_Mods\logs\" + filename;
            return filename;
        }

        public static bool IsEnabled = true; // Enabled for debugging

        public static void Log(string message)
        {
            if (!IsEnabled) return;
            try
            {
                lock (_lock)
                {
                    string dir = Path.GetDirectoryName(LogFilePath);
                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                    using (StreamWriter sw = File.AppendText(LogFilePath))
                    {
                        sw.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message}");
                        sw.Flush(); 
                    }
                }
            }
            catch { }
        }

        public static void ExecuteBlock(string blockName, Action action)
        {
            Log($"START: {blockName}");
            try
            {
                action();
                Log($"END: {blockName} - Success");
            }
            catch (Exception ex)
            {
                Log($"CRASH in {blockName}: {ex.Message}");
                // throw; 
            }
        }
    }
}
