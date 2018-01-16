using Estudo.ProjetoMedicinaVet.AcessoDados.Entity.TypeConfiguration;
using Estudo.ProjetoMedicinaVet.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.ProjetoMedicinaVet.AcessoDados.Entity.Context
{
    public class MedicinaVetContext : DbContext
    {
        public MedicinaVetContext()
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<MedicoVeterinario> Veterinarios { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnimalTypeConfiguration());
            modelBuilder.Configurations.Add(new MedicoVeterinarioTypeConfiguration());
            modelBuilder.Configurations.Add(new ProntuarioTypeConfiguration());
        }
    }
}
