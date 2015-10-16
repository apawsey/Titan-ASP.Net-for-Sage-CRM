﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace PortalClient.localhost {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback PortalLogonOperationCompleted;
        
        private System.Threading.SendOrPostCallback PortalLogoutOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCompanyNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCompanyWebSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCasesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::PortalClient.Properties.Settings.Default.PortalClient_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event PortalLogonCompletedEventHandler PortalLogonCompleted;
        
        /// <remarks/>
        public event PortalLogoutCompletedEventHandler PortalLogoutCompleted;
        
        /// <remarks/>
        public event getCompanyNameCompletedEventHandler getCompanyNameCompleted;
        
        /// <remarks/>
        public event getCompanyWebSiteCompletedEventHandler getCompanyWebSiteCompleted;
        
        /// <remarks/>
        public event getCasesCompletedEventHandler getCasesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PortalLogon", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool PortalLogon(string username, string password) {
            object[] results = this.Invoke("PortalLogon", new object[] {
                        username,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PortalLogonAsync(string username, string password) {
            this.PortalLogonAsync(username, password, null);
        }
        
        /// <remarks/>
        public void PortalLogonAsync(string username, string password, object userState) {
            if ((this.PortalLogonOperationCompleted == null)) {
                this.PortalLogonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPortalLogonOperationCompleted);
            }
            this.InvokeAsync("PortalLogon", new object[] {
                        username,
                        password}, this.PortalLogonOperationCompleted, userState);
        }
        
        private void OnPortalLogonOperationCompleted(object arg) {
            if ((this.PortalLogonCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PortalLogonCompleted(this, new PortalLogonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PortalLogout", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool PortalLogout() {
            object[] results = this.Invoke("PortalLogout", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PortalLogoutAsync() {
            this.PortalLogoutAsync(null);
        }
        
        /// <remarks/>
        public void PortalLogoutAsync(object userState) {
            if ((this.PortalLogoutOperationCompleted == null)) {
                this.PortalLogoutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPortalLogoutOperationCompleted);
            }
            this.InvokeAsync("PortalLogout", new object[0], this.PortalLogoutOperationCompleted, userState);
        }
        
        private void OnPortalLogoutOperationCompleted(object arg) {
            if ((this.PortalLogoutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PortalLogoutCompleted(this, new PortalLogoutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCompanyName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCompanyName() {
            object[] results = this.Invoke("getCompanyName", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCompanyNameAsync() {
            this.getCompanyNameAsync(null);
        }
        
        /// <remarks/>
        public void getCompanyNameAsync(object userState) {
            if ((this.getCompanyNameOperationCompleted == null)) {
                this.getCompanyNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCompanyNameOperationCompleted);
            }
            this.InvokeAsync("getCompanyName", new object[0], this.getCompanyNameOperationCompleted, userState);
        }
        
        private void OngetCompanyNameOperationCompleted(object arg) {
            if ((this.getCompanyNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCompanyNameCompleted(this, new getCompanyNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCompanyWebSite", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCompanyWebSite() {
            object[] results = this.Invoke("getCompanyWebSite", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCompanyWebSiteAsync() {
            this.getCompanyWebSiteAsync(null);
        }
        
        /// <remarks/>
        public void getCompanyWebSiteAsync(object userState) {
            if ((this.getCompanyWebSiteOperationCompleted == null)) {
                this.getCompanyWebSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCompanyWebSiteOperationCompleted);
            }
            this.InvokeAsync("getCompanyWebSite", new object[0], this.getCompanyWebSiteOperationCompleted, userState);
        }
        
        private void OngetCompanyWebSiteOperationCompleted(object arg) {
            if ((this.getCompanyWebSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCompanyWebSiteCompleted(this, new getCompanyWebSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCases", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getCases() {
            object[] results = this.Invoke("getCases", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getCasesAsync() {
            this.getCasesAsync(null);
        }
        
        /// <remarks/>
        public void getCasesAsync(object userState) {
            if ((this.getCasesOperationCompleted == null)) {
                this.getCasesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCasesOperationCompleted);
            }
            this.InvokeAsync("getCases", new object[0], this.getCasesOperationCompleted, userState);
        }
        
        private void OngetCasesOperationCompleted(object arg) {
            if ((this.getCasesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCasesCompleted(this, new getCasesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void PortalLogonCompletedEventHandler(object sender, PortalLogonCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PortalLogonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PortalLogonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void PortalLogoutCompletedEventHandler(object sender, PortalLogoutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PortalLogoutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PortalLogoutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void getCompanyNameCompletedEventHandler(object sender, getCompanyNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCompanyNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCompanyNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void getCompanyWebSiteCompletedEventHandler(object sender, getCompanyWebSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCompanyWebSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCompanyWebSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void getCasesCompletedEventHandler(object sender, getCasesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCasesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCasesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591