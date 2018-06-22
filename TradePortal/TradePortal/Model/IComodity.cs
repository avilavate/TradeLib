using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TradePortal.Model
{
    public interface ICommodity
    {
        string Name { get; }
        float Quantity { get; set; }
        float Rate { get; }
        float GetCost();
    }
}
