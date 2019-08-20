using SGCRP.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Relatorios
{
    public partial class frmMostrarNota : Form
    {
        public frmMostrarNota()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public frmMostrarNota(object dados)
        {
            InitializeComponent();
            relMostrarNotas relMostrar = new relMostrarNotas();
            relMostrar.SetDataSource(dados);
            crvNotas.ReportSource = relMostrar;
        }
    }
}
