﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _17DemoEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class punedbEntities : DbContext
    {
        public punedbEntities()
            : base("name=punedbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
