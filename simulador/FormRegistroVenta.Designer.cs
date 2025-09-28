
namespace simulador
{
    partial class FormRegistroVenta
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
            lblTitulo = new Label();
            lblNumCompra = new Label();
            label3 = new Label();
            txtNumCompra = new TextBox();
            txtFecha = new TextBox();
            lblFecha = new Label();
            txtIdcliente = new TextBox();
            lblIdentificadorCliente = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtNumTarjeta = new TextBox();
            lblNumTarjeta = new Label();
            txtFechaVenci = new TextBox();
            lblFechaVencimiento = new Label();
            txtCodigoTarjeta = new TextBox();
            lblCodigoTarjeta = new Label();
            txtCantidadProducto = new TextBox();
            lblCantidadProducto = new Label();
            txtCodigoProducto = new TextBox();
            lblCodigoProducto = new Label();
            button1 = new Button();
            lblRegistro = new Label();
            btnAgregarProdcuto = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(300, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Nueva Venta";
            // 
            // lblNumCompra
            // 
            lblNumCompra.AutoSize = true;
            lblNumCompra.Location = new Point(12, 111);
            lblNumCompra.Name = "lblNumCompra";
            lblNumCompra.Size = new Size(113, 15);
            lblNumCompra.TabIndex = 1;
            lblNumCompra.Text = "Numero de Compra";
            lblNumCompra.Click += lblNumCompra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 196);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtNumCompra
            // 
            txtNumCompra.Location = new Point(164, 108);
            txtNumCompra.Name = "txtNumCompra";
            txtNumCompra.Size = new Size(100, 23);
            txtNumCompra.TabIndex = 3;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(164, 244);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(34, 247);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha de Compra";
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(164, 176);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(100, 23);
            txtIdcliente.TabIndex = 7;
            // 
            // lblIdentificadorCliente
            // 
            lblIdentificadorCliente.AutoSize = true;
            lblIdentificadorCliente.Location = new Point(34, 179);
            lblIdentificadorCliente.Name = "lblIdentificadorCliente";
            lblIdentificadorCliente.Size = new Size(84, 15);
            lblIdentificadorCliente.TabIndex = 6;
            lblIdentificadorCliente.Text = "Cedula Cliente";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(741, 241);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 9;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(622, 244);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(95, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total de Compra";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.Location = new Point(416, 111);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(100, 23);
            txtNumTarjeta.TabIndex = 11;
            // 
            // lblNumTarjeta
            // 
            lblNumTarjeta.AutoSize = true;
            lblNumTarjeta.Location = new Point(281, 111);
            lblNumTarjeta.Name = "lblNumTarjeta";
            lblNumTarjeta.Size = new Size(105, 15);
            lblNumTarjeta.TabIndex = 10;
            lblNumTarjeta.Text = "Numero de Tarjeta";
            // 
            // txtFechaVenci
            // 
            txtFechaVenci.Location = new Point(416, 173);
            txtFechaVenci.Name = "txtFechaVenci";
            txtFechaVenci.Size = new Size(100, 23);
            txtFechaVenci.TabIndex = 13;
            txtFechaVenci.TextChanged += txtFechaVenci_TextChanged;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(281, 173);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(107, 15);
            lblFechaVencimiento.TabIndex = 12;
            lblFechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // txtCodigoTarjeta
            // 
            txtCodigoTarjeta.Location = new Point(416, 244);
            txtCodigoTarjeta.Name = "txtCodigoTarjeta";
            txtCodigoTarjeta.Size = new Size(100, 23);
            txtCodigoTarjeta.TabIndex = 15;
            // 
            // lblCodigoTarjeta
            // 
            lblCodigoTarjeta.AutoSize = true;
            lblCodigoTarjeta.Location = new Point(281, 244);
            lblCodigoTarjeta.Name = "lblCodigoTarjeta";
            lblCodigoTarjeta.Size = new Size(100, 15);
            lblCodigoTarjeta.TabIndex = 14;
            lblCodigoTarjeta.Text = "Codigo de Tarjeta";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(741, 179);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(100, 23);
            txtCantidadProducto.TabIndex = 19;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.Location = new Point(622, 182);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(116, 15);
            lblCantidadProducto.TabIndex = 18;
            lblCantidadProducto.Text = "Catidad de Producto";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(741, 108);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(100, 23);
            txtCodigoProducto.TabIndex = 17;
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Location = new Point(622, 111);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(114, 15);
            lblCodigoProducto.TabIndex = 16;
            lblCodigoProducto.Text = "Codigo de Producto";
            // 
            // button1
            // 
            button1.Location = new Point(335, 311);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 20;
            button1.Text = "Confirmar Compra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(902, 108);
            lblRegistro.MaximumSize = new Size(100, 100);
            lblRegistro.MinimumSize = new Size(125, 250);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(125, 250);
            lblRegistro.TabIndex = 21;
            lblRegistro.Text = "    Prodcutos Compra";
            // 
            // btnAgregarProdcuto
            // 
            btnAgregarProdcuto.Location = new Point(705, 283);
            btnAgregarProdcuto.Name = "btnAgregarProdcuto";
            btnAgregarProdcuto.Size = new Size(136, 23);
            btnAgregarProdcuto.TabIndex = 22;
            btnAgregarProdcuto.Text = "Agregar Productos";
            btnAgregarProdcuto.UseVisualStyleBackColor = true;
            btnAgregarProdcuto.Click += btnAgregarProdcuto_Click;
            // 
            // FormRegistroVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 478);
            Controls.Add(btnAgregarProdcuto);
            Controls.Add(lblRegistro);
            Controls.Add(button1);
            Controls.Add(txtCantidadProducto);
            Controls.Add(lblCantidadProducto);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblCodigoProducto);
            Controls.Add(txtCodigoTarjeta);
            Controls.Add(lblCodigoTarjeta);
            Controls.Add(txtFechaVenci);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(txtNumTarjeta);
            Controls.Add(lblNumTarjeta);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtIdcliente);
            Controls.Add(lblIdentificadorCliente);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtNumCompra);
            Controls.Add(label3);
            Controls.Add(lblNumCompra);
            Controls.Add(lblTitulo);
            Name = "FormRegistroVenta";
            Text = "FormRegistroVenta";
            Load += FormRegistroVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumCompra;
        private Label label3;
        private TextBox txtNumCompra;
        private TextBox txtFecha;
        private Label lblFecha;
        private TextBox txtIdcliente;
        private Label lblIdentificadorCliente;
        private TextBox txtTotal;
        private Label lblTotal;
        private TextBox txtNumTarjeta;
        private Label lblNumTarjeta;
        private TextBox txtFechaVenci;
        private Label lblFechaVencimiento;
        private TextBox txtCodigoTarjeta;
        private Label lblCodigoTarjeta;
        private TextBox txtCantidadProducto;
        private Label lblCantidadProducto;
        private TextBox txtCodigoProducto;
        private Label lblCodigoProducto;
        private Button button1;
        private Label lblRegistro;
        private Button btnAgregarProdcuto;
    }
}