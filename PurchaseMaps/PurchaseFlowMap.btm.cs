namespace PurchaseMaps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PurchaseSchemas.PurchaseRequest", typeof(PurchaseSchemas.PurchaseRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PurchaseSchemas.PurchaseResponse", typeof(PurchaseSchemas.PurchaseResponse))]
    public sealed class PurchaseFlowMap : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://PurchaseFlow.Schemas.PurchaseRequest"" xmlns:ns0=""http://PurchaseFlow.Schemas.PurchaseResponse"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseRequest"">
    <ns0:PurchaseResponse>
      <ns0:customerId>
        <xsl:value-of select=""customerId/text()"" />
      </ns0:customerId>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:DBLookup(0 , string(productId/text()) , &quot;Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=PurchaseSampleDb;User Id=sa;Password=PFFYkev1;&quot; , &quot;dbo.Products&quot; , &quot;ProductId&quot;)"" />
      <xsl:variable name=""var:v2"" select=""ScriptNS0:DBValueExtract(string($var:v1) , &quot;Price&quot;)"" />
      <xsl:variable name=""var:v3"" select=""userCSharp:LogicalIsNumeric(string($var:v2))"" />
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""string(productId/text())"" />
        <xsl:variable name=""var:v5"" select=""ScriptNS0:DBLookup(0 , $var:v4 , &quot;Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=PurchaseSampleDb;User Id=sa;Password=PFFYkev1;&quot; , &quot;dbo.Products&quot; , &quot;ProductId&quot;)"" />
        <xsl:variable name=""var:v6"" select=""ScriptNS0:DBValueExtract(string($var:v5) , &quot;Price&quot;)"" />
        <ns0:price>
          <xsl:value-of select=""$var:v6"" />
        </ns0:price>
      </xsl:if>
      <xsl:variable name=""var:v7"" select=""userCSharp:LogicalIsNumeric(string($var:v2))"" />
      <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNot(string($var:v7))"" />
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v9"" select=""&quot;0&quot;"" />
        <ns0:price>
          <xsl:value-of select=""$var:v9"" />
        </ns0:price>
      </xsl:if>
      <xsl:variable name=""var:v10"" select=""ScriptNS0:DBLookup(1 , string(customerId/text()) , &quot;Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=PurchaseSampleDb;User Id=sa;Password=PFFYkev1;&quot; , &quot;dbo.Customers&quot; , &quot;CustomerId&quot;)"" />
      <xsl:variable name=""var:v11"" select=""ScriptNS0:DBValueExtract(string($var:v10) , &quot;Visits&quot;)"" />
      <xsl:variable name=""var:v12"" select=""userCSharp:LogicalIsNumeric(string($var:v11))"" />
      <xsl:if test=""string($var:v12)='true'"">
        <xsl:variable name=""var:v13"" select=""string(customerId/text())"" />
        <xsl:variable name=""var:v14"" select=""ScriptNS0:DBLookup(1 , $var:v13 , &quot;Provider=SQLOLEDB;Data Source=localhost;Initial Catalog=PurchaseSampleDb;User Id=sa;Password=PFFYkev1;&quot; , &quot;dbo.Customers&quot; , &quot;CustomerId&quot;)"" />
        <xsl:variable name=""var:v15"" select=""ScriptNS0:DBValueExtract(string($var:v14) , &quot;Visits&quot;)"" />
        <ns0:visits>
          <xsl:value-of select=""$var:v15"" />
        </ns0:visits>
      </xsl:if>
      <xsl:variable name=""var:v16"" select=""userCSharp:LogicalIsNumeric(string($var:v11))"" />
      <xsl:variable name=""var:v17"" select=""userCSharp:LogicalNot(string($var:v16))"" />
      <xsl:if test=""string($var:v17)='true'"">
        <xsl:variable name=""var:v18"" select=""&quot;0&quot;"" />
        <ns0:visits>
          <xsl:value-of select=""$var:v18"" />
        </ns0:visits>
      </xsl:if>
    </ns0:PurchaseResponse>
    <xsl:variable name=""var:v19"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalIsNumeric(string val)
{
	return IsNumeric(val);
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"PurchaseSchemas.PurchaseRequest";
        
        private const PurchaseSchemas.PurchaseRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PurchaseSchemas.PurchaseResponse";
        
        private const PurchaseSchemas.PurchaseResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"PurchaseSchemas.PurchaseRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PurchaseSchemas.PurchaseResponse";
                return _TrgSchemas;
            }
        }
    }
}
