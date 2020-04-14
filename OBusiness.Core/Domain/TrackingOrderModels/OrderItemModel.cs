using System.Collections.Generic;

namespace OBusiness.Core.Domain.TrackingOrderModels
{
    public class OrderItemModel
    {
        public string DateCreated { get; set; }

        public List<ExtraModel> Extras { get; set; } = new List<ExtraModel>();

        public ProductModel Product { get; set; } = new ProductModel();

        public string ProductCode { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public int Status { get; set; }

        public double SubTotalExclTax { get; set; }

        public double SubTotalInclTax { get; set; }

        public double GstAmount { get; set; }

        public string UniqueCode { get; set; }

        public int OrderItemId { get; set; } = 0;

        public bool IsPrinted { get; set; } = false;
    }

    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
