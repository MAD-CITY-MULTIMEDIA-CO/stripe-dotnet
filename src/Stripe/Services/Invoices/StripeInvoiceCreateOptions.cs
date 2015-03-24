﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe.Services.Invoices
{
    public class StripeInvoiceCreateOptions
    {
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [JsonProperty("description")]
        public bool Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("tax_percent")]
        public int? TaxPercent { get; set; }
    }
}