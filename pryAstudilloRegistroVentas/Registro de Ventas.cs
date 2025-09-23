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
            LimpiarControles();
        }

        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {


            lstProducto.Items.Add("Gabinete");
            lstProducto.Items.Add("cpu");
            lstProducto.Items.Add("ram");

            nudCantidad.Enabled = false;
            mtbPrecioUnitario.Enabled = false;
            btnRegistrar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void nudCantidad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vFecha = dtpFecha.Value;
            vProducto = lstProducto.Text;
           
            //Mostrar resultados
            lstRegistro.Items.Add("Fecha:" + " " + dtpFecha.Text);
            lstRegistro.Items.Add("Producto:" + " " + lstProducto.SelectedItem);
            lstRegistro.Items.Add("Cantidad:" + " " + nudCantidad.Value);
            lstRegistro.Items.Add("Precio:$" + " " + mtbPrecioUnitario.Text + "\n");

        }
        private void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Now;
            lstProducto.SelectedIndex = -1;
            nudCantidad.Value = 0;
            nudCantidad.Enabled = false;
            mtbPrecioUnitario.Clear();
            mtbPrecioUnitario.Enabled = false;
            btnRegistrar.Enabled = false;
            lstProducto.Focus();
        }
    }
}
