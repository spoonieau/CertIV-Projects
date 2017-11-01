﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26323.1
// 
namespace Ultimate_GamingPCsUWP.WebServiceUGP {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PcDetails", Namespace="http://tempuri.org/")]
    public partial class PcDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ProductCodeField;
        
        private string ProductTitleField;
        
        private string ProductDescriptionField;
        
        private decimal ProductPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProductCode {
            get {
                return this.ProductCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductCodeField, value) != true)) {
                    this.ProductCodeField = value;
                    this.RaisePropertyChanged("ProductCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProductTitle {
            get {
                return this.ProductTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductTitleField, value) != true)) {
                    this.ProductTitleField = value;
                    this.RaisePropertyChanged("ProductTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ProductDescription {
            get {
                return this.ProductDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescriptionField, value) != true)) {
                    this.ProductDescriptionField = value;
                    this.RaisePropertyChanged("ProductDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal ProductPrice {
            get {
                return this.ProductPriceField;
            }
            set {
                if ((this.ProductPriceField.Equals(value) != true)) {
                    this.ProductPriceField = value;
                    this.RaisePropertyChanged("ProductPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceUGP.UGPWebServiceSoap")]
    public interface UGPWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPcDetails", ReplyAction="*")]
        System.Threading.Tasks.Task<Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsResponse> GetPcDetailsAsync(Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPcDetailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPcDetails", Namespace="http://tempuri.org/", Order=0)]
        public Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequestBody Body;
        
        public GetPcDetailsRequest() {
        }
        
        public GetPcDetailsRequest(Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPcDetailsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ProductCode;
        
        public GetPcDetailsRequestBody() {
        }
        
        public GetPcDetailsRequestBody(string ProductCode) {
            this.ProductCode = ProductCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPcDetailsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPcDetailsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsResponseBody Body;
        
        public GetPcDetailsResponse() {
        }
        
        public GetPcDetailsResponse(Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPcDetailsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Ultimate_GamingPCsUWP.WebServiceUGP.PcDetails GetPcDetailsResult;
        
        public GetPcDetailsResponseBody() {
        }
        
        public GetPcDetailsResponseBody(Ultimate_GamingPCsUWP.WebServiceUGP.PcDetails GetPcDetailsResult) {
            this.GetPcDetailsResult = GetPcDetailsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UGPWebServiceSoapChannel : Ultimate_GamingPCsUWP.WebServiceUGP.UGPWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UGPWebServiceSoapClient : System.ServiceModel.ClientBase<Ultimate_GamingPCsUWP.WebServiceUGP.UGPWebServiceSoap>, Ultimate_GamingPCsUWP.WebServiceUGP.UGPWebServiceSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UGPWebServiceSoapClient() : 
                base(UGPWebServiceSoapClient.GetDefaultBinding(), UGPWebServiceSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.UGPWebServiceSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UGPWebServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(UGPWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), UGPWebServiceSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UGPWebServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UGPWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UGPWebServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UGPWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UGPWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsResponse> Ultimate_GamingPCsUWP.WebServiceUGP.UGPWebServiceSoap.GetPcDetailsAsync(Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequest request) {
            return base.Channel.GetPcDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsResponse> GetPcDetailsAsync(string ProductCode) {
            Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequest inValue = new Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequest();
            inValue.Body = new Ultimate_GamingPCsUWP.WebServiceUGP.GetPcDetailsRequestBody();
            inValue.Body.ProductCode = ProductCode;
            return ((Ultimate_GamingPCsUWP.WebServiceUGP.UGPWebServiceSoap)(this)).GetPcDetailsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.UGPWebServiceSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.UGPWebServiceSoap)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:50858/UGPWebService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return UGPWebServiceSoapClient.GetBindingForEndpoint(EndpointConfiguration.UGPWebServiceSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return UGPWebServiceSoapClient.GetEndpointAddress(EndpointConfiguration.UGPWebServiceSoap);
        }
        
        public enum EndpointConfiguration {
            
            UGPWebServiceSoap,
        }
    }
}
