using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wms_android.shared.Models;

namespace wms_android.shared.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Dispatch> Dispatches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure DateTime properties
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties()
                    .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?)))
                {
                    if (property.Name == nameof(Parcel.CreatedAt) || property.Name == nameof(Parcel.DispatchedAt))
                    {
                        property.SetColumnType("timestamp with time zone");
                    }
                    else
                    {
                        property.SetColumnType("timestamp without time zone");
                        
                        var converter = new ValueConverter<DateTime, DateTime>(
                            v => v.Kind == DateTimeKind.Utc ? v.ToLocalTime() : DateTime.SpecifyKind(v, DateTimeKind.Local),
                            v => DateTime.SpecifyKind(v, DateTimeKind.Local)
                        );

                        property.SetValueConverter(converter);
                    }
                }
            }

            // Configure Parcel entity
            modelBuilder.Entity<Parcel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone");
                entity.Property(e => e.DispatchedAt)
                    .HasColumnType("timestamp with time zone");

                // Configure relationship with User
                entity.HasOne(p => p.CreatedBy)
                      .WithMany()
                      .HasForeignKey(p => p.CreatedById)
                      .OnDelete(DeleteBehavior.SetNull)
                      .IsRequired(false);
            });

            // Configure Shipment entity
            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasIndex(e => e.WaybillNumber)
                      .IsUnique();

                entity.Property(e => e.CreatedAt)
                      .HasColumnType("timestamp with time zone");

                entity.HasOne(s => s.Creator)
                      .WithMany() 
                      .HasForeignKey(s => s.CreatedById)
                      .OnDelete(DeleteBehavior.SetNull) 
                      .IsRequired(false);

                entity.HasMany(s => s.Parcels)
                      .WithOne(p => p.Shipment)
                      .HasForeignKey(p => p.ShipmentId)
                      .OnDelete(DeleteBehavior.Cascade); 
            });

            // Configure Vehicle entity
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.VehicleRegistrationNumber).IsRequired();
                entity.Property(e => e.BodyType).IsRequired();
            });

            // Configure Drivers entity
            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Initials).IsRequired();
                entity.Property(e => e.LicenseNumber).IsRequired();
            });

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("timestamp without time zone");

                entity.HasOne(u => u.Role)
                    .WithMany()
                    .HasForeignKey(u => u.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configure Dispatch entity
            modelBuilder.Entity<Dispatch>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.SourceBranch).IsRequired();
                entity.Property(e => e.VehicleNumber).IsRequired();
                entity.Property(e => e.Driver).IsRequired();
                entity.Property(e => e.DispatchTime)
                    .HasColumnType("timestamp with time zone");
                entity.Property(e => e.Status).IsRequired();

                // Configure relationship with Parcels
                entity.HasMany(d => d.Parcels)
                    .WithMany()
                    .UsingEntity(j => j.ToTable("DispatchParcels"));
            });

            // Seed Vehicle data
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KDL 085M", BodyType = "Truck" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KCY 067A", BodyType = "Truck" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KCZ 595L", BodyType = "Truck" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KDB 387Q", BodyType = "Truck" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KDE 228S", BodyType = "Truck" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KAY 215H", BodyType = "Van" },
                new Vehicle { Id = Guid.NewGuid(), VehicleRegistrationNumber = "KBF 462A", BodyType = "Van" }
            );

            // Seed Drivers data
            modelBuilder.Entity<Drivers>().HasData(
                new Drivers { Id = Guid.NewGuid(), FirstName = "John", LastName = "Njuguna", Initials = "JN", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "Robert", LastName = "Njuguna", Initials = "RN", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "John", LastName = "Mwai", Initials = "JM", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "David", LastName = "Mwangi", Initials = "DM", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "David", LastName = "Kibet", Initials = "DK", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "Erastus", LastName = "Kagwa", Initials = "EK", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "Julius", LastName = "Kamula", Initials = "JK", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "Stephen", LastName = "Kimuyu", Initials = "SK", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "Charles", LastName = "Maina", Initials = "CM", LicenseNumber = "DL123456" },
                new Drivers { Id = Guid.NewGuid(), FirstName = "James", LastName = "Gichohi", Initials = "JG", LicenseNumber = "DL123456" }
            );

            // Seed Roles data
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", Description = "Administrator" },
                new Role { Id = 2, Name = "Manager", Description = "Manager" },
                new Role { Id = 3, Name = "Clerk", Description = "Regular User" },
                new Role { Id = 4, Name = "Client", Description = "Client User" }
            );

            // Seed Users data
            var createdAtDate = DateTime.SpecifyKind(new DateTime(2023, 1, 1, 0, 0, 0), DateTimeKind.Local);
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash("clerk123", out passwordHash, out passwordSalt);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@example.com",
                    Password = "admin123",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = 1,
                    CreatedAt = createdAtDate.ToLocalTime()
                },
                new User
                {
                    Id = 2,
                    Username = "manager",
                    FirstName = "Manager",
                    LastName = "Person",
                    Email = "manager@example.com",
                    Password = "manager123",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = 2,
                    CreatedAt = createdAtDate.ToLocalTime()
                },
                new User
                {
                    Id = 3,
                    Username = "clerk1",
                    FirstName = "Clerk",
                    LastName = "One",
                    Email = "clerk1@example.com",
                    Password = "clerk123",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = 3,
                    CreatedAt = createdAtDate.ToLocalTime()
                },
                new User
                {
                    Id = 4,
                    Username = "clerk2",
                    FirstName = "Clerk",
                    LastName = "Two",
                    Email = "clerk2@example.com",
                    Password = "clerk123",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = 3,
                    CreatedAt = createdAtDate.ToLocalTime()
                },
                new User
                {
                    Id = 5,
                    Username = "client1",
                    FirstName = "Client",
                    LastName = "UserOne",
                    Email = "client1@example.com",
                    Password = "client123",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    RoleId = 4,
                    CreatedAt = createdAtDate.ToLocalTime()
                }
            );
            
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}