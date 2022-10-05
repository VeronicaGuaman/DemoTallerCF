using DemoTallerCF.Models;
using DemoTallerCF.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoTallerCF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ProductEntity> products = this._productService.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProductModel product)
        {
            ProductEntity productEntity = new()
            { 
                Name = product.Name,
                Description = product.Description,
                Stock = product.Stock,
            };
            _productService.CreateProduct(productEntity);
            return Ok("Product add succefuly");
        }

        [HttpPut]
        [Route("updateProduct")]
        public IActionResult Put(int id, [FromBody] ProductModel product)
        {
            ProductEntity productEntity = new()
            {
                Name = product.Name,
                Description = product.Description,
                Stock = product.Stock,
            };
            _productService.UpdateProduct(productEntity, id);
            return Ok();
        }
    }
}
