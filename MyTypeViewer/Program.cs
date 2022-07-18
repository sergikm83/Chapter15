using System;
using System.Reflection;
using System.Linq;


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
            // MethodInfo[] mi = t.GetMethods();
            var methodNames = from n in t.GetMethods() select n.Name;
            foreach(var name in methodNames)
                Console.WriteLine("-> {0}",name);
            Console.WriteLine();
        }
    }
}
