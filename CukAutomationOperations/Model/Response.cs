using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class Response
    {
        public string NumberOfBeneficiaries { get; set; }
        public Beneficiarysearchresponselist[] BeneficiarySearchResponseList { get; set; }
        public Error Error { get; set; }
    }

    public class Beneficiarysearchresponselist
    {
        public string Beneficiary_ThumbnailURL { get; set; }
        public string FullBodyImageURL { get; set; }
        public string FullName { get; set; }
        public string PriorityScore { get; set; }
        public string BeneficiaryState { get; set; }
        public string FieldOffice_Name { get; set; }
        public string ICP_Country { get; set; }
        public string ICP_ID { get; set; }
        public string Age { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string LocalNumber { get; set; }
        public string Beneficiary_GlobalID { get; set; }
        public string Beneficiary_LocalID { get; set; }
        public string HoldingGlobalPartnerID { get; set; }
        public string HoldExpirationDate { get; set; }
        public string CorrespondentScore { get; set; }
        public string PreferredName { get; set; }
        public string WaitingSinceDate { get; set; }
        public bool IsInHIVAffectedArea { get; set; }
        public bool IsSpecialNeeds { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOrphan { get; set; }
        public string MinDaysWaiting { get; set; }
        public string SourceCode { get; set; }
        public string HoldId { get; set; }
        public string LongWaiting { get; set; }
    }
    public class ErrorResponse
    {
        public Error Error { get; set; }
    }

    public class Error
    {
        public string ErrorId { get; set; }
        public DateTime ErrorTimestamp { get; set; }
        public string ErrorClass { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorRetryable { get; set; }
        public string ErrorModule { get; set; }
        public string ErrorSubModule { get; set; }
        public string ErrorMethod { get; set; }
        public string ErrorLoggedInUser { get; set; }
        public string RelatedRecordId { get; set; }
    }
    public class BeneficiaryRequestModel
    {
        public string LongWaiting { get; set; }
        public string localId { get; set; }
        public string gender { get; set; }
        public string countries { get; set; }
        public string[] multipleCountries { get; set; }
        public string minPriorityScore { get; set; }
        public string maxPriorityScore { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string icpId { get; set; }
        public string birthDateFrom { get; set; }
        public string birthDateTo { get; set; }
        public string birthDay { get; set; }
        public string birthMonth { get; set; }
        public string birthYear { get; set; }
        public string minDaysWaiting { get; set; }
        public string maxDaysWaiting { get; set; }
        public string includeOnHold { get; set; }
        public string status { get; set; }
        public string[] statuses { get; set; }
        public string hasSpecialNeeds { get; set; }
        public string hasSiblings { get; set; }
        public string isFatherAlive { get; set; }
        public string isMotherAlive { get; set; }
        public string cluster { get; set; }
        public string isPhysicalDisable { get; set; }
        public string IsOrphan { get; set; }
        public string hivAffectedArea { get; set; }
        public string chronicIllness { get; set; }
        public string isTransitioned { get; set; }
        public string globalId { get; set; }
        public int take { get; set; }
        public int skip { get; set; }
        public string age { get; set; }
        public string lowage { get; set; }
        public string highage { get; set; }
        public string[] territory { get; set; }
        public string BeneficiaryLastReviewDate { get; set; }
        public string SourceCode { get; set; }
        public string[] HoldingGlobalPartnerID { get; set; }
    }

    public class BeneficiaryHoldRequest
    {
        public Beneficiaryholdrequestlist[] BeneficiaryHoldRequestList { get; set; }
    }

    [DataContract]
    public class Beneficiaryholdrequestlist
    {
        [DataMember]
        public string BeneficiaryState { get; set; }
        [DataMember]
        public object EstimatedNoMoneyYieldRate { get; set; }
        [DataMember]
        public DateTime HoldEndDate { get; set; }
        [DataMember]
        public string HoldID { get; set; }
        [DataMember]
        public string HoldYieldRate { get; set; }
        [DataMember]
        public bool IsSpecialHandling { get; set; }
        [DataMember]
        public string PrimaryHoldOwner { get; set; }
        [DataMember]
        public string SecondaryHoldOwner { get; set; }
        [DataMember]
        public string SourceCode { get; set; }
        [DataMember]
        public string Beneficiary_GlobalID { get; set; }
        [DataMember]
        public string Beneficiary_LocalID { get; set; }
        [DataMember]
        public string WaitingSinceDate { get; set; }
        [DataMember]
        public string Channel_Name { get; set; }
        [DataMember]
        public string ChannelId { get; set; }
        [DataMember]
        public string GlobalPartner_ID { get; set; }
        [DataMember]
        public string HoldStatus { get; set; }
    }
    public class BeneficiaryHoldResponse
    {
        public int Status { get; set; }
        public Beneficiaryholdresponselist[] BeneficiaryHoldResponseList { get; set; }
        public Error Error { get; set; }
    }

    public class Beneficiaryholdresponselist
    {
        public string Beneficiary_GlobalID { get; set; }
        public string Beneficiary_LocallID { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string HoldID { get; set; }
        public long ChildRNID { get; set; }
    }
}
