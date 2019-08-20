using System;
using System.Collections.Generic;
using SGCRP.Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace SGCRP.Funcoes
{
    public class CalcPremioBoiada
    {
        public static PremioBoiada procuraPremio(object id)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Etapa etapa = contexto.Etapa.Find(id);
            try
            {
                PremioBoiada premioBoiada = etapa.premioBoiada.FirstOrDefault(p => p.etapaID == etapa.id);
                return premioBoiada;
            }
            catch
            {
                return null;
            }
        }

        public static string calcularPremio(PremioBoiada premioBoiada)
        {
            try
            {
                float total = (premioBoiada.qtdeBoiada * premioBoiada.valBoiada) + (premioBoiada.qtdDiarias * 
                    premioBoiada.diaria) + premioBoiada.melhorBoi + premioBoiada.melhorBoiada;
                return Convert.ToString(total);
            }
            catch
            {
                return null;
            }
        }
    }
}
