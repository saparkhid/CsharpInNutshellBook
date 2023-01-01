using Ch3_5.Indexer;
Book book1 = new Book("Book A");
Library libary = new Library();
libary.DoSomething();
GC.Collect();
Thread.Sleep(1000);
Console.WriteLine("any key...");
Console.ReadKey();