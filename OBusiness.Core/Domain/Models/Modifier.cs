using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{
    [BsonIgnoreExtraElements]
    public class Modifier
    {
        
        public bool? IsAutoSel { get; set; }
        
        public string Code { get; set; }
        
        public string DisplayName { get; set; }
        
        public int DisplayOrder { get; set; }
        
        public int Status { get; set; }
        
        public int ID { get; set; }    
        public string LinkedProductId { get; set; }
        
        public string Name { get; set; }
        
        public double Price { get; set; }
        
        public double? TaxRate { get; set; }
       
        public string PhotoURL { get; set; }
        
        public int? MinQty { get; set; } = 0;
        
        public int? MaxQty { get; set; } = 0;


    }
}
