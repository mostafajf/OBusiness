using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;

namespace OBusiness.Core.Domain.Models
{

    public class Location
    {
        
        public string Address { get; set; }
        
        public string Country { get; set; }
        
        public string State { get; set; }
        
        public string Suburb { get; set; }
        
        public string Postcode { get; set; }
        [BsonElement("Location")]
        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Coordinate { get; set; }
    }
}
