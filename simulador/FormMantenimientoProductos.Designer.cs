namespace simulador
{
    partial class FormMantenimientoProductos
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
            btnAceptar = new Button();
            cmbTipoMant = new ComboBox();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNomre = new Label();
            lblTitulo = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(469, 162);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTipoMant
            // 
            cmbTipoMant.FormattingEnabled = true;
            cmbTipoMant.Items.AddRange(new object[] { "Nuevo Producto", "Editar Producto" });
            cmbTipoMant.Location = new Point(465, 103);
            cmbTipoMant.Name = "cmbTipoMant";
            cmbTipoMant.Size = new Size(121, 23);
            cmbTipoMant.TabIndex = 28;
            cmbTipoMant.SelectedIndexChanged += cmbTipoMant_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(306, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 27;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(241, 109);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 23);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 23;
            // 
            // lblNomre
            // 
            lblNomre.Location = new Point(44, 159);
            lblNomre.Name = "lblNomre";
            lblNomre.Size = new Size(59, 23);
            lblNomre.TabIndex = 22;
            lblNomre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(297, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 15);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Mantenimiento Productos";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(109, 103);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 20;
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(44, 106);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(59, 23);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Numero";
            // 
            // FormMantenimientoProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(cmbTipoMant);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblNomre);
            Controls.Add(lblTitulo);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "FormMantenimientoProductos";
            Text = "FormMantenimientoProductos";
            Load += FormMantenimientoProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private ComboBox cmbTipoMant;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNomre;
        private Label lblTitulo;
        private TextBox txtNumero;
        private Label lblNumero;
    }
}