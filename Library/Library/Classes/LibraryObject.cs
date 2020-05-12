using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class LibraryObject
    {
        public decimal price;
        public string title;
        public string description;

        public LibraryObject(decimal _price, string _title, string _description)
        {
            price = _price;
            title = _title;
            description = _description;
        }

        public override string ToString()
        {
            return title;
        }
    }
}