using OBusiness.Core.Domain.Enums;
using System;
using System.Collections.Generic;

namespace OBusiness.Core.Domain.Models
{
    
    public class Store
    {
        
        public string ID { get; set; }
        
        public string Name { get; set; }
        
        public string DeliveryRules { get; set; }
        
        public string TimezoneIanaFormat { get; set; }
        
        public string QRTemplate { get; set; }
        
        public string Website { get; set; }      
        
        public string IntroImage { get; set; }
        
        public string ProfileImage { get; set; }
        
        public bool ChargeToRoom { get; set; }
        public string ClosingStoreMessage { get; set; }        
      
        
        public string Company_Id { get; set; }
        
        public string ContactEmail { get; set; }
        
        public string Logo { get; set; }
        
        public string MobilePhone { get; set; }
        
        public string OfficePhone { get; set; }
        
        public int DisplayOrder { get; set; }
        
        public int OrderPreparationTime { get; set; }
        
        public bool IsEnabled { get; set; }
        
        public bool IsHQ { get; set; }
        
        public bool IsInOperation { get; set; }
        
        public bool IsTest { get; set; }
        
        public Location Location { get; set; }
        
        public List<OperatingHours> OperatingHours { get; set; }
        
        public List<MenuTimeSetting> MenuTimeSettings { get; set; }        

  
        
        public List<DeliveryArea> DeliveryAreas { get; set; }
        
        public string PaymentConfigEnvironment { get; set; }
        
        public string RegistrationNumber { get; set; }
        
        public string StoreTitle { get; set; }
        
        public string TimezoneCity { get; set; }
        
        public int PointsToDollarRatio { get; set; }
        
        public bool IsEarnPointsWhenRedeem { get; set; }
        
        public List<EarningRule> EarningRules { get; set; } = new List<EarningRule>();
        
        public List<RedemptionRule> RedemptionRules { get; set; }
        
        public Dictionary<string, PriceTrigger> PriceTriggers { get; set; }
        
        public ThemeSettings ThemeSettings { get; set; }

        public void CopyFrom(Store store)
        {
            ID = store.ID;
            Name = store.Name;
            DeliveryRules = store.DeliveryRules;
            DeliveryAreas = store.DeliveryAreas;
            TimezoneIanaFormat = store.TimezoneIanaFormat;
            QRTemplate = store.QRTemplate;
            Website = store.Website;           
            IntroImage = store.IntroImage;
            ProfileImage = store.ProfileImage;
            ChargeToRoom = store.ChargeToRoom;
            ClosingStoreMessage = store.ClosingStoreMessage;            
            Company_Id = store.Company_Id;
            ContactEmail = store.ContactEmail;
            Logo = store.Logo;
            MobilePhone = store.MobilePhone;
            OfficePhone = store.OfficePhone;
            DisplayOrder = store.DisplayOrder;
            OrderPreparationTime = store.OrderPreparationTime;
            IsEnabled = store.IsEnabled;
            IsHQ = store.IsHQ;
            IsInOperation = store.IsInOperation;
            IsTest = store.IsTest;
            Location = store.Location;
            OperatingHours = store.OperatingHours;
            MenuTimeSettings = store.MenuTimeSettings;       
            PaymentConfigEnvironment = store.PaymentConfigEnvironment;
            RegistrationNumber = store.RegistrationNumber;
            StoreTitle = store.StoreTitle;
            TimezoneCity = store.TimezoneCity;
            PointsToDollarRatio = store.PointsToDollarRatio;
            IsEarnPointsWhenRedeem = store.IsEarnPointsWhenRedeem;
            EarningRules = store.EarningRules;
            RedemptionRules = store.RedemptionRules;
            PriceTriggers = store.PriceTriggers;
            ThemeSettings = store.ThemeSettings;
        }
    }

    
    public class ThemeSettings
    {    
        
    
    }
    
   
    public class DeliveryArea
    {
        
        public string PostcodeFrom { get; set; }
        
        public string PostcodeTo { get; set; }
    }
    
    public class MenuTimeSetting
    {
        
        public string DayOfWeek { get; set; }
        
        public string StartTime { get; set; }
        
        public string Endtime { get; set; }
        
        public string MenuType { get; set; }
    }

    
    
    public class EarningRule
    {
        
        public bool Disabled { get; set; }
        
        public int DollarSpent { get; set; }
        
        public dynamic ExpiredDate { get; set; }
        
        public int Point { get; set; }
        
        public int RewardPointRuleId { get; set; }
    }

    
    public class RedemptionRule
    {
        
