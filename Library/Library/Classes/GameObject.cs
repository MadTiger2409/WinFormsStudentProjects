using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class GameObject : LibraryObject
    {
        public int minimalAge;

        public GameObject(decimal _price, string _title, string _description, int _minimalAge) : base(_price, _title, _description)
        {
            minimalAge = _minimalAge;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"c:\games.txt", true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", price, title, description, minimalAge);
            }
        }
    }
}