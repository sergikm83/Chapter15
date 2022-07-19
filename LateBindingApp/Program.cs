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
                a = Assembly.LoadFrom("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (a != null)
                CreateUsingBinding(a);
        }
        static void CreateUsingBinding(Assembly asm)
        {
            try
            {
                // Получить метаданные для типа MiniVan.
                Type miniVan = asm.GetType("CarLibrary.MiniVan");
                // Создать экземпляр MiniVan на лету.
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);
                // Получить информацию о TurboBoost.
                MethodInfo mi = miniVan.GetMethod("TurboBoost");
                // Вызвать метод (null означает отсутствие параметров).
                mi.Invoke(obj,null);
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
