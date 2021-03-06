﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UserPass")]
	public partial class LINQ_UserPassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser_Password(User_Password instance);
    partial void UpdateUser_Password(User_Password instance);
    partial void DeleteUser_Password(User_Password instance);
    #endregion
		
		public LINQ_UserPassDataContext() : 
				base(global::Pharmacy.Properties.Settings.Default.UserPassConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_UserPassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_UserPassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_UserPassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQ_UserPassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User_Password> User_Passwords
		{
			get
			{
				return this.GetTable<User_Password>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteUserPass")]
		public int DeleteUserPass([global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(50)")] string user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EditUserPass")]
		public int EditUserPass([global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(50)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(50)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hint", DbType="NVarChar(50)")] string hint, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modifiers", DbType="NVarChar(50)")] string modifiers)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, pass, hint, modifiers);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SaveUserPass")]
		public int SaveUserPass([global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(50)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(50)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Modifiers", DbType="NVarChar(50)")] string modifiers, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hint", DbType="NVarChar(50)")] string hint)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, pass, modifiers, hint);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.User_Password")]
	public partial class User_Password : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _Password;
		
		private string _PasswordHint;
		
		private string _Modifiers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPasswordHintChanging(string value);
    partial void OnPasswordHintChanged();
    partial void OnModifiersChanging(string value);
    partial void OnModifiersChanged();
    #endregion
		
		public User_Password()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHint", DbType="NVarChar(50)")]
		public string PasswordHint
		{
			get
			{
				return this._PasswordHint;
			}
			set
			{
				if ((this._PasswordHint != value))
				{
					this.OnPasswordHintChanging(value);
					this.SendPropertyChanging();
					this._PasswordHint = value;
					this.SendPropertyChanged("PasswordHint");
					this.OnPasswordHintChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modifiers", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Modifiers
		{
			get
			{
				return this._Modifiers;
			}
			set
			{
				if ((this._Modifiers != value))
				{
					this.OnModifiersChanging(value);
					this.SendPropertyChanging();
					this._Modifiers = value;
					this.SendPropertyChanged("Modifiers");
					this.OnModifiersChanged();
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
}
#pragma warning restore 1591
