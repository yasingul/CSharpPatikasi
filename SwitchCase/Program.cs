using System;

namespace SwitchCase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //if-else yapılarıyla yapılan her şeyi switch-case ile de yapabiliriz.
            //Uzun yazımlarda if-else okunabilirliğini kaybedebiliyor ama Switch/Case yapısı uzun işlemler için daha uygun ve okunur kod yazılmasını sağlar.
            int month = DateTime.Now.Month;

            //Parantez içerisine Expression yazılır. Kontrol edilmek istenen koşul yazılır.
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız!");
                    break;

                case 2:
                    Console.WriteLine("Şubat Ayındasınız!");
                    break;

                case 3:
                    Console.WriteLine("Mart Ayındasınız!");
                    break;

                case 4:
                    Console.WriteLine("Nisan Ayındasınız!");
                    break;

                case 6:
                    Console.WriteLine("Haziran Ayındasınız!");
                    break;

                case 5:
                    Console.WriteLine("Mayıs Ayındasınız!");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girdiniz!");
                    break;
            }
            // switch/case ifadesinde caseleri çoklu olarak yazıp tek bir çıktı vermelerini sağlayabiliyoruz.
            //Aynı zamanda tek bir case için tek bir değer atamamız gerekecek. case3: case3: şeklinde bir yazım hatalı olacaktır.

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz.");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimindesiniz.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz.");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz.");
                    break;

                default:
                    break;
            }

            //default olma zorunluluğu yoktur. Case sırasının herhangi bir zorunluluğu yok. default en altta olması gerekmemekte.
        }
    }
}