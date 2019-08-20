using System;
using System.Collections.Generic;
using System.Linq;
using SGCRP.Modelo;
using System.Windows.Forms;
using System.IO;
using Novacode;
using System.Drawing;


namespace SGCRP.Funcoes
{
    class Contratos
    {
        public static void geracaoContrato()
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            winword.ShowAnimation = false;

            winword.Visible = false;
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            //Configuração da Pagian
            object FilePath = @"c:\Teste\contrato.doc";
            object oMissing = Type.Missing;
            Microsoft.Office.Interop.Word.Application templateDoc = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document documentTemplate = templateDoc.Documents.Open(ref FilePath,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing);
            document.PageSetup.TopMargin = documentTemplate.PageSetup.TopMargin;
            document.PageSetup.BottomMargin = documentTemplate.PageSetup.BottomMargin;
            document.PageSetup.LeftMargin = documentTemplate.PageSetup.LeftMargin;
            document.PageSetup.RightMargin = documentTemplate.PageSetup.RightMargin;




            object filename = @"c:\teste\teste.doc";
            document.SaveAs2(ref filename);
            document.Close(ref missing, ref missing, ref missing);
            documentTemplate.Close(ref oMissing, ref oMissing, ref oMissing);
            document = null;
            winword.Quit(ref missing, ref missing, ref missing);
            templateDoc.Quit(ref oMissing, ref oMissing, ref oMissing);
            winword = null;
            MessageBox.Show("Document created successfully !");
        }

        private static void pularLinhas(Paragraph p, int qtdLinha)
        {
            for (int i = 0; i < qtdLinha; i++)
            {
                p.AppendLine().Font(new FontFamily("Arial"));
            }
        }

        public static void geracaoContratoDocX(ExpecifContrato expecif, int? competidorInicioID, int? competidorFim)
        {
            SGCRPContexto contexto = new SGCRPContexto();
            Modelo.Empresa empresa = contexto.Empresa.Find(expecif.empresaID);
            Modelo.Etapa etapa = contexto.Etapa.Find(expecif.etapaID);
            List<EtapaCompetidor> lstEtapaCompetidor = etapa.etapaCompetidor.OrderBy(e => e.nomeCompetidor).ToList();
            List<EtapaCompetidor> lstCompIntervalo = new List<EtapaCompetidor>();
            bool validado = false;
            if (competidorInicioID != null)
            {
                for (int i = 0; i < lstEtapaCompetidor.Count; i++)
                {
                    if (lstEtapaCompetidor[i].id == competidorInicioID || validado)
                    {
                        lstCompIntervalo.Add(lstEtapaCompetidor[i]);
                        validado = true;
                    }
                    if (lstEtapaCompetidor[i].id == competidorFim)
                        break;
                }
            }
            else
                lstCompIntervalo = lstEtapaCompetidor;
            FontFamily font = new FontFamily("Arial");
            string nomeArq = expecif.nomeFesta.Replace(" ", "_") + "(" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + ")";
            string filePath = @"c:\Contrato\" + nomeArq + "_CONTRATO.doc";
            using (DocX doc = DocX.Create(filePath))
            {
                doc.MarginTop = 53.9f;
                doc.MarginBottom = 72f;
                doc.MarginLeft = 63f;
                doc.MarginRight = 37.4f;
                for (int i = 0; i < lstCompIntervalo.Count; i++)
                {
                    geracaoContratoRpa(expecif, lstCompIntervalo[i].id, doc, false);
                    geracaoContratoRpa(expecif, lstCompIntervalo[i].id, doc, true);
                    geracaoContratoCompetidor(lstCompIntervalo[i], doc, etapa, empresa, expecif);
                    geracaoContratoCompetidor(lstCompIntervalo[i], doc, etapa, empresa, expecif);
                }
                doc.Save();
            }
            System.Diagnostics.Process.Start(filePath);
        }

