using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAdm.API.Models
{
    public class Abastecimento
    {
        public int Viatura { get; set; }
        public int KmViatura { get; set; }
        public int Litros { get; set; }
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public int Responsavel { get; set; }
        public string Convenio { get; set; }
        public int Saldo { get; set; }



    }
}