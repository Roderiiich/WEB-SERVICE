﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TRABAJO_CRUDF.AlumnosYAsignaturasWS {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MIWSPERUCASoap", Namespace="http://tempuri.org/")]
    public partial class MIWSPERUCA : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GuardarAlumnosOperationCompleted;
        
        private System.Threading.SendOrPostCallback GuardarAsignaturasOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarAsignaturaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MIWSPERUCA() {
            this.Url = global::TRABAJO_CRUDF.Properties.Settings.Default.TRABAJO_CRUDF_AlumnosYAsignaturasWS_MIWSPERUCA;
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
        public event GuardarAlumnosCompletedEventHandler GuardarAlumnosCompleted;
        
        /// <remarks/>
        public event GuardarAsignaturasCompletedEventHandler GuardarAsignaturasCompleted;
        
        /// <remarks/>
        public event ListarCompletedEventHandler ListarCompleted;
        
        /// <remarks/>
        public event ListarAsignaturaCompletedEventHandler ListarAsignaturaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GuardarAlumnos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GuardarAlumnos(string Nombre, string ApellidoPAt, string ApellidoMat, string Email, string N_Matricula) {
            object[] results = this.Invoke("GuardarAlumnos", new object[] {
                        Nombre,
                        ApellidoPAt,
                        ApellidoMat,
                        Email,
                        N_Matricula});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarAlumnosAsync(string Nombre, string ApellidoPAt, string ApellidoMat, string Email, string N_Matricula) {
            this.GuardarAlumnosAsync(Nombre, ApellidoPAt, ApellidoMat, Email, N_Matricula, null);
        }
        
        /// <remarks/>
        public void GuardarAlumnosAsync(string Nombre, string ApellidoPAt, string ApellidoMat, string Email, string N_Matricula, object userState) {
            if ((this.GuardarAlumnosOperationCompleted == null)) {
                this.GuardarAlumnosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarAlumnosOperationCompleted);
            }
            this.InvokeAsync("GuardarAlumnos", new object[] {
                        Nombre,
                        ApellidoPAt,
                        ApellidoMat,
                        Email,
                        N_Matricula}, this.GuardarAlumnosOperationCompleted, userState);
        }
        
        private void OnGuardarAlumnosOperationCompleted(object arg) {
            if ((this.GuardarAlumnosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarAlumnosCompleted(this, new GuardarAlumnosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GuardarAsignaturas", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GuardarAsignaturas(string NombreAsignatura, int Creditos) {
            object[] results = this.Invoke("GuardarAsignaturas", new object[] {
                        NombreAsignatura,
                        Creditos});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarAsignaturasAsync(string NombreAsignatura, int Creditos) {
            this.GuardarAsignaturasAsync(NombreAsignatura, Creditos, null);
        }
        
        /// <remarks/>
        public void GuardarAsignaturasAsync(string NombreAsignatura, int Creditos, object userState) {
            if ((this.GuardarAsignaturasOperationCompleted == null)) {
                this.GuardarAsignaturasOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarAsignaturasOperationCompleted);
            }
            this.InvokeAsync("GuardarAsignaturas", new object[] {
                        NombreAsignatura,
                        Creditos}, this.GuardarAsignaturasOperationCompleted, userState);
        }
        
        private void OnGuardarAsignaturasOperationCompleted(object arg) {
            if ((this.GuardarAsignaturasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarAsignaturasCompleted(this, new GuardarAsignaturasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Alumnos[] Listar() {
            object[] results = this.Invoke("Listar", new object[0]);
            return ((Alumnos[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarAsync() {
            this.ListarAsync(null);
        }
        
        /// <remarks/>
        public void ListarAsync(object userState) {
            if ((this.ListarOperationCompleted == null)) {
                this.ListarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarOperationCompleted);
            }
            this.InvokeAsync("Listar", new object[0], this.ListarOperationCompleted, userState);
        }
        
        private void OnListarOperationCompleted(object arg) {
            if ((this.ListarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarCompleted(this, new ListarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarAsignatura", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Asignaturas[] ListarAsignatura() {
            object[] results = this.Invoke("ListarAsignatura", new object[0]);
            return ((Asignaturas[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarAsignaturaAsync() {
            this.ListarAsignaturaAsync(null);
        }
        
        /// <remarks/>
        public void ListarAsignaturaAsync(object userState) {
            if ((this.ListarAsignaturaOperationCompleted == null)) {
                this.ListarAsignaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarAsignaturaOperationCompleted);
            }
            this.InvokeAsync("ListarAsignatura", new object[0], this.ListarAsignaturaOperationCompleted, userState);
        }
        
        private void OnListarAsignaturaOperationCompleted(object arg) {
            if ((this.ListarAsignaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarAsignaturaCompleted(this, new ListarAsignaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Alumnos {
        
        private int iDAlumnosField;
        
        private string nombreField;
        
        private string apellidoPAtField;
        
        private string apellidoMatField;
        
        private string emailField;
        
        private string n_MatriculaField;
        
        /// <remarks/>
        public int IDAlumnos {
            get {
                return this.iDAlumnosField;
            }
            set {
                this.iDAlumnosField = value;
            }
        }
        
        /// <remarks/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string ApellidoPAt {
            get {
                return this.apellidoPAtField;
            }
            set {
                this.apellidoPAtField = value;
            }
        }
        
        /// <remarks/>
        public string ApellidoMat {
            get {
                return this.apellidoMatField;
            }
            set {
                this.apellidoMatField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string N_Matricula {
            get {
                return this.n_MatriculaField;
            }
            set {
                this.n_MatriculaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Asignaturas {
        
        private int codigoAsignaturaField;
        
        private string nombreAsignaturaField;
        
        private int creditosField;
        
        /// <remarks/>
        public int CodigoAsignatura {
            get {
                return this.codigoAsignaturaField;
            }
            set {
                this.codigoAsignaturaField = value;
            }
        }
        
        /// <remarks/>
        public string NombreAsignatura {
            get {
                return this.nombreAsignaturaField;
            }
            set {
                this.nombreAsignaturaField = value;
            }
        }
        
        /// <remarks/>
        public int Creditos {
            get {
                return this.creditosField;
            }
            set {
                this.creditosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GuardarAlumnosCompletedEventHandler(object sender, GuardarAlumnosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarAlumnosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarAlumnosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GuardarAsignaturasCompletedEventHandler(object sender, GuardarAsignaturasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarAsignaturasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarAsignaturasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void ListarCompletedEventHandler(object sender, ListarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Alumnos[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Alumnos[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void ListarAsignaturaCompletedEventHandler(object sender, ListarAsignaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarAsignaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarAsignaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Asignaturas[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Asignaturas[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591