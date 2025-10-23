using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class Vatandas
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        
        public void HizmetTalepEt()
        {
            // Hizmet talep etme işlemleri burada gerçekleştirilebilir
        }
    }
}
