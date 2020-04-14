namespace OBusiness.Core.Domain.TrackingOrder
{
    public class TrackingOrderModel
    {
        public TrackingOrderModel()
        {
            Order = new OrderModel();    
        }
        public int CompanyId { get; set; }
        public OrderModel Order { get; set; }        
        public string AccessToken { get; set; }
        public int? UserId { get; set; }
        public string AppName { get; set; }
        public string AppType { get; set; }
     
    }
}
