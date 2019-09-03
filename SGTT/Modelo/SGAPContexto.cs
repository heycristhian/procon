using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SGAP.Modelo
{
    public class SGAPContexto: DbContext
    {        
        public SGAPContexto() : base("name=SGAP") { }

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        
        public DbSet<Consumidor> Consumidor { get; set; }
        public DbSet<Encaminhamento> Encaminhamento { get; set; }
        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Movimento> Movimento { get; set; }
        public DbSet<ProblemaPrincipal> ProblemaPrincipal { get; set; }
        public DbSet<TipoAtendimento> TipoAtendimento { get; set; }
        public DbSet<TipoReclamacao> TipoReclamacao { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Andamento> Andamento { get; set; }
        public DbSet<TipoStatus> TipoStatus { get; set; } 
        public DbSet<AlteracaoAtendimento> AlteracaoAtendimento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }        
    }
}
