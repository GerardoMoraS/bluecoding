using Gems.Inventory.Backend.Models;
using Gems.Inventory.Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Gems.Inventory.Backend.Controllers
{
    // 𝗩𝗲𝗿𝘁𝗶𝗰𝗮𝗹 𝗦𝗹𝗶𝗰𝗲 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲
    [Route("api/[controller]")]
    [ApiController]
    public class CqrsProductController(IQueriesService queriesService, IProductCommandService productCommandService) : ControllerBase
    {
        [HttpPut]
        public CreatedResult NewInventory(Product product)
        {
            productCommandService.InsertProduct(product);

            return Created();
        }


        [HttpGet("{id}")]
        public  Product GetProduct([FromRoute] Guid id)
        {
            var product = queriesService.GetProduct(id);

            return product;
        }

        [HttpGet]
        public  Product[] ListInventory()
        {
            var products = queriesService.GetAllProducts();

            return products;
        }


        [HttpPost]
        public  NoContentResult UpdateProduct(Product product)
        {
            productCommandService.UpdateProduct(product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult DeleteProduct([FromRoute] Guid id)
        {
            productCommandService.DeleteProduct(id);

            return NoContent();
        }
    }
}
