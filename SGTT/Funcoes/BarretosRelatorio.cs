using System;
using System.Collections.Generic;
using System.Linq;
using SGCRP.Funcoes;
using SGCRP.Modelo;
using System.Text;
using System.Threading.Tasks;

namespace SGCRP.Funcoes
{
    public class BarretosRelatorio
    {

        public static void melhoresMontariaNoiteV2(int roundID, int qtd)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            var culture = new System.Globalization.CultureInfo("pt-BR");
            Round round = contexto.Round.Find(roundID);
            Funcoes.finalizarRound.reodernarCompCampeonato(round.etapa.campeonatoID);
            round = contexto.Round.Find(roundID);
            List<CopaCompetidor> lstCopaCompetidor = new List<CopaCompetidor>();
            if (round.etapa.copaEtapa.Count() > 0)
            {
                Modelo.Copa copa = contexto.Copa.Find(round.etapa.copaEtapa.First().copaID);
                lstCopaCompetidor = copa.getCompetidores(true);
            }
            string folder = Relatorios.diretorioPasta(round.etapa.campeonato.nome, round.etapa);
            string arq = folder + @"\CRP" + round.etapa.campeonato.modalidade.abreviacao.ToUpper() + "_MELHORES_MONT_R" + round.numRound + "_" + culture.DateTimeFormat.GetDayName(round.data.DayOfWeek).Substring(0, 3).ToUpper() + "_" + round.etapa.cidade.nome.ToUpper() + "_" + round.data.Year + ".html";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(arq))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(" <link rel=\"stylesheet\" type=\"text/css\" href=\"../../css/estilo.css\" />");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<div class=\"divCabecalho\">");
                sw.WriteLine("<th>");
                sw.WriteLine("<img src=\"../../Logos/logo1.png\" class=\"imgCabecalho\"/>");
                sw.WriteLine("<img src=\"../../Logos/logo2.png\" class=\"imgCabecalho\"/>");
                sw.WriteLine("			<h3 style=\"margin: 10px; text-align: left;\"> " + round.etapa.cidade.nome + " - " + round.etapa.cidade.uf + " </h3>");
                sw.WriteLine("			<h3 style=\"margin: 10px; text-align: left;\">" + round.etapa.nome + "</h3>");
                sw.WriteLine("          <h3 style=\"margin: 10px; text-align: left;\">" + round.etapa.campeonato.nome + "</h3>");
                sw.WriteLine("			<h3 style=\"margin: 10px; text-align: left;\">" + round.etapa.numEtapa + "° ETAPA" + "</h3>");
                sw.WriteLine("</div>");
                sw.WriteLine("<br>");
                CampeonatoEtapaExterno campeonatoEtapaExterno = contexto.CampeonatoEtapaExternos.FirstOrDefault(c => c.etapaID == round.etapaID);

                List<Montaria> lstMontaria = round.montaria.Where(t => t.touroID != null && t.pulo && t.notas.Count > 0).OrderByDescending(m => m.notaTempoMontaria).ToList();
                for (int i = 0; i < qtd; i++)
                {
                    CampeonatoCompetidor campeonatoCompetidor;
                    if (campeonatoEtapaExterno != null)
                    {
                        campeonatoCompetidor = campeonatoEtapaExterno.campeonato.campeonatoCompetidor.FirstOrDefault(c => c.competidorID == lstMontaria[i].etapaCompetidor.competidorID);
                    }
                    else
                    {
                        campeonatoCompetidor = null;
                    }
                    float[] calculo = CalculoSaidaParadaTouro.calculoSaidaParada(Convert.ToInt32(lstMontaria[i].touroID));
                    sw.WriteLine("<center>");
                    sw.WriteLine("<table class=\"tbMelhoresMont\">");
                    sw.WriteLine("<tr> <th scope=\"col\">" + (i + 1) + "°</th> <th scope=\"col\" class=\"colComp\"> COMPETIDOR </th> <th scope=\"col\" class=\"colAnimal\"> ANIMAL </th> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> NOME </th> <td> " + lstMontaria[i].etapaCompetidor.competidor.apelido + "</td> <td> " + lstMontaria[i].touro.nome + " (" + lstMontaria[i].touro.tropeiro.sigla + ") </td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> IDADE </th> <td> " + Idade.calcIdade(lstMontaria[i].etapaCompetidor.competidor.nascimento) + "</td> <td>" + lstMontaria[i].touro.idade + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> CIDADE </th> <td> " + lstMontaria[i].cidadeCompetidor + "</td> <td> " + lstMontaria[i].touro.tropeiro.cidade.nome + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> RANKING </th> <td> " + (campeonatoCompetidor == null ? lstMontaria[i].etapaCompetidor.campeonatoCompetidor.rank : campeonatoCompetidor.rank) + "</td> <td> - </td> </tr>");
                    if (lstCopaCompetidor.Count > 0)
                    {
                        int posCopa = 0;
                        if (campeonatoCompetidor == null)
                            posCopa = lstCopaCompetidor.FindIndex(c => c.campeonatoCompetidorID == lstMontaria[i].etapaCompetidor.campeonatoCompetidorID) + 1;
                        else
                            posCopa = lstCopaCompetidor.FindIndex(c => c.campeonatoCompetidor.competidorID == campeonatoCompetidor.competidorID) + 1;
                        sw.WriteLine("<tr> <th scope=\"linha\"> RANKING COPA </th> <td> " + posCopa + "</td> <td> - </td> </tr>");
                    }
                    sw.WriteLine("<tr> <th scope=\"linha\"> TITULOS </th> <td scope=\"valor\"> " + (campeonatoCompetidor == null ? lstMontaria[i].etapaCompetidor.competidor.qtdTitulos : campeonatoCompetidor.competidor.qtdTitulos) + "</td> <td scope=\"valor\"> - </td> </tr>");
                    int qtdSaida = (campeonatoCompetidor == null ? lstMontaria[i].etapaCompetidor.campeonatoCompetidor.saidas : campeonatoCompetidor.saidas);
                    int qtdParada = (campeonatoCompetidor == null ? lstMontaria[i].etapaCompetidor.campeonatoCompetidor.paradas : campeonatoCompetidor.paradas);
                    sw.WriteLine("<tr> <th scope=\"linha\"> QUANTIDADE SAIDA </th> <td scope=\"valor\">" + qtdSaida + "</td> <td scope=\"valor\">" + calculo[0] + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> QUANTIDADE PARADA </th> <td scope=\"valor\">" + qtdParada + "<td scope=\"valor\"> " + calculo[1] + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> % DE PARADAS </th> <td scope=\"valor\">" + ((float)lstMontaria[i].etapaCompetidor.campeonatoCompetidor.paradas / (float)lstMontaria[i].etapaCompetidor.campeonatoCompetidor.saidas * 100).ToString("0.00") + "</td> <td scope=\"valor\"> " + ((float)calculo[1] / (float)calculo[0] * 100).ToString("0.00") + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> MÉDIA TEMPO </th>  <td scope=\"valor\"> - </td> <td scope=\"valor\">" + (calculo[2] / (calculo[0] - calculo[1])).ToString("0.00") + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> NOTA </th> <td scope=\"valor\"> " + (lstMontaria[i].notas.Count(n => n.notaCompetidor < 8) == 0 ? lstMontaria[i].notas.Sum(n => n.notaCompetidor) : (lstMontaria[i].notas.Sum(n => n.notaCompetidor) / lstMontaria[i].notas.Count)).ToString("0.00") + "</td> <td scope=\"valor\"> " + lstMontaria[i].notas.Sum(n => n.notaTouro).ToString("0.00") + "</td> </tr>");
                    sw.WriteLine("<tr> <th scope=\"linha\"> TOTAL </th> <td colspan=\"2\" scope=\"total\">" + lstMontaria[i].notaMontaria.ToString("0.00") + "</td> </tr>");
                    sw.WriteLine("</table>");
                    sw.WriteLine("</center>");
                    sw.WriteLine("<br>");
                }
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arq);
        }
    }
}
