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

        struct RegistroVentas
        {
            public DateTime Fecha;
            public string Producto;
            public int Cantidad;
            public int PrecioUnitario;
            
        }
        
        RegistroVentas[] vectorVentas = new RegistroVentas[10];
        int indice = 0;
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
            if (lstProducto.SelectedIndex == -1 || nudCantidad.Value == 0 || mtbPrecioUnitario.Text == "")
            {
                MessageBox.Show("Faltan completar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indice >= 10)
            {
                MessageBox.Show("El vector de ventas está completo (10 registros).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            vectorVentas[indice].Fecha = dtpFecha.Value;
            vectorVentas[indice].Producto = lstProducto.Text;
            vectorVentas[indice].Cantidad = Convert.ToInt32(nudCantidad.Value);
            int precioUnitario;
            if (int.TryParse(mtbPrecioUnitario.Text.Trim(), out precioUnitario))
            {
                vectorVentas[indice].PrecioUnitario = precioUnitario;
            }
            else
            {
                MessageBox.Show("Ingrese un precio unitario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            lblResultado.Text +=
                vectorVentas[indice].Fecha.ToShortDateString() + " - " +
                vectorVentas[indice].Producto + " | " +
                "Cantidad: " + vectorVentas[indice].Cantidad + " | " +
                "Precio: $" + vectorVentas[indice].PrecioUnitario + "\n";


            indice++;

            LimpiarControles();

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
