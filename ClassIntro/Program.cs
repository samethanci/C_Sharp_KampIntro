using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Samet HANCI";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Berika";
            kurs2.IzlenmeOrani = 31;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Alihan";
            kurs3.IzlenmeOrani = 55;

            //Console.WriteLine($"Kurs Adı: {kurs1.KursAdi} Kursun Eğitmeni: {kurs1.Egitmen} Kursun İzlenme Oranı: %{kurs1.IzlenmeOrani}");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs item in kurslar)
            {
                Console.WriteLine($"Kurs Adı: {item.KursAdi} Kursun Eğitmeni: {item.Egitmen} Kursun İzlenme Oranı: %{item.IzlenmeOrani}");
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
