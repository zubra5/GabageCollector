using System;


namespace GabageCollector5
{

    class MyClass
    {
        ~MyClass()
        {
           throw new Exception();
            Console.WriteLine("Succeeded");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my= new MyClass();
        }
    }
}
