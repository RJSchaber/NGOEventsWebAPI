﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGOEventsWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ngoEntities : DbContext
    {
        public ngoEntities()
            : base("name=ngoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<UserM> UserMs { get; set; }
        public virtual DbSet<UserNGO> UserNGOes { get; set; }
    }
}