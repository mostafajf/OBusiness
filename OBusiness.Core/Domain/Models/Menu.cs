using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string StoreId { get; set; }
        public MenuDoc Doc { get; set; }

    }
    public class MenuDoc
    {
        public List<Category> Categories { get; set; }
        public Dictionary<string, Category> SpecialCategories { get; set; }
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public Dictionary<string, Product> Products { get; set; }

        public Dictionary<string, ModifierGroup> ModifierGroups { get; set; }
    }

}
