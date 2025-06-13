using System;

namespace Kutuphane_Takip_Sistemi
{
    public class Odunc
    {
        public Kitap Kitap { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }

        public Odunc(Kitap kitap)
        {
            Kitap = kitap;
            OduncTarihi = DateTime.Now;
            IadeTarihi = null;
        }

        public bool GeciktiMi()
        {
            return IadeTarihi == null && (DateTime.Now - OduncTarihi).Days > 15;
        }

        public override string ToString()
        {
            string durum = IadeTarihi == null ? "Teslim edilmedi" : $"İade Tarihi: {IadeTarihi.Value.ToShortDateString()}";
            return $"📚 {Kitap.Ad} - Ödünç: {OduncTarihi.ToShortDateString()} - {durum}";
        }
    }
}
