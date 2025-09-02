namespace pryAstudilloRegistroVentas
{
    partial class frmRegistroVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            lstProducto = new ComboBox();
            mtbPrecioUnitario = new MaskedTextBox();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(32, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(32, 100);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(33, 159);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(32, 210);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(289, 249);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(164, 49);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 6;
            // 
            // lstProducto
            // 
            lstProducto.Enabled = false;
            lstProducto.FormattingEnabled = true;
            lstProducto.Items.AddRange(new object[] { "hola ", "chau " });
            lstProducto.Location = new Point(164, 95);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(121, 23);
            lstProducto.TabIndex = 7;
            lstProducto.SelectedIndexChanged += lstProducto_SelectedIndexChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Location = new Point(164, 202);
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(100, 23);
            mtbPrecioUnitario.TabIndex = 8;
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(164, 154);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(38, 23);
            nudCantidad.TabIndex = 9;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // frmRegistroVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 284);
            Controls.Add(nudCantidad);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(lstProducto);
            Controls.Add(dtpFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmRegistroVentas";
            Text = "Registro_de_Ventas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Button btnCancelar;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private ComboBox lstProducto;
        private MaskedTextBox mtbPrecioUnitario;
        private NumericUpDown nudCantidad;
    }
}