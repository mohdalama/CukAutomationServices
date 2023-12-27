using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class Constant
    {
        public const string HOSTNAME = "http://cukdev.co.uk/";
        public const string ONEVIEW_HOSTNAME = "http://cukdev.co.uk/oneview/";
        public const string SIGNATURE = ONEVIEW_HOSTNAME+"AdvanceNotice/img/Signature.png?123";
        public const string DIRECTDEBITLOGO = ONEVIEW_HOSTNAME+"AdvanceNotice/img/direct-debit-logo.png?123";
        public const string TICK = ONEVIEW_HOSTNAME + "AdvanceNotice/img/tick.png?123";
        public const int MAX_EXISTING_COMMITMENTS = 4;
    }
}
