using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmentApp
{
    internal class SimpleStringCollection
    {
        string[] Strings;

        public SimpleStringCollection(string[] strings)
        {
            Strings = strings;
        }

        public string this[int index]
        {
            get
            {
                return Strings[index];
            }
            set
            {
                Strings[index] = value;
            }
        }
    }
}
