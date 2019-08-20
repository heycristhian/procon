using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Notas
{
    public partial class frmNotasMobiles : Form
    {
        int idMontaria;
        List<Modelo.Equipe> lstEquipe;

        public frmNotasMobiles(int idMontaria, List<Modelo.Equipe> lstEquipe)
        {
            InitializeComponent();
            this.idMontaria = idMontaria;
            this.lstEquipe = lstEquipe;
        }

        private void frmNotasMobiles_Load(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void atualizarLista()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            List<Modelo.Mobile.NotaMobile> lstNotaMobile = new List<Modelo.Mobile.NotaMobile>();
            lstNotaMobile = contexto.NotaMobile.Where(m => m.montariaID == this.idMontaria).OrderBy(t => t.profissionalLogin.profissional.apelido).ToList();
            dgvNotaMobile.DataSource = (from nota in lstNotaMobile
                         select new
                         {
                             juiz = lstEquipe.First(p => nota.profissionalLogin.profissonalID == p.profissonalID).profissonal.apelido,
                             notaTouro = nota.notaTouro.ToString("0.00"),
                             notaCompetidor = nota.notaCompetidor.ToString("0.00"),
                             repete = nota.repete ? "Sim" : "Não",
                             situacao = nota.status == 1 ? "Aguardando Notas" : "Nota Recebidas"
                         }).ToList();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizarLista();
        }
    }
}
