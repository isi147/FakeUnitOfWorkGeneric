using ConsoleApp9.Models;
using ConsoleApp9.Repository.Abstract;
using ConsoleApp9.Repository.DbContext;

namespace ConsoleApp9.Repository.Concrate;

public class ProductRepository : IBaseRepository<Product>
{
    private readonly DatabaseContext _databaseContext;

    public ProductRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public void Add(Product product)
    {
        _databaseContext.Products.Add(product);
    }

    public void Delete(int id)
    {
        //Product product = null;
        //foreach (var item in Products)
        //{
        //    if (item.Id == id) ;
        //    product = item;
        //}
        //if(Product is null)
        //{
        //    throw new Exception($"{id} - Yalniwdir")
        //}
        //else
        //{
        //    Products.Remove(product);
        //}

        var product = _databaseContext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"{id} - Yalniwdir");
        _databaseContext.Products.Remove(product);
    }

    public List<Product> GetAll()
    {
        return _databaseContext.Products;
    }

    public Product GetById(int id)
    {
        return _databaseContext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"{id} - Yalniwdir");
    }

    public void Update(int id)
    {
        var product = _databaseContext.Products.FirstOrDefault(x => x.Id == id) ?? throw new Exception($"{id} - Yalniwdir");
        
    }
}
