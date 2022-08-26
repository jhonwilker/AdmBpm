using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAdm.Application.Constracts;
using ProAdm.Domain;
using ProAdm.Persistence.Contexts;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServidorController : ControllerBase
    {
       
        public readonly IServidorService _servidorService;


        public ServidorController(IServidorService servidorService)
        {
            _servidorService = servidorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           try
           {
                var servidores = await _servidorService.GetAllServidoresAsync();
                if (servidores == null) return NotFound("Nehum servidor encontrado!"); 
                return Ok(servidores);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                        $"Erro ao tentar recuperar servidores. Erro:{ex.Message}");

           }
        }

         [HttpGet("{id}")]
         public async Task<IActionResult> GetById(int id)
        {
               
            try
           {
                var servidor = await _servidorService.GetServidorByIdAsync(id);
                if (servidor == null) return NotFound("Nehum servidor encontrado!"); 
                return Ok(servidor);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar recuperar servidor . Erro:{ex.Message}");

           } 
        }

        [HttpPost]
        public async Task<IActionResult> Post(Servidor model){
            try
           {
                var servidor = await _servidorService.AddServidor(model);
                if (servidor == null) return BadRequest("Erro ao tentar adicionar o servidor!"); 
                return Ok(servidor);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar adicionar servidor. Erro:{ex.Message}");

           }  
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Servidor model){
            try
           {
                var servidor = await _servidorService.UpdateServidor(id,model);
                if (servidor == null) return BadRequest("Erro ao tentar adicionar o servidor!"); 
                return Ok(servidor);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar atualizar servidor. Erro:{ex.Message}");

           }  
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            try
           {
                if(await _servidorService.DeleteServidor(id))
                {
                    return Ok("Deletado");
                }
                else
                {
                    return BadRequest("Servidor não deletado");
                }
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar deletar servidor. Erro:{ex.Message}");

           }  
        }


    }
}
