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
                Assembly
            }
        }
    }
}
