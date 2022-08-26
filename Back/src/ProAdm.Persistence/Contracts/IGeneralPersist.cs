using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Persistence.Contracts
{
    public interface IGeneralPersist
    {

        void Insert<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class; 
        void Delete<T>(T entity) where T: class; 
        void DeleteRange<T>(T[] entity) where T: class; 

        Task<bool> SaveChangeAsync();

      

    }
}