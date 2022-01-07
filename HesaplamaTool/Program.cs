using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama_Cikarma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basit C# Dizin ve Sayı hesaplama Programı
            var i = 0;
            while (i == 0)
            {
                Console.WriteLine(">>> (1) Hesaplama Özelliklerini Görmek İçin");
                Console.WriteLine(">>> (2) Metin Özelliklerini Görmek İçin");
                byte sorgu = Convert.ToByte(Console.ReadLine());
                if (sorgu == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(">>> (1) Gireceğiniz sayılardan hangisinin daha büyük olduğunu öğren");
                    Console.WriteLine(">>> (2) Gireceğiniz sayılardan hangisinin daha küçük olduğunu öğren");
                    Console.WriteLine(">>> (3) Gireceğiniz sayının karekökünü döndürme");
                    Console.WriteLine(">>> (4) Gireceğiniz sayıları Toplama");
                    Console.WriteLine(">>> (5) Gireceğiniz sayıları çıkarma");
                    Console.WriteLine(">>> (6) Gireceğiniz sayıları çarpma");
                    Console.WriteLine(">>> (7) Gireceğiniz sayıları bölme");
                    byte sorgu4 = Convert.ToByte(Console.ReadLine());
                    if (sorgu4 == 1)
                    {
                        Console.WriteLine(">>> Hesaplamak istediğiniz ilk sayıyı girin lütfen");
                        long sorgu5 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine(">>> Hesaplamak istediğiniz ikinci sayıyı girin lütfen");
                        long sorgu6 = Convert.ToInt64(Console.ReadLine());
                        var sonuc = Math.Max(sorgu5, sorgu6);
                        if (sonuc == sorgu5)
                        {
                            Console.WriteLine(">>> İlk girdiğiniz sayı daha büyük");
                        }
                        else
                        {
                            Console.WriteLine(">>> İkinci girdiğiniz sayı daha büyük");
                        }
                    }
                    else if (sorgu4 == 2)
                    {
                        Console.WriteLine(">>> Hesaplamak istediğiniz ilk sayıyı girin lütfen");
                        long sorgu5 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine(">>> Hesaplamak istediğiniz ikinci sayıyı girin lütfen");
                        long sorgu6 = Convert.ToInt64(Console.ReadLine());
                        var sonuc = Math.Min(sorgu5, sorgu6);
                        if (sonuc == sorgu5)
                        {
                            Console.WriteLine(">>> İlk girdiğiniz sayı daha küçük");
                        }
                        else
                        {
                            Console.WriteLine(">>> İkinci girdiğiniz sayı daha küçük");
                        }
                    }
                    else if (sorgu4 == 3)
                    {
                        Console.WriteLine(">>> Karekökünü döndürmek istediğiniz sayıyı giriniz lütfen");
                        int sorgu5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Sonuç: " + Math.Sqrt(sorgu5));
                    }
                    else if (sorgu4 == 4)
                    {
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ilk sayıyı giriniz lütfen");
                        int sorgu5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ikinci sayıyı giriniz lütfen");
                        int sorgu6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Sonuç: " + (sorgu5 + sorgu6));
                    }
                    else if (sorgu4 == 5)
                    {
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ilk sayıyı giriniz lütfen");
                        int sorgu5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ikinci sayıyı giriniz lütfen");
                        int sorgu6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Sonuç: " + (sorgu5 - sorgu6));
                    }
                    else if (sorgu4 == 6)
                    {
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ilk sayıyı giriniz lütfen");
                        int sorgu5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ikinci sayıyı giriniz lütfen");
                        int sorgu6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Sonuç: " + (sorgu5 * sorgu6));
                    }
                    else if (sorgu4 == 7)
                    {
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ilk sayıyı giriniz lütfen");
                        int sorgu5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Hesap yapmak istediğiniz ikinci sayıyı giriniz lütfen");
                        int sorgu6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(">>> Sonuç: " + (sorgu5 / sorgu6));
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(">>> (1) Gireceğiniz yazının uzunluğunu öğren");
                    Console.WriteLine(">>> (2) Gireceğiniz yazıyı büyütme");
                    Console.WriteLine(">>> (3) Gireceğiniz yazıyı küçültme");
                    byte sorgu2 = Convert.ToByte(Console.ReadLine());
                    if (sorgu2 == 1)
                    {
                        Console.WriteLine(">>> Uzunluğunu öğrenmek istediğiniz metni girin lütfen");
                        string sorgu3 = Console.ReadLine();
                        Console.WriteLine(">>> Uzunluk: " + sorgu3.Length);
                    }
                    else if (sorgu2 == 2)
                    {
                        Console.WriteLine(">>> Büyütmek istediğiniz metni girin lütfen");
                        string sorgu3 = Console.ReadLine();
                        Console.WriteLine(">>> " + sorgu3.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(">>> Küçültmek istediğiniz metni girin lütfen");
                        string sorgu3 = Console.ReadLine();
                        Console.WriteLine(">>> " + sorgu3.ToLower());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
