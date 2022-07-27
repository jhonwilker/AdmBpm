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
    public class ViaturaController : ControllerBase
    {
        public readonly DataContext _context;
        
        public ViaturaController(DataContext context)
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
                viatura => viatura.ViaturaId == id
                ); 
        }
    }
}
