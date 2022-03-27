using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Central_Kata
{
    public class Checkout
    {
        public decimal Total { get; set; }

        private Dictionary<string, int> itemScanCountDictionary;

        public Checkout()
        {
            Total = 0;
            itemScanCountDictionary = new Dictionary<string, int>();
        }

        public void Scan(Item item)
        {
            if(itemScanCountDictionary.ContainsKey(item.ID))
            {
                itemScanCountDictionary[item.ID]++;
            }
            else
            {
                itemScanCountDictionary.Add(item.ID, 1);
            }

            if(item.OfferQuant > 0 && itemScanCountDictionary[item.ID] == item.OfferQuant)
            {
                decimal discount = (item.Price * item.OfferQuant) - item.OfferPrice;

                Total -= discount;

                itemScanCountDictionary[item.ID] = 0;
            }

            Total += item.Price;
        }
    }
}
