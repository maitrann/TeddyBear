using TeddyBear.Dao;
using TeddyBear.Models;
using TeddyBear.ModelsView;

namespace TeddyBear.Repository
{
    public class HomeRepo
    {
        public static List<ProductView> GetCateOfProductOutstand()
        {
            return HomepageDAO.Instance().GetCateOfProductOutstand();
        }
        public static List<Product> GetProductOutstand(int? id)
        {
            return HomepageDAO.Instance().GetProductOutstand(id);
        }
        public static List<ProductView> GetSizeOfProduct(int id)
        {
            return HomepageDAO.Instance().GetSizeOfProduct(id);
        }
    
    }
}
