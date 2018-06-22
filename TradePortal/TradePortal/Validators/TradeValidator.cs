using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    class TradeValidator : IValidator
    {
        private const float MinTransactionLimit = 1F;
        private const float MaxTransactionLimit = 20000F;
        public ITrade Trade { get; }
        public ICommodity Comodity { get; }

        public TradeValidator(ITrade trade, ICommodity comodity)
        {
            Trade = trade;
            Comodity = comodity;
        }

        public bool IsValid() => Trade.TradePrice<=MaxTransactionLimit && Trade.TradePrice>MinTransactionLimit;
    }
}
