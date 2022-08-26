using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProAdm.Domain;
using ProAdm.Persistence.Contexts;

namespace ProAdm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViaturaController : ControllerBase
    {
        public readonly ProAdmContext _context;
        
        public ViaturaController(ProAdmContext context)
        {
            _context = context;
           
        }

        [HttpGet]
        public IEnumerable<Viatura> Get()
        {
            return _context.Viaturas; 
        }

         [HttpGet("{id}")]
        public Viatura GetById(int id)
        {
            return _context.Viaturas.FirstOrDefault(
                viatura => viatura.Id == id
                ); 
        }
    }
}
