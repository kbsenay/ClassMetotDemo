using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Yeni Eklenen Müşteri : "+ musteri.Adi + " " + musteri.Soyadi);
        }

        public void Guncelle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi + " isimli müşterinin bilgileri güncellendi!");
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Silindi!");
        }

        public void Görüntüle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Adı-Soyadı : " + musteri.Adi + " " +  musteri.Soyadi);
            Console.WriteLine("Iban No : " + "TR" +  musteri.IbanNo);
            Console.WriteLine("Şube adı : " + musteri.SubeAdi + " Şubesi");
            Console.WriteLine("Hesap Bakiyesi : " + musteri.HesapBakiyesi + " TL");
        }
    }
}
