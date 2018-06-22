using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradePortal.Model;

namespace TradePortal.Validators
{
    /// <summary>
    /// Interface to validate any tracaction before its executed.
    /// </summary>
   public interface IValidator
    {
        ITrade Trade { get; }
        ICommodity Comodity { get; }

        bool IsValid();
    }
}
