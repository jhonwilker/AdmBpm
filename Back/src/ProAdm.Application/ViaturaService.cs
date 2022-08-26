using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Application.Constracts;
using ProAdm.Domain;
using ProAdm.Persistence.Contracts;

namespace ProAdm.Application
{
    public class ViaturaService : IViaturaService
       
        
    {
        private readonly IGeneralPersist _generalPersist;
        private readonly IViaturaPersist _viaturaPersist;
        public ViaturaService(IGeneralPersist generalPersist, IViaturaPersist viaturaPersist)
        {
            _viaturaPersist = viaturaPersist;
            _generalPersist = generalPersist;
            
        }
        public async Task<Viatura> AddViatura(Viatura model)
        {
            try
            {
               _generalPersist.Insert<Viatura>(model);
               if (await _generalPersist.SaveChangeAsync())
               {
                return await _viaturaPersist.GetViaturaByIdAsync(model.Id);
               }
               return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public  async Task<Viatura> UpdateViatura(int viaturaId, Viatura model)
        {
            try
            {
                var viatura = await _viaturaPersist.GetViaturaByIdAsync(viaturaId);
                if (viatura == null) return null;

                model.Id = viatura.Id;

                _generalPersist.Update(model);
                if (await _generalPersist.SaveChangeAsync())
                {
                    return await _viaturaPersist.GetViaturaByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteViatura(int viaturaId)
        {
            try
            {
                var viatura = await _viaturaPersist.GetViaturaByIdAsync(viaturaId);

                if (viatura == null) throw new Exception("Viatura não encontrado!");

                
                _generalPersist.Delete(viatura);

                return await _generalPersist.SaveChangeAsync();
    
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public  async Task<Viatura> GetViaturaByIdAsync(int viaturaIdId)
        {
            try
            {
              var viatura = await _viaturaPersist.GetViaturaByIdAsync(viaturaIdId);

              if (viatura == null) return null;

              return viatura; 
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Viatura[]> GetAllViaturasAsync()
        {
            try
            {
              var viaturas = await _viaturaPersist.GetAllViaturasAsync();

              if (viaturas == null) return null;

              return viaturas;  
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

       
    }
}