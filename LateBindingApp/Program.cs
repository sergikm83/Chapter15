using System;
using System.IO;
using System.Reflection;

namespace LateBindingApp
{
    // Это приложение будет загружать внешнюю сборку и
    // создавать объект, используя позднее связывание.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****");
            // Попробовать загрузить локальную копию CarLibrary.
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (a != null)
                // continue this
                ;
        }

    }
}
