﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketManagementMVC.LayoutService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LayoutService.IWcfLayoutService")]
    public interface IWcfLayoutService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/ToList", ReplyAction="http://tempuri.org/IWcfLayoutService/ToListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfBusinessLogic.Core.Contracts.Exceptions.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfLayoutService/ToListServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        WcfBusinessLogic.Core.Contracts.Data.Layout[] ToList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/ToList", ReplyAction="http://tempuri.org/IWcfLayoutService/ToListResponse")]
        System.Threading.Tasks.Task<WcfBusinessLogic.Core.Contracts.Data.Layout[]> ToListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenue", ReplyAction="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WcfBusinessLogic.Core.Contracts.Exceptions.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueServiceValidationFaultDetai" +
            "lsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        WcfBusinessLogic.Core.Contracts.Data.Layout[] GetLayoutsByVenue(int venueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenue", ReplyAction="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueResponse")]
        System.Threading.Tasks.Task<WcfBusinessLogic.Core.Contracts.Data.Layout[]> GetLayoutsByVenueAsync(int venueId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfLayoutServiceChannel : TicketManagementMVC.LayoutService.IWcfLayoutService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfLayoutServiceClient : System.ServiceModel.ClientBase<TicketManagementMVC.LayoutService.IWcfLayoutService>, TicketManagementMVC.LayoutService.IWcfLayoutService {
        
        public WcfLayoutServiceClient() {
        }
        
        public WcfLayoutServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfLayoutServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfLayoutServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfLayoutServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfBusinessLogic.Core.Contracts.Data.Layout[] ToList() {
            return base.Channel.ToList();
        }
        
        public System.Threading.Tasks.Task<WcfBusinessLogic.Core.Contracts.Data.Layout[]> ToListAsync() {
            return base.Channel.ToListAsync();
        }
        
        public WcfBusinessLogic.Core.Contracts.Data.Layout[] GetLayoutsByVenue(int venueId) {
            return base.Channel.GetLayoutsByVenue(venueId);
        }
        
        public System.Threading.Tasks.Task<WcfBusinessLogic.Core.Contracts.Data.Layout[]> GetLayoutsByVenueAsync(int venueId) {
            return base.Channel.GetLayoutsByVenueAsync(venueId);
        }
    }
}
