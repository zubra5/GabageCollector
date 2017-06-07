using System;
using System.Threading;


namespace GarbageCollector_002
{
    class MyClass
    {
        private int _i;

        public MyClass(int i)
        {
            _i = i;
        }

        ~MyClass()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Finalized class {0}!", _i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new MyClass(i);//создаем по слабой ссылки. после создания они никому не нужны, т е они будут мусором
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //for (int i = 0; i < 80; i++)
            //{
            //    Console.Write(".");
            //}
        }
    }
}
