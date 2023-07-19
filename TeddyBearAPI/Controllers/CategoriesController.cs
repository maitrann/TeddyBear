using Microsoft.AspNetCore.Mvc;
using TeddyBearAPI.Models;
using TeddyBearAPI.ModelsView;
using TeddyBearAPI.Utilities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeddyBearAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DBContext _db = new();
        // GET: api/<CategoriesController>
        [Route("GetCateMain")]
        [HttpGet]
        public List<Category> GetCateMain()
        {
            var rs = _db.Categories.Where(x => x.IdCate == null && x.IsActive == true).ToList();
            return rs;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<CategoriesController>/5
        [Route("GetCate/{id}")]
        [HttpGet]
        public List<Category> GetCate(int id)
        {
            var rs = _db.Categories.Where(x => x.IdCate == id && x.IsActive == true).ToList();
            return rs;
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