        public static void geracaoContratoCompetidor(EtapaCompetidor etapaCompetidor, DocX doc, Etapa etapa, Empresa empresa, ExpecifContrato expecif)
        {
            Paragraph pTitulo = doc.InsertParagraph();
            pTitulo.Alignment = Alignment.center;
            insertAppendBold(pTitulo, "CONTRATO DE PRESTAÇÃO DE SERVIÇO INDIVIDUAL EM CARÁTER EVENTUAL SEM RELAÇÃO DE EMPREGO");
            pularLinhas(pTitulo, 8);
            Dictionary<int, string> dcDias = new Dictionary<int, string>();
            dcDias.Add(1, "um");
            dcDias.Add(2, "dois");
            dcDias.Add(3, "três");
            dcDias.Add(4, "quatro");
            dcDias.Add(5, "cinco");
            dcDias.Add(6, "seis");
            dcDias.Add(7, "sete");
            Paragraph pIntroducao = doc.InsertParagraph();
            pIntroducao.Alignment = Alignment.both;
            pIntroducao.IndentationFirstLine = 4.109f;
            insertAppendBold(pIntroducao, empresa.razaoSocial);
            insertAppend(pIntroducao, ", pessoa jurídica de direito privado, CNPJ/MF sob o n.º " + empresa.cnpj + ", com sede na " + empresa.endereco);
            insertAppend(pIntroducao, ", na cidade de " + empresa.cidade.nome + ", estado de " + empresa.cidade.getEstado() + " doravante denominada ");
            insertAppendBold(pIntroducao, "CONTRATANTE");
            insertAppend(pIntroducao, " e ");
            insertAppendBold(pIntroducao, etapaCompetidor.competidor.nome);
            insertAppend(pIntroducao, ", inscrito no CPF/MF sob o n.º " + etapaCompetidor.competidor.cpf + ", doravante denominado ");
            insertAppendBold(pIntroducao, "CONTRATADO");
            insertAppend(pIntroducao, ", tem entre si, combinado o presente contrato, que mútua e reciprocamente outorgam e aceitam mediante as cláusulas e condições seguintes, nos termos da Lei n.º 10.220/01: ");
            SendKeys.Send("{ENTER}");

            Paragraph pTituloClausula1 = doc.InsertParagraph();
            pularLinhas(pTituloClausula1, 1);
            insertAppendBold(pTituloClausula1, "CLÁUSULA PRIMEIRA");

            Paragraph pClausulaPrimeira = doc.InsertParagraph();
            pClausulaPrimeira.Alignment = Alignment.both;
            pClausulaPrimeira.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaPrimeira, "O presente instrumento tem por objeto a prestação de serviço do ");
            insertAppendBold(pClausulaPrimeira, "CONTRATADO");
            insertAppend(pClausulaPrimeira, ", assim considerado, nos termos do artigo 1º da Lei supra mencionada, à ");
            insertAppendBold(pClausulaPrimeira, "CONTRATADA");
            insertAppend(pClausulaPrimeira, ", para o exercício da função de Peão de Rodeios na ");
            insertAppendBold(pClausulaPrimeira, expecif.nomeFesta + " - " + etapa.numEtapa + "ª ETAPA DO CIRCUITO RANCHO PRIMAVERA");
            insertAppend(pClausulaPrimeira, ", a realizar-se entre os dias " + etapa.dataInicio.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(etapa.dataInicio.Month).FirstCharToUpper()
                + " de " + etapa.dataInicio.Year.ToString("0,000"));
            insertAppend(pClausulaPrimeira, " a " + etapa.dataFim.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(etapa.dataFim.Month).FirstCharToUpper()
                + " de " + etapa.dataFim.Year.ToString("0,000") + ".");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula2 = doc.InsertParagraph();
            pularLinhas(pTituloClausula2, 1);
            insertAppendBold(pTituloClausula2, "CLÁUSULA SEGUNDA");

