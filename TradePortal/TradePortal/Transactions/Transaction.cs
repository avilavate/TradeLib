using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TradePortal.Fakes;
using TradePortal.Fakes.Services;
using TradePortal.Model;
using TradePortal.Validators;

namespace TradePortal.Transactions
{
    /// <summary>
    /// A basic commodity trade transaction class supports buy sell and associated validations.
    /// </summary>
    public class Transaction : ITransaction
    {
        public ICommodity TxCommodity { get; set; }
        public ITrade TxTrade { get; set; }
        public IValidator TxProfitValidator { get; set; }
        public IValidator TxTradeValidator { get; set; }

        public Transaction(ICommodity commodity, ITrade trade)
        {
            TxCommodity = commodity;
            TxTrade = trade;

            TxProfitValidator = new ProfitValidator(TxCommodity, TxTrade);
            TxTradeValidator = new TradeValidator(TxTrade);
        }

        /// <summary>
        /// Buy commodity 
        /// Checks:
        /// if wallet has balance
        /// add tx in ledger
        /// </summary>
        public void Buy()
        {
            if (!TxTradeValidator.IsValid()) return;
            using (var myWallet = new GoldWallet(WalletService.FetchBalance(), new GoldTaxLoad()))
            {
                using (var ts = new TransactionScope())
                {
                    myWallet.Debit(TxTrade.GetTradeCost());
                    WalletService.WalletBalance = myWallet.GetBalance();
                    TxCommodity = new GoldCommodity(TxTrade.TradePrice, TxCommodity.Quantity + TxTrade.TradeQuantity);
                    TransactionLedgerService.MasterLedger.HistoryTransactions.Add(TxCommodity);
                }
            }
        }

        /// <summary>
        /// Sell commodoty method
        /// Checks:
        /// if trade is profatble
        /// credits the profit back in wallet
        /// </summary>
        /// <param name="sellingCommodity"></param>
        public void Sell(ICommodity sellingCommodity)
        {
            if (!TxProfitValidator.IsValid()) throw new Exception("The trade is not profitable");
            using (var myWallet = new GoldWallet(WalletService.FetchBalance(), new GoldTaxLoad()))
            {
                using (var ts = new TransactionScope())
                {
                    TxCommodity.Quantity -= TxTrade.TradeQuantity;
                    myWallet.Credit(TxTrade.GetTradeCost()-GoldTaxLoad.GoldBuyTransactionCharges);
                }
            }
        }
    }
}
