using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AlgorithmQuestionsCollections1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Questions questions = new Questions();
            //questions.Questions1();
            //questions.Questions2();
            questions.Questions3();

            Console.ReadLine();
        }

        private class Questions
        {
            public void Questions1()
            {
                /*
                 * Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
                 * Negatif ve numeric olmayan girişleri engelleyin.
                 * Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                 * Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
                 */

                List<int> numbers = new List<int>();
                Console.WriteLine("Write a number: ");
                for (var i = 0; i < 20; i++)
                {
                    while (true)
                    {
                        string n = Console.ReadLine();
                        try
                        {
                            int num = int.Parse(n);
                            if (num <= 0) throw new Exception("Input values must be positive integers");
                            else
                            {
                                numbers.Add(num);
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                List<int> primeNumbers = new List<int>();
                List<int> nonPrimeNumbers = new List<int>();

                List<int> primesUnderSeventeen = new List<int> { 2, 3, 5, 7, 11, 13 };

                foreach (int i in numbers)
                {
                    if (i < 17)
                    {
                        if (primesUnderSeventeen.Contains(i)) primeNumbers.Add(i);
                        else nonPrimeNumbers.Add(i);
                    }
                    else
                    {
                        if (((i + 1) % 2 == 0) | ((i - 1) % 2 == 0)) primeNumbers.Add(i);
                        else nonPrimeNumbers.Add(i);
                    }
                }
                Console.WriteLine("Prime Numbers");
                foreach (var j in primeNumbers.OrderBy(x => x))
                    Console.WriteLine(j.ToString() + " ");
                Console.WriteLine("");
                Console.WriteLine("Prime Numbers Average : " + ((float)primeNumbers.Sum() / (float)primeNumbers.Count()).ToString());

                Console.WriteLine("Non Prime Numbers");
                foreach (var j in nonPrimeNumbers.OrderBy(x => x))
                    Console.WriteLine(j.ToString() + " ");
                Console.WriteLine("");
                Console.WriteLine("Non Prime Numbers Average : " + ((float)nonPrimeNumbers.Sum() / (float)nonPrimeNumbers.Count()).ToString());
            }

            public void Questions2()
            {
                /* Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
                * her iki grubun kendi içerisinde ortalamalarını alan ve
                * bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
                */

                List<int> nums = new List<int>();
                Console.WriteLine("Write a number : ");
                for (var i = 0; i < 20; i++)
                {
                    while (true)
                    {
                        string n = Console.ReadLine();
                        try
                        {
                            int num = int.Parse(n);
                            nums.Add(num);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                List<int> maxNums = new List<int>();
                List<int> minNums = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    int maxNum = nums.Max();
                    Console.WriteLine("Maximum element " + maxNum);
                    //Console.WriteLine("Maximum element " + maxNum.GetType());
                    maxNums.Add(maxNum);
                    maxNums.Remove(maxNum);

                    int minNum = nums.Min();
                    Console.WriteLine("Minimum element " + minNum);
                    minNums.Add(minNum);
                    minNums.Remove(minNum);
                }

                Console.WriteLine("nums");
                foreach (int k in nums) Console.WriteLine(k);

                Console.WriteLine("maxNUms");
                foreach (int k in maxNums) Console.WriteLine(k);

                Console.WriteLine("minNums");
                foreach (int k in minNums) Console.WriteLine(k);
            }

            public void Questions3()
            {
                Console.WriteLine("Give me a sentence");
                string sentence = Console.ReadLine();
                string pattern = @"[aeıuüioö]";
                Regex rg = new Regex(pattern);
                MatchCollection vowelSounds = rg.Matches(sentence);
                foreach (Match match in vowelSounds) Console.WriteLine(match);
            }
        }
    }
}