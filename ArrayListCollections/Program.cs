using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListCollections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('a');

            //içerisinde ki verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange - eleman ekler.

            Console.WriteLine("***---AddRange---***");

            string[] renkler = { "Kırmızı", "Sarı", "Yeşil", "mavi" };
            List<int> numbers = new List<int>() { 1, 8, 3, 5, 47, 18, 52, 35, 5260 };
            liste.AddRange(renkler);
            liste.AddRange(numbers);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort - sıralar

            Console.WriteLine("***---Sort---***");

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search - elemanı arar ve sıra numarasını bize verir.

            Console.WriteLine("***---Binary Search---***");

            Console.WriteLine(liste.BinarySearch(35));

            // Reverse  -listeyi ters çevirir-aynalar

            Console.WriteLine("***---Reverse---***");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear -    listeyi temizler

            Console.WriteLine("***---Clear---***");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}