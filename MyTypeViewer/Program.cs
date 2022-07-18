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

        // Отобразить имена полей в типе.
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
                Console.WriteLine("-> {0}", name);
            Console.WriteLine();
        }
    }
}
