using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo1
{
    internal class MusteriManager
    {
        public void musterileriListele(params Musteri[] musteri)
        {

            Console.WriteLine("---------Müşteriler----------");

            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Id + " " + musteriler.Adi + " " + musteriler.Yasi + " " + musteriler.Maasi);

            }
            Console.WriteLine("----------------------------------");

        }

        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("---------Eklenen Müşteri----------");

            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Yasi + " " + musteri.Maasi);

            Console.WriteLine("----------------------------------");
        }


        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine("---------Silinen Müşteri----------");

            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Yasi + " " + musteri.Maasi);

            Console.WriteLine("----------------------------------");
        }








    }
}
