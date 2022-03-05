using System;
using System.Collections.Generic;
using System.IO;

namespace SP
{
    public static class Logger
    {
        static private readonly string logFileName = "logs.txt";
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" +
                                    LoginValidator.currentUser.Username + ";" +
                                    LoginValidator.currentUser.Role + ";" +
                                    activity;
            currentSessionActivities.Add(activityLine);

            File.AppendAllText(logFileName, activityLine + "\n");
        }

        static public void ShowLogs()
        {
            if (!File.Exists(logFileName))
            {
                return;
            }
            Console.WriteLine("\nLogs from file:");
            Console.WriteLine(File.ReadAllText(logFileName));
        }

        static public void ShowCurrentSessionLogs()
        {
            Console.WriteLine("Current log session:");

            foreach (string log in currentSessionActivities)
            {
                Console.WriteLine(log);
            }

        }

        static public void CreateCertificate(string certificate, string pathToFile)
        {
            File.WriteAllText(pathToFile, certificate);
        }
    }
}
