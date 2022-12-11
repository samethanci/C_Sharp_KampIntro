using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdeti = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Köy Çileği";
            urun2.StokAdeti = 30;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun item in urunler)
            {
                Console.WriteLine($"Ürün Adı: {item.Adi} Ürün Fiyatı: {item.Fiyati} Ürün Açıklaması: {item.Aciklama} Stok Adeti: {item.StokAdeti}");
            }
            Console.WriteLine("--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
