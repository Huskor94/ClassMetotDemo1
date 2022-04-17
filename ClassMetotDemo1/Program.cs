using System;

namespace ClassMetotDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "12345678901";
            musteri1.Adi = "Derin";
            musteri1.Yasi = 25;
            musteri1.Maasi = 9000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "12345678902";
            musteri2.Adi = "Deniz";
            musteri2.Yasi = 30;
            musteri2.Maasi = 9200;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "12345678903";
            musteri3.Adi = "Ece";
            musteri3.Yasi = 32;
            musteri3.Maasi = 10000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = "12345678904";
            musteri4.Adi = "Mustafa";
            musteri4.Yasi = 29;
            musteri4.Maasi = 8000;

            Musteri musteri5 = new Musteri();
            musteri5.Id = "12345678905";
            musteri5.Adi = "Hüseyin";
            musteri5.Yasi = 28;
            musteri5.Maasi = 2500;



            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.musterileriListele(musteri1,musteri2,musteri3);
           
            musteriManager.musteriEkle(musteri4);

            musteriManager.musteriSil(musteri5);


        }
    }
}
