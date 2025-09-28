namespace simulador
{
    partial class FormMantenimientoClientes
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
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblTitulo = new Label();
            txtNombre = new TextBox();
            lblNomre = new Label();
            txtPrimerApellido = new TextBox();
            lblPrimerApellido = new Label();
            txtSegundoApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtDireccion = new TextBox();
            lblDirreccion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtPais = new TextBox();
            lblPAis = new Label();
            cmbTipoMant = new ComboBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(58, 99);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(59, 23);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(123, 96);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(311, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(134, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Mantenimiento Clientes";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(123, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNomre
            // 
            lblNomre.Location = new Point(58, 152);
            lblNomre.Name = "lblNomre";
            lblNomre.Size = new Size(59, 23);
            lblNomre.TabIndex = 3;
            lblNomre.Text = "Nombre";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(123, 204);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(100, 23);
            txtPrimerApellido.TabIndex = 6;
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.Location = new Point(23, 204);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(94, 23);
            lblPrimerApellido.TabIndex = 5;
            lblPrimerApellido.Text = "Pirmer Apellido";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(123, 259);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(100, 23);
            txtSegundoApellido.TabIndex = 8;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.Location = new Point(23, 262);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(200, 23);
            lblSegundoApellido.TabIndex = 7;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(327, 259);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 16;
            // 
            // lblDirreccion
            // 
            lblDirreccion.Location = new Point(262, 262);
            lblDirreccion.Name = "lblDirreccion";
            lblDirreccion.Size = new Size(59, 23);
            lblDirreccion.TabIndex = 15;
            lblDirreccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(327, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 14;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(262, 207);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 23);
            lblTelefono.TabIndex = 13;
            lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(327, 149);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 12;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(262, 152);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(59, 23);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(327, 96);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(100, 23);
            txtPais.TabIndex = 10;
            // 
            // lblPAis
            // 
            lblPAis.Location = new Point(262, 99);
            lblPAis.Name = "lblPAis";
            lblPAis.Size = new Size(59, 23);
            lblPAis.TabIndex = 9;
            lblPAis.Text = "Pais";
            // 
            // cmbTipoMant
            // 
            cmbTipoMant.FormattingEnabled = true;
            cmbTipoMant.Items.AddRange(new object[] { "Nuevo Cliente", "Editar Cliente", "Eliminar Cliente" });
            cmbTipoMant.Location = new Point(479, 96);
            cmbTipoMant.Name = "cmbTipoMant";
            cmbTipoMant.Size = new Size(121, 23);
            cmbTipoMant.TabIndex = 17;
            cmbTipoMant.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(483, 155);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormMantenimientoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(cmbTipoMant);
            Controls.Add(txtDireccion);
            Controls.Add(lblDirreccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtPais);
            Controls.Add(lblPAis);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNomre);
            Controls.Add(lblTitulo);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Name = "FormMantenimientoClientes";
            Text = " ";
            Load += FormMantenimientoClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblTitulo;
        private TextBox txtNombre;
        private Label lblNomre;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtDireccion;
        private Label lblDirreccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtPais;
        private Label lblPAis;
        private ComboBox cmbTipoMant;
        private Button btnAceptar;
    }
}