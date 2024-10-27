using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15_PatikaKütüphane
{
    internal class Kitap
    {
        // Gerekli alanları tanımlıyoruz.
        public string kitapAd;      // Kitap adı
        public string yazarAd;      // Yazar adı
        public string yazarSoyadi;  // Yazar soyadı
        public int sayfaSayisi;     // Sayfa sayısı
        public string yayinevi;     // Yayın evi
        public DateTime tarih;      // Kayıt tarihi

        // Gerekli alanların özelliklerini tanımlıyoruz.
        public string KitabAd // Kitap adını almak ve ayarlamak için özellik
        {
            get // Kitap adı değeri alınırken kullanılacak olan get
            {
                return kitapAd; // Değişkenin değerini döndür
            }
            set // Kitap adı değeri atanırken kullanılacak olan set
            {
                kitapAd = value; // Atanan değeri değişkene kaydet
            }
        }

        public string YazarAd 
        {
            get
            {
                return yazarAd; 
            }
            set
            {
                yazarAd = value; 
            }
        }

        public string YazarSoyadi 
        {
            get
            {
                return yazarSoyadi; 
            }
            set
            {
                yazarSoyadi = value; 
            }
        }

        public int SayfaSayisi 
        {
            get
            {
                return sayfaSayisi; 
            }
            set
            {
                sayfaSayisi = value;
            }
        }

        public string Yayinevi 
        {
            get
            {
                return yayinevi; 
            }
            set
            {
                yayinevi = value; 
            }
        }

        public DateTime Tarih 
        {
            get
            {
                return tarih; 
            }
            set
            {
                tarih = value; 
            }
        }

        // Parametreli constructor
        public Kitap(string kitapAd, string yazarAd, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            // Parametrelerden gelen değerleri alanlara atıyoruz
            this.kitapAd = kitapAd;
            this.yazarAd = yazarAd;
            this.yazarSoyadi = yazarSoyadi;
            this.sayfaSayisi = sayfaSayisi;
            this.yayinevi = yayinevi;
            this.tarih = DateTime.Now; // Kayıt tarihi olarak şu anki zamanı alıyoruz
        }

        // Varsayılan constructor
        public Kitap()
        {
            // Varsayılan oluşturucuda kayıt tarihi olarak şu anki zamanı alıyoruz
            Tarih = DateTime.Now;
        }

        // Kitap bilgilerini yazdıran metot
        public void KitapBilgisi()
        {
            // Kitap bilgilerini konsola yazdırıyoruz
            Console.WriteLine($"Kitap Adı: {kitapAd} \nYazar Adı-Soyadı: {yazarAd} {yazarSoyadi} \nSayfa Sayısı: {sayfaSayisi} \nYayın Evi: {yayinevi} ");
            Console.WriteLine($"Kayıt tarihi:  {tarih}");
        }
    }
}