﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourseEvalDB_WDEntities : DbContext
    {
        public CourseEvalDB_WDEntities()
            : base("name=CourseEvalDB_WDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_has_Courses> Student_has_Courses { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        public System.Data.Entity.DbSet<WebApi.Models.StuMember> StuMembers { get; set; }
    }
}
