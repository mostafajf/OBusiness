using System.Collections.Generic;
using System.Linq;
namespace OBusiness.Core.Dto
{
    public class ModifierDto
    {     
        public int ModifierGroupId { get; set; }
        public int? OldState { get; set; }
        public int Status { get; set; }
        public string Code { get; set; }

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }

        public string LinkedProductID { get; set; }

        public double Price { get; set; }

        public double? TaxRate { get; set; }

        public string PhotoUrl { get; set; }

        public List<ModifierGroupDto> SubModifiers { get; set; }        
        public ModifierGroupDto ModifierGroup { get; set; }
        public bool IsSingleSell => !(MaxQty >= MinQty && MaxQty > 1);
        public int? MinQty { get; set; } = 1;
        public int? MaxQty { get; set; } = 20;  

        public ModifierDto Clone(ModifierGroupDto modifierGroupVm)
        {
            return new ModifierDto
            {
                Code = Code,              
                DisplayName = DisplayName,
                DisplayOrder = DisplayOrder,
                ID = ID,
                LinkedProductID = LinkedProductID,
                MaxQty = MaxQty,
                MinQty = MinQty,
                ModifierGroup = modifierGroupVm,
                ModifierGroupId = int.Parse(modifierGroupVm.ID),
                Name = Name,
                OldState = OldState,              
                PhotoUrl = PhotoUrl,
                Price = Price,
                SubModifiers = SubModifiers.Select(s => s.Clone(s.Product)).ToList(),
                Status = Status,
                TaxRate = TaxRate
            };
        }
    }
}
