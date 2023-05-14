using System.Runtime.CompilerServices;
using Console = System.Console;

namespace Ch_4._1._9_EventExample;

public class Person
{
    public string name;

    private Magazine magazine;
    public Person(string name,Magazine publisher)
    {
        this.name = name;
        magazine = publisher;
        Console.WriteLine(name+" subscribed!");
        magazine.MagazinePublished += OnMagazinePublished;
    }

    /// <summary>
    /// publish event handler
    /// </summary>
    /// <param name="message"></param>
    private void OnMagazinePublished(string message)
    {
        Console.WriteLine(name+" received: "+ message);
    }

    public void Unsubscribe()
    {
        Console.WriteLine(name+" unsubscribed!");
        magazine.MagazinePublished -= OnMagazinePublished;
    }
 
}