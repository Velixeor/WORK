using Microsoft.EntityFrameworkCore;
using WORK.Models;
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WORK.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { 
        
        }
        public DbSet<DATA_month> months { get; set; }
        public DbSet<DATA_day> Days { get; set; }
        public DbSet<DATA_event> Events { get; set; }
        //Add-Migration InitialMigration -c ApplicationDbContext -o Data/Migrations
        //Update-Database -context ApplicationDbContext
        //pg_ctl start -D "C:\Program Files\PostgreSQL\15\data"
    }
}
