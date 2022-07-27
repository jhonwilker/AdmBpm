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
    public class PolicialController : ControllerBase
    {
        private readonly DataContext _context;
        
        public PolicialController(DataContext context )
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Policial> Get()
        {
            return _context.Policiais; 
        }

         [HttpGet("{id}")]
        public Policial Get(int id)
        {
            return _context.Policiais.FirstOrDefault(
                policial => policial.PolicialId == id
                ); 
        }
    }
}
