using Gems.Inventory.Backend.Models;

namespace Gems.Inventory.Backend.Services
{
    public interface IQueriesService
    {
        Product[] GetAllProducts();
        Product GetProduct(Guid productId);
    }
}