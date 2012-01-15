namespace PurchaseSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://PurchaseFlow.Schemas.PurchaseResponse",@"PurchaseResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.UInt32), "customerId", XPath = @"/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='customerId' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']", XsdType = @"unsignedInt")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Decimal), "price", XPath = @"/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='price' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']", XsdType = @"decimal")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.UInt32), "visits", XPath = @"/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='visits' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']", XsdType = @"unsignedInt")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "message", XPath = @"/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='message' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PurchaseResponse"})]
    public sealed class PurchaseResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://PurchaseFlow.Schemas.PurchaseResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://PurchaseFlow.Schemas.PurchaseResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PurchaseResponse"" type=""PurchaseResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='customerId' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='price' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='visits' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseResponse' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']/*[local-name()='message' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseResponse']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""PurchaseResponse"">
    <xs:sequence>
      <xs:element default=""0"" name=""customerId"" type=""xs:unsignedInt"" />
      <xs:element default=""0"" name=""price"" type=""xs:decimal"" />
      <xs:element default=""0"" name=""visits"" type=""xs:unsignedInt"" />
      <xs:element name=""message"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public PurchaseResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PurchaseResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
