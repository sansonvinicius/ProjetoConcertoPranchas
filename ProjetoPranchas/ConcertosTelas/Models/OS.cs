using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas.Models
{
    class OS
    {
        public int OSID { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public string Status { get; set; }
        public string Situacao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }
}
