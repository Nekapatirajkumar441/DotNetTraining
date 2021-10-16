using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class book
    {
        public string title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} by {1} (price:$ {2})",title,Author,Price).ToString();
        }
    }
}
