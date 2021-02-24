using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Göksal TAK";
            kurs1.IzlenmeOrani = 61;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hakan Şeker";
            kurs2.IzlenmeOrani = 34;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Erman AKTÜRK";
            kurs3.IzlenmeOrani = 01;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Gökhan Bağcı";
            kurs4.IzlenmeOrani = 81;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " %" + kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" :" + kurs.Egitmen + " " + kurs.IzlenmeOrani +"%");
                //Console.WriteLine(kurs.Egitmen);
                //Console.WriteLine(kurs.IzlenmeOrani);
            }

            Urunler urun1 = new Urunler();
            urun1.UrunKodu = "869101";
            urun1.UrunAdi = "Urun1";
            urun1.UrunFiyati = 89.90;

            Urunler urun2 = new Urunler();
            urun2.UrunKodu = "869102";
            urun2.UrunAdi = "Urun2";
            urun2.UrunFiyati = 79.90;

            Urunler urun3 = new Urunler();
            urun3.UrunKodu = "869103";
            urun3.UrunAdi = "Urun3";
            urun3.UrunFiyati = 69.90;

            Urunler urun4 = new Urunler();
            urun4.UrunKodu = "869104";
            urun4.UrunAdi = "Urun4";
            urun4.UrunFiyati = 99.90;

            Urunler urun5 = new Urunler();
            urun5.UrunKodu = "869105";
            urun5.UrunAdi = "Urun4";
            urun5.UrunFiyati = 109.90;

            Urunler[] urunler = new Urunler[] { urun1, urun2, urun3, urun4,urun5 };

            Console.WriteLine("For İle");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunKodu + " " + urunler[i].UrunAdi + " " + urunler[i].UrunFiyati + "%");
            }

            Console.WriteLine("While İle");

            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunKodu + " " + urunler[j].UrunAdi + " " + urunler[j].UrunFiyati + "%");
                j++;

            }

            Console.WriteLine("foreach İle");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunKodu +" " +urun.UrunAdi+" "+ urun.UrunFiyati+"%");
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

    class Urunler
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }

    }
}
