using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCRP.Forms.Telao
{
    public partial class frmRankingTelao : Component
    {
        public frmRankingTelao()
        {
            InitializeComponent();
        }

        public frmRankingTelao(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
