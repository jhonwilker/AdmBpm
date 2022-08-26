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
    public class ViaturaPersist : IViaturaPersist
    {
        private readonly ProAdmContext _context;
        
        public ViaturaPersist(ProAdmContext context)
        {
            _context = context;           
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }
    

        public async Task<Viatura[]> GetAllViaturasAsync()
        {
            IQueryable<Viatura> query = _context.Viaturas;                                                 

            query = query.OrderBy(a=> a.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Servidor> GetServidorByIdAsync(int ServidorId)
        {
            IQueryable<Servidor> query = _context.Servidores;                                                 

            query = query.OrderBy(s => s.Id)
                         .Where(s => s.Id == ServidorId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Viatura> GetViaturaByIdAsync(int ViaturaId)
        {
            IQueryable<Viatura> query = _context.Viaturas;                                                                                                 

            query = query.OrderBy(v=> v.Id)
                         .Where(v => v.Id == ViaturaId);

            return await query.FirstOrDefaultAsync();
        }

        
    }
}