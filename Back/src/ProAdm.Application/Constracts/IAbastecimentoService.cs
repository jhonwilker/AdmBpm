using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Application.Constracts
{
    public interface IAbastecimentoService
    {
        Task<Abastecimento> AddAbastecimento(Abastecimento model);
        Task<Abastecimento> UpdateAbastecimento(int abastecimentoId,Abastecimento model);
        Task<bool> DeleteAbastecimento(int abastecimentoId);    
        Task<Abastecimento> GetAbastecimentoByIdAsync(int abastecimentoId);
        Task<Abastecimento[]> GetAllAbastecimentosAsync();
    }
}