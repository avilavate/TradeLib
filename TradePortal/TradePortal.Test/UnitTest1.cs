using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradePortal;
using TradePortal.Fakes.Services;
using TradePortal.Model;
using TradePortal.Transactions;

namespace TradePortal.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Buy_Gold_Method()
        {

            var tx = new Transaction(CommodityService.CommodityBalance, new Trade(3000, 10));
            var walletBalanceBefore = WalletService.WalletBalance;
            tx.Buy();
            var walletBalanceAfter = WalletService.WalletBalance;
            //Test if wallet balance is debited?
            Assert.IsTrue(walletBalanceAfter <= walletBalanceBefore);

        }
        [TestMethod]
        public void Test_GST_Is_Applied()
        {
            var tx = new Transaction(CommodityService.CommodityBalance, new Trade(3000, 10));
            var walletBalanceBefore = WalletService.WalletBalance;
            tx.Buy();
            var walletBalanceAfter = WalletService.WalletBalance;
            Assert.IsTrue(walletBalanceBefore - walletBalanceAfter < 3000 * 10);

        }
        [TestMethod]

        public void Test_GST_Is_Correctly_Applied()
        {
            WalletService.ResetWallet();
            var tx = new Transaction(CommodityService.CommodityBalance, new Trade(3000, 10));
            var walletBalanceBefore = WalletService.WalletBalance;
            tx.Buy();
            var walletBalanceAfter = WalletService.WalletBalance;
            float GSTRate = 5.0F;
            Assert.IsTrue((walletBalanceBefore - walletBalanceAfter) == (3000 * 10) * (GSTRate / 100) + 3000 * 10);

        }

        [TestMethod]
        public void Check_Profit_Validator()
        {
            //Buy some gold
            WalletService.ResetWallet();
            var tx = new Transaction(CommodityService.CommodityBalance, new Trade(3000, 10));
            var walletBalanceBefore = WalletService.WalletBalance;
            tx.Buy();
            var walletBalanceAfter = WalletService.WalletBalance;
            var noProfitException = "The trade is not profitable";
            //try selling some gold at lower price
            try
            {
                tx.Sell(new GoldCommodity(5, 3000));
            }
            catch (Exception e)
            {
                Assert.IsNotNull(e);
                Assert.IsTrue(e.Message==noProfitException);
            }
           

        }
    }
}
