﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace SGAP.Modelo
{
    [Table("Atendimento")]

    public class Atendimento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string numeroProcon { get; set; }

        public string reclamacao { get; set; }

        public DateTime dataInicio { get; set; }
        
        public Nullable<DateTime> dataEncerramento { get; set; }

        public string usuario { get; set; }

        //CHAVES ESTRANGEIRAS
        public int consumidorID { get; set; }
        virtual public Consumidor Consumidor { get; set; }

        public int fornecedorID { get; set; }
        virtual public Fornecedor Fornecedor { get; set; }

        public int tipoAtendimentoID { get; set; }
        virtual public TipoAtendimento TipoAtendimento { get; set; }

        public int tipoReclamacaoID { get; set; }
        virtual public TipoReclamacao TipoReclamacao { get; set; }

        public int problemaPrincipalID { get; set; }
        virtual public ProblemaPrincipal ProblemaPrincipal { get; set; }

        public int tipoStatus { get; set; }
        virtual public TipoStatus TipoStatus { get; set; }

    }
}
