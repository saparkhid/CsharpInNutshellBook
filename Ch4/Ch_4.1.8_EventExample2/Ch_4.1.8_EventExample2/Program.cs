using System.Globalization;
using Ch_4._1._8_EventExample2;

Currency dollarCurrency = new Currency();
Exchange zarExchange = new Exchange("Zar Exchange",dollarCurrency);
Exchange jordanExchange = new Exchange("Jordan Exchange",dollarCurrency);

dollarCurrency.SetPrice(50000);


Console.ReadKey();