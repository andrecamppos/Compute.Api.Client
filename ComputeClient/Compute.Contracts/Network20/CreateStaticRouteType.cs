﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("createStaticRoute", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
public partial class CreateStaticRouteType
{

	private string networkDomainIdField;

	private string nameField;

	private string descriptionField;

	private string ipVersionField;

	private string destinationNetworkAddressField;

	private int destinationPrefixSizeField;

	private string nextHopAddressField;

	/// <remarks/>
	public string networkDomainId
	{
		get
		{
			return this.networkDomainIdField;
		}
		set
		{
			this.networkDomainIdField = value;
		}
	}

	/// <remarks/>
	public string name
	{
		get
		{
			return this.nameField;
		}
		set
		{
			this.nameField = value;
		}
	}

	/// <remarks/>
	public string description
	{
		get
		{
			return this.descriptionField;
		}
		set
		{
			this.descriptionField = value;
		}
	}

	/// <remarks/>
	public string ipVersion
	{
		get
		{
			return this.ipVersionField;
		}
		set
		{
			this.ipVersionField = value;
		}
	}

	/// <remarks/>
	public string destinationNetworkAddress
	{
		get
		{
			return this.destinationNetworkAddressField;
		}
		set
		{
			this.destinationNetworkAddressField = value;
		}
	}

	/// <remarks/>
	public int destinationPrefixSize
	{
		get
		{
			return this.destinationPrefixSizeField;
		}
		set
		{
			this.destinationPrefixSizeField = value;
		}
	}

	/// <remarks/>
	public string nextHopAddress
	{
		get
		{
			return this.nextHopAddressField;
		}
		set
		{
			this.nextHopAddressField = value;
		}
	}
}