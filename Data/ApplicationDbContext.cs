using System;
using System.Collections.Generic;
using System.Text;
using CensusManagement_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CensusManagement_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User>Users { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
