using System;
using System.Threading;

namespace GarbageCollector
{
    class NormalObject
    {
        byte[] array=new byte[1024];// 1 Kb

        public NormalObject()
        {
            Console.WriteLine("Constructor {0}", this.GetHashCode());
        }

        ~NormalObject()
        {
            Console.WriteLine("Destructor {0}", this.GetHashCode());
        }
    }

    class OtherObject
    {
        byte[] array=new byte[1024*50];//50 Kb
    }

    class Program
    {
        static void AuxiliaryMethod()
        {
            OtherObject[] objects=new OtherObject[1000];

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i]=new OtherObject();

                Thread.Sleep(5);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("System contains {0} generations.", (GC.MaxGeneration+1));
            Console.WriteLine(new string('_',40));

            NormalObject @object=new NormalObject();

            new Thread(AuxiliaryMethod).Start();

            for (int i = 0; i < 30; i++)
            {
                Console.Write("Generation: {0} |", GC.GetGeneration(@object));
                Console.WriteLine("Size of heap = {0} Kb", GC.GetTotalMemory(false)/1024);//true
                Thread.Sleep(100);
            }

            Console.WriteLine(new string('_', 40));
            Console.WriteLine("Generation 0 was checked {0} times", GC.CollectionCount(0));
            Console.WriteLine("Generation 1 was checked {0} times", GC.CollectionCount(1));
            Console.WriteLine("Generation 2 was checked {0} times", GC.CollectionCount(1));
            Console.WriteLine(new string('_', 40));

        }
    }
}
