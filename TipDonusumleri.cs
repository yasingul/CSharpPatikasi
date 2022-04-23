using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama
{
    class TipDonusumleri
    {
    //    ***** Implicit Conversion (Bilinçsiz Dönüşüm) *****
    //    Düşük kapasiteli bir değişkenin kendisinde nyüksek kapasiteli bir değişkene atanmasıdır.
    //    Örnek:
    //    Console.WriteLine("Implicit Convertion");

    //    byte a = 4;
    //    sbyte s = 5;
    //    short c = 10;

    //    int d = a + s + c;
    //    Console.WriteLine("d: " + d);

    //    long h = d;
    //    Console.WriteLine("h: " + h);
        
    //    float i = h;
    //    Console.WriteLine("i: " + i);

    //    string e = "Yasin";
    //    char f = 'k';
    //    object g = e + f + d;
    //    Console.WriteLine("g: " + g);

    //    ***** Explicit Convertion (Bilinçli Dönüşüm) ******
    //    CSharp'ın kendisinin yapamadığı dönüşümlerdir. Manuel olarak kendimiz yapmak yapmamız gerekiyor. 
    //    Parse, Convert ve ToString başlıca örnekleri.

    //    Console.WriteLine("Explicit Convertion");
    //    int x = 4;
    //    byte y = (byte)x;   //bu şekilde yaptığımızda parantezin sağında ki veriyi parantez içinde ki veriye dönüştürmeye çalışır.
    //    Console.WriteLine("y: " + y);

    //    int z = 100;
    //    byte t = (byte)z;
    //    Console.WriteLine("t: " + t);

    //    float w = 10.3f;
    //    byte v = (byte)w;
    //    Console.WriteLine("v: " + v);

    //    ***** ToString() Metodu *****
    //    Aldığı veriyi string olarak değiştirir.
    //    Console.WriteLine("ToString() Metodu");

    //    int xx = 7;
    //    string yy = xx.ToString();
    //    Console.WriteLine("yy: " + yy);

    //    string zz = 10.5f.ToString();
    //    Console.WriteLine("zz: " + zz);

    //    ***** System.Convert
    //    Console.WriteLine("System.Convert Metodu");

    //    string s1 = "10", s2 = "20";
    //    int sayi1, sayi2;
    //    int Toplam;

    //    sayi1 = Convert.ToInt32(s1);
    //    sayi2 = Convert.ToInt32(s2);
            
    //    Toplam = sayi1 + sayi2;
    //    Console.WriteLine("Toplam: " + Toplam);

    //    ***** Parse Metodu *****
    //    String ifadeleri int ifadelere dönüştürmek için kullanırız.
    //    Console.WriteLine("--**--Parse Metodu--**--");

    //    ParseMethod();
    }

    //public static void ParseMethod()
    //{
    //    string metin1 = "10";
    //    string metin2 = "10.25";
    //    int rakam1;
    //    double double1;

    //    rakam1 = Int32.Parse(metin1);
    //    double1 = Double.Parse(metin2);

    //    Console.WriteLine("rakam1: " + rakam1);
    //    Console.WriteLine("double1: " + double1);
    //}
}
