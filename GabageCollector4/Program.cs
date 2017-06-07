using  System;
using System.Threading;

namespace GabageCollector4
{
    class MyClass
    {
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
        }
    }
}
