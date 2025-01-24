using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaCrud.Models;

public partial class ConfeccionesElCondorContext : DbContext
{
    public ConfeccionesElCondorContext()
    {
    }

    public ConfeccionesElCondorContext(DbContextOptions<ConfeccionesElCondorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=ConfeccionesElCondor ;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");//
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Idempleado).HasName("PK__Empleado__50621DCDF535D82F");

            entity.HasIndex(e => e.NumDocumento, "UQ__Empleado__11150A80F7956322").IsUnique();

            entity.Property(e => e.Idempleado).HasColumnName("IDEmpleado");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
