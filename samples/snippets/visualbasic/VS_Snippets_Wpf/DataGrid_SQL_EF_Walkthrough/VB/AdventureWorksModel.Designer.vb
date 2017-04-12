﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("2a07b192-e52c-4830-841a-d2f8ab5653d4")>
#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "ProductCategory", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(ProductCategory), "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(Product), True)>
<Assembly: EdmRelationshipAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(ProductCategory), "ProductCategory1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(ProductCategory), True)>

#End Region

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class AdventureWorksLT2008Entities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new AdventureWorksLT2008Entities object using the connection string found in the 'AdventureWorksLT2008Entities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=AdventureWorksLT2008Entities", "AdventureWorksLT2008Entities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new AdventureWorksLT2008Entities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "AdventureWorksLT2008Entities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new AdventureWorksLT2008Entities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "AdventureWorksLT2008Entities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property Products() As ObjectSet(Of Product)
        Get
            If (_Products Is Nothing) Then
                _Products = MyBase.CreateObjectSet(Of Product)("Products")
            End If
            Return _Products
        End Get
    End Property

    Private _Products As ObjectSet(Of Product)

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property ProductCategories() As ObjectSet(Of ProductCategory)
        Get
            If (_ProductCategories Is Nothing) Then
                _ProductCategories = MyBase.CreateObjectSet(Of ProductCategory)("ProductCategories")
            End If
            Return _ProductCategories
        End Get
    End Property

    Private _ProductCategories As ObjectSet(Of ProductCategory)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToProducts(ByVal product As Product)
        MyBase.AddObject("Products", product)
    End Sub

    ''' <summary>
    ''' Deprecated Method for adding a new object to the ProductCategories EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToProductCategories(ByVal productCategory As ProductCategory)
        MyBase.AddObject("ProductCategories", productCategory)
    End Sub

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="AdventureWorksLT2008Model", Name:="Product")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Product
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Product object.
    ''' </summary>
    ''' <param name="productID">Initial value of the ProductID property.</param>
    ''' <param name="name">Initial value of the Name property.</param>
    ''' <param name="productNumber">Initial value of the ProductNumber property.</param>
    ''' <param name="standardCost">Initial value of the StandardCost property.</param>
    ''' <param name="listPrice">Initial value of the ListPrice property.</param>
    ''' <param name="sellStartDate">Initial value of the SellStartDate property.</param>
    ''' <param name="rowguid">Initial value of the rowguid property.</param>
    ''' <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
    Public Shared Function CreateProduct(productID As Global.System.Int32, name As Global.System.String, productNumber As Global.System.String, standardCost As Global.System.Decimal, listPrice As Global.System.Decimal, sellStartDate As Global.System.DateTime, rowguid As Global.System.Guid, modifiedDate As Global.System.DateTime) As Product
        Dim product as Product = New Product
        product.ProductID = productID
        product.Name = name
        product.ProductNumber = productNumber
        product.StandardCost = standardCost
        product.ListPrice = listPrice
        product.SellStartDate = sellStartDate
        product.rowguid = rowguid
        product.ModifiedDate = modifiedDate
        Return product
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ProductID() As Global.System.Int32
        Get
            Return _ProductID
        End Get
        Set
            If (_ProductID <> Value) Then
                OnProductIDChanging(value)
                ReportPropertyChanging("ProductID")
                _ProductID = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("ProductID")
                OnProductIDChanged()
            End If
        End Set
    End Property

    Private _ProductID As Global.System.Int32
    Private Partial Sub OnProductIDChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnProductIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Name() As Global.System.String
        Get
            Return _Name
        End Get
        Set
            OnNameChanging(value)
            ReportPropertyChanging("Name")
            _Name = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("Name")
            OnNameChanged()
        End Set
    End Property

    Private _Name As Global.System.String
    Private Partial Sub OnNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ProductNumber() As Global.System.String
        Get
            Return _ProductNumber
        End Get
        Set
            OnProductNumberChanging(value)
            ReportPropertyChanging("ProductNumber")
            _ProductNumber = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("ProductNumber")
            OnProductNumberChanged()
        End Set
    End Property

    Private _ProductNumber As Global.System.String
    Private Partial Sub OnProductNumberChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnProductNumberChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Color() As Global.System.String
        Get
            Return _Color
        End Get
        Set
            OnColorChanging(value)
            ReportPropertyChanging("Color")
            _Color = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Color")
            OnColorChanged()
        End Set
    End Property

    Private _Color As Global.System.String
    Private Partial Sub OnColorChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnColorChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property StandardCost() As Global.System.Decimal
        Get
            Return _StandardCost
        End Get
        Set
            OnStandardCostChanging(value)
            ReportPropertyChanging("StandardCost")
            _StandardCost = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("StandardCost")
            OnStandardCostChanged()
        End Set
    End Property

    Private _StandardCost As Global.System.Decimal
    Private Partial Sub OnStandardCostChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OnStandardCostChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ListPrice() As Global.System.Decimal
        Get
            Return _ListPrice
        End Get
        Set
            OnListPriceChanging(value)
            ReportPropertyChanging("ListPrice")
            _ListPrice = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ListPrice")
            OnListPriceChanged()
        End Set
    End Property

    Private _ListPrice As Global.System.Decimal
    Private Partial Sub OnListPriceChanging(value As Global.System.Decimal)
    End Sub

    Private Partial Sub OnListPriceChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Size() As Global.System.String
        Get
            Return _Size
        End Get
        Set
            OnSizeChanging(value)
            ReportPropertyChanging("Size")
            _Size = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("Size")
            OnSizeChanged()
        End Set
    End Property

    Private _Size As Global.System.String
    Private Partial Sub OnSizeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnSizeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property Weight() As Nullable(Of Global.System.Decimal)
        Get
            Return _Weight
        End Get
        Set
            OnWeightChanging(value)
            ReportPropertyChanging("Weight")
            _Weight = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("Weight")
            OnWeightChanged()
        End Set
    End Property

    Private _Weight As Nullable(Of Global.System.Decimal)
    Private Partial Sub OnWeightChanging(value As Nullable(Of Global.System.Decimal))
    End Sub

    Private Partial Sub OnWeightChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ProductCategoryID() As Nullable(Of Global.System.Int32)
        Get
            Return _ProductCategoryID
        End Get
        Set
            OnProductCategoryIDChanging(value)
            ReportPropertyChanging("ProductCategoryID")
            _ProductCategoryID = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ProductCategoryID")
            OnProductCategoryIDChanged()
        End Set
    End Property

    Private _ProductCategoryID As Nullable(Of Global.System.Int32)
    Private Partial Sub OnProductCategoryIDChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnProductCategoryIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ProductModelID() As Nullable(Of Global.System.Int32)
        Get
            Return _ProductModelID
        End Get
        Set
            OnProductModelIDChanging(value)
            ReportPropertyChanging("ProductModelID")
            _ProductModelID = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ProductModelID")
            OnProductModelIDChanged()
        End Set
    End Property

    Private _ProductModelID As Nullable(Of Global.System.Int32)
    Private Partial Sub OnProductModelIDChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnProductModelIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property SellStartDate() As Global.System.DateTime
        Get
            Return _SellStartDate
        End Get
        Set
            OnSellStartDateChanging(value)
            ReportPropertyChanging("SellStartDate")
            _SellStartDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("SellStartDate")
            OnSellStartDateChanged()
        End Set
    End Property

    Private _SellStartDate As Global.System.DateTime
    Private Partial Sub OnSellStartDateChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnSellStartDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property SellEndDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _SellEndDate
        End Get
        Set
            OnSellEndDateChanging(value)
            ReportPropertyChanging("SellEndDate")
            _SellEndDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("SellEndDate")
            OnSellEndDateChanged()
        End Set
    End Property

    Private _SellEndDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnSellEndDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnSellEndDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property DiscontinuedDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _DiscontinuedDate
        End Get
        Set
            OnDiscontinuedDateChanging(value)
            ReportPropertyChanging("DiscontinuedDate")
            _DiscontinuedDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("DiscontinuedDate")
            OnDiscontinuedDateChanged()
        End Set
    End Property

    Private _DiscontinuedDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnDiscontinuedDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnDiscontinuedDateChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ThumbNailPhoto() As Global.System.Byte()
        Get
                Return StructuralObject.GetValidValue(_ThumbNailPhoto)
        End Get
        Set
            OnThumbNailPhotoChanging(value)
            ReportPropertyChanging("ThumbNailPhoto")
            _ThumbNailPhoto = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("ThumbNailPhoto")
            OnThumbNailPhotoChanged()
        End Set
    End Property

    Private _ThumbNailPhoto As Global.System.Byte()
    Private Partial Sub OnThumbNailPhotoChanging(value As Global.System.Byte())
    End Sub

    Private Partial Sub OnThumbNailPhotoChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ThumbnailPhotoFileName() As Global.System.String
        Get
            Return _ThumbnailPhotoFileName
        End Get
        Set
            OnThumbnailPhotoFileNameChanging(value)
            ReportPropertyChanging("ThumbnailPhotoFileName")
            _ThumbnailPhotoFileName = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("ThumbnailPhotoFileName")
            OnThumbnailPhotoFileNameChanged()
        End Set
    End Property

    Private _ThumbnailPhotoFileName As Global.System.String
    Private Partial Sub OnThumbnailPhotoFileNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnThumbnailPhotoFileNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property rowguid() As Global.System.Guid
        Get
            Return _rowguid
        End Get
        Set
            OnrowguidChanging(value)
            ReportPropertyChanging("rowguid")
            _rowguid = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("rowguid")
            OnrowguidChanged()
        End Set
    End Property

    Private _rowguid As Global.System.Guid
    Private Partial Sub OnrowguidChanging(value As Global.System.Guid)
    End Sub

    Private Partial Sub OnrowguidChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ModifiedDate() As Global.System.DateTime
        Get
            Return _ModifiedDate
        End Get
        Set
            OnModifiedDateChanging(value)
            ReportPropertyChanging("ModifiedDate")
            _ModifiedDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ModifiedDate")
            OnModifiedDateChanged()
        End Set
    End Property

    Private _ModifiedDate As Global.System.DateTime
    Private Partial Sub OnModifiedDateChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnModifiedDateChanged()
    End Sub

    #End Region
    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "ProductCategory")>
    Public Property ProductCategory() As ProductCategory
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property ProductCategoryReference() As EntityReference(Of ProductCategory)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory", value)
            End If
        End Set
    End Property

    #End Region
End Class

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="AdventureWorksLT2008Model", Name:="ProductCategory")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class ProductCategory
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new ProductCategory object.
    ''' </summary>
    ''' <param name="productCategoryID">Initial value of the ProductCategoryID property.</param>
    ''' <param name="name">Initial value of the Name property.</param>
    ''' <param name="rowguid">Initial value of the rowguid property.</param>
    ''' <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
    Public Shared Function CreateProductCategory(productCategoryID As Global.System.Int32, name As Global.System.String, rowguid As Global.System.Guid, modifiedDate As Global.System.DateTime) As ProductCategory
        Dim productCategory as ProductCategory = New ProductCategory
        productCategory.ProductCategoryID = productCategoryID
        productCategory.Name = name
        productCategory.rowguid = rowguid
        productCategory.ModifiedDate = modifiedDate
        Return productCategory
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ProductCategoryID() As Global.System.Int32
        Get
            Return _ProductCategoryID
        End Get
        Set
            If (_ProductCategoryID <> Value) Then
                OnProductCategoryIDChanging(value)
                ReportPropertyChanging("ProductCategoryID")
                _ProductCategoryID = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("ProductCategoryID")
                OnProductCategoryIDChanged()
            End If
        End Set
    End Property

    Private _ProductCategoryID As Global.System.Int32
    Private Partial Sub OnProductCategoryIDChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnProductCategoryIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property ParentProductCategoryID() As Nullable(Of Global.System.Int32)
        Get
            Return _ParentProductCategoryID
        End Get
        Set
            OnParentProductCategoryIDChanging(value)
            ReportPropertyChanging("ParentProductCategoryID")
            _ParentProductCategoryID = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ParentProductCategoryID")
            OnParentProductCategoryIDChanged()
        End Set
    End Property

    Private _ParentProductCategoryID As Nullable(Of Global.System.Int32)
    Private Partial Sub OnParentProductCategoryIDChanging(value As Nullable(Of Global.System.Int32))
    End Sub

    Private Partial Sub OnParentProductCategoryIDChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Name() As Global.System.String
        Get
            Return _Name
        End Get
        Set
            OnNameChanging(value)
            ReportPropertyChanging("Name")
            _Name = StructuralObject.SetValidValue(value, false)
            ReportPropertyChanged("Name")
            OnNameChanged()
        End Set
    End Property

    Private _Name As Global.System.String
    Private Partial Sub OnNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnNameChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property rowguid() As Global.System.Guid
        Get
            Return _rowguid
        End Get
        Set
            OnrowguidChanging(value)
            ReportPropertyChanging("rowguid")
            _rowguid = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("rowguid")
            OnrowguidChanged()
        End Set
    End Property

    Private _rowguid As Global.System.Guid
    Private Partial Sub OnrowguidChanging(value As Global.System.Guid)
    End Sub

    Private Partial Sub OnrowguidChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property ModifiedDate() As Global.System.DateTime
        Get
            Return _ModifiedDate
        End Get
        Set
            OnModifiedDateChanging(value)
            ReportPropertyChanging("ModifiedDate")
            _ModifiedDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("ModifiedDate")
            OnModifiedDateChanged()
        End Set
    End Property

    Private _ModifiedDate As Global.System.DateTime
    Private Partial Sub OnModifiedDateChanging(value As Global.System.DateTime)
    End Sub

    Private Partial Sub OnModifiedDateChanged()
    End Sub

    #End Region
    #Region "Navigation Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "Product")>
     Public Property Products() As EntityCollection(Of Product)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Product)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "Product")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of Product)("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "Product", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1")>
     Public Property ProductCategory1() As EntityCollection(Of ProductCategory)
        Get
            Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <XmlIgnoreAttribute()>
    <SoapIgnoreAttribute()>
    <DataMemberAttribute()>
    <EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory")>
    Public Property ProductCategory2() As ProductCategory
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory").Value
        End Get
        Set
            CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory").Value = value
        End Set
    End Property
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <BrowsableAttribute(False)>
    <DataMemberAttribute()>
    Public Property ProductCategory2Reference() As EntityReference(Of ProductCategory)
        Get
            Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory")
        End Get
        Set
            If (Not value Is Nothing)
                CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of ProductCategory)("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory", value)
            End If
        End Set
    End Property

    #End Region
End Class

#End Region
