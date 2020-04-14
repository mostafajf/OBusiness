namespace OBusiness.Core.Domain.Enums
{
    public enum TriggerMode
    {
        TriggerAutomatically = 0, // : If the condition is valid, this Price Trigger will be applied automatically, 
        TriggerWithConfirm = 1, // If the condition is valid, system will pop up to user about if we need to apply theTriggerWithConfirm Price Trigger or not. 
        TriggerManually = 2, // We won't check this type of price trigger unless user want to apply this priceTriggerManually trigger. 
        TriggerCheckOutPageInOnlineOrderingApp = 3, //Only online ordering app using this Price Trigger, This Price Trigger is applied in the check out page, Like, to give one free water at the check out page. 
        TriggerFirstOrderInOnlineOrderingApp = 4, // Only online ordering app using this Price Trigger, This Price Trigger is applied in the check out page, Like, to give discount for the first order
    }

    public enum RunType
    {
        TypeUndefined = 0,// Something Wrong???? 
        RunOnce = 1,// We only run this Price Trigger one time for one order.
        RunMultiple = 2 // We will run this Price Trigger as many as we could as long as we could meet the conditions.
    }

    public enum OutcomePriceType
    {
        FlatDiscount = 0,
        PercentageDiscount = 1,
        FixedPrice = 2,
        FreeUpToValue = 3,
    }

    public enum OutcomeType
    {
        Default = 0,
        Products = 1,
        FromCategories = 2,
        FromTags = 3,
        Categories = 4,
        Tags = 5
    }

    public enum OrderType
    {
        OrderTypeEatIn = 2,
        OrderTypeTakeaway = 3,
        OrderTypeBuzzer = 9,
        OrderTypeDelivery = 10
    }
    public enum PriceTriggerType
    {
        wholeOrderDiscountPriceTriggers = 0,
        rollIntoMealPriceTriggers = 1,
        perItemDiscountPriceTriggers = 2
    }
}
