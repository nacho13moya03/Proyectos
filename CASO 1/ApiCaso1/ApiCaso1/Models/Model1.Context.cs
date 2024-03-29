﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiCaso1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CasoEstudioKNEntities : DbContext
    {
        public CasoEstudioKNEntities()
            : base("name=CasoEstudioKNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Movimientos> Movimientos { get; set; }
        public virtual DbSet<TiposMovimientos> TiposMovimientos { get; set; }
    
        public virtual ObjectResult<ConsultarMovimientos_SP_Result> ConsultarMovimientos_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarMovimientos_SP_Result>("ConsultarMovimientos_SP");
        }
    
        public virtual int RegistrarMovimientos_SP(string descripcion, Nullable<decimal> monto, Nullable<int> tipoMovimiento)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("Monto", monto) :
                new ObjectParameter("Monto", typeof(decimal));
    
            var tipoMovimientoParameter = tipoMovimiento.HasValue ?
                new ObjectParameter("TipoMovimiento", tipoMovimiento) :
                new ObjectParameter("TipoMovimiento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarMovimientos_SP", descripcionParameter, montoParameter, tipoMovimientoParameter);
        }
    }
}
