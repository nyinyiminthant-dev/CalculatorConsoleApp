using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorConsoleApp.DataBase;
using Microsoft.EntityFrameworkCore;

namespace CalculatorConsoleApp.Dtos;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(MyConnection._sqlConnectionStringBuilder.ConnectionString);
        }
    }

   public DbSet<Model> models { get; set; }
}
