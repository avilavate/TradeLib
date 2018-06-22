using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
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
