using System;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{
    public class Coupon : IEquatable<Coupon>
    {
        public Coupon()
        {
            CouponCategory = new List<CouponCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Balance { get; set; } = 0;
        public string CouponAccess { get; set; }
        public List<CouponCategory> CouponCategory { get; set; }
        public string CouponCode { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public double? FreeDollar { get; set; } = 0;
        public bool? IsActive { get; set; }
        public bool? IsFreeShipping { get; set; }
        public bool? IsRedeemed { get; set; }
        public bool? IsTemplate { get; set; }
        public int? MaxUsage { get; set; } = 0;
        public double? MinSpent { get; set; } = 0;
        public double? PercentageValue { get; set; } = 0;
        public string Product { get; set; }

        public string ProductTitle { get; set; }

        public int? MinimumQuantity { get; set; }

        public int? MaximumQuantity { get; set; }
        //do not map
        public bool IsUsed { get; set; } = false;
        public string Discount => PercentageValue.HasValue && PercentageValue.Value != 0 ? $"{PercentageValue}% {Name}" : $"${FreeDollar} {Name}";
        public bool Equals(Coupon other)
        {
            return Id == other.Id;
        }
    }
    public class CouponCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
    
}
