using DemoTallerCF.Data;
using DemoTallerCF.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoTallerCF.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;

        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }

        public void CreateProduct(ProductEntity product)
        {
            _context.ProductEntity.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductEntity product, int idProduct)
        {
            ProductEntity productEntity = this.GetProduct(idProduct) ?? throw new NullReferenceException();
            if (idProduct == productEntity.Id)
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(ProductEntity product, int idProduct)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }

        public ProductEntity GetProduct(int idProduct)
        {
            return _context.ProductEntity.Find(idProduct);
        }

        public List<ProductEntity> GetProducts()
        {
            return _context.ProductEntity.ToList();
        }
    }
}
