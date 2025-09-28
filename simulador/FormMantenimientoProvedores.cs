using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using GestorJSON;
namespace simulador
{
    public partial class FormMantenimientoProvedores : Form
    {
        int tipoMant;
        String estado;
        public FormMantenimientoProvedores()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            cmbTipoMant.SelectedIndex = 0;
            tipoMant = 6;
            estado = "1";

        }

        private void FormMantenimientoProvedores_Load(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {


        }
        private List<object> generar_lista()
        {
            List<Object> datosProvedor = new List<object>();
            datosProvedor.Add(tipoMant);
            datosProvedor.Add(txtCedula.Text);
            datosProvedor.Add(txtNombre.Text);
            datosProvedor.Add(txtNombreContacto.Text);
            datosProvedor.Add(txtTelefono.Text);
            datosProvedor.Add(txtCorreo.Text);
            datosProvedor.Add(estado);

            return datosProvedor;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoSeleccionado = cmbEstado.SelectedItem.ToString();

            if (textoSeleccionado == "Activo")
            {
                estado = "1";
            }
            else if (textoSeleccionado == "Inactivo")
            {
                estado = "2";
            }
        }
        /*
        * Activo
       Inactivo
       Nuevo Provedor
       Editar Provedor
        */
        private void cmbTipoMant_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string textoSeleccionado = cmbTipoMant.SelectedItem.ToString();
            MessageBox.Show(textoSeleccionado);
            if (textoSeleccionado == "Nuevo Provedor")
            {
                tipoMant = 6;
            }
            else if (textoSeleccionado == "Editar Provedor")
            {
                tipoMant = 7;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProvedorJSON provedorJSON = new ProvedorJSON(); 
            provedorJSON.GenerarJson(generar_lista());
        }
    }
}
