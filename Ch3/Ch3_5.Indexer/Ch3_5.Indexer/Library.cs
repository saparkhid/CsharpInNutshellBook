using System;

namespace Ch3_5.Indexer
{
    public class Library : Object
    {
        public string[] books;
        public Library()
        {

            Console.WriteLine("Created Library");
            books = new string[]
            {
                "The Man Has a Past",
                "Quick Quack Quentin",
                "Presentations (Quick Study: Business)",
                "Trigonometry (Quick Study Academic)"
            };
        }
       
        public void DoSomething()
        {
            /*
            for(int i = 0; i < books.Length; i++)
            {
                Book b = new Book(books[i]);
            }*/
        }
        public string this[int j]
        {
            get { return books[j]; }
        }

        ~Library()
        {
            Console.WriteLine("Finalizing Library");
            //System.IO.File.WriteAllText("D:\\ERRRRRE.txt", "Finalizing Library");
        }
   
      
    }
}
