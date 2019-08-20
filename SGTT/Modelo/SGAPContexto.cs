using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace SGAP.Modelo
{
    public class SGAPContexto: DbContext
    {
        internal object obj;

        public SGAPContexto() : base("SGAP") { }

        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Consumidor> Consumidor { get; set; }
        public DbSet<Encaminhamento> Encaminhamento { get; set; }
        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Movimento> Movimento { get; set; }
        public DbSet<ProblemaPrincipal> ProblemaPrincipal { get; set; }
        public DbSet<TipoAtendimento> TipoAtendimento { get; set; }
        public DbSet<TipoReclamacao> TipoReclamacao { get; set; }
    }
}
