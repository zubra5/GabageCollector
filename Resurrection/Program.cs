using System;
using System.Threading;

namespace Resurrection
{
    internal sealed class SomeType
    {
        private int counter;

        public SomeType()
        {
            counter = 0;
        }

        ~SomeType()
        {
            Console.WriteLine("Finalizer {0}", ++counter);

            if (counter < 3)
            {
                GC.ReRegisterForFinalize(this);
            }
        }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            SomeType instance= new SomeType();
            instance = null;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                GC.Collect();

                Console.WriteLine("\t\tmain {0} iteration", i);
            }
        }
    }
}
