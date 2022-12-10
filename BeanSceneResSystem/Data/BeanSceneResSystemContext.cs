using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeanSceneResSystem.Models;

namespace BeanSceneResSystem.Data
{
    public class BeanSceneResSystemContext : DbContext
    {
        public BeanSceneResSystemContext (DbContextOptions<BeanSceneResSystemContext> options)
            : base(options)
        {
        }

        public DbSet<BeanSceneResSystem.Models.User> Users { get; set; } = default!;
        public DbSet<BeanSceneResSystem.Models.Reservation> Reservations { get; set; } = default!;
        public DbSet<BeanSceneResSystem.Models.RegisteredUser> RegisteredUsers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<RegisteredUser>().ToTable("RegisteredUser");
        }
    }
}
