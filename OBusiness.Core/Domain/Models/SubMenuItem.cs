namespace OBusiness.Core.Domain.Models
{

    public class SubMenuItem
    {
        
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public double? Price { get; set; }
        
        public string ProductCode { get; set; }
        
        public int ProductID { get; set; }
    }
}