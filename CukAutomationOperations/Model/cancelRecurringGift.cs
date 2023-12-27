using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class cancelRecurringGift
    {
        public string commBBID { get; set; }
        public string sponsorshipType { get; set; }
        public string childlocalid { get; set; }
        public string conid { get; set; }
        public string revenueid { get; set; }
        public string Responce { get; set; }
        public string PrimarySupporterblackbaudid { get; set; }

        public string Reason { get; set; }
    }


    public class SponsorshipModel
    {
        public string InstallmentFrequency { get; set; }
        public string FirstFundedDate { get; set; }
        public string GAStartDate { get; set; }
        public string DDISource { get; set; }
        public string referenceNo { get; set; }
        public string DesignationID { get; set; }
        public DateTime RgInstallmentStartDate { get; set; }
        public string PaymentMethod { get; set; }
        public string RecordId { get; set; }
        public string DDISourceDate { get; set; }
    }

    public class OtherRecurringGift
    {
        public string LookupID { get; set; }
        public string SponsorshipType { get; set; }
        public string RevenueId { get; set; }
        public string SponsorshipId { get; set; }
        public int TotalDonationAmount { get; set; }
        public string DesignationID { get; set; }
        public string DDISource { get; set; }
        public string DDISourceDate { get; set; }
    }

    public class CompassionOfficeIncidentData
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string SupId { get; set; }
        public string Country { get; set; }
        public string postaladdress { get; set; }
        public string ChurchName { get; set; }
        public string ChurchLocation { get; set; }
        public string Size { get; set; }
        public string CompassionSundayFlag { get; set; }
        public string Source { get; set; }
        public string postcode { get; set; }
        public string digitalOnly { get; set; }
    }

}
