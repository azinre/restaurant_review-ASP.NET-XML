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
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurants {
    
    private restaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("restaurant")]
    public restaurant[] restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurant {
    
    private basicinfo basicinfoField;
    
    private review reviewField;
    
    private menu menuField;
    
    /// <remarks/>
    public basicinfo basicinfo {
        get {
            return this.basicinfoField;
        }
        set {
            this.basicinfoField = value;
        }
    }
    
    /// <remarks/>
    public review review {
        get {
            return this.reviewField;
        }
        set {
            this.reviewField = value;
        }
    }
    
    /// <remarks/>
    public menu menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class basicinfo {
    
    private string nameOfResaurantField;
    
    private string websiteField;
    
    private logo logoField;
    
    private address addressField;
    
    private string phoneField;
    
    private rateRange ratingField;
    
    private string cuisineField;
    
    private rateRange priceRatingField;
    
    /// <remarks/>
    public string nameOfResaurant {
        get {
            return this.nameOfResaurantField;
        }
        set {
            this.nameOfResaurantField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    public logo logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    public address address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    public rateRange rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    public string cuisine {
        get {
            return this.cuisineField;
        }
        set {
            this.cuisineField = value;
        }
    }
    
    /// <remarks/>
    public rateRange priceRating {
        get {
            return this.priceRatingField;
        }
        set {
            this.priceRatingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class logo {
    
    private string urlField;
    
    private dimensionType heightField;
    
    private dimensionType widthField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
    public string url {
        get {
            return this.urlField;
        }
        set {
            this.urlField = value;
        }
    }
    
    /// <remarks/>
    public dimensionType height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    public dimensionType width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class dimensionType {
    
    private string unitField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="integer")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public partial class NameType {
    
    private string firstField;
    
    private string middleField;
    
    private string lastField;
    
    /// <remarks/>
    public string first {
        get {
            return this.firstField;
        }
        set {
            this.firstField = value;
        }
    }
    
    /// <remarks/>
    public string middle {
        get {
            return this.middleField;
        }
        set {
            this.middleField = value;
        }
    }
    
    /// <remarks/>
    public string last {
        get {
            return this.lastField;
        }
        set {
            this.lastField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class address {
    
    private string streetField;
    
    private string cityField;
    
    private ProvinceType provinceField;
    
    private string postalcodeField;
    
    /// <remarks/>
    public string street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    public string city {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public ProvinceType province {
        get {
            return this.provinceField;
        }
        set {
            this.provinceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("postal-code")]
    public string postalcode {
        get {
            return this.postalcodeField;
        }
        set {
            this.postalcodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
public enum ProvinceType {
    
    /// <remarks/>
    ON,
    
    /// <remarks/>
    QC,
    
    /// <remarks/>
    BC,
    
    /// <remarks/>
    ALBT,
    
    /// <remarks/>
    SK,
    
    /// <remarks/>
    MB,
    
    /// <remarks/>
    NL,
    
    /// <remarks/>
    PEI,
    
    /// <remarks/>
    NB,
    
    /// <remarks/>
    NS,
    
    /// <remarks/>
    NT,
    
    /// <remarks/>
    NV,
    
    /// <remarks/>
    YK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute("rating", Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class rateRange {
    
    private string minField;
    
    private string maxField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="integer")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class review {
    
    private System.DateTime dateField;
    
    private NameType reviewerField;
    
    private string summaryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public NameType reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    public string summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class menu {
    
    private item[] appetizersField;
    
    private item[] entreesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
    public item[] appetizers {
        get {
            return this.appetizersField;
        }
        set {
            this.appetizersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
    public item[] entrees {
        get {
            return this.entreesField;
        }
        set {
            this.entreesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class item {
    
    private string dishNameField;
    
    private string descriptionField;
    
    private price[] priceField;
    
    /// <remarks/>
    public string dishName {
        get {
            return this.dishNameField;
        }
        set {
            this.dishNameField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public price[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class price {
    
    private string quantityField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class appetizers {
    
    private item[] itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public item[] item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class entrees {
    
    private item[] itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public item[] item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}
