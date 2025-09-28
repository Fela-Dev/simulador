
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using GestorJSON;
namespace simulador
{
    public partial class FormRegistroVenta : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        public FormRegistroVenta()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            txtFecha.Text = today.ToString("yyyy-MM-dd");
        }

        private void lblNumCompra_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistroVenta_Load(object sender, EventArgs e)
        {

        }
        private List<object> GenerarLista()
        {
            RegistroVentaJSON registroVentaJSON = new RegistroVentaJSON();

            // Crear la lista
            List<object> list = new List<object>();

            // Agregar el contenido de los TextBox
            list.Add(txtIdcliente.Text);

            list.Add(txtNumCompra.Text);
            list.Add(txtFecha.Text);


            list.Add(txtNumTarjeta.Text);
            list.Add(txtFechaVenci.Text);
            list.Add(txtCodigoTarjeta.Text);
            list.Add(txtTotal.Text);

            //list.Add(txtCantidadProducto.Text);
            //list.Add(txtCodigoProducto.Text);
            registroVentaJSON.GenerarJSON(list,listaProductos);
            


            return list;
        }
        private void AgregarProductosLista()
        {

            String codigo_producto = txtCodigoProducto.Text;
            int cantidad = int.Parse(txtCantidadProducto.Text);

            Producto producto = new Producto(cantidad, codigo_producto);

            listaProductos.Add(producto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarLista();
        }

        private void txtFechaVenci_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoTarjeta.Text.Length == 2 && !txtCodigoTarjeta.Text.Contains("/"))
            {
                txtCodigoTarjeta.Text += "/";
                txtCodigoTarjeta.SelectionStart = txtCodigoTarjeta.Text.Length;
            }
        }

        private void btnAgregarProdcuto_Click(object sender, EventArgs e)
        {
            AgregarProductosLista();
        }
    }
}
