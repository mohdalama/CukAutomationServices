using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class S2BCommDraftData
    {
        public long ID { get; set; }
        public string Message { get; set; }
        public long NeedID { get; set; }
        public long SupporterGroupID { get; set; }
        public long SupporterID { get; set; }
        public int TemplateID { get; set; }
        public int SBCStatus { get; set; }
        public string SBCStatusLookupName { get; set; }
        public string CreatedTime { get; set; }
        public string TemplateUrl { get; set; }
    }
    public class Gift
    {
        public string ClearedBank { get; set; }
        public string AmountInOriginatingCurrency { get; set; }
        public string GiftType { get; set; }
        public string PartnerGiftDate { get; set; }
        public string PartnerGiftID { get; set; }
        public string ReceipentID { get; set; }
        public string SupporterGlobalID { get; set; }
        public string GiftTransmittedtoGMCAttributeValue { get; set; }
        public string GiftReceivedbyChildAttributeValue { get; set; }
        public string GiftErrorMessageAttributeValue { get; set; }
        public string ConstituentLookupID { get; set; }
        public string DesignationName { get; set; }
        public string UndeliverableGiftReason { get; set; }
        public string GiftDelay { get; set; }
        public string GiftDelayReason { get; set; }
        public string UndeliverableGiftDate { get; set; }
    }

    public class Message
    {
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ActionText { get; set; }
        public string ActionDestination { get; set; }
        public S2BCommDraftData Draft { get; set; }
        public Child Child { get; set; }
    }
    public class Child
    {
        public long NeedId { get; set; }
        public string photo { get; set; }
        public long SupporterId { get; set; }
        public string forceLogOff { get; set; }
        public long SupporterGroupId { get; set; }
        public bool ddflag { get; set; }
        public string ProjectName { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public long CountryId { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string ChildNeedKey { get; set; }
        public string SupporterName { get; set; }
        public string SupporterGroupName { get; set; }
        public string SupporterGroupPreferredName { get; set; }
        
        
        public string ImageURL { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string FullBodyImageURL { get; set; }
        public string PreferredName { get; set; }
        public string ProgramDeliveryType { get; set; }
        public string BeneficiaryGlobalId { get; set; }
        public string IcpId { get; set; }
        public string City { get; set; }
        public string MyCompassionStatus { get; set; }
        public int lenghtOfSponsorship { get; set; }
        public int projectAttendence { get; set; }
        public int medicalCheckups { get; set; }
        public int NutritionalMeal { get; set; }
        public string blackbaudid { get; set; }
        public DateTime StartDate { get; set; }
    }
    public class SupporterGroup
    {
        public long SupporterGroupID { get; set; }
        public string Name { get; set; }
        public string PreferredName { get; set; }

    }

}
