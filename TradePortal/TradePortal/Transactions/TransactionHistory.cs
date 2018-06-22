using System.Collections.Generic;
using TradePortal.Model;

namespace TradePortal.Transactions
{
    public class TransactionLedger
    {
        public ICollection<ICommodity> HistoryTransactions { get; set; }

        public TransactionLedger()
        {
            HistoryTransactions = new List<ICommodity>();
        }
    }
}
