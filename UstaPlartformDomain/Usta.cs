using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class Usta
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string UzmanlıkAlanı { get; set; }
        public int Puan { get; set; }
        public string Durum { get; set; }

        public void IsAl()
        {
            Durum = "Meşgul";
        }
        public void IsBitir()
        {
            Durum = "Boşta";
        }
        //public Usta(int a, string b, string c, int d,string e)
        //{
        //    a = Id;
        //    b = AdSoyad;
        //    c = UzmanlıkAlanı;
        //    d = Puan;
        //    e = Durum;

        //}
    }
}
