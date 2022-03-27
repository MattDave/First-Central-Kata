using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Central_Kata
{
    public class Item
    {
        public string ID { get; }
        public decimal Price { get; }
        public int OfferQuant { get; }
        public decimal OfferPrice { get; }

        public Item(string id, decimal price, int offerQuant, decimal offerPrice)
        {
            ID = id;
            Price = price;
            OfferQuant = offerQuant;
            OfferPrice = offerPrice;
        }
    }
}
