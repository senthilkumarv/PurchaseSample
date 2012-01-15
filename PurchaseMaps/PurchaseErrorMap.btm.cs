namespace PurchaseMaps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PurchaseSchemas.PurchaseRequest", typeof(global::PurchaseSchemas.PurchaseRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PurchaseSchemas.ErrorSchema", typeof(global::PurchaseSchemas.ErrorSchema))]
    public sealed class PurchaseErrorMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://PurchaseFlow.Schemas.PurchaseRequest"" xmlns:ns0=""http://PurchaseFlowSchemas.ErrorSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;1001&quot;)"" />
    <ns0:Error>
      <Code>
        <xsl:value-of select=""$var:v1"" />
      </Code>
      <Message>
        <xsl:text>-</xsl:text>
      </Message>
    </ns0:Error>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PurchaseSchemas.PurchaseRequest";
        
        private const global::PurchaseSchemas.PurchaseRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PurchaseSchemas.ErrorSchema";
        
        private const global::PurchaseSchemas.ErrorSchema _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"PurchaseSchemas.ErrorSchema";
                return _TrgSchemas;
            }
        }
    }
}
