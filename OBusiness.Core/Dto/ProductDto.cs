using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;


namespace OBusiness.Core.Dto
{
    public class ProductDto
    {
        public ProductDto()
        {           
            UID = Guid.NewGuid();
        }
        public int ID { get; set; }
        public Guid UID { get; set; }
        public List<string> ProductCategoryIDs { get; set; }
        public List<string> ProductTagIDs { get; set; }
        public List<ModifierGroupDto> ModifierGroups { get; set; }
        public string DisplayOrder { get; set; }
        public string FullDescription { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string ProductCode { get; set; }
        public string ShortDescription { get; set; }
        public int Status { get; set; }
        public double TaxRate { get; set; }
        public double Price { get; set; }      
        public bool IsRedemption { get; set; } = false;   
        public ProductDto Clone()
        {
            var result = new ProductDto();
            result.ID = ID;
            result.DisplayOrder = DisplayOrder;
            result.FullDescription = FullDescription;
            result.Price = Price;
            result.Name = Name;
            result.IsRedemption = IsRedemption;
            result.ModifierGroups = ModifierGroups.Select(s => s.Clone(result)).ToList();
            result.PhotoUrl = PhotoUrl;
            result.ProductCategoryIDs = ProductCategoryIDs;
            result.ProductCode = ProductCode;
            result.ProductTagIDs = ProductTagIDs;
            result.ShortDescription = ShortDescription;
            result.Status = Status;
            result.TaxRate = TaxRate;
            result.UID = UID;
            return result;
        }   
        
    }
}
