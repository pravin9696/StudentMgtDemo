﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentMgtDemo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentMGTEntities : DbContext
    {
        public StudentMGTEntities()
            : base("name=StudentMGTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
