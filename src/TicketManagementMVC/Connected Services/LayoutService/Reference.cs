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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Layout", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Layout : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TicketManagementMVC.LayoutService.Area[] AreaListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VenueIdField;
        
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
        public TicketManagementMVC.LayoutService.Area[] AreaList {
            get {
                return this.AreaListField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaListField, value) != true)) {
                    this.AreaListField = value;
                    this.RaisePropertyChanged("AreaList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VenueId {
            get {
                return this.VenueIdField;
            }
            set {
                if ((this.VenueIdField.Equals(value) != true)) {
                    this.VenueIdField = value;
                    this.RaisePropertyChanged("VenueId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Area", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Area : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CoordXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CoordYField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LayoutIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TicketManagementMVC.LayoutService.Seat[] SeatListField;
        
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
        public int CoordX {
            get {
                return this.CoordXField;
            }
            set {
                if ((this.CoordXField.Equals(value) != true)) {
                    this.CoordXField = value;
                    this.RaisePropertyChanged("CoordX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CoordY {
            get {
                return this.CoordYField;
            }
            set {
                if ((this.CoordYField.Equals(value) != true)) {
                    this.CoordYField = value;
                    this.RaisePropertyChanged("CoordY");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LayoutId {
            get {
                return this.LayoutIdField;
            }
            set {
                if ((this.LayoutIdField.Equals(value) != true)) {
                    this.LayoutIdField = value;
                    this.RaisePropertyChanged("LayoutId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TicketManagementMVC.LayoutService.Seat[] SeatList {
            get {
                return this.SeatListField;
            }
            set {
                if ((object.ReferenceEquals(this.SeatListField, value) != true)) {
                    this.SeatListField = value;
                    this.RaisePropertyChanged("SeatList");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Seat", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Seat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AreaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RowField;
        
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
        public int AreaId {
            get {
                return this.AreaIdField;
            }
            set {
                if ((this.AreaIdField.Equals(value) != true)) {
                    this.AreaIdField = value;
                    this.RaisePropertyChanged("AreaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Row {
            get {
                return this.RowField;
            }
            set {
                if ((this.RowField.Equals(value) != true)) {
                    this.RowField = value;
                    this.RaisePropertyChanged("Row");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
        "s")]
    [System.SerializableAttribute()]
    public partial class ServiceValidationFaultDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LayoutService.IWcfLayoutService")]
    public interface IWcfLayoutService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/ToList", ReplyAction="http://tempuri.org/IWcfLayoutService/ToListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.LayoutService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfLayoutService/ToListServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        TicketManagementMVC.LayoutService.Layout[] ToList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/ToList", ReplyAction="http://tempuri.org/IWcfLayoutService/ToListResponse")]
        System.Threading.Tasks.Task<TicketManagementMVC.LayoutService.Layout[]> ToListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenue", ReplyAction="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.LayoutService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueServiceValidationFaultDetai" +
            "lsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        TicketManagementMVC.LayoutService.Layout[] GetLayoutsByVenue(int venueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenue", ReplyAction="http://tempuri.org/IWcfLayoutService/GetLayoutsByVenueResponse")]
        System.Threading.Tasks.Task<TicketManagementMVC.LayoutService.Layout[]> GetLayoutsByVenueAsync(int venueId);
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
        
        public TicketManagementMVC.LayoutService.Layout[] ToList() {
            return base.Channel.ToList();
        }
        
        public System.Threading.Tasks.Task<TicketManagementMVC.LayoutService.Layout[]> ToListAsync() {
            return base.Channel.ToListAsync();
        }
        
        public TicketManagementMVC.LayoutService.Layout[] GetLayoutsByVenue(int venueId) {
            return base.Channel.GetLayoutsByVenue(venueId);
        }
        
        public System.Threading.Tasks.Task<TicketManagementMVC.LayoutService.Layout[]> GetLayoutsByVenueAsync(int venueId) {
            return base.Channel.GetLayoutsByVenueAsync(venueId);
        }
    }
}