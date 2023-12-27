using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class ChildDataModel
    {
        public string PreferredName { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string CountryId { get; set; }
        public string CountryInfo { get; set; }
        public string ContinentName { get; set; }
        public string CountryName { get; set; }
        public string NeedKey { get; set; }
        public string NeedId { get; set; }
        public string RNNeedId { get; set; }
        public string Project { get; set; }
        public string Bio { get; set; }
        public DateTime BirthDate { get; set; }
        public string Course { get; set; }
        public string Child { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string GlobalID { get; set; }
        public bool Handicapped { get; set; }
        public bool Active { get; set; }

        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string AbbreviatedName { get; set; }
        public string LastName { get; set; }
        //public string BirthDate { get; set; }

        public bool BirthDateKnown { get; set; }
        public bool Orphan { get; set; }
        public string LanguagesSpoken { get; set; }
        public string CompassChildID { get; set; }
        public DateTime LastCaseStudyDate { get; set; }
        public string SchoolPerformance { get; set; }
        public string HoldSourceCode { get; set; }
        public string HoldStatus { get; set; }
        public string HoldDateExpiry { get; set; }
        public string FullBodyImageURL { get; set; }
        public string Beneficiary_GlobalID { get; set; }
        public string Beneficiary_LocalID { get; set; }
        public string Channel_Name { get; set; }
        public string EstimatedNoMoneyYieldRate { get; set; }
        public string HoldEndDate { get; set; }
        public string HoldID { get; set; }
        public string HoldType { get; set; }
        public string HoldYieldRate { get; set; }
        public string Hold_Url { get; set; }
        public string ID { get; set; }
        public string IsSpecialHandling { get; set; }
        public string NeedRNID { get; set; }
        public string PrimaryHoldOwner { get; set; }
        public string ProjectRNID { get; set; }
        public string SecondaryHoldOwner { get; set; }
        public string SourceCode { get; set; }
        public string NeedStatus { get; set; }

        public string globalCommitmentId { get; set; }
        public string globalCorrCommitmentId { get; set; }
        public string childGlobalId { get; set; }
        public string supGrpGlobalId { get; set; }
        public string SupporterGroupID { get; set; }
        public string BlackbaudID { get; set; }
        public string CommitmentId { get; set; }
        public string SupporterGroupName { get; set; }
        public string CompassConID { get; set; }

        public string ReservationID { get; set; }
        public string ComBlackbaudID { get; set; }

        // only for Dep-Sub flow
        public string MarketingChannel { get; set; }
        public string RelationshipManager { get; set; }
        public string Organisation { get; set; }
        public string MarketingCode { get; set; }
        public string CommSupporter { get; set; }
        public string Event { get; set; }
        public string Campaign { get; set; }
        public string BBDDAmount { get; set; }
        public string BBDDNextDate { get; set; }
        public string BBDDStartDateText { get; set; }
        public string BBPaymentMethod { get; set; }
        public string DDReference { get; set; }
        public string SponsorshipPlus { get; set; }
        public string PaymentMethod { get; set; }
        public string GroupType { get; set; }
        public string LinkedToPartnership { get; set; }
        public string OrgSupporterGroupLink { get; set; }
        public DateTime HoldExpirationDate { get; set; }

        public string childName { get; set; }
        public string childKey { get; set; }
        public string gender { get; set; }
        public string ChildBirthDate { get; set; }
        //public string childGlobalId { get; set; }
        public string childPersonalName { get; set; }
        public int actionid { get; set; }
        public List<RecurringGifts> RGDetails { get; set; }

    }

    public class RecurringGifts
    {
        public string RGType { get; set; }
        public int RGAmount { get; set; }
    }

    public class Correspondence
    {
        public string CommKitID { get; set; }
        public string ChildRef { get; set; }
        public string ChildPreferredName { get; set; }
        public string Status { get; set; }
        public string Contentissuesfound { get; set; }
        public string Comments { get; set; }
        public string Datereceivedinsystem { get; set; }
        public string Datemodified { get; set; }
        public string Linktopdf { get; set; }
        public long IncidentID { get; set; }
    }

    public class S2BCommData
    {
        public string SupporterGroupID { get; set; }
        public string SupporterGroupName { get; set; }
        public string SupporterGlobalID { get; set; }
        public string ChildPreferredName { get; set; }
        public string NeedKey { get; set; }
        public string ChildGlobalID { get; set; }
        public string TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string OldS2BRecordID { get; set; }
        public string OldCommkitID { get; set; }
        public string FileId { get; set; }
        public string FileAttachmentURL { get; set; } 
        public Correspondence ThreadData { get; set; }
        public string NeedId { get; set; }
        public string SupporterId { get; set; }
        public string LetterType { get; set; }
        public string MessageFrom { get; set; }
        public string TemplateURL { get; set; }
        public bool error { get; set; }
        public bool success { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string LetterImage { get; set; }
        public string LetterId { get; set; }
    }

    public class TemplateInfo
    {
        public string TemplateURL { get; set; }
        public string TemplateType { get; set; }
    }
}
