using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; } //list of types
        public List<Item> Items { get; set; } //list of types

        public Store() //a constructor because it has not assingment
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();

        }
    }
}
