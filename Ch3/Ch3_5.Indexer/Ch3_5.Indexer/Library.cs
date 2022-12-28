using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_5.Indexer
{
    public class Library
    {
        public string[] books;
        public Library()
        {
            books = new string[]
            {
                "The Man Has a Past",
                "Quick Quack Quentin",
                "Presentations (Quick Study: Business)",
                "Trigonometry (Quick Study Academic)"
            };
        }
       
        public string this[int j]
        {
            get { return books[j]; }
        }
      
    }
}
