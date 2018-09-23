using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    public class OsDTO
    {
        public int Id_OS { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Data_Entrada { get; set; }
        public DateTime? Data_Saida { get; set; }
        public string Status { get; set; }
        public string Situacao { get; set; }
        public int? PranchaId_Prancha { get; set; }
        public int? ClienteId_Cliente { get; set; }





    }
}
