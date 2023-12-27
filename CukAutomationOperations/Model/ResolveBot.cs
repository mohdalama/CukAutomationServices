using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class ResolveBot
    {
        //Do not not add/update this model as this model Created for Only Resolvebot process
        public string CountryOffice { get; set; }
        public string ApplicationSource { get; set; }
        public string SupporterType { get; set; }
        public string NewSupporter { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class ResolveBotSupporterData
    {
        public long IncidentID { get; set; }
        public string NeedKey { get; set; }
        public string Email { get; set; }
    }

    public class ResolveBotAdvanceNotice
    {
        public string message { get; set; }
        public bool error { get; set; }
    }

}
