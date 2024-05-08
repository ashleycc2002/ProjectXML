
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MESSAGE {
    
    private MESSAGEHEADER hEADERField;
    
    private MESSAGECUSTOMERINFO cUSTOMERINFOField;
    
    private MESSAGEDATA dATAField;
    
    private string tYPEField;
    
    private byte vERSIONField;
    
    /// <remarks/>
    public MESSAGEHEADER HEADER {
        get {
            return this.hEADERField;
        }
        set {
            this.hEADERField = value;
        }
    }
    
    /// <remarks/>
    public MESSAGECUSTOMERINFO CUSTOMERINFO {
        get {
            return this.cUSTOMERINFOField;
        }
        set {
            this.cUSTOMERINFOField = value;
        }
    }
    
    /// <remarks/>
    public MESSAGEDATA DATA {
        get {
            return this.dATAField;
        }
        set {
            this.dATAField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TYPE {
        get {
            return this.tYPEField;
        }
        set {
            this.tYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte VERSION {
        get {
            return this.vERSIONField;
        }
        set {
            this.vERSIONField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MESSAGEHEADER {
    
    private string sERVERSOURCEField;
    
    private string sERVICESOURCEField;
    
    private string sERVICEDESTINATIONField;
    
    private string cORRELATIONIDField;
    
    private string cHANNELField;
    
    private string fUNCTIONField;
    
    private string lANGUAGEField;
    
    private string cOUNTRYField;
    
    private byte sESSIONIDField;
    
    private string sERVER_IPField;
    
    /// <remarks/>
    public string SERVERSOURCE {
        get {
            return this.sERVERSOURCEField;
        }
        set {
            this.sERVERSOURCEField = value;
        }
    }
    
    /// <remarks/>
    public string SERVICESOURCE {
        get {
            return this.sERVICESOURCEField;
        }
        set {
            this.sERVICESOURCEField = value;
        }
    }
    
    /// <remarks/>
    public string SERVICEDESTINATION {
        get {
            return this.sERVICEDESTINATIONField;
        }
        set {
            this.sERVICEDESTINATIONField = value;
        }
    }
    
    /// <remarks/>
    public string CORRELATIONID {
        get {
            return this.cORRELATIONIDField;
        }
        set {
            this.cORRELATIONIDField = value;
        }
    }
    
    /// <remarks/>
    public string CHANNEL {
        get {
            return this.cHANNELField;
        }
        set {
            this.cHANNELField = value;
        }
    }
    
    /// <remarks/>
    public string FUNCTION {
        get {
            return this.fUNCTIONField;
        }
        set {
            this.fUNCTIONField = value;
        }
    }
    
    /// <remarks/>
    public string LANGUAGE {
        get {
            return this.lANGUAGEField;
        }
        set {
            this.lANGUAGEField = value;
        }
    }
    
    /// <remarks/>
    public string COUNTRY {
        get {
            return this.cOUNTRYField;
        }
        set {
            this.cOUNTRYField = value;
        }
    }
    
    /// <remarks/>
    public byte SESSIONID {
        get {
            return this.sESSIONIDField;
        }
        set {
            this.sESSIONIDField = value;
        }
    }
    
    /// <remarks/>
    public string SERVER_IP {
        get {
            return this.sERVER_IPField;
        }
        set {
            this.sERVER_IPField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MESSAGECUSTOMERINFO {
    
    private string dOCUMENTTYPEField;
    
    private uint dOCUMENTNUMBERField;
    
    private string uSERIDField;
    
    private string cUSTOMERTYPEField;
    
    private string cUSTOMERSEGMENTField;
    
    private byte pARENTCUSTOMERIDField;
    
    private byte cUSTOMERIDField;
    
    private string cHILDDOCUMENTTYPEField;
    
    private object cHILDDOCUMENTNUMBERField;
    
    private string cUSTOMERNAMEField;
    
    private string cUSTOMERTYPE1Field;
    
    private string cUSTOMERSEGMENT1Field;
    
    private string eMAILField;
    
    private byte cUSTOMERBRANCHField;
    
    /// <remarks/>
    public string DOCUMENTTYPE {
        get {
            return this.dOCUMENTTYPEField;
        }
        set {
            this.dOCUMENTTYPEField = value;
        }
    }
    
    /// <remarks/>
    public uint DOCUMENTNUMBER {
        get {
            return this.dOCUMENTNUMBERField;
        }
        set {
            this.dOCUMENTNUMBERField = value;
        }
    }
    
    /// <remarks/>
    public string USERID {
        get {
            return this.uSERIDField;
        }
        set {
            this.uSERIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CUSTOMER-TYPE")]
    public string CUSTOMERTYPE {
        get {
            return this.cUSTOMERTYPEField;
        }
        set {
            this.cUSTOMERTYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CUSTOMER-SEGMENT")]
    public string CUSTOMERSEGMENT {
        get {
            return this.cUSTOMERSEGMENTField;
        }
        set {
            this.cUSTOMERSEGMENTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PARENT-CUSTOMERID")]
    public byte PARENTCUSTOMERID {
        get {
            return this.pARENTCUSTOMERIDField;
        }
        set {
            this.pARENTCUSTOMERIDField = value;
        }
    }
    
    /// <remarks/>
    public byte CUSTOMERID {
        get {
            return this.cUSTOMERIDField;
        }
        set {
            this.cUSTOMERIDField = value;
        }
    }
    
    /// <remarks/>
    public string CHILDDOCUMENTTYPE {
        get {
            return this.cHILDDOCUMENTTYPEField;
        }
        set {
            this.cHILDDOCUMENTTYPEField = value;
        }
    }
    
    /// <remarks/>
    public object CHILDDOCUMENTNUMBER {
        get {
            return this.cHILDDOCUMENTNUMBERField;
        }
        set {
            this.cHILDDOCUMENTNUMBERField = value;
        }
    }
    
    /// <remarks/>
    public string CUSTOMERNAME {
        get {
            return this.cUSTOMERNAMEField;
        }
        set {
            this.cUSTOMERNAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CUSTOMERTYPE")]
    public string CUSTOMERTYPE1 {
        get {
            return this.cUSTOMERTYPE1Field;
        }
        set {
            this.cUSTOMERTYPE1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CUSTOMERSEGMENT")]
    public string CUSTOMERSEGMENT1 {
        get {
            return this.cUSTOMERSEGMENT1Field;
        }
        set {
            this.cUSTOMERSEGMENT1Field = value;
        }
    }
    
    /// <remarks/>
    public string EMAIL {
        get {
            return this.eMAILField;
        }
        set {
            this.eMAILField = value;
        }
    }
    
    /// <remarks/>
    public byte CUSTOMERBRANCH {
        get {
            return this.cUSTOMERBRANCHField;
        }
        set {
            this.cUSTOMERBRANCHField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MESSAGEDATA {
    
    private MESSAGEDATACOUNTRY cOUNTRYField;
    
    /// <remarks/>
    public MESSAGEDATACOUNTRY COUNTRY {
        get {
            return this.cOUNTRYField;
        }
        set {
            this.cOUNTRYField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MESSAGEDATACOUNTRY {
    
    private ushort iNTERNALIDField;
    
    private ushort cITYCODEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INTERNAL-ID")]
    public ushort INTERNALID {
        get {
            return this.iNTERNALIDField;
        }
        set {
            this.iNTERNALIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CITY-CODE")]
    public ushort CITYCODE {
        get {
            return this.cITYCODEField;
        }
        set {
            this.cITYCODEField = value;
        }
    }
}



// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class EstucturaDatos
{

    private EstucturaDatosEmpleado empleadoField;

    private EstucturaDatosDepartamento[] departamentoField;

    /// <remarks/>
    public EstucturaDatosEmpleado Empleado
    {
        get
        {
            return this.empleadoField;
        }
        set
        {
            this.empleadoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Departamento")]
    public EstucturaDatosDepartamento[] Departamento
    {
        get
        {
            return this.departamentoField;
        }
        set
        {
            this.departamentoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class EstucturaDatosEmpleado
{

    private byte idField;

    private string nombreField;

    private string apellidoField;

    private string emailField;

    private string fechaIngresoField;

    private string activoField;

    /// <remarks/>
    public byte ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    /// <remarks/>
    public string Apellido
    {
        get
        {
            return this.apellidoField;
        }
        set
        {
            this.apellidoField = value;
        }
    }

    /// <remarks/>
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public string FechaIngreso
    {
        get
        {
            return this.fechaIngresoField;
        }
        set
        {
            this.fechaIngresoField = value;
        }
    }

    /// <remarks/>
    public string Activo
    {
        get
        {
            return this.activoField;
        }
        set
        {
            this.activoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class EstucturaDatosDepartamento
{

    private ushort idField;

    private string nameField;

    /// <remarks/>
    public ushort ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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
}

