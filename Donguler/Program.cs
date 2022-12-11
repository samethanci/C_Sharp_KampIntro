using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = { "Java", "Python", "C#", "Html", "JavaScript", "React", "Asp.Net", "Asp.Net Core" };

            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}



            //dizilerde foreach kullanılır
            foreach (string item in kurslar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
