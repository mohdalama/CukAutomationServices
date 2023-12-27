using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class ConstituentPaymentDetails
    {
        public string SponsorshipId { get; set; }
        public string RevenueId { get; set; }
        public string AccountNo { get; set; }
        public string SortCode { get; set; }
        public string PaymentMethod { get; set; }
        public string DirectDebitReferenceNumber { get; set; }
        public string InstallmentFrequency { get;set; }
        public DateTime? NextInstallmentsDate { get; set; }
        public string AccountStatus { get; set; }
        public string NameOnAccount { get; set; }
        public string Lookupid { get; set; }
        public string RecurringGiftStatus { get; set; }
    }
}
