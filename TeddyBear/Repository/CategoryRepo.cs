using Newtonsoft.Json;
using RestSharp;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using TeddyBear.Models;
using static System.Net.WebRequestMethods;

namespace TeddyBear.Repository
{
    public class CategoryRepo
    {
        private static CategoryRepo? _instance;
        private CategoryRepo() { }
        public static CategoryRepo Instance()
        {
            if (_instance == null)
            {
                _instance = new CategoryRepo();
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
        public List<Category> GetCateMain()
        {
            var callApi = ConnectApi("Categories/GetCateMain");
            var rs = JsonConvert.DeserializeObject<List<Category>>(callApi);
            return rs;
        }
        public List<Category> GetCate(int id)
        {
            var callApi = ConnectApi($"Categories/GetCate/{id}");
            var rs = JsonConvert.DeserializeObject<List<Category>>(callApi);
            return rs;
        }
    }
}
