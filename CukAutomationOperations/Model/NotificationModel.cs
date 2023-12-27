using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class NotificationsModel
    {
        public string to { get; set; }
        public bool mutable_content { get; set; }
        public long RecordID { get; set; }
        public NotificationContent notification { get; set; }
        public NotificationData data { get; set; }
    }
    public class NotificationContent
    {
        public string body { get; set; }
        public string title { get; set; }
        public string sound { get; set; }
        public long badge { get; set; }
    }
    public class NotificationData
    {
        public string heroId { get; set; }
        public string destination { get; set; }
        public string body { get; set; }
        public string title { get; set; }
        public string needkey { get; set; }
        public long badge { get; set; }
        public long CorrespondenceID { get; set; }
        public long FileID { get; set; }
        public string revenueid { get; set; }
        public string image { get; set; }
        public int needid { get; set; }
    }
    public class Notifications
    {
        public string Topic { get; set; }
        public long SUPPORTER_ID { get; set; }
        public string SUPPORTER_NAME { get; set; }
        public string CHILD_NAME { get; set; }
        public string NEEDKEY { get; set; }
        public string MESSAGE_TITLE { get; set; }
        public string MESSAGE_BODY { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string HERO { get; set; }
        public string DESTINATION { get; set; }
        public long RecordID { get; set; }
        public long CorrespondenceID { get; set; }
        public long FileID { get; set; }
        public string image { get; set; }
        public string DATA { get; set; }
        public string Revenueid { get; set; }
        public int NeedId { get; set; }
    }
    public class ChildDetails
    {
        public string PreferredName { get; set; }
        public string NeedKey { get; set; }
        public long NeedID { get; set; }
        public string BirthDate { get; set; }
        public string childImage { get; set; }
        public long CorrespondenceID { get; set; }
        public long FileID { get; set; }
    }
    public class RevenueData
    {
        public string LookupID { get; set; }
        public string NeedKey { get; set; }
        public long SupporterID { get; set; }
        public string ChildPreferredName { get; set; }
    }
    
}
