using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAP.Modelo
{
    [Table("AlteracaoAtendimento")]
    public class AlteracaoAtendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string numeroAtendimento { get; set; }

        public string tipoAtendimento { get; set; }

        public string consumidor { get; set; }

        public string fornecedor { get; set; }

        public string descricao { get; set; }

        public DateTime dataAlteracao { get; set; }

        public string usuario { get; set; }

        //CHAVES ESTRANGEIRAS
        public int atendimentoID { get; set; }
        virtual public Atendimento Atendimento { get; set; }
    }
}
