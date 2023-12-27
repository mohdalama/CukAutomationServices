﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CukAutomationOperations.MiscServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ValidateUKBankAccountResponseModel", Namespace="http://schemas.datacontract.org/2004/07/V_Series")]
    [System.SerializableAttribute()]
    public partial class ValidateUKBankAccountResponseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string invalidParameterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string invalidReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool validField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string invalidParameter {
            get {
                return this.invalidParameterField;
            }
            set {
                if ((object.ReferenceEquals(this.invalidParameterField, value) != true)) {
                    this.invalidParameterField = value;
                    this.RaisePropertyChanged("invalidParameter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string invalidReason {
            get {
                return this.invalidReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.invalidReasonField, value) != true)) {
                    this.invalidReasonField = value;
                    this.RaisePropertyChanged("invalidReason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool valid {
            get {
                return this.validField;
            }
            set {
                if ((this.validField.Equals(value) != true)) {
                    this.validField = value;
                    this.RaisePropertyChanged("valid");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MiscServices.IServices")]
    public interface IServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/ValidateUKBankAccount", ReplyAction="http://tempuri.org/IServices/ValidateUKBankAccountResponse")]
        CukAutomationOperations.MiscServices.ValidateUKBankAccountResponseModel ValidateUKBankAccount(string sortCode, string accountNumber, string buildingSocietyRollNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/ValidateUKBankAccount", ReplyAction="http://tempuri.org/IServices/ValidateUKBankAccountResponse")]
        System.Threading.Tasks.Task<CukAutomationOperations.MiscServices.ValidateUKBankAccountResponseModel> ValidateUKBankAccountAsync(string sortCode, string accountNumber, string buildingSocietyRollNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/updateLocalData", ReplyAction="http://tempuri.org/IServices/updateLocalDataResponse")]
        void updateLocalData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/updateLocalData", ReplyAction="http://tempuri.org/IServices/updateLocalDataResponse")]
        System.Threading.Tasks.Task updateLocalDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/BulkWebGiftToGMC", ReplyAction="http://tempuri.org/IServices/BulkWebGiftToGMCResponse")]
        void BulkWebGiftToGMC(string base64data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/BulkWebGiftToGMC", ReplyAction="http://tempuri.org/IServices/BulkWebGiftToGMCResponse")]
        System.Threading.Tasks.Task BulkWebGiftToGMCAsync(string base64data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetValidateUKBankAccount", ReplyAction="http://tempuri.org/IServices/GetValidateUKBankAccountResponse")]
        string GetValidateUKBankAccount(string AccountNo, string SortCode, string buildingSocietyRollNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/GetValidateUKBankAccount", ReplyAction="http://tempuri.org/IServices/GetValidateUKBankAccountResponse")]
        System.Threading.Tasks.Task<string> GetValidateUKBankAccountAsync(string AccountNo, string SortCode, string buildingSocietyRollNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicesChannel : CukAutomationOperations.MiscServices.IServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicesClient : System.ServiceModel.ClientBase<CukAutomationOperations.MiscServices.IServices>, CukAutomationOperations.MiscServices.IServices {
        
        public ServicesClient() {
        }
        
        public ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CukAutomationOperations.MiscServices.ValidateUKBankAccountResponseModel ValidateUKBankAccount(string sortCode, string accountNumber, string buildingSocietyRollNumber) {
            return base.Channel.ValidateUKBankAccount(sortCode, accountNumber, buildingSocietyRollNumber);
        }
        
        public System.Threading.Tasks.Task<CukAutomationOperations.MiscServices.ValidateUKBankAccountResponseModel> ValidateUKBankAccountAsync(string sortCode, string accountNumber, string buildingSocietyRollNumber) {
            return base.Channel.ValidateUKBankAccountAsync(sortCode, accountNumber, buildingSocietyRollNumber);
        }
        
        public void updateLocalData() {
            base.Channel.updateLocalData();
        }
        
        public System.Threading.Tasks.Task updateLocalDataAsync() {
            return base.Channel.updateLocalDataAsync();
        }
        
        public void BulkWebGiftToGMC(string base64data) {
            base.Channel.BulkWebGiftToGMC(base64data);
        }
        
        public System.Threading.Tasks.Task BulkWebGiftToGMCAsync(string base64data) {
            return base.Channel.BulkWebGiftToGMCAsync(base64data);
        }
        
        public string GetValidateUKBankAccount(string AccountNo, string SortCode, string buildingSocietyRollNumber) {
            return base.Channel.GetValidateUKBankAccount(AccountNo, SortCode, buildingSocietyRollNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetValidateUKBankAccountAsync(string AccountNo, string SortCode, string buildingSocietyRollNumber) {
            return base.Channel.GetValidateUKBankAccountAsync(AccountNo, SortCode, buildingSocietyRollNumber);
        }
    }
}