﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassicalConsoleApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/MyFirstWcfService")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArticalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string Artical {
            get {
                return this.ArticalField;
            }
            set {
                if ((object.ReferenceEquals(this.ArticalField, value) != true)) {
                    this.ArticalField = value;
                    this.RaisePropertyChanged("Artical");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/MyFirstWcfService")]
    [System.SerializableAttribute()]
    public partial class CustomException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InnerExceptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string ExceptionMessage {
            get {
                return this.ExceptionMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMessageField, value) != true)) {
                    this.ExceptionMessageField = value;
                    this.RaisePropertyChanged("ExceptionMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InnerException {
            get {
                return this.InnerExceptionField;
            }
            set {
                if ((object.ReferenceEquals(this.InnerExceptionField, value) != true)) {
                    this.InnerExceptionField = value;
                    this.RaisePropertyChanged("InnerException");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAuthorService")]
    public interface IAuthorService {
        
        // CODEGEN: Generating message contract since the wrapper name (AuthorRequest) of message AuthorRequest does not match the default value (GetInfo)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthorService/GetInfo", ReplyAction="http://tempuri.org/IAuthorService/GetInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClassicalConsoleApp.ServiceReference1.CustomException), Action="http://tempuri.org/IAuthorService/GetInfoCustomExceptionFault", Name="CustomException", Namespace="http://schemas.datacontract.org/2004/07/MyFirstWcfService")]
        ClassicalConsoleApp.ServiceReference1.AuthorResponse GetInfo(ClassicalConsoleApp.ServiceReference1.AuthorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthorService/GetInfo", ReplyAction="http://tempuri.org/IAuthorService/GetInfoResponse")]
        System.Threading.Tasks.Task<ClassicalConsoleApp.ServiceReference1.AuthorResponse> GetInfoAsync(ClassicalConsoleApp.ServiceReference1.AuthorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthorRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthorRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string AuthorId;
        
        public AuthorRequest() {
        }
        
        public AuthorRequest(string AuthorId) {
            this.AuthorId = AuthorId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClassicalConsoleApp.ServiceReference1.Author Author;
        
        public AuthorResponse() {
        }
        
        public AuthorResponse(ClassicalConsoleApp.ServiceReference1.Author Author) {
            this.Author = Author;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthorServiceChannel : ClassicalConsoleApp.ServiceReference1.IAuthorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthorServiceClient : System.ServiceModel.ClientBase<ClassicalConsoleApp.ServiceReference1.IAuthorService>, ClassicalConsoleApp.ServiceReference1.IAuthorService {
        
        public AuthorServiceClient() {
        }
        
        public AuthorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClassicalConsoleApp.ServiceReference1.AuthorResponse ClassicalConsoleApp.ServiceReference1.IAuthorService.GetInfo(ClassicalConsoleApp.ServiceReference1.AuthorRequest request) {
            return base.Channel.GetInfo(request);
        }
        
        public ClassicalConsoleApp.ServiceReference1.Author GetInfo(string AuthorId) {
            ClassicalConsoleApp.ServiceReference1.AuthorRequest inValue = new ClassicalConsoleApp.ServiceReference1.AuthorRequest();
            inValue.AuthorId = AuthorId;
            ClassicalConsoleApp.ServiceReference1.AuthorResponse retVal = ((ClassicalConsoleApp.ServiceReference1.IAuthorService)(this)).GetInfo(inValue);
            return retVal.Author;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClassicalConsoleApp.ServiceReference1.AuthorResponse> ClassicalConsoleApp.ServiceReference1.IAuthorService.GetInfoAsync(ClassicalConsoleApp.ServiceReference1.AuthorRequest request) {
            return base.Channel.GetInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClassicalConsoleApp.ServiceReference1.AuthorResponse> GetInfoAsync(string AuthorId) {
            ClassicalConsoleApp.ServiceReference1.AuthorRequest inValue = new ClassicalConsoleApp.ServiceReference1.AuthorRequest();
            inValue.AuthorId = AuthorId;
            return ((ClassicalConsoleApp.ServiceReference1.IAuthorService)(this)).GetInfoAsync(inValue);
        }
    }
}
