using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAdm.API.Models;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbastecimentoController : ControllerBase
    {
        public IEnumerable<Abastecimento> _abastecimento = new Abastecimento[] {

        
        };

        public AbastecimentoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Abastecimento> Get()
        {
            return _abastecimento; 
        }

         [HttpGet("{id}")]
        public IEnumerable<Abastecimento> Get(int id)
        {
            return _abastecimento.Where(abastecimento => abastecimento.AbastecimentoId == id); 
        }
    }
}
