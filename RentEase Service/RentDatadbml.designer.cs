﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentEase_Service
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TanzaniteD")]
	public partial class RentDatadbmlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertMerchant(Merchant instance);
    partial void UpdateMerchant(Merchant instance);
    partial void DeleteMerchant(Merchant instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertShopping_cart(Shopping_cart instance);
    partial void UpdateShopping_cart(Shopping_cart instance);
    partial void DeleteShopping_cart(Shopping_cart instance);
    partial void InsertInvoice(Invoice instance);
    partial void UpdateInvoice(Invoice instance);
    partial void DeleteInvoice(Invoice instance);
    #endregion
		
		public RentDatadbmlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TanzaniteDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RentDatadbmlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentDatadbmlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentDatadbmlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentDatadbmlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Merchant> Merchants
		{
			get
			{
				return this.GetTable<Merchant>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<Shopping_cart> Shopping_carts
		{
			get
			{
				return this.GetTable<Shopping_cart>();
			}
		}
		
		public System.Data.Linq.Table<Invoice> Invoices
		{
			get
			{
				return this.GetTable<Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Customer_Invoice> Customer_Invoices
		{
			get
			{
				return this.GetTable<Customer_Invoice>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _U_Name;
		
		private string _Surname;
		
		private string _Email;
		
		private string _User_Type;
		
		private string _password;
		
		private EntityRef<Admin> _Admin;
		
		private EntityRef<Merchant> _Merchant;
		
		private EntitySet<Shopping_cart> _Shopping_carts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnU_NameChanging(string value);
    partial void OnU_NameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUser_TypeChanging(string value);
    partial void OnUser_TypeChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public User()
		{
			this._Admin = default(EntityRef<Admin>);
			this._Merchant = default(EntityRef<Merchant>);
			this._Shopping_carts = new EntitySet<Shopping_cart>(new Action<Shopping_cart>(this.attach_Shopping_carts), new Action<Shopping_cart>(this.detach_Shopping_carts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string U_Name
		{
			get
			{
				return this._U_Name;
			}
			set
			{
				if ((this._U_Name != value))
				{
					this.OnU_NameChanging(value);
					this.SendPropertyChanging();
					this._U_Name = value;
					this.SendPropertyChanged("U_Name");
					this.OnU_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="VarChar(3) NOT NULL", CanBeNull=false)]
		public string User_Type
		{
			get
			{
				return this._User_Type;
			}
			set
			{
				if ((this._User_Type != value))
				{
					this.OnUser_TypeChanging(value);
					this.SendPropertyChanging();
					this._User_Type = value;
					this.SendPropertyChanged("User_Type");
					this.OnUser_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Admin", Storage="_Admin", ThisKey="Id", OtherKey="A_ID", IsUnique=true, IsForeignKey=false)]
		public Admin Admin
		{
			get
			{
				return this._Admin.Entity;
			}
			set
			{
				Admin previousValue = this._Admin.Entity;
				if (((previousValue != value) 
							|| (this._Admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Admin.Entity = null;
						previousValue.User = null;
					}
					this._Admin.Entity = value;
					if ((value != null))
					{
						value.User = this;
					}
					this.SendPropertyChanged("Admin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Merchant", Storage="_Merchant", ThisKey="Id", OtherKey="M_ID", IsUnique=true, IsForeignKey=false)]
		public Merchant Merchant
		{
			get
			{
				return this._Merchant.Entity;
			}
			set
			{
				Merchant previousValue = this._Merchant.Entity;
				if (((previousValue != value) 
							|| (this._Merchant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Merchant.Entity = null;
						previousValue.User = null;
					}
					this._Merchant.Entity = value;
					if ((value != null))
					{
						value.User = this;
					}
					this.SendPropertyChanged("Merchant");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Shopping_cart", Storage="_Shopping_carts", ThisKey="Id", OtherKey="C_ID")]
		public EntitySet<Shopping_cart> Shopping_carts
		{
			get
			{
				return this._Shopping_carts;
			}
			set
			{
				this._Shopping_carts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Shopping_carts(Shopping_cart entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Shopping_carts(Shopping_cart entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _A_ID;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnA_IDChanging(int value);
    partial void OnA_IDChanged();
    #endregion
		
		public Admin()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int A_ID
		{
			get
			{
				return this._A_ID;
			}
			set
			{
				if ((this._A_ID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnA_IDChanging(value);
					this.SendPropertyChanging();
					this._A_ID = value;
					this.SendPropertyChanged("A_ID");
					this.OnA_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Admin", Storage="_User", ThisKey="A_ID", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Admin = null;
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Admin = this;
						this._A_ID = value.Id;
					}
					else
					{
						this._A_ID = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Merchant")]
	public partial class Merchant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _M_ID;
		
		private EntitySet<Product> _Products;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnM_IDChanging(int value);
    partial void OnM_IDChanged();
    #endregion
		
		public Merchant()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int M_ID
		{
			get
			{
				return this._M_ID;
			}
			set
			{
				if ((this._M_ID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnM_IDChanging(value);
					this.SendPropertyChanging();
					this._M_ID = value;
					this.SendPropertyChanged("M_ID");
					this.OnM_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Merchant_Product", Storage="_Products", ThisKey="M_ID", OtherKey="M_ID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Merchant", Storage="_User", ThisKey="M_ID", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Merchant = null;
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Merchant = this;
						this._M_ID = value.Id;
					}
					else
					{
						this._M_ID = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Merchant = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Merchant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Product_Name;
		
		private string _Decript;
		
		private int _Quantity;
		
		private decimal _Price;
		
		private int _M_ID;
		
		private EntitySet<Image> _Images;
		
		private EntitySet<Shopping_cart> _Shopping_carts;
		
		private EntityRef<Merchant> _Merchant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProduct_NameChanging(string value);
    partial void OnProduct_NameChanged();
    partial void OnDecriptChanging(string value);
    partial void OnDecriptChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnM_IDChanging(int value);
    partial void OnM_IDChanged();
    #endregion
		
		public Product()
		{
			this._Images = new EntitySet<Image>(new Action<Image>(this.attach_Images), new Action<Image>(this.detach_Images));
			this._Shopping_carts = new EntitySet<Shopping_cart>(new Action<Shopping_cart>(this.attach_Shopping_carts), new Action<Shopping_cart>(this.detach_Shopping_carts));
			this._Merchant = default(EntityRef<Merchant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Product_Name
		{
			get
			{
				return this._Product_Name;
			}
			set
			{
				if ((this._Product_Name != value))
				{
					this.OnProduct_NameChanging(value);
					this.SendPropertyChanging();
					this._Product_Name = value;
					this.SendPropertyChanged("Product_Name");
					this.OnProduct_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decript", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Decript
		{
			get
			{
				return this._Decript;
			}
			set
			{
				if ((this._Decript != value))
				{
					this.OnDecriptChanging(value);
					this.SendPropertyChanging();
					this._Decript = value;
					this.SendPropertyChanged("Decript");
					this.OnDecriptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M_ID", DbType="Int NOT NULL")]
		public int M_ID
		{
			get
			{
				return this._M_ID;
			}
			set
			{
				if ((this._M_ID != value))
				{
					if (this._Merchant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnM_IDChanging(value);
					this.SendPropertyChanging();
					this._M_ID = value;
					this.SendPropertyChanged("M_ID");
					this.OnM_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Image", Storage="_Images", ThisKey="Id", OtherKey="P_ID")]
		public EntitySet<Image> Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				this._Images.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Shopping_cart", Storage="_Shopping_carts", ThisKey="Id", OtherKey="P_ID")]
		public EntitySet<Shopping_cart> Shopping_carts
		{
			get
			{
				return this._Shopping_carts;
			}
			set
			{
				this._Shopping_carts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Merchant_Product", Storage="_Merchant", ThisKey="M_ID", OtherKey="M_ID", IsForeignKey=true)]
		public Merchant Merchant
		{
			get
			{
				return this._Merchant.Entity;
			}
			set
			{
				Merchant previousValue = this._Merchant.Entity;
				if (((previousValue != value) 
							|| (this._Merchant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Merchant.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Merchant.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._M_ID = value.M_ID;
					}
					else
					{
						this._M_ID = default(int);
					}
					this.SendPropertyChanged("Merchant");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Images(Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Shopping_carts(Shopping_cart entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Shopping_carts(Shopping_cart entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Image")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Image_ID;
		
		private int _P_ID;
		
		private string _Image_URL;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImage_IDChanging(int value);
    partial void OnImage_IDChanged();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnImage_URLChanging(string value);
    partial void OnImage_URLChanged();
    #endregion
		
		public Image()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Image_ID
		{
			get
			{
				return this._Image_ID;
			}
			set
			{
				if ((this._Image_ID != value))
				{
					this.OnImage_IDChanging(value);
					this.SendPropertyChanging();
					this._Image_ID = value;
					this.SendPropertyChanged("Image_ID");
					this.OnImage_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", DbType="Int NOT NULL")]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image_URL", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Image_URL
		{
			get
			{
				return this._Image_URL;
			}
			set
			{
				if ((this._Image_URL != value))
				{
					this.OnImage_URLChanging(value);
					this.SendPropertyChanging();
					this._Image_URL = value;
					this.SendPropertyChanged("Image_URL");
					this.OnImage_URLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Image", Storage="_Product", ThisKey="P_ID", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Images.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Images.Add(this);
						this._P_ID = value.Id;
					}
					else
					{
						this._P_ID = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shopping_cart")]
	public partial class Shopping_cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _P_ID;
		
		private int _C_ID;
		
		private EntityRef<User> _User;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_IDChanging(int value);
    partial void OnP_IDChanged();
    partial void OnC_IDChanging(int value);
    partial void OnC_IDChanged();
    #endregion
		
		public Shopping_cart()
		{
			this._User = default(EntityRef<User>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int P_ID
		{
			get
			{
				return this._P_ID;
			}
			set
			{
				if ((this._P_ID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnP_IDChanging(value);
					this.SendPropertyChanging();
					this._P_ID = value;
					this.SendPropertyChanged("P_ID");
					this.OnP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int C_ID
		{
			get
			{
				return this._C_ID;
			}
			set
			{
				if ((this._C_ID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnC_IDChanging(value);
					this.SendPropertyChanging();
					this._C_ID = value;
					this.SendPropertyChanged("C_ID");
					this.OnC_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Shopping_cart", Storage="_User", ThisKey="C_ID", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Shopping_carts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Shopping_carts.Add(this);
						this._C_ID = value.Id;
					}
					else
					{
						this._C_ID = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Shopping_cart", Storage="_Product", ThisKey="P_ID", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Shopping_carts.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Shopping_carts.Add(this);
						this._P_ID = value.Id;
					}
					else
					{
						this._P_ID = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Invoice")]
	public partial class Invoice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _I_Date;
		
		private decimal _Total_Cost;
		
		private int _Total_Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnI_DateChanging(System.DateTime value);
    partial void OnI_DateChanged();
    partial void OnTotal_CostChanging(decimal value);
    partial void OnTotal_CostChanged();
    partial void OnTotal_QuantityChanging(int value);
    partial void OnTotal_QuantityChanged();
    #endregion
		
		public Invoice()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_I_Date", DbType="Date NOT NULL")]
		public System.DateTime I_Date
		{
			get
			{
				return this._I_Date;
			}
			set
			{
				if ((this._I_Date != value))
				{
					this.OnI_DateChanging(value);
					this.SendPropertyChanging();
					this._I_Date = value;
					this.SendPropertyChanged("I_Date");
					this.OnI_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Cost", DbType="Decimal(18,0) NOT NULL")]
		public decimal Total_Cost
		{
			get
			{
				return this._Total_Cost;
			}
			set
			{
				if ((this._Total_Cost != value))
				{
					this.OnTotal_CostChanging(value);
					this.SendPropertyChanging();
					this._Total_Cost = value;
					this.SendPropertyChanged("Total_Cost");
					this.OnTotal_CostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Quantity", DbType="Int NOT NULL")]
		public int Total_Quantity
		{
			get
			{
				return this._Total_Quantity;
			}
			set
			{
				if ((this._Total_Quantity != value))
				{
					this.OnTotal_QuantityChanging(value);
					this.SendPropertyChanging();
					this._Total_Quantity = value;
					this.SendPropertyChanged("Total_Quantity");
					this.OnTotal_QuantityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Invoices")]
	public partial class Customer_Invoice
	{
		
		private int _C_ID;
		
		private int _Invoice_ID;
		
		public Customer_Invoice()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_ID", DbType="Int NOT NULL")]
		public int C_ID
		{
			get
			{
				return this._C_ID;
			}
			set
			{
				if ((this._C_ID != value))
				{
					this._C_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_ID", DbType="Int NOT NULL")]
		public int Invoice_ID
		{
			get
			{
				return this._Invoice_ID;
			}
			set
			{
				if ((this._Invoice_ID != value))
				{
					this._Invoice_ID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order
	{
		
		private int _Invoice_ID;
		
		private int _Product_ID;
		
		private int _Quantity;
		
		private decimal _subTotal;
		
		private int _Durantion;
		
		public Order()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Invoice_ID", DbType="Int NOT NULL")]
		public int Invoice_ID
		{
			get
			{
				return this._Invoice_ID;
			}
			set
			{
				if ((this._Invoice_ID != value))
				{
					this._Invoice_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL")]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this._Product_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subTotal", DbType="Decimal(18,0) NOT NULL")]
		public decimal subTotal
		{
			get
			{
				return this._subTotal;
			}
			set
			{
				if ((this._subTotal != value))
				{
					this._subTotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Durantion", DbType="Int NOT NULL")]
		public int Durantion
		{
			get
			{
				return this._Durantion;
			}
			set
			{
				if ((this._Durantion != value))
				{
					this._Durantion = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
