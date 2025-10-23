using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlatform.Infrastructure
{
    public class MoneyFormatter
    {
        
        public static string moneyFormat(decimal fiyat)
        {
           return fiyat.ToString("100");
        }
    }
}
