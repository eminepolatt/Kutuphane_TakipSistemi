using System;
using System.Collections.Generic;

namespace Kutuphane_Takip_Sistemi
{
    public class Uye : IOduncAlabilir
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public List<Odunc> OduncListesi { get; set; }

        public Uye(int id, string adSoyad, string telefon)
        {
            Id = id;
            AdSoyad = adSoyad;
            Telefon = telefon;
            OduncListesi = new List<Odunc>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (!kitap.OduncVerildiMi)
            {
                kitap.OduncVerildiMi = true;
                OduncListesi.Add(new Odunc(kitap));
                Console.WriteLine($" {kitap.Ad} adlı kitap {AdSoyad} adlı üyeye ödünç verildi.");
            }
            else
            {
                Console.WriteLine("❗ Kitap zaten ödünç verilmiş.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            var odunc = OduncListesi.Find(o => o.Kitap == kitap && o.IadeTarihi == null);
            if (odunc != null)
            {
                kitap.OduncVerildiMi = false;
                odunc.IadeTarihi = DateTime.Now;
                Console.WriteLine($" {kitap.Ad} adlı kitap {AdSoyad} tarafından iade edildi.");
            }
            else
            {
                Console.WriteLine("❗ Bu kitap bu üyede görünmüyor.");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id} - {AdSoyad} ({Telefon}) - Ödünç Sayısı: {OduncListesi.Count}";
        }
    }
}
