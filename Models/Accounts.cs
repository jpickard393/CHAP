using Newtonsoft.Json;

namespace CHAP.Models
{
    public class Accounts
    {
        [JsonProperty("last_accounts")]
        public LastAccounts LastAccounts { get; set; }

        [JsonProperty("next_accounts")]
        public NextAccounts NextAccounts { get; set; }

        [JsonProperty("accounting_reference_date")]
        public AccountingReferenceDate AccountingReferenceDate { get; set; }

        [JsonProperty("next_due")]
        public string NextDue { get; set; }

        [JsonProperty("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
    }

}

