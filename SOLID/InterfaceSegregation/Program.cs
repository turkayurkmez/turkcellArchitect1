// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//public interface IOperations
//{
//    void DoThis();
//    void DoThat();
//    void ShowThis();
//}
//public class CustomProcess : IOperations
//{
//    public void DoThat()
//    {
//        Console.WriteLine("Ok");
//    }

//    public void DoThis()
//    {
//        throw new NotImplementedException();
//    }

//    public void ShowThis()
//    {
//        Console.WriteLine("Show....");
//    }
//}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public interface IRepository<T>
{
    IList<T> GetAll();
    T GetById(int id);
    void Add(T entity);

}

public interface IProductRepository : IRepository<Product>
{
    IList<Product> SearchProductsByName(string name);
}
public class ProductRepository : IProductRepository
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public IList<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Product> SearchProductsByName(string name)
    {
        throw new NotImplementedException();
    }
}

public class Category
{

}
public class CategoryRepository : IRepository<Category>
{
    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public IList<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }
}