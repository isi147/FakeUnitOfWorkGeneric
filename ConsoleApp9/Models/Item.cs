namespace ConsoleApp9.Models;

public class Item
{
    public int Id { get; set; }
    public List<Product> Products { get; set; }
    public decimal Price { get; set; }
    public Item(int id, List<Product> products, decimal price)
    {
        Id = id;
        Products = products;
        Price = price;
    }
}
