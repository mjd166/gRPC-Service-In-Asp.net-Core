using Microsoft.AspNetCore.Mvc;
using ProductsService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWebApplication.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductsController : Controller
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        private readonly ProductService.ProductServiceClient _serviceClient;
#pragma warning restore CS0436 // Type conflicts with imported type

#pragma warning disable CS0436 // Type conflicts with imported type
        public ProductsController(ProductService.ProductServiceClient serviceClient)
#pragma warning restore CS0436 // Type conflicts with imported type
        {
            _serviceClient = serviceClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _serviceClient.GetAllAsync(new Empty());
            var products = result.Products.ToList();

            return Ok( products);
        }

        [HttpGet("{id:int}",Name ="GetProduct")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await  _serviceClient.GetAsync(new ProductId { Id = id });
            if (product == null)
                return NotFound();

            return   Ok(product);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product _product)
        {
            var _createdProduct = await  _serviceClient.InsertAsync(_product);
            return CreatedAtRoute("GetProduct", new { Id = _createdProduct.ProductId },_createdProduct);

        }

        [HttpPut]
        public async Task< IActionResult> Put([FromBody] Product _product)
        {
            var result = await  _serviceClient.UpdateAsync(_product);
            if (result == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
           return Ok(await  _serviceClient.DeleteAsync(new ProductId { Id = id }));
        }
    }
}
