using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAP.Modelo
{
    [Table("TipoAtendimento")]

    public class TipoAtendimento
    {
        public TipoAtendimento()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string descricao { get; set; }
    }
}
