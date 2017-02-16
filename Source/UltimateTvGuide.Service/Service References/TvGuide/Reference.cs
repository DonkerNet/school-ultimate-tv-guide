﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UltimateTvGuide.Service.TvGuide {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://nl.school.ultimatetvguide/", ConfigurationName="TvGuide.TvGuide")]
    public interface TvGuide {
        
        // CODEGEN: Generating message contract since the operation GetGuide is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetGuide", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UltimateTvGuide.Service.TvGuide.GetGuideResponse GetGuide(UltimateTvGuide.Service.TvGuide.GetGuideRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="GetGuide", ReplyAction="*")]
        System.Threading.Tasks.Task<UltimateTvGuide.Service.TvGuide.GetGuideResponse> GetGuideAsync(UltimateTvGuide.Service.TvGuide.GetGuideRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://nl.school.ultimatetvguide.Schemas.GuideRequestIn")]
    public partial class GuideRequestIn : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string countryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://nl.school.ultimatetvguide.Schemas.Guide")]
    public partial class Guide : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string countryField;
        
        private string loadDateField;
        
        private GuideChannel[] channelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string LoadDate {
            get {
                return this.loadDateField;
            }
            set {
                this.loadDateField = value;
                this.RaisePropertyChanged("LoadDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public GuideChannel[] Channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
                this.RaisePropertyChanged("Channel");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://nl.school.ultimatetvguide.Schemas.Guide")]
    public partial class GuideChannel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string channelIdField;
        
        private string channelNameField;
        
        private string logoField;
        
        private GuideChannelShow[] showField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ChannelId {
            get {
                return this.channelIdField;
            }
            set {
                this.channelIdField = value;
                this.RaisePropertyChanged("ChannelId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ChannelName {
            get {
                return this.channelNameField;
            }
            set {
                this.channelNameField = value;
                this.RaisePropertyChanged("ChannelName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
                this.RaisePropertyChanged("Logo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Show", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public GuideChannelShow[] Show {
            get {
                return this.showField;
            }
            set {
                this.showField = value;
                this.RaisePropertyChanged("Show");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://nl.school.ultimatetvguide.Schemas.Guide")]
    public partial class GuideChannelShow : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string startTimeField;
        
        private string endTimeField;
        
        private decimal iMDBRatingField;
        
        private string plotField;
        
        private string logoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
                this.RaisePropertyChanged("StartTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
                this.RaisePropertyChanged("EndTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal IMDBRating {
            get {
                return this.iMDBRatingField;
            }
            set {
                this.iMDBRatingField = value;
                this.RaisePropertyChanged("IMDBRating");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Plot {
            get {
                return this.plotField;
            }
            set {
                this.plotField = value;
                this.RaisePropertyChanged("Plot");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
                this.RaisePropertyChanged("Logo");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGuideRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://nl.school.ultimatetvguide.Schemas.GuideRequestIn", Order=0)]
        public UltimateTvGuide.Service.TvGuide.GuideRequestIn GuideRequestIn;
        
        public GetGuideRequest() {
        }
        
        public GetGuideRequest(UltimateTvGuide.Service.TvGuide.GuideRequestIn GuideRequestIn) {
            this.GuideRequestIn = GuideRequestIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGuideResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://nl.school.ultimatetvguide.Schemas.Guide", Order=0)]
        public UltimateTvGuide.Service.TvGuide.Guide Guide;
        
        public GetGuideResponse() {
        }
        
        public GetGuideResponse(UltimateTvGuide.Service.TvGuide.Guide Guide) {
            this.Guide = Guide;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TvGuideChannel : UltimateTvGuide.Service.TvGuide.TvGuide, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TvGuideClient : System.ServiceModel.ClientBase<UltimateTvGuide.Service.TvGuide.TvGuide>, UltimateTvGuide.Service.TvGuide.TvGuide {
        
        public TvGuideClient() {
        }
        
        public TvGuideClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TvGuideClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TvGuideClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TvGuideClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UltimateTvGuide.Service.TvGuide.GetGuideResponse UltimateTvGuide.Service.TvGuide.TvGuide.GetGuide(UltimateTvGuide.Service.TvGuide.GetGuideRequest request) {
            return base.Channel.GetGuide(request);
        }
        
        public UltimateTvGuide.Service.TvGuide.Guide GetGuide(UltimateTvGuide.Service.TvGuide.GuideRequestIn GuideRequestIn) {
            UltimateTvGuide.Service.TvGuide.GetGuideRequest inValue = new UltimateTvGuide.Service.TvGuide.GetGuideRequest();
            inValue.GuideRequestIn = GuideRequestIn;
            UltimateTvGuide.Service.TvGuide.GetGuideResponse retVal = ((UltimateTvGuide.Service.TvGuide.TvGuide)(this)).GetGuide(inValue);
            return retVal.Guide;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UltimateTvGuide.Service.TvGuide.GetGuideResponse> UltimateTvGuide.Service.TvGuide.TvGuide.GetGuideAsync(UltimateTvGuide.Service.TvGuide.GetGuideRequest request) {
            return base.Channel.GetGuideAsync(request);
        }
        
        public System.Threading.Tasks.Task<UltimateTvGuide.Service.TvGuide.GetGuideResponse> GetGuideAsync(UltimateTvGuide.Service.TvGuide.GuideRequestIn GuideRequestIn) {
            UltimateTvGuide.Service.TvGuide.GetGuideRequest inValue = new UltimateTvGuide.Service.TvGuide.GetGuideRequest();
            inValue.GuideRequestIn = GuideRequestIn;
            return ((UltimateTvGuide.Service.TvGuide.TvGuide)(this)).GetGuideAsync(inValue);
        }
    }
}
