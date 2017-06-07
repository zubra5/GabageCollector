using System;


namespace GCBigObjects
{
    class BigObject
    {
        //381 Mb
        private Array array = new int[100000000];

        public BigObject()
        {
            Console.WriteLine(this.GetHashCode());
        }

        ~BigObject()
        {
            Console.WriteLine("Object "+this.GetHashCode()+" is deleted");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //381 Mb
            Array array = new int[100000000];
            Console.WriteLine("Generation of Array's object: {0}", GC.GetGeneration(array));

            BigObject @object = new BigObject();
            Console.WriteLine("Generation of BigObjects's object: {0}", GC.GetGeneration(@object));

            Console.ReadKey();
        }
    }
}
