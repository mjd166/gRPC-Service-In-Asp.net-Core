using Microsoft.AspNetCore.Mvc;
using ProductsService;
using System.Threading.Tasks;

namespace ProductApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductServices.ProductServicesClient _servicesClient;

        public ProductController(ProductServices.ProductServicesClient servicesClient)
        {
            _servicesClient = servicesClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _servicesClient.GetAllAsync(new Empty()));
        }


        [HttpGet("{id:int}",Name ="GetProductById")]
        public async Task<IActionResult> GetById(int id)
        {
            var search = await _servicesClient.GetAsync(new ProductId { Id=id });
            if (search == null) return NotFound();
            return Ok(search);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            var result = await _servicesClient.InsertAsync(product);
            if (result == null) return BadRequest();
            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Product product)
        {
            var result = await _servicesClient.UpdateAsync(product);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _servicesClient.DeleteAsync(new ProductId { Id = id }));
        }
    }
}
