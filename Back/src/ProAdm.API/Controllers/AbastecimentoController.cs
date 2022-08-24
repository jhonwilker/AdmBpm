using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAdm.Persistence;
using ProAdm.Domain;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbastecimentoController : ControllerBase
    {
       
        public readonly ProAdmContext _context;


        public AbastecimentoController(ProAdmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Abastecimento> Get()
        {
            return _context.Abastecimentos; 
        }

         [HttpGet("{id}")]
        public Abastecimento GetById(int id)
        {
               
            return _context.Abastecimentos.FirstOrDefault(
                abastecimento => abastecimento.Id == id
            ); 
        }
    }
}
