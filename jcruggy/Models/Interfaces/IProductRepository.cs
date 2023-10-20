namespace jcruggy.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<product> GetAllProducts();

        IEnumerable<product> GetTrendProducts();
        product GetProductDetail(int id);
    }
}
