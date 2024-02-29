using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeBank.Interfaces;

namespace TradeBank
{
    /// <summary>
    /// This class will use a list of ITradeCategory to determine the category of each trade.
    /// </summary>
    public class TradeCategorizer
    {
        private readonly List<ITradeCategory> _categories;

        public TradeCategorizer(List<ITradeCategory> categories)
        {
            _categories = categories ?? throw new ArgumentNullException(nameof(categories));
        }

        public List<string> CategorizeTrades(IEnumerable<ITrade> trades)
        {
            var tradeCategories = new List<string>();

            foreach (var trade in trades)
            {
                var category = _categories.FirstOrDefault(c => c.IsMatch(trade));

                tradeCategories.Add(category?.Name ?? "UNKNOWN");
            }

            return tradeCategories;
        }
    }
}
