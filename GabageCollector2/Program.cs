using System;

using System.Threading;

namespace GabageCollector2
{
    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Destructor thread ID: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread ID: {0}", Thread.CurrentThread.ManagedThreadId);

            MyClass my=new MyClass();
        }
    }
}
