using System;

namespace DestructorTryCatch
{
    class MyClass
    {
        ~MyClass()
        {
            try
            {
                throw new Exception("Some Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Succeeded");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my=new MyClass();
        }
    }
}
