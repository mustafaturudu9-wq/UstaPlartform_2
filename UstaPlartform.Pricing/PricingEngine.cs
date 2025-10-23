using System;
using System.Collections.Generic;
using System.IO;            
using System.Reflection;    
using System.Linq;
using UstaPlartform.Domain; 

namespace UstaPlartform.Pricing
{
    public class PricingEngine
    {
        private List<IPricingRule> pricingRules = new();

        public void AddRule(IPricingRule rule)
        {
            pricingRules.Add(rule);
        }
        //plug in sistemi için eklenti yükleme metodu
        public void LoadPlugins(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Eklenti klasörü bulunamadı: " + folderPath);
                return;
            }

            var dllFiles = Directory.GetFiles(folderPath, "*.dll");

            foreach (var dll in dllFiles)
            {
                try
                {
                    var assembly = Assembly.LoadFrom(dll);
                    var types = assembly.GetTypes()
                        .Where(t => typeof(IPricingRule).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                    foreach (var type in types)
                    {
                        if (Activator.CreateInstance(type) is IPricingRule rule)
                        {
                            pricingRules.Add(rule);
                            Console.WriteLine($"Eklenti yüklendi: {type.Name}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Eklenti yüklenirken hata: {ex.Message}");
                }
            }
        }

        public decimal Hesapla(decimal basePrice)
        {
            decimal finalPrice = basePrice;

            foreach (var rule in pricingRules)
            {
                finalPrice = rule.applyPricingRule(finalPrice);
            }

            return finalPrice;
        }
    }
}