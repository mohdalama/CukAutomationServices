using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class SupporterDataModel
    {
        public string SupId { get; set; }
        public string firtsname { get; set; }
        public string lastname { get; set; }
        public string SupporterName { get; set; }
        public string Email { get; set; }
        public string status { get; set; }
        public string BlackbaudId { get; set; }
        public string Process { get; set; }
        public string SupporterInRN { get; set; }
        public string NoOfEnq { get; set; }
        public string SupGrpInRN { get; set; }
        public string Blackbaud { get; set; }
        public string Connect { get; set; }
        public string phoneNo { get; set; }
        public string mobileNo { get; set; }
        public string OfficePhone { get; set; }
        public string Supporterpreferencesphone { get; set; }
        public string hassponplus { get; set; }
        public string GiftAidDeclaration { get; set; }
        public string AnnualBirthdayGift { get; set; }
        public string AnnualChristmasGift { get; set; }
        public string Welcomepackoption { get; set; }
        public bool TraditionalorPaperless { get; set; }
        public bool IsNewSupporter { get; set; }
        public int TotalCommitment { get; set; }
        public string Source { get; set; }
        public string postcode { get; set; }
        public string street1 { get; set; }

        public string NewSupporterPreferredName { get; set; }
        public string OldSupporterPreferredName { get; set; }
        public string SupporterGroupId { get; set; }
        public string ChildNeedKey { get; set; }
        public string ChildPreferredName { get; set; }

    }

    public class OrganizationData
    {
        public string OrgID { get; set; }
        public string OrgRelationshipStatus { get; set; }
    }
    public class ScannedImageDetailsModel
    {
        public long RecordID { get; set; }
        public string Barcode { get; set; }

        public string Needkey { get; set; }
        public string NeedID { get; set; }
        public string BeneficiaryGlobalID { get; set; }
        public string ConID { get; set; }
        public string SupporterGroupID { get; set; }
        public string SupporterGlobalID { get; set; }

    }
    public class OnlineS2BDbModel
    {
        public int actionid { get; set; }
        public int Id { get; set; }
        public int Need { get; set; }
        public string NeedKey { get; set; }
        public string MessageTo { get; set; }
        public string BeneficiaryGlobalID { get; set; }
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public int SupporterGroup { get; set; }
        public string SupporterGlobalID { get; set; }
        public string MessageFrom { get; set; }
        public long ConId { get; set; }
        public string Message { get; set; }
        public string Image64 { get; set; }
        public string ImageExtension { get; set; }
        public string FtpFilePath { get; set; }
        public string FileURL { get; set; }
        public long SourceId { get; set; }
        public string CommKitId { get; set; }

        public int Type { get; set; }
        public string BatchID { get; set; }
        public DateTime DateScanned { get; set; }
        public DateTime DateProcessed { get; set; }
        public bool ItemNotScannedEligable { get; set; }
        public bool ItemNotScannedNotEligable { get; set; }
        public bool FromUtility { get; set; }
        public string Barcode { get; set; }
    }

    public class PreferredNameChange
    {
        public long SupporterGroupID { get; set; }
        public string NewValue { get; set; }
        public string PrevValue { get; set; }
        public string ReasonForChange { get; set; }
        public int Source { get; set; }
        public string Context { get; set; }
        public long Supporter { get; set; }
        public int Account { get; set; }
    }


    public class EncounterAttendanceAndVisitData
    {
        public long EncounterID { get; set; }
        public long VisitID { get; set; }
    }


    
}
