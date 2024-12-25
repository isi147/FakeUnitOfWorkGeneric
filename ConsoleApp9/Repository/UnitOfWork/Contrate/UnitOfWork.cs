using ConsoleApp9.Repository.Abstract;
using ConsoleApp9.Repository.Concrate;
using ConsoleApp9.Repository.DbContext;

namespace ConsoleApp9.Repository.UnitOfWork.Contrate;

public class UnitOfWork
{
    public DatabaseContext _dbContext;


    public ProductRepository ProductRepository  ;
    public CategoryRepository CategoryRepository ;
    public ItemRepository ItemRepository;

    public UnitOfWork(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
        ProductRepository = new ProductRepository(_dbContext);
        CategoryRepository = new CategoryRepository(_dbContext);
        ItemRepository = new ItemRepository(_dbContext);
    }
}
