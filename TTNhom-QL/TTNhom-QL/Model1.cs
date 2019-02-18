namespace TTNhom_QL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HANGTON> HANGTONs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<PHIEUXUAT> PHIEUXUATs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HANGTON>()
                .Property(e => e.Idhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HANGTON>()
                .Property(e => e.Tenhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HANGTON>()
                .Property(e => e.Dvt)
                .IsFixedLength();

            modelBuilder.Entity<NCC>()
                .Property(e => e.Idncc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.Tenncc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.Diachi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.Sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.Idphieun)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.Idhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.Idncc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.Tenhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.Dvt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.Idphieux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.Idhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.Tenhang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUXUAT>()
                .Property(e => e.Dvt)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
