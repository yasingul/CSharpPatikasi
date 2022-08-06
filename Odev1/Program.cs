using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Odev1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Questions soru = new Questions();
            //soru.question1();
            //soru.question2();
            //soru.question3();
            soru.question4();
        }

        public class Questions
        {
            public void question1()
            {
                Console.Write("Lütfen pozitif bir sayı giriniz.");
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                Console.Write("Lütfen ", n, "adet bir sayı giriniz.");
                int[] sayiDizisi = new int[n];

                for (int i = 0; i < sayiDizisi.Length; i++)
                {
                    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                    sayiDizisi[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("*** Çift Sayıların Listesi ***");

                foreach (var sayi in sayiDizisi)
                {
                    if (sayi % 2 == 0)
                        Console.WriteLine(sayi);
                }

                Console.ReadLine();
            }

            public void question2()
            {
                Console.Write("Lütfen pozitif bir sayı giriniz.");
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                Console.Write("Lütfen ", n, "adet bir sayı giriniz.");
                int[] sayiDizisi = new int[n];

                for (int i = 0; i < sayiDizisi.Length; i++)
                {
                    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                    sayiDizisi[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("*** m değerine eşit ve tam bölünenler ***");

                foreach (var sayi in sayiDizisi)
                {
                    if (sayi % m == 0)
                        Console.WriteLine(sayi);
                }

                Console.ReadLine();
            }

            public void question3()
            {
                Console.Write("Kelime Adedini Giriniz : ");
                int n = int.Parse(Console.ReadLine());

                List<string> words = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Kelimeleri Giriniz : ");
                    string word = Console.ReadLine();
                    words.Add(word);
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(words[i]);
                }
            }

            public void question4()
            {
                Console.Write("Cümle Giriniz: ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');
                Console.WriteLine("Kelime Sayisi : {0}", words.Count());

                Regex r = new Regex(@"\w");

                Console.WriteLine("Harf Sayisi : {0}", sentence.Count());
            }
        }
    }
}