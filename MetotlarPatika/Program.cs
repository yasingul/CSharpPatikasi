using System;

namespace MetotlarPatika
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adı(parametreListesi/arguman)
            //{
            //komutlar;
            //return;   //geri dönüşlerde kullanılır.
            //}
            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);    //Metodu çağırdık.
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();    //class dışında oluşturduğumuz metodu bu şekilde çağırırız.
            ornek.EkranaYazdir(Convert.ToString(sonuc));
        }

        private static int Topla(int deger1, int deger2)    //Metodu burada tanımladık. Geriye bir değer döndüğü için static dememiz lazım.
        {
            return (deger1 + deger2);
        }

        private class Metotlar
        {
            public void EkranaYazdir(string veri)      //bir değer dönmediği için void dedik.
            {
                Console.WriteLine(veri);
            }

            //ref anahtar kelimesi ile referanslarını alırız ve çağıracağımız değerlerin başına da ref anahtar kelimesini yazarız.
        }
    }
}