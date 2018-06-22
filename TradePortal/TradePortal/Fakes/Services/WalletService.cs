using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Fakes.Services
{
    public static class WalletService
    {
        public static float FetchBalance() => 100000F;
        public static float WalletBalance { get; set; } = FetchBalance();
        public static void ResetWallet() => WalletBalance = 100000F;
    }
}
