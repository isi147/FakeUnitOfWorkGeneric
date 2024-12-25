using ConsoleApp9.Models;
using ConsoleApp9.Repository.Abstract;
using ConsoleApp9.Repository.DbContext;

namespace ConsoleApp9.Repository.Concrate;

public class CategoryRepository : IBaseRepository<Category>
{
    private readonly DatabaseContext _databaseContext;

    public CategoryRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public void Add(Category category)
    {
        _databaseContext.Categories.Add(category);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}
