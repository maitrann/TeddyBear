using TeddyBear.Models;
using TeddyBear.ModelsView;

namespace TeddyBear.Interface
{
    public interface IHomepage
    {
        List<ProductView> GetCateOfProductOutstand();
        List<Product> GetProductOutstand(int? id);
        List<ProductView> GetSizeOfProduct(int id);
    }
}
