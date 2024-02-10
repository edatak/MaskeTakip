// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

//Console.WriteLine("Hello, World!");

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            //Değişkenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim: "Eda");
            SelamVer();

            int sonuc = Topla(3,5);
            

            //Diziler/Arrays

            string ogrenci1 = "Aslı";
            string ogrenci2 = "Elif";
            string ogrenci3 = "Mete";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Aslı";
            ogrenciler[1] = "Elif";
            ogrenciler[2] = "Mete";

            ogrenciler = new string[4];
            ogrenciler[3] = "Alperen";

            for (int i = 0; i < ogrenciler.Length; i++) 
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //reference types : array, interface, class, abstract
            //value types : int, double, bool
            //string aslında reference tip ama çalışma şekli value tip gibidir.

            /*
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            */

            Person person1 = new Person();
            person1.FirstName = "Eda";
            person1.LastName = "Atak";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Cemre";

            foreach (string s in sehirler1) 
            {
                Console.WriteLine(s);
            }

            List<string> yeniSehirler1 = new List<string> {"Ankara 1", "İstanbul 1", "İzmir 1"};
            yeniSehirler1.Add(item: "Adana 1");
            foreach(var s in yeniSehirler1) 
            { 
                Console.WriteLine(s); 
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        //resharper
        static void SelamVer(string isim = "İsimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }
}


//    string ad = "Eda";
//    string soyad = "Atak";
//    int dogumYili = 1994;
//    long tcNo = 12345678910;

//    Console.WriteLine(mesaj);

//    Console.WriteLine(tutar * 1.18);
//}

//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }

//}//private static void Değişkenler()
//{
//    string mesaj = "Merhaba";
//    double tutar = 100000;
//    int sayi = 100;
//    bool girisYapmisMi = false;

//    string ad = "Eda";
//    string soyad = "Atak";
//    int dogumYili = 1994;
//    long tcNo = 12345678910;

//    Console.WriteLine(mesaj);

//    Console.WriteLine(tutar * 1.18);
//}

//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }

//}