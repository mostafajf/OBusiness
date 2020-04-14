using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{
    public class MenuDoc
    {
        public List<Category> Categories { get; set; }

        public int MenuID { get; set; }

        public Dictionary<string, Product> Products { get; set; }

        public Dictionary<string, ModifierGroup> ModifierGroups { get; set; }

        public string ProfileImage { get; set; }
    }


}
