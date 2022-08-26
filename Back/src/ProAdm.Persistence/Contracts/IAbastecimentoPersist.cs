using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Domain;

namespace ProAdm.Persistence.Contracts
{
    public interface IAbastecimentoPersist
    {

        //Task<Abastecimento[]> GetAllAbastecimentosAsync(string )
        Task<Abastecimento> GetAbastecimentoByIdAsync(int abastecimentoId);
        Task<Abastecimento[]> GetAllAbastecimentosAsync();

    }
}