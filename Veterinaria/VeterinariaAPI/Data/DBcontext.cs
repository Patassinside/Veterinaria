using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using VeterinariaAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace VeterinariaAPI.Models
{
    public class VeterinariaDbContext : DbContext
    {

        public DbSet<Mascotas> Mascotas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<CitaProducto> CitaProducto { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }


        public VeterinariaDbContext(DbContextOptions<VeterinariaDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clientes>()
            .HasKey(c => c.IdCliente);

            modelBuilder.Entity<Citas>()
            .HasKey(c => c.IdCita);

            modelBuilder.Entity<Mascotas>()
            .HasKey(c => c.IdMascota);

            modelBuilder.Entity<Productos>()
                .HasKey(p => p.IdProducto);

            modelBuilder.Entity<Proveedor>()
                .HasKey(p => p.IdProveedor);

            modelBuilder.Entity<Servicios>()
                .HasKey(s => s.IdServicio);


            modelBuilder.Entity<CitaProducto>()
                .HasNoKey();


            modelBuilder.Entity<Productos>()
                .HasOne(ps => ps.Proveedor)
                .WithMany(p => p.Productos)
                .HasForeignKey(ps => ps.IdProveedor);

            modelBuilder.Entity<Mascotas>()
                .HasOne(m => m.Cliente)
                .WithMany(c => c.Mascotas)
                .HasForeignKey(m => m.IdCliente);

            modelBuilder.Entity<CitaProducto>()
                .HasKey(cp => new { cp.IdProducto, cp.IdCita });


            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Citas)
                .WithMany(c => c.CitaProducto)
                .HasForeignKey(cp => cp.IdCita);

            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Productos)
                .WithMany(p => p.CitaProductos)
                .HasForeignKey(cp => cp.IdProducto);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Servicio)
                .WithMany(s => s.Citas)
                .HasForeignKey(c => c.IdServicio);

            modelBuilder.Entity<Citas>()
                .HasOne(c => c.Mascota)
                .WithMany(m => m.Citas)
                .HasForeignKey(c => c.IdMascota);


        }
    }
}
    
    
 