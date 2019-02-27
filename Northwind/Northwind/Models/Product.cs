namespace Northwind.Models
{
    public class Product
    {
        int Id { get; set; }
        double Price { get; set; }
        string Name { get; set; }

        public Product(int id, double price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }
    }
}