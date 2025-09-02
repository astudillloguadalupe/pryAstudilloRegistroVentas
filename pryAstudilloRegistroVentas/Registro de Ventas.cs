using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloRegistroVentas
{
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                mtbPrecioUnitario.Enabled = true;
            }
            else
            {
                mtbPrecioUnitario.Enabled = false;
            }

        }
        private void mtbPrecioUnitario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
              if (mtbPrecioUnitario.Text != "")
              {
                btnRegistrar.Enabled = true;
              }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
