﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class fingerPrintInBusDBEntities : DbContext
    {
        public fingerPrintInBusDBEntities()
            : base("name=fingerPrintInBusDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConstractToUser> ConstractToUsers { get; set; }
        public virtual DbSet<ConstractTravel> ConstractTravels { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<TravelToUser> TravelToUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Travel> Travels { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
    }
}
