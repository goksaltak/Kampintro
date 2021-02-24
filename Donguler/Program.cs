using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java",
                "Unity İle Mobil Programlama",
                "C# Öğreniyorum",
                "Sql - Tsql Öğreniyorum",
                "Python",
                "MVC Programming",
                "Pascal",
                "Delphi"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("Kurs "+i +" : " + kurslar[i]);
            }
            Console.WriteLine("------For Bitti----------");
            Console.WriteLine("Sayfa Sonu -- footer");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("------Foreach Bitti--------");
            Console.WriteLine("Sayfa Sonu -- footer");
        }
    }
}
