using System.Globalization;


namespace PoliFix.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
           : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() 
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return "Product name: "
                   + Name
                   + " / Total price: $"
                   + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                   + $" (Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
