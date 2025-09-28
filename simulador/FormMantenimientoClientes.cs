using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorJSON;
namespace simulador;
    public partial class FormMantenimientoClientes : Form
    {
        int tipoMant;
        public FormMantenimientoClientes()
        {

            InitializeComponent();
            
            
            cmbTipoMant.SelectedIndex = 0;
            tipoMant = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Nuevo Cliente id=1
                Editar Cliente id=2
                Eliminar Cliente id=3    
             */
            String chose = cmbTipoMant.Text;

            if (chose == "Nuevo Cliente")
            {
                tipoMant = 1;
            }
            else if (chose == "Editar Cliente")
            {
                tipoMant = 2;
            }
            else if (chose == "Eliminar Cliente")
            {
                tipoMant = 3;
            }



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteJSON archivoCliente = new GestorJSON.ClienteJSON();
            archivoCliente.GenerarJson(generLista());
            

        }

        private List<object> generLista()
        {
            /*
             * (2,"1234567890", "CR", "Felipito", "Gonzalez", "Lopez", "felipe@mail.com", "88881234", "Calle 123"),
             */
            List<object> datosCliente = new List<object>();
            datosCliente.Add(tipoMant);
            datosCliente.Add(txtCedula.Text);
            datosCliente.Add(txtPais.Text);
            datosCliente.Add(txtNombre.Text);
            datosCliente.Add(txtPrimerApellido.Text);
            datosCliente.Add(txtSegundoApellido.Text);
            datosCliente.Add(txtCorreo.Text);
            datosCliente.Add(txtTelefono.Text);
            datosCliente.Add(txtDireccion.Text);
            for (int i = 0; i < datosCliente.Count; i++)
            {
                //MessageBox.Show($"Elemento {i}: {datosCliente[i]}");
            }


            return datosCliente;
        }

        private void FormMantenimientoClientes_Load(object sender, EventArgs e)
        {

        }
    }

