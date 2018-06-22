using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    class ProfitValidator : IValidator
    {
        public ICommodity Comodity { get; }
        public ITrade Trade { get; }
        public IValidator TradeValidator { get; }


        public ProfitValidator(ICommodity comodity, ITrade trade)
        {
            Comodity = comodity;
            Trade = trade;
            TradeValidator = new TradeValidator(trade, comodity);
        }

        public bool IsValid() => TradeValidator.IsValid() && Trade.GetTradeCost() > Comodity.GetCost();

    }
}
