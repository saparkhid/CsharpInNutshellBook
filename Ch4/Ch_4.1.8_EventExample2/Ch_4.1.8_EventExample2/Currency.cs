namespace Ch_4._1._8_EventExample2;

public class Currency
{
    private decimal price;
    public event PriceChangedHandler PriceChanged;
    public Currency()
    {
        price = 0;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public void SetPrice(decimal userPrice)
    {
        if (userPrice != price)
        {
            PriceChanged.Invoke(this.price,userPrice);
        }
        price = userPrice;
    }
}