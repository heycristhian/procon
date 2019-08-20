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
    public partial class PremioCopa : Form
    {
        public PremioCopa()
        {
            InitializeComponent();
        }

        private void PremioCopa_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbCampeonato.ValueMember = "id";
            cmbCampeonato.DisplayMember = "nome";
            cmbCopa.ValueMember = "id";
            cmbCopa.DisplayMember = "descr";
            cmbCampeonato.DataSource = contexto.Campeonato.OrderByDescending(c => c.favorito).ThenByDescending(c => c.dataInicio).ToList();

            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
        }

        private void visualizarCampos(bool status)
        {
            lblPremiacao.Visible = status;
            txtPremiacao.Visible = status;
            btnGerar.Visible = status;
            dgvPremiacao.Visible = status;
            btnAplicar.Visible = status;
            btnRemoverPremio.Visible = status;
        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Copa copa = contexto.Copa.Find(Convert.ToInt32(cmbCopa.SelectedValue));
            bool verifCopa = true;
            int qtdPremios;
            if (int.TryParse(txtPremiacao.Text, out qtdPremios))
            {
                if (qtdPremios >= 0)
                {
                    List<Modelo.PremioCopa> lstPremioCopa = copa.premioCopa.ToList();
                    if (lstPremioCopa.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Você realmente deseja gerar novas premiações? Premiações antigas serão removidas!", "Gerar Novas Premiações", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {

                            for (int i = 0; i < lstPremioCopa.Count; i++)
                            {
                                Modelo.PremioCopa premioCopa = contexto.PremioCopa.Find(lstPremioCopa[i].id);
                                contexto.PremioCopa.Remove(premioCopa);
                                contexto.SaveChanges();
                            }
                        }
                        else
                            verifCopa = false;
                    }
                    if (verifCopa)
                    {
                        for (int i = 0; i < qtdPremios; i++)
                        {
                            Modelo.PremioCopa premioCopa = new Modelo.PremioCopa();
                            premioCopa.ordem = i + 1;
                            premioCopa.copaID = copa.id;
                            premioCopa.premio = 0;
                            contexto.PremioCopa.Add(premioCopa);
                        }
                        contexto.SaveChanges();
                        carregarCampos();
                    }
                }
                else {
                    MessageBox.Show("É necessário que a quantidade seja positiva!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPremiacao.Text = copa.premioCopa.Count.ToString();
                    txtPremiacao.Focus();
                }
            }
            else {
                MessageBox.Show("Valor inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPremiacao.Text = copa.premioCopa.Count.ToString();
                txtPremiacao.Focus();
            }
        }

        private void carregarCampos()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Copa copa = contexto.Copa.Find(Convert.ToInt32(cmbCopa.SelectedValue));
            List<Modelo.PremioCopa> lstPremioCopa = copa.premioCopa.OrderBy(t => t.ordem).ToList();
            txtPremiacao.Text = lstPremioCopa.Count.ToString();
            if (lstPremioCopa.Count > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Ordem");
                dt.Columns.Add("Premio");
                dt.Columns.Add("Ganhador");
                for (int i = 0; i < lstPremioCopa.Count; i++)
                {
                    dt.Rows.Add(lstPremioCopa[i].ordem, "R$" + lstPremioCopa[i].premio.ToString("0.00"), (lstPremioCopa[i].campeonatoCompetidorID == null ? "" : lstPremioCopa[i].campeonatoCompetidor.competidor.apelido));
                }
                dgvPremiacao.DataSource = dt;
            }
            else
            {
                dgvPremiacao.DataSource = null;
            }
            if (lstPremioCopa.FirstOrDefault(t => t.campeonatoCompetidorID != null) != null)
            {
                btnAplicar.Enabled = false;
                btnRemoverPremio.Enabled = true;
                btnGerar.Enabled = false;
            }
            else
            {
                btnAplicar.Enabled = true;
                btnRemoverPremio.Enabled = false;
                btnGerar.Enabled = true;
            }
        }

        private void cmbCampeonato_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCampeonato.SelectedIndex > -1)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                cmbCopa.DataSource = contexto.Campeonato.Find(Convert.ToInt32(cmbCampeonato.SelectedValue)).copas.OrderByDescending(t => t.dataInicio).ToList();
            }
        }

        private void cmbCopa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCopa.SelectedIndex > -1)
            {
                carregarCampos();
                visualizarCampos(true);
            }
            else
            {
                visualizarCampos(false);
            }
        }

        private void dgvPremiacao_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            mudarPremio(e);
        }

        private void mudarPremio(DataGridViewCellEventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            int ordem = Convert.ToInt32(dgvPremiacao["ordem", e.RowIndex].Value);
            int copaID = Convert.ToInt32(cmbCopa.SelectedValue);
            Modelo.PremioCopa premioCopa = contexto.PremioCopa.FirstOrDefault(p => p.copaID == copaID && p.ordem == ordem);
            float novoPremio;
            if (float.TryParse(dgvPremiacao["premio", e.RowIndex].Value.ToString().Replace("R", "").Replace("$", "").Replace(" ", ""), out novoPremio))
            {
                premioCopa.premio = novoPremio;
                contexto.Entry(premioCopa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                dgvPremiacao["premio", e.RowIndex].Value = "R$" + novoPremio.ToString("0.00");
            }
            else
            {
                dgvPremiacao["premio", e.RowIndex].Value = "R$" + premioCopa.premio.ToString("0.00");
            }
        }

        private void dgvPremiacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Copa copa = contexto.Copa.Find(Convert.ToInt32(cmbCopa.SelectedValue));
            List<Modelo.CopaCompetidor> lstCopaCompetidor = copa.getCompetidores(true); //Este método já traz os competidores ordenado pela a pontuação total
            List<Modelo.PremioCopa> lstPremioCopa = copa.premioCopa.OrderBy(t => t.ordem).ToList();
            for (int i = 0; i < lstPremioCopa.Count && i < lstCopaCompetidor.Count; i++)
            {
                Modelo.PremioCopa premioCopa = contexto.PremioCopa.Find(lstPremioCopa[i].id);
                premioCopa.campeonatoCompetidorID = lstCopaCompetidor[i].campeonatoCompetidorID;
                Modelo.CampeonatoCompetidor campeonatoCompetidor = contexto.CampeonatoCompetidor.Find(lstCopaCompetidor[i].campeonatoCompetidorID);
                campeonatoCompetidor.totalPremio += premioCopa.premio;
                contexto.Entry(premioCopa).State = System.Data.Entity.EntityState.Modified;
                contexto.Entry(campeonatoCompetidor).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
            Funcoes.Relatorios.relPremioCopa(copa.id);
            carregarCampos();
        }

        private void removerPremios()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Copa copa = contexto.Copa.Find(Convert.ToInt32(cmbCopa.SelectedValue));
            List<Modelo.PremioCopa> lstPremioCopa = copa.premioCopa.OrderBy(t => t.ordem).ToList();
            for (int i = 0; i < lstPremioCopa.Count; i++)
            {
                if (lstPremioCopa[i].campeonatoCompetidorID != null)
                {
                    Modelo.PremioCopa premioCopa = contexto.PremioCopa.Find(lstPremioCopa[i].id);
                    Modelo.CampeonatoCompetidor campeonatoCompetidor = contexto.CampeonatoCompetidor.Find(premioCopa.campeonatoCompetidorID);
                    premioCopa.campeonatoCompetidorID = null;
                    campeonatoCompetidor.totalPremio -= premioCopa.premio;
                    contexto.Entry(campeonatoCompetidor).State = System.Data.Entity.EntityState.Modified;
                    contexto.Entry(premioCopa).State = System.Data.Entity.EntityState.Modified;
                    contexto.Entry(premioCopa);
                    contexto.SaveChanges();
                }
            }
            carregarCampos();
            MessageBox.Show("Premiação Removida dos Competidores", "Prêmios Removidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemoverPremio_Click(object sender, EventArgs e)
        {
            removerPremios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
