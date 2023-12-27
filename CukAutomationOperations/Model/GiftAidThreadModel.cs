using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class GiftAidThreadModel
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string GADatefrom { get; set; }
        public string addressLine1 { get; set; }
        public string postcode { get; set; }
        public long primarySupporterId { get; set; }
        public long IncidentId { get; set; }
        public string ConstituentRecordID { get; set; }
        public string disposition { get; set; }
    }

    public class GiftAidBatchModel
    {
        public string ConstituentId { get; set; }
        public string PaysTax { get; set; }
        public string Status { get; set; }
        public string StartDate { get; set; }
        public string Made { get; set; }
        public string AliasFirstName { get; set; }
        public string AliasLastName { get; set; }
    }


    public class GiftAid
    {
        public const string FUTURE_DONATION_DATE = "01-07-2019";
    }

   

}
