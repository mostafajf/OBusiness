namespace OBusiness.Core.Domain.TrackingOrderModels
{
    public class PaymentTransactionModel
    {
        public double Amount { get; set; }
        public string CustomerReceipt { get; set; }
        public string TransactionId { get; set; }
        public int IsRefund { get; set; }
        public string ReferenceNumber { get; set; }
        public int CreditAccountId { get; set; }
        public int SignatureRequired { get; set; }
        public string TransactionReference { get; set; }
        public string CardType { get; set; }
        public string UniqueID { get; set; }
        public string TransactionTime { get; set; }
        public string AuthorisationCode { get; set; }
        public string PaymentMethod { get; set; }
        public string ElidedPan { get; set; }
        public string RetrievalReferenceNumber { get; set; }
        public string MerchantReceipt { get; set; }
        public int PaymentType { get; set; }
        public int ProviderType { get; set; }
        public int Status { get; set; }
     
        public string PaymentTransactionDescription { get; set; }
    }
}
