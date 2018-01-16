using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.Comum.Entity
{
    public abstract class MedicinaVetEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade> where TEntidade : class 
    {
        public MedicinaVetEntityAbstractConfig()
        {
            ConfiguraNomeTabela();
            ConfiguraNomeCampo();
            ConfiguraChavePrimaria();
            ConfiguraChaveEstrangeira();
        }

        protected abstract void ConfiguraNomeTabela();
        protected abstract void ConfiguraNomeCampo();
        protected abstract void ConfiguraChavePrimaria();
        protected abstract void ConfiguraChaveEstrangeira();
    }
}
