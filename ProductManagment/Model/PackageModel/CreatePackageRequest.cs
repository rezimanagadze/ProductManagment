using ProductManagment.Entity;

namespace ProductManagment.Model
{
    public class CreatePackageRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<PackageProductModel> PackageProducts { get; set; }
        public string Description { get; set; }
    }
}
