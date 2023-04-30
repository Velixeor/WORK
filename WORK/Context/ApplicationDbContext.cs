using Microsoft.EntityFrameworkCore;
using WORK.Models;
using System;
namespace WORK.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { 
        
        }
        public DbSet<DATA_month> months { get; set; }
    }
}
