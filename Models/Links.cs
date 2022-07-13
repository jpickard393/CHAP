using Newtonsoft.Json;

namespace CHAP.Models
{
    public class Links
    {
        [JsonProperty("self")]
        public string? Self { get; set; }

        [JsonProperty("filing_history")]
        public string? FilingHistory { get; set; }

        [JsonProperty("officers")]
        public string? Officers { get; set; }

        [JsonProperty("charges")]
        public string? Charges { get; set; }

        [JsonProperty("insolvency")]
        public string? Insolvency { get; set; }

        [JsonProperty("company_profile")]
        public string? CompanyProfile { get; set; }
    }

}

