using Entities;
using GestorJSON;
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
    public partial class FormCompraProductos : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        public FormCompraProductos()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            txtFecha.Text = today.ToString("yyyy-MM-dd");
        }

        private void FormCompraProductos_Load(object sender, EventArgs e)
        {

        }
        private List<object> GenerarLista()
        {
            CompraProductoJSON compraProdcutosJSON = new CompraProductoJSON();

            // Crear la lista
            List<object> list = new List<object>();

            // Agregar el contenido de los TextBox
            list.Add(txtNumCompra.Text);
            list.Add(txtFecha.Text);
            list.Add(txtCedulaJudirica.Text);



            //list.Add(txtCantidadProducto.Text);
            //list.Add(txtCodigoProducto.Text);
            compraProdcutosJSON.GenerarJSON(list, listaProductos);



            return list;
        }
        private void AgregarProductosLista()
        {

            String codigo_producto = txtCodigoProducto.Text;
            int cantidad = int.Parse(txtCantidadProducto.Text);

            Producto producto = new Producto(cantidad, codigo_producto);

            listaProductos.Add(producto);
        }

        private void btnAgregarProdcuto_Click(object sender, EventArgs e)
        {
            AgregarProductosLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarLista();  
        }
    }
}
