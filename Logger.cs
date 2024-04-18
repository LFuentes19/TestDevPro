using System;
using System.IO;

//Task 1: Logger
public class Logger
{
	///<summary>
	///This method prints the latest log status in the specified log file.
	///</summary>
	///<param name="filePath"> string => Directory file path.
	///<param name="message"> string => Descriptive message for the log status.
	///<param name="status"> string => Log status.
    public static void LogMessage(string filePath, string message, string status)
    {
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{status}] {message}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }
}


