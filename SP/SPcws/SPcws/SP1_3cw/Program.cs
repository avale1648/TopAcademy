using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/////////////////////////
namespace SP1_3cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Processes List";
            Process[] processes= Process.GetProcesses();
            Console.WriteLine("{0,-28},{1,-10}","Process's Name:","PID: \n");
            foreach(var item in processes)
                Console.WriteLine("{0,-28},{1,-10}",item.ProcessName,item.Id);
        }
    }
}
