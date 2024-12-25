using ConsoleApp9.Models;

namespace ConsoleApp9.Repository.Abstract;

public interface IBaseRepository<T>
{
    public void Add(T element);
    public void Update(int id);
    public void Delete(int id);
    public T GetById(int id);
    public List<T> GetAll();
}
