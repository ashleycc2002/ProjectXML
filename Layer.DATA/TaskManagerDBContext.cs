using System;
using System.Collections.Generic;
using Layer.DATA.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Layer.DATA
{
    public partial class TaskManagerDBContext : DbContext
    {
       
        public TaskManagerDBContext(DbContextOptions<TaskManagerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<InfoCustomer> InfoCustomers { get; set; } = null!;
        public virtual DbSet<ServerInfo> ServerInfos { get; set; } = null!;
       // public virtual DbSet<Task> Tasks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-S1KPBO3;Initial Catalog=TaskManagerDB;User ID=sa;Password=rossy2233;Application Name=MyApp");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.ExternalId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("externalId");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsoCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("isoCode")
                    .IsFixedLength();

                entity.Property(e => e.IsoCodi)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("isoCodi")
                    .IsFixedLength();
            });

            modelBuilder.Entity<InfoCustomer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__InfoCust__A4AE64D8039AFCFC");

                entity.ToTable("InfoCustomer");

                entity.Property(e => e.ChildDocumentNumber).HasMaxLength(30);

                entity.Property(e => e.ChildDocumentType).HasMaxLength(1);

                entity.Property(e => e.CustomerName).HasMaxLength(30);

                entity.Property(e => e.CustomerSegment).HasMaxLength(30);

                entity.Property(e => e.CustomerType).HasMaxLength(25);

                entity.Property(e => e.DocumentNumber).HasMaxLength(60);

                entity.Property(e => e.DocumentType).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.UserId).HasMaxLength(30);
            });

            modelBuilder.Entity<ServerInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.ToTable("ServerInfo");

                entity.Property(e => e.Chanel)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Funcion)
                    .HasMaxLength(50)
                    .HasColumnName("funcion");

                entity.Property(e => e.Languge)
                    .HasMaxLength(50)
                    .HasColumnName("languge");

                entity.Property(e => e.ServerSource).HasMaxLength(30);

                entity.Property(e => e.Serverip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceSource).HasMaxLength(40);
            });

           

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
