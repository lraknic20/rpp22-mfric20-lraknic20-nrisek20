using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class WinatjecajModel : DbContext
    {
        public WinatjecajModel()
            : base("name=WinatjecajModel")
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Criterion> Criteria { get; set; }
        public virtual DbSet<Documentation> Documentations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasMany(e => e.Documentations)
                .WithRequired(e => e.Application)
                .HasForeignKey(e => new { e.users_id, e.competitions_id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.needed_documentation)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.Competition)
                .HasForeignKey(e => e.competitions_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Competition>()
                .HasMany(e => e.Criteria)
                .WithMany(e => e.Competitions)
                .Map(m => m.ToTable("Competitions_Criteria").MapLeftKey("competitions_id").MapRightKey("criteria_id"));

            modelBuilder.Entity<Criterion>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Criterion>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Documentation>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Documentation>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.roles_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.oib)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);
        }
    }
}
