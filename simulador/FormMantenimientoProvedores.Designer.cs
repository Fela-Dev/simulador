namespace simulador
{
    partial class FormMantenimientoProvedores
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
            txtNombreContacto = new TextBox();
            lblNombreContacto = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            lblEstado = new Label();
            txtNombre = new TextBox();
            lblNomre = new Label();
            lblTitulo = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            cmbEstado = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(507, 173);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 37;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTipoMant
            // 
            cmbTipoMant.FormattingEnabled = true;
            cmbTipoMant.Items.AddRange(new object[] { "Nuevo Provedor", "Editar Provedor" });
            cmbTipoMant.Location = new Point(503, 114);
            cmbTipoMant.Name = "cmbTipoMant";
            cmbTipoMant.Size = new Size(121, 23);
            cmbTipoMant.TabIndex = 36;
            cmbTipoMant.SelectedIndexChanged += cmbTipoMant_SelectedIndexChanged;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(369, 114);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(121, 23);
            txtNombreContacto.TabIndex = 35;
            txtNombreContacto.TextChanged += txtDireccion_TextChanged;
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.Location = new Point(269, 114);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(181, 23);
            lblNombreContacto.TabIndex = 34;
            lblNombreContacto.Text = "Nombre Contacto";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(147, 277);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 33;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(82, 280);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 23);
            lblTelefono.TabIndex = 32;
            lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(147, 222);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 31;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(82, 225);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(59, 23);
            lblCorreo.TabIndex = 30;
            lblCorreo.Text = "Correo";
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(269, 174);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(94, 23);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 167);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 23;
            // 
            // lblNomre
            // 
            lblNomre.Location = new Point(82, 170);
            lblNomre.Name = "lblNomre";
            lblNomre.Size = new Size(59, 23);
            lblNomre.TabIndex = 22;
            lblNomre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(335, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 15);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Mantenimiento Provedores";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(147, 114);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 20;
            // 
            // lblCedula
            // 
            lblCedula.Location = new Point(82, 117);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(59, 23);
            lblCedula.TabIndex = 19;
            lblCedula.Text = "Cedula";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(369, 167);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 38;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // FormMantenimientoProvedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEstado);
            Controls.Add(btnAceptar);
            Controls.Add(cmbTipoMant);
            Controls.Add(txtNombreContacto);
            Controls.Add(lblNombreContacto);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(lblEstado);
            Controls.Add(txtNombre);
            Controls.Add(lblNomre);
            Controls.Add(lblTitulo);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Name = "FormMantenimientoProvedores";
            Text = "FormMantenimientoProvedores";
            Load += FormMantenimientoProvedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private ComboBox cmbTipoMant;
        private TextBox txtNombreContacto;
        private Label lblNombreContacto;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Label lblEstado;
        private TextBox txtNombre;
        private Label lblNomre;
        private Label lblTitulo;
        private TextBox txtCedula;
        private Label lblCedula;
        private ComboBox cmbEstado;
    }
}