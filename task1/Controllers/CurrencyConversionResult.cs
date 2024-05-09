namespace task1.Controllers
{
    internal class CurrencyConversionResult
    {
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public decimal Amount { get; set; }
        public dynamic ConvertedAmount { get; internal set; }
        public string ErrorMessage { get; internal set; }
    }
}