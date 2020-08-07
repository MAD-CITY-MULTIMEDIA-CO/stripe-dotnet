namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsCustomField : StripeEntity<CustomerInvoiceSettingsCustomField>
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
