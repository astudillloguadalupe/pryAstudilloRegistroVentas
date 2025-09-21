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

        DateTime vFecha = DateTime.Now;
        string vProducto = "";
        int vCantidad = 0;
        int vPrecio = 0;


        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducto.SelectedIndex == -1)
            {
                nudCantidad.Enabled = false;
            }
            else
            {
                nudCantidad.Enabled = true;
            }
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
            if (nudCantidad.Value == 0)
            {
                mtbPrecioUnitario.Enabled = false;
            }
            else
            {
                mtbPrecioUnitario.Enabled = true;
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
            if (MessageBox.Show("¿Está seguro que desea cancelar?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstProducto.SelectedIndex = -1;
                nudCantidad.Value = 0;
                mtbPrecioUnitario.Clear();
                mtbPrecioUnitario.Enabled = false;
                nudCantidad.Enabled = false;
                dtpFecha.Value = DateTime.Now;
                lstProducto.Focus();
            }
           
        }

        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {


            lstProducto.Items.Add("GABINETE");
            lstProducto.Items.Add("CPU");
            lstProducto.Items.Add("RAM");

            nudCantidad.Enabled = false;
            mtbPrecioUnitario.Enabled = false;
            
        }

        private void nudCantidad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = lstProducto.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);

            lblResultado.Text +=
                 vFecha + " " + vProducto
                 + " " + "Cantidad: " + vCantidad + " " + "$" + vPrecio + "\n";
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Now;
            lstProducto.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecioUnitario.Text = "";

            lstProducto.Focus();
        }
    }
}
