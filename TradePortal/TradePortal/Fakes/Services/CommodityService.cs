using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Fakes.Services
{
    public static class CommodityService
    {
        public static ICommodity CommodityBalance { get; set; } = new GoldCommodity(3200,100);  
    }
}
