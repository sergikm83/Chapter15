using System;
using System.Reflection;

namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Отобразить имена методов в типе.
        static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach(MethodInfo m in mi)
                Console.WriteLine("-> {0}",m.Name);
            Console.WriteLine();
        }
    }
}
