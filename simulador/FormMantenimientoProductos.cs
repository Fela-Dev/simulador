using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulador
{
    public partial class FormMantenimientoProductos : Form
    {

        int tipoMant;
        public FormMantenimientoProductos()
        {
            InitializeComponent();
            cmbTipoMant.SelectedIndex = 0;
            tipoMant = 1;
        }

        private void FormMantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoMant_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 
             * 
             * 
             * Nuevo Producto
                Editar Producto
            */

            String chose = cmbTipoMant.Text;

            if (chose == "Nuevo Producto")
            {
                tipoMant = 1;
            }
            else if (chose == "Editar Producto")
            {
                tipoMant = 2;
            }

        }
        private List<object> generLista()
        {
            decimal precio = decimal.Parse(txtPrecio.Text);

            
            int valorEntero = (int)(precio * 100);

          
            string precioFormateado = valorEntero.ToString().PadLeft(8, '0'); ;//rellena con ceros

            List<object> datosCliente = new List<object>();
            datosCliente.Add(tipoMant);
            datosCliente.Add(txtNumero.Text);
            datosCliente.Add(txtNombre.Text);
            datosCliente.Add(precioFormateado);




            return datosCliente;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorJSON.ProductoJSON archivoProducto = new GestorJSON.ProductoJSON();
                archivoProducto.GenerarJson(generLista());

                // Código principal aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
