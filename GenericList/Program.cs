using System;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<T> class => yazım şekli
            //System.Collections.Generic
            //T => Generic yapıda olduğunu gösterir. Hangi tür nesneleri ekleyeceğimizi T ile belirtiriz.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(1);
            sayiListesi.Add(2);
            sayiListesi.Add(3);
            sayiListesi.Add(4);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("sarı");
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");

            //Count:

            Console.WriteLine(renkListesi.Count);   //liste içerisinde ki eleman sayısını bize getirir.
            Console.WriteLine(sayiListesi.Count);   //sayiListesi içerisinde ki eleman sayısını bize verir.

            //Foreach ve List.ForEach ile eleman erişimi
            //Liste elemanlarını ekrana yazdırmak:

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma

            sayiListesi.Remove(2);  //2. indekste ki elemanı çıkartır
            renkListesi.Remove("kırmızı");  //kırmızı elemanını çıkartır. hem indeks hem eleman verebiliriz.

            //Liste içerisinde arama

            if (sayiListesi.Contains(1))
            {
                Console.WriteLine("1 Liste içerisinde bulundu!");
            }

            //Eleman ile indekse erişme

            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //Diziyi liste çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?

            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Yasin";
            kullanici1.Soyisim = "Gul";
            kullanici1.Yas = 28;

            kullaniciListesi.Add(kullanici1);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar
            {
                Isim = "Ece",
                Soyisim = "Gül",
                Yas = 30
            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Yas);
            }

            kullaniciListesi.Clear();
        }
    }

    public class Kullanicilar
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}