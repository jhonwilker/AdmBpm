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
    public class GeneralPersist: IGeneralPersist
    {
        private readonly ProAdmContext _context;
        
        public GeneralPersist(ProAdmContext context)
        {
            _context = context;           
            
        }
        public void Insert<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
             _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
             _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
             _context.RemoveRange(entityArray);
        }
        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    
        
    }
}