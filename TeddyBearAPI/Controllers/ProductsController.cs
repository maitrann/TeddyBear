using Microsoft.AspNetCore.Mvc;
using TeddyBearAPI.Models;
using TeddyBearAPI.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeddyBearAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DBContext _db = new();

        // GET: api/<ProductsController>
        [Route("GetProductByIdSubCate/{id}")]
        [HttpGet]
        public List<Product> GetProductByIdSubCate(int id)
        {
            var rs = _db.Products.Where(x => x.Prod_Cate.IdCate==id && x.IsActive == true).Select(x => new Product()
            {
                Id = x.Id,
                Title = x.Title,
            }).ToList();
            return rs;
        }

        // GET api/<ProductsController>/5
        [HttpGet("GetProductByIdCate/{id}")]
        public List<Product> GetProductByIdCate(int id)
        {
            var rs = _db.Products.Where(x => x.IdCategory == id && x.IsActive == true).Select(x => new Product()
            {
                Id = x.Id,
                Title = x.Title,
            }).ToList();
            return rs;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
