using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Transactions
{
    interface ITransaction
    {
        ICommodity TxCommodity { get; set; }
        ITrade TxTrade { get; set; }

        void Buy();
        void Sell(ICommodity sellingComodity);

    }
}
