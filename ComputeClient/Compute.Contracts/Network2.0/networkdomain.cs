﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace DD.CBU.Compute.Api.Contracts {
    using System.Xml.Serialization;
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("networkDomain", Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
    public partial class NetworkDomain {
        
        private string nameField;
        
        private string descriptionField;
        
        private string typeField;
        
        private string snatIpv4AddressField;
        
        private string createTimeField;
        
        private string stateField;
        
        private ProgressType progressField;
        
        private string idField;
        
        private string datacenterIdField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string snatIpv4Address {
            get {
                return this.snatIpv4AddressField;
            }
            set {
                this.snatIpv4AddressField = value;
            }
        }
        
        /// <remarks/>
        public string createTime {
            get {
                return this.createTimeField;
            }
            set {
                this.createTimeField = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public ProgressType progress {
            get {
                return this.progressField;
            }
            set {
                this.progressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId {
            get {
                return this.datacenterIdField;
            }
            set {
                this.datacenterIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "networkDomains", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class NetworkDomains {
        
        private NetworkDomain[] networkDomainField;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int pageCountField;
        
        private bool pageCountFieldSpecified;
        
        private int totalCountField;
        
        private bool totalCountFieldSpecified;
        
        private int pageSizeField;
        
        private bool pageSizeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkDomain")]
        public NetworkDomain[] NetworkDomain {
            get {
                return this.networkDomainField;
            }
            set {
                this.networkDomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified {
            get {
                return this.pageNumberFieldSpecified;
            }
            set {
                this.pageNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount {
            get {
                return this.pageCountField;
            }
            set {
                this.pageCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified {
            get {
                return this.pageCountFieldSpecified;
            }
            set {
                this.pageCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount {
            get {
                return this.totalCountField;
            }
            set {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified {
            get {
                return this.totalCountFieldSpecified;
            }
            set {
                this.totalCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize {
            get {
                return this.pageSizeField;
            }
            set {
                this.pageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified {
            get {
                return this.pageSizeFieldSpecified;
            }
            set {
                this.pageSizeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deployNetworkDomain", Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
    public partial class DeployNetworkDomainType {
        
        private string datacenterIdField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string typeField;
        
        /// <remarks/>
        public string datacenterId {
            get {
                return this.datacenterIdField;
            }
            set {
                this.datacenterIdField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editNetworkDomain", Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
    public partial class EditNetworkDomainType {
        
        private string nameField;
        
        private string descriptionField;
        
        private string typeField;
        
        private string idField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
