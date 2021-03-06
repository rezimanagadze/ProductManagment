using ProductManagment.Entity;

namespace ProductManagment.Model
{
    public class CreatePackageProductRequest
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
