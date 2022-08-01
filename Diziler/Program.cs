//Dizi tanımlama
string[] renkler = new string[5];   //5 elemanlı string tipinde bir dizi tanımladık.

string[] hayvanlar = { "Kedi", "Köpek", "kuş", "Fil" };  //4 elemanlı ve elemanları belli olan bir dizi tanımladık.

int[] dizi;             //Önce diziyi tanımladık sonra eleman sayısını belirledik. Elemanları sonradan da belirleyebiliyoruz.
dizi = new int[5];

//Dizilerde değer atama ve erişim
renkler[0] = "Mavi";    //renkler dizisinin 1. elemanı Mavi oldu

dizi[3] = 10;       //dizi dizisinin 4. elemanı 10 oldu.

Console.WriteLine(dizi[3]);
Console.WriteLine(hayvanlar[1]);    //hayvanlar dizisinin 2. elemanını çağırdık.
Console.WriteLine(renkler[0]);

// *****  Döngülerle dizi kullanımı  *****

//klavyeden girilen n tane sayının ortalamasını hesaplayan program:

Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunluğu = int.Parse(Console.ReadLine());   //dizi uzunluğunu bu değer ile alırız.
int[] sayiDizisi = new int[diziUzunluğu];       //ekrana girilen sayı kadar eleman içeren bir dizi tanımladık

for (int i = 0; i < diziUzunluğu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);      //elemanları bu kod ile alıyoruz.
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0; //toplam değerini yapacağımız bir değer tanımladık.
foreach (var sayi in sayiDizisi)
{
    toplam += sayi;
}

Console.WriteLine("Ortalama: " + toplam / diziUzunluğu);