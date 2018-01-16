using Estudo.ProjetoMedicinaVet.Comum.Entity;
using Estudo.ProjetoMedicinaVet.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.AcessoDados.Entity.TypeConfiguration
{
    public class ProntuarioTypeConfiguration : MedicinaVetEntityAbstractConfig<Prontuario>
    { 
        protected override void ConfiguraNomeTabela()
        {
            ToTable("PRO_PRONTUARIO");
        }

        protected override void ConfiguraNomeCampo()
        {
            Property(p => p.ProntuarioID).IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("PRO_ID");

            Property(p => p.NomeVeterinario).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PRO_VETERINARIO");

            Property(p => p.AnimalAtendido).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("PRO_ANIMAL");

            Property(p => p.AnimalAtendido).IsRequired()
                .HasColumnName("PRO_DATAS");

            Property(p => p.Observacoes).IsRequired()
                .HasMaxLength(500)
                .HasColumnName("PRO_OBSERVACOES");
        }

        protected override void ConfiguraChavePrimaria()
        {
            HasKey(pk => pk.ProntuarioID);
        }

        protected override void ConfiguraChaveEstrangeira()
        {

        }
    }
}
