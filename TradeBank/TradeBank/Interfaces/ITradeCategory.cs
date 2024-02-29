using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBank.Interfaces
{
    /// <summary>
    /// ITradeCategory Interface, this interface will be implemented by any class that represents a trade category, such as LowRisk, MediumRisk, or HighRisk.
    /// </summary>
    public interface ITradeCategory

    {

        string Name { get; }

        bool IsMatch(ITrade trade);

    }
}
