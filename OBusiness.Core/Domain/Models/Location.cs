namespace OBusiness.Core.Domain.Models
{

    public class Location
    {
        
        public string Address { get; set; }
        
        public string Country { get; set; }
        
        public string State { get; set; }
        
        public string Suburb { get; set; }
        
        public string Postcode { get; set; }
        
        public double? Latitude { get; set; }
        
        public double? Longitude { get; set; }
    }
}
