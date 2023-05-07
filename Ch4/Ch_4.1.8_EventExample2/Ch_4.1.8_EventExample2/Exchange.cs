namespace Ch_4._1._8_EventExample2;

public class Exchange
{
    private string name;
    private Currency currency;
    public Exchange(string exchangeName, Currency importantCurrency)
    {
        this.name = exchangeName;
        this.currency = importantCurrency;
        this.currency.PriceChanged += OnCurrencyPriceChanged;
    }
    //event handler
    public void OnCurrencyPriceChanged(decimal oldPrice, decimal newPrice)
    {
        Console.WriteLine(name+":");
        Console.WriteLine("Old price:"+ oldPrice);
        Console.WriteLine("New price:"+ newPrice);
        Console.WriteLine("-----");
    }
}