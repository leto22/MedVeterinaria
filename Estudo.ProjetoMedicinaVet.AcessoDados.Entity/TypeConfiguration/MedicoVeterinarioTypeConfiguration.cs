using Estudo.ProjetoMedicinaVet.Comum.Entity;
using Estudo.ProjetoMedicinaVet.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.AcessoDados.Entity.TypeConfiguration
{
    public class MedicoVeterinarioTypeConfiguration : MedicinaVetEntityAbstractConfig<MedicoVeterinario>
    {
        protected override void ConfiguraNomeTabela()
        {
            ToTable("MED_VETERINARIOS");
        }

        protected override void ConfiguraNomeCampo()
        {
            Property(p => p.MedicoVetID).IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("MED_ID");

            Property(p => p.Nome).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("MED_NOME");

            Property(p => p.TipoEspecialidade).IsRequired()
                .HasColumnName("MED_ESPECIALIDADE");

            Property(p => p.NumeroConselho).IsRequired()
                .HasMaxLength(50)
                .HasColumnName("MED_NCONSELHO");
        }

        protected override void ConfiguraChavePrimaria()
        {
            HasKey(pk => pk.MedicoVetID);
        }

        protected override void ConfiguraChaveEstrangeira()
        {

        }
    }
}
