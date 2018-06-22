using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    /// <summary>
    /// Takes the trade (uncommited transaction) and validates it 
    /// based on minimum and maximum transaction limit.
    /// </summary>
    class TradeValidator : IValidator
    {
        private const float MinTransactionLimit = 1F;
        private const float MaxTransactionLimit = 20000F;
        public ITrade Trade { get; }
        public ICommodity Comodity { get; } = null;

        public TradeValidator(ITrade trade) => Trade = trade;

        public bool IsValid() => Trade.TradePrice<=MaxTransactionLimit && Trade.TradePrice>MinTransactionLimit;
    }
}
