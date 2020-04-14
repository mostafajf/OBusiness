using System.Collections.Generic;

namespace OBusiness.Core.Dto
{
    public class CategoryDto
    {
        public CategoryDto()
        {
            Products = new List<ProductDto>();
        }
        public int ID { get; set; }
        public string Name { get; set; }  
        public List<ProductDto> Products { get; set; }
    }
}
