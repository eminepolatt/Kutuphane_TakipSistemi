# 📚 Kütüphane Takip Sistemi

Bu proje, öğrencilerin kitap ödünç alıp iade edebildiği, kütüphane personelinin kitap ve üye takibi yapabildiği **Windows Forms** tabanlı bir sistemdir. Görsel arayüz destekli olup **Object Oriented Programming (OOP)** ilkelerine uygun şekilde geliştirilmiştir.

---

## 🚀 Özellikler

- 📖 **Kitap Ekleme** (Roman veya Ders Kitabı ayrımı)
- 📃 **Kitap Listeleme**
- 👤 **Üye Ekleme ve Listeleme**
- 🔁 **Kitap Ödünç Verme ve İade Alma**
- ⏰ **Geciken Kitapları Gösterme**
- 💾 **Verileri JSON olarak Kaydetme/Yükleme**

---
!

## 🖼️ Ekran Görüntüleri

### 📥 Kitap Ekleme ve Listeleme
![Ekran görüntüsü 2025-06-13 033908](https://github.com/user-attachments/assets/2ad272e2-ad0a-416b-8741-1364f6075090)

### 👤 Üye Ekleme ve Listeleme
![Ekran görüntüsü 2025-06-13 033824](https://github.com/user-attachments/assets/d31da8f1-2ce2-46df-bed0-2524553cf56c)

### 🔄 Ödünç-İade ve Gecikenler
![Ekran görüntüsü 2025-06-13 033919](https://github.com/user-attachments/assets/e71e8379-1cb3-41ae-86f9-4a04f20a833e)

---

## 🧠 Kullanılan OOP Kavramları

| OOP Prensibi       | Kullanımı                            |
|--------------------|---------------------------------------|
| Sınıf ve Nesne     | `Kitap`, `Uye`, `Kutuphane` sınıfları |
| Kalıtım (Inheritance) | `DersKitabi : Kitap`, `Roman : Kitap` |
| Kapsülleme (Encapsulation) | Özelliklerin `get` / `set` erişimleri   |
| Arayüz (Interface) | `IOduncAlabilir`                     |

---

## 🔧 Kurulum

1. **Visual Studio (.NET Framework)** ile açın.
2. Giriş noktası: `Program.cs` dosyasında `Form1` otomatik olarak başlar.
3. Arayüzde butonlar ile tüm işlemleri yapabilirsiniz.

> 📁 JSON dosyaları (`kitaplar.json`, `uyeler.json`) projenin dizininde oluşturulur.

---

## 🛠️ Proje Yapısı

- `Form1.cs`: Uygulamanın görsel arayüzü ve olay işleyicileri
- `Kutuphane.cs`: Kitap ve üye işlemlerinin tamamı burada toplanır
- `Uye.cs`, `Kitap.cs`: Veri modelleri
- `Program.cs`: Uygulamanın başlangıç noktası

---

## 🧪 Test Durumu

✅ Kitap ekleme, listeleme, ödünç işlemleri test edildi.  
✅ Üye ekleme, listeleme ve JSON dosyalarıyla veri saklama çalışıyor.  
✅ Geciken kitap kontrolü başarıyla gösteriliyor.

---

## 👨‍💻 Katkıda Bulunma

Katkıda bulunmak isterseniz:
1. Fork'layın 🔱
2. Değişiklik yapın 🛠️
3. Pull Request gönderin 📩

---

## © Geliştirici

Bu proje, ders kapsamında bireysel olarak geliştirilmiştir.  
Her türlü öneri ve katkıya açıktır. 🙌
