namespace simulador
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoClientes formClientes = new FormMantenimientoClientes();

            this.Hide();
            formClientes.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registroVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroVenta formRegistro = new FormRegistroVenta();
            this.Hide();
            formRegistro.ShowDialog();
            this.Show();
        }

        private void mantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoProvedores formMantenimientoProvedores = new FormMantenimientoProvedores();
            this.Hide();
            formMantenimientoProvedores.ShowDialog();
            this.Show();
        }

        private void ingresoProductosAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompraProductos formCompraProductos = new FormCompraProductos();
            this.Hide();
            formCompraProductos.ShowDialog();
            this.Show();


        }

        private void mantenimientoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoProductos formMantenimientoProductos = new FormMantenimientoProductos();
            this.Hide();
            formMantenimientoProductos.ShowDialog();
            this.Show();
        }
    }
}
