using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Persistence.Contracts
{
    public interface IServidorPersist
    {
       
        Task<Servidor> GetServidorByIdAsync(int servidorId);
        Task<Servidor[]> GetAllServidoresAsync();

    }
}