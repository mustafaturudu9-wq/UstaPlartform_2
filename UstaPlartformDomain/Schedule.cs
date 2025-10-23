using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UstaPlartform.Domain
{
    public class Schedule
    {
        private Dictionary<DateOnly, List<IsEmri>> schedule=new Dictionary<DateOnly, List<IsEmri>>();
        public void AddIsEmri(DateOnly date, IsEmri isEmri)
        {
            if (!schedule.ContainsKey(date))
            {
                schedule[date] = new List<IsEmri>();
            }
            schedule[date].Add(isEmri);
        }
        public List<IsEmri> this[DateOnly date]
        {
            get
            {
                if (schedule.ContainsKey(date))
                    return schedule[date];
                else
                    return new List<IsEmri>(); // o güne ait iş yoksa boş liste döner
            }
        }
        public void Listele(DateOnly date)
        {
            if (schedule.ContainsKey(date))
            {
                Console.WriteLine($"{date} tarihli işler:");
                foreach (var isEmri in schedule[date])
                {
                    Console.WriteLine($"- {isEmri}");
                }
            }
            else
            {
                Console.WriteLine($"{date} tarihinde iş bulunmuyor.");
            }
        }
    }
}
