using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAdm.Domain;
using ProAdm.Persistence.Contexts;
using ProAdm.Persistence.Contracts;

namespace ProAdm.Persistence
{
    public class AbastecimentoPersist : IAbastecimentoPersist
    {
        private readonly ProAdmContext _context;
        
        public AbastecimentoPersist(ProAdmContext context)
        {
            _context = context; 
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;          
            
        }
        

        public async Task<Abastecimento> GetAbastecimentoByIdAsync(int AbastecimentoId)
        {
            IQueryable<Abastecimento> query = _context.Abastecimentos
                                                      .Include(a=>a.Responsavel)
                                                      .Include(a => a.Viatura);                                                 

            query = query.OrderBy(a => a.Id)
                         .Where(a => a.Id == AbastecimentoId);
            
                         

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Abastecimento[]> GetAllAbastecimentosAsync()
        {
            IQueryable<Abastecimento> query = _context.Abastecimentos
                                                      .Include(a => a.Responsavel)
                                                      .Include(a => a.Viatura);

            query = query.OrderBy(a => a.Id);

            return await query.ToArrayAsync();
        }
        
    }
}