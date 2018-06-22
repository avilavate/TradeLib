using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    class TradeValidator:IValidator
    {
        public ITrade Trade { get; }
        public ICommodity Comodity { get; }

        public TradeValidator(ITrade trade, ICommodity comodity)
        {
            Trade = trade;
            Comodity = comodity;
        }

        public bool IsValid() => true;
        //Comodity.GetCost() <= Trade.GetTradeCost();
    }
}
