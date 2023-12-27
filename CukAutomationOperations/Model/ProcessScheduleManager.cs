using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class ProcessScheduleManager
    {
        public string ID { get; set; }
        public string ProcessName { get; set; }
        public string LastSuccessfulRunTime { get; set; }
        public string Status { get; set; }
    }
}
