﻿using Microsoft.EntityFrameworkCore;
namespace immid.Models
{
    public class ProjectContext : DbContext
    {
        //Помогает получить из бд набор данных (таблица)
        public DbSet<ProjectModel> Projects { get; set; }
        
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
            //При отсутствии бд создает ее
            Database.EnsureCreated();
        }
    }
}
