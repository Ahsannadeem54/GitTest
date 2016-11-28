﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class FYPDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertLawnOwner(LawnOwner instance);
  partial void UpdateLawnOwner(LawnOwner instance);
  partial void DeleteLawnOwner(LawnOwner instance);
  partial void InsertImage(Image instance);
  partial void UpdateImage(Image instance);
  partial void DeleteImage(Image instance);
  #endregion
	
	public FYPDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public FYPDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FYPDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FYPDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FYPDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
	
	public System.Data.Linq.Table<LawnOwner> LawnOwners
	{
		get
		{
			return this.GetTable<LawnOwner>();
		}
	}
	
	public System.Data.Linq.Table<Image> Images
	{
		get
		{
			return this.GetTable<Image>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Phone;
	
	private string _Email;
	
	private string _Password;
	
	private string _Confrom_Password;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnConfrom_PasswordChanging(string value);
    partial void OnConfrom_PasswordChanged();
    #endregion
	
	public User()
	{
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Confrom Password]", Storage="_Confrom_Password", DbType="NVarChar(50)")]
	public string Confrom_Password
	{
		get
		{
			return this._Confrom_Password;
		}
		set
		{
			if ((this._Confrom_Password != value))
			{
				this.OnConfrom_PasswordChanging(value);
				this.SendPropertyChanging();
				this._Confrom_Password = value;
				this.SendPropertyChanged("Confrom_Password");
				this.OnConfrom_PasswordChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LawnOwners")]
public partial class LawnOwner : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _LawnName;
	
	private string _SeatingCapacity;
	
	private string _Address;
	
	private string _BankAcc;
	
	private string _Phone;
	
	private string _Email;
	
	private string _Password;
	
	private string _ConfirmPassword;
	
	private string _Area;
	
	private EntitySet<Image> _Images;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLawnNameChanging(string value);
    partial void OnLawnNameChanged();
    partial void OnSeatingCapacityChanging(string value);
    partial void OnSeatingCapacityChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnBankAccChanging(string value);
    partial void OnBankAccChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnConfirmPasswordChanging(string value);
    partial void OnConfirmPasswordChanged();
    partial void OnAreaChanging(string value);
    partial void OnAreaChanged();
    #endregion
	
	public LawnOwner()
	{
		this._Images = new EntitySet<Image>(new Action<Image>(this.attach_Images), new Action<Image>(this.detach_Images));
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LawnName", DbType="NVarChar(50)")]
	public string LawnName
	{
		get
		{
			return this._LawnName;
		}
		set
		{
			if ((this._LawnName != value))
			{
				this.OnLawnNameChanging(value);
				this.SendPropertyChanging();
				this._LawnName = value;
				this.SendPropertyChanged("LawnName");
				this.OnLawnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeatingCapacity", DbType="NVarChar(50)")]
	public string SeatingCapacity
	{
		get
		{
			return this._SeatingCapacity;
		}
		set
		{
			if ((this._SeatingCapacity != value))
			{
				this.OnSeatingCapacityChanging(value);
				this.SendPropertyChanging();
				this._SeatingCapacity = value;
				this.SendPropertyChanged("SeatingCapacity");
				this.OnSeatingCapacityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankAcc", DbType="NVarChar(50)")]
	public string BankAcc
	{
		get
		{
			return this._BankAcc;
		}
		set
		{
			if ((this._BankAcc != value))
			{
				this.OnBankAccChanging(value);
				this.SendPropertyChanging();
				this._BankAcc = value;
				this.SendPropertyChanged("BankAcc");
				this.OnBankAccChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmPassword", DbType="NVarChar(50)")]
	public string ConfirmPassword
	{
		get
		{
			return this._ConfirmPassword;
		}
		set
		{
			if ((this._ConfirmPassword != value))
			{
				this.OnConfirmPasswordChanging(value);
				this.SendPropertyChanging();
				this._ConfirmPassword = value;
				this.SendPropertyChanged("ConfirmPassword");
				this.OnConfirmPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="NVarChar(50)")]
	public string Area
	{
		get
		{
			return this._Area;
		}
		set
		{
			if ((this._Area != value))
			{
				this.OnAreaChanging(value);
				this.SendPropertyChanging();
				this._Area = value;
				this.SendPropertyChanged("Area");
				this.OnAreaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LawnOwner_Image", Storage="_Images", ThisKey="Id", OtherKey="LawnID")]
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
		entity.LawnOwner = this;
	}
	
	private void detach_Images(Image entity)
	{
		this.SendPropertyChanging();
		entity.LawnOwner = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Uimg;
	
	private System.Nullable<int> _LawnID;
	
	private System.Nullable<int> _LID;
	
	private EntityRef<LawnOwner> _LawnOwner;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUimgChanging(string value);
    partial void OnUimgChanged();
    partial void OnLawnIDChanging(System.Nullable<int> value);
    partial void OnLawnIDChanged();
    partial void OnLIDChanging(System.Nullable<int> value);
    partial void OnLIDChanged();
    #endregion
	
	public Image()
	{
		this._LawnOwner = default(EntityRef<LawnOwner>);
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uimg", DbType="VarChar(5000)")]
	public string Uimg
	{
		get
		{
			return this._Uimg;
		}
		set
		{
			if ((this._Uimg != value))
			{
				this.OnUimgChanging(value);
				this.SendPropertyChanging();
				this._Uimg = value;
				this.SendPropertyChanged("Uimg");
				this.OnUimgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LawnID", DbType="Int")]
	public System.Nullable<int> LawnID
	{
		get
		{
			return this._LawnID;
		}
		set
		{
			if ((this._LawnID != value))
			{
				if (this._LawnOwner.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnLawnIDChanging(value);
				this.SendPropertyChanging();
				this._LawnID = value;
				this.SendPropertyChanged("LawnID");
				this.OnLawnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LID", DbType="Int")]
	public System.Nullable<int> LID
	{
		get
		{
			return this._LID;
		}
		set
		{
			if ((this._LID != value))
			{
				this.OnLIDChanging(value);
				this.SendPropertyChanging();
				this._LID = value;
				this.SendPropertyChanged("LID");
				this.OnLIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LawnOwner_Image", Storage="_LawnOwner", ThisKey="LawnID", OtherKey="Id", IsForeignKey=true)]
	public LawnOwner LawnOwner
	{
		get
		{
			return this._LawnOwner.Entity;
		}
		set
		{
			LawnOwner previousValue = this._LawnOwner.Entity;
			if (((previousValue != value) 
						|| (this._LawnOwner.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._LawnOwner.Entity = null;
					previousValue.Images.Remove(this);
				}
				this._LawnOwner.Entity = value;
				if ((value != null))
				{
					value.Images.Add(this);
					this._LawnID = value.Id;
				}
				else
				{
					this._LawnID = default(Nullable<int>);
				}
				this.SendPropertyChanged("LawnOwner");
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
#pragma warning restore 1591
