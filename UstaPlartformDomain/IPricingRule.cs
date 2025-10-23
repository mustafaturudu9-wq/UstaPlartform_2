using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class IPricingRule
    {
        public decimal basePrice { get; set; }
        public decimal applyPricingRule(decimal basePrice)
        {
            // Fiyatlandırma kuralı uygulama işlemleri burada gerçekleştirilebilir
            return basePrice;
        }
        public IPricingRule()
        {
            applyPricingRule ( basePrice);
        }
    }
}
