﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradePortal.Model
{
    class GSTGold:ITax
    {
        public float TaxRate { get; } = 5.0F;
    }
}