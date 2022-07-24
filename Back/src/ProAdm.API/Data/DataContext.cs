using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAdm.API.Models;

namespace ProAdm.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<Viatura> Viaturas { get; set; }
        public DbSet<Policial> Policiais { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
    }
}