using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdm.Domain
{
    public class Abastecimento
    {
        public int Id { get; set; } 
        public Viatura Viatura { get; set; }
        public int KmAbastecimento { get; set; }
        public float LitrosAbastecimento { get; set; }
        public float ValorAbastecimento { get; set; }
        public DateTime DataAbastecimento { get; set; }
        public Servidor Responsavel { get; set; }
        public string Convenio { get; set; }
        public float Saldo { get; set; }

    }
}