using System;
using ConstructionERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ConstructionERP.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
