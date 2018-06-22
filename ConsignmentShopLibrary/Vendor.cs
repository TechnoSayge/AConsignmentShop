using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        //creating an autoproperty you can type prop and hit tab twice
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public Vendor()
        {
            Commission = .5;
        }
    }
}
