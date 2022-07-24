using System;

namespace Operators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Atame ve İşlemli Atama
            int x = 3;
            int y = 6;
            y += 2; // y+2
            Console.WriteLine(y);
            y /= 2; // y/2
            Console.WriteLine(y);
            x *= 2; // x*2
            Console.WriteLine(x);

            //Mantıksal Operatörler ( || && ! )
            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)    //ve anlamındadır. ikiside true ise çalışır.
                Console.WriteLine("Perfect!");
            if (isSuccess || isCompleted)    //veya anlamındadır. ikisinden birisi true ise çalışır.
                Console.WriteLine("Great!");
            if (isSuccess && !isCompleted)    //değil anlamındadır. 2.değerin tam tersi değerini alır. false ise true olarak alır.
                Console.WriteLine("Fine :)");

            ////İlişkisel Operatörler (<, >, <=, >=, ==, !=)
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik İfadeler (/, +, *, -, %)
            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2 = sayi * sayi2;
            Console.WriteLine(sonuc1);
            int sonuc3 = sayi + sayi2;
            Console.WriteLine(sonuc1);
            int sonuc4 = sayi - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi++;
            Console.WriteLine(sayi);
            int sayi3 = 20 % 3; //Bölme işleminde kalanı getirir. Mod diye okunur.
            Console.WriteLine(sayi3);
        }
    }
}