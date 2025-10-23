using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class IsEmri
    {
        public int Id { get; set; }
        
        public string Talep { get; set; }
        public string Usta { get; set; }
        public int Fiyat { get; set; }  
      
         //zaman
        public DateTime Zamani { get; set; }

        //fiyat hesapla metodu
        public void FiyatHesapla()
        {
            //Fiyat hesaplama işlemleri burada gerçekleştirilebilir
        }
        public IsEmri()
        {
            
        }
        public IsEmri(int id, string talep, string usta, int fiyat, DateTime zamani)
        {
            Id = id;
            Talep = talep;
            Usta = usta;
            Fiyat = fiyat;
            Zamani = zamani;
        }
        public override string ToString()
        {
            return $"İş Emri ID: {Id}, Talep: {Talep}, Usta: {Usta}, Fiyat: {Fiyat}, Zamanı: {Zamani}";
        }
    }
}
