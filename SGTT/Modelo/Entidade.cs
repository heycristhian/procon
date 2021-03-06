﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAP.Modelo
{
    [Table("Entidade")]

    public class Entidade
    {
        public Entidade()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        [Required]
        public string nome { get; set; }

        [StringLength(40)]
        public string endereco { get; set; }

        public int cidadeID { get; set; }
        virtual public Cidade Cidade { get; set; }

        [StringLength(9)]
        public string cep { get; set; }

        [StringLength(14)]
        public string fone { get; set; }

        [StringLength(14)]
        public string celular { get; set; }

        [StringLength(14)]
        public string whatsApp { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(30)]
        public string site { get; set; }

        [StringLength(20)]
        public string contato { get; set; }
    }
}
