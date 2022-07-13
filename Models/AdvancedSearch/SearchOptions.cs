using System.ComponentModel.DataAnnotations;
namespace CHAP.Models.AdvancedSearch
{
    public class SearchOptions
    {
        [Display(Name = "Company name includes")]
        public string? company_name_includes { get; set; }

        [Display(Name = "Company name excludes")]
        public string? company_name_excludes { get; set; }

        [Display(Name = "Company status")]
        public string? company_status { get; set; }
    }
}

