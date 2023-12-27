using CukAutomationOperations.RightNowServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class AdvanceNotice
    {
        public int RecordID { get; set; }
        public string RevenueID { get; set; }
        public string LookupID { get; set; }
        public string DirectDebitAccountNo { get; set; }
        public string DirectDebitReferenceNo { get; set; }
        public string TriggerType { get; set; }
        public string Office { get; set; }
        public string Frequency { get; set; }
        public decimal Amount { get; set; }
        public string Designation { get; set; }
        public string PreferredChildName { get; set; }
        public string BatchNo { get; set; }
        public string CollectionDate { get; set; }
        public string IncidentId { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public string AdvanceNoticeDateSent { get; set; }
        public string RevenueRecordID { get; set; }
        public string PaymentMethod { get; set; }
        public string NeedKey { get; set; }
        public string EnquiryCreatedTime { get; set; }
    }

    public class AdvanceNoticeTemplate
    {
        public string Office { get; set;}
        public int TemplateID { get; set; }
        public string ProcessType { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }
        public string EmailTemplate { get; set; }
        public string LetterTemplate { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
    }

    public class AdvanceNoticeContact
    {
        public long ContactID { get; set; }
        public string EmailValidated { get; set; }
        public string LetterSalutation { get; set; }
        public string AddressSalutation { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string street3 { get; set; }
        public string street4 { get; set; }
        public string street5 { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string postcode { get; set; }
        public string POBox { get; set; }
        public string Undeliverable { get; set; }

        public string SupporterGroupAddressSalutation { get; set; }
        public OrganisationDetails OrgData { get; set; }
    }

    public class OrganisationDetails
    {
        public long PrioritySupporterId { get; set; }
        public long OrgId { get; set; }
        public string name { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string street3 { get; set; }
        public string street4 { get; set; }
        public string street5 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string postcode { get; set; }
        public string undeliverable { get; set; }
        public string POBox { get; set; }
        public string SupporterGroupAddressSalutation { get; set; }
    }
    public class AdvanceNoticeIncident
    {
        public long ContactID { get; set; }
        public string CampaignFormType { get; set; }
        public List<AdvanceNoticeDonationDetails> DonationList {get;set;}
        public int RecordId { get; set; }
        public string lookupid { get; set; }
        public string Template { get; set; }
        public string Type { get; set; }
        public string TemplateType { get; set; }
        public string Office { get; set; }
        public string DDRef { get; set; }
    }

    public class AdvanceNoticeDonationDetails
    {
        public decimal Amount { get; set; }
        public string Designation { get; set; }
        public string PreferredChildName { get; set; }
        public int RecordId { get; set; }
        public string Currency { get; set; }
        public string AdvanceNoticeDateSent { get; set; }
        public string RevenueId { get; set; }
    }

    public class PdfResponce
    {
        public string Url { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }

    public class ReveneuData
    {
        public string RecordID { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class RateChangeEnquiriesForKingsline
    {
        public string LookupID { get; set; }
        public string DirectDebitAccountNo { get; set; }
        public string DirectDebitReferenceNo { get; set; }
        public string Office { get; set; }
        public string Frequency { get; set; }
        public string AggregateAmount { get; set; }
        public string Designation { get; set; }
        public string PreferredChildName { get; set; }
        public string NextCollectionDate { get; set; }
        public string EnquiryRefNo { get; set; }
        public string Currency { get; set; }
        public string AdvanceNoticeDateSent { get; set; }
        public string PaymentMethod { get; set; }
        public string NeedKey { get; set; }
        public string LetterSalutation { get; set; }
        public string AddressSalutation { get; set; }
        public string Address { get; set; }
        public string PaymentDetails { get; set; }
        public string RevenueIds { get; set; }
        public string RNID { get; set; }

        public string street1 { get; set; }
        public string street2 { get; set; }
        public string street3 { get; set; }
        public string street4 { get; set; }
        public string street5 { get; set; }
        public string city { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string postcode { get; set; }
        public string POBox { get; set; }
        public string Country { get; set; }
        public string DayOfInstallments { get; set; }
        public string ANCreatedDate { get; set; }
        public string Segment { get; set; }
        public int PaymentDetailsRowCount { get; set; }
    }
    public class RateChangeKingslineSuppressionList
    {
        public string RNID { get; set; }
        public string RevIDs { get; set; }
        public string EnquiryNo { get; set; }
        public string DDRef { get; set; }
        public string KingslineANListDate { get; set; }
    }
}
