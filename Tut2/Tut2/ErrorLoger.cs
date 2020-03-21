using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tut2
{
    public class ErrorLoger
    {
        private static string LogFileName = "log.txt";
        public List<string> Messages = new List<string>();

        public void AddMessage(string message)
        {
            Messages.Add(message);
        }

        public void PrintMessages()
        {
            StreamWriter writer = new StreamWriter(LogFileName);
            if (Messages.Count == 0)
            {
                writer.WriteLine("");
            }
            
            foreach(string message in Messages)
            {
                writer.WriteLine(message);
                
            }
            writer.Flush();
        }

    }
}
