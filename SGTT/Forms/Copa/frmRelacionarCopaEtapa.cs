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
    public partial class frmRelacionarCopaEtapa : Form
    {
        public frmRelacionarCopaEtapa()
        {
            InitializeComponent();
        }

        private void frmRelacionarCopaEtapa_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbCampeonato.ValueMember = "id";
            cmbCampeonato.DisplayMember = "nome";
            cmbCopa.ValueMember = "id";
            cmbCopa.DisplayMember = "descr";
            lsbEtapaCopa.DisplayMember = "etapaNome";
            lsbEtapaCopa.ValueMember = "id";
            lsbEtapa.DisplayMember = "descrEtapa";
            lsbEtapa.ValueMember = "id";
            cmbCampeonato.DataSource = contexto.Campeonato.OrderByDescending(c => c.favorito).ThenByDescending(c => c.dataInicio).ToList();

            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
        }

        private void cmbCampeonato_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCampeonato.SelectedIndex > -1)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                int campID = Convert.ToInt32(cmbCampeonato.SelectedValue);
                cmbCopa.DataSource = contexto.Copa.Where(t => t.campeonatoID == campID).OrderByDescending(t => t.dataFim).ToList();
                cmbCopa.SelectedIndex = -1;
            }
         
        }

        private void visualizarCampos(bool status)
        {
            lsbEtapa.Visible = status;
            lsbEtapaCopa.Visible = status;
            btnAdicionar.Visible = status;
            btnRemover.Visible = status;
            lblEtapa.Visible = status;
            lblCopa.Visible = status;
        }

        private void carregarLsb()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            List<Modelo.CopaEtapa> lstCopaEtapas = contexto.Copa.Find(Convert.ToInt32(cmbCopa.SelectedValue)).copaEtapas.OrderByDescending(t => t.etapa.dataInicio).ToList();
            lsbEtapaCopa.DataSource = lstCopaEtapas;
            List<Modelo.Etapa> lstEtapa = contexto.Campeonato.Find(Convert.ToInt32(cmbCampeonato.SelectedValue)).etapa.OrderByDescending(t => t.dataInicio).ToList();
            for (int i = 0; i < lstCopaEtapas.Count; i++)
            {
                lstEtapa.Remove(lstCopaEtapas[i].etapa);
            }
            lsbEtapa.DataSource = lstEtapa;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.CopaEtapa copaEtapa = new Modelo.CopaEtapa();
            copaEtapa.copaID = Convert.ToInt32(cmbCopa.SelectedValue);
            copaEtapa.etapaID = Convert.ToInt32(lsbEtapa.SelectedValue);
            copaEtapa.calcPontos = true;
            contexto.CopaEtapa.Add(copaEtapa);
            contexto.SaveChanges();
            carregarLsb();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.CopaEtapa copaEtapa = contexto.CopaEtapa.Find(Convert.ToInt32(lsbEtapaCopa.SelectedValue));
            contexto.CopaEtapa.Remove(copaEtapa);
            contexto.SaveChanges();
            carregarLsb();
        }

        private void cmbCopa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCopa.SelectedIndex > -1)
            {
                visualizarCampos(true);
                carregarLsb();
            }
            else
            {
                visualizarCampos(false);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
