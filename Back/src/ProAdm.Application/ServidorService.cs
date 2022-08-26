using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAdm.Application.Constracts;
using ProAdm.Domain;
using ProAdm.Persistence.Contracts;

namespace ProAdm.Application
{
    public class ServidorService:IServidorService
     {
        private readonly IGeneralPersist _generalPersist;
        private readonly IServidorPersist _servidorPersist;
        public ServidorService(IGeneralPersist generalPersist, IServidorPersist servidorPersist)
        {
            _servidorPersist = servidorPersist;
            _generalPersist = generalPersist;
            
        }
        public async Task<Servidor> AddServidor(Servidor model)
        {
            try
            {
               _generalPersist.Insert<Servidor>(model);
               if (await _generalPersist.SaveChangeAsync())
               {
                return await _servidorPersist.GetServidorByIdAsync(model.Id);
               }
               return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public  async Task<Servidor> UpdateServidor(int servidorId, Servidor model)
        {
            try
            {
                var servidor = await _servidorPersist.GetServidorByIdAsync(servidorId);
                if (servidor == null) return null;

                model.Id = servidor.Id;

                _generalPersist.Update(model);
                if (await _generalPersist.SaveChangeAsync())
                {
                    return await _servidorPersist.GetServidorByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteServidor(int servidorId)
        {
            try
            {
                var servidor = await _servidorPersist.GetServidorByIdAsync(servidorId);

                if (servidor == null) throw new Exception("Servidor não encontrado!");

                
                _generalPersist.Delete(servidor);

                return await _generalPersist.SaveChangeAsync();
    
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public  async Task<Servidor> GetServidorByIdAsync(int servidorId)
        {
            try
            {
              var servidor = await _servidorPersist.GetServidorByIdAsync(servidorId);

              if (servidor == null) return null;

              return servidor; 
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Servidor[]> GetAllServidoresAsync()
        {
            try
            {
              var servidores = await _servidorPersist.GetAllServidoresAsync();

              if (servidores == null) return null;

              return servidores;  
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

    }
}