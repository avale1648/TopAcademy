using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SP2_2cw
{
    class MyClass
    {
        int i;
        double d;
        string s;
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Type t = typeof(string);
            Console.Write(t.ToString());
            foreach (MethodInfo mi in t.GetMethods())
                Console.Write($"\n {mi}");
            Console.Write("\n-=-=-=-\n");
            foreach (FieldInfo fi in t.GetFields(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static))
                Console.Write($"{fi}\n");
        }
    }
}
