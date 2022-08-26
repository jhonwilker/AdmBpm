using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Application.Constracts;
using ProAdm.Domain;
using ProAdm.Persistence.Contracts;

namespace ProAdm.Application
{
    public class AbastecimentoService : IAbastecimentoService
       
        
    {
        private readonly IGeneralPersist _generalPersist;
        private readonly IAbastecimentoPersist _abastecimentoPersist;
        public AbastecimentoService(IGeneralPersist generalPersist, IAbastecimentoPersist abastecimentoPersist)
        {
            _abastecimentoPersist = abastecimentoPersist;
            _generalPersist = generalPersist;
            
        }
        public async Task<Abastecimento> AddAbastecimento(Abastecimento model)
        {
            try
            {
               _generalPersist.Insert<Abastecimento>(model);
               if (await _generalPersist.SaveChangeAsync())
               {
                return await _abastecimentoPersist.GetAbastecimentoByIdAsync(model.Id);
               }
               return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public  async Task<Abastecimento> UpdateAbastecimento(int abastecimentoId, Abastecimento model)
        {
            try
            {
                var abastecimento = await _abastecimentoPersist.GetAbastecimentoByIdAsync(abastecimentoId);
                if (abastecimento == null) return null;

                model.Id = abastecimento.Id;

                _generalPersist.Update(model);
                if (await _generalPersist.SaveChangeAsync())
                {
                    return await _abastecimentoPersist.GetAbastecimentoByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteAbastecimento(int abastecimentoId)
        {
            try
            {
                var abastecimento = await _abastecimentoPersist.GetAbastecimentoByIdAsync(abastecimentoId);

                if (abastecimento == null) throw new Exception("Abastecimento não encontrado!");

                
                _generalPersist.Delete(abastecimento);

                return await _generalPersist.SaveChangeAsync();
    
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public  async Task<Abastecimento> GetAbastecimentoByIdAsync(int abastecimentoId)
        {
            try
            {
              var abastecimento = await _abastecimentoPersist.GetAbastecimentoByIdAsync(abastecimentoId);

              if (abastecimento == null) return null;

              return abastecimento; 
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Abastecimento[]> GetAllAbastecimentosAsync()
        {
            try
            {
              var abastecimentos = await _abastecimentoPersist.GetAllAbastecimentosAsync();

              if (abastecimentos == null) return null;

              return abastecimentos;  
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

    }
}