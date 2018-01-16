using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.Dominio
{
    public class MedicoVeterinario
    {
        public int MedicoVetID { get; set; }
        public string Nome { get; set; }
        public string NumeroConselho { get; set; }
        public Especialidade TipoEspecialidade { get; set; }
    }
}
