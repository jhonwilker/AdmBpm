using System;

namespace ProAdm.API.Models
{
    public class Viatura
    {
        public int ViaturaId { get; set; }

        public string Prefixo { get; set; }

        public string Placa { get; set; }

        public int Odometro { get; set; }

        public string TipoCombustivel { get; set; }
        
    }
}
