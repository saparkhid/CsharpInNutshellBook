using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_5.Indexer
{
    public class Book
    {
        public string Title;
        public Book(string title)
        {
            Console.WriteLine("Created book");
            Title = title;
        }
        ~Book()
        {
            Console.WriteLine("Finalized book");
        }


    }
}
