using Microsoft.EntityFrameworkCore;

namespace PrintersBackend.Models
{
    public class PrinterContext : DbContext
    {
        public PrinterContext(DbContextOptions<PrinterContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<Printer> Printers { get; set; } = null!;
        public DbSet<PrinterModel> Models { get; set; } = null!;
        public DbSet<PrinterType> Types { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Cyrillic_General_CI_AS");

            modelBuilder.Entity<PrinterModel>()
                .HasMany(e => e.Printers)
                .WithOne(e => e.Model)
                .HasForeignKey(e => e.ModelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PrinterType>()
                .HasMany(e => e.Models)
                .WithOne(e => e.Type)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.Models)
                .WithOne(e => e.Vendor)
                .HasForeignKey(e => e.VendorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
