using System.Collections.Generic;

namespace OBusiness.Core.Dto
{
    public class MenuDto
    {
        public int MenuID { get; set; }
        public List<CategoryDto> Categories { get; set; }
    }
}
