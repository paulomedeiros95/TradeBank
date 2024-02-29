// See https://aka.ms/new-console-template for more information
using TradeBank.Interfaces;
using TradeBank.UseCases;
using TradeBank;

Console.WriteLine("Trade Category");
Console.WriteLine("--------------");

//Execution examples below.
var trades = new List<ITrade>
{
    new Trade(2000000, "Private"),
    new Trade(400000, "Public"),
    new Trade(500000, "Public"),
    new Trade(3000000, "Public")
};

var categories = new List<ITradeCategory>
{
    new LowRiskCategory(),
    new MediumRiskCategory(),
    new HighRiskCategory()
};

var categorizer = new TradeCategorizer(categories);
var tradeCategories = categorizer.CategorizeTrades(trades);

// Output trade categories
foreach (var category in tradeCategories)
{
    Console.WriteLine($"Result of this trade is =  {category}");
}
