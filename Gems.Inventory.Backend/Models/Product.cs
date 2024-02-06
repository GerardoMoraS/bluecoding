namespace Gems.Inventory.Backend.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public double Price { get; set; }
        public double UnitsInStock { get; set; }
    }
}
