using System;

namespace DateMathHazırMetotlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** DateTime Kütüphanesi *****");

            Console.WriteLine(DateTime.Now);            //Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);     //Haftanın gününü string olarak getirir.
            Console.WriteLine(DateTime.Now.DayOfYear);      //İçinde olduğumuz yılın kaçıncı gününde olduğumuzu gösterir.

            Console.WriteLine(DateTime.Now.ToLongDateString()); //uzun uzun günü ve ayı yazar
            Console.WriteLine(DateTime.Now.ToShortDateString());    //Kısaca tarihi yazar
            Console.WriteLine(DateTime.Now.ToLongTimeString());     //saati gösterirken saniyeyi de ekler
            Console.WriteLine(DateTime.Now.ToShortTimeString());    //sadece saat ve dakika gösterir.

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(1));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTime Formatları

            //Günler
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            //Aylar
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("mm"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            //Yıllar
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("***** Math Kütüphanesi *****");

            Console.WriteLine(Math.Abs(-25));   //Mutlak değer alır. Negatif değeri pozitif yapar.
            Console.WriteLine(Math.Sin(10));    //Sinüs alma işlemi
            Console.WriteLine(Math.Cos(10));    //Cosinüs alma işlemi
            Console.WriteLine(Math.Tan(5));     //Tanjant hesaplama

            Console.WriteLine(Math.Ceiling(10.5));   //11 //yukarıya yuvarlar, küsüratlı sayıdan sonra gelen en büyük tam sayıyı getirir.
            Console.WriteLine(Math.Round(7.2));      //7
            Console.WriteLine(Math.Round(7.7));     //8 //küsüratlı sayılarda hangi tam sayıya daha yakınsa onu getirir.
            Console.WriteLine(Math.Floor(10.7));    //10 //Aşağıya yuvarlar, küsüratlı sayıdan küçük en büyük tam sayıya yuvarlar.

            Console.WriteLine(Math.Max(2, 7));   //7 Max olanı getirir
            Console.WriteLine(Math.Min(2, 7));   //2 Min olanı getirir

            Console.WriteLine(Math.Pow(3, 4));   //3^4=81 //Üs alma işlemidir.
            Console.WriteLine(Math.Sqrt(9));    //3  //Karekök işlemidir.
            Console.WriteLine(Math.Log(9));     //9 un e tabanında ki logaritmik karşılığıdır.
            Console.WriteLine(Math.Exp(3));     //e^3 //e üzeri 3tür.
            Console.WriteLine(Math.Log10(19));  //19 un logaritma 10 tabanındaki karşılığıdır.
        }
    }
}