using System;
using System.Threading;

namespace IDisposableFinalization
{
    public class MyClass : IDisposable
    {
        //по требованию
        public void Dispose()
        {
            Console.WriteLine("Method Dispose() fineshed:"+this.GetHashCode());
        }

        public void SomeMethod()
        {
            Console.WriteLine("Some work");
        }
        //автоматически
        ~MyClass()
        {
            Console.WriteLine("Finilizator finished:"+this.GetHashCode());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance= new MyClass();
            try
            {
                instance.SomeMethod();
            }
            finally
            {
                if (instance is IDisposable && instance != null)
                {
                    instance.Dispose();
                }
            }

            Console.WriteLine( new string('_',30));
            using (instance = new MyClass())
            {
                instance.SomeMethod();
            }

            Console.ReadKey();
        }
    }
}
