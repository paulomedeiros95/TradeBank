using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeBank.Interfaces;

namespace TradeBank.UseCases
{
    /// <summary>
    /// Implement Category Classes. Each category will be a class that implements the ITradeCategory interface.
    /// </summary>
    public class LowRiskCategory : ITradeCategory
    {        public string Name => "LOWRISK";

        public bool IsMatch(ITrade trade)
        {
            return trade.Value < 1_000_000 && trade.ClientSector == "Public";
        }
    }
}
