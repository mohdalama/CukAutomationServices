using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{   
    public class NonSponsorDonationsModel
    {
        public long SupporterID { get; set; }
        public long NewSupporterID { get; set; }
        public string BlackbaudID { get; set; }
        public string BatchId { get; set; }
        public string BatchName { get; set; }
    }

    public class TransferConstituentInBatchModel
    {
        public string OldLookupId { get; set; }
        public string NewLookupId { get; set; }
        public string BatchId { get; set; }
        public string BatchName { get; set; }
    }
}
