using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAP.Modelo
{
    [Table("Encaminhamento")]
    
    public class Encaminhamento
    {
        public Encaminhamento()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int movimentoID { get; set; }
        virtual public Movimento Movimento { get; set; }

        public int entidadeID { get; set; }
        virtual public Entidade Entidade { get; set; }

        [StringLength(30)]
        public string obs { get; set; }
    }
}
