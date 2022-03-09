using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMan_saep.Models;

namespace TechMan_saep.Data
{
    public class ContextoTech : DbContext
    {
        public ContextoTech(DbContextOptions<ContextoTech> options)
                   : base(options)
        {
        }

        public DbSet<Perfis> Perfis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipamentos> Equipamentos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
    }
}