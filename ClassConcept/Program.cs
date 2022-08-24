using System;

namespace ClassConcept
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Söz Dizimi
             * class SinifAdi
             * {
             *      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
             *      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
             *      {
             *      //Metot komutları
             *      }
             * }
             */

            /*Erişim Belirleyiciler
             * Public       :Her yerden erişilebilir
             * Private      :Sadece tanımlandığı sınıf içerisinde erişilebilir
             * Internal     :Sadece kendi bulunduğu proje içerisinde erişilebilir.
             * Protected    :Sadece tanımalndığı sınıf ve o sınıfı kalıtım alan sınıflarda erişilebilir.
             */

            Employee employee1 = new Employee(); //Çalışanların bir örneğini oluşturduk.
            employee1.EmployeeId = 15464898;
            employee1.Name = "Elif";
            employee1.Surname = "Kara";
            employee1.Department = "Muhasebe";

            Console.WriteLine("**********");

            Employee employee2 = new Employee();
            employee2.EmployeeId = 2236546;
            employee2.Name = "Deniz";
            employee2.Surname = "Arda";
            employee2.Department = "İnsan Kaynakları";

            employee1.EmployeeInfo();
            employee2.EmployeeInfo();
        }
    }

    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public void EmployeeInfo()
        {
            Console.WriteLine("Çalışan Numarası: {0}", EmployeeId);
            Console.WriteLine("Çalışan Adı: {0}", Name);
            Console.WriteLine("Çalışan Soyadı: {0}", Surname);
            Console.WriteLine("Çalışanın Departmanı: {0}", Department);
        }
    }
}