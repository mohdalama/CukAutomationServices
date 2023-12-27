using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class Departure
    {

    }

    public class DepartureSEF
    {
        public long ContactId { get; set; }
        public string NewNeedKey { get; set; }
        public string OldNeedKey { get; set; }
        public long RTXIncidentId { get; set; }

        public long ETREnquiryId { get; set; }
        public string SEFGUID { get; set; }
        public int Amount { get; set; }
    }

    public class ExitEnquiryData
    {
        public string SupporterName { get; set; }
        public ExitEnquiryThreadData Thread { get; set; }
        public string Category { get; set; }
        public string SetupStatus { get; set; }
        public long ContactId { get; set; }
        public string InternalSubject { get; set; }
        public string IgnoreException { get; set; }
        public string SefGuid { get; set; }

    }

    public class ExitEnquiryThreadData
    {
        public string LocalBeneficiaryID { get; set; }
        public string ExitType { get; set; }
        public string CreatedDate { get; set; }
        public string BeneficiaryPreferredName { get; set; }
        public string BeneficiaryFullName { get; set; }
        public string BeneficiaryGender { get; set; }
        public string Age { get; set; }
        public string ICPName { get; set; }
        public string ICPStatus { get; set; }
        public string DateLastAttended { get; set; }
        public string ExitReason { get; set; }
        public string SponsorImpact { get; set; }
        public string NewSituation { get; set; }
        public string FutureHopes { get; set; }
        public string FamilyImpact { get; set; }
        public string PlanforEducation { get; set; }
        public string VocationalTraining { get; set; }
        public string DateOfDeath { get; set; }
        public string DeathCategory { get; set; }
        public string DeathSubcategory { get; set; }
        public string DeathInfoInterventions { get; set; }
        public string DeathOfBeneficiary { get; set; }
        public string Comments { get; set; }
    }

    public class ResolveExceptionConfigurationRow
    {
        public long SequenceID { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public int Priority { get; set; }
        public string AutomationState { get; set; }
    }

    public class ExitToResolveExceptions
    {
        public int Length { get; set; }
        public List<string> Exception { get; set; }
    }

    public class CreateIncidentData
    {
        public long ContactId { get; set; }
        public string NeedKey { get; set; }
        public int ExceptionCount { get; set; }
        public List<string> Exceptions { get; set; }
        public ExitEnquiryThreadData Thread { get; set; }
        public PrivateNote privateNote {get;set;}
        public string SEFGUID { get; set; }
    }

    public class DupSubPreferences
    {
        public bool SubChildren { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Continent { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string Country1 { get; set; }
        public string Country2 { get; set; }
        public string Country3 { get; set; }
        public List<string> Countries { get; set; } 
        public string OtherPreference { get; set; }
        public bool GreatestNeed { get; set; }
        public bool MostNeededFund { get; set; }
        public List<string> ContinentCountries { get; set; }
        public long IncidentId { get; set; }
        public string SetupStatus { get; set; }
        public string SefGuid { get; set; }
    }

    public class PrivateNote
    {
        public string NeedKey { get; set; }
        public string HoldId { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string GreatestNeed { get; set; }
    }

    public class TimeScale
    {
        public string Unit { get; set; }
        public string TimescaleType { get; set; }
    }

    
    public class ExistingCommitmentData
    {
        public int supgrpid { get; set; }
        public string ExistingSupporterGroupID { get; set; }
        public int linktype { get; set; }
        public int linkreason { get; set; }
        public int amount { get; set; }
        public string sponsorchild { get; set; }
        public string childnumber { get; set; }
        public string sgname { get; set; }
        public string sglettersalutation { get; set; }
        public string sgaddresssalutation { get; set; }
        public string BeneficiaryGlobalId { get; set; }
        public string BeneficiaryHoldId { get; set; }
        public string CorrespondentSupporterGlobalID { get; set; }
        public string ComBBId { get; set; }
        public string commMarketingChannel { get; set; }
        public string commCampaign { get; set; }
        public string commBBDDAmount { get; set; }
        public string SupGrpPreferredName { get; set; }
        public string ExistingBeneficiaryGlobalId { get; set; }
        public string ExistingCommitmentId { get; set; }
        public string ExistingGlobalCommitmentId { get; set; }
        public string ExistingGlobalCorrCommitmentId { get; set; }
        public string SupGrpType { get; set; }
    }
    
    

}
