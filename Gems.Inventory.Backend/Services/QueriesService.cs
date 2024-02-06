using Gems.Inventory.Backend.Models;

namespace Gems.Inventory.Backend.Services
{
    public class QueriesService : IQueriesService
    {
        public QueriesService() { }

        public Product[] GetAllProducts()
        {
            return new[] { new Product { Id = Guid.NewGuid(), Name = "Name-01", Code = "N-01", Price = 3.99, UnitsInStock = 3.5 }, new Product { Id = Guid.NewGuid(), Name = "Name-02", Code = "N-02", Price = 3.99, UnitsInStock = 3.5 } };
        }

        public Product GetProduct(Guid productId)
        {
            return new Product { Id = productId, Name = "Name-01", Code = "N-01", Price = 3.99, UnitsInStock = 3.5 };
        }
    }
}
