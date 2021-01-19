using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Sakıp";
            musteri1.Soyadi = "SABANCI";
            musteri1.IbanNo = "740001001231575410625001";
            musteri1.SubeAdi = "Etiler";
            musteri1.HesapBakiyesi = 10000000;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Rahmi";
            musteri2.Soyadi = "KOÇ";
            musteri2.IbanNo = "740001001231676450835001";
            musteri2.SubeAdi = "Etiler";
            musteri2.HesapBakiyesi = 12000000;

            //Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            //foreach (var musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Adi);
            //    Console.WriteLine(musteri.Soyadi);
            //    Console.WriteLine("TR" + musteri.IbanNo);
            //    Console.WriteLine(musteri.SubeAdi + " Şubesi");
            //    Console.WriteLine(musteri.HesapBakiyesi + " TL");
            //    Console.WriteLine("-------------------------------");
            //}

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("MÜŞTERİ EKLEME");
            musterimanager.Ekle(musteri1);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ GÖRÜNTÜLEME");
            musterimanager.Görüntüle(musteri1);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ GÜNCELLEME");
            musterimanager.Guncelle(musteri1);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ SİLME");
            musterimanager.Sil(musteri1);
            Console.WriteLine("----------------------------");

            Console.WriteLine("************************************************");

            Console.WriteLine("MÜŞTERİ EKLEME");
            musterimanager.Ekle(musteri2);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ GÖRÜNTÜLEME");
            musterimanager.Görüntüle(musteri2);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ GÜNCELLEME");
            musterimanager.Guncelle(musteri2);
            Console.WriteLine("----------------------------");

            Console.WriteLine("MÜŞTERİ SİLME");
            musterimanager.Sil(musteri2);
            Console.WriteLine("----------------------------");



            
            
        }
    }
}
