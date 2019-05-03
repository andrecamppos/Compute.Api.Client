using DD.CBU.Compute.Api.Contracts.Network20;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("reconfigureImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
public partial class ReconfigureImageType
{
    /// <remarks/>
    public ReconfigureImageTypeAdvancedVirtualizationSettings advancedVirtualizationSettings;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
public partial class ReconfigureImageTypeAdvancedVirtualizationSettings
{
    /// <remarks/>
    public bool nestedHardwareVirtualization
    {
        get { return this.nestedHardwareVirtualization; }
        set { this.nestedHardwareVirtualization = value; }
    }

    /// <remarks/>
    public string cpuLatencySensitivity
    {
        get { return this.cpuLatencySensitivity; }
        set { this.cpuLatencySensitivity = value; }
    }

    /// <remarks/>
    public bool numaAutosize
    {
        get { return this.numaAutosize; }
        set { this.numaAutosize = value; }
    }

    /// <remarks/>
    public bool enableHostInfoToVmTools
    {
        get { return this.enableHostInfoToVmTools; }
        set { this.enableHostInfoToVmTools = value; }
    }
}
