using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    [DataContract]
    public class CIFModel
    {
        [DataMember]
        public bool isDepartureSubCommitment { get; set; }
        [DataMember]
        public bool isCorrespondentCommitment { get; set; }
        [DataMember]
        public bool createconstituentonly { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string barcode { get; set; }
        [DataMember]
        public string sponsorchild { get; set; }
        [DataMember]
        public string childnumber { get; set; }
        [DataMember]
        public int communicationmethod { get; set; }
        [DataMember]
        public string[] BestTimetoCall { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string primary { get; set; }
        [DataMember]
        public string[] supporterid { get; set; }
        [DataMember]
        public string[] titlestring { get; set; }
        [DataMember]
        public string[] title { get; set; }
        [DataMember]
        public string[] firstname { get; set; }
        [DataMember]
        public string[] lastname { get; set; }
        [DataMember]
        public string[] email { get; set; }
        [DataMember]
        public string[] phone { get; set; }
        [DataMember]
        public string[] mobilephone { get; set; }
        [DataMember]
        public string[] addresslineone { get; set; }
        [DataMember]
        public string[] addresslinetwo { get; set; }
        [DataMember]
        public string[] addresslinethree { get; set; }
        [DataMember]
        public string[] addresslinefour { get; set; }
        [DataMember]
        public string[] town { get; set; }
        [DataMember]
        public string[] county { get; set; }
        [DataMember]
        public string[] addresscountry { get; set; }
        [DataMember]
        public string[] postcode { get; set; }
        [DataMember]
        public string[] dob { get; set; }
        [DataMember]
        public string iscorrsponsor { get; set; }
        [DataMember]
        public string volunteering { get; set; }
        [DataMember]
        public string sponsorship { get; set; }
        [DataMember]
        public string manager { get; set; }
        [DataMember]
        public string bankaddress { get; set; }
        [DataMember]
        public string bankpostcode { get; set; }
        [DataMember]
        public string accountname { get; set; }
        [DataMember]
        public string accountnumber { get; set; }
        [DataMember]
        public string sortcode { get; set; }
        [DataMember]
        public string sortcode1 { get; set; }
        [DataMember]
        public string sortcode2 { get; set; }
        [DataMember]
        public string sortcode3 { get; set; }
        [DataMember]
        public string reference { get; set; }
        [DataMember]
        public string iamtaxpayer { get; set; }
        [DataMember]
        public string giftaidstatus { get; set; }
        [DataMember]
        public string futuredonationdate { get; set; }
        [DataMember]
        public string donationdate { get; set; }
        [DataMember]
        public string taxpayertitle { get; set; }
        [DataMember]
        public string taxpayerfirstname { get; set; }
        [DataMember]
        public string taxpayersurname { get; set; }
        [DataMember]
        public string debiton { get; set; }
        [DataMember]
        public string sgname { get; set; }
        [DataMember]
        public int supgrpid { get; set; }
        [DataMember]
        public string enqrefid { get; set; }
        [DataMember]
        public string enquiryrefid { get; set; }
        [DataMember]
        public int linktype { get; set; }
        [DataMember]
        public int linkreason { get; set; }
        [DataMember]
        public decimal amount { get; set; }
        [DataMember]
        public string installmentfrequency { get; set; }
        [DataMember]
        public string paymentmethod { get; set; }
        [DataMember]
        public string ddisource { get; set; }
        [DataMember]
        public string dddate { get; set; }
        [DataMember]
        public string firstfundeddate { get; set; }
        [DataMember]
        public string advancenoticesent { get; set; }
        [DataMember]
        public string nomoney { get; set; }
        [DataMember]
        public string groupaccount { get; set; }
        [DataMember]
        public string indicator { get; set; }
        [DataMember]
        public string scanneddocexists { get; set; }
        [DataMember]
        public string sglettersalutation { get; set; }
        [DataMember]
        public string sgaddresssalutation { get; set; }
        [DataMember]
        public string sgglobalid { get; set; }
        [DataMember]
        public string sgcompassconid { get; set; }
        [DataMember]
        public string SponsorSupporterGlobalID { get; set; }
        [DataMember]
        public string loggedinUser { get; set; }
        [DataMember]
        public string BeneficiaryGlobalId { get; set; }
        [DataMember]
        public string DepartedBeneficiaryGlobalId { get; set; }
        [DataMember]
        public string BeneficiaryHoldId { get; set; }
        [DataMember]
        public string individualsgname { get; set; }
        [DataMember]
        public string ExistingBeneficiaryGlobalId { get; set; }
        [DataMember]
        public string ExistingCommitmentId { get; set; }
        [DataMember]
        public string ExistingGlobalCommitmentId { get; set; }
        [DataMember]
        public string ExistingGlobalCorrCommitmentId { get; set; }
        [DataMember]
        public string ExistingSupporterGroupID { get; set; }
        [DataMember]
        public string CorrespondentSupporterGlobalID { get; set; }
        [DataMember]
        public string ComBBId { get; set; }
        [DataMember]
        public string bic { get; set; }
        [DataMember]
        public string iban { get; set; }

        [DataMember]
        public bool isOrganisation { get; set; }
        [DataMember]
        public string orgId { get; set; }
        [DataMember]
        public string orgName { get; set; }
        [DataMember]
        public string orgAddPref { get; set; }
        [DataMember]
        public string orgaddresslineone { get; set; }
        [DataMember]
        public string orgaddresslinetwo { get; set; }
        [DataMember]
        public string orgaddresslinethree { get; set; }
        [DataMember]
        public string orgaddresslinefour { get; set; }
        [DataMember]
        public string orgtown { get; set; }
        [DataMember]
        public string orgcounty { get; set; }
        [DataMember]
        public string orgaddresscountry { get; set; }
        [DataMember]
        public string orgpostcode { get; set; }
        [DataMember]
        public string orgwebsite { get; set; }
        [DataMember]
        public string orgPhone { get; set; }
        [DataMember]
        public string orgEmail { get; set; }
        [DataMember]
        public string orgType { get; set; }
        [DataMember]
        public string isorgcorrsponsor { get; set; }


        [DataMember]
        public string commMarketingChannel { get; set; }
        [DataMember]
        public string commMarketingCode { get; set; }
        [DataMember]
        public string commRelationshipManager { get; set; }
        [DataMember]
        public string commOrganisation { get; set; }
        [DataMember]
        public string commSupporter { get; set; }
        [DataMember]
        public string commEvent { get; set; }
        [DataMember]
        public string commCampaign { get; set; }

        [DataMember]
        public string commBBDDAmount { get; set; }
        [DataMember]
        public string commBBDDNextDate { get; set; }
        [DataMember]
        public string commBBDDStartDate { get; set; }
        [DataMember]
        public string commBBPaymentMethod { get; set; }
        [DataMember]
        public string commDDReference { get; set; }
        [DataMember]
        public bool commSponsorshipPlus { get; set; }
        [DataMember]
        public string commPaymentMethod { get; set; }
        [DataMember]
        public string commLinkedToPartnership { get; set; }

        [DataMember]
        public bool isIndiaProcessService { get; set; }
        [DataMember]
        public string DepNeedStatus { get; set; }
        [DataMember]
        public string IsSponPlus { get; set; }
        [DataMember]
        public string delinkType { get; set; }
        [DataMember]
        public string delinkReason { get; set; }
        [DataMember]
        public string isChildChangeFlow { get; set; }

        [DataMember]
        public string sefGUID { get; set; }

        [DataMember]
        public string samepc { get; set; }

        // Changes for GDPR marketing permission
        [DataMember]
        public string[] emailPreference { get; set; }
        [DataMember]
        public string[] phonePreference { get; set; }
        [DataMember]
        public string[] smsPreference { get; set; }
        [DataMember]
        public string[] createSolicit { get; set; }

        [DataMember]
        public string loggedinUserAccountID { get; set; }
        [DataMember]
        public string privateNote { get; set; }
        [DataMember]
        public string birthdayGiftAmount { get; set; }
        [DataMember]
        public string christmasGiftAmount { get; set; }
        [DataMember]
        public string AnnualBirthDate { get; set; }
        [DataMember]
        public string AnnualChristmasDate { get; set; }
        [DataMember]
        public string Sponsorshipsource { get; set; }
        [DataMember]
        public string SupGrpPreferredName { get; set; }
        [DataMember]
        public string IsHillsongSponPlus { get; set; }
        [DataMember]
        public string nonDDPaymentMethod { get; set; }

        [DataMember]
        public List<RGDetails> CreateRG { get; set; }
        [DataMember]
        public List<RGDetails> CancelRG { get; set; }
        [DataMember]
        public bool connectusestage { get; set; }
        [DataMember]
        public long SetupBotIncident { get; set; }

        [DataMember]
        public long RTXIncidentId { get; set; }

        [DataMember]
        public long ETREnquiryId { get; set; }

        [DataMember]
        public string OldChildNeedkey { get; set; }

        [DataMember]
        public string CC_TransactionId { get; set; }

        [DataMember]
        public string BatchName { get; set; }

        [DataMember]
        public string BatchDonorId { get; set; }

        [DataMember]
        public long NonSponsorDonationRecordId { get; set; }

    }
    public class RGDetails
    {
        public string RGAmount { get; set; }
        public string RGType { get; set; }
    }
}
