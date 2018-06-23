using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    //Interface to define tax on any commodity based transaction
    interface ITax
    {
        float TaxRate { get; }
    }
}
