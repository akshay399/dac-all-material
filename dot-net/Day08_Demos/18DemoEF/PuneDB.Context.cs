﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _18DemoEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PuneDBEntities : DbContext
    {
        public PuneDBEntities()
            : base("name=PuneDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Emp> Emps { get; set; }
        public DbSet<EmpDetail> EmpDetails { get; set; }
    
        public virtual ObjectResult<spSelectByCity_Result> spSelectByCity(string city)
        {
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectByCity_Result>("spSelectByCity", cityParameter);
        }
    }
}