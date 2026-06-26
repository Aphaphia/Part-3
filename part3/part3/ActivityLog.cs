using System;
using System.Collections.Generic;

namespace Part3
{
    public static class ActivityLog
    {
        // List that stores all log entries
        private static List<string> logEntries = new List<string>();

        // Adds a new entry to the log
        public static void AddEntry(string action)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string entry = "[" + timestamp + "] " + action;
            logEntries.Add(entry);
        }

        // Returns the last 10 entries as a formatted string
        public static string GetRecentLog()
        {
            if (logEntries.Count == 0)
            {
                return "No activity recorded yet.";
            }

            int startIndex = logEntries.Count - 10;
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            string result = "Here is a summary of recent actions:\n";

            int number = 1;
            for (int i = startIndex; i < logEntries.Count; i++)
            {
                result = result + number + ". " + logEntries[i] + "\n";
                number = number + 1;
            }

            return result;
        }

        // Returns the total number of log entries
        public static int GetCount()
        {
            return logEntries.Count;
        }
    }
}
