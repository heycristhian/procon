using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCRP.Modelo;
using NReco.PhantomJS;
using System.Windows.Forms;

namespace SGCRP.Funcoes
{
    public class Banner
    {
        public static void phantonImage(string htmlBanner, string nomeImagem, int width, int height, bool telao, bool transparente = false)
        {
            var phantomJS = new PhantomJS();
            string script = "var page = require('webpage').create(); " +
                "page.open('Banner/" + htmlBanner + ".html', function() { " +
                "page.clipRect = {  top: 0, left: 0, width: " + width + ", height: " + height + "}; " +
                "page.render('" + (telao ? "C:/Relatorio/Telao/temp/" : "C:/Relatorio/Banners/") + nomeImagem + (transparente ? ".png" : ".jpg") + "'); " +
                "phantom.exit(); " +
                " });";
            phantomJS.RunScript(script, null);
            if (telao)
            {
                string arq = @"C:/Relatorio/Telao/temp/" + nomeImagem + ".html";
                using (StreamWriter html = new StreamWriter(arq))
                {
                    html.WriteLine("<html><head><style>body { background: url(\"" + nomeImagem + ".jpg\");background-color: rgba(0, 0, 0, 0);background-position-x: 0%;background-position-y: 0%;background-size: auto auto;background-color: #0a769d;height: 100%;min-height: 100%;max-height: 100%;width: 100%;background-size: 100% 100%;background-position: center;max-width: 100%;min-width: 100%;top: 0;left: 0;padding: 0;margin: 0;}</style></head><body></body></html>");
                }
                System.Diagnostics.Process.Start(arq);
            }
        }

        public static void bannerMelhorMontariaRound(int roundID, bool telao)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Round round = contexto.Round.Find(roundID);
            string nomeArq = "Banner/bannerMelhorMontRound.html";
            Montaria montaria = round.montaria.OrderByDescending(m => m.notaTempoMontaria).First();
            string dirImg = "Banner/img/frente/" + montaria.etapaCompetidor.competidorID + ".png";

            using (StreamWriter html = new StreamWriter(nomeArq))
            {
                gerarInicioHtmlBanner(html, "eMelhorMontariaNoite.css", "melhorMontariaNoite.jpg");
                ////textMelhorBannerRound(html, "img/Competidores/" + montaria.etapaCompetidor.competidorID + ".jpg", montaria);
                textMelhorBannerRound(html, dirImg.Replace(@"Banner/", ""), montaria);
                gerarFimHtmlBanner(html);
            }
            string nomeImagem = "";
            if (telao)
            {
                nomeImagem = round.etapa.nome.Replace(" ", "_") + "_MELHOR_MONTARIA_ROUND(" + round.numRound + ")";
            }
            else
            {
                nomeImagem = round.etapa.campeonato.getFolderName() + "/" + round.etapa.getEtapaFolder() + "/" + round.getFolder() + "/" + round.etapa.nome.Replace(" ", "_") + "_MELHOR_MONTARIA_ROUND(" + round.numRound + ")";
            }
            phantonImage("bannerMelhorMontRound", nomeImagem, 0, 0, telao);
        }

