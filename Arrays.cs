using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            // Sort: Sıralama yapar.
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("**** sırasız dizi ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("**** sıralı dizi ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear: Verdiğimiz dizi içerisinde, verdiğimiz indeksten başlayarak verdiğimiz eleman sayısı kadar değeri sıfırlar.
            Console.WriteLine("**** Array Clear ****");

            Array.Clear(sayiDizisi, 2, 2);  //2. değerden başlatarak 2 tane elemanı sıfırlar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse: Tersine çevirme işlemi. Diziyi ortadan aynalayarak yer değiştirir.
            Console.WriteLine("**** Array Reverse ****");

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf: Verdiğimiz dizi üzerinde verdiğimiz elemanın eğer içeride varsa indexsini döner.
            Console.WriteLine("**** Array İndexOf ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize: Yeniden boyutlandırma yapar.
            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi, 9);   //normalde 8 elemanlı bir diziyi 9 elemanlı hale getirdik.
            sayiDizisi[8] = 99;     //9. elemana 99 değeri atadık.
        }
}
