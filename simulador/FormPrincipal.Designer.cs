namespace simulador
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoClientesToolStripMenuItem = new ToolStripMenuItem();
            registroVentaToolStripMenuItem = new ToolStripMenuItem();
            mantToolStripMenuItem = new ToolStripMenuItem();
            ingresoProductosAlmacenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, ingresoProductosAlmacenToolStripMenuItem, registroVentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mantenimientoClientesToolStripMenuItem, mantToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(106, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoClientesToolStripMenuItem
            // 
            mantenimientoClientesToolStripMenuItem.Name = "mantenimientoClientesToolStripMenuItem";
            mantenimientoClientesToolStripMenuItem.Size = new Size(218, 22);
            mantenimientoClientesToolStripMenuItem.Text = "Mantenimiento Clientes";
            mantenimientoClientesToolStripMenuItem.Click += mantenimientoClientesToolStripMenuItem_Click;
            // 
            // registroVentaToolStripMenuItem
            // 
            registroVentaToolStripMenuItem.Name = "registroVentaToolStripMenuItem";
            registroVentaToolStripMenuItem.Size = new Size(94, 20);
            registroVentaToolStripMenuItem.Text = "Registro Venta";
            registroVentaToolStripMenuItem.Click += registroVentaToolStripMenuItem_Click;
            // 
            // mantToolStripMenuItem
            // 
            mantToolStripMenuItem.Name = "mantToolStripMenuItem";
            mantToolStripMenuItem.Size = new Size(218, 22);
            mantToolStripMenuItem.Text = "Mantenimiento Provedores";
            mantToolStripMenuItem.Click += mantToolStripMenuItem_Click;
            // 
            // ingresoProductosAlmacenToolStripMenuItem
            // 
            ingresoProductosAlmacenToolStripMenuItem.Name = "ingresoProductosAlmacenToolStripMenuItem";
            ingresoProductosAlmacenToolStripMenuItem.Size = new Size(173, 20);
            ingresoProductosAlmacenToolStripMenuItem.Text = "Ingreso Productos (Almacen)";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoClientesToolStripMenuItem;
        private ToolStripMenuItem registroVentaToolStripMenuItem;
        private ToolStripMenuItem mantToolStripMenuItem;
        private ToolStripMenuItem ingresoProductosAlmacenToolStripMenuItem;
    }
}
