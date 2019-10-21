using OfficeOpenXml;
using OfficeOpenXml.Style;
using SGAP.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Funcoes
{
    public class Relatorios
    {
        public static void prazoFornecedor()
        {
            SGAPContexto contexto = new SGAPContexto();
            string folder = @"c:\Relatórios";
            string arquivo = @"C:\Relatórios\Prazo Fornecedores " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            try
            {
                if (File.Exists(arquivo))
                {
                    File.Delete(arquivo);
                }


                List<Andamento> lstAndamentos = new List<Andamento>();

                lstAndamentos = contexto.Andamento.Where(x => x.Atendimento.dataEncerramento == null).OrderBy(x => x.prazo).ToList();

                FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
                ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);

                ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");

                planilha.Cells["A1"].Value = "RELATÓRIOS DE PRAZOS DE FORNECEDORES (ATENDIMENTOS ATIVOS)";
                planilha.Cells["A1"].Style.Font.Bold = true;
                planilha.Cells["A1"].Style.Font.Size = 14;
                planilha.Row(1).Height = 32;
                planilha.Cells["A1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                planilha.Cells["A1:A2"].Style.Font.Color.SetColor(Color.FromArgb(0, 112, 192));

                planilha.Cells["A2"].Value = "Período: " + DateTime.Now.ToShortDateString();
                planilha.View.ShowGridLines = false;

                int linha = 3;
                int coluna = 1;

                //INSERINDO VALORES NA PRIMEIRA LINHA
                planilha.Cells[++linha, coluna].Value = "PRAZO";
                planilha.Cells[linha, ++coluna].Value = "DESCRIÇÃO";
                planilha.Cells[linha, ++coluna].Value = "NÚMERO ATENDIMENTO";
                planilha.Cells[linha, ++coluna].Value = "DATA INSERÇÃO";

                planilha.Cells["A4:D4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                planilha.Cells["A4:D4"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(128, 128, 128));

                //DEFININDO COR DA FONTE
                planilha.Cells["A4:D4"].Style.Font.Color.SetColor(Color.FromArgb(255, 255, 255));

                //DEFININDO NEGRITO
                planilha.Cells["A4:D4"].Style.Font.Bold = true;

                foreach (Andamento andamento in lstAndamentos)
                {
                    planilha.Cells[++linha, coluna = 1].Value = andamento.prazo;
                    planilha.Cells[linha, ++coluna].Value = andamento.descricao;
                    planilha.Cells[linha, ++coluna].Value = andamento.Atendimento.numeroProcon;
                    planilha.Cells[linha, ++coluna].Value = andamento.data;
                }

                planilha.Cells["A4:D" + linha].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                planilha.Cells["A4:D" + linha].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                planilha.Cells["A4:D" + linha].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                planilha.Cells["A4:D" + linha].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                if (linha < 5)
                    linha = 5;

                //CENTRALIZANDO
                planilha.Cells["A4:D4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                planilha.Cells["A5:A" + linha].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                planilha.Cells["C5:D" + linha].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                //TRATANDO FORMATO DE CELULA
                planilha.Cells["A5:A" + linha].Style.Numberformat.Format = "dd/MM/yyyy";
                planilha.Cells["D5:D" + linha].Style.Numberformat.Format = "dd/MM/yyyy";

                //CODIGOS FINAIS
                planilha.Cells[planilha.Dimension.Address].AutoFitColumns();
                planilha.Column(1).Width = 23;


                arquivoExcel.Save();
                arquivoExcel.Dispose();

                System.Diagnostics.Process.Start(arquivo);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Arquivo existente aberto. Feche e tente gerar novamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
