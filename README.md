16008124018 
Muhammet Mustafa Türüdü

USTAPLATFORM PROJESİ RAPORU 
Bu projede amaç, ustalar ve vatandaşlar arasında hizmet taleplerini yönetebilen, fiyat 
hesaplayabilen ve genişletilebilir bir sistem geliştirmekti. Projeyi çok katmanlı yapıda 
oluşturdum. Katmanlar sırasıyla Domain, Pricing, Infrastructure ve App olarak ayrıldı. Her 
katman kendi görevinden sorumlu olacak şekilde düzenlendi. 
İlk olarak Domain katmanında Usta, Vatandaş, Talep, İşEmri ve Çizelge (Schedule) sınıflarını 
yazdım. Ardından Pricing katmanında fiyatlandırma motorunu oluşturdum. Burada 
IPricingRule arayüzünü tanımlayıp farklı fiyat kurallarını ekleyebilmek için uygun yapı 
kurdum. 
Infrastructure katmanında yardımcı sınıflar yer aldı. Özellikle MoneyFormatter sınıfı ile 
fiyatların ekranda düzgün görünmesini sağladım. En üst katman olan App kısmında ise bütün 
bu sınıfları bir araya getirip çalışabilir bir senaryo hazırladım. 
Projenin en çok zorlandığım kısmı Plug-in oldu. Çünkü bu kısımda farklı projeden derlenen 
.dll dosyalarını uygulamaya dinamik olarak yüklemem gerekiyordu. Klasör yolu, namespace 
ve referans bağlantıları doğru yapılmazsa proje hata veriyordu. Birkaç denemeden sonra 
Assembly sınıfını kullanarak eklentileri başarıyla yüklemeyi başardım. Bu sayede program, 
yeni fiyat kurallarını kod değiştirmeden algılayabiliyor hale geldi. 
Sonuç olarak bu projeyi geliştirirken katmanlı mimariyi, SOLID prensiplerini ve 
genişletilebilir sistemlerin nasıl kurulduğunu daha iyi anladım. Özellikle Plug-in kısmı bana 
gerçek projelerde dikkat edilmesi gereken bağımlılık yönetimi konusunu öğretti.

