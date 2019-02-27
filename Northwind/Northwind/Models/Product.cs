namespace Northwind.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(int id, double price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }
    }
}