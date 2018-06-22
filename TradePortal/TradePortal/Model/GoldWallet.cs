using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    class GoldWallet : BaseWallet, IDisposable
    {
        private ITax GSTonGold { get; set; }

        public GoldWallet(float ammount, ITax gst)
        {
            Balance = ammount;
            GSTonGold = gst;
        }

        public override void Debit(float ammount)
        {
            if (!ValidateDebit(ammount)) throw new Exception("The Wallet has insufficient balance");
            ammount += (ammount * GSTonGold.TaxRate) / 100;
            base.Debit(ammount);
        }

        public override bool ValidateDebit(float ammount) => Balance > ammount;

        public void Dispose()
        {
            Balance = 0;
        }
    }
}
