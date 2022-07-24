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
    public class PolicialController : ControllerBase
    {
        public IEnumerable<Policial> _policial = new Policial[] {

            
        };

        public PolicialController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Policial> Get()
        {
            return _policial; 
        }

         [HttpGet("{id}")]
        public IEnumerable<Policial> Get(int id)
        {
            return _policial.Where(policial => policial.PolicialId == id); 
        }
    }
}
