using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class RevenuePayment
    {
        public string odatametadata { get; set; }
        public Value[] value { get; set; }
        public string odatacount { get; set; }
    }

    public class CSVModel
    {
        public string Amount { get; set; }

        [Name("Revenue ID")]
        public string RevenueID { get; set; }

        [Name("Advance notice sent date")]
        public string Advancenoticesentdate { get; set; }

        [Name("Inbound channel")]
        public string Inboundchannel { get; set; }

        [Name("Constituent\\Lookup ID")]
        public string ConstituentLookupID { get; set; }

        [Name("Pledge\\Grant award first installment due")]
        public string PledgeGrantawardfirstinstallmentdue { get; set; }

        [Name("Direct debit reference number")]
        public string Directdebitreferencenumber { get; set; }

        [Name("Direct Debit Account\\Account number (masked)")]
        public string DirectDebitAccountAccountnumbermasked { get; set; }

        [Name("Application Details\\Designation\\Public name")]
        public string ApplicationDetailsDesignationPublicname { get; set; }

        [Name("Child\\Child\\Preferred Child Name Attribute\\Value")]
        public string ChildChildPreferredChildNameAttributeValue { get; set; }

        [Name("Constituent\\Assigned Security Groups\\Security group name")]
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }

        [Name("Child\\Child\\First name")]
        public string ChildChildFirstname { get; set; }



    }

    public class OneOffBackUp
    {
        public string BUSINESSPROCESSOUTPUT_PKID { get; set; }
        public string Amount { get; set; }

        [Name("Revenue ID")]
        public string RevenueID { get; set; }

        [Name("Advance notice sent date")]
        public string Advancenoticesentdate { get; set; }

        [Name("Inbound channel")]
        public string Inboundchannel { get; set; }

        [Name("Constituent\\Lookup ID")]
        public string ConstituentLookupID { get; set; }

        [Name("Pledge/Grant award first installment due")]
        public string PledgeGrantawardfirstinstallmentdue { get; set; }

        [Name("Direct debit reference number")]
        public string Directdebitreferencenumber { get; set; }

        [Name("Direct Debit Account\\Account number")]
        public string DirectDebitAccountAccountnumbermasked { get; set; }

        [Name("Application Details\\Designation\\Public name")]
        public string ApplicationDetailsDesignationPublicname { get; set; }

        [Name("Child\\Child\\Preferred Child Name Attribute\\Value")]
        public string ChildChildPreferredChildNameAttributeValue { get; set; }

        [Name("Constituent\\Assigned Security Groups\\Security group name")]
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }

        [Name("Child\\Child\\Preferred Child Name Attribute\\Value")]
        public string ChildChildFirstname { get; set; }



    }

    public class OneOff
    {
        public string BUSINESSPROCESSOUTPUT_PKID { get; set; }
        public string Amount { get; set; }

        [Name("Revenue ID")]
        public string RevenueID { get; set; }

        [Name("Advance notice sent date")]
        public string Advancenoticesentdate { get; set; }

        [Name("Inbound channel")]
        public string Inboundchannel { get; set; }

        [Name("Constituent\\Lookup ID")]
        public string ConstituentLookupID { get; set; }

        [Name("Collection Date")]
        public string PledgeGrantawardfirstinstallmentdue { get; set; }

        [Name("Direct debit reference number")]
        public string Directdebitreferencenumber { get; set; }

        [Name("Installment frequency")]
        public string Installmentfrequency { get; set; }

        [Name("Direct Debit Account\\Account number (masked)")]
        public string DirectDebitAccountAccountnumbermasked { get; set; }

        [Name("Application Details\\Designation\\Public name")]
        public string ApplicationDetailsDesignationPublicname { get; set; }

        [Name("Constituent\\Assigned Security Groups\\Security group name")]
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }

        [Name("Child\\Child\\First name")]
        public string ChildChildFirstname { get; set; }

        [Name("Sponsorships\\Sponsorship Opportunity\\Child\\First name")]
        public string ChildPreferredName { get; set; }

        [Name("Payment method")]
        public string PaymentMethod { get; set; }

        [Name("System record ID")]
        public string RevenueRecordID { get; set; }
    }
    public class RecurringGift
    {
        public string BUSINESSPROCESSOUTPUT_PKID { get; set; }
        public string Amount { get; set; }

        [Name("Revenue ID")]
        public string RevenueID { get; set; }

        [Name("Advance notice sent date")]
        public string Advancenoticesentdate { get; set; }

        [Name("Inbound channel")]
        public string Inboundchannel { get; set; }

        [Name("Constituent\\Lookup ID")]
        public string ConstituentLookupID { get; set; }

        [Name("Collection Date")]
        public string Recurringgiftnexttransactiondate { get; set; }

        [Name("Direct debit reference number")]
        public string Directdebitreferencenumber { get; set; }

        [Name("Direct Debit Account\\Account number (masked)")]
        public string DirectDebitAccountAccountnumbermasked { get; set; }

        [Name("Application Details\\Designation\\Public name")]
        public string ApplicationDetailsDesignationPublicname { get; set; }

        [Name("Constituent\\Assigned Security Groups\\Security group name")]
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }

        [Name("Child\\Child\\First name")]
        public string ChildChildFirstname { get; set; }

        [Name("Installment frequency")]
        public string Installmentfrequency { get; set; }

        [Name("Sponsorships\\Sponsorship Opportunity\\Child\\First name")]
        public string ChildPreferredName { get; set; }

        [Name("Payment method")]
        public string PaymentMethod { get; set; }

        [Name("System record ID")]
        public string RevenueRecordID { get; set; }




    }
    public class Value
    {
        public string BBID { get; set; }
        public string Name { get; set; }
        public string Prospectstatus { get; set; }
        public string Prospectmanager { get; set; }
        public string Prospectmanagerstartdate { get; set; }
        public string Prospectmanagerenddate { get; set; }
        public string Stepdate { get; set; }
        public string Stepobjective { get; set; }
        public string Stepstage { get; set; }
        public string Stepstatus { get; set; }
        public string AmountOrganisationCurrency { get; set; }
        public string RevenueID { get; set; }
        public string LookupID { get; set; }
        public string Amount { get; set; }
        public string AmountOrgCurrency { get; set; }
        public string AmountTransactionCurrency { get; set; }
        public string Date { get; set; }
        public string DesignationList { get; set; }
        public string GLPostDate { get; set; }
        public string GLPostProces { get; set; }
        public string GLPostStatus { get; set; }
        public string InboundChannel { get; set; }
        public string OriginalPaymentAmount { get; set; }
        public string OriginalPaymentAmountOrgCurrency { get; set; }
        public string OriginalPaymentAmountTransactionCurrency { get; set; }
        public string PaymentMethod { get; set; }
        public string OtherMethod { get; set; }
        public string PledgeGrantAwardBalance { get; set; }
        public string ReceiptAmount { get; set; }
        public string AdvanceNoticeSentDat { get; set; }
        public string DirectDebitReferenceDate { get; set; }
        public string DirectDebitReferenceNumber { get; set; }
        public string SendInstruction { get; set; }
        public string SendInstructionType { get; set; }
        public string SetUpInstructionDate { get; set; }
        public string NewInstructionDate { get; set; }
        public string CancelInstructionDate { get; set; }
        public string DDISource { get; set; }
        public string GAClaimableTaxAmount { get; set; }
        public string GAClaimableTaxAmountOrgCurrency { get; set; }
        public string GAClaimableTaxAmountTransactionCurrency { get; set; }
        public string GAGrossAmount { get; set; }
        public string GAGrossAmountOrgCurrency { get; set; }
        public string GAGrossAmountTransactionCurrency { get; set; }
        public string GAPotentialGrossAmount { get; set; }
        public string GAPotentialGrossAmountOrgCurrency { get; set; }
        public string GAPotentialGrossAmountTransactionCurrency { get; set; }
        public string ReceivedTaxClaimAmount { get; set; }
        public string ReceivedTaxClaimAmountOrgCurrency { get; set; }
        public string ReceivedTaxClaimAmountTransactionCurrency { get; set; }
        public string CalcGAClaimableTaxAmount { get; set; }
        public string CalcGAClaimableTaxAmountOrgCurrency { get; set; }
        public string CalcGAClaimableTaxAmountTransactionCurrency { get; set; }
        public string CalcGAGrossAmount { get; set; }
        public string CalcGAGrossAmountOrgCurrency { get; set; }
        public string CalcGAGrossAmountTransactionCurrency { get; set; }
        public string CalcGAPotentialGrossAmount { get; set; }
        public string CalcGAPotentialGrossAmountOrgCurrency { get; set; }
        public string CalcGAPotentialGrossAmountTransactionCurrency { get; set; }
        public string CalcGAReceivedTaxClaimAmount { get; set; }
        public string CalcGAReceivedTaxClaimAmountOrgCurrency { get; set; }
        public string CalcGAReceivedTaxClaimAmountTransactionCurrency { get; set; }
        public string DateAdded { get; set; }
        public string DateChanged { get; set; }
        public string AppealName { get; set; }
        public string BaseCurrency { get; set; }
        public string TransactionCurrency { get; set; }
        public string BasecurrencyID { get; set; }
        public string TransactioncurrencyID { get; set; }
        public string BasecurrencyID1 { get; set; }
        public string TransactioncurrencyID1 { get; set; }
        public string BasecurrencyID2 { get; set; }
        public string TransactioncurrencyID2 { get; set; }
        public string GiftAidBasecurrencyID { get; set; }
        public string GiftAidTransactioncurrencyID { get; set; }
        public string GiftAidBasecurrencyID1 { get; set; }
        public string GiftAidTransactioncurrencyID1 { get; set; }
        public string GiftAidBasecurrencyID2 { get; set; }
        public string GiftAidTransactioncurrencyID2 { get; set; }
        public string GiftAidBasecurrencyID3 { get; set; }
        public string GiftAidTransactioncurrencyID3 { get; set; }
        public string GiftAidCalculatedBasecurrencyID { get; set; }
        public string GiftAidCalculatedTransactioncurrencyID { get; set; }
        public string GiftAidCalculatedBasecurrencyID1 { get; set; }
        public string GiftAidCalculatedTransactioncurrencyID1 { get; set; }
        public string GiftAidCalculatedBasecurrencyID2 { get; set; }
        public string GiftAidCalculatedTransactioncurrencyID2 { get; set; }
        public string GiftAidCalculatedBasecurrencyID3 { get; set; }
        public string GiftAidCalculatedTransactioncurrencyID3 { get; set; }
        public string QUERYRECID { get; set; }
        public string RecurringGiftStatus { get; set; }
        public string InstallmentsStartDate { get; set; }
        public string InstallmentsEndDate { get; set; }
        public string LatestInstallmentPaymentDate { get; set; }
        public string LatestInstallmentPaymentAmount { get; set; }
        public string InstallmentFrequency { get; set; }

        public string ChildPreferredName { get; set; }
        public string Advancenoticesentdate { get; set; }
        public string Inboundchannel { get; set; }
        public string ConstituentLookupID { get; set; }
        public string PledgeGrantawardfirstinstallmentdue { get; set; }
        public string Directdebitreferencenumber { get; set; }
        public string DirectDebitAccountAccountnumber { get; set; }
        public string ApplicationDetailsDesignationPublicname { get; set; }
        public string ChildChildPreferredChildNameAttributeValue { get; set; }
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }
        public string ChildChildFirstname { get; set; }
        public string Installmentfrequency { get; set; }
        public string AccountSystem { get; set; }
        public string IsPending { get; set; }
        public string Latestpaymentamountorganizationcurrency { get; set; }
        public string Latestpaymentamounttransactioncurrency { get; set; }
        public string NumberOfInstallments { get; set; }
        public string LatestpaymentamounttransactioncurrencyID { get; set; }
        public string GLPostProcess { get; set; }
        public string Recurringgiftnexttransactiondate { get; set; }
    }

    public class DBModel
    {
        public string PaymentMethod { get; set; }
        public string RevenueRecordID { get; set; }
        public string ChildPreferredName { get; set; }
        public string RevenueID { get; set; }
        public string LookupID { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountOrgCurrency { get; set; }
        public decimal AmountTransactionCurrency { get; set; }
        public DateTime? Date { get; set; }
        public string DesignationList { get; set; }
        public DateTime? GLPostDate { get; set; }
        public DateTime? Recurringgiftnexttransactiondate { get; set; }
        public string GLPostProces { get; set; }
        public string GLPostStatus { get; set; }
        public string InboundChannel { get; set; }
        public decimal OriginalPaymentAmount { get; set; }
        public decimal OriginalPaymentAmountOrgCurrency { get; set; }
        public decimal OriginalPaymentAmountTransactionCurrency { get; set; }
        

        public string RecurringGiftStatus { get; set; }
        public string OtherMethod { get; set; }
        public decimal PledgeGrantAwardBalance { get; set; }
        public decimal ReceiptAmount { get; set; }
        public DateTime? AdvanceNoticeSentDat { get; set; }
        public DateTime? DirectDebitReferenceDate { get; set; }
        public string DirectDebitReferenceNumber { get; set; }
        public string SendInstruction { get; set; }
        public string SendInstructionType { get; set; }
        public DateTime? SetUpInstructionDate { get; set; }
        public DateTime? NewInstructionDate { get; set; }
        public DateTime? CancelInstructionDate { get; set; }
        public string DDISource { get; set; }
        public decimal GAClaimableTaxAmount { get; set; }
        public decimal GAClaimableTaxAmountOrgCurrency { get; set; }
        public decimal GAClaimableTaxAmountTransactionCurrency { get; set; }
        public decimal GAGrossAmount { get; set; }
        public decimal GAGrossAmountOrgCurrency { get; set; }
        public decimal GAGrossAmountTransactionCurrency { get; set; }
        public decimal GAPotentialGrossAmount { get; set; }
        public decimal GAPotentialGrossAmountOrgCurrency { get; set; }
        public decimal GAPotentialGrossAmountTransactionCurrency { get; set; }
        public decimal ReceivedTaxClaimAmount { get; set; }
        public decimal ReceivedTaxClaimAmountOrgCurrency { get; set; }
        public decimal ReceivedTaxClaimAmountTransactionCurrency { get; set; }
        public decimal CalcGAClaimableTaxAmount { get; set; }
        public decimal CalcGAClaimableTaxAmountOrgCurrency { get; set; }
        public decimal CalcGAClaimableTaxAmountTransactionCurrency { get; set; }
        public decimal CalcGAGrossAmount { get; set; }
        public decimal CalcGAGrossAmountOrgCurrency { get; set; }
        public decimal CalcGAGrossAmountTransactionCurrency { get; set; }
        public decimal CalcGAPotentialGrossAmount { get; set; }
        public decimal CalcGAPotentialGrossAmountOrgCurrency { get; set; }
        public decimal CalcGAPotentialGrossAmountTransactionCurrency { get; set; }
        public decimal CalcGAReceivedTaxClaimAmount { get; set; }
        public decimal CalcGAReceivedTaxClaimAmountOrgCurrency { get; set; }
        public decimal CalcGAReceivedTaxClaimAmountTransactionCurrency { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateChanged { get; set; }
        public string AppealName { get; set; }
        public string BaseCurrency { get; set; }
        public string TransactionCurrency { get; set; }
        public DateTime? InstallmentsStartDate { get; set; }
        public DateTime? InstallmentsEndDate { get; set; }
        public DateTime? LatestInstallmentPaymentDate { get; set; }
        public decimal LatestInstallmentPaymentAmount { get; set; }
        public string InstallmentFrequency { get; set; }
        public string AccountSystem { get; set; }
        public DateTime? Advancenoticesentdate { get; set; }
        public string Inboundchannel { get; set; }
        public string ConstituentLookupID { get; set; }
        public DateTime? PledgeGrantawardfirstinstallmentdue { get; set; }
        public string Directdebitreferencenumber { get; set; }
        public string DirectDebitAccountAccountnumber { get; set; }
        public string ApplicationDetailsDesignationPublicname { get; set; }
        public string ChildChildPreferredChildNameAttributeValue { get; set; }
        public string ConstituentAssignedSecurityGroupsSecuritygroupname { get; set; }
        public string ChildChildFirstname { get; set; }
        public string Installmentfrequency { get; set; }
    }
    public class PaymentMethodNoneOdataResponce
    {
        public string odatametadata { get; set; }
        public PaymentMethodNoneData[] value { get; set; }
        public string odatacount { get; set; }
    }

    public class PaymentMethodNoneData
    {
        public string Paymentmethod { get; set; }
        public string ConstituentLookupID { get; set; }
        public string Amount { get; set; }
        public string Installmentfrequency { get; set; }
        public string Recurringgiftnexttransactiondate { get; set; }
        public string SponsorshipsSponsorshipOpportunityChildFirstname { get; set; }
        public string Recurringgiftstatus { get; set; }
        public string SupporterId { get; set; }
        public string BasecurrencyID { get; set; }
        public string QUERYRECID { get; set; }
    }
    public class Enquiry
    {
        public string IncidentId { get; set; }
        public string Status { get; set; }
        public string ContactId { get; set; }
        public string ThreadText { get; set; }
        public string LookUpId { get; set; }
        public EnquiryThreadData ThreadData { get; set; }

    }
    public class EnquiryThreadData
    {
        public string SupporterId { get; set; }
        public string Paymentmethod { get; set; }
        public string Blackbaudid { get; set; }
        public string Amount { get; set; }
        public string Revenueid { get; set; }
    }

    public class AdvanceNoticeControlTableData
    {   
        public string status { get; set; }
        public string Amount { get; set; }
        public string NeedKey { get; set; }
    }

}
