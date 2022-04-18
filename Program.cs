using System;

namespace ConsoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Girin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba, " + name + " " + surname);
        }
    }
}
