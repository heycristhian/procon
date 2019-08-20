using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAP.Modelo
{
    [Table("Movimento")]

    public class Movimento
    {
        public Movimento()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int atendimentoID { get; set; }
        virtual public Atendimento Atendimento { get; set; }

        public int tipoAtendimentoID { get; set; }
        virtual public TipoAtendimento TipoAtendimento { get; set; }

        public DateTime data { get; set; }

        [StringLength(100)]
        public string historico { get; set; }

        [StringLength(100)]
        public string resultado { get; set; }
    }
}
