using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Application.Constracts
{
    public interface IViaturaService
    {
        Task<Viatura> AddViatura(Viatura model);
        Task<Viatura> UpdateViatura(int viaturaId, Viatura model);
        Task<bool> DeleteViatura(int viaturaId);    
        Task<Viatura> GetViaturaByIdAsync(int viaturaId);
        Task<Viatura[]> GetAllViaturasAsync();
    }
}