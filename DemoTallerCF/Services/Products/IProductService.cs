using DemoTallerCF.Models;

namespace DemoTallerCF.Services.Products
{
    public interface IProductService
    {
        void CreateProduct(ProductEntity product);
        void DeleteProduct(ProductEntity product, int idProduct);
        ProductEntity GetProduct(int idProduct);
        public List<ProductEntity> GetProducts();
        void UpdateProduct(ProductEntity product, int idProduct);
    }
}