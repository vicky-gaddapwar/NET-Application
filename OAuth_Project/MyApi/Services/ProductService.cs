using MyApi.Models;

namespace MyApi.Services
{
    public class ProductService
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000 },
            new Product { Id = 2, Name = "Mouse", Price = 1500 }
        };

        public List<Product> GetAll() => _products;

        public Product? Get(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public Product Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return product;
        }

        public bool Delete(int id)
        {
            var product = Get(id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }
    }
}
