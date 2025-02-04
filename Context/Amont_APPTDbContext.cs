

using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Amont_APPT.Models;
namespace Amont_APPT.Context
{
    public class Amont_APPTDbContext : DbContext
    {

        public DbSet<FormModel> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PGED1TP\SQLEXPRESS;Initial Catalog=TechnicianScheduler;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }


    }
}
