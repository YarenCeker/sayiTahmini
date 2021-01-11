using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            while (true)
            {

                while (true)
                {
                    Console.WriteLine("Tahmininizi girin = ");
                    int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                    if (uretilenSayi > tahminEdilenSayi)
                    {
                        Console.WriteLine("Yukarı!");
                    }
                    else if (uretilenSayi < tahminEdilenSayi)
                    {
                        Console.WriteLine("Aşağı!");
                    }
                    else
                    {
                        Console.WriteLine("Eşittir");
                        break;

                    }
                    Console.WriteLine("Devam etmek ister misin? (Evet/Hayır)");
                    string cevap = Console.ReadLine();
                    if (cevap == "evet")
                    {
                        Console.Clear();
                        uretilenSayi = rastgeleSayiUretici.Next(1, 100);
                    }
                    else
                    {
                        Console.WriteLine("Tekrar Gelinn!");
                        break;
                    }

                }
            }


        }
