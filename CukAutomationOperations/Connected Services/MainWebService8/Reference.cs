﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CukAutomationOperations.MainWebService8 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainWebService8.IMainServices")]
    public interface IMainServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainServices/IAmOneWayMessagingPattern", ReplyAction="http://tempuri.org/IMainServices/IAmOneWayMessagingPatternResponse")]
        void IAmOneWayMessagingPattern(string jsonpayload, int action);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainServices/IAmOneWayMessagingPattern", ReplyAction="http://tempuri.org/IMainServices/IAmOneWayMessagingPatternResponse")]
        System.Threading.Tasks.Task IAmOneWayMessagingPatternAsync(string jsonpayload, int action);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainServices/IAmFullDuplexMessagingPattern", ReplyAction="http://tempuri.org/IMainServices/IAmFullDuplexMessagingPatternResponse")]
        string IAmFullDuplexMessagingPattern(string JsonString, int action);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainServices/IAmFullDuplexMessagingPattern", ReplyAction="http://tempuri.org/IMainServices/IAmFullDuplexMessagingPatternResponse")]
        System.Threading.Tasks.Task<string> IAmFullDuplexMessagingPatternAsync(string JsonString, int action);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainServicesChannel : CukAutomationOperations.MainWebService8.IMainServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServicesClient : System.ServiceModel.ClientBase<CukAutomationOperations.MainWebService8.IMainServices>, CukAutomationOperations.MainWebService8.IMainServices {
        
        public MainServicesClient() {
        }
        
        public MainServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void IAmOneWayMessagingPattern(string jsonpayload, int action) {
            base.Channel.IAmOneWayMessagingPattern(jsonpayload, action);
        }
        
        public System.Threading.Tasks.Task IAmOneWayMessagingPatternAsync(string jsonpayload, int action) {
            return base.Channel.IAmOneWayMessagingPatternAsync(jsonpayload, action);
        }
        
        public string IAmFullDuplexMessagingPattern(string JsonString, int action) {
            return base.Channel.IAmFullDuplexMessagingPattern(JsonString, action);
        }
        
        public System.Threading.Tasks.Task<string> IAmFullDuplexMessagingPatternAsync(string JsonString, int action) {
            return base.Channel.IAmFullDuplexMessagingPatternAsync(JsonString, action);
        }
    }
}
