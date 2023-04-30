using Microsoft.EntityFrameworkCore;
using System;
using WORK.Context;

namespace WORK.Models
{
    public class Interaction_with_the_database
    {
        private readonly ApplicationDbContext _dbContext;

        public Interaction_with_the_database(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task InsertUserAsync()
        {
            
            
                 DATA_month m=new DATA_month();
            m.name = "Test";
            m.id = 2;
          
            _dbContext.months.Add(m);
            await _dbContext.SaveChangesAsync();
        }
    }
}
