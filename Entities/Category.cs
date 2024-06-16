using Core.DataAccess;

namespace Entities
{
    public class Category : Entity
    {
        public Category()
        {
        }
        public Category(int id,string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }

        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set;}
    }
}