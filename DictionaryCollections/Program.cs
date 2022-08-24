using System;
using System.Collections.Generic;

namespace DictionaryCollections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //system.collection.generic altında bulunur.
            //key ve value olarak iki değerden oluşur.
            //dictionary key'leri uniqe olmak zorundadırlar.

            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ayşe Hebele");
            kullanıcılar.Add(5, "Yasin Gül");
            kullanıcılar.Add(7, "Ece Dilara");

            //Dicilerin elemamlarına erişim

            Console.WriteLine("***---Dizi elemanlarını Erişim---***");

            Console.WriteLine(kullanıcılar[5]);     //5 (key)indexine sahip (value)elemanı getirir.

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("***---Count---***");

            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("***---Contains---***");

            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Yasin Gül"));

            //Remove
            Console.WriteLine("***---Remove---***");

            kullanıcılar.Remove(10);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("***---Keys---***");

            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("***---Values---***");

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}