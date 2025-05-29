using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Takip_Sistemi
{
    public class Kutuphane
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        private List<Uye> uyeler = new List<Uye>();
        private int kitapIdSayac = 1;
        private int uyeIdSayac = 1;

        public void KitapEkle()
        {
            Console.Write("Kitap Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Yazar: ");
            string yazar = Console.ReadLine();

            Console.Write("Tür: ");
            string tur = Console.ReadLine();

            Kitap yeniKitap = new Kitap(kitapIdSayac++, ad, yazar, tur);
            kitaplar.Add(yeniKitap);

            Console.WriteLine("Kitap başarıyla eklendi!");
        }

        public void KitapListele()
        {
            if (kitaplar.Count == 0)
            {
                Console.WriteLine(" Kütüphanede hiç kitap yok.");
                return;
            }

            Console.WriteLine("\n Kitap Listesi:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

        public void UyeEkle()
        {
            Console.Write("Üye Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();

            Uye yeniUye = new Uye(uyeIdSayac++, adSoyad, telefon);
            uyeler.Add(yeniUye);

            Console.WriteLine("✅ Üye başarıyla eklendi!");
        }

        public void UyeListele()
        {
            if (uyeler.Count == 0)
            {
                Console.WriteLine("👥 Hiç üye kaydı yok.");
                return;
            }

            Console.WriteLine("\n👤 Üye Listesi:");
            foreach (var uye in uyeler)
            {
                Console.WriteLine(uye);
            }
        }

        public void KitapOduncVer()
        {
            KitapListele();
            Console.Write("\nÖdünç verilecek kitap ID: ");
            if (!int.TryParse(Console.ReadLine(), out int kitapId))
            {
                Console.WriteLine("Geçersiz kitap ID.");
                return;
            }

            Kitap secilenKitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);

            if (secilenKitap == null)
            {
                Console.WriteLine("❌ Kitap bulunamadı.");
                return;
            }

            if (secilenKitap.OduncVerildiMi)
            {
                Console.WriteLine("❗ Bu kitap zaten ödünç verilmiş.");
                return;
            }

            UyeListele();
            Console.Write("\nKitabı alacak üye ID: ");
            if (!int.TryParse(Console.ReadLine(), out int uyeId))
            {
                Console.WriteLine("Geçersiz üye ID.");
                return;
            }

            Uye secilenUye = uyeler.FirstOrDefault(u => u.Id == uyeId);

            if (secilenUye == null)
            {
                Console.WriteLine("❌ Üye bulunamadı.");
                return;
            }

            secilenKitap.OduncVerildiMi = true;
            secilenUye.OduncKitaplar.Add(secilenKitap);

            Console.WriteLine($"✅ {secilenKitap.Ad} kitabı {secilenUye.AdSoyad} adlı üyeye ödünç verildi.");
        }

        public void KitapIadeEt()
        {
            KitapListele();
            Console.Write("\nİade edilecek kitap ID: ");
            if (!int.TryParse(Console.ReadLine(), out int kitapId))
            {
                Console.WriteLine("Geçersiz kitap ID.");
                return;
            }

            Kitap secilenKitap = kitaplar.FirstOrDefault(k => k.Id == kitapId);

            if (secilenKitap == null)
            {
                Console.WriteLine("❌ Kitap bulunamadı.");
                return;
            }

            if (!secilenKitap.OduncVerildiMi)
            {
                Console.WriteLine("❗ Bu kitap zaten rafta.");
                return;
            }

            // Kitabı ödünç almış üyeyi bul ve listeden çıkar
            Uye alanUye = uyeler.FirstOrDefault(u => u.OduncKitaplar.Contains(secilenKitap));
            if (alanUye != null)
            {
                alanUye.OduncKitaplar.Remove(secilenKitap);
            }

            secilenKitap.OduncVerildiMi = false;
            Console.WriteLine($"✅ {secilenKitap.Ad} kitabı iade edildi.");
        }
    
    public void VeriEkle()
        {
            // 10 Üye
            uyeler.Add(new Uye(uyeIdSayac++, "Ahmet Yılmaz", "0555 111 2233"));
            uyeler.Add(new Uye(uyeIdSayac++, "Ayşe Demir", "0555 222 3344"));
            uyeler.Add(new Uye(uyeIdSayac++, "Mehmet Korkmaz", "0555 333 4455"));
            uyeler.Add(new Uye(uyeIdSayac++, "Elif Çelik", "0555 444 5566"));
            uyeler.Add(new Uye(uyeIdSayac++, "Zeynep Koç", "0555 555 6677"));
            uyeler.Add(new Uye(uyeIdSayac++, "Ali Kaya", "0555 666 7788"));
            uyeler.Add(new Uye(uyeIdSayac++, "Fatma Acar", "0555 777 8899"));
            uyeler.Add(new Uye(uyeIdSayac++, "Burak Yıldız", "0555 888 9900"));
            uyeler.Add(new Uye(uyeIdSayac++, "Merve Güneş", "0555 999 1010"));
            uyeler.Add(new Uye(uyeIdSayac++, "Emre Şahin", "0555 101 2020"));

            // 50 Kitap (örnek karışık yerli-yabancı kitaplar)
            kitaplar.Add(new Kitap(kitapIdSayac++, "Sefiller", "Victor Hugo", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Suç ve Ceza", "Fyodor Dostoyevski", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "İnce Memed", "Yaşar Kemal", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Kürk Mantolu Madonna", "Sabahattin Ali", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Tutunamayanlar", "Oğuz Atay", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "1984", "George Orwell", "Distopya"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Hayvan Çiftliği", "George Orwell", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Beyaz Zambaklar Ülkesinde", "Grigory Petrov", "Deneme"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Simyacı", "Paulo Coelho", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Bülbülü Öldürmek", "Harper Lee", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Don Kişot", "Miguel de Cervantes", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Savaş ve Barış", "Lev Tolstoy", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Karamazov Kardeşler", "Fyodor Dostoyevski", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Baba", "Mario Puzo", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Serenad", "Zülfü Livaneli", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Kırmızı Pazartesi", "Gabriel Garcia Marquez", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Yüzüklerin Efendisi", "J.R.R. Tolkien", "Fantastik"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Harry Potter ve Felsefe Taşı", "J.K. Rowling", "Fantastik"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Sonsuzluğun Sonu", "Isaac Asimov", "Bilim Kurgu"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Dune", "Frank Herbert", "Bilim Kurgu"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Bilinmeyen Bir Kadının Mektubu", "Stefan Zweig", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Küçük Prens", "Antoine de Saint-Exupéry", "Masal"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Martin Eden", "Jack London", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Aşk ve Gurur", "Jane Austen", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Çalıkuşu", "Reşat Nuri Güntekin", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Yabancı", "Albert Camus", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Anna Karenina", "Lev Tolstoy", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Uçurtma Avcısı", "Khaled Hosseini", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Fareler ve İnsanlar", "John Steinbeck", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Ben, Kirke", "Madeline Miller", "Fantastik"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Hayat 101", "Mümin Sekman", "Kişisel Gelişim"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Cesur Yeni Dünya", "Aldous Huxley", "Distopya"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Satranç", "Stefan Zweig", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Olasılıksız", "Adam Fawer", "Gerilim"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Körlük", "Jose Saramago", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Dönüşüm", "Franz Kafka", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Hayvan Mezarlığı", "Stephen King", "Korku"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Yüzyıllık Yalnızlık", "Gabriel Garcia Marquez", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Kayıp Sembol", "Dan Brown", "Gerilim"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Başlangıç", "Dan Brown", "Gerilim"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Babil Kitaplığı", "Jorge Luis Borges", "Deneme"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Göçebe", "Stephenie Meyer", "Bilim Kurgu"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Zamanın Kısa Tarihi", "Stephen Hawking", "Bilim"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Beyaz Diş", "Jack London", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Yeraltından Notlar", "Fyodor Dostoyevski", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Goriot Baba", "Honore de Balzac", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Oblomov", "İvan Gonçarov", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Sineklerin Tanrısı", "William Golding", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Dervişin Teselli Koleksiyonu", "Ali Şeriati", "Deneme"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "Bir İdam Mahkumunun Son Günü", "Victor Hugo", "Roman"));
            kitaplar.Add(new Kitap(kitapIdSayac++, "İnsan Neyle Yaşar?", "Lev Tolstoy", "Deneme"));
        }

    }
}
