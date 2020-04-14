namespace OBusiness.Core.Domain.Models
{

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
        
        public double TaxRate { get; set; }
       
        public string PhotoUrl { get; set; }
        
        public int MinQty { get; set; } = 0;
        
        public int MaxQty { get; set; } = 0;


    }
}
