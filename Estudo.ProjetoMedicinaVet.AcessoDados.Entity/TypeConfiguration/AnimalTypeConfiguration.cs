using Estudo.ProjetoMedicinaVet.Comum.Entity;
using Estudo.ProjetoMedicinaVet.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.AcessoDados.Entity.TypeConfiguration
{
    public class AnimalTypeConfiguration : MedicinaVetEntityAbstractConfig<Animal>
    {
        protected override void ConfiguraNomeTabela()
        {
            ToTable("ANL_ANIMAIS");
        }

        protected override void ConfiguraNomeCampo()
        {
            Property(p => p.AnimalID).IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ANL_ID");

            Property(p => p.NomeAnimal).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("ANL_NOME");

            Property(p => p.Idade).IsOptional()
                .HasColumnName("ANL_IDADE");

            Property(p => p.Raca).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("ANL_RACA");

            Property(p => p.NomeDono).IsRequired()
                .HasMaxLength(80)
                .HasColumnName("ANL_NOMEDONO");
        }

        protected override void ConfiguraChavePrimaria()
        {
            HasKey(pk => pk.AnimalID);
        }

        protected override void ConfiguraChaveEstrangeira()
        {

        }
    }
}
