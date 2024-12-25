using ConsoleApp9.Models;
using ConsoleApp9.Repository.Concrate;
using ConsoleApp9.Repository.DbContext;
using ConsoleApp9.Repository.UnitOfWork.Contrate;

class Program
{

    static void Main(string[] args)
    {
        DatabaseContext dbContext = new DatabaseContext();
        UnitOfWork unitOfWork = new UnitOfWork(dbContext);
       


        Category category1 = new Category(1, "Et mehsullari");
        Category category2 = new Category(2, "Sud mehsullari");
        Product product1 = new Product(1, "Seba Toyuq 1kq", category1, 5.6m);
        Product product2 = new Product(2, "Atena Ayran", category2, 3.2m);




        unitOfWork.CategoryRepository.Add(category1);
        unitOfWork.CategoryRepository.Add(category2);

        unitOfWork.ProductRepository.Add(product1);
        unitOfWork.ProductRepository.Add(product2);

        var product = unitOfWork.ProductRepository.GetById(2);
        Console.WriteLine(product);




        Invoice invoice = new Invoice();

        foreach (var item in invoice)
        {
            Console.WriteLine(item);
        }


    }




}