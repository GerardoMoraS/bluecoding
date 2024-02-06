using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gems.Inventory.Backend.Controllers
{
    // 𝗩𝗲𝗿𝘁𝗶𝗰𝗮𝗹 𝗦𝗹𝗶𝗰𝗲 𝗔𝗿𝗰𝗵𝗶𝘁𝗲𝗰𝘁𝘂𝗿𝗲
    [Route("api/[controller]")]
    [ApiController]
    public class VsaProductController : ControllerBase
    {
        public record GetProductModel(Guid id, string Name, string code, double price, double unitsInStock);

        public record PutProductModel(string name, string code, double price, double unitsInStock);
        public record PostProductModel(Guid id, string Name, string code, double price, double unitsInStock);

        [HttpPut]
        public PutProductModel NewInventory()
        {
            var model = new PutProductModel( "Name-01", "N-01", 3.99, 3.5);

            return model;
        }


        [HttpGet("{id}")]
        public GetProductModel GetItem([FromRoute] Guid id)
        {
            var model = new GetProductModel(id, "Name-01", "N-01", 3.99, 3.5);

            return model;
        }

        [HttpGet]
        public GetProductModel[] ListInventory()
        {
            var model = new[] { new GetProductModel(Guid.NewGuid(), "Name-01", "N-01", 3.99, 3.5), new GetProductModel(Guid.NewGuid(), "Name-02", "N-02", 3.99, 3.5) };

            return model;
        }


        [HttpPost]
        public PostProductModel CurrentInventory()
        {
            var model = new PostProductModel(Guid.NewGuid(), "Name-01", "N-01", 3.99, 3.5);

            return model;
        }
    }
}
