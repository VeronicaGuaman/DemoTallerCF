namespace DemoTallerCF.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public string Stock { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
