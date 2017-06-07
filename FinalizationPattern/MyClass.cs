using System;


namespace FinalizationPattern
{
    public class MyClass: IDisposable
    {
        private bool _disposed = false;//финализировался или нет
        /// <summary>
        /// делегирует свои обязанности другому методу
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);//Не вызывать деструктор
        }

        protected virtual void Dispose(bool dsiposing)
        {
            if (!_disposed)
            {
                if (dsiposing)
                {
                    Console.WriteLine("Database connection is closed");
                }
                _disposed = true;
            }
        }
        /// <summary>
        ///  делегирует свои обязанности другому методу
        /// </summary>
        ~MyClass()
        {
            Dispose(false);
            Console.WriteLine("Finalize");
        }
    }
}
