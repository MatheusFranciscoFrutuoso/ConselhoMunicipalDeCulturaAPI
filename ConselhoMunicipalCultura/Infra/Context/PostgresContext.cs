using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("server=localhost;Database=postgres;user id=postgres;Password=senha123;Persist Security Info=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>();
            modelBuilder.Entity<Editais>();
            modelBuilder.Entity<DocumentosUsuarios>();
            modelBuilder.Entity<Tema>();
        }
    }    
}
