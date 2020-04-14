using System.Collections.Generic;
using System.Linq;
namespace OBusiness.Core.Dto
{
    public class ModifierGroupDto
    {
        public ModifierGroupDto()
        {          
            ModifiersList = new List<ModifierDto>();          
        }

        public int? DisplayOrder { get; set; } = 1000;
        public bool Selected { get; set; }
        public string ID { get; set; }
        public bool IsAutoSel { get; set; }
        public bool IsForceSel { get; set; }
        public bool IsSingleSel { get; set; }
        public string Name { get; set; }
        public bool IsPromptSel { get; set; }
        public bool IsSeen { get; set; }
        public bool IsCollapsed { get; set; }
        public bool IncludeQuantity { get; set; }
        public int? MaximumSelection { get; set; }
        public int? MinimumSelection { get; set; }
        public int SelectionCount { get; set; }  
        public ModifierDto ParentModifier { get; set; }
        public List<ModifierDto> ModifiersList { get; set; }
        public ProductDto Product { get; set; }
        public ModifierGroupDto Clone(ProductDto productVm)
        {
            var res = new ModifierGroupDto();
            res.ID = ID;
            res.IncludeQuantity = IncludeQuantity;
            res.IsAutoSel = IsAutoSel;
            res.IsForceSel = IsForceSel;
            res.IsPromptSel = IsPromptSel;
            res.IsSeen = IsSeen;
            res.IsSingleSel = IsSingleSel;          
            res.MaximumSelection = MaximumSelection;       
            res.MinimumSelection = MinimumSelection;
            res.ModifiersList = ModifiersList.Select(s => s.Clone(res)).ToList();
            res.Name = Name;
            res.ParentModifier = ParentModifier;
            res.Product = productVm;
            res.Selected = Selected;
            res.SelectionCount = SelectionCount;     
            return res;
        }
    }
}
