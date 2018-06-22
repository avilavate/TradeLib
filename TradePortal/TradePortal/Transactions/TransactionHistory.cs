using System.Collections.Generic;
using TradePortal.Model;

namespace TradePortal.Transactions
{
    /// <summary>
    /// Used to hold all past gold trades to calculate average gold ETF price
    ///  to evaluate gold/commodity sell trade profitability.
    /// </summary>
    public class TransactionLedger
    {
        public ICollection<ICommodity> HistoryTransactions { get; set; }
        public TransactionLedger() => HistoryTransactions = new List<ICommodity>();
    }
}
