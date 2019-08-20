using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Funcoes
{
    public class OrderListView : IComparer
    {
        private int coluna;

        public OrderListView(int coluna)
        {
            this.coluna = coluna;
        }

        public int Compare(object x, object y)
        {
            ListViewItem listX = (ListViewItem)x;
            ListViewItem listY = (ListViewItem)y;

            // Convert column text to numbers before comparing.
            // If the conversion fails, just use the value 0.
            decimal listXVal, listYVal;
            try
            {
                listXVal = Decimal.Parse(listX.SubItems[coluna].Text);
            }
            catch
            {
                listXVal = 0;
            }

            try
            {
                listYVal = Decimal.Parse(listY.SubItems[coluna].Text);
            }
            catch
            {
                listYVal = 0;
            }

            return (Decimal.Compare(listXVal, listYVal));
        }
    }
}
