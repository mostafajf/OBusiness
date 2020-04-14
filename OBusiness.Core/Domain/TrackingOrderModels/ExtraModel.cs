using System.Collections.Generic;

namespace OBusiness.Core.Domain.TrackingOrderModels
{
    public class ExtraModel
    {
        public ExtraModel()
        {
            SubExtras = new List<ExtraModel>();
        }
        public int ExtraId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double PriceExclTax { get; set; }

        public string PrintName { get; set; }

        public int Quantity { get; set; }

        public List<ExtraModel> SubExtras { get; set; }

    }
}
