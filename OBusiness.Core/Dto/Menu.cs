using System.Collections.Generic;

namespace OBusiness.Core.Dto
{
    public class Menu
    {
        public int MenuID { get; set; }
        public List<Category> Categories { get; set; }
    }
}
