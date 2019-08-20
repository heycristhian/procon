using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAP.Modelo
{
    [Table("Consumidor")]
    public class Consumidor
    {
        public Consumidor()
        {
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

        [Required]
        [StringLength(40)]
        public string nome { get; set; }

        [StringLength(40)]
        public string endereco { get; set; }

        [StringLength(30)]
        public string bairro { get; set; }

        public int cidadeID { get; set; }
        virtual public Cidade Cidade { get; set; }

        [StringLength(9)]
        public string cep { get; set; }

        [StringLength(14)]
        public string fone { get; set; }

        [StringLength(14)]
        public string foneComercial { get; set; }

        [StringLength(14)]
        public string celular { get; set; }

        [StringLength(14)]
        public string whatsApp { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(14)]
        public string rg { get; set; }

        [StringLength(14)]
        public string cpf { get; set; }

        virtual public string descConsumidor { get { return nome + " - " + cpf.ToString(); } }

    }
}
