using System;

namespace GCMemoryException
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
            Console.WriteLine("Object " + this.GetHashCode() + " is deleted");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //372 Gb
            BigObject[] objects=new BigObject[1000];
            try
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    //objects[i]=new BigObject();
                    BigObject @object = new BigObject();//optimize +
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
