using ConsoleApp9.Models;
using ConsoleApp9.Repository.Abstract;
using ConsoleApp9.Repository.DbContext;

namespace ConsoleApp9.Repository.Concrate;

public class ItemRepository :IBaseRepository<Item>
{
    private readonly DatabaseContext _databaseContext;

    public ItemRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public void Add(Item product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Item> GetAll()
    {
        throw new NotImplementedException();
    }

    public Item GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}
