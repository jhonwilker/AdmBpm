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
    public class ServidorPersist : IServidorPersist
    {
        private readonly ProAdmContext _context;
        
        public ServidorPersist(ProAdmContext context)
        {
            _context = context;           
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; 
        }
        public async Task<Servidor[]> GetAllServidoresAsync()
        {
            IQueryable<Servidor> query = _context.Servidores;                                                 

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


        
    }
}