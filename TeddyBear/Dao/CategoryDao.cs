using TeddyBear.Repository;

namespace TeddyBear.Dao
{
    public class CategoryDao
    {
        private static CategoryDao? _instance;
        public CategoryDao() { }
        public static CategoryDao Instance()
        {
            if (_instance == null)
            {
                _instance = new CategoryDao();
            }
            return _instance;
        }
        

    }
}
