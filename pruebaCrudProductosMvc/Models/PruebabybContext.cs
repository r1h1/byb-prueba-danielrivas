using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pruebaCrudProductosMvc.Models;

public partial class PruebabybContext : DbContext
{
    public PruebabybContext()
    {
    }

    public PruebabybContext(DbContextOptions<PruebabybContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      //  => optionsBuilder.UseSqlServer("SERVER=L-EC-05-0378\\SQLEXPRESS; DATABASE=pruebabyb; INTEGRATED SECURITY=true; ENCRYPT=false; TRUSTED_CONNECTION=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F6AEA14FC");

            entity.ToTable("productos");

            entity.HasIndex(e => e.CodigoProducto, "UQ__producto__BCDE77E053785464").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodigoProducto).HasColumnName("codigoProducto");
            entity.Property(e => e.FechaProducto)
                .HasColumnType("date")
                .HasColumnName("fechaProducto");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreProducto");
            entity.Property(e => e.PrecioProducto)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("precioProducto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
