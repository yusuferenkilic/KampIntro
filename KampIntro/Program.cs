using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGrisiYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu"");
            }

            if (sistemeGrisiYapmisMi == true)
            {
                Console.WriteLine("Ayarlar");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

            Console.WriteLine(kategoriEtiketi);

            Sa<string>
        }
    }
}
