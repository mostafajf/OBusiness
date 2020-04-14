using System;

namespace OBusiness.Core.Domain.Models
{
    public class Promotion : IEquatable<Promotion>
    {
        public Promotion()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public PromotionType PromotionType { get; set; }

        public bool Deletable => PromotionType == PromotionType.Coupon;

        public bool Equals(Promotion other)
        {
            return Id == other.Id;
        }
    }

    public enum PromotionType
    {
        Coupon = 1,
        PriceTrigger = 2
    }
}
