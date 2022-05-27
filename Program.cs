using System;

namespace donguler_for_loop
{

    class Program
    {
        static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");

            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamları ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; // tekToplam = tekToplam + i ;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Cift Toplam: " + ciftToplam);

            // break = döngüyü sonlandırmak için, continue = mevcut döngünün o cycle atlamak

            // for (int i = 0; 1 < length; i++)
            // {
            //     if (i == 4)
            //         break;
            //     Console.WriteLine(i);
            // }
        }

    }
}
