using System;
using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}

