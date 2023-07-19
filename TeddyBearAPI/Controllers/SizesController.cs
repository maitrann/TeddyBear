using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeddyBearAPI.Models;
using TeddyBearAPI.ModelsView;
using TeddyBearAPI.Utilities;

namespace TeddyBearAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        private readonly DBContext _db = new();

        [Route("GetSizeByIdProd/{id}")]
        [HttpGet]
        public List<ProductView> GetSizeByIdProd(int id)
        {
            var rs = _db.Product_Sizes.Where(x => x.IdProduct == id).Select(x => new ProductView()
            {
                IdProduct = x.IdProduct,
                IdSize = x.IdSize,
                Length = x.Size.Length,
                Price = x.Price,
                SalePrice = x.SalePrice,
            }).ToList();
            return rs;
        }
    }
}
