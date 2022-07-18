using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;


namespace MyTypeViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Вспомогательный метод для отображения
        // элементов коллекции IEnumerable<T>.
        // Сделан с целью рефакторингаю
        static void PrintCollection(IEnumerable<string> collection)
        {
            foreach (var item in collection)
                Console.WriteLine("-> {0}", item);
            Console.WriteLine();
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
