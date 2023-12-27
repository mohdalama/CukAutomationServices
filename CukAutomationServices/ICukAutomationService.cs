using CukAutomationOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CukAutomationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICukAutomationService" in both code and config file together.
    [ServiceContract]
    public interface ICukAutomationService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void SendPhotoNotification();

        [OperationContract]
        void TriggerSetupBot();

        [OperationContract]
        void TriggerCheckBot();

        [OperationContract]
        string FetchOrgIdFromCommitmentId(string CommitmentId);

        [OperationContract]
        void SyncAdvanceNotice(long RecordId);

        [OperationContract]
        void CreateAdvanceNoticeEnquiries(long RecordId);

        [OperationContract]
        void UpdateAdNoticeSentDateInBBMainMethod(long RecordId);

        [OperationContract]
        void TriggerResolveBot(long IncidentID);

        [OperationContract]
        void SyncS2BLookUpValFromBarcode();

        [OperationContract]
        void UpdateSupporterGiftLetterFeedBackDates(long SupporterID, string Type);

        [OperationContract]
        S2BCommData GetCorrespondenceData(string Incidentrefid);

        [OperationContract]
        string GetSpondorshipDataOnID(string SponsorshipId);

        [OperationContract]
        string TestServices();

        [OperationContract]
        long CreateS2BCommDraft(S2BCommDraftData s2bobj);

        [OperationContract]
        bool UpdateS2BCommDraft(S2BCommDraftData s2bobj);

        [OperationContract]
        bool DeleteS2BCommDraft(long SupporterID);

        [OperationContract]
        S2BCommDraftData GetS2BCommDraft(long SupporterID);


        [OperationContract]
        string UpsertS2BCommDraft(S2BCommDraftData s2bobj);

        [OperationContract]
        Message GetS2BCommDraftTile(long SupporterID);


        [OperationContract]
        void SendNotificationOperation(string Type, string Env);

        [OperationContract]
        void TriggerExitToResolve();

        [OperationContract]
        List<cancelRecurringGift> cancelRecurringGift(List<cancelRecurringGift> rgobj, string delinkReason,string FundType, int DonationAmount,bool IsAssignToGeneralFund,string IncidentRefId,string DDiSource, string DDiSourceDate);


        [OperationContract]
        bool CheckSponsroshipStartToday(string SponsorshipId);

        [OperationContract]
        void ImportRateChangeEnquiriesForKingslineData(long RecordId);

        [OperationContract]
        void ResolveRateChangeEnquiries(long RecordId);

        [OperationContract]
        void CreateOnlyConstituentProcess(long SupporterId, string CC_TransactionId);


        [OperationContract]
        string GetLookupIdOnSupporterId(long SupporterId);


        [OperationContract]
        void CreateOnlyConstituentProcessOtherPayments(OnlyConstituentDetails Obj);

        [OperationContract]
        string getSupporterIdFromBlackbaudId(string lookupId);


        [OperationContract]
        void TransferSupporterDetails(long recordId);

        [OperationContract]
        string SearchSupporterByParams(SearchSupporterModel Obj);


        [OperationContract]
        bool CheckIfSupporterEligibleForNotification(string supporterId);

    }
}
