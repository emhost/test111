namespace WindowsFormsApplication15
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<JZHZ> JZHZ { get; set; }
        public virtual DbSet<JZHZ_RELATION> JZHZ_RELATION { get; set; }
        public virtual DbSet<PAYMENT> PAYMENT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JZHZ>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.NSEX)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.VSFZH)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.VCARD)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.VPWD)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.VPYM)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ>()
                .Property(e => e.VPATIENTID)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VSFZH)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VCARD)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VGX)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VGLID)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VPYM)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.NSEX)
                .IsUnicode(false);

            modelBuilder.Entity<JZHZ_RELATION>()
                .Property(e => e.VPATIENTID)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VDDLSH)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VCLINICNO)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VCARD)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VSFZH)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VDEPT)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VDOCTOR)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.NCOSTS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VREMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VAPPTIME)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.VHZID)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.NGHF)
                .HasPrecision(10, 4);

            modelBuilder.Entity<PAYMENT>()
                .Property(e => e.NZLF)
                .HasPrecision(10, 4);
        }
    }
}
