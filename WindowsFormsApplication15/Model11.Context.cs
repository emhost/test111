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
    
    public partial class Entities11 : DbContext
    {
        public Entities11()
            : base("name=Entities11")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<V_STAFF> V_STAFF { get; set; }
        public virtual DbSet<JZHZ_RELATION> JZHZ_RELATION { get; set; }
        public virtual DbSet<V_MZSF_PRESC> V_MZSF_PRESC { get; set; }
        public virtual DbSet<JZHZ> JZHZ { get; set; }
    }
}
