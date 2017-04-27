using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("IOHook!");
            string dbDirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory+"\\DB\\";
            string dbPathFileName = dbDirectoryPath + System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            if (!Directory.Exists(dbDirectoryPath)) Directory.CreateDirectory(dbDirectoryPath);
            if (!File.Exists(dbPathFileName)) 
            Console.WriteLine("dbPath;"+ dbPathFileName);
        }
        
    }
}
