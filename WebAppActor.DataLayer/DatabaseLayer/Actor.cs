namespace WebAppActor.DataLayer.DatabaseLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Actor : DbContext
    {
        public Actor()
            : base("name=Actor")
        {
        }

        public virtual DbSet<ActorInfo> ActorInfo { get; set; }
        public virtual DbSet<Eyes> Eyes { get; set; }
        public virtual DbSet<PhotoActor> PhotoActor { get; set; }
        public virtual DbSet<PrjDetail> PrjDetail { get; set; }
        public virtual DbSet<PrjMain> PrjMain { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserInRoles> UserInRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eyes>()
                .HasMany(e => e.ActorInfo)
                .WithRequired(e => e.Eyes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhotoActor>()
                .HasMany(e => e.PrjDetail)
                .WithRequired(e => e.PhotoActor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrjMain>()
                .HasMany(e => e.PrjDetail)
                .WithRequired(e => e.PrjMain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.UserInRoles)
                .WithRequired(e => e.Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.PrjMain)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserInRoles)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