        public static void textMelhorBannerRound(StreamWriter html, string imgSrc, Montaria melhorMontaria)
        {
            string arq = @"../../../Relatorio/Telao/img/frente/" + melhorMontaria.etapaCompetidor.competidorID + ".png";
            html.WriteLine("<img class=\"imgCompetidor\" src=\"" + imgSrc + "\"/>");
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo\" />");
            html.WriteLine("<div class=\"divRodeio\">");
            html.WriteLine("<p class=\"nTextoRodeio\"> MODALIDADE </p>");
            html.WriteLine("</div>");
            html.WriteLine("<div class=\"divTipoRodeio\">");
            html.WriteLine("<p class=\"nTipoRodeio\">" + (melhorMontaria.round.etapa.campeonato.modalidade.abreviacao == "TOU" ? "TOURO" : "CUTIANO") + "</p>");
            html.WriteLine("</div>");
            html.WriteLine("<p class=\"nRound\"> ROUND " + melhorMontaria.round.numRound.ToString("00") + " </p>");
            html.WriteLine("<p class=\"nInfoEtapa\">" + melhorMontaria.round.etapa.numEtapa + "ª ETAPA <br> " + melhorMontaria.round.etapa.cidade.nome + " - " + melhorMontaria.round.etapa.cidade.uf + "</p>");
            html.WriteLine("<div class=\"divComp\">");
            html.WriteLine("<p class=\"nCompetidor\">" + melhorMontaria.etapaCompetidor.competidor.apelido + " </p>");
            html.WriteLine("</div>");
            html.WriteLine("<div class=\"divCidade\">");
            html.WriteLine("<p class=\"nCidade\">" + melhorMontaria.etapaCompetidor.competidor.cidade.nome + " - " + melhorMontaria.etapaCompetidor.competidor.cidade.uf + "</p>");
            html.WriteLine("</div>");
            html.WriteLine("<div class=\"divTouro\">");
            html.WriteLine("<p class=\"nTouro\">" + melhorMontaria.touro.nome + "</p>");
            html.WriteLine("</div>");
            html.WriteLine("<div class=\"divTropeiro\">");
            html.WriteLine("<p class=\"nTropeiro\">" + melhorMontaria.touro.tropeiro.nome + "</p>");
            html.WriteLine("</div>");
            html.WriteLine("<p class=\"nSaida\">" + melhorMontaria.etapaCompetidor.campeonatoCompetidor.saidas + "</p>");
            html.WriteLine("<p class=\"nParada\">" + melhorMontaria.etapaCompetidor.campeonatoCompetidor.paradas + "</p>");
            html.WriteLine("<p class=\"nRanking\">" + melhorMontaria.etapaCompetidor.campeonatoCompetidor.rank + "</p>");
            html.WriteLine("<p class=\"nPontosRank\">" + melhorMontaria.etapaCompetidor.campeonatoCompetidor.pontos.ToString("0.00") + "</p>");
            html.WriteLine("<p class=\"ntitulos\">" + melhorMontaria.etapaCompetidor.campeonatoCompetidor.qtdTitulos + "</p>");
            float percentual = ((float)melhorMontaria.etapaCompetidor.campeonatoCompetidor.paradas / (float)melhorMontaria.etapaCompetidor.campeonatoCompetidor.saidas) * 100;
            html.WriteLine("<p class=\"nPercParadas\">" + percentual.ToString("0") + "</p>");
            html.WriteLine("<div class=\"divTextoNota\">");
            html.WriteLine("<p class=\"nNota\"> Maior Nota</p>");
            html.WriteLine("</div>");
            html.WriteLine("<div class=\"divNota\">");
            html.WriteLine("<p class=\"nota\">" + melhorMontaria.notaTempoMontaria.ToString("0.00") + "</p>");
            html.WriteLine("</div>");
        }

        public static void bannerMelhorRound(int roundID, bool telao)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Round round = contexto.Round.Find(roundID);
            List<Montaria> lstMontaria = round.montaria.Where(m => m.etapaCompetidorID != null && m.touroID != null && m.pulo && m.rep != "R").OrderByDescending(m => m.notaTempoMontaria).ToList();
            int qtdBanner = lstMontaria.Count / 10 + (lstMontaria.Count % 10 > 0 ? 1 : 0);
            for (int i = 0; i < qtdBanner; i++)
            {
                string nomeArq = "Banner/bannerMelhorRound" + i + ".html";
                List<Montaria> lstMontRel = new List<Montaria>();
                if (lstMontaria.Count > 9)
                {
                    lstMontRel = lstMontaria.Take(10).ToList();
                    lstMontaria.RemoveRange(0, 10);
                }
                else
                {
                    lstMontRel = lstMontaria.Take(lstMontaria.Count).ToList();
                    lstMontaria.RemoveRange(0, lstMontaria.Count);
                }
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    gerarInicioHtmlBanner(html, "eMelhorRoundDia.css", "melhorRoundDia.jpg");
                    textoMelhorRound(html, round, i, lstMontRel);
                    gerarFimHtmlBanner(html);
                }
                string nomeImagem = round.etapa.campeonato.getFolderName() + "/" + round.etapa.getEtapaFolder() + "/" + round.getFolder() + "/RESULTADO_ROUND/" + round.etapa.nome.Replace(" ", "_") + "_RESULTADO_ROUND(" + round.numRound + ")PAG" + (i + 1);
                phantonImage("bannerMelhorRound" + i, nomeImagem, 2810, 2559, telao);
            }
        }

        public static void textoMelhorRound(StreamWriter html, Round round, int pag, List<Montaria> lstMontaria)
        {
            html.WriteLine("<p class=\"pModalidade\">" + "RODEIO EM " + round.etapa.campeonato.modalidade.descricao + "</p>");
            html.WriteLine("<p class=\"pEtapa\">" + round.etapa.numEtapa + "ª ETAPA </p>");
            html.WriteLine("<p class=\"pNumRound\"> " + round.numRound + "° ROUND</p>");
            html.WriteLine("<p class=\"pTituloRound\"> " + round.etapa.cidade.nome + " - " + round.etapa.cidade.uf + "</p>");
            html.WriteLine("<p class=\"pPage\"> " + (pag + 1).ToString("00") + "</p>");
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo\" />");
            for (int i = 0; i < lstMontaria.Count && i < 10; i++)
            {
                html.WriteLine("<p class=\"ord\" target=\"_pos" + (i + 1) + "\">" + ((i + 1) + (pag * 10)).ToString("00") + "</p>");
                html.WriteLine("<p class=\"comp\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].etapaCompetidor.apelidoCompetidor + "</p>");
                html.WriteLine("<p class=\"touro\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].touro.nome + "</p>");
                html.WriteLine("<p class=\"tropeiro\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].touro.tropeiro.sigla + "</p>");
                if (lstMontaria[i].notaTempoMontaria > 8)
                    html.WriteLine("<p class=\"pontos\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].notaTempoMontaria.ToString("00.00") + "</p>");
                else
                    html.WriteLine("<p class=\"pontos\" style=\"color: red;\" target=\"_pos" + (i + 1) + "\"> &nbsp " + lstMontaria[i].notaTempoMontaria.ToString("0.00") + "</p>");
            }
        }

        public static void bannerSorteio(int roundID, bool telao)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Round round = contexto.Round.Find(roundID);
            string nomeArq = "Banner/bannerSorteio.html";
            List<Montaria> lstMontaria = round.montaria.Where(m => m.etapaCompetidorID != null && m.touroID != null).OrderBy(m => m.ordem).ToList();
            int qtdBanner = lstMontaria.Count / 10 + (lstMontaria.Count % 10 > 0 ? 1 : 0);
            List<Montaria> lstMontariaGeral = montariasGerais(round.etapa);
            for (int i = 0; i < qtdBanner; i++)
            {
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    List<Montaria> lstMontariaRel = new List<Montaria>();
                    if (lstMontaria.Count > 9)
                    {
                        lstMontariaRel = lstMontaria.Take(10).ToList();
                        lstMontaria.RemoveRange(0, 10);
                    }
                    else
                    {
                        lstMontariaRel = lstMontaria.Take(lstMontaria.Count).ToList();
                        lstMontaria.RemoveRange(0, lstMontaria.Count);
                    }
                    gerarInicioHtmlBanner(html, "eSorteioRound.css", "sorteioRound.jpg");
                    textoSorteio(html, round, i, lstMontariaRel, lstMontariaGeral);
                    gerarFimHtmlBanner(html);
                }
                string nomeImg = round.etapa.campeonato.getFolderName() + "/" + round.etapa.getEtapaFolder() + "/" + round.getFolder() + "/SORTEIO/" + round.etapa.nome.Replace(" ", "_") + "_SORTEIO(" + round.numRound + ")PAG" + (i + 1);
                phantonImage("bannerSorteio", nomeImg, 2795, 2539, telao);
            }
        }

        public static List<Montaria> montariasGerais(Etapa etapa)
        {
            List<Montaria> lstMontariaGeral = new List<Montaria>();
            foreach (Round rounds in etapa.round)
            {
                lstMontariaGeral.AddRange(rounds.montaria);
                if (rounds.repartirRound == 1)
                {
                    List<Round> lstTurma = rounds.etapa.round.Where(r => r.numRound == rounds.numRound).OrderBy(r => r.repartirRound).ToList();
                    foreach (Round turma in lstTurma)
                    {
                        if (turma.repartirRound != 1)
                            lstMontariaGeral.AddRange(turma.montaria);
                    }
                }
            }
            return lstMontariaGeral;
        }

        public static void textoSorteio(StreamWriter html, Round round, int pag, List<Montaria> lstMontaria, List<Montaria> lstMontariaGeral)
        {
            html.WriteLine("<p class=\"pModalidade\">" + "RODEIO EM " + round.etapa.campeonato.modalidade.descricao + "</p>");
            html.WriteLine("<p class=\"pEtapa\">" + round.etapa.numEtapa + "ª ETAPA </p>");
            html.WriteLine("<p class=\"pNumRound\"> " + round.numRound + "° ROUND</p>");
            html.WriteLine("<p class=\"pTituloRound\"> " + round.etapa.cidade.nome + " - " + round.etapa.cidade.uf + "</p>");
            html.WriteLine("<p class=\"pPage\"> " + (pag + 1).ToString("00") + "</p>");
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo\" />");
            for (int i = 0; i < lstMontaria.Count && i < 10; i++)
            {
                html.WriteLine("<p class=\"ord\" target=\"_pos" + (i + 1) + "\">" + ((i + 1) + (pag * 10)).ToString("00") + "</p>");
                html.WriteLine("<p class=\"comp\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].etapaCompetidor.apelidoCompetidor + "</p>");
                html.WriteLine("<p class=\"touro\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].touro.nome + "</p>");
                html.WriteLine("<p class=\"tropeiro\" target=\"_pos" + (i + 1) + "\">" + lstMontaria[i].touro.tropeiro.sigla + "</p>");
                html.WriteLine("<p class=\"pontos\" target=\"_pos" + (i + 1) + "\">" + calculoNotaAcumuladaMontaria(round, lstMontariaGeral, Convert.ToInt32(lstMontaria[i].etapaCompetidorID)).ToString("00.00") + "</p>");
            }
        }

        public static float calculoNotaAcumuladaMontaria(Round round, List<Montaria> lstMontariaGeral, int etapaCompetidorID)
        {
            float somaNota = 0;
            foreach (Round rounds in round.etapa.round.Where(r => r.numRound < round.numRound))
            {
                Montaria montaria = new Montaria();
                if (rounds.repartirRound > 0)
                {
                    foreach (Round roundRep in round.etapa.round.Where(r => r.numRound == rounds.numRound))
                    {
                        montaria = lstMontariaGeral.FirstOrDefault(e => e.idRoundCompetidor == roundRep.id && e.etapaCompetidorID == etapaCompetidorID && e.rep == "N" && e.pulo);
                        if (montaria != null)
                            break;
                    }
                }
                else
                    montaria = lstMontariaGeral.FirstOrDefault(e => e.idRoundCompetidor == rounds.id && e.etapaCompetidorID == etapaCompetidorID && e.rep == "N" && e.pulo && e.touroID != null);
                if (montaria != null)
                {
                    somaNota += montaria.notaMontaria;
                }
            }
            return somaNota;
        }

        public static void gerarInicioHtmlBanner(StreamWriter html, string cssNome, string imgSrc)
        {
            html.WriteLine("<html>");
            html.WriteLine("<head>");
            html.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset =utf-8\">");
            html.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" > ");
            html.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"css/" + cssNome + "\" />");
            html.WriteLine("</head>");
            html.WriteLine("<body>");
            html.WriteLine("<div class=\"image\">");
            html.WriteLine("<img src=\"img/" + imgSrc + "\"/>");
        }

        public static void gerarFimHtmlBanner(StreamWriter html)
        {
            html.WriteLine("</div>");
            html.WriteLine("</body>");
            html.WriteLine("</html>");
        }

        public static void gerarInicioHtmlTransparenteBanner(StreamWriter html, string cssNome)
        {
            html.WriteLine("<html>");
            html.WriteLine("<head>");
            html.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset =utf-8\">");
            html.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" > ");
            html.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"css/" + cssNome + "\" />");
            html.WriteLine("</head>");
            html.WriteLine("<body style=\"background-color: rgba(0,0,0,0); \">");
        }

        public static void gerarFimHtmTransparentelBanner(StreamWriter html)
        {
            html.WriteLine("</body>");
            html.WriteLine("</html>");
        }

        public static void bannerClassificacaoEtapa(int etapaID, bool telao, int pos)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Etapa etapa = contexto.Etapa.Find(etapaID);
            List<Modelo.EtapaCompetidor> lstEtapaCompetidor = etapa.etapaCompetidor.Where(t => (t.ativo || t.calculo) && t.montarias.Count(m => m.notas.Count > 0 && m.rep != "R" && m.pulo) > 0).ToList();
            lstEtapaCompetidor = lstEtapaCompetidor.OrderByDescending(t => t.pontosCalculo).ThenBy(t => t.ultimoTempo).ThenByDescending(t => t.totalTempo).ToList();
            if (!telao)
            {
                int qtdBanner = lstEtapaCompetidor.Count / 5 + (lstEtapaCompetidor.Count % 10 > 0 ? 1 : 0);
                for (int i = 0; i < qtdBanner; i++)
                {
                    string nomeArq = "Banner/classifEtapa" + i + ".html";
                    List<EtapaCompetidor> lstEtapaCompetidorRel = new List<EtapaCompetidor>();
                    if (lstEtapaCompetidor.Count > 5)
                    {
                        lstEtapaCompetidorRel = lstEtapaCompetidor.Take(5).ToList();
                        lstEtapaCompetidor.RemoveRange(0, 5);
                    }
                    else
                    {
                        lstEtapaCompetidorRel = lstEtapaCompetidor.Take(lstEtapaCompetidor.Count).ToList();
                        lstEtapaCompetidor.RemoveRange(0, lstEtapaCompetidorRel.Count);
                    }
                    using (StreamWriter html = new StreamWriter(nomeArq))
                    {
                        gerarInicioHtmlBanner(html, "eClassificacaoEtapa.css", "classificacao.jpg");
                        textoClassificacaoEtapa(html, etapa, (i * 5) + 1, lstEtapaCompetidorRel);
                        gerarFimHtmlBanner(html);
                    }
                    string nomeImagem = etapa.campeonato.getFolderName() + "/" + etapa.getEtapaFolder() + "/CLASSIFICACAO_ETAPA(5_COMPETIDORRES)/" + etapa.nome.Replace(" ", "_") + "_CLASSIFICACAO_PAG" + (i + 1);
                    phantonImage("classifEtapa" + i, nomeImagem, 2610, 2544, telao);
                }
            }
            else
            {
                string nomeArq = "Banner/classifEtapa.html";
                List<EtapaCompetidor> lstEtapaCompetidorRel = new List<EtapaCompetidor>();
                int qtd = lstEtapaCompetidor.Count - pos > 3 ? 5 : lstEtapaCompetidor.Count - pos + 1;
                lstEtapaCompetidorRel = lstEtapaCompetidor.GetRange(pos - 1, qtd);
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    gerarInicioHtmlBanner(html, "eClassificacaoEtapa.css", "classificacao.jpg");
                    textoClassificacaoEtapa(html, etapa, pos, lstEtapaCompetidorRel);
                    gerarFimHtmlBanner(html);
                }
                string nomeImagem = etapa.nome.Replace(" ", "_") + "_CLASSIFICACAO";
                phantonImage("classifEtapa", nomeImagem, 2610, 2544, telao);
            }
        }

        public static void bannerClassifEtapaNovo(int etapaID, bool telao, int pos, bool transparente = false)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Etapa etapa = contexto.Etapa.Find(etapaID);
            List<Modelo.EtapaCompetidor> lstEtapaCompetidor = etapa.etapaCompetidor.Where(t => (t.ativo || t.calculo) && t.montarias.Count(m => m.notas.Count > 0 && m.rep != "R" && m.pulo) > 0).ToList();
            lstEtapaCompetidor = lstEtapaCompetidor.OrderByDescending(t => t.pontosCalculo).ThenBy(t => t.ultimoTempo).ThenByDescending(t => t.totalTempo).ToList();
            if (!telao)
            {
                EtapaCompetidor etapaCompetidorLider = lstEtapaCompetidor.First();
                lstEtapaCompetidor.RemoveRange(0, 1);
                int qtdBanner = lstEtapaCompetidor.Count / 9 + (lstEtapaCompetidor.Count % 9 > 0 ? 1 : 0);
                for (int i = 0; i < qtdBanner; i++)
                {
                    string nomeArq = "Banner/classifEtapa" + i + ".html";
                    List<EtapaCompetidor> lstEtapaCompetidorRel = new List<EtapaCompetidor>();
                    if (lstEtapaCompetidor.Count > 9)
                    {
                        lstEtapaCompetidorRel = lstEtapaCompetidor.Take(9).ToList();
                        lstEtapaCompetidor.RemoveRange(0, 9);
                    }
                    else
                    {
                        lstEtapaCompetidorRel = lstEtapaCompetidor.Take(lstEtapaCompetidor.Count).ToList();
                        lstEtapaCompetidor.RemoveRange(0, lstEtapaCompetidorRel.Count);
                    }
                    using (StreamWriter html = new StreamWriter(nomeArq))
                    {
                        if (transparente)
                        {
                            gerarInicioHtmlTransparenteBanner(html, "eClassificacaoEtapaNovo.css");
                            textoClassificacaoEtapaNovo(html, etapa, (i * 9) + 2, lstEtapaCompetidorRel, etapaCompetidorLider);
                            gerarFimHtmTransparentelBanner(html);
                        }
                        else
                        {
                            gerarInicioHtmlBanner(html, "eClassificacaoEtapaNovo.css", "classifEtapaDez.jpg");
                            textoClassificacaoEtapaNovo(html, etapa, (i * 9) + 2, lstEtapaCompetidorRel, etapaCompetidorLider);
                            gerarFimHtmlBanner(html);
                        }
                    }
                    string nomeImagem = etapa.campeonato.getFolderName() + "/" + etapa.getEtapaFolder() + "/CLASSIFICACAO_ETAPA(10_COMPETIDORRES)"+ (transparente ? "[TRANSPARENTE]" : "") + "/" + etapa.nome.Replace(" ", "_") + "_CLASSIFICACAO_PAG" + (i + 1);
                    phantonImage("classifEtapa" + i, nomeImagem, 3572, 2011, telao, transparente);
                }
            }
            else
            {
                EtapaCompetidor etapaCompetidorLider = lstEtapaCompetidor.First();
                string nomeArq = "Banner/classifEtapa.html";
                List<EtapaCompetidor> lstEtapaCompetidorRel = new List<EtapaCompetidor>();
                if (lstEtapaCompetidor.Count - pos > 9)
                    lstEtapaCompetidorRel = lstEtapaCompetidor.GetRange(pos - 1, 9).ToList();
                else
                    lstEtapaCompetidorRel = lstEtapaCompetidor.GetRange(pos - 1, lstEtapaCompetidor.Count - pos).ToList();
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    gerarInicioHtmlBanner(html, "eClassificacaoEtapaNovo.css", "classifEtapaDez.jpg");
                    textoClassificacaoEtapaNovo(html, etapa, pos, lstEtapaCompetidorRel, etapaCompetidorLider);
                    gerarFimHtmlBanner(html);
                }
                string nomeImagem = etapa.nome.Replace(" ", "_") + "_CLASSIFICACAO";
                phantonImage("classifEtapa", nomeImagem, 3572, 2011, telao);
            }
        }



        public static void textoClassificacaoEtapaNovo(StreamWriter html, Etapa etapa, int posInicial, List<EtapaCompetidor> lstEtapaCompetidor, Modelo.EtapaCompetidor etapaCompetidorLider)
        {
            html.WriteLine("<div class=\"dCompLider\" target=\"_comp1\">" + etapaCompetidorLider.apelidoCompetidor + " </div>");
            html.WriteLine("<div class=\"dNotaLider\" target=\"_nota1\">" + etapaCompetidorLider.pontosCalculo.ToString("0.00") + "</div>");
            string cowboySombra = @"img\perfilSombra.png";
            string arq = @"Banner\img\perfil\" + etapaCompetidorLider.competidorID + ".png";
            if (File.Exists(arq))
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + arq.Replace(@"Banner\", "") + "\"/>");
            }
            else
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + cowboySombra + "\"/>");
            }
            for (int i = 0; i < lstEtapaCompetidor.Count; i++)
            {
                string competidor = lstEtapaCompetidor[i].apelidoCompetidor;
                html.WriteLine("<div class=\"dComp\" target=\"_comp" + (i + 2) + "\">" + competidor + " </div>");
                html.WriteLine("<div class=\"dPos\" target=\"_pos" + (i + 2) + "\">" + (posInicial + i) + "º </div>");
                html.WriteLine("<div class=\"dNota\" target=\"_nota" + (i + 2) + "\">" + lstEtapaCompetidor[i].pontosCalculo.ToString("0.00") + "</div>");
            }
        }

        public static void bannerClassifRanking(int campeonatoID, int pos, bool telao, string tipoFoto, bool transparente = false)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Campeonato campeonato = contexto.Campeonato.Find(campeonatoID);
            List<CampeonatoCompetidor> lstCamp = campeonato.campeonatoCompetidor.OrderByDescending(t => t.pontos).ToList();
            if (lstCamp.Count > 0)
            {
                if (telao)
                {
                    string arq = "Banner/classifRanking.html";
                    using (StreamWriter html = new StreamWriter(arq))
                    {
                        gerarInicioHtmlBanner(html, "eClassificacaoRanking.css", "classifRanking.jpg");
                        textoClassifiRanking(html, campeonato, lstCamp[0], lstCamp.GetRange(pos - 1, 4), pos, tipoFoto);
                        gerarFimHtmlBanner(html);
                    }
                    string nomeImagem = campeonato.nome.Replace(" ", "_") + "_CLASSIFICACAO";
                    phantonImage("classifRanking", nomeImagem, 3568, 2006, telao);
                }
                else
                {
                    CampeonatoCompetidor campeonatoCompetidorLider = lstCamp.First();
                    lstCamp.RemoveRange(0, 1);
                    int qtdBanner = lstCamp.Count / 4 + (lstCamp.Count % 4 > 0 ? 1 : 0);
                    for (int i = 0; i < qtdBanner; i++)
                    {
                        string nomeArq = "Banner/classifRanking" + i + ".html";
                        List<CampeonatoCompetidor> lstCampeonatoCompetidorRel = new List<CampeonatoCompetidor>();
                        if (lstCamp.Count > 4)
                        {
                            lstCampeonatoCompetidorRel = lstCamp.Take(4).ToList();
                            lstCamp.RemoveRange(0, 4);
                        }
                        else
                        {
                            lstCampeonatoCompetidorRel = lstCamp.Take(lstCamp.Count).ToList();
                            lstCamp.RemoveRange(0, lstCampeonatoCompetidorRel.Count);
                        }
                        using (StreamWriter html = new StreamWriter(nomeArq))
                        {
                            if (transparente)
                            {
                                gerarInicioHtmlTransparenteBanner(html, "eClassificacaoRanking.css");
                                textoClassifiRanking(html, campeonato, campeonatoCompetidorLider, lstCampeonatoCompetidorRel, (i * 4) + 2, tipoFoto);
                                gerarFimHtmTransparentelBanner(html);
                            }
                            else
                            {
                                gerarInicioHtmlBanner(html, "eClassificacaoRanking.css", "classifRanking.jpg");
                                textoClassifiRanking(html, campeonato, campeonatoCompetidorLider, lstCampeonatoCompetidorRel, (i * 4) + 2, tipoFoto);
                                gerarFimHtmlBanner(html);

                            }
                        }
                        DateTime dt = DateTime.Now;
                        string nomeImagem = campeonato.getFolderName() + "/RANKING(" + dt.Day.ToString("00") + "-" + dt.Month.ToString("00") + ")" + (transparente ? "[TRANSPARENTE]" : "") + "/" + campeonato.nome.Replace(" ", "_") + "_RANKING_PAG" + (i + 1);
                        phantonImage("classifRanking" + i, nomeImagem, 3568, 2006, telao, transparente);
                    }
                }
            }
        }

        public static void bannerClassifCopa(int etapaID, int pos, bool telao, string tipoFoto, bool transparente = false)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Etapa etapa = contexto.Etapa.Find(etapaID);
            if (etapa.copaEtapa.Count > 0)
            {

                if (telao)
                {
                    /*string arq = "Banner/classifCopa.html";
                    using (StreamWriter html = new StreamWriter(arq))
                    {
                        gerarInicioHtmlBanner(html, "eClassificacaoRanking.css", "classifRanking.jpg");
                        textoClassifiRanking(html, campeonato, lstCamp[0], lstCamp.GetRange(pos - 1, 4), pos, tipoFoto);
                        gerarFimHtmlBanner(html);
                    }
                    string nomeImagem = campeonato.nome.Replace(" ", "_") + "_CLASSIFICACAO";
                    phantonImage("classifRanking", nomeImagem, 3568, 2006, telao);
                    */
                }
                else
                {
                    Copa copa = contexto.Copa.Find(etapa.copaEtapa.First().copaID);
                    List<CopaCompetidor> lstCopacompetidor = copa.getCompetidores();
                    CopaCompetidor copaCompetidorLider = lstCopacompetidor.First();
                    lstCopacompetidor.RemoveRange(0, 1);
                    int qtdBanner = lstCopacompetidor.Count / 4 + (lstCopacompetidor.Count % 4 > 0 ? 1 : 0);
                    for (int i = 0; i < qtdBanner; i++)
                    {
                        string nomeArq = "Banner/classifCopa" + i + ".html";
                        List<CopaCompetidor> lstCopaCompetidorRel = new List<CopaCompetidor>();
                        if (lstCopacompetidor.Count > 4)
                        {
                            lstCopaCompetidorRel = lstCopacompetidor.Take(4).ToList();
                            lstCopacompetidor.RemoveRange(0, 4);
                        }
                        else
                        {
                            lstCopaCompetidorRel = lstCopacompetidor.Take(lstCopacompetidor.Count).ToList();
                            lstCopacompetidor.RemoveRange(0, lstCopaCompetidorRel.Count);
                        }
                        using (StreamWriter html = new StreamWriter(nomeArq))
                        {

                            if (transparente)
                            {
                                gerarInicioHtmlTransparenteBanner(html, "eClassificacaoRanking.css");
                                textoClassifiCopaRanking(html, copa, copaCompetidorLider, lstCopaCompetidorRel, (i * 4) + 2, tipoFoto);
                                gerarFimHtmTransparentelBanner(html);
                            }
                            else
                            {
                                gerarInicioHtmlBanner(html, "eClassificacaoRanking.css", "classifRanking.jpg");
                                textoClassifiCopaRanking(html, copa, copaCompetidorLider, lstCopaCompetidorRel, (i * 4) + 2, tipoFoto);
                                gerarFimHtmlBanner(html);

                            }

                        }
                        DateTime dt = DateTime.Now;
                        string nomeImagem = copa.campeonato.getFolderName() + "/" + copa.getCopaFolder() + "/RANKING_COPA(" + dt.Day.ToString("00") + "-" + dt.Month.ToString("00") + (transparente ? "[TRANSPARETNE]" : "") + ")/" + copa.descr.Replace(" ", "_") + "_RANKING_PAG" + (i + 1);
                        phantonImage("classifCopa" + i, nomeImagem, 3568, 2006, telao, transparente);
                    }
                }

            }
        }

        public static void textoClassifiCopaRanking(StreamWriter html, Modelo.Copa copa, CopaCompetidor copaCompetidorLider, List<CopaCompetidor> lstCopaCompetidor, int pos, string tipoFoto)
        {
            if (copa.premio > 0)
            {
                html.WriteLine("<div class=\"premio\"> (R$ " + copa.premio.ToString("#,###.00") + ")</div>");
            }
            html.WriteLine("<div class=\"compNomeLider\" target=\"_comp1\">" + copaCompetidorLider.campeonatoCompetidor.competidor.apelido + "</div>");
            html.WriteLine("<div class=\"pontosLider\" target=\"_pontos1\">" + copaCompetidorLider.pontos.ToString("0.00") + "</div>");
            string cowboySombra = @"img\perfilSombra.png";
            string cowboyImg = @"Banner\img\" + tipoFoto + @"\" + copaCompetidorLider.campeonatoCompetidor.competidor.apelido + ".png";
            if (File.Exists(cowboyImg))
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + cowboyImg.Replace(@"Banner\", "") + "\"/>");
            }
            else
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + cowboySombra + "\"/>");
            }
            for (int i = 0; i < lstCopaCompetidor.Count; i++)
            {
                cowboyImg = @"Banner\img\" + tipoFoto + @"\" + lstCopaCompetidor[i].campeonatoCompetidor.competidor.apelido + ".png";
                if (File.Exists(cowboyImg))
                {
                    html.WriteLine("<img class=\"imgComp\" target=\"_img" + (i + 2) + "\" src=\"" + cowboyImg.Replace(@"Banner\", "") + "\"/>");
                }
                else
                {
                    html.WriteLine("<img class=\"imgComp\" target=\"_img" + (i + 2) + "\" src=\"" + cowboySombra + "\"/>");
                }
                html.WriteLine("<div class=\"pos\" target=\"_pos" + (i + 2) + "\">" + (pos + i) + "º</div>");
                html.WriteLine("<div class=\"compNome\" target=\"_comp" + (i + 2) + "\">" + lstCopaCompetidor[i].campeonatoCompetidor.competidor.apelido + "</div>");
                html.WriteLine("<div class=\"pontos\" target=\"_pontos" + (i + 2) + "\">" + (lstCopaCompetidor[i].pontos - copaCompetidorLider.pontos).ToString("0.00") + "</div>");
            }
        }


        public static void textoClassifiRanking(StreamWriter html, Modelo.Campeonato campeonato, CampeonatoCompetidor campCompLider, List<CampeonatoCompetidor> lstCampeonatoCompetidor, int pos, string tipoFoto)
        {
            if (campeonato.premio > 0)
            {
                html.WriteLine("<div class=\"premio\"> (R$ " + campeonato.premio.ToString("#,###.00") + ")</div>");
            }
            html.WriteLine("<div class=\"compNomeLider\" target=\"_comp1\">" + campCompLider.competidor.apelido + "</div>");
            html.WriteLine("<div class=\"pontosLider\" target=\"_pontos1\">" + campCompLider.pontos.ToString("0.00") + "</div>");
            string cowboySombra = @"img\perfilSombra.png";
            string cowboyImg = @"Banner\img\" + tipoFoto + @"\" + campCompLider.competidorID + ".png";
            if (File.Exists(cowboyImg))
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + cowboyImg.Replace(@"Banner\", "") + "\"/>");
            }
            else
            {
                html.WriteLine("<img class=\"imgCompLider\" target=\"_img1\" src=\"" + cowboySombra + "\"/>");
            }
            for (int i = 0; i < lstCampeonatoCompetidor.Count; i++)
            {
                cowboyImg = @"Banner\img\" + tipoFoto + @"\" + lstCampeonatoCompetidor[i].competidorID + ".png";
                if (File.Exists(cowboyImg))
                {
                    html.WriteLine("<img class=\"imgComp\" target=\"_img" + (i + 2) + "\" src=\"" + cowboyImg.Replace(@"Banner\", "") + "\"/>");
                }
                else
                {
                    html.WriteLine("<img class=\"imgComp\" target=\"_img" + (i + 2) + "\" src=\"" + cowboySombra + "\"/>");
                }
                html.WriteLine("<div class=\"pos\" target=\"_pos" + (i + 2) + "\">" + (pos + i) + "º</div>");
                html.WriteLine("<div class=\"compNome\" target=\"_comp" + (i + 2) + "\">" + lstCampeonatoCompetidor[i].competidor.apelido + "</div>");
                html.WriteLine("<div class=\"pontos\" target=\"_pontos" + (i + 2) + "\">" + (lstCampeonatoCompetidor[i].pontos - campCompLider.pontos).ToString("0.00") + "</div>");
            }
        }

        public static void bannerClassificacaoCopa(int etapaID, int copaID, List<CopaCompetidor> lstCopaCompetidor, int pos, bool telao, bool transparente = false)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Etapa etapa = contexto.Etapa.Find(etapaID);
            Copa copa = contexto.Copa.Find(copaID);
            if (telao)
            {
                string nomeArq = "Banner/classifCopa.html";
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    gerarInicioHtmlBanner(html, "eClassificacaoEtapa.css", "classificacao.jpg");
                    textoClassificacaoCopa(html, copa, etapa, pos, lstCopaCompetidor);
                    gerarFimHtmlBanner(html);
                }
                string nomeImagem = etapa.nome.Replace(" ", "_") + "_CLASSIFICACAO";
                phantonImage("classifCopa", nomeImagem, 2610, 2544, telao);
            }
            else
            {
                Funcoes.finalizarRound.calculoBonus(etapaID, false);
                lstCopaCompetidor = copa.getCompetidores();
                for (int i = 1; i < lstCopaCompetidor.Count; i++)
                {
                    lstCopaCompetidor[i].pontos = lstCopaCompetidor[0].pontos - lstCopaCompetidor[i].pontos;
                }
            }
        }



        public static void textoClassificacaoCopa(StreamWriter html, Copa copa, Etapa etapa, int posInicial, List<CopaCompetidor> lstCopaCompetidor)
        {
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo1\" />");
            html.WriteLine("<img src=\"img/logo2.png\" class=\"logo2\" />");
            html.WriteLine("<div class=\"dEtapaTexto\"> <font class=\"f1\"> CLASSIFICAÇÃO DA " + copa.descr + " </font> </div>");
            html.WriteLine("<div class=\"dModalidade\"> <font class=\"f1L\"> RODEIO EM " + etapa.campeonato.modalidade.descricao + "</font> </div>");
            for (int i = 0; i < lstCopaCompetidor.Count; i++)
            {
                string competidor = lstCopaCompetidor[i].campeonatoCompetidor.competidor.apelido;
                if (competidor.Count() >= 19)
                {
                    competidor = competidor.Substring(0, 19) + ".";
                }
                html.WriteLine("<div class=\"dComp" + (i + 1) + "\"> <font class=\"f1\">" + competidor + "</font> </div>");
                html.WriteLine("<div class=\"dPos" + (i + 1) + "\"> <font class=\"f1N\">" + (posInicial + i) + "º </font> </div>");
                if (posInicial == 1 && i == 0)
                    html.WriteLine("<div class=\"dNota" + (i + 1) + "\"> <font class=\"f1P\" style=\"color: blue;\">" + lstCopaCompetidor[i].pontos.ToString("0.00") + "</font> </div>");
                else
                    html.WriteLine("<div class=\"dNota" + (i + 1) + "\"> <font class=\"f1P\" style=\"color: red;\">-" + lstCopaCompetidor[i].pontos.ToString("0.00") + "</font> </div>");

            }
        }


        public static void textoClassificacaoEtapa(StreamWriter html, Etapa etapa, int posInicial, List<EtapaCompetidor> lstEtapaCompetidor)
        {
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo1\" />");
            html.WriteLine("<img src=\"img/logo2.png\" class=\"logo2\" />");
            //html.WriteLine("<div class=\"dEtapaCidade\"> <font class=\"f1L\"> " + etapa.cidade.nome + " - " + etapa.cidade.uf + "</font> </div>");
            //html.WriteLine("<div class=\"dEtapaNum\"> <font class=\"f1L\"> " + etapa.numEtapa + "ª ETAPA" + "</font> </div> ");
            html.WriteLine("<div class=\"dEtapaTexto\"> <font class=\"f1\"> CLASSIFICAÇÃO DA ETAPA </font> </div>");
            html.WriteLine("<div class=\"dModalidade\"> <font class=\"f1L\"> RODEIO EM " + etapa.campeonato.modalidade.descricao + "</font> </div>");
            for (int i = 0; i < lstEtapaCompetidor.Count; i++)
            {
                string competidor = lstEtapaCompetidor[i].apelidoCompetidor;
                if (competidor.Count() >= 19)
                {
                    competidor = competidor.Substring(0, 19) + ".";
                }
                html.WriteLine("<div class=\"dComp" + (i + 1) + "\"> <font class=\"f1\">" + competidor + "</font> </div>");
                html.WriteLine("<div class=\"dPos" + (i + 1) + "\"> <font class=\"f1N\">" + (posInicial + i) + "º </font> </div>");
                html.WriteLine("<div class=\"dNota" + (i + 1) + "\"> <font class=\"f1N\" style=\"color: black;\">" + lstEtapaCompetidor[i].pontosCalculo.ToString("0.00") + "</font> </div>");
            }
        }

        public static void bannerClassificacaoRound(int roundID, bool telao, int pos)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Round round = contexto.Round.Find(roundID);
            List<Modelo.Montaria> lstMontaria = round.montaria.Where(t => t.etapaCompetidorID != null && t.etapaCompetidor.ativo && t.notas.Count > 0 && t.rep != "R" && t.pulo).OrderByDescending(t => t.notaTempoMontaria).ThenBy(t => t.etapaCompetidor.apelidoCompetidor).ToList();
            int qtd = lstMontaria.Count - pos > 3 ? 5 : lstMontaria.Count - pos + 1;
            lstMontaria = lstMontaria.GetRange(pos - 1, qtd);
            if (telao)
            {
                string nomeArq = "Banner/classifRound.html";
                using (StreamWriter html = new StreamWriter(nomeArq))
                {
                    gerarInicioHtmlBanner(html, "eClassificacaoEtapa.css", "classificacao.jpg");
                    textoClassificacaoRound(html, round, pos, lstMontaria);
                    gerarFimHtmlBanner(html);
                }
                string nomeImagem = "classifRound";
                phantonImage("classifRound", nomeImagem, 2610, 2544, telao);
            }
        }

        public static void textoClassificacaoRound(StreamWriter html, Round round, int posInicial, List<Montaria> lstMontaria)
        {
            html.WriteLine("<img src=\"img/logo1.png\" class=\"logo1\" />");
            html.WriteLine("<img src=\"img/logo2.png\" class=\"logo2\" />");
            //html.WriteLine("<div class=\"dEtapaCidade\"> <font class=\"f1L\"> " + etapa.cidade.nome + " - " + etapa.cidade.uf + "</font> </div>");
            //html.WriteLine("<div class=\"dEtapaNum\"> <font class=\"f1L\"> " + etapa.numEtapa + "ª ETAPA" + "</font> </div> ");
            html.WriteLine("<div class=\"dEtapaTexto\"> <font class=\"f1\"> CLASSIFICAÇÃO DO ROUND </font> </div>");
            html.WriteLine("<div class=\"dModalidade\"> <font class=\"f1L\"> RODEIO EM " + round.etapa.campeonato.modalidade.descricao.ToUpper() + "</font> </div>");
            for (int i = 0; i < lstMontaria.Count; i++)
            {
                string competidor = lstMontaria[i].etapaCompetidor.apelidoCompetidor;
                if (competidor.Count() >= 19)
                {
                    competidor = competidor.Substring(0, 19) + ".";
                }
                html.WriteLine("<div class=\"dComp" + (i + 1) + "\"> <font class=\"f1\">" + competidor + "</font> </div>");
                html.WriteLine("<div class=\"dPos" + (i + 1) + "\"> <font class=\"f1N\">" + (posInicial + i) + "º </font> </div>");
                html.WriteLine("<div class=\"dNota" + (i + 1) + "\"> <font class=\"f1N\" style=\"color:" + (lstMontaria[i].notaTempoMontaria > 8 ? "black" : "red") + ";\">" + lstMontaria[i].notaTempoMontaria.ToString("0.00") + "</font> </div>");
            }
        }

        public static void gerarDepoisMontaria(int montariaID)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Montaria montaria = contexto.Montaria.Find(montariaID);
            string nomeArq = "Banner/dMontaria.html";
            int pos = montaria.round.montaria.Where(t => t.etapaCompetidorID != null && t.etapaCompetidor.ativo && t.rep != "R").OrderByDescending(t => t.etapaCompetidor.pontosCalculo).ThenByDescending(t => t.etapaCompetidor.ultimoTempo).ThenByDescending(t => t.etapaCompetidor.totalTempo).ToList().IndexOf(montaria) + 1;
            using (StreamWriter html = new StreamWriter(nomeArq))
            {
                gerarInicioHtmlBanner(html, "dMontaria.css", "dMontaria.jpg");
                depoisMontariaHtml(html, montaria, pos);
                gerarFimHtmlBanner(html);
            }
            string nomeImagem = "dMontaria";
            phantonImage("dMontaria", nomeImagem, 2801, 2543, true);
        }

        public static void depoisMontariaHtml(StreamWriter html, Modelo.Montaria montaria, int pos)
        {
            html.WriteLine("<div class=\"dLogo\">");
            html.WriteLine("<img class=\"logo1\" src=\"img/logo1.png\">");
            html.WriteLine("<img class=\"logo2\" src=\"img/logo2.png\">");
            html.WriteLine("</div>");
            string arq = @"Banner\img\frente\" + montaria.etapaCompetidor.competidorID + ".png";
            if (File.Exists(arq))
                html.WriteLine("<img class=\"imgCowboy\" src=\"" + arq.Replace(@"Banner\", "") + "\"/>");
            else
                html.WriteLine("<img class=\"imgCowboySombra\" src=\"img/cowboy.png\"/>");
            html.WriteLine("<div class=\"dNome\">" + pos + "º " + montaria.etapaCompetidor.competidor.apelido + "</div>");
            html.WriteLine("<div class=\"dTouro\">" + montaria.touro.nome + " </div>");
            html.WriteLine("<div class=\"dTropeiro\">" + montaria.touro.tropeiro.nome + "</div>");
            int i = 1;
            montaria.notas.OrderBy(t => t.juiz.profissonal.nome).ToList().ForEach(t =>
            {
                html.WriteLine("<div class=\"dJuiz\" target=\"_juiz" + i + "\" > " + t.juiz.profissonal.apelido.Replace(" ", "<br>") + "</font> </div>");
                html.WriteLine("<div class=\"dNotaTJ\" target=\"_notaT" + i + "\"> " + t.notaTouro.ToString("0.00") + "</font> </div>");
                html.WriteLine("<div class=\"dNotaCJ\" target=\"_notaC" + i + "\" > " + (montaria.notaTempoMontaria > 8 ? t.notaCompetidor.ToString("0.00") : t.tempoMedio.ToString("0.00")) + "</font> </div>");
                i++;
            });
            html.WriteLine("<div class=\"dNotaTT\">" + montaria.notaTouro.ToString("0.00") + "</div>");
            html.WriteLine("<div class=\"dNotaCT\">" + (montaria.notaTempoMontaria > 8 ? montaria.notas.Sum(n => n.notaCompetidor).ToString("0.00") : montaria.notaTempoMontaria.ToString("0.00")) + "</font> </div>");
            html.WriteLine("<div class=\"dNotaTotal\">" + (montaria.notaTempoMontaria > 8 ? montaria.notaTempoMontaria.ToString("0.00") : "0,00") + "</div>");
        }

        public static void gerarAntesMontaria(int montariaID)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Montaria montaria = contexto.Montaria.Find(montariaID);
            string nomeArq = "Banner/aMontaria.html";
            int pos = montaria.round.montaria.Where(t => t.etapaCompetidorID != null && t.etapaCompetidor.ativo && t.rep != "R").OrderByDescending(t => t.etapaCompetidor.pontosCalculo).ThenByDescending(t => t.etapaCompetidor.ultimoTempo).ThenByDescending(t => t.etapaCompetidor.totalTempo).ToList().IndexOf(montaria) + 1;
            using (StreamWriter html = new StreamWriter(nomeArq))
            {
                gerarInicioHtmlBanner(html, "aMontaria.css", "aMontaria.jpg");
                antesMontariaHtml(html, montaria);
                gerarFimHtmlBanner(html);
            }
            string nomeImagem = "aMontaria";
            phantonImage("aMontaria", nomeImagem, 2801, 2543, true);
        }

        public static void antesMontariaHtml(StreamWriter html, Montaria montaria)
        {
            html.WriteLine("<div class=\"dLogo\">");
            html.WriteLine("<img class=\"logo1\" src=\"img/logo1.png\">");
            html.WriteLine("<img class=\"logo2\" src=\"img/logo2.png\">");
            html.WriteLine("</div>");
            List<Modelo.Montaria> lstMontaria = montaria.round.montaria.Where(t => t.etapaCompetidorID != null && t.etapaCompetidor.ativo && t.rep != "R").OrderByDescending(t => t.etapaCompetidor.pontosCalculo).ThenByDescending(t => t.etapaCompetidor.ultimoTempo).ThenByDescending(t => t.etapaCompetidor.totalTempo).ToList();
            int pos = lstMontaria.IndexOf(montaria) + 1;
            Modelo.Etapa etapa = montaria.round.etapa;
            float difLider = 0;
            float acumulado = montaria.etapaCompetidor.pontosCalculo;
            if (pos != 1)
                difLider = lstMontaria[0].etapaCompetidor.pontosCalculo - acumulado;
            string arq = @"Banner\img\frente\" + montaria.etapaCompetidor.competidorID + ".png";
            if (File.Exists(arq))
                html.WriteLine("<img class=\"imgCowboy\" src=\"" + arq.Replace(@"Banner\", "") + "\"/>");
            else
                html.WriteLine("<img class=\"imgCowboy\" src=\"img/cowboy.png\"/>");
            html.WriteLine("<div class=\"dEtapaCidade\">" + etapa.numEtapa + "ª ETAPA" + " - ROUND " + montaria.round.numRound + "</div> ");
            html.WriteLine("<div class=\"dNome\">" + montaria.etapaCompetidor.competidor.apelido + "</div>");
            html.WriteLine("<div class=\"dCidade\">" + montaria.etapaCompetidor.competidor.cidade.nome + " - " + montaria.etapaCompetidor.competidor.cidade.uf + "</div>");
            html.WriteLine("<div class=\"dColocacao\">" + pos + "º </div>");
            html.WriteLine("<div class=\"dAcumulado\">" + acumulado.ToString("0.00") + "</div>");
            html.WriteLine("<div class=\"dDiferenca\">" + difLider.ToString("0.00") + "</div>");
            html.WriteLine("<div class=\"dTouro\">" + montaria.touro.nome + "</div>");
            html.WriteLine("<div class=\"dCia\">" + montaria.touro.tropeiro.nome + "</div>");
        }
    }
}