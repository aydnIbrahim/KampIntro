using System;

namespace KampIntro { 
    class Program
{
        static void Main(string[] args)
        {
            //type safety - tip güvenliği c# ve java bu konuda epey katıdır
            string kategoriEtiketi = "Kategori";
            bool ok = false;
            Console.WriteLine(kategoriEtiketi);
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış butonu göster");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster.");
            }

            else
            {
                Console.WriteLine("Değişmedi butonunu göster.");
            }

            
        }
    }
}