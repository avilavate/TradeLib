using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TradePortal.Model
{
    /// <summary>
    /// represent any commodity
    /// for our example its gold
    /// </summary>
    public interface ICommodity
    {
        string Name { get; }
        float Quantity { get; set; }
        float Rate { get; }
        float GetCost();
    }
}
