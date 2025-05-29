using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Takip_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();

            kutuphane.VeriEkle();


            while (true)
            {
                Console.WriteLine("\n==== Kütüphane Takip Sistemi ====");
                Console.WriteLine("1 - Kitap Ekle");
                Console.WriteLine("2 - Kitapları Listele");
                Console.WriteLine("3 - Üye Ekle");
                Console.WriteLine("4 - Üyeleri Listele");
                Console.WriteLine("5 - Kitap Ödünç Ver");
                Console.WriteLine("6 - Kitap İade Et");
                Console.WriteLine("7 - Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1": kutuphane.KitapEkle(); break;
                    case "2": kutuphane.KitapListele(); break;
                    case "3": kutuphane.UyeEkle(); break;
                    case "4": kutuphane.UyeListele(); break;
                    case "5": kutuphane.KitapOduncVer(); break;
                    case "6": kutuphane.KitapIadeEt(); break;
                    case "7": return;
                    default: Console.WriteLine("Geçersiz seçim."); break;
                }
            }
        }
    }
}
