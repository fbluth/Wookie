﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wookie.Project.Management.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BS_PM_Mandant1")]
	public partial class ProjectManagementDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnCreated();
    partial void InserttblProject(tblProject instance);
    partial void UpdatetblProject(tblProject instance);
    partial void DeletetblProject(tblProject instance);
    partial void InserttlkpProjectCategory(tlkpProjectCategory instance);
    partial void UpdatetlkpProjectCategory(tlkpProjectCategory instance);
    partial void DeletetlkpProjectCategory(tlkpProjectCategory instance);
    partial void InserttlkpProjectType(tlkpProjectType instance);
    partial void UpdatetlkpProjectType(tlkpProjectType instance);
    partial void DeletetlkpProjectType(tlkpProjectType instance);
    #endregion
		
		public ProjectManagementDataContext() : 
				base(global::Wookie.Project.Management.Properties.Settings.Default.BS_PM_Mandant1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectManagementDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectManagementDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectManagementDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectManagementDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblProject> tblProject
		{
			get
			{
				return this.GetTable<tblProject>();
			}
		}
		
		public System.Data.Linq.Table<tlkpProjectCategory> tlkpProjectCategory
		{
			get
			{
				return this.GetTable<tlkpProjectCategory>();
			}
		}
		
		public System.Data.Linq.Table<tlkpProjectType> tlkpProjectType
		{
			get
			{
				return this.GetTable<tlkpProjectType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblProject")]
	public partial class tblProject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _PKProject;
		
		private System.Nullable<long> _FKProjectCategory;
		
		private System.Nullable<long> _FKProjectType;
		
		private string _Projectname;
		
		private System.Data.Linq.Binary _Picture;
		
		private System.Nullable<long> _FKUserCreated;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<long> _FKUserChanged;
		
		private System.Nullable<System.DateTime> _ChangedOn;
		
		private System.Nullable<System.Guid> _UniqueIdentifier;
		
		private EntityRef<tlkpProjectCategory> _tlkpProjectCategory;
		
		private EntityRef<tlkpProjectType> _tlkpProjectType;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKProjectChanging(long value);
    partial void OnPKProjectChanged();
    partial void OnFKProjectCategoryChanging(System.Nullable<long> value);
    partial void OnFKProjectCategoryChanged();
    partial void OnFKProjectTypeChanging(System.Nullable<long> value);
    partial void OnFKProjectTypeChanged();
    partial void OnProjectnameChanging(string value);
    partial void OnProjectnameChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnFKUserCreatedChanging(System.Nullable<long> value);
    partial void OnFKUserCreatedChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnFKUserChangedChanging(System.Nullable<long> value);
    partial void OnFKUserChangedChanged();
    partial void OnChangedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnChangedOnChanged();
    partial void OnUniqueIdentifierChanging(System.Nullable<System.Guid> value);
    partial void OnUniqueIdentifierChanged();
    #endregion
		
		public tblProject()
		{
			this._tlkpProjectCategory = default(EntityRef<tlkpProjectCategory>);
			this._tlkpProjectType = default(EntityRef<tlkpProjectType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKProject", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long PKProject
		{
			get
			{
				return this._PKProject;
			}
			set
			{
				if ((this._PKProject != value))
				{
					this.OnPKProjectChanging(value);
					this.SendPropertyChanging();
					this._PKProject = value;
					this.SendPropertyChanged("PKProject");
					this.OnPKProjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKProjectCategory", DbType="BigInt")]
		public System.Nullable<long> FKProjectCategory
		{
			get
			{
				return this._FKProjectCategory;
			}
			set
			{
				if ((this._FKProjectCategory != value))
				{
					if (this._tlkpProjectCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFKProjectCategoryChanging(value);
					this.SendPropertyChanging();
					this._FKProjectCategory = value;
					this.SendPropertyChanged("FKProjectCategory");
					this.OnFKProjectCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKProjectType", DbType="BigInt")]
		public System.Nullable<long> FKProjectType
		{
			get
			{
				return this._FKProjectType;
			}
			set
			{
				if ((this._FKProjectType != value))
				{
					if (this._tlkpProjectType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFKProjectTypeChanging(value);
					this.SendPropertyChanging();
					this._FKProjectType = value;
					this.SendPropertyChanged("FKProjectType");
					this.OnFKProjectTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Projectname", DbType="NVarChar(255)")]
		public string Projectname
		{
			get
			{
				return this._Projectname;
			}
			set
			{
				if ((this._Projectname != value))
				{
					this.OnProjectnameChanging(value);
					this.SendPropertyChanging();
					this._Projectname = value;
					this.SendPropertyChanged("Projectname");
					this.OnProjectnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserCreated", DbType="BigInt")]
		public System.Nullable<long> FKUserCreated
		{
			get
			{
				return this._FKUserCreated;
			}
			set
			{
				if ((this._FKUserCreated != value))
				{
					this.OnFKUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._FKUserCreated = value;
					this.SendPropertyChanged("FKUserCreated");
					this.OnFKUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserChanged", DbType="BigInt")]
		public System.Nullable<long> FKUserChanged
		{
			get
			{
				return this._FKUserChanged;
			}
			set
			{
				if ((this._FKUserChanged != value))
				{
					this.OnFKUserChangedChanging(value);
					this.SendPropertyChanging();
					this._FKUserChanged = value;
					this.SendPropertyChanged("FKUserChanged");
					this.OnFKUserChangedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ChangedOn
		{
			get
			{
				return this._ChangedOn;
			}
			set
			{
				if ((this._ChangedOn != value))
				{
					this.OnChangedOnChanging(value);
					this.SendPropertyChanging();
					this._ChangedOn = value;
					this.SendPropertyChanged("ChangedOn");
					this.OnChangedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueIdentifier", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UniqueIdentifier
		{
			get
			{
				return this._UniqueIdentifier;
			}
			set
			{
				if ((this._UniqueIdentifier != value))
				{
					this.OnUniqueIdentifierChanging(value);
					this.SendPropertyChanging();
					this._UniqueIdentifier = value;
					this.SendPropertyChanged("UniqueIdentifier");
					this.OnUniqueIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlkpProjectCategory_tblProject", Storage="_tlkpProjectCategory", ThisKey="FKProjectCategory", OtherKey="PKProjectCategory", IsForeignKey=true)]
		public tlkpProjectCategory tlkpProjectCategory
		{
			get
			{
				return this._tlkpProjectCategory.Entity;
			}
			set
			{
				tlkpProjectCategory previousValue = this._tlkpProjectCategory.Entity;
				if (((previousValue != value) 
							|| (this._tlkpProjectCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlkpProjectCategory.Entity = null;
						previousValue.tblProject.Remove(this);
					}
					this._tlkpProjectCategory.Entity = value;
					if ((value != null))
					{
						value.tblProject.Add(this);
						this._FKProjectCategory = value.PKProjectCategory;
					}
					else
					{
						this._FKProjectCategory = default(Nullable<long>);
					}
					this.SendPropertyChanged("tlkpProjectCategory");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlkpProjectType_tblProject", Storage="_tlkpProjectType", ThisKey="FKProjectType", OtherKey="PKProjectType", IsForeignKey=true)]
		public tlkpProjectType tlkpProjectType
		{
			get
			{
				return this._tlkpProjectType.Entity;
			}
			set
			{
				tlkpProjectType previousValue = this._tlkpProjectType.Entity;
				if (((previousValue != value) 
							|| (this._tlkpProjectType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlkpProjectType.Entity = null;
						previousValue.tblProject.Remove(this);
					}
					this._tlkpProjectType.Entity = value;
					if ((value != null))
					{
						value.tblProject.Add(this);
						this._FKProjectType = value.PKProjectType;
					}
					else
					{
						this._FKProjectType = default(Nullable<long>);
					}
					this.SendPropertyChanged("tlkpProjectType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlkpProjectCategory")]
	public partial class tlkpProjectCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _PKProjectCategory;
		
		private string _Name;
		
		private string _Description;
		
		private System.Data.Linq.Binary _Picture;
		
		private System.Nullable<long> _FKUserCreated;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<long> _FKUserChanged;
		
		private System.Nullable<System.DateTime> _ChangedOn;
		
		private System.Nullable<System.Guid> _UniqueIdentifier;
		
		private EntitySet<tblProject> _tblProject;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKProjectCategoryChanging(long value);
    partial void OnPKProjectCategoryChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnFKUserCreatedChanging(System.Nullable<long> value);
    partial void OnFKUserCreatedChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnFKUserChangedChanging(System.Nullable<long> value);
    partial void OnFKUserChangedChanged();
    partial void OnChangedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnChangedOnChanged();
    partial void OnUniqueIdentifierChanging(System.Nullable<System.Guid> value);
    partial void OnUniqueIdentifierChanged();
    #endregion
		
		public tlkpProjectCategory()
		{
			this._tblProject = new EntitySet<tblProject>(new Action<tblProject>(this.attach_tblProject), new Action<tblProject>(this.detach_tblProject));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKProjectCategory", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long PKProjectCategory
		{
			get
			{
				return this._PKProjectCategory;
			}
			set
			{
				if ((this._PKProjectCategory != value))
				{
					this.OnPKProjectCategoryChanging(value);
					this.SendPropertyChanging();
					this._PKProjectCategory = value;
					this.SendPropertyChanged("PKProjectCategory");
					this.OnPKProjectCategoryChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserCreated", DbType="BigInt")]
		public System.Nullable<long> FKUserCreated
		{
			get
			{
				return this._FKUserCreated;
			}
			set
			{
				if ((this._FKUserCreated != value))
				{
					this.OnFKUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._FKUserCreated = value;
					this.SendPropertyChanged("FKUserCreated");
					this.OnFKUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserChanged", DbType="BigInt")]
		public System.Nullable<long> FKUserChanged
		{
			get
			{
				return this._FKUserChanged;
			}
			set
			{
				if ((this._FKUserChanged != value))
				{
					this.OnFKUserChangedChanging(value);
					this.SendPropertyChanging();
					this._FKUserChanged = value;
					this.SendPropertyChanged("FKUserChanged");
					this.OnFKUserChangedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ChangedOn
		{
			get
			{
				return this._ChangedOn;
			}
			set
			{
				if ((this._ChangedOn != value))
				{
					this.OnChangedOnChanging(value);
					this.SendPropertyChanging();
					this._ChangedOn = value;
					this.SendPropertyChanged("ChangedOn");
					this.OnChangedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueIdentifier", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UniqueIdentifier
		{
			get
			{
				return this._UniqueIdentifier;
			}
			set
			{
				if ((this._UniqueIdentifier != value))
				{
					this.OnUniqueIdentifierChanging(value);
					this.SendPropertyChanging();
					this._UniqueIdentifier = value;
					this.SendPropertyChanged("UniqueIdentifier");
					this.OnUniqueIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlkpProjectCategory_tblProject", Storage="_tblProject", ThisKey="PKProjectCategory", OtherKey="FKProjectCategory")]
		public EntitySet<tblProject> tblProject
		{
			get
			{
				return this._tblProject;
			}
			set
			{
				this._tblProject.Assign(value);
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
		
		private void attach_tblProject(tblProject entity)
		{
			this.SendPropertyChanging();
			entity.tlkpProjectCategory = this;
		}
		
		private void detach_tblProject(tblProject entity)
		{
			this.SendPropertyChanging();
			entity.tlkpProjectCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlkpProjectType")]
	public partial class tlkpProjectType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _PKProjectType;
		
		private string _Name;
		
		private string _Description;
		
		private System.Data.Linq.Binary _Picture;
		
		private System.Nullable<long> _FKUserCreated;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<long> _FKUserChanged;
		
		private System.Nullable<System.DateTime> _ChangedOn;
		
		private System.Nullable<System.Guid> _UniqueIdentifier;
		
		private EntitySet<tblProject> _tblProject;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPKProjectTypeChanging(long value);
    partial void OnPKProjectTypeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnFKUserCreatedChanging(System.Nullable<long> value);
    partial void OnFKUserCreatedChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnFKUserChangedChanging(System.Nullable<long> value);
    partial void OnFKUserChangedChanged();
    partial void OnChangedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnChangedOnChanged();
    partial void OnUniqueIdentifierChanging(System.Nullable<System.Guid> value);
    partial void OnUniqueIdentifierChanged();
    #endregion
		
		public tlkpProjectType()
		{
			this._tblProject = new EntitySet<tblProject>(new Action<tblProject>(this.attach_tblProject), new Action<tblProject>(this.detach_tblProject));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PKProjectType", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long PKProjectType
		{
			get
			{
				return this._PKProjectType;
			}
			set
			{
				if ((this._PKProjectType != value))
				{
					this.OnPKProjectTypeChanging(value);
					this.SendPropertyChanging();
					this._PKProjectType = value;
					this.SendPropertyChanged("PKProjectType");
					this.OnPKProjectTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserCreated", DbType="BigInt")]
		public System.Nullable<long> FKUserCreated
		{
			get
			{
				return this._FKUserCreated;
			}
			set
			{
				if ((this._FKUserCreated != value))
				{
					this.OnFKUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._FKUserCreated = value;
					this.SendPropertyChanged("FKUserCreated");
					this.OnFKUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKUserChanged", DbType="BigInt")]
		public System.Nullable<long> FKUserChanged
		{
			get
			{
				return this._FKUserChanged;
			}
			set
			{
				if ((this._FKUserChanged != value))
				{
					this.OnFKUserChangedChanging(value);
					this.SendPropertyChanging();
					this._FKUserChanged = value;
					this.SendPropertyChanged("FKUserChanged");
					this.OnFKUserChangedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ChangedOn
		{
			get
			{
				return this._ChangedOn;
			}
			set
			{
				if ((this._ChangedOn != value))
				{
					this.OnChangedOnChanging(value);
					this.SendPropertyChanging();
					this._ChangedOn = value;
					this.SendPropertyChanged("ChangedOn");
					this.OnChangedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UniqueIdentifier", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UniqueIdentifier
		{
			get
			{
				return this._UniqueIdentifier;
			}
			set
			{
				if ((this._UniqueIdentifier != value))
				{
					this.OnUniqueIdentifierChanging(value);
					this.SendPropertyChanging();
					this._UniqueIdentifier = value;
					this.SendPropertyChanged("UniqueIdentifier");
					this.OnUniqueIdentifierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlkpProjectType_tblProject", Storage="_tblProject", ThisKey="PKProjectType", OtherKey="FKProjectType")]
		public EntitySet<tblProject> tblProject
		{
			get
			{
				return this._tblProject;
			}
			set
			{
				this._tblProject.Assign(value);
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
		
		private void attach_tblProject(tblProject entity)
		{
			this.SendPropertyChanging();
			entity.tlkpProjectType = this;
		}
		
		private void detach_tblProject(tblProject entity)
		{
			this.SendPropertyChanging();
			entity.tlkpProjectType = null;
		}
	}
}
#pragma warning restore 1591
