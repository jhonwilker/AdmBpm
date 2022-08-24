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
    public class ServidorController : ControllerBase
    {
        private readonly ProAdmContext _context;
        
        public ServidorController(ProAdmContext context )
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Servidor> Get()
        {
            return _context.Servidores; 
        }

         [HttpGet("{id}")]
        public Servidor Get(int id)
        {
            return _context.Servidores.FirstOrDefault(
                servidor => servidor.Id == id
                ); 
        }
    }
}
