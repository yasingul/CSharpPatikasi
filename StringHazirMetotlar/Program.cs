using System;

namespace StringHazirMetotlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
            string degisken2 = "CSharp";

            //length

            Console.WriteLine(degisken.Length);     //Uzunluk

            //ToUpper, ToLower

            Console.WriteLine(degisken.ToUpper());  //hepsini büyük harfle yazar.
            Console.WriteLine(degisken.ToLower());  //hepsini küçük harfle yazar.

            //Concat

            Console.WriteLine(String.Concat(degisken, " Merhaba!"));    //iki metni birleştirir.

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));       //0, 1, -1 değerlerini alır
            Console.WriteLine(String.Compare(degisken, degisken2, true));       //büyük küçük harf duyarsız hale gelir
            Console.WriteLine(String.Compare(degisken, degisken2, false));       //büyük küçük harf duyarsız hale gelir

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));    //degisken içerisinde degisken2'yi içeriyor muı durumu kontrol edilir.
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));    //Hoşgeldiniz. ile bitip bitmediğini kontrol ederiz.
            Console.WriteLine(degisken.StartsWith("Merhaba!"));      //Merhaba ile başlıyor mu diye konterol deriz.

            //IndexOf

            Console.WriteLine(degisken.IndexOf("CS"));      //Degisken içerisinde verdiğimiz kelimenin hangi index'te(yerini) olduğunu gösterir. Bulamaz ise -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i"));   //verdiğimiz harfin hangi en son indexte olduğunu gösterir.

            //Insert

            Console.WriteLine(degisken.Insert(0, "Merhaba"));    //hangi indexten başlayıp sonrasında ne ekleyeceğimizi yazarız.

            //PadLeft, PadRight

            Console.WriteLine(degisken + degisken2.PadLeft(30));    //degisken2'nin sol tarafına eğer 30 karakterden düşükse 30 karaktere tamamlayacak kadar boşluk bırakır.
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove

            Console.WriteLine(degisken.Remove(10));     //10. indexten başlayıp sonuna kadar silme işlemi yapar. 10. indexten öncesini getirir.
            Console.WriteLine(degisken.Remove(5, 3));    //5. karakterden başlayıp 3 karakter siler
            Console.WriteLine(degisken.Remove(0, 1));    //0. indexten başlayıp 1 karakter siler.

            //Replace

            Console.WriteLine(degisken.Replace("CSharp", "C#"));    //CSharp yazan yerleri C# yaptı.
            Console.WriteLine(degisken.Replace(" ", "*"));      //Boşluklar yerine * karakterini kullandı.

            //Split

            Console.WriteLine(degisken.Split(' ')[1]);  //boşluklardan kesip string bir dizi tanımladı ve o dizinin 1. indexinde yer alan elemanını ekrana yazdırır.

            //Substring

            Console.WriteLine(degisken.Substring(4));   //4. indexten başlayarak sonuncu indexe kadar yazdırır.
            Console.WriteLine(degisken.Substring(4, 6));    //4. indexten başlayıp 6 karakteri ekrana yazdırır.
        }
    }
}