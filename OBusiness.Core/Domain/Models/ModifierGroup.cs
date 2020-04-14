using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{

    public class ModifierGroup
    {
        
        public int? DisplayOrder { get; set; } = 1000;
        
        public bool? Disabled { get; set; }
        
        public bool IsAutoSel { get; set; }
        
        public bool IsForceSel { get; set; }
        
        public bool IsSingleSel { get; set; }
        
        public string Name { get; set; }
        
        public bool? IsPromptSel { get; set; }
        
        public int? MaximumSelection { get; set; }
        
        public List<Modifier> Modifiers { get; set; }
        
        public int? MinimumSelection { get; set; }
        
        public bool IncludeQuantity { get; set; }
        
        public bool? IsCollapsed { get; set; } = false;
    }
}
