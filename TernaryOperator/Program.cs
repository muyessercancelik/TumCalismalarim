using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            string odev;
            odev = (a < 5) ? "a, 5'ten küçüktür." : "a, 5'ten büyüktür.";  //C# dilinde "ternary operatörü"

            Console.WriteLine(odev);

        }
    }
}
