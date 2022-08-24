using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAdm.Domain;

namespace ProAdm.Persistence
{
    public class ProAdmContext:DbContext
    {
        public ProAdmContext(DbContextOptions<ProAdmContext> options): base(options){}
        public DbSet<Viatura> Viaturas { get; set; }
        public DbSet<Servidor> Servidores { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}