using System;

namespace Kutuphane_Takip_Sistemi
{
    public class DersKitabi : Kitap
    {
        public string DersAdi { get; set; }

        public DersKitabi(int id, string ad, string yazar, string tur, string dersAdi)
            : base(id, ad, yazar, tur)
        {
            DersAdi = dersAdi;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Ders: {DersAdi}";
        }
    }
}
