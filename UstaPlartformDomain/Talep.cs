using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class Talep
    {
        public int Id { get; set; }
        public string Acıklama { get; set; }
        public string Adres { get; set; }
        public string VatandasId { get; set; }

        //TalepZamani (init-only property)
        public DateTime TalepZamani { get; init; } = DateTime.Now;
    }
}
