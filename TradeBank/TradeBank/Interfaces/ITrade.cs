﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBank.Interfaces
{
    public interface ITrade

    {
        double Value { get; }

        string ClientSector { get; }

    }
}
