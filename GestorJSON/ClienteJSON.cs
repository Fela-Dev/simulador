using ConexionServidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GestorJSON
{
    public class ClienteJSON
    {
        public void GenerarJson(List <object> datosCliente)
        {
            // Crear un diccionario con los campos del cliente
            var clienteDict = new Dictionary<string, object>
            {
            { "op_code", datosCliente[0] },
            { "Cedula", datosCliente[1] },
            { "Pais", datosCliente[2] },
            { "Nombre", datosCliente[3] },
            { "PrimerApellido", datosCliente[4] },
            { "SegundoApellido", datosCliente[5] },
            { "Correo", datosCliente[6] },
            { "Telefono", datosCliente[7] },
            { "Direccion", datosCliente[8] }
            };

            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Convertir a JSON con formato
            string jsonString = JsonSerializer.Serialize(clienteDict, opciones);

            // Mostrar en MessageBox
            
            EnviarJson(jsonString);


        }

        private void EnviarJson(string json)
        {
            ConexionVerificador conV = new ConexionVerificador();

            try
            {
                conV.EnviarJson(json);
                /*
                 * 
                 
                using (TcpClient client = new TcpClient("localhost", 6666))
                using (NetworkStream stream = client.GetStream())
                {
                    // Enviar JSON
                    byte[] datosEnviar = Encoding.ASCII.GetBytes(json);
                    stream.Write(datosEnviar, 0, datosEnviar.Length);

                    // Recibir respuesta del servidor
                    byte[] datosRecibir = new byte[256];
                    int bytesRecibidos = stream.Read(datosRecibir, 0, datosRecibir.Length);
                    string mensajeServidor = Encoding.ASCII.GetString(datosRecibir, 0, bytesRecibidos);

                    // Mostrar mensaje en un MessageBox
                    MessageBox.Show(mensajeServidor, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
