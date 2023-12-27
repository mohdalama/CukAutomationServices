using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class ExportModel
    {
        public string RecordID { get; set; }
        public DateTime ProcessStartTime { get; set; }
        public DateTime ProcessEndTime { get; set; }
        public long NumberOfRecordsProcessed { get; set; }
    }
}
