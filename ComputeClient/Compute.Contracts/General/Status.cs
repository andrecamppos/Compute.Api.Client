﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace DD.CBU.Compute.Api.Contracts.General
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.0.30319.18020")]
    [System.Serializable]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.General)]
    [XmlRoot(Namespace = XmlNamespaceConstants.General, IsNullable = false)]
    public class Status {
        /// <remarks/>
        public string operation { get; set; }

        /// <remarks/>
        public string result { get; set; }

        /// <remarks/>
        public string resultDetail { get; set; }

        /// <remarks/>
        public string resultCode { get; set; }

        /// <summary>
        /// The additional information
        /// </summary>
        [XmlElement("additionalInformation")]
        public AdditionalInformation[] additionalInformation { get; set; }
    }

    /// <summary>
    /// The additional information
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = XmlNamespaceConstants.General)]
    [XmlRoot(Namespace = XmlNamespaceConstants.General, IsNullable = false)]
    public class AdditionalInformation
    {
        /// <summary>
        /// The name
        /// </summary>
        [XmlAttribute]
        public string name { get; set; }

        /// <summary>
        /// The value
        /// </summary>
        public string value { get; set; }
    }
}