using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.ReajusteDados
{
    public partial class frmReajusteCidade : Form
    {
        public frmReajusteCidade()
        {
            InitializeComponent();
        }

        private void frmReajusteCidade_Load(object sender, EventArgs e)
        {
            cmbCidadeRecebe.DisplayMember = "getCidadeID";
            cmbCidadeRecebe.ValueMember = "id";
            cmbCidadeRemove.DisplayMember = "getCidadeID";
            cmbCidadeRemove.ValueMember = "id";
            atualizarcmb();
        }

        private void atualizarcmb()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbCidadeRemove.DataSource = contexto.Cidade.OrderBy(c => c.id).ToList();
            cmbCidadeRecebe.DataSource = contexto.Cidade.OrderBy(c => c.id).ToList();
        }

        private void btnRelCidades_Click(object sender, EventArgs e)
        {
            Funcoes.Relatorios.relCidadesIguais();
        }

        private void btnRealizarAcao_Click(object sender, EventArgs e)
        {
            if (cmbCidadeRecebe.SelectedIndex != -1 && cmbCidadeRemove.SelectedIndex != -1)
            {
                int idCidadeRecebe = Convert.ToInt32(cmbCidadeRecebe.SelectedValue);
                int idCidadeRemove = Convert.ToInt32(cmbCidadeRemove.SelectedValue);
                if (idCidadeRecebe != idCidadeRemove)
                {
                    Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                    string texto = "Você tem certeza que deseja remover a cidade " + contexto.Cidade.Find(idCidadeRemove).nome + " e passar seus dados para a cidade " + contexto.Cidade.Find(idCidadeRecebe).nome;
                    if (DialogResult.Yes == MessageBox.Show(texto, "Realizar Ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        realizarReajuste(idCidadeRecebe, idCidadeRemove);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível realzar o reajuste em cidades de ID iguais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void realizarReajuste(int idCidadeRecebe, int idCidadeRemove)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Cidade cidadeRem = contexto.Cidade.Find(idCidadeRemove);
            foreach (int idTropeiro in cidadeRem.tropeiros.Select(c => c.id))
            {
                Modelo.Tropeiro tropeiro = contexto.Tropeiro.Find(idTropeiro);
                tropeiro.cidadeID = idCidadeRecebe;
                contexto.Entry(tropeiro).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            foreach (int idCompetidor in cidadeRem.competidores.ToList().Select(c => c.id))
            {
                Modelo.Competidor competidor = contexto.Competidor.Find(idCompetidor);
                competidor.cidadeID = idCidadeRecebe;
                contexto.Entry(competidor).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            foreach (int idProfissonais in cidadeRem.profissonais.ToList().Select(c => c.id))
            {
                Modelo.Profissonal profissonal = contexto.Profissonal.Find(idProfissonais);
                profissonal.cidadeID = idCidadeRecebe;
                contexto.Entry(profissonal).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            foreach (int idPatrocinadores in cidadeRem.patrocinadores.ToList().Select(c => c.id))
            {
                Modelo.Patrocinador patrocinador = contexto.Patrocinador.Find(idPatrocinadores);
                patrocinador.cidadeID = idCidadeRecebe;
                contexto.Entry(patrocinador).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            foreach (int idEmpresa in cidadeRem.empresas.ToList().Select(c => c.id))
            {
                Modelo.Empresa empresa = contexto.Empresa.Find(idEmpresa);
                empresa.cidadeID = idCidadeRecebe;
                contexto.Entry(empresa).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            foreach (int idEtapa in cidadeRem.etapas.ToList().Select(c => c.id))
            {
                Modelo.Etapa etapa = contexto.Etapa.Find(idEtapa);
                etapa.cidadeID = idCidadeRecebe;
                contexto.Entry(etapa).State = System.Data.Entity.EntityState.Modified;
            }
            contexto.SaveChanges();
            contexto.Cidade.Remove(cidadeRem);
            contexto.SaveChanges();
            MessageBox.Show("Cidade reajustada!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            atualizarcmb();   
        }
    }
}
