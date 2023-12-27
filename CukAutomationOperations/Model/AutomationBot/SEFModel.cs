using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model.AutomationBot
{
    public class SEFModel
    {
        public string supporterid { get; set; }
        public string titlestring { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobilephone { get; set; }
        public string addresslineone { get; set; }
        public string addresslinetwo { get; set; }
        public string addresslinethree { get; set; }
        public string addresslinefour { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string addresscountry { get; set; }
        public string postcode { get; set; }

        public string sponsorchild { get; set; }
        public string childnumber { get; set; }
        public string BeneficiaryGlobalId { get; set; }
        public string BeneficiaryHoldId { get; set; }
        public string accountname { get; set; }
        public string accountnumber { get; set; }
        public string sortcode { get; set; }
        public string SponsorshipPlus { get; set; }

        //For Couple Process
        public string supporterid1 { get; set; }
        public string titlestring1 { get; set; }
        public string firstname1 { get; set; }
        public string lastname1 { get; set; }
        public string email1 { get; set; }
        public string mobilephone1 { get; set; }
        public string addresslineone1 { get; set; }
        public string postcode1 { get; set; }
        public string accountname1 { get; set; }
        public string accountnumber1 { get; set; }
        public string sortcode1 { get; set; }
        public string childnumber1 { get; set; }
        public string BeneficiaryGlobalId1 { get; set; }
        public string BeneficiaryHoldId1 { get; set; }
        public string supporterid2 { get; set; }
        public string titlestring2 { get; set; }
        public string firstname2 { get; set; }
        public string lastname2 { get; set; }
        public string email2 { get; set; }
        public string mobilephone2 { get; set; }
        public string addresslineone2 { get; set; }
        public string postcode2 { get; set; }
        public string accountname2 { get; set; }
        public string accountnumber2 { get; set; }
        public string sortcode2 { get; set; }
        public string childnumber2 { get; set; }
        public string BeneficiaryGlobalId2 { get; set; }
        public string BeneficiaryHoldId2 { get; set; }
        public string SponsorshipPlus1 { get; set; }
        public string SponsorshipPlus2 { get; set; }
        public string BirthDate { get; set; }
        public string connectusestage { get; set; }
        public string CC_TransactionId { get; set; }
    }

    public class OperationParams
    {
        public long Contactid { get; set; }
        public long IncidentId { get; set; }
        public string Needkey { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
        public string SponsorshipPlus { get; set; }
        public string SEFGUID { get; set; }
        public string giftaidstatus { get; set; }
        public string SupporterPreferredName { get; set; }
        public string sponsorshipplustype { get; set; }
        public string ChritmasAmount { get; set; }
        public string BirthdayAmount { get; set; }
        public string sponsorshipplus { get; set; }
        public string ApplicationCode { get; set; }
        public string MandateType { get; set; }
        public string dddateprefer { get; set; }
        public string NewSupporter { get; set; }
    }

    public class SupporterData
    {
        public string TitleID { get; set; }
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
    }
    
    public class SupporterDataList
    {
        public List<string> titlestring { get; set; }
        public List<string> title { get; set; }
        public List<string> firstname { get; set; }
        public List<string> lastname { get; set; }
        public List<string> addresslineone { get; set; }
        public List<string> addresslinetwo { get; set; }
        public List<string> addresslinethree { get; set; }
        public List<string> addresslinefour { get; set; }
        public List<string> town { get; set; }
        public List<string> county { get; set; }
        public List<string> addresscountry { get; set; }
        public List<string> postcode { get; set; }
        public List<string> connectusestage { get; set; }
        public List<string> email { get; set; }
        public List<string> mobilephone { get; set; }
        public List<string> yearofbirth { get; set; }

    }

    public class NewChildData 
    {
        public string NewChild_BeneficiaryGlobalId { get; set; }
        public string NewChild_BeneficiaryHoldId { get; set; }
        public string NewChild_sponsorchild { get; set; }
    }

}
