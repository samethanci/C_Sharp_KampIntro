using System;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DortIslem dortIslem = new DortIslem();
            Console.Write("Sayı1 giriniz: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Sayı2 giriniz: ");
            double number2 = double.Parse(Console.ReadLine());
            dortIslem.Topla(number1, number2);
        }
    }
}
