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

        public async Task InsertDbAsync(string nameDay, string nameMonth, string categori, string nameEvent, int DayNumber)
        {
            DATA_month m = new DATA_month();
            DATA_day d = new DATA_day();
            DATA_event e= new DATA_event();
          
            m.name = "Test";
            _dbContext.months.Add(m);
            _dbContext.Days.Add(d);
            _dbContext.Events.Add(e);
           
            await _dbContext.SaveChangesAsync();
        }
    }
}
