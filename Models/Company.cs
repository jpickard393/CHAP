using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CHAP.Models
{
    [JsonObject]
    public class Company
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("undeliverable_registered_office_address")]
        public bool UndeliverableRegisteredOfficeAddress { get; set; }

        [JsonProperty("registered_office_address")]
        public RegisteredOfficeAddress RegisteredOfficeAddress { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("annual_return")]
        public AnnualReturn AnnualReturn { get; set; }

        [JsonProperty("date_of_creation")]
        public string DateOfCreation { get; set; }

        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("last_full_members_list_date")]
        public string LastFullMembersListDate { get; set; }

        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("has_been_liquidated")]
        public bool HasBeenLiquidated { get; set; }

        [JsonProperty("accounts")]
        public Accounts Accounts { get; set; }

        [JsonProperty("has_insolvency_history")]
        public bool HasInsolvencyHistory { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("has_charges")]
        public bool HasCharges { get; set; }

        [JsonProperty("company_status")]
        public string CompanyStatus { get; set; }

        [JsonProperty("confirmation_statement")]
        public ConfirmationStatement ConfirmationStatement { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("registered_office_is_in_dispute")]
        public bool RegisteredOfficeIsInDispute { get; set; }

        [JsonProperty("can_file")]
        public bool CanFile { get; set; }
    }


    public class AccountingReferenceDate
    {
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }
    }

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

    public class AnnualReturn
    {
        [JsonProperty("last_made_up_to")]
        public string LastMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
    }

    public class ConfirmationStatement
    {
        [JsonProperty("next_due")]
        public string NextDue { get; set; }

        [JsonProperty("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }
    }

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

    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("filing_history")]
        public string FilingHistory { get; set; }

        [JsonProperty("officers")]
        public string Officers { get; set; }

        [JsonProperty("charges")]
        public string Charges { get; set; }

        [JsonProperty("insolvency")]
        public string Insolvency { get; set; }
    }

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

    public class RegisteredOfficeAddress
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }
    }

}

