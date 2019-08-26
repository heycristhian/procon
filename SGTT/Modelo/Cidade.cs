using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGAP.Modelo
{
    [Table("Cidade")]
    public class Cidade
    {
        public Cidade()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string descricao { get; set; }

        [Required]
        [StringLength(2)]
        public string uf { get; set; }

        //public virtual string ufNoRepeat { get { return ; } }

        public virtual string getEstado()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ac", "Acre");
            dic.Add("al", "Alagoas");
            dic.Add("ap", "Amapá");
            dic.Add("am", "Amazonas");
            dic.Add("ba", "Bahia");
            dic.Add("ce", "Ceará");
            dic.Add("df", "Distrito Federal");
            dic.Add("es", "Espírito Santo");
            dic.Add("go", "Goiás");
            dic.Add("ma", "Maranhão");
            dic.Add("mt", "Mato Grosso");
            dic.Add("ms", "Mato Grosso do Sul");
            dic.Add("mg", "Minas Gerais");
            dic.Add("pa", "Pará");
            dic.Add("pb", "Paraíba");
            dic.Add("pr", "Paraná");
            dic.Add("pe", "Pernambuco");
            dic.Add("pi", "Piauí");
            dic.Add("rj", "Rio de Janeiro");
            dic.Add("rn", "Rio Grande do Norte");
            dic.Add("rs", "Rio Grande do Sul");
            dic.Add("ro", "Rondônia");
            dic.Add("rr", "Roraima");
            dic.Add("sc", "Santa Catarina");
            dic.Add("sp", "São Paulo");
            dic.Add("se", "Sergipe");
            dic.Add("to", "Tocantins");
            return dic[this.uf.ToLower()];
        }

        virtual public string descEstado { get { return descricao + " - " + uf.ToString(); } }
        
        public virtual string getCidadeID
        {
            get
            {
                return this.id + " - " + this.descricao;
            }
        }
    }
}
