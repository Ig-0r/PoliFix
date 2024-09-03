using PoliFix.Entities;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        
        Console.Write("Enter a number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product #{i} data: ");
            Console.Write("Common, used or imported (c/u/i)? ");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'c':
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                    break;

                case 'u':
                    Console.Write("Name: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Price: ");
                    double price1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name1, price1, manufactureDate));
                    break;

                case 'i':
                    Console.Write("Name: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Price: ");
                    double price2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name2, price2, customsFee));
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("PRICE TAGS: ");
        foreach (Product prod in list) 
        {
            Console.WriteLine(prod.PriceTag());
        }
    }
}