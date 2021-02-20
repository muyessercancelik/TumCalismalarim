using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalismam
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms iletildi. ");
        }
    }
}
