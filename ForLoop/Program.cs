//Döngüleri belirli kod bloklarının, belirli şartlar altında, şartlara bağlı kalarak birden fazla kez çalışmasını istiyorsak "for" ile kullanırız.

//ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
Console.Write("Lütfen bir sayı giriniz: ");
int sayac = int.Parse(Console.ReadLine());  //Parse ile ReadLine string bir değer okuduğu halde bu yöntem ile int değerleri okumasını da sağladık.
for (int i = 0; i < sayac; i++)
{
    //komut satırları burada çalışır.
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}

//1-1000 arasında ki tek ve çift sayıların kendi içlerinde ki toplamlarını ekrana yazdıracağız.
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1) //tek sayılar
    {
        tekToplam += i; //tekToplam = tektoplam + i demek.
    }
    else
    {
        ciftToplam += i;    //ciftToplam = ciftToplam + i demek.
    }
    Console.WriteLine("Tek Toplam: " + tekToplam);
    Console.WriteLine("Çift Toplam: " + ciftToplam);
}

// break, döngüyü sonlandırmak için kullanılır, continue

for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        break;
        Console.WriteLine(i);
    }
}
//break geçerli olduğu loop'u sonlandırır.
//Continue ile sadece 4'ü atladı.
for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        continue;
        Console.WriteLine(i);
    }
}