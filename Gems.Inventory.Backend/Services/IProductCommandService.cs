using Gems.Inventory.Backend.Models;

namespace Gems.Inventory.Backend.Services
{
    public interface IProductCommandService
    {
        void DeleteProduct(Guid productId);
        Guid InsertProduct(Product product);
        void UpdateProduct(Product product);
    }
}