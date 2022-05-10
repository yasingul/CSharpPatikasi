using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama
{
    class WhileForeach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********While Döngüsü***********");
            // 1Den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplama
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z'ye kadar tüm harfleri konsola yazdır. (z dahil değil)
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);   //çıktıyı yan yana yazdırır.
            }

            Console.WriteLine("***********ForEach Döngüsü***********");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };   //dizi tanımladık

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
