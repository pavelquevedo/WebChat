﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebChat.Api.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebChatDBEntities : DbContext
    {
        public WebChatDBEntities()
            : base("name=WebChatDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
