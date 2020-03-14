using Kit.Domain.Models;
using Kit.Infra.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Kit.Infra.Contexto
{
    public class KitControleContext : DbContext
    {
        public KitControleContext()
        {

        }

        public KitControleContext(DbContextOptions<KitControleContext> options)
            :base(options){}

        public DbSet<Usuario> Usuarios;


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
