using System.Collections.Generic;
using System.Linq;

namespace UM_BL_Estimate.Services
{
    public class ProductService
    {

        private List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1200, Stock = 10 },
        new Product { Id = 2, Name = "Mouse", Price = 25, Stock = 100 }
    };

        public List<Product> GetAll() => _products;

        public void Add(Product p)
        {
            p.Id = _products.Max(x => x.Id) + 1;
            _products.Add(p);
        }

        public void Update(Product p)
        {
            var existing = _products.First(x => x.Id == p.Id);
            existing.Name = p.Name;
            existing.Price = p.Price;
            existing.Stock = p.Stock;
        }

        public void Delete(Product p)
        {
            _products.Remove(_products.First(x => x.Id == p.Id));
        }

    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
