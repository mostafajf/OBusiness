using OBusiness.Core.Domain.Models;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.TrackingOrderModels
{
    public class CouponModel
    {
        public CouponModel()
        {
            ProductCategories = new List<CouponCategory>();
        }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public double? MinimumSpend { get; set; }
        public int Id { get; set; }
        public double? FreeDollar { get; set; }
        public double? Percentage { get; set; }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ExpiredDateStr { get; set; }
        public List<CouponCategory> ProductCategories { get; set; }
        
    }
}
