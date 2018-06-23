using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    /// <summary>
    /// Class represent trade object
    /// cntains trade details as:
    /// Trade price- offered transaction price
    /// Trade quantity-offered quantity
    /// </summary>
   public class Trade : ITrade
    {
        public float TradePrice  { get; set; }    
        public float TradeQuantity { get; set; }
        public float GetTradeCost() => TradePrice * TradeQuantity;
      
        public Trade(float tradePrice, float tradeQuantity)
        {
            TradePrice = tradePrice;
            TradeQuantity = tradeQuantity;
        }
    }
}
