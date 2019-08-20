using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.GoldCowboy
{
    public partial class frmGoldTipo : Form
    {
        private int roundID;
        

        public frmGoldTipo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            roundID = cmbTipoRound.SelectedIndex;
            this.Close();
        }

        public int getRoundID()
        {
            return this.roundID;
        }
    }
}
