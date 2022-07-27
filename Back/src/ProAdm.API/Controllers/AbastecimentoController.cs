using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAdm.API.Data;
using ProAdm.API.Models;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbastecimentoController : ControllerBase
    {
       
        public readonly DataContext _context;

        public AbastecimentoController(DataContext context)
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
                abastecimento => abastecimento.AbastecimentoId == id
            ); 
        }
    }
}
