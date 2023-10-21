using jcruggy.Data;
using jcruggy.Models.Interfaces;

namespace jcruggy.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private jcruggyDbContext dbContext;

        public ProductRepository(jcruggyDbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
