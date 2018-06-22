using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;
using TradePortal.Transactions;

namespace TradePortal.Fakes
{
    public static class TransactionLedgerService
    {
        public static TransactionLedger MasterLedger = new TransactionLedger();
        static void AddTransaction(ICommodity tx)
        {
            MasterLedger.HistoryTransactions.Add(tx);
        }

        public static float GetAverageCost() => MasterLedger.HistoryTransactions.Average(tx => tx.Rate);
    }
}
