using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Models.RacketsModels;

namespace TennisStoreApi.Models.DbModels;

public partial class OnlineStoreContext : DbContext
{
 

    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
        : base(options)
    {
    }





    public virtual DbSet<Racket> Rackets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=OnlineShop;User=sa;Password=Asdfg12345;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BId).HasName("PK_Brand_Id");

            entity.Property(e => e.BId)
                .ValueGeneratedNever()
                .HasColumnName("b_id");
            entity.Property(e => e.BImage)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("b_image");
            entity.Property(e => e.BName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("b_name");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.RefId).HasColumnName("ref_id");
        });

        modelBuilder.Entity<Racket>(entity =>
        {
            entity.HasKey(e => e.RId).HasName("PK_Racket_Id");

            entity.Property(e => e.RId)
                .ValueGeneratedNever()
                .HasColumnName("r_id");
            entity.Property(e => e.RBrand).HasColumnName("r_brand");
            entity.Property(e => e.RImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("r_image_url");
            entity.Property(e => e.RName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("r_name");
            entity.Property(e => e.RPrice)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("r_price");

            entity.HasOne(d => d.RBrandNavigation).WithMany(p => p.Rackets)
                .HasForeignKey(d => d.RBrand)
                .HasConstraintName("FK_Brands_To_Rackets");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
