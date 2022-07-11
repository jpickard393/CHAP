using Newtonsoft.Json;

namespace CHAP.Models
{
    public class LastAccounts
    {
        [JsonProperty("made_up_to")]
        public string MadeUpTo { get; set; }

        [JsonProperty("period_start_on")]
        public string PeriodStartOn { get; set; }

        [JsonProperty("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}

