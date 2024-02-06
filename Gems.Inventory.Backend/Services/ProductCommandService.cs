using Gems.Inventory.Backend.Models;

namespace Gems.Inventory.Backend.Services
{
    public class ProductCommandService : IProductCommandService
    {
        public Guid InsertProduct(Product product)
        {
            return Guid.NewGuid();
        }

        public void UpdateProduct(Product product)
        {

        }

        public void DeleteProduct(Guid productId)
        {

        }
    }
}
