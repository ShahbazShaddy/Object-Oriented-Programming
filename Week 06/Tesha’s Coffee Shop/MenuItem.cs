using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06a
{
    internal class MenuItem
    {
            public string Name { get; set; }
            public string Type { get; set; }
            public double Price { get; set; }

            public MenuItem(string name, string type, double price)
            {
                Name = name;
                Type = type;
                Price = price;
            }
    }
}
