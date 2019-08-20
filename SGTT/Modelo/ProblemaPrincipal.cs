using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAP.Modelo
{
    [Table("ProblemaPrincipal")]

    public class ProblemaPrincipal
    {
        public ProblemaPrincipal()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(35)]
        [Required]
        public string descricao { get; set; }

        public int tipoReclamacaoID { get; set; }
        virtual public TipoReclamacao TipoReclamacao { get; set; }

       
    }
}
