using SGAP.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SGAP.Modelo;


namespace SGAP.Forms
{
    public partial class frmPesquisaEntidade : Form
    {
        frmAtendimento atendimento = new frmAtendimento();
        public string entidade { get; set; }

        public frmPesquisaEntidade()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmPesquisaEntidade(frmAtendimento frmAtendimento, string tipoEntidade)
        {
            InitializeComponent();
            atendimento = frmAtendimento;
            entidade = tipoEntidade;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if(entidade == "consumidor")
            {
                lblTitulo.Text = "Pesquisar consumidor";
            }
            else if(entidade == "fornecedor")
            {
                lblTitulo.Text = "Pesquisar fornecedor";
            }
        }

        private void PesquisaEntidade_Load(object sender, EventArgs e)
        {
            carregaGrid();
            ToolModeladas.dgvTransformation(dgvEntidade);

            this.dgvEntidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void carregaGrid()
        {
            if(entidade == "consumidor")
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                var dados = from form in contexto.Consumidor.OrderBy(x => x.nome)
                            select new
                            {
                                id = form.id,
                                nome = form.nome,
                                cnpjCpf = form.cpf
                            };
                dgvEntidade.DataSource = dados.ToList();
            }
            else if(entidade == "fornecedor")
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                var dados = from form in contexto.Fornecedor.OrderBy(x => x.razaoSocial)
                            select new
                            {
                                id = form.id,
                                nome = form.razaoSocial,
                                cnpjCpf = form.cnpj
                            };

                dgvEntidade.DataSource = dados.ToList();
            }
            
        }

        private void carregaGrid(string condicao)
        {
            if (entidade == "consumidor")
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                var dados = from form in contexto.Consumidor.ToList().Where(p => (p.nome.ToLower().RemoveDiacritics().Contains(condicao.ToLower().RemoveDiacritics().Trim()) || p.cpf.Contains(condicao.ToLower().RemoveDiacritics().Trim())))
                            select new
                            {
                                id = form.id,
                                nome = form.nome,
                                cnpjCpf = form.cpf
                            };
                dgvEntidade.DataSource = dados.ToList();
            }
            else if (entidade == "fornecedor")
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                var dados = from form in contexto.Fornecedor.ToList().Where(p => (p.razaoSocial.ToLower().RemoveDiacritics().Contains(condicao.ToLower().RemoveDiacritics().Trim()) || p.cnpj.Contains(condicao.ToLower().RemoveDiacritics().Trim())))
                            select new
                            {
                                id = form.id,
                                nome = form.razaoSocial,
                                cnpjCpf = form.cnpj
                            };

                dgvEntidade.DataSource = dados.ToList();
            }

        }

        private void dgvEntidade_DoubleClick(object sender, EventArgs e)
        {
            atendimento.idCombo = Convert.ToInt32(dgvEntidade.SelectedRows[0].Cells["id"].Value);
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            carregaGrid(txtPesquisar.Text);
            
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            carregaGrid(txtPesquisar.Text);
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            carregaGrid(txtPesquisar.Text);
        }
    }
}
