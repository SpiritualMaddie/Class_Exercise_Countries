using System;
using System.Collections.Generic;
using System.Text;

namespace _22_10_20_Countries
{
    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
        public Country(string Name, string Code, string Capital)
        {
            this.Name = Name;
            this.Code = Code.ToUpper();
            this.Capital = Capital;
        }
    }
}
