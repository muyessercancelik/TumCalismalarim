using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}
