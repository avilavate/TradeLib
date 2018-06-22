using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    /// <summary>
    /// profit validator- validates a trade (an uncomited transaction) before its executed
    /// based on its profitability.
    /// </summary>
    class ProfitValidator : IValidator
    {
        public ICommodity Comodity { get; }
        public ITrade Trade { get; }
        public IValidator TradeValidator { get; }


        public ProfitValidator(ICommodity comodity, ITrade trade)
        {
            Comodity = comodity;
            Trade = trade;
            TradeValidator = new TradeValidator(trade);
        }

        public bool IsValid() => TradeValidator.IsValid() && Trade.GetTradeCost() > Comodity.GetCost();

    }
}
