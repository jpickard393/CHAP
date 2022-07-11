using Newtonsoft.Json;

namespace CHAP.Models
{
    public class NextAccounts
    {
        [JsonProperty("overdue")]
        public bool Overdue { get; set; }

        [JsonProperty("period_start_on")]
        public string PeriodStartOn { get; set; }

        [JsonProperty("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }
    }

}

