using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Application.Constracts
{
    public interface IServidorService 
    {
        Task<Servidor> AddServidor(Servidor model);
        Task<Servidor> UpdateServidor(int servidorId, Servidor model);
        Task<bool> DeleteServidor(int servidorId);    
        Task<Servidor> GetServidorByIdAsync(int servidorId);
        Task<Servidor[]> GetAllServidoresAsync();
    }
}