using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliFix.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        UsedProduct() 
        { 
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return "Product name: "
                   + Name
                   + " (used) / Price: $"
                   + Price.ToString("F2", CultureInfo.InvariantCulture)
                   + " (Manufacture date: "
                   + ManufactureDate.ToString("dd/MM/yyyy")
                   + ")";
        }
    }
}
