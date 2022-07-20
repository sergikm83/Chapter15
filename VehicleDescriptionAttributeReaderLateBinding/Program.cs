using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            string currProjPath = AppContext.BaseDirectory;
            string findStr = "VehicleDescriptionAttributeReaderLateBinding";
            string currSolutionPath = currProjPath.Substring(0, currProjPath.IndexOf(findStr));
            string asmName = @"AttributesCarLibrary\bin\Debug\net5.0\AttributesCarLibrary.dll";
            string fullAssemblyPath = currSolutionPath + asmName;
            Console.WriteLine($"{fullAssemblyPath}");
        }
        private static void ReflectAttributesUsingLateBinding(string pathAndFilenameAssembly)
        {
            try
            {
                // Загрузить локальную сборку AttributesCarLibrary.
                Assembly asm = Assembly.LoadFrom(pathAndFilenameAssembly);
                // Получить информацию о типе VehicleDescriptionAttribute.
                Type vehicleDesc = asm.GetType("AttributesCarLibrary.VehicleDescriptionAttribute");
                // Получить информацию о типе свойства Description.
                PropertyInfo propDesc = vehicleDesc.GetProperty("Description");
                // Получить все типы в сборке.
                Type[] types = asm.GetTypes();
                // Пройти по всем типам и получить любые атрибуты
                // VehicleDescriptionAttribute.
                foreach(Type t in types)
                {
                    object[] objs = t.GetCustomAttributes(vehicleDesc, false);
                    // Пройти по каждому VehicleDecriptionAttribute
                    // и вывести описание, используя позднее связывание.
                    foreach(object o in objs)
                        Console.WriteLine("-> {0}: {1}\n",
                            t.Name,propDesc.GetValue(o,null));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