        public bool Disable { get; set; }
        
        public int? DiscountAmount { get; set; }
        
        public int? DiscountRate { get; set; }
        
        public int DollarSpend { get; set; }
        
        public dynamic ExpiredDate { get; set; }
        
        public bool IsDiscountExcludeVariants { get; set; }
        
        public bool IsHQ { get; set; }
        
        public string Name { get; set; }
        
        public int Point { get; set; }
        
        public int ProductVariant { get; set; }
        
        public int RewardPointId { get; set; }
        
        public string UniqueCode { get; set; }
        
        public List<int> Categories { get; set; }
        
        public List<int> Tags { get; set; }
    }

    
    public class PriceTrigger
    {
   
        public int ID { get; set; }
        
        public int DiscountFlatValue { get; set; }
        
        public float DiscountPercentageValue { get; set; }
        
        public dynamic EndAt { get; set; }
        public DateTime? EndAtDatetime { get; set; }
        
        public dynamic StartAt { get; set; }
        public DateTime? StartAtDatetime { get; set; }
        
        public int? FixedPriceValue { get; set; }
        
        public bool IsDisabled { get; set; }
        
        public bool IsMostExpensiveFirst { get; set; }
        
        public bool IsOutcomeLinkedToProduct { get; set; }
        
        public string MembershipLevelID { get; set; }
        
        public int? MinimumSpend { get; set; }
        
        public string Name { get; set; }
        
        public bool NotApplicableWithCoupon { get; set; }
        
        public OrderType? OrderType { get; set; }
        
        public OutcomePriceType OutcomePriceType { get; set; }
        
        public OutcomeType? OutcomeType { get; set; }
        
        public int Priority { get; set; }
        
        public TriggerMode TriggerMode { get; set; }
        
        public RunType RunType { get; set; }
        
        public List<ProductCategoryCondition> ProductCategoryConditions { get; set; }
        
        public List<ProductTagCondition> ProductTagConditions { get; set; }
        
        public List<string> CustomerTags { get; set; }
        
        public List<ProductOutcome> ProductOutcomes { get; set; }
        
        public List<ProductCategoryCondition> ProductOutcomesCategory { get; set; }
        
        public List<ProductTagCondition> ProductTagOutcomes { get; set; }

        public Guid OrderUID { get; set; }
        public PriceTriggerType? PriceTriggerType { get; set; }
        public int? AppliedQuantity { get; set; }
        public double? AppliedDiscount { get; set; }
        public string ProductID { get; set; }
      

        public PriceTrigger Clone()
        {
            return new PriceTrigger
            {
                ID = this.ID,
                AppliedQuantity = this.AppliedQuantity,
                CustomerTags = this.CustomerTags,
                DiscountFlatValue = this.DiscountFlatValue,
                DiscountPercentageValue = this.DiscountPercentageValue,
                EndAt = this.EndAt,
                FixedPriceValue = this.FixedPriceValue,
                IsDisabled = this.IsDisabled,
                IsMostExpensiveFirst = this.IsMostExpensiveFirst,
                IsOutcomeLinkedToProduct = this.IsOutcomeLinkedToProduct,
                MembershipLevelID = this.MembershipLevelID,
                MinimumSpend = MinimumSpend,
                Name = Name,
                NotApplicableWithCoupon = NotApplicableWithCoupon,
                OrderUID = OrderUID,
                OrderType = OrderType,
                OutcomePriceType = OutcomePriceType,
                OutcomeType = OutcomeType,
                Priority = Priority,
                ProductCategoryConditions = ProductCategoryConditions,
                ProductOutcomes = ProductOutcomes,
                ProductOutcomesCategory = ProductOutcomesCategory,
                ProductTagConditions = ProductTagConditions,
                ProductTagOutcomes = ProductTagOutcomes,
                RunType = RunType,
                StartAt = StartAt,
                TriggerMode = TriggerMode,
                PriceTriggerType = PriceTriggerType,
                AppliedDiscount = AppliedDiscount,
                ProductID = ProductID
            };
        }
    }

    
    public class ProductCategoryCondition
    {
        
        public string ProductCategoryID { get; set; }
        
        public int Quantity { get; set; }
    }

    
    public class ProductTagCondition
    {
        
        public string ProductTagID { get; set; }
        
        public int Quantity { get; set; }
    }

    
    public class ProductOutcome
    {
        
        public string ProductID { get; set; }
        
        public int Quantity { get; set; }
    }
  
}
