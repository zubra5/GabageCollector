using System;

namespace GabageCollector
{
    class MyClass
    {
        /// <summary>
        /// Destructor
        /// </summary>
        ~MyClass()
        {
            Console.WriteLine("Hello from Destructor");
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            
            //It is not allowed
            //my.~MyClass();

            //my = null;
            //вызов сборщика мусора
            GC.Collect();

            Console.ReadLine();
        }
    }
}
