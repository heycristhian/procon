using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Forms
{
    public partial class frmRelatorioMensalAtividades : Form
    {
        public string inicio { get; set; }
        public string final { get; set; }

        public frmRelatorioMensalAtividades()
        {
            InitializeComponent();
        }

        private void frmRelatorioMensalAtividades_Load(object sender, EventArgs e)
        {
            inicio = DateTime.Now.AddDays(-(DateTime.Now.Day - 1)).ToString("dd-MM-yyyy");
            final = DateTime.Now.AddDays(-(DateTime.Now.Day - 1)).AddMonths(1).AddDays(-1).ToString("dd-MM-yyyy");
            mtbDataInicial.Text = inicio;
            mtbDataFinal.Text = final;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string folder = @"c:\Relatórios";
            string arquivo = @"C:\Relatórios\Atividade Mensal (" + inicio + " - " + final + ").xlsx";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (File.Exists(arquivo))
            {
                //Fazer tratamento
                File.Delete(arquivo);
            }

            FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);

            int linha = 0;
            int coluna = 1;
            int contador = 0;

            // CRIANDO (ADD) uma planilha neste arquivo e obtendo a referência para meu código operá-la.
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");

            planilha.Cells[++linha, coluna].Value = "ITEM";
            planilha.Cells[linha, ++coluna].Value = "DESCRIÇÃO";
            planilha.Cells[linha, ++coluna].Value = "ALIMENTOS";
            planilha.Cells[linha, ++coluna].Value = "SAÚDE";
            planilha.Cells[linha, ++coluna].Value = "HABITAÇÃO";
            planilha.Cells[linha, ++coluna].Value = "PRODUTOS";
            planilha.Cells[linha, ++coluna].Value = "SERVIÇOS PRIVADOS";
            planilha.Cells[linha, ++coluna].Value = "SERVIÇOS ESSENCIAIS";
            planilha.Cells[linha, ++coluna].Value = "ASSUNTOS FINANCEIROS";
            planilha.Cells[linha, ++coluna].Value = "TOTAL";

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Simples Consulta";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Atendimento Preliminar";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "CIPs emitidas";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "CIPs finalizadas com acordo";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "CIPs finalizadas com outras baixas (encerradas, canceladas, consulta concluída";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Reclamações abertas no retorno da CIP (CIPs finalizadas com \"Abertura de reclamação\")";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Reclamações abertas sem emissão de CIP";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Reclamações finalizadas como Atendidas";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;


            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Reclamações finalizadas como NÃO Atendidas";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;


            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Reclamações finalizadas com outras baixas (encerradas, consulta fornecida)";
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Extra Procon";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = (++contador).ToString("D2");
            planilha.Cells[linha, ++coluna].Value = "Nota Fiscal Paulista";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            planilha.Cells[++linha, coluna = 1].Value = "Total Geral";
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = null;
            planilha.Cells[linha, ++coluna].Value = 0;

            arquivoExcel.Save();
            arquivoExcel.Dispose();

            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
