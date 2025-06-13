namespace Kutuphane_Takip_Sistemi
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public bool OduncVerildiMi { get; set; }

        public Kitap(int id, string ad, string yazar, string tur)
        {
            Id = id;
            Ad = ad;
            Yazar = yazar;
            Tur = tur;
            OduncVerildiMi = false;
        }

        public override string ToString()
        {
            return $"ID: {Id} - {Ad} ({Yazar}) - Tür: {Tur} - {(OduncVerildiMi ? "📕 Ödünçte" : "📗 Rafta")}";
        }
    }
}
