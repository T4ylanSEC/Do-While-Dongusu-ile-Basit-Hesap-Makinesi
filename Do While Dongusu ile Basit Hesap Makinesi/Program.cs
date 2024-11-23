using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Dongusu_ile_Basit_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Write("Lütfen İşlem Türünü Giriniz (+, -, *, /) veya 'Çıkış' Yazınız: ");
                input = Console.ReadLine();

                if (input.ToLower() == "Çıkış")
                    break;

                Console.Write("Birinci Sayıyı Giriniz: ");
                if (!double.TryParse(Console.ReadLine(), out double sayi1))
                {
                    Console.WriteLine("Geçerli Bir Sayı Giriniz.");
                    continue;
                }

                Console.Write("İkinci Sayıyı Giriniz: ");
                if (!double.TryParse(Console.ReadLine(), out double sayi2))
                {
                    Console.WriteLine("Geçerli Bir Sayı Giriniz.");
                    continue;
                }

                double sonuc;

                switch (input)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;

                    case "-":
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;

                    case "*":
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;

                    case "/":
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Hata: Bir Sayı Sıfıra Bölünemez.");
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine($"Sonuç: {sonuc}");
                        }
                        break;

                    default:
                        Console.WriteLine("Geçerli Bir İşlem Türü Giriniz.");
                        break;
                }
            } while (true);

            Console.WriteLine("Program sonlandırıldı.");

            Console.ReadKey();

        }
    }
}
