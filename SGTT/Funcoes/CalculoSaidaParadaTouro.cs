using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCRP.Modelo;

namespace SGCRP.Funcoes
{
    public class CalculoSaidaParadaTouro
    {
        public static float[] calculoSaidaParada(int touroID)
        {
            float[] calculo = { 0, 0, 0 };
            SGCRPContexto contexto = new Modelo.SGCRPContexto();
            var dados = from m in contexto.Montaria.Where(t => t.touroID == touroID && t.notas.Count > 0 && t.mediaBoiada && t.pulo)
                        select new
                        {
                            nota = m.notas
                        };
            foreach (var montaria in dados)
            {
                calculo[0]++;
                if (montaria.nota.FirstOrDefault(n => n.notaCompetidor > 8) != null)
                {
                    calculo[1]++;
                }
                else
                {
                    calculo[2] += montaria.nota.Sum(t => t.notaCompetidor) / montaria.nota.Count;
                }
            }
            return calculo;
        }
    }
}
