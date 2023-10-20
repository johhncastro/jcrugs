namespace jcruggy.Models
{
    public class product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Detail { get; set; }

        public string? ImgUrl { get; set; }

        public decimal Price { get; set; }

        public bool IsTredingProduct { get; internal set; }
    }
}
