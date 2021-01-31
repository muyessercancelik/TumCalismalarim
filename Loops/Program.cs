using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            if (AsalSayiMi(6))
            {
                Console.WriteLine("Bu bir asal sayıdır.");
            }
            else
            {
                Console.WriteLine("Bu bir asal sayı değildir.");
            }

        }
        private static bool AsalSayiMi(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);//Şart sağlanmasa bile do çalıştı ve 10 yazdı.
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)//Belli bir şart sağlanana kadar döngü çalışır.
            {
                Console.WriteLine(number);
                number--;
            }
            //Console.WriteLine("Now number is: {0} ", number); Böyle de yazabilirsin.
            Console.WriteLine("Now number is: " + number);
        }

        private static void FoorLoop()
        {
            for (int i = 100; i >= 1; i--)//i sadece bu blok içinde çalışır.
            {
                Console.WriteLine(i);
            }
        }
    }
}
