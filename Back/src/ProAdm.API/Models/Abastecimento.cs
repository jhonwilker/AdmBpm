using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdm.API.Models
{
    public class Abastecimento
    {
        public int AbastecimentoId { get; set; } 
        public Viatura Viatura { get; set; }
        public int KmAbastecimento { get; set; }
        public float LitrosAbastecimento { get; set; }
        public float ValorAbastecimento { get; set; }
        public DateTime DataAbastecimento { get; set; }
        public Policial Responsavel { get; set; }
        public string Convenio { get; set; }
        public float Saldo { get; set; }



    }
}