using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    /// <summary>
    /// Trade contract
    /// </summary>
   public interface ITrade
    {
        float TradePrice { get; set; }
        float TradeQuantity { get; set; }

        float GetTradeCost();
    }
}
