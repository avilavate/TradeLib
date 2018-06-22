using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    class BaseWallet
    {
        protected float Balance { get; set; }
        public void Credit(float ammount) => Balance = ammount + Balance;

        public virtual void Debit(float ammount) => Balance -= ValidateDebit(ammount) ? ammount : throw new Exception("No Sufficient Balance");

        public virtual bool ValidateDebit(float ammount) => false;

        public float GetBalance() => Balance;
    }
}
