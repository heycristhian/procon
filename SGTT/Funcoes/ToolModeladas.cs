using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Funcoes
{
    static public class ToolModeladas
    {
        static public void dgvTransformation (DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromName("Control");
            dgv.BorderStyle = BorderStyle.None; //0 = none
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         // dgv.ColumnHeadersDefaultCellStyle. = DataGridViewColumnSortMode.NotSortable;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromName("ActiveCaption");
            dgv.AutoGenerateColumns = false;
            dgv.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
