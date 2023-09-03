using ECommerce.Application.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductReadRepository _productRead;
        private readonly IProductWriteRepository _productWrite;

        public ProductsController(IProductReadRepository productRead, IProductWriteRepository productWrite)
        {
            _productRead = productRead;
            _productWrite = productWrite;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //await _productWrite.AddRangeAsync(new() { 
            //    new Domain.Entities.Product() { Name = "Product3", Price = 300, CreateedDate = DateTime.UtcNow }, 
            //    new Domain.Entities.Product() { Name = "Product4", Price = 400, CreateedDate = DateTime.UtcNow } 
            //});
            //await _productWrite.SaveAsync();

            var products = _productRead.GetAll().ToList();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var products = await _productRead.GetByIdAsync(id);
            return Ok(products);
        }
    }
}
