using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CukAutomationOperations;
using CukAutomationOperations.Model;

namespace CukAutomationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CukAutomationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CukAutomationService.svc or CukAutomationService.svc.cs at the Solution Explorer and start debugging.
    public class CukAutomationService : ICukAutomationService
    {
        public void DoWork()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();

            obj.Test();

            //obj.GiftAidProcess(7318619);

            // obj.GiftAidProcess(7318841);

            // obj.TriggerGiftAidProcess();

            // obj.BatchSearchNInsert();

            // 
        }

        public void SendPhotoNotification()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.SendPhotoNotification(0, "");
        }

        public void TriggerSetupBot()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.FindSetupBotRecords();
        }

        public void TriggerCheckBot()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.TriggerCheckBot();
        }

        public string FetchOrgIdFromCommitmentId(string CommitmentId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.FetchOrgIdFromCommitmentId("64512");
        }

        public void SyncAdvanceNotice(long RecordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.SyncAdvanceNoticeMain(RecordId);
        }

        public void CreateAdvanceNoticeEnquiries(long RecordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.CreateAdvanceNoticeEnquiries(RecordId);
        }

        public void UpdateAdNoticeSentDateInBBMainMethod(long RecordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.UpdateAdNoticeSentDateInBBMainMethod(RecordId);
        }

        public void TriggerResolveBot(long IncidentID)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            if (IncidentID != 0)
                obj.TriggerResolveBot(IncidentID);
            else
                obj.FindResolveBotRecords(0);
        }
        public void SyncS2BLookUpValFromBarcode()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.SyncS2BLookUpValFromBarcode();
        }

        public void UpdateSupporterGiftLetterFeedBackDates(long SupporterID, string Type)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.UpdateSupporterGiftLetterFeedBackDates(SupporterID, Type);
        }

        public S2BCommData GetCorrespondenceData(string Incidentrefid)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.GetCorrespondenceData(Incidentrefid);
        }

        public string GetSpondorshipDataOnID(string SponsorshipId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.GetSpondorshipDataOnID(SponsorshipId);
        }

        public string TestServices()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.GenerateQrCodeWithCenterLogo();
        }

        public long CreateS2BCommDraft(S2BCommDraftData s2bobj)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.CreateS2BCommDraft(s2bobj);
        }

        public bool UpdateS2BCommDraft(S2BCommDraftData s2bobj)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.UpdateS2BCommDraft(s2bobj);
        }

        public bool DeleteS2BCommDraft(long SupporterID)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.DeleteS2BCommDraft(SupporterID);
        }

        public S2BCommDraftData GetS2BCommDraft(long SupporterID)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.GetS2BCommDraft(SupporterID);
        }

        public string UpsertS2BCommDraft(S2BCommDraftData s2bobj)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.UpsertS2BCommDraft(s2bobj);
        }

        public Message GetS2BCommDraftTile(long SupporterID)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.OptimizeGetS2BCommDraftTile(SupporterID);
        }

        public void SendNotificationOperation(string Type, string Env)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.SendNotificationOperation(Type, Env);
        }

        public void TriggerExitToResolve()
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.FindDepartedEnqueriesRecords();
        }

        public List<cancelRecurringGift> cancelRecurringGift(List<cancelRecurringGift> rgobj, string delinkReason, string FundType, int DonationAmount, bool IsAssignToGeneralFund, string IncidentRefId, string DDiSource, string DDiSourceDate)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.CancelRecurringGift(rgobj, delinkReason, FundType, DonationAmount, IsAssignToGeneralFund, IncidentRefId, DDiSource, DDiSourceDate);
        }
        public bool CheckSponsroshipStartToday(string SponsorshipId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.CheckSponsroshipStartToday(SponsorshipId);
        }


        public void ImportRateChangeEnquiriesForKingslineData(long RecordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.GetSetGetWhiteMailAdvanceNoticeData(RecordId);
        }

        public void ResolveRateChangeEnquiries(long RecordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.ResolveRateChangeEnquiries(RecordId);
        }

        public void CreateOnlyConstituentProcess(long SupporterId, string CC_TransactionId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.CreateOnlyConstituentProcess(SupporterId, CC_TransactionId);
        }


        public string GetLookupIdOnSupporterId(long SupporterId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.GetLookupIdOnSupporterId(SupporterId);
        }

        public void CreateOnlyConstituentProcessOtherPayments(OnlyConstituentDetails Obj)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            obj.CreateOnlyConstituentProcessOtherPayments(Obj);
        }

        public string getSupporterIdFromBlackbaudId(string lookupId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.getSupIdFromBlackbaudId(lookupId);
        }

        public void TransferSupporterDetails(long recordId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
             obj.transferSupporterDetails(recordId);
        }


        public string SearchSupporterByParams(SearchSupporterModel Obj)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.SearchSupporterByParams(Obj);

        }

        public bool CheckIfSupporterEligibleForNotification(string supporterId)
        {
            CukAutomationOperations.CukAutomationOperation obj = new CukAutomationOperations.CukAutomationOperation();
            return obj.CheckIfSupporterEligibleForNotification(supporterId);
        }

    }
}