            Paragraph pClausulaSegundaL1 = doc.InsertParagraph();
            pClausulaSegundaL1.Alignment = Alignment.both;
            pClausulaSegundaL1.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaSegundaL1, "O prazo de vigência do presente contrato será de " + ((etapa.dataFim - etapa.dataInicio).Days + 1).ToString("00"));
            insertAppend(pClausulaSegundaL1, " dias, com início no dia " + etapa.dataInicio.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(etapa.dataInicio.Month).FirstCharToUpper()
                + " de " + etapa.dataInicio.Year.ToString("0,000"));
            insertAppend(pClausulaSegundaL1, " e término no dia " + etapa.dataFim.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(etapa.dataFim.Month).FirstCharToUpper()
                + " de " + etapa.dataFim.Year.ToString("0,000") + ".");
            SendKeys.Send("{ENTER}");
            Paragraph pClausulaSegundaL2 = doc.InsertParagraph();
            insertAppend(pClausulaSegundaL2, "No caso de não comparecimento nos dias estipulados acima a ");
            insertAppendBold(pClausulaSegundaL2, "CONTRATANTE");
            insertAppend(pClausulaSegundaL2, "  poderá considerar rescindido o presente contrato, sendo devidos apenas os dias efetivamente trabalhados.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula3 = doc.InsertParagraph();
            pularLinhas(pTituloClausula3, 1);
            insertAppendBold(pTituloClausula3, "CLÁUSULA TERCEIRA");

            Paragraph pClasulaTerceira = doc.InsertParagraph();
            pClasulaTerceira.Alignment = Alignment.both;
            pClasulaTerceira.IndentationFirstLine = 4.109f;
            insertAppend(pClasulaTerceira, "Em razão das festividades e da realização do Rodeio objeto do presente contrato, a jornada de trabalho dos "
              + "Peões de Rodeio iniciar-se-á as 20:00 hrs e terminará as 00:00 hr, com a observância de que não excederá a oito horas/dia, na sua "
              + "consecução.");
            SendKeys.Send("{ENTER}");

            Paragraph pTituloClasula4 = doc.InsertParagraph();
            pularLinhas(pTituloClasula4, 1);
            insertAppendBold(pTituloClasula4, "CLÁUSULA QUARTA");

            Paragraph pClasulaQuarta = doc.InsertParagraph();
            pClasulaQuarta.Alignment = Alignment.both;
            pClasulaQuarta.IndentationFirstLine = 4.109f;
            insertAppend(pClasulaQuarta, "Nos termos do artigo 2º, inciso III da Lei n.º 10.220/01, os CONTRATADOS serão remunerados de "
                + "acordo com o Regulamento do Rodeio, ao qual previamente assinaram, restando-lhes garantidos " + ((etapa.dataFim - etapa.dataInicio).Days + 1) + "/30 (" + dcDias.FirstOrDefault(d => d.Key == (etapa.dataFim - etapa.dataInicio).Days + 1).Value + " trinta avos) do"
                + " salário vigente no País, a título de remuneração básica.");
            SendKeys.Send("{ENTER}");


            Paragraph pClausulaQuartaP1 = doc.InsertParagraph();
            pularLinhas(pClausulaQuartaP1, 1);
            pClausulaQuartaP1.Alignment = Alignment.both;
            insertAppendBold(pClausulaQuartaP1, "PARÁGRAFO PRIMEIRO");
            insertAppend(pClausulaQuartaP1, ". As demais formas e modos de pagamento dos valores referentes a prêmios, bonificações,"
                + " gratificações, luvas e outros, serão efetivamente pagos de acordo com as regras gerais do Rodeio a ser realizado na ");
            insertAppend(pClausulaQuartaP1, expecif.nomeFesta + " - " + etapa.numEtapa + "ª ETAPA DO CIRCUITO RANCHO PRIMAVERA.");
            SendKeys.Send("{ENTER}");

            Paragraph pClausulaQuartaP2 = doc.InsertParagraph();
            pularLinhas(pClausulaQuartaP2, 1);
            pClausulaQuartaP2.Alignment = Alignment.both;
            insertAppendBold(pClausulaQuartaP2, "PARÁGRAFO SEGUNDO");
            insertAppend(pClausulaQuartaP2, ". O ");
            insertAppendBold(pClausulaQuartaP2, "CONTRATADO");
            insertAppend(pClausulaQuartaP2, " deverá estar presente ao final do contrato para recebimento de seus haveres.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClasula5 = doc.InsertParagraph();
            pularLinhas(pTituloClasula5, 1);
            insertAppendBold(pTituloClasula5, "CLÁUSULA QUINTA");

            Paragraph pClausulaQuinta = doc.InsertParagraph();
            pClausulaQuinta.Alignment = Alignment.both;
            pClausulaQuinta.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaQuinta, "Ao ");
            insertAppendBold(pClausulaQuinta, "CONTRATADO");
            insertAppend(pClausulaQuinta, " será garantido Seguro de Vida e Invalidez, nos termos do artigo 2º, §§ 1º e 3º.");
            SendKeys.Send("{ENTER}");


            Paragraph pClausulaQuintaP1 = doc.InsertParagraph();
            pularLinhas(pClausulaQuintaP1, 1);
            pClausulaQuintaP1.Alignment = Alignment.both;
            insertAppendBold(pClausulaQuintaP1, "PARÁGRAFO ÚNICO");
            insertAppend(pClausulaQuintaP1, ". Serão disponibilizadas pela ");
            insertAppendBold(pClausulaQuintaP1, "CONTRATANTE");
            insertAppend(pClausulaQuintaP1, " após prévio comunicado e requerimento as autoridades competentes, a presença de apoio "
                + "médico-hospitalar, bem como veículo adequado para transporte de acidentados no local de realização das provas de Rodeio.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula6 = doc.InsertParagraph();
            pularLinhas(pTituloClausula6, 1);
            insertAppendBold(pTituloClausula6, "CLÁUSULA SEXTA");

            Paragraph pClausulaSexta = doc.InsertParagraph();
            pClausulaSexta.Alignment = Alignment.both;
            pClausulaSexta.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaSexta, "Nos locais de realização das provas de Rodeio, serão postos à disposição do ");
            insertAppendBold(pClausulaSexta, "CONTRATADO");
            insertAppend(pClausulaSexta, " locais de espera para a realização da atividade pelo qual foram contratados, sendo-lhe garantido espaço adequado para aquecimento, espera e estacionamento.");
            SendKeys.Send("{ENTER}");


            Paragraph ptituloClausula7 = doc.InsertParagraph();
            pularLinhas(ptituloClausula7, 1);
            insertAppendBold(ptituloClausula7, "CLÁUSULA SÉTIMA");

            Paragraph pClausulaSetima = doc.InsertParagraph();
            pClausulaSetima.Alignment = Alignment.both;
            pClausulaSetima.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaSetima, "O ");
            insertAppendBold(pClausulaSetima, "CONTRATADO");
            insertAppend(pClausulaSetima, " obriga-se a utilizar todos os materiais e equipamentos de segurança necessários para a "
                + "realização de suas funções à montaria, sob pena de incorrer em responsabilidade decorrente de eventuais acidentes.");
            SendKeys.Send("{ENTER}");


            Paragraph pClausulaSetimaP1 = doc.InsertParagraph();
            pularLinhas(pClausulaSetimaP1, 1);
            pClausulaSetimaP1.Alignment = Alignment.both;
            insertAppendBold(pClausulaSetimaP1, "PARÁGRAFO PRIMEIRO");
            insertAppend(pClausulaSetimaP1, "O ");
            insertAppendBold(pClausulaSetimaP1, "CONTRATADO");
            insertAppend(pClausulaSetimaP1, " que não utilizar os materiais e equipamentos de segurança necessários para "
                + "a realização de suas funções junto à montaria desobrigará a ");
            insertAppendBold(pClausulaSetimaP1, "CONTRATANTE ");
            insertAppend(pClausulaSetimaP1, "no tocante as despesas oriundas de eventuais acidentes, não restando ao mesmo à cobertura" +
                " do Seguro de Vida e Invalidez, previsto na Lei n.º 10.220/01, artigo 2º, §§ 1º e 3º.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula8 = doc.InsertParagraph();
            pularLinhas(pTituloClausula8, 1);
            insertAppendBold(pTituloClausula8, "CLÁUSULA OITAVA");

            Paragraph pClausulaOitava = doc.InsertParagraph();
            pClausulaOitava.Alignment = Alignment.both;
            pClausulaOitava.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaOitava, "O ");
            insertAppendBold(pClausulaOitava, "CONTRATADO ");
            insertAppend(pClausulaOitava, "obriga-se a não utilizar quaisquer objetos que venham a causar dor e/ou sofrimento às montarias,"
                + " sob pena de responder, administrativa, civil e penalmente pelos danos que causar aos animais, nos termos das legislações "
                + "vigentes, no tocante à proteção aos animais, estando ainda sujeito a rescisão unilateral do presente contrato e pagamento "
                + "de multa contratual, à base de 20% (vinte por cento) dos valores percebidos pelo ");
            insertAppendBold(pClausulaOitava, "CONTRATADO.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula9 = doc.InsertParagraph();
            pularLinhas(pTituloClausula9, 1);
            insertAppendBold(pTituloClausula9, "CLÁUSULA NONA");

            Paragraph pClausulaNona = doc.InsertParagraph();
            pClausulaNona.Alignment = Alignment.both;
            pClausulaNona.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaNona, "O ");
            insertAppendBold(pClausulaNona, "CONTRATADO ");
            insertAppend(pClausulaNona, "declara estar ciente a respeito das divulgações referentes as festividades e a realização das"
                + " provas de Rodeio, a realizarem-se na ");
            insertAppend(pClausulaNona, expecif.nomeFesta + " - " + etapa.numEtapa + "ª ETAPA DO CIRCUITO RANCHO PRIMAVERA,");
            insertAppend(pClausulaNona, " cedendo seu direito de imagem sem contrapartida a remunerações, restando autorizada a "
                + "divulgação, comerciais, apresentações, filmagens, reportagens e demais meios que caracterizem direito de imagem.");
            SendKeys.Send("{ENTER}");

            Paragraph pTituloClausula10 = doc.InsertParagraph();
            pularLinhas(pTituloClausula10, 1);
            insertAppendBold(pTituloClausula10, "CLÁUSULA DÉCIMA");

            Paragraph pClausulaDecima = doc.InsertParagraph();
            pClausulaDecima.Alignment = Alignment.both;
            pClausulaDecima.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDecima, "Em razão do tipo de evento “Festa do Peão de Boiadeiro”, não existe para o ");
            insertAppendBold(pClausulaDecima, " CONTRATADO ");
            insertAppend(pClausulaDecima, "jornada de trabalho diária a ser cumprida, por não estar o mesmo a disposição do ");
            insertAppendBold(pClausulaDecima, "CONTRATANTE");
            insertAppend(pClausulaDecima, ", devendo somente comparecer e se apresentar nas provas que estiver inscrito.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula11 = doc.InsertParagraph();
            pularLinhas(pTituloClausula11, 1);
            insertAppendBold(pTituloClausula11, "CLÁUSULA DÉCIMA-PRIMEIRA");

            Paragraph pClausulaDPrimeira = doc.InsertParagraph();
            pClausulaDPrimeira.Alignment = Alignment.both;
            pClausulaDPrimeira.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDPrimeira, "O ");
            insertAppendBold(pClausulaDPrimeira, "CONTRATADO ");
            insertAppend(pClausulaDPrimeira, " expressamente se declara cadastrado no INSS (Previdência Social), como Segurado"
                + " Facultativo ou Contribuinte Individual devidamente cadastrado no PIS, conforme Artigo 5º da IN 03/2005, ficando desde"
                + " já pactuada a CONTRATANTE a efetuar o recolhimento da Contribuição Previdenciária devidamente informando na GFIP"
                + " Lei Federal 10.666/2003, art. 4º e art. 5º, por meio de ");
            insertAppendBold(pClausulaDPrimeira, "R.P.A. (Recibo de Pagamento de Autônomo)");
            insertAppend(pClausulaDPrimeira, ", sobre o valor da remuneração básica estipulada na ");
            insertAppendBold(pClausulaDPrimeira, "CLÁUSULA QUARTA");
            insertAppend(pClausulaDPrimeira, " do contrato, que vier a receber dependendo do acordo firmado entre as partes sem retirar da premiação especificada.");
            SendKeys.Send("{ENTER}");

            Paragraph pTituloClausula12 = doc.InsertParagraph();
            pularLinhas(pTituloClausula12, 1);
            insertAppendBold(pTituloClausula12, "CLÁUSULA DÉCIMA-SEGUNDA");

            Paragraph pClausulaDSegunda = doc.InsertParagraph();
            pClausulaDSegunda.Alignment = Alignment.both;
            pClausulaDSegunda.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDSegunda, "O valor total bruto dos prêmios, a que, os peões estarão concorrendo serão de ");
            insertAppend(pClausulaDSegunda, "R$" + etapa.premio.ToString("0,000.00") + " (" + etapa.premio.toExtenso() + ")");
            insertAppend(pClausulaDSegunda, ", divididos entre os 10 (dez) primeiros colocados, dependendo de sua pontuação "
                + "diária e geral, computados através de planilha da ");
            insertAppendBold(pClausulaDSegunda, "CONTRATANTE.");
            SendKeys.Send("{ENTER}");


            Paragraph pTituloClausula13 = doc.InsertParagraph();
            pularLinhas(pTituloClausula13, 1);
            insertAppendBold(pTituloClausula13, "CLÁUSULA DÉCIMA TERCEIRA");


            Paragraph pClausulaDTerceira = doc.InsertParagraph();
            pClausulaDTerceira.Alignment = Alignment.both;
            pClausulaDTerceira.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDTerceira, "A ");
            insertAppendBold(pClausulaDTerceira, "CONTRATANTE");
            insertAppend(pClausulaDTerceira, " não poderá em hipótese alguma cobrar inscrições dos competidores, pois os "
                + "mesmos terão o direito de remuneração firmada na ");
            insertAppendBold(pClausulaDTerceira, "CLÁUSULA QUARTA");
            insertAppend(pClausulaDTerceira, ".");
            SendKeys.Send("{ENTER}");

            Paragraph pClausulaDTerceiraL2 = doc.InsertParagraph();
            pClausulaDTerceiraL2.Alignment = Alignment.both;
            pClausulaDTerceiraL2.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDTerceiraL2, "Nos termos do artigo 2º, inciso IV da Lei n.º 10.220/01, em caso de descumprimento e/ou "
                + "rompimento unilateral dos preceitos legais e/ou das cláusulas contratuais do presente termo, restará rescindido "
                + "o presente contrato, sujeitando-se ao causador da rescisão o pagamento de multa a título de cláusula penal, no "
                + "quantitativo de 20% do contrato.");
            SendKeys.Send("{ENTER}");

            Paragraph pTituloClausula14 = doc.InsertParagraph();
            pularLinhas(pTituloClausula14, 1);
            insertAppendBold(pTituloClausula14, "CLÁUSULA DÉCIMA QUARTA");

            //Tem que arrumar a cidade depois.
            Paragraph pClausulaDQuarta = doc.InsertParagraph();
            pClausulaDQuarta.Alignment = Alignment.both;
            pClausulaDQuarta.IndentationFirstLine = 4.109f;
            insertAppend(pClausulaDQuarta, "Fica eleito o foro da Comarca de Assis/SP, renunciando a qualquer outro, por mais privilegiado que seja, "
               + "para todas as ações e feitos judiciais decorrentes deste contrato.");
            SendKeys.Send("{ENTER}");

            Paragraph pclausulaDQuartaL2 = doc.InsertParagraph();
            pclausulaDQuartaL2.Alignment = Alignment.both;
            pclausulaDQuartaL2.IndentationFirstLine = 4.109f;
            insertAppend(pclausulaDQuartaL2, "E, por estarem justos e acordados, firmam as partes este contrato em duas vias, do mesmo teor e para um mesmo efeito, juntamente com as testemunhas abaixo que a tudo presenciaram.");
            SendKeys.Send("{ENTER}");

            Paragraph pData = doc.InsertParagraph();
            DateTime data = expecif.data; //Talvez essa data seja selecionada no contrato.
            pData.Alignment = Alignment.center;
            pularLinhas(pData, 3);
            insertAppend(pData, "Assis/SP, " + etapa.dataInicio.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(etapa.dataInicio.Month).FirstCharToUpper()
                + " de " + etapa.dataInicio.Year);

            Paragraph pAssinaturaContratante = doc.InsertParagraph();
            pAssinaturaContratante.Alignment = Alignment.center;

            pularLinhas(pAssinaturaContratante, 5);
            insertAppend(pAssinaturaContratante, "____________________________________");
            pularLinhas(pAssinaturaContratante, 1);
            insertAppendBold(pAssinaturaContratante, empresa.razaoSocial);
            pularLinhas(pAssinaturaContratante, 1);
            insertAppendBold(pAssinaturaContratante, "CONTRATANTE");

            Paragraph pAssinaturaContratado = doc.InsertParagraph();
            pAssinaturaContratado.Alignment = Alignment.center;
            pularLinhas(pAssinaturaContratado, 5);
            insertAppend(pAssinaturaContratado, "____________________________________");
            pularLinhas(pAssinaturaContratado, 1);
            insertAppendBold(pAssinaturaContratado, etapaCompetidor.competidor.nome);
            pularLinhas(pAssinaturaContratado, 1);
            insertAppendBold(pAssinaturaContratado, "CONTRATADO");
            doc.InsertParagraph().InsertPageBreakAfterSelf();
        }

        public static void geracaoContratoRpa(ExpecifContrato expecif, int etapaCompetidorID, DocX doc, bool segundaVia)
        {
            //ADICIONAR CEI NA EMPRESA
            SGCRPContexto contexto = new SGCRPContexto();
            EtapaCompetidor etapaCompetidor = contexto.EtapaCompetidor.Find(etapaCompetidorID);
            FontFamily font = new FontFamily("Arial");
            float valorINSS = expecif.valorServico * expecif.percINSS / 100;
            float valorLiquido = expecif.valorServico - valorINSS;

            Table t1 = doc.AddTable(4, 2);
            t1.SetColumnWidth(0, 6500);
            t1.SetColumnWidth(1, 3500);
            t1.Rows[0].Cells[0].Paragraphs.First().IndentationFirstLine = 0.4f;
            t1.Rows[1].Cells[0].Paragraphs.First().IndentationFirstLine = 0.4f;
            t1.Rows[2].Cells[0].Paragraphs.First().IndentationFirstLine = 0.4f;
            t1.Rows[3].Cells[0].Paragraphs.First().IndentationFirstLine = 0.4f;
            t1.Rows[0].Cells[0].Paragraphs.First().SetLineSpacing(Novacode.LineSpacingType.Before, 0.6f);
            t1.Rows[0].Cells[0].Paragraphs.First().Append("RECIBO DE PAGAMENTO A AUTÔNOMO – RPA").FontSize(11).Bold().Font(font);
            if (segundaVia)
                t1.Rows[1].Cells[0].Paragraphs.First().Append("2ª Via       ").FontSize(11).Bold().Alignment = Alignment.right;
            t1.Rows[2].Cells[0].Paragraphs.First().Append("Nome ou Razão Social da Empresa").FontSize(11).Bold().Font(font);
            t1.Rows[3].Cells[0].Paragraphs.First().Append(expecif.empresa.razaoSocial).FontSize(11).Font(font);
            t1.Rows[1].Cells[1].Paragraphs.First().Append("Mês : ").FontSize(11).Bold().Font(font)
                .Append(expecif.data.Month.ToString("00") + "/" + expecif.data.Year).FontSize(11).Font(font);
            t1.Rows[2].Cells[1].Paragraphs.First().Append("Matrícula (CNPJ/CEI)").FontSize(11).Bold().Font(font);
            t1.Rows[3].Cells[1].Paragraphs.First().Append(expecif.empresa.cnpj + "/0001-38").FontSize(11).Font(font);
            //Bordas da TABLE
            t1.Rows[0].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[0].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[3].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[3].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[0].Cells[1].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[0].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[1].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[1].Cells[1].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[1].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[2].Cells[1].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[3].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t1.Rows[3].Cells[1].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));

            doc.InsertTable(t1);


            Table t2 = doc.AddTable(1, 2);
            t2.SetColumnWidth(0, 4000);
            t2.SetColumnWidth(1, 6000);
            Paragraph t2p1 = t2.Rows[0].Cells[0].Paragraphs.First();
            t2p1.Append("  Nome Completo").FontSize(9).Bold().Font(font);
            t2p1.AppendLine("  " + etapaCompetidor.competidor.nome).FontSize(9).Font(font);
            t2p1.AppendLine();
            t2p1.AppendLine();
            t2p1.Append("  N° INSS/PIS:").FontSize(9).Bold().Font(font);
            t2p1.Append(etapaCompetidor.competidor.pis);
            Paragraph t2p2 = t2.Rows[0].Cells[1].Paragraphs.First();
            t2p2.Append("    Depto/Setor/Seção").FontSize(9).Bold().Font(font);
            t2p2.AppendLine("    0002/0000/0000 - PEOES AUTONOMOS").FontSize(9).Font(font);
            t2p2.AppendLine();
            t2p2.AppendLine();
            t2p2.Append("C.P.F.  ").FontSize(9).Bold().Font(font);
            t2p2.Append(etapaCompetidor.competidor.cpf);
            t2p2.Append("    RG/Orgão Emissor  ").FontSize(9).Bold().Font(font);
            t2p2.Append(etapaCompetidor.competidor.rg + "/").FontSize(9).Font(font);
            t2.Rows[0].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t2.Rows[0].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            doc.InsertTable(t2);

            Table t3 = doc.AddTable(2, 4);
            t3.SetColumnWidth(0, 1500);
            t3.SetColumnWidth(1, 3500);
            t3.SetColumnWidth(2, 2500);
            t3.SetColumnWidth(3, 2500);
            String[] t3Headers = { "CÓDIGO", "DESCRIÇÃO", "VALOR VENCIMENTO", "VALOR DESCONTO" };
            for (int i = 0; i < 4; i++)
            {
                t3.Rows[0].Cells[i].Paragraphs.First().Alignment = Alignment.center;
                t3.Rows[0].Cells[i].Paragraphs.First().Append(t3Headers[i]).FontSize(9).Bold().Font(font);
                t3.Rows[0].Cells[i].Paragraphs.First().SetLineSpacing(Novacode.LineSpacingType.Before, 0.2f);
                t3.Rows[1].Cells[i].Paragraphs.First().SetLineSpacing(LineSpacingType.Before, 0.2f);
            }
            t3.Rows[1].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            t3.Rows[1].Cells[0].Paragraphs.First().Append("4991").FontSize(9).Font(font);
            t3.Rows[1].Cells[0].Paragraphs.First().AppendLine("9860").FontSize(9).Font(font);
            t3.Rows[1].Cells[1].Paragraphs.First().Alignment = Alignment.left;
            t3.Rows[1].Cells[1].Paragraphs.First().Append("AUTONOMO CONTR. IN 87").FontSize(9).Font(font);
            t3.Rows[1].Cells[1].Paragraphs.First().AppendLine("I.N.S.S.").FontSize(9).Font(font);
            t3.Rows[1].Cells[2].Paragraphs.First().Alignment = Alignment.right;
            t3.Rows[1].Cells[2].Paragraphs.First().Append(expecif.valorServico.ToString("0.00")).FontSize(9).Font(font);
            t3.Rows[1].Cells[2].Paragraphs.First().AppendLine();
            t3.Rows[1].Cells[3].Paragraphs.First().Alignment = Alignment.right;
            t3.Rows[1].Cells[3].Paragraphs.First().AppendLine(valorINSS.ToString("0.00")).FontSize(9).Font(font);
            doc.InsertTable(t3);

            Table t4 = doc.AddTable(2, 5);
            t4.SetColumnWidth(0, 2000);
            t4.SetColumnWidth(1, 1500);
            t4.SetColumnWidth(2, 1500);
            t4.SetColumnWidth(3, 2500);
            t4.SetColumnWidth(4, 2500);
            for (int i = 0; i < 5; i++)
            {
                t4.Rows[0].Cells[i].Paragraphs.First().SetLineSpacing(LineSpacingType.Before, 0.2f);
                t4.Rows[1].Cells[i].Paragraphs.First().SetLineSpacing(LineSpacingType.Before, 0.2f);
            }
            t4.Rows[0].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[0].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[1].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[1].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[1].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[2].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[2].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[2].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[2].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[0].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[1].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[1].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[1].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[2].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[2].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[2].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[2].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[3].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[3].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[3].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[1].Cells[3].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t4.Rows[0].Cells[0].Paragraphs.First().Append("Base INSS Empresa").Bold().FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[0].Cells[1].Paragraphs.First().Append("Base INSS Segurado").Bold().FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[0].Cells[2].Paragraphs.First().Append("Total Parcial").Bold().FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[0].Cells[3].Paragraphs.First().Append(expecif.valorServico.ToString("0.00")).FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[0].Cells[4].Paragraphs.First().Append(valorINSS.ToString("0.00")).FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[1].Cells[0].Paragraphs.First().Append(expecif.valorServico.ToString("0.00")).FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[1].Cells[1].Paragraphs.First().Append(expecif.valorServico.ToString("0.00")).FontSize(9).Font(font).Alignment = Alignment.right;
            t4.Rows[1].Cells[3].Paragraphs.First().Append("Total").Font(font).FontSize(9).Bold().Alignment = Alignment.right;
            t4.Rows[1].Cells[4].Paragraphs.First().Append(valorLiquido.ToString("0.00")).FontSize(9).Font(font).Alignment = Alignment.right;
            doc.InsertTable(t4);
            Table t5 = doc.AddTable(1, 1);
            t5.SetColumnWidth(0, 10000);
            Paragraph paragraphT5 = t5.Rows[0].Cells[0].Paragraphs.First();
            paragraphT5.SetLineSpacing(LineSpacingType.Before, 0.2f);
            paragraphT5.Append(" Recebi da empresa acima identifica pela prestação dos servicos    " +
                expecif.etapa.cidade.nome.ToUpper() + "/" + expecif.etapa.cidade.uf.ToUpper()).Font(font).FontSize(9);
            paragraphT5.AppendLine(" a importância de R$   " + valorLiquido.ToString("0.00")).Font(font).FontSize(9);
            paragraphT5.AppendLine(" (" + valorLiquido.toExtenso()).Font(font).FontSize(9);
            paragraphT5.Append(")********************     Conforme Discriminativo Acima.").Font(font).FontSize(9);
            doc.InsertTable(t5);
            Table t6 = doc.AddTable(1, 2);
            t6.SetColumnWidth(0, 6000);
            t6.SetColumnWidth(1, 4000);
            t6.Rows[0].Cells[1].SetBorder(TableCellBorderType.Left, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t6.Rows[0].Cells[0].SetBorder(TableCellBorderType.Right, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            t6.Rows[0].Cells[0].Paragraphs.First().AppendLine().Append(expecif.nomeFesta).Font(font).FontSize(9);
            t6.Rows[0].Cells[0].Paragraphs.First().AppendLine().AppendLine(expecif.etapa.numEtapa + "ª ETAPA DO CIRCUITO RANCHO PRIMAVERA.").Font(font).FontSize(9);
            t6.Rows[0].Cells[1].Paragraphs.First().Append("ASSIS, " + expecif.etapa.dataFim.Day + " de "
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(expecif.data.Month).FirstCharToUpper()
                + " de " + expecif.data.Year).FontSize(9).Font(font);
            t6.Rows[0].Cells[1].Paragraphs.First().SetLineSpacing(LineSpacingType.Before, 0.2f);
            t6.Rows[0].Cells[1].Paragraphs.First().AppendLine().AppendLine("_____________________________________").Font(font).FontSize(9);
            Paragraph pT6 = t6.Rows[0].Cells[1].InsertParagraph();
            pT6.Alignment = Alignment.center;
            pT6.Append(etapaCompetidor.competidor.nome).Font(font).FontSize(9);
            doc.InsertTable(t6);
            // + expecif.etapa.numEtapa + "ª ETAPA DO CIRCUITO RANCHO PRIMAVERA.
            //Table t1 = doc.AddTable(1, 1);
            //t1.SetColumnWidth(0, 9000);
            //t1.Alignment = Alignment.center;
            //t1.Design = TableDesign.TableGrid;
            //t1.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            //t1.Rows[0].Cells[0].Paragraphs.First().Append("RECIBO DE PAGAMENTO A AUTÔNOMO – RPA").FontSize(12).Bold().Font(font);
            //doc.InsertTable(t1);
            //Paragraph p1 = doc.InsertParagraph();

            //Table t2 = doc.AddTable(2, 1);
            //t2.SetColumnWidth(0, 9000);
            //t2.Alignment = Alignment.center;
            //t2.Design = TableDesign.TableGrid;
            //t2.Rows[0].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            //t2.Rows[1].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            //t2.Rows[0].Cells[0].Paragraphs.First().Append("").FontSize(12).Font(font);
            //t2.Rows[1].Cells[0].Paragraphs.First().Alignment = Alignment.both;
            //t2.Rows[1].Cells[0].Paragraphs.First().IndentationFirstLine = 2;
            //t2.Rows[1].Cells[0].Paragraphs.First().SetLineSpacing(0, 1.5f);
            //t2.Rows[1].Cells[0].Paragraphs.First().Append("Recebi da(o) " + expecif.empresa.razaoSocial + ", CNPJ " + expecif.empresa.cnpj).FontSize(12).Font(font);
            ////Aqui é valor Servico - valor INSS
            //t2.Rows[1].Cells[0].Paragraphs.First().Append(", a importância líquida de R$" + valorLiquido.ToString("0.00")).FontSize(12).Font(font);
            //t2.Rows[1].Cells[0].Paragraphs.First().Append("(" + valorLiquido.toExtenso() + "), pela a prestação de serviços de: Peão de Rodeios.").FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //doc.InsertTable(t2);

            //Paragraph p2 = doc.InsertParagraph();

            //Table t3 = doc.AddTable(1, 1);
            //t3.SetColumnWidth(0, 9000);
            //t3.Alignment = Alignment.center;
            //t3.Design = TableDesign.TableGrid;
            //t3.Rows[0].Cells[0].Paragraphs.First().SetLineSpacing(0, 1.5f);
            //t3.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.left;
            //t3.Rows[0].Cells[0].Paragraphs.First().Append("Discriminação de valores para o pagamento dos serviços prestados:").FontSize(12).Font(font);
            //t3.Rows[0].Cells[0].Paragraphs.First().AppendLine();
            //t3.Rows[0].Cells[0].Paragraphs.First().Append("Valor Bruto R$" + expecif.valorServico).FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //t3.Rows[0].Cells[0].Paragraphs.First().AppendLine();
            //t3.Rows[0].Cells[0].Paragraphs.First().Append("Desconto INSS (" + expecif.percINSS + "% x " + expecif.valorServico.ToString("0.00") + ") R$" + (expecif.valorServico / (expecif.percINSS / 100))).Font(font).FontSize(12);
            //SendKeys.Send("{ENTER}");
            //t3.Rows[0].Cells[0].Paragraphs.First().AppendLine();
            //t3.Rows[0].Cells[0].Paragraphs.First().Append("Valor Líquido R$" + valorLiquido.ToString("0.00")).Font(font).FontSize(12);
            //SendKeys.Send("{ENTER}");
            //doc.InsertTable(t3);

            //Paragraph p3 = doc.InsertParagraph();

            //int qtdLinhaT4 = 6;
            //Table t4 = doc.AddTable(qtdLinhaT4, 1);
            //t4.SetColumnWidth(0, 9000);
            //t4.Alignment = Alignment.center;
            //t4.Design = TableDesign.TableGrid;
            //for (int i = 0; i < qtdLinhaT4; i++)
            //{
            //    t4.Rows[i].Cells[0].Paragraphs.First().SetLineSpacing(0, 1.5f);
            //    t4.Rows[i].Cells[0].Paragraphs.First().Alignment = Alignment.both;
            //    if (i != 0)
            //        t4.Rows[i].Cells[0].SetBorder(TableCellBorderType.Top, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            //    if (qtdLinhaT4 != i + 1)
            //        t4.Rows[i].Cells[0].SetBorder(TableCellBorderType.Bottom, new Border(Novacode.BorderStyle.Tcbs_none, 0, 0, Color.Black));
            //}
            //t4.Rows[0].Cells[0].Paragraphs.First().Append("Nome completo: " + etapaCompetidor.competidor.nome).FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //t4.Rows[1].Cells[0].Paragraphs.First().Append("Inscrição Municipal: " + etapaCompetidor.competidor.inscricaoMunicipal).FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //t4.Rows[2].Cells[0].Paragraphs.First().Append("CPF: " + etapaCompetidor.competidor.cpf).FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //t4.Rows[3].Cells[0].Paragraphs.First().Append("C.I.: " + etapaCompetidor.competidor.rg + " Órgão Emissor: " + etapaCompetidor.competidor.orgEmissor).FontSize(12).Font(font);
            //SendKeys.Send("{ENTER}");
            //t4.Rows[4].Cells[0].Paragraphs.First().Append("Nº do PIS:" + etapaCompetidor.competidor.pis + " Data: " + etapaCompetidor.competidor.nascimento.Day + "/" + etapaCompetidor.competidor.nascimento.Month + "/" + etapaCompetidor.competidor.nascimento.Year).Font(font).FontSize(12);
            //SendKeys.Send("{ENTER}");
            //t4.Rows[5].Cells[0].Paragraphs.First().Append("Endereço: " + etapaCompetidor.competidor.rua + " " + etapaCompetidor.competidor.num + " - " + etapaCompetidor.competidor.cidade.nome + " - " + etapaCompetidor.competidor.cidade.uf).Font(font).FontSize(12);
            //doc.InsertTable(t4);

            //Paragraph p4 = doc.InsertParagraph();
            //Table t5 = doc.AddTable(1, 1);
            doc.InsertParagraph().InsertPageBreakAfterSelf();
        }

        public static void insertAppendBold(Paragraph paragraph, string texto)
        {
            paragraph.Append(texto).Bold().Font(new FontFamily("Arial"));
        }

        public static void insertAppend(Paragraph paragraph, string texto)
        {
            paragraph.Append(texto).Font(new FontFamily("Arial"));
        }

        public static void insertAppend(Paragraph paragraph, string texto, bool pularLinha)
        {
            paragraph.Append(texto).AppendLine().Font(new FontFamily("Arial"));
        }
    }
}
