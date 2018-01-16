using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.Dominio
{
    public class Prontuario
    {
        public int ProntuarioID { get; set; }
        public string NomeVeterinario { get; set; }
        public string AnimalAtendido { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Observacoes { get; set; }
    }
}
