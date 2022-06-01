using ProductManagment.Entity;

namespace ProductManagment.Model
{
    public class PackageProductModel
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int ProductId { get; set; }
    }
}
