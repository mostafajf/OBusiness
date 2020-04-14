namespace OBusiness.Core.Domain.TrackingOrderModels
{
    public class ProductModel
    {
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string PhotoUrl { get; set; }
        public string PrintName { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public int Status { get; set; } = 1;
        public double TaxRate { get; set; }

    }
}
