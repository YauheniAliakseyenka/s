﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketManagementMVC.VenueService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Venue", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Venue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TicketManagementMVC.VenueService.Layout[] LayoutListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameWithOffsetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimezoneField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
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
        public TicketManagementMVC.VenueService.Layout[] LayoutList {
            get {
                return this.LayoutListField;
            }
            set {
                if ((object.ReferenceEquals(this.LayoutListField, value) != true)) {
                    this.LayoutListField = value;
                    this.RaisePropertyChanged("LayoutList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameWithOffset {
            get {
                return this.NameWithOffsetField;
            }
            set {
                if ((object.ReferenceEquals(this.NameWithOffsetField, value) != true)) {
                    this.NameWithOffsetField = value;
                    this.RaisePropertyChanged("NameWithOffset");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Timezone {
            get {
                return this.TimezoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TimezoneField, value) != true)) {
                    this.TimezoneField = value;
                    this.RaisePropertyChanged("Timezone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Layout", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Layout : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TicketManagementMVC.VenueService.Area[] AreaListField;
        
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
        public TicketManagementMVC.VenueService.Area[] AreaList {
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
        private TicketManagementMVC.VenueService.Seat[] SeatListField;
        
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
        public TicketManagementMVC.VenueService.Seat[] SeatList {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VenueService.IWcfVenueService")]
    public interface IWcfVenueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Create", ReplyAction="http://tempuri.org/IWcfVenueService/CreateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.VenueService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfVenueService/CreateServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        int Create(TicketManagementMVC.VenueService.Venue entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Create", ReplyAction="http://tempuri.org/IWcfVenueService/CreateResponse")]
        System.Threading.Tasks.Task<int> CreateAsync(TicketManagementMVC.VenueService.Venue entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Update", ReplyAction="http://tempuri.org/IWcfVenueService/UpdateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.VenueService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfVenueService/UpdateServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        void Update(TicketManagementMVC.VenueService.Venue entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Update", ReplyAction="http://tempuri.org/IWcfVenueService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(TicketManagementMVC.VenueService.Venue entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Delete", ReplyAction="http://tempuri.org/IWcfVenueService/DeleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.VenueService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfVenueService/DeleteServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Delete", ReplyAction="http://tempuri.org/IWcfVenueService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Get", ReplyAction="http://tempuri.org/IWcfVenueService/GetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.VenueService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfVenueService/GetServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        TicketManagementMVC.VenueService.Venue Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/Get", ReplyAction="http://tempuri.org/IWcfVenueService/GetResponse")]
        System.Threading.Tasks.Task<TicketManagementMVC.VenueService.Venue> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/ToList", ReplyAction="http://tempuri.org/IWcfVenueService/ToListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TicketManagementMVC.VenueService.ServiceValidationFaultDetails), Action="http://tempuri.org/IWcfVenueService/ToListServiceValidationFaultDetailsFault", Name="ServiceValidationFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfBusinessLogic.Core.Contracts.Exception" +
            "s")]
        TicketManagementMVC.VenueService.Venue[] ToList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfVenueService/ToList", ReplyAction="http://tempuri.org/IWcfVenueService/ToListResponse")]
        System.Threading.Tasks.Task<TicketManagementMVC.VenueService.Venue[]> ToListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfVenueServiceChannel : TicketManagementMVC.VenueService.IWcfVenueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfVenueServiceClient : System.ServiceModel.ClientBase<TicketManagementMVC.VenueService.IWcfVenueService>, TicketManagementMVC.VenueService.IWcfVenueService {
        
        public WcfVenueServiceClient() {
        }
        
        public WcfVenueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfVenueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfVenueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfVenueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Create(TicketManagementMVC.VenueService.Venue entity) {
            return base.Channel.Create(entity);
        }
        
        public System.Threading.Tasks.Task<int> CreateAsync(TicketManagementMVC.VenueService.Venue entity) {
            return base.Channel.CreateAsync(entity);
        }
        
        public void Update(TicketManagementMVC.VenueService.Venue entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(TicketManagementMVC.VenueService.Venue entity) {
            return base.Channel.UpdateAsync(entity);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public TicketManagementMVC.VenueService.Venue Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<TicketManagementMVC.VenueService.Venue> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public TicketManagementMVC.VenueService.Venue[] ToList() {
            return base.Channel.ToList();
        }
        
        public System.Threading.Tasks.Task<TicketManagementMVC.VenueService.Venue[]> ToListAsync() {
            return base.Channel.ToListAsync();
        }
    }
}