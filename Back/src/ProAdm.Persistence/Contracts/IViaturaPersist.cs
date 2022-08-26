using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Persistence.Contracts
{
    public interface IViaturaPersist
    {

        Task<Viatura> GetViaturaByIdAsync(int siaturaId); 
        Task<Viatura[]> GetAllViaturasAsync();

    }
}