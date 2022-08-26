using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAdm.Persistence;
using ProAdm.Domain;
using ProAdm.Persistence.Contexts;
using ProAdm.Application.Constracts;
using Microsoft.AspNetCore.Http;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbastecimentoController : ControllerBase
    {
       
        public readonly IAbastecimentoService _abastecimentoService;


        public AbastecimentoController(IAbastecimentoService abastecimentoService)
        {
            _abastecimentoService = abastecimentoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           try
           {
                var abastecimentos = await _abastecimentoService.GetAllAbastecimentosAsync();
                if (abastecimentos == null) return NotFound("Nehum abastecimento encontrado!"); 
                return Ok(abastecimentos);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                        $"Erro ao tentar recuperar abastecimentos. Erro:{ex.Message}");

           }
        }

         [HttpGet("{id}")]
         public async Task<IActionResult> GetById(int id)
        {
               
            try
           {
                var abastecimento = await _abastecimentoService.GetAbastecimentoByIdAsync(id);
                if (abastecimento == null) return NotFound("Nehum abastecimento encontrado!"); 
                return Ok(abastecimento);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar recuperar abastecimento . Erro:{ex.Message}");

           } 
        }

        [HttpPost]
        public async Task<IActionResult> Post(Abastecimento model){
            try
           {
                var abastecimento = await _abastecimentoService.AddAbastecimento(model);
                if (abastecimento == null) return BadRequest("Erro ao tentar adicionar o abastecimento!"); 
                return Ok(abastecimento);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar adicionar abastecimento . Erro:{ex.Message}");

           }  
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Abastecimento model){
            try
           {
                var abastecimento = await _abastecimentoService.UpdateAbastecimento(id,model);
                if (abastecimento == null) return BadRequest("Erro ao tentar adicionar o abastecimento!"); 
                return Ok(abastecimento);
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar atualizar abastecimento . Erro:{ex.Message}");

           }  
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            try
           {
                if(await _abastecimentoService.DeleteAbastecimento(id))
                {
                    return Ok("Deletado");
                }
                else
                {
                    return BadRequest("Abastecimento não deletado");
                }
           }
           catch (Exception ex)
           {
            
             return this.StatusCode(StatusCodes.Status500InternalServerError, 
                       $"Erro ao tentar deletar abastecimento . Erro:{ex.Message}");

           }  
        }


    }
}
