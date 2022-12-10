using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorTests.Models;

namespace RazorTests.Data
{
    public class RazorTestsContext : DbContext
    {
        public RazorTestsContext (DbContextOptions<RazorTestsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorTests.Models.Vessel> Vessel { get; set; } = default!;
    }
}
