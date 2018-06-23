using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    /// <summary>
    /// Implements ICommodity interface
    /// represents gold commodity
    /// </summary>
    public class GoldCommodity:ICommodity
    {
        private const string ComodityName = "GoldCommodity";
        public string Name { get; } = ComodityName;
        public float Quantity { get; set; }
        public float Rate { get; }
        public GoldCommodity(float rate, float quantity)
        {
            Rate = rate;
            Quantity = quantity;
        }

        public float GetCost() => Rate * Quantity;
    }
}
