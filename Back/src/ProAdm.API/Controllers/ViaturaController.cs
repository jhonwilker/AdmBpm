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
    public class ViaturaController : ControllerBase
    {
        public IEnumerable<Viatura> _viatura = new Viatura[] {

            new Viatura()
            {
                ViaturaId = 1,
                Prefixo = "VP-19-112",
                Placa = "PTL8112"
            },
                new Viatura()
            {
                ViaturaId = 2,
                Prefixo = "VP-21-043",
                Placa = "PMT8114"
            }
        };

        public ViaturaController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Viatura> Get()
        {
            return _viatura; 
        }

         [HttpGet("{id}")]
        public IEnumerable<Viatura> Get(int id)
        {
            return _viatura.Where(viatura => viatura.ViaturaId == id); 
        }
    }
}
