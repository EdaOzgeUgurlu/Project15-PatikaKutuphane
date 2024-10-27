# Patika Kütüphane Projesi

## Proje Hakkında
Patika Kütüphane, kullanıcıların kitap bilgilerini yönetmelerine olanak tanıyan basit bir C# uygulamasıdır. Bu proje, kitap nesnelerinin oluşturulmasını, saklanmasını ve bu nesnelerin bilgilerini görüntülemeyi sağlar. Uygulama, nesne yönelimli programlamanın temel kavramlarını içermekte ve C# dilini kullanarak veri yönetimi konusunu öğretmeyi hedeflemektedir.

## İçindekiler
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kitap Sınıfı](#kitap-sınıfı)
- [Özellikler](#özellikler)
- [Yapıcı Metotlar (Constructors)](#yapıcı-metotlar-constructors)
- [Metotlar](#metotlar)
- [Örnek Kullanım](#örnek-kullanım)

## Kurulum
Projenin çalışabilmesi için aşağıdaki adımları izleyin:

1. **Gereksinimler**: Bilgisayarınızda [Visual Studio](https://visualstudio.microsoft.com/) veya [Rider](https://www.jetbrains.com/rider/) gibi bir IDE yüklü olmalıdır. Ayrıca .NET SDK'nın en son sürümünün yüklü olduğundan emin olun.

2. **Projeyi İndirin veya Klonlayın**:
   ```bash
   git clone https://github.com/kullaniciadi/patika-kutuphane.git
   ```

3. **Projeyi Açın**: İndirdiğiniz projeyi IDE'nizle açın.

4. **Projeyi Derleyin**: IDE'de projeyi derleyin. Herhangi bir hata almadığınızdan emin olun.

5. **Çalıştırın**: Projeyi çalıştırarak uygulamanın çalışıp çalışmadığını kontrol edin.

## Kullanım
Uygulama, kullanıcıların `Kitap` sınıfı üzerinden kitap bilgilerini oluşturmasına ve görüntülemesine olanak tanır. Her kitap için ad, yazar, sayfa sayısı, yayınevi ve kayıt tarihi gibi bilgileri saklayabilirsiniz. 

## Kitap Sınıfı
`Kitap` sınıfı, bir kitap nesnesinin özelliklerini ve davranışlarını tanımlar. Sınıfın yapısı aşağıdaki gibidir:

- **Alanlar**: Kitapla ilgili bilgileri tutan özel değişkenlerdir.
- **Özellikler**: Dışarıdan erişime ve değişime açık olan, sınıfın içindeki alanları temsil eden yapılardır.
- **Metotlar**: Kitap nesnesinin davranışlarını tanımlar.

### Alanlar
- `kitapAd`: Kitabın adı.
- `yazarAd`: Yazarın adı.
- `yazarSoyadi`: Yazarın soyadı.
- `sayfaSayisi`: Kitabın toplam sayfa sayısı.
- `yayinevi`: Kitabın yayımlandığı yayınevi.
- `tarih`: Kitabın kayıt tarihi (oluşturulma tarihi).

### Özellikler
`Kitap` sınıfında tanımlanan özellikler, aşağıdaki gibidir:
```csharp
public string KitabAd { get; set; }
public string YazarAd { get; set; }
public string YazarSoyadi { get; set; }
public int SayfaSayisi { get; set; }
public string Yayinevi { get; set; }
public DateTime Tarih { get; set; }
```

## Yapıcı Metotlar (Constructors)
`Kitap` sınıfı, nesne oluşturulurken başlangıç durumunu ayarlamak için iki tür yapıcı metot içerir:

1. **Parametreli Yapıcı Metot**: Kullanıcıdan kitapla ilgili bilgileri alır ve bu bilgileri sınıfın özelliklerine atar.
   ```csharp
   public Kitap(string kitapAd, string yazarAd, string yazarSoyadi, int sayfaSayisi, string yayinevi)
   ```

2. **Varsayılan Yapıcı Metot**: Parametre almaz ve `tarih` alanını mevcut tarih ile başlatır.
   ```csharp
   public Kitap()
   ```

## Metotlar
- **KitapBilgisi()**: Bu metot, kitapla ilgili tüm bilgileri konsola yazdırır.
  ```csharp
  public void KitapBilgisi()
  ```

## Örnek Kullanım
Aşağıda, `Kitap` sınıfını kullanarak bir kitap nesnesi oluşturma ve kitap bilgilerini görüntüleme örneği verilmiştir:

```csharp
Kitap kitap1 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitapevi");
kitap1.KitapBilgisi();
```



