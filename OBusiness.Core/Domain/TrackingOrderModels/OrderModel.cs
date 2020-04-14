using OBusiness.Core.Domain.TrackingOrderModels;
using System;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.TrackingOrder
{
    public class OrderModel
    {
        public string CreatedOn { get; set; }

        public List<OrderItemModel> Items { get; set; } = new List<OrderItemModel>();


        public List<CouponModel> Coupons { get; set; } = new List<CouponModel>();

        public int OrderId { get; set; }

        public int OrderNumber { get; set; }

        public int OrderType { get; set; }

        public int PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public int Status { get; set; } = 2;
        public double Subtotal { get; set; }
        public double Discount { get; set; }

        public double SubtotalExcludingTax { get; set; }
        public double DiscountFlatValue { get; set; }

        public double DiscountGst { get; set; }
        public double SubtotalOfTax { get; set; }
        public double DiscountExcludingGst { get; set; }
        public int TableID { get; set; }
        public string TableNo { get; set; }

        public string TableNumber { get; set; }

        public double TotalCost { get; set; }

        public double TotalTax { get; set; }
        public double TotalGst { get; set; }

        public double CashPayment { get; set; }
        public double CreditCardPayment { get; set; }
        public double Tax { get; set; }

        public String UniqueCode { get; set; }

        public List<PaymentTransactionModel> PaymentTransactions { get; } = new List<PaymentTransactionModel>();

        public List<Table> Tables { get; set; }

        public string ClerkNo { get; set; } = "1";
        public string DeviceUDID { get; set; }
        public decimal BankCardsSurcharge { get; set; } = 0;

        public decimal POSSurchargeOfTax { get; set; } = 0;

        public decimal POSSurchargeExcludingTax { get; set; } = 0;

        public decimal SurchargeAmount => BankCardsSurcharge + POSSurchargeExcludingTax + POSSurchargeOfTax;

        public decimal TipAmount { get; set; } = 0;

        public int ShouldDelete { get; set; } = 0;

        public string AdditionalMode { get; set; } = "1";

        public List<int?> RewardPointIDs { get; set; }

        public int RedeemPoints { get; set; }

        public string SupayTransactionId { get; set; }

        public string CustomerId { get; set; }
        public double RoundingExcludingTax { get; set; }
        public double RoundingOfTax { get; set; }
    }
}



