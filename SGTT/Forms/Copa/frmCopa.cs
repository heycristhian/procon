using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Copa
{
    public partial class frmCopa : Form
    {

        char op = 'x';

        public frmCopa()
        {
            InitializeComponent();
        }

        private void frmCopa_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd/MM/yyyy";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "dd/MM/yyyy";
            cmbCampeonato.DisplayMember = "nome";
            cmbCampeonato.ValueMember = "id";
            cmbCampeonato.DataSource = contexto.Campeonato.OrderByDescending(c => c.favorito).ThenByDescending(c => c.dataInicio).ToList();
            cmbEtapaFinal.DisplayMember = "etapaNome";
            cmbEtapaFinal.ValueMember = "id";
            carregarGridGeral();
            habilitarCampos(false);
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
        }

        private void habilitarCampos(bool status)
        {
            txtNomeCopa.Enabled = status;
            txtPremio.Enabled = status;
            cmbCampeonato.Enabled = status;
            cmbEtapaFinal.Enabled = status;
            dtpInicio.Enabled = status;
            dtpFim.Enabled = status;
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            dgvCopa.Enabled = !status;
            if (op != 'E')
            {
                lblID.Text = "";
                txtNomeCopa.Text = "";
                txtPremio.Text = "";
                cmbCampeonato.SelectedIndex = -1;
                dtpInicio.Value = DateTime.Today;
                dtpFim.Value = DateTime.Today;
                cmbEtapaFinal.SelectedIndex = -1;
            }
        }

        private void carregarGridGeral()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            carregarGrid(contexto.Copa.OrderByDescending(t => t.dataInicio).ToList());
        }

        private void carregarGrid(List<Modelo.Copa> lstCopa)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            var dados = (from c in lstCopa
                         select new
                         {
                             id = c.id,
                             Nome = c.descr,
                             Campeonato = c.campeonato.nome,
                             Inicio = c.dataInicio,
                             Fim = c.dataFim
                         }).ToList();
            dgvCopa.DataSource = dados;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            op = 'I';
            habilitarCampos(true);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            op = 'X';
            habilitarCampos(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "")
            {
                op = 'E';
                habilitarCampos(true);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Copa copa = this.op == 'I' ? getCopa(new Modelo.Copa()) : getCopa(contexto.Copa.Find(Convert.ToInt32(lblID.Text)));
                if (op == 'I')
                    contexto.Copa.Add(copa);
                else
                    contexto.Entry(copa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                lblID.Text = copa.id.ToString();
                op = 'E';
                habilitarCampos(false);
                op = 'X';
                carregarGridGeral();
            }
        }

        private Modelo.Copa getCopa(Modelo.Copa copa)
        {
            copa.descr = txtNomeCopa.Text;
            copa.campeonatoID = Convert.ToInt32(cmbCampeonato.SelectedValue);
            copa.dataInicio = dtpInicio.Value;
            copa.dataFim = dtpFim.Value;
            copa.premio = Convert.ToSingle(txtPremio.Text.Replace("R$", ""));
            if (cmbEtapaFinal.SelectedIndex > -1)
            {
                copa.copaEtapaFinalID = Convert.ToInt32(cmbEtapaFinal.SelectedValue);
            }
            else
            {
                copa.copaEtapaFinalID = null;
            }
            return copa;
        }

        private void setCopa(Modelo.Copa copa)
        {
            lblID.Text = copa.id.ToString();
            txtNomeCopa.Text = copa.descr;
            cmbCampeonato.SelectedValue = copa.campeonatoID;
            dtpInicio.Value = copa.dataInicio;
            dtpFim.Value = copa.dataFim;
            cmbEtapaFinal.DataSource = copa.copaEtapas.OrderBy(t => t.etapaNome).ToList();
            txtPremio.Text = copa.premio.ToString("R$ #,##0.00");
            if (copa.copaEtapaFinalID != null)
            {
                cmbEtapaFinal.SelectedValue = copa.copaEtapaFinalID;
            }
            else
            {
                cmbEtapaFinal.SelectedIndex = -1;
            }
        }

        private bool verificarCampos()
        {
            if (txtNomeCopa.Text == "")
            {
                MessageBox.Show("Existe campos obrigatórios em branco!", "O nome da copa é um campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCopa.Focus();
                return false;
            }
            else
            {
                if (cmbCampeonato.SelectedIndex < 0)
                {
                    MessageBox.Show("Existe campos obrigatórios em branco", "O campo Campeonato é obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCampeonato.Focus();
                    return false;
                }
                else if (txtPremio.Text == "")
                {
                    MessageBox.Show("Existe campos obrigatórios em branco", "O campo Prêmio é obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPremio.Focus();
                    return false;
                }
            }
            return true;
        }

        private void dgvCopa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCopa.SelectedRows.Count > 0)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                setCopa(contexto.Copa.Find(Convert.ToInt32(dgvCopa.SelectedRows[0].Cells["id"].Value)));
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Precisa fazer if's de verificação antes
            if (lblID.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Você realmente deseja remover esta copa?", "Remover Copa", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                    contexto.Copa.Remove(contexto.Copa.Find(Convert.ToInt32(lblID.Text)));
                    contexto.SaveChanges();
                    op = 'X';
                    carregarGridGeral();
                    habilitarCampos(false);
                }
            }
        }

        private void txtPremio_Leave(object sender, EventArgs e)
        {
            float premio;
            if (float.TryParse(txtPremio.Text.Replace("R$", ""), out premio))
            {
                txtPremio.Text = premio.ToString("R$ #,##0.00");
            }
            else
            {
                txtPremio.Text = "";
            }
        }
    }
}
