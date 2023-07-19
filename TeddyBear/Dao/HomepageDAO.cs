using TeddyBear.Interface;
using TeddyBear.Models;
using TeddyBear.ModelsView;
using TeddyBear.Utilities;

namespace TeddyBear.Dao
{
    public class HomepageDAO : IHomepage
    {
        private DBContext _db = new DBContext();
        private static HomepageDAO? _instance = null;
        private HomepageDAO() { }
        public static HomepageDAO Instance()
        {
            if (_instance == null)
            {
                _instance = new HomepageDAO();
            }
            return _instance;
        }
        public List<ProductView> GetCateOfProductOutstand()
        {
            //var rs = _db.Product_Sizes.Select(x=>new ProductView()
            //{
            //    IdProduct=x.
            //}).ToList();
            var rs = _db.Products.Where(x => x.IsOutstanding == true).Select(x=>new ProductView()
            {
                IdCategory= x.IdCategory,
                TitleCate=x.Prod_Cate.Title,
            }).Distinct().ToList();
            return rs;
        }

        public List<Product> GetProductOutstand(int? id)
        {
            var rs = _db.Products.Where(x => x.IsOutstanding == true&&x.IdCategory==id).ToList();
            return rs;
        }

        public List<ProductView> GetSizeOfProduct(int id)
        {
            var rs = _db.Product_Sizes.Where(x=>x.IdProduct==id).Select(x=>new ProductView()
            {
                IdSize = x.IdSize,
                Length=x.Size.Length,
                Price=x.Price,
                SalePrice=x.SalePrice,
            }).ToList();
            return rs;
        }
    }
}
