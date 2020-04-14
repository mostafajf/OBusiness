using System.Collections.Generic;

namespace OBusiness.Core.Dto
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int ID { get; set; }
        public string Name { get; set; }  
        public List<Product> Products { get; set; }
    }
}
