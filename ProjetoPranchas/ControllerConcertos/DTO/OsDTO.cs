using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    public class OsDTO
    {
        //Classe criada pois o visual studio não estava deixando fazer as consultas usando as variáveis de OS
        public int Id_OS { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? Data_Entrada { get; set; }
        public DateTime? Data_Saida { get; set; }
        public string Status { get; set; }
        public string Situacao { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }





    }
}
