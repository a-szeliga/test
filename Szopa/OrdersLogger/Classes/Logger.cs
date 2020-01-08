using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace OrdersLogger.Classes
{
    public abstract class Logger
    {
        public virtual void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }

        public abstract string ReadLogs();
    }

    public class FileLogger : Logger
    {
        public override void Log(string message)
        {
            File.WriteAllText("logs.txt", message);
            base.Log(message);
        }

        public override string ReadLogs()
        {
            return File.ReadAllText("logs.txt");
        }
    }
}
