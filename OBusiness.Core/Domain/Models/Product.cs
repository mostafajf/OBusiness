using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{

    public class Product
    {
        
        public string DisplayOrder { get; set; }
        
        public string FullDescription { get; set; }
        
        public List<string> ModifierGroups { get; set; }
        
        public List<string> ProductCategoryNames { get; set; }
        public List<string> ProductCategoryIDs { get; set; }

        public List<string> ProductTagIDs { get; set; }
        
        public string Name { get; set; }
        
        public string PhotoUrl { get; set; }
        public string PhotoUrlCombinationImage { get; set; }
        public string RevenueGroup { get; set; }

        public string ProductCode { get; set; }
        
        public string ShortDescription { get; set; }
        
        public int? Status { get; set; }
        
        public double TaxRate { get; set; }
        public double RewardPoint { get; set; }

    }
}
