
using Project15_PatikaKütüphane; // Projedeki Kitap sınıfını içe aktarıyoruz

internal class Program
{
    private static void Main(string[] args)
    {
        // Kitap nesnelerini oluşturuyoruz
        Kitap kitap1 = new Kitap(); // İlk kitap nesnesi
        Kitap kitap2 = new Kitap(); // İkinci kitap nesnesi
        Kitap kitap3 = new Kitap(); // Üçüncü kitap nesnesi

        // İlk kitabın bilgilerini ayarlıyoruz
        kitap1.kitapAd = "Adı Aylin";
        kitap1.yazarAd = "Ayşe";
        kitap1.yazarSoyadi = "Kulin";
        kitap1.sayfaSayisi = 398;
        kitap1.yayinevi = "Remzi Kitapevi";

        // İkinci kitabın bilgilerini ayarlıyoruz
        kitap2.kitapAd = "Ana";
        kitap2.yazarAd = "Maksim";
        kitap2.yazarSoyadi = "Gorki";
        kitap2.sayfaSayisi = 400;
        kitap2.yayinevi = "Can Kitabevi";

        // Üçüncü kitabın bilgilerini ayarlıyoruz
        kitap3.kitapAd = "Düşüş";
        kitap3.yazarAd = "Albert";
        kitap3.yazarSoyadi = "Camus";
        kitap3.sayfaSayisi = 350;
        kitap3.yayinevi = "Can Kitapevi";

        // Kitap bilgilerini konsola yazdırıyoruz
        kitap1.KitapBilgisi(); // İlk kitabın bilgilerini yazdır
        Console.WriteLine();
        kitap2.KitapBilgisi(); // İkinci kitabın bilgilerini yazdır
        Console.WriteLine();
        kitap3.KitapBilgisi(); // Üçüncü kitabın bilgilerini yazdır
        Console.WriteLine();
    }
}

// Class : Nesnenin yapısını ve işlevlerini tanımlayan bir şablondur. Kitap adında bir sınıf oluşturduk. Bu sınıf, kitap nesnelerini temsil eder ve kitapla ilgili özellikler (property) ile davranışları (metotlar) içerir.
//Özellikler (Property): sınıf içindeki verileri temsil eder. Kitap sınıfında, kitabın adı, yazarı, sayfa sayısı, yayınevi ve kayıt tarihi gibi bilgileri saklayan özellikler yer alır. Bu özellikler public durumda, dışarıdan erişime ve değişime açıktır.
//Yeni Nesne Oluşturma new anahtar kelimesi: sınıf içerisinde yeni bir nesne oluşturmak için kullanılır. Bu sayede sınıfın bir örneği (instance) yaratılır. Örneğin, kitap1, kitap2 ve kitap3 adında ayrı ayrı kitap nesnesi oluşturduk.
//Yapıcı Metot(Constructor) : yeni bir nesne oluşturulduğunda ilk olarak çalışan özel bir metottur. Bu metot, nesnenin başlangıç durumunu ayarlamak için kullanılır. Bu çalışmada biri parametre almayan (varsayılan yapıcı), diğeri ise parametre alarak bilgileri nesne oluşturulurken ilgili özelliklere atayan yapıcı olmak üzere iki yapıcı metot oluşturduk.


