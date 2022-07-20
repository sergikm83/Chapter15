// Выполнение рефлексии атрибутов с использованием раннего связывания.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttributesCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();
        }
        private static void ReflectOnAttributesUsingEarlyBinding()
        {
            // Получить объект Type, представляющий тип Winnebago.
            Type t = typeof(Winnebago);
            // Получить все аттрибуты Winnebago.
            object[] customAtts = t.GetCustomAttributes(false);
            // вывести описание.
            foreach(VehicleDescriptionAttribute v in customAtts)
                Console.WriteLine("-> {0}",v.Description);
        }
    }
}
