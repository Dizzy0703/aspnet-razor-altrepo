using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeanSceneReservationSystem.Models;

namespace BeanSceneReservationSystem.Data
{
    public class BeanSceneReservationSystemContext : DbContext
    {
        public BeanSceneReservationSystemContext (DbContextOptions<BeanSceneReservationSystemContext> options)
            : base(options)
        {
        }

        public DbSet<BeanSceneReservationSystem.Models.User> User { get; set; } = default!;

        public DbSet<BeanSceneReservationSystem.Models.Reservation> Reservation { get; set; }
    }
}
