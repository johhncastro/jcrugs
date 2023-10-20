using jcruggy.Models.Interfaces;

namespace jcruggy.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<product> productsList = new List<product>() 
        { 
            new product{Id = 1 , Name = "Jolly Roger", Price = 200, Detail = "3.5ft x 3.5ft Tufted rug. This rug is the jolly roger from the straw hat pirates from the hit show One Piece.", ImgUrl = "https://imgur.com/a/oDzvMRd"}
            new product{Id = 2 , Name = "UZI RUG", Price = 250, Detail = "3.5ft x 3.5ft Tufted rug. This rug is taken from inpiration from lil uzi eternal atake album", ImgUrl = "https://imgur.com/a/oDzvMRd"}
            new product{Id = 3 , Name = "UNDERTALE", Price = 150, Detail = "3.5ft x 3.5ft Tufted rug. This rug is from the video game undertale and features the main character", ImgUrl = "https://imgur.com/a/oDzvMRd"}

        };
        public IEnumerable<product> GetAllProducts()
        {
            return productsList;
        }

        public product GetProductDetail(int id)
        {
            return productsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<product> GetTrendProducts()
        {
            return productsList.Where(p=>p.IsTredingProduct);
        }
    }
}
