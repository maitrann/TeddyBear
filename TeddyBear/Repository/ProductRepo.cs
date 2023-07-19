using Newtonsoft.Json;
using RestSharp;
using TeddyBear.Models;
using TeddyBear.ModelsView;

namespace TeddyBear.Repository
{
    public class ProductRepo
    {
        private static ProductRepo? _instance=null;
        private ProductRepo() { }
        public static ProductRepo Instance()
        {
            if (_instance == null)
            {
                _instance = new ProductRepo();
            }
            return _instance;
        }

        private dynamic ConnectApi(string controller)
        {
            var connectApi = new RestClient($"http://localhost:5166/api/{controller}");

            var request = new RestRequest();
            RestResponse response = connectApi.Execute(request);
            return response.Content;
        }
        public List<Product> GetProductByIdSubCate(int id)
        {
            var callApi = ConnectApi($"Products/GetProductByIdSubCate/{id}");
            var rs = JsonConvert.DeserializeObject<List<Product>>(callApi);
            return rs;
        }
        public List<Product> GetProductByIdCate(int id)
        {
            var callApi = ConnectApi($"Products/GetProductByIdCate/{id}");
            var rs = JsonConvert.DeserializeObject<List<Product>>(callApi);
            return rs;
        }
        public List<ProductView> GetSizeByIdProd(int id)
        {
            var callApi = ConnectApi($"Sizes/GetSizeByIdProd/{id}");
            var rs = JsonConvert.DeserializeObject<List<ProductView>>(callApi);
            return rs;
        }
    }
}
