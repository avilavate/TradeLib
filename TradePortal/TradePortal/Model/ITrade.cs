using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
   public interface ITrade
    {
        float TradePrice { get; set; }
        float TradeQuantity { get; set; }

        float GetTradeCost();
    }
}
