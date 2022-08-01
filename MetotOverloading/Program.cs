using System;

namespace MetotOverloading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(3, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Overloading = Metot Aşırı Yükleme

            int ifade = 987;
            instance.EkranaYazdir(ifade);

            //Metot imzasına göre karar verir.
            //Metot İmzası = metotAdı + parametre sayısı + parametre, bu iç ifade metot imzasını oluşturur.

            instance.EkranaYazdir("Yasin", "GÜL");
        }

        private class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}