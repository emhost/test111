﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication15
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities3 : DbContext
    {
        public Entities3()
            : base("name=Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<V_COST_INFO> V_COST_INFO { get; set; }
        public virtual DbSet<V_DICDEPART> V_DICDEPART { get; set; }
        public virtual DbSet<V_EXAMITEMS_INFO> V_EXAMITEMS_INFO { get; set; }
        public virtual DbSet<V_GHSF_CARD> V_GHSF_CARD { get; set; }
        public virtual DbSet<V_GHSF_REGHIS> V_GHSF_REGHIS { get; set; }
        public virtual DbSet<V_LABITEMS_INFO> V_LABITEMS_INFO { get; set; }
        public virtual DbSet<V_MZ_CHARGEDETAIL> V_MZ_CHARGEDETAIL { get; set; }
        public virtual DbSet<V_PATIENT_BASIC_INFO> V_PATIENT_BASIC_INFO { get; set; }
        public virtual DbSet<V_PATIENT_ZY_INFO> V_PATIENT_ZY_INFO { get; set; }
        public virtual DbSet<V_REGPLAN> V_REGPLAN { get; set; }
        public virtual DbSet<V_STAFF> V_STAFF { get; set; }
        public virtual DbSet<V_TJ_PACKAGE> V_TJ_PACKAGE { get; set; }
        public virtual DbSet<V_TJ_PEINFO> V_TJ_PEINFO { get; set; }
        public virtual DbSet<V_TJ_PETIME> V_TJ_PETIME { get; set; }
        public virtual DbSet<V_ZYGL_PREPAY> V_ZYGL_PREPAY { get; set; }
        public virtual DbSet<V_ZYGL_REGHIS> V_ZYGL_REGHIS { get; set; }
    }
}
