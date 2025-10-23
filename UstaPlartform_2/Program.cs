using System;
using UstaPlartform.Domain;
using UstaPlartform.Pricing;
using UstaPlatform.Infrastructure;
namespace UstaPlartform_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usta Platforma Hoşgeldiniz!");
            // Usta oluşturma
            Usta usta2 = new Usta
            {
                Id = 2,
                AdSoyad = "Mehmet Usta",
                UzmanlıkAlanı = "Tesisat",
                Puan = 4,
                Durum = "Meşgul"
            };
            Usta usta = new Usta
            {
                Id = 1,
                AdSoyad = "Ahmet Usta",
                UzmanlıkAlanı = "Elektrik",
                Puan = 5,
                Durum = "Boşta"
            };
            Console.WriteLine($"Usta Bilgileri: {usta.AdSoyad}, Uzmanlık: {usta.UzmanlıkAlanı}, Puan: {usta.Puan}, Durum: {usta.Durum}");
            Console.WriteLine($"Usta2 Bilgileri: {usta2.AdSoyad}, Uzmanlık: {usta2.UzmanlıkAlanı}, Puan: {usta2.Puan}, Durum: {usta2.Durum}");
            // Vatandaş oluşturma
            Vatandas vatandas = new Vatandas { Id = 1, AdSoyad = "Mehmet Yılmaz", Adres = "İstanbul" };
            Console.WriteLine($"vatandas bilgileri: {vatandas.AdSoyad}, Adres: {vatandas.Adres}");
            //vatandaş hizmet talep etme
           
            var talep = "Elektrik Tesisatı Onarımı";
            vatandas.HizmetTalepEt();
            // İş emri oluşturma
            var isEmri = new IsEmri
            {
                Id = 1,
                Talep = talep,
                Usta = usta.AdSoyad,
                Fiyat = 500,
                Zamani = DateTime.Now
            };
            var engine = new PricingEngine();
            engine.AddRule(new HaftaSonuEkÜcretKuralı());
            // 4.2 Plug-in kurallarını yükle
            engine.LoadPlugins("PricingRules"); // DLL klasörünü burada arar

            // 5️⃣ Fiyat hesapla
            decimal basePrice = 100m;
            decimal finalPrice = engine.Hesapla(basePrice);
            isEmri.Fiyat = (int)finalPrice;

            Console.WriteLine($"Temel Fiyat: {MoneyFormatter.moneyFormat(basePrice)}");
            Console.WriteLine($"Son Fiyat (kurallar dahil): {MoneyFormatter.moneyFormat(finalPrice)}\n");

            // 6️⃣ İş emrini çizelgeye ekle
            var schedule = new Schedule();
            schedule.AddIsEmri(DateOnly.FromDateTime(DateTime.Now), isEmri);

            Console.WriteLine("Ustanın çizelgesine eklendi:");
            schedule.Listele(DateOnly.FromDateTime(DateTime.Now));

            Console.WriteLine("\n=== Test Senaryosu Tamamlandı ===");
        }
    }

}
    

