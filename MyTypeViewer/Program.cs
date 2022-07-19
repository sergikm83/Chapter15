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
            Console.WriteLine("***** Welcome to MyTypeViewer *****");
            string typeName = "";
            do
            {
                // Предложение ввести имя типа
                Console.WriteLine("\nEnter a type name to evaluate");
                // или Q для завершения.
                Console.Write("or enter Q to quit: ");
                // получить имя типа
                typeName = Console.ReadLine();
                // желает ли пользователь завершить программу?
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    break;
                // попробовать отобразить информацию о типе.
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine();
                    AdvanceListMethods(t);
                    //ListVariuosStats(t);
                    //ListFields(t);
                    //ListProps(t);
                    //ListMethods(t);
                    //ListInterfaces(t);
                }
                catch
                {
                    // не удается найти тип.
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
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
            var methodNames = from n in t.GetMethods() select n;
            foreach (var name in methodNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        // Отобразить имена полей в типе.
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;
            PrintCollection(fieldNames);
        }

        // Отобразить имена свойств в типе.
        static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() select p.Name;
            PrintCollection(propNames);
        }

        // Отобразить имена интерфейсов, которые реализуют тип.
        static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var ifaces = from i in t.GetInterfaces() select i.Name;
            PrintCollection(ifaces);
        }

        // Просто ради полноты картины.
        static void ListVariuosStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            // базовый класс
            Console.WriteLine("Base class is: {0}", t.BaseType);
            // Абстрактный?
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            // Запечатанный?
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            // Обобщенный?
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            // Класс?
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}
