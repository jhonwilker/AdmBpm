using System;

namespace ProAdm.Domain
{
    public class Viatura
    {
        public int Id { get; set; }

        public string Prefixo { get; set; }

        public string Placa { get; set; }

        public int Odometro { get; set; }

        public string TipoCombustivel { get; set; }
        
    }
}
