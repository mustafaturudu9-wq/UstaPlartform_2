using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UstaPlartform.Domain;

namespace UstaPlartform.Pricing
{
    public class HaftaSonuEkÜcretKuralı : IPricingRule
    {
        public decimal applyPricingRule(decimal basePrice)
        {
            DayOfWeek today = DateTime.Now.DayOfWeek;
            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                return basePrice +20; // Hafta sonu 20 tl ek ücret
            }
            return basePrice;
        }
    }
}
