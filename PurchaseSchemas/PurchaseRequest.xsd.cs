namespace PurchaseSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://PurchaseFlow.Schemas.PurchaseRequest",@"PurchaseRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.UInt32), "customerId", XPath = @"/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='customerId' and namespace-uri()='']", XsdType = @"unsignedInt")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.UInt32), "productId", XPath = @"/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='productId' and namespace-uri()='']", XsdType = @"unsignedInt")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.UInt32), "quantity", XPath = @"/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='quantity' and namespace-uri()='']", XsdType = @"unsignedInt")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PurchaseRequest"})]
    public sealed class PurchaseRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://PurchaseFlow.Schemas.PurchaseRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://PurchaseFlow.Schemas.PurchaseRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PurchaseRequest"" type=""PurchaseRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='customerId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='productId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PurchaseRequest' and namespace-uri()='http://PurchaseFlow.Schemas.PurchaseRequest']/*[local-name()='quantity' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""PurchaseRequest"">
    <xs:sequence>
      <xs:element name=""customerId"" type=""xs:unsignedInt"" />
      <xs:element name=""productId"" type=""xs:unsignedInt"" />
      <xs:element name=""quantity"" type=""xs:unsignedInt"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public PurchaseRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PurchaseRequest";
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
