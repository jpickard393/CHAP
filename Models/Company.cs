using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CHAP.Models
{
    [JsonObject]
    public class Company
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("undeliverable_registered_office_address")]
        public bool UndeliverableRegisteredOfficeAddress { get; set; }

        [Display(Name = "Registered Office Address")]
        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress? RegisteredOfficeAddress { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("annual_return")]
        public AnnualReturn? AnnualReturn { get; set; }

        [Display(Name = "Date of Creation")]
        [JsonProperty("date_of_creation")]
        public string? DateOfCreation { get; set; }

        [Display(Name = "Company Number")]
        [JsonProperty("company_number")]
        public string? CompanyNumber { get; set; }

        [Display(Name = "Company Name")]
        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("last_full_members_list_date")]
        public string? LastFullMembersListDate { get; set; }

        [JsonProperty("jurisdiction")]
        public string? Jurisdiction { get; set; }

        [Display(Name = "Has Been Liquidated")]
        [JsonProperty("has_been_liquidated")]
        public bool HasBeenLiquidated { get; set; }

        [JsonProperty("accounts")]
        public Accounts? Accounts { get; set; }

        [Display(Name = "Has Insolvancy History")]
        [JsonProperty("has_insolvency_history")]
        public bool HasInsolvencyHistory { get; set; }

        [JsonProperty("etag")]
        public string? Etag { get; set; }

        [JsonProperty("has_charges")]
        public bool HasCharges { get; set; }

        [Display(Name = "Company Status")]
        [JsonProperty("company_status")]
        public string? CompanyStatus { get; set; }

        [JsonProperty("confirmation_statement")]
        public ConfirmationStatement? ConfirmationStatement { get; set; }

        [JsonProperty("links")]
        public Links? Links { get; set; }

        [Display(Name = "Registerd Office In Dispute")]
        [JsonProperty("registered_office_is_in_dispute")]
        public bool RegisteredOfficeIsInDispute { get; set; }

        [JsonProperty("can_file")]
        public bool CanFile { get; set; }
    }

}

