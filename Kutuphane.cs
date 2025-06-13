using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kutuphane_Takip_Sistemi
{
    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private List<Uye> uyeler = new List<Uye>();
        private int kitapIdSayac = 1;
        private int uyeIdSayac = 1;

        public void KitapEkle(string ad, string yazar, string tur, string yayinEvi = null, string dersAdi = null)
        {
            Kitap yeniKitap;

            if (!string.IsNullOrWhiteSpace(yayinEvi))
            {
                yeniKitap = new Roman(kitapIdSayac++, ad, yazar, tur, yayinEvi);
            }
            else if (!string.IsNullOrWhiteSpace(dersAdi))
            {
                yeniKitap = new DersKitabi(kitapIdSayac++, ad, yazar, tur, dersAdi);
            }
            else
            {
                throw new ArgumentException("Geçerli kitap türü belirtilmeli (yayınevi veya ders adı).");
            }

            kitaplar.Add(yeniKitap);
        }

        public string KitapListele()
        {
            if (kitaplar.Count == 0)
                return "Kütüphanede hiç kitap yok.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("📚 Kitap Listesi:");
            foreach (var kitap in kitaplar)
            {
                sb.AppendLine(kitap.ToString());
            }
            return sb.ToString();
        }


        public void UyeEkle(string adSoyad, string telefon)
        {
            Uye yeniUye = new Uye(uyeIdSayac++, adSoyad, telefon);
            uyeler.Add(yeniUye);
        }

        public string UyeListele()
        {
            if (uyeler.Count == 0)
                return "Hiç üye kaydı yok.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("👤 Üye Listesi:");
            foreach (var uye in uyeler)
            {
                sb.AppendLine(uye.ToString());
            }
            return sb.ToString();
        }


        public void KitapOduncVer(int kitapId, int uyeId)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);
            var uye = uyeler.FirstOrDefault(u => u.Id == uyeId);

            if (kitap == null || uye == null)
                throw new ArgumentException("Kitap veya üye bulunamadı.");

            if (kitap.OduncVerildiMi)
                throw new InvalidOperationException("Bu kitap zaten ödünç verilmiş.");

            uye.KitapOduncAl(kitap);
        }

        public void KitapIadeEt(int kitapId)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);
            if (kitap == null)
                throw new ArgumentException("Kitap bulunamadı.");

            var uye = uyeler.FirstOrDefault(u => u.OduncListesi.Any(o => o.Kitap.Id == kitapId && o.IadeTarihi == null));
            if (uye == null)
                throw new ArgumentException("Bu kitap iade edilecek şekilde kayıtlı değil.");

            uye.KitapIadeEt(kitap);
        }

        public List<(string uyeAd, Odunc odunc)> GecikenKitaplariGetir()
        {
            var liste = new List<(string, Odunc)>();
            foreach (var uye in uyeler)
            {
                foreach (var odunc in uye.OduncListesi)
                {
                    if (odunc.GeciktiMi())
                        liste.Add((uye.AdSoyad, odunc));
                }
            }
            return liste;
        }

        public void VerileriKaydet()
        {
            File.WriteAllText("kitaplar.json", JsonConvert.SerializeObject(kitaplar, Formatting.Indented));
            File.WriteAllText("uyeler.json", JsonConvert.SerializeObject(uyeler, Formatting.Indented));
        }

        public void VerileriYukle()
        {
            if (File.Exists("kitaplar.json"))
            {
                kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(File.ReadAllText("kitaplar.json"));
                if (kitaplar.Count > 0)
                    kitapIdSayac = kitaplar.Max(k => k.Id) + 1;
            }

            if (File.Exists("uyeler.json"))
            {
                uyeler = JsonConvert.DeserializeObject<List<Uye>>(File.ReadAllText("uyeler.json"));
                if (uyeler.Count > 0)
                    uyeIdSayac = uyeler.Max(u => u.Id) + 1;
            }
        }
        public string GecikenKitaplariListele()
        {
            StringBuilder sb = new StringBuilder();
            bool varMi = false;

            foreach (var uye in uyeler)
            {
                foreach (var odunc in uye.OduncListesi)
                {
                    if (odunc.GeciktiMi())
                    {
                        sb.AppendLine($"Üye: {uye.AdSoyad} → {odunc}");
                        varMi = true;
                    }
                }
            }

            if (!varMi)
                return "Tüm kitaplar zamanında iade edilmiş. ";

            return sb.ToString();
        }

    }
}

