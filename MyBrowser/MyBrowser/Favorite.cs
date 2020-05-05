using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBrowser
{
    public class Favorite
    {
        public string UrlAddress;
        public string Title;

        public Favorite(string urlAddress, string title)
        {
            UrlAddress = urlAddress;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}