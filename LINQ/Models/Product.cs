namespace LINQ.Models
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
