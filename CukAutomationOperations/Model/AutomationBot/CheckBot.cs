using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model.AutomationBot
{
    public class CheckBot
    {
        public string RuleSetID { get; set; }
        public string Description { get; set; }
        public string ProcessingOrder { get; set; }
        public string AutomationLevel { get; set; }
        public string CountryOffice { get; set; }
        public string ApplicationSource { get; set; }
        public string SupporterType { get; set; }
        public string NewSupporter { get; set; }
        public string IsUnique { get; set; }
        public string ExistingCommitments { get; set; }
        public string UpdatesApplied { get; set; }
        public string SupporterNameStatus { get; set; }
        public string DigitalChoice { get; set; }
        public string CountryOfResidence { get; set; }
        public string PostalAddressStatus { get; set; }
        public string PhoneNumberStatus { get; set; }
        public string EmailAddressStatus { get; set; }
        public string PaymentMethod { get; set; }
        public string BankAccountStatus { get; set; }
        public string AnnualGifts { get; set; }
        public string GiftAidStatus { get; set; }
        public string VulnerableCircumstances { get; set; }
        public string SafeguardingConcern { get; set; }
        public string SupporterLinked { get; set; }
        public string SupporterStatus { get; set; }
        public string ChildAvailability { get; set; }
        public string ReadyForSetup { get; set; }
        public string MatchedOn { get; set; }
        public string PartnerOffice { get; set; }
        public string SponsorshipPlus { get; set; }
        public string YearofBirth { get; set; }
        public string Source { get; set; }
        public string DDPaymentChecks { get; set; }
        public IncidentThreadText ThreadObjects { get; set; }
    }

    public class CheckBotCompareModel
    {
        public string CountryOffice { get; set; }
        public string ApplicationSource { get; set; }
        public string SupporterType { get; set; }
        public string NewSupporter { get; set; }
        public string IsUnique { get; set; }
        public string ExistingCommitments { get; set; }
        public string UpdatesApplied { get; set; }
        public string SupporterNameStatus { get; set; }
        public string DigitalChoice { get; set; }
        public string CountryOfResidence { get; set; }
        public string PostalAddressStatus { get; set; }
        public string PhoneNumberStatus { get; set; }
        public string EmailAddressStatus { get; set; }
        public string PaymentMethod { get; set; }
        public string BankAccountStatus { get; set; }
        public string SponsorshipPlus { get; set; }
        public string AnnualGifts { get; set; }
        public string GiftAidStatus { get; set; }
        public string VulnerableCircumstances { get; set; }
        public string SafeguardingConcern { get; set; }
        public string SupporterLinked { get; set; }
        public string SupporterStatus { get; set; }
        public string ChildAvailability { get; set; }
    }

    public class IncidentThreadText
    {
        public string SupporterTitle { get; set; }
        public string SupporterId { get; set; }
        public string SupporterName { get; set; }
        public string SupporterFirstName { get; set; }
        public string SupporterLastName { get; set; }
        public string SupporterEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string TelephoneNumber { get; set; }
        public string Source { get; set; }
        public string Birthday { get; set; }
        public string Christmas { get; set; }
        public string Howcompassionshouldaddress { get; set; }
        public string NewSupporter { get; set; }
        public string RNIDMatch { get; set; }
        public string YearofBirth { get; set; }

        public string AddressEntryMethod { get; set; }
        public string AddressChanged { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
        public string Category { get; set; }
        public string SupporterType { get; set; }
        public string SupporterNameStatus { get; set; }
        public string SponsorshipPath { get; set; }
        public string BasedOnCommitment { get; set; }
        public string NameChanged { get; set; }
        public string EmailAddressChanged { get; set; }
        public string TelephoneNumberChanged { get; set; }
        public string YearOfBirthChanged { get; set; }
        public string ChangesToMakeComment { get; set; }
    }

    public class IncidentData
    {
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ThreadText { get; set; }
        public IncidentThreadText ThreadData { get; set; }
        public string Category { get; set; }
        public string giftaidstatus { get; set; }
        public string supportertype { get; set; }
        public string country { get; set; }
        public string sponsorshipplus { get; set; }
        public string NeedKey { get; set; }
        public string sponsorshipplustype { get; set; }
        public string bankaccountstatus { get; set; }
        public string newsupporter { get; set; }
        public string updatesapplied { get; set; }
        public string SetupStatus { get; set; }
        public long ContactId { get; set; }
        public string internalsubject { get; set; }
        public DateTime createdTime { get; set; }
    }

    public class SupporterPreferences
    {
        public string Comments { get; set; }
        public string Post { get; set; }
        public string Type { get; set; }
    }

    public class Supporter
    {
        public long SupporterId { get; set; }
        public string Status { get; set; }
        public string safeguarding_concern { get; set; }
        public int bannerflagid { get; set; }
    }


    public class ReadyBotRulesConfiguration
    {
        public string RuleSetID { get; set; }
        public string AutomationLevel { get; set; }
    }

}

