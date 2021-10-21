using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp2A2.BooksApi
{
    public class Book

    {

        public string Title { get; set; }



        public string Author { get; set; }



        public int Price { get; set; }



        public override string ToString()

        {

            return string.Format("{0} by {1} ", Title, Author);

        }

    }
}
