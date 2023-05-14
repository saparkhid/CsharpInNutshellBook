// See https://aka.ms/new-console-template for more information

using Ch_4._1._9_EventExample;

Magazine publisher = new Magazine("Life");
Person personAli = new Person("Ali",publisher);
Person personMohammad = new Person("Mohammad",publisher);
Person personHamid = new Person("Hamid",publisher);
Person personMostafa = new Person("Mostafa",publisher);
personHamid.Unsubscribe();
publisher.Publish();

Console.ReadKey();

