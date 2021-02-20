using System;

namespace InterfaceCalismam
{
    class FileBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
