using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.Dominio
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string NomeAnimal { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public string NomeDono { get; set; }
    }
}
