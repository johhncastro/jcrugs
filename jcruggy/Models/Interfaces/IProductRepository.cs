namespace jcruggy.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetTrendProducts();
        Product? GetProductDetail(int id);
    }
}
