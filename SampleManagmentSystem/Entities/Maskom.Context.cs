﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleManagmentSystem.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MikroDB_V16_MASKOM : DbContext
    {
        public MikroDB_V16_MASKOM()
            : base("name=MikroDB_V16_MASKOM")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADAY_CARI_HESAPLAR> ADAY_CARI_HESAPLAR { get; set; }
        public virtual DbSet<CARI_HESAPLAR> CARI_HESAPLAR { get; set; }
        public virtual DbSet<STOK_ALT_GRUPLARI> STOK_ALT_GRUPLARI { get; set; }
        public virtual DbSet<STOK_ANA_GRUPLARI> STOK_ANA_GRUPLARI { get; set; }
        public virtual DbSet<STOKLAR> STOKLAR { get; set; }
        public virtual DbSet<URUNLER> URUNLER { get; set; }
    }
}
