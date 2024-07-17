using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.ProductRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductsAsync();

            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductsWithCategoriesAsync();

            return Ok(values);
        }

        [HttpGet("ChangeProductDealOfTheDayToFalse/{id}")]
        public async Task<IActionResult> ChangeProductDealOfTheDayToFalse(int id)
        {
            _productRepository.ChangeProductDealOfTheDayToFalse(id);
            return Ok("İlan Günün Fırsatları Arasından Çıkarıldı!");
        }

        [HttpGet("ChangeProductDealOfTheDayToTrue/{id}")]
        public async Task<IActionResult> ChangeProductDealOfTheDayToTrue(int id)
        {
            _productRepository.ChangeProductDealOfTheDayToTrue(id);
            return Ok("İlan Günün Fırsatları Arasına Eklendi!");
        }
    }
}
