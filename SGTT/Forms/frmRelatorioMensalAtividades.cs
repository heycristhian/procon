using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Forms
{
    public partial class frmRelatorioMensalAtividades : Form
    {
        public frmRelatorioMensalAtividades()
        {
            InitializeComponent();
        }

        private void frmRelatorioMensalAtividades_Load(object sender, EventArgs e)
        {
            label1.Size = new System.Drawing.Size(8, 8);
        }
    }
}
