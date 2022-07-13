using System;
using Newtonsoft.Json;
namespace CHAP.Models.AdvancedSearch
{
    public class TopHit
    {
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("company_number")]
        public string? CompanyNumber { get; set; }

        [JsonProperty("company_status")]
        public string? CompanyStatus { get; set; }

        [JsonProperty("company_type")]
        public string? CompanyType { get; set; }

        [JsonProperty("kind")]
        public string? Kind { get; set; }

        [JsonProperty("links")]
        public Links? Links { get; set; }

        [JsonProperty("date_of_creation")]
        public string? DateOfCreation { get; set; }

        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress? RegisteredOfficeAddress { get; set; }

        [JsonProperty("sic_codes")]
        public List<string>? SicCodes { get; set; }
    }
}

