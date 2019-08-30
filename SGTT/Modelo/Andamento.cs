using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAP.Modelo
{
    [Table("Andamento")]
    public class Andamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string descricao { get; set; }

        //CHAVES ESTRANGEIRAS
        public int atendimentoID { get; set; }
        virtual public Atendimento Atendimento { get; set; }
    }
}
