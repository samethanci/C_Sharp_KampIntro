using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerçek Müşteri

            GercekMusteri gercekMusteri1 = new GercekMusteri() { Id = 1, MusteriNo = "12345", TcNo = "1234567890", Adi = "Samet", Soyadi = "HANCI" };


            // Tüzel Müşteri
            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 5;
            tuzelMusteri1.MusteriNo = "1232789";
            tuzelMusteri1.VergiNo = "12315453";
            tuzelMusteri1.SirketAdi = "HANCI HOLDING";


            Musteri musteri = new GercekMusteri();
            Musteri musteri1 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(gercekMusteri1);
            musteriManager.Add(tuzelMusteri1);
            musteriManager.Add(musteri);
            musteriManager.Add(musteri1);

        }
    }
}
