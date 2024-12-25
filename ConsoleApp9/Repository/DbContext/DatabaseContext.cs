using ConsoleApp9.Models;

namespace ConsoleApp9.Repository.DbContext;

public class DatabaseContext
{
    public List<Product> Products { get; set; }
    public List<Category> Categories { get; set; }
    public List<Item> Items { get; set; }

    public DatabaseContext()
    {
        Products = new List<Product>();
        Categories = new List<Category>();
        Items = new List<Item>();
    }
}
