using System;
using System.Collections.Generic;
using System.Text;

namespace day6
{
    internal class bookinfo
    {
        public string Id {  get; set; }
        public string Bookname { get; set; }
        public string Author { get; set; }

        public double Price { get; set; }

        public string Lab { get; set; }
        public bool isborrow {  get; set; }

        internal bookinfo(string Id, string Bookname, string Author, double Price, string Lab,bool isborrow)
        {
            this.Id = Id;
            this.Bookname = Bookname;
            this.Author = Author;
            this.Price = Price;
            this.Lab = Lab;
            this.isborrow = isborrow;
        }
    }
}
