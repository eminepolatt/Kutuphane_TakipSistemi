using System;

namespace Kutuphane_Takip_Sistemi
{
    public class Roman : Kitap
    {
        public string YayinEvi { get; set; }

        public Roman(int id, string ad, string yazar, string tur, string yayinEvi)
            : base(id, ad, yazar, tur)
        {
            YayinEvi = yayinEvi;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Yayınevi: {YayinEvi}";
        }
    }
}
