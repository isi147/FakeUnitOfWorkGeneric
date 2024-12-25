using System.Collections;

namespace ConsoleApp9.Models;

public class Invoice:IEnumerable
{
    public int Id { get; set; }
    public List<Item> Items { get; set; }

    public decimal TotalPrice { get; set; }

    public IEnumerator GetEnumerator()
    {
        return Items.GetEnumerator();
    }
}
