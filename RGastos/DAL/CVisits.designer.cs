﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18052
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RGastos.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CVisits-v1")]
	public partial class CVisitsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertVisita(Visita instance);
    partial void UpdateVisita(Visita instance);
    partial void DeleteVisita(Visita instance);
    #endregion
		
		public CVisitsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CVisitsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CVisitsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CVisitsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CVisitsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CVisitsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Visita> Visita
		{
			get
			{
				return this.GetTable<Visita>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Visita")]
	public partial class Visita : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _VisitaID;
		
		private System.DateTime _FechaIngreso;
		
		private System.DateTime _FechaPlanificada;
		
		private string _Descripcion;
		
		private int _EstadoVisitaID;
		
		private int _LineaProductoID;
		
		private int _TipoVisitaID;
		
		private int _ClienteID;
		
		private int _UserId;
		
		private System.DateTime _FechaTermino;
		
		private bool _EsTodoElDia;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVisitaIDChanging(int value);
    partial void OnVisitaIDChanged();
    partial void OnFechaIngresoChanging(System.DateTime value);
    partial void OnFechaIngresoChanged();
    partial void OnFechaPlanificadaChanging(System.DateTime value);
    partial void OnFechaPlanificadaChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnEstadoVisitaIDChanging(int value);
    partial void OnEstadoVisitaIDChanged();
    partial void OnLineaProductoIDChanging(int value);
    partial void OnLineaProductoIDChanged();
    partial void OnTipoVisitaIDChanging(int value);
    partial void OnTipoVisitaIDChanged();
    partial void OnClienteIDChanging(int value);
    partial void OnClienteIDChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnFechaTerminoChanging(System.DateTime value);
    partial void OnFechaTerminoChanged();
    partial void OnEsTodoElDiaChanging(bool value);
    partial void OnEsTodoElDiaChanged();
    #endregion
		
		public Visita()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int VisitaID
		{
			get
			{
				return this._VisitaID;
			}
			set
			{
				if ((this._VisitaID != value))
				{
					this.OnVisitaIDChanging(value);
					this.SendPropertyChanging();
					this._VisitaID = value;
					this.SendPropertyChanged("VisitaID");
					this.OnVisitaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaIngreso", DbType="DateTime NOT NULL")]
		public System.DateTime FechaIngreso
		{
			get
			{
				return this._FechaIngreso;
			}
			set
			{
				if ((this._FechaIngreso != value))
				{
					this.OnFechaIngresoChanging(value);
					this.SendPropertyChanging();
					this._FechaIngreso = value;
					this.SendPropertyChanged("FechaIngreso");
					this.OnFechaIngresoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaPlanificada", DbType="DateTime NOT NULL")]
		public System.DateTime FechaPlanificada
		{
			get
			{
				return this._FechaPlanificada;
			}
			set
			{
				if ((this._FechaPlanificada != value))
				{
					this.OnFechaPlanificadaChanging(value);
					this.SendPropertyChanging();
					this._FechaPlanificada = value;
					this.SendPropertyChanged("FechaPlanificada");
					this.OnFechaPlanificadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstadoVisitaID", DbType="Int NOT NULL")]
		public int EstadoVisitaID
		{
			get
			{
				return this._EstadoVisitaID;
			}
			set
			{
				if ((this._EstadoVisitaID != value))
				{
					this.OnEstadoVisitaIDChanging(value);
					this.SendPropertyChanging();
					this._EstadoVisitaID = value;
					this.SendPropertyChanged("EstadoVisitaID");
					this.OnEstadoVisitaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineaProductoID", DbType="Int NOT NULL")]
		public int LineaProductoID
		{
			get
			{
				return this._LineaProductoID;
			}
			set
			{
				if ((this._LineaProductoID != value))
				{
					this.OnLineaProductoIDChanging(value);
					this.SendPropertyChanging();
					this._LineaProductoID = value;
					this.SendPropertyChanged("LineaProductoID");
					this.OnLineaProductoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoVisitaID", DbType="Int NOT NULL")]
		public int TipoVisitaID
		{
			get
			{
				return this._TipoVisitaID;
			}
			set
			{
				if ((this._TipoVisitaID != value))
				{
					this.OnTipoVisitaIDChanging(value);
					this.SendPropertyChanging();
					this._TipoVisitaID = value;
					this.SendPropertyChanged("TipoVisitaID");
					this.OnTipoVisitaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClienteID", DbType="Int NOT NULL")]
		public int ClienteID
		{
			get
			{
				return this._ClienteID;
			}
			set
			{
				if ((this._ClienteID != value))
				{
					this.OnClienteIDChanging(value);
					this.SendPropertyChanging();
					this._ClienteID = value;
					this.SendPropertyChanged("ClienteID");
					this.OnClienteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaTermino", DbType="DateTime NOT NULL")]
		public System.DateTime FechaTermino
		{
			get
			{
				return this._FechaTermino;
			}
			set
			{
				if ((this._FechaTermino != value))
				{
					this.OnFechaTerminoChanging(value);
					this.SendPropertyChanging();
					this._FechaTermino = value;
					this.SendPropertyChanged("FechaTermino");
					this.OnFechaTerminoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EsTodoElDia", DbType="Bit NOT NULL")]
		public bool EsTodoElDia
		{
			get
			{
				return this._EsTodoElDia;
			}
			set
			{
				if ((this._EsTodoElDia != value))
				{
					this.OnEsTodoElDiaChanging(value);
					this.SendPropertyChanging();
					this._EsTodoElDia = value;
					this.SendPropertyChanged("EsTodoElDia");
					this.OnEsTodoElDiaChanged();
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