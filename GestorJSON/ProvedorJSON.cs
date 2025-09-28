using ConexionServidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestorJSON
{
    public class ProvedorJSON
    {
        public void GenerarJson(List<object> datosProvedor)
        {
            string contenido = string.Join(Environment.NewLine, datosProvedor.Select((item, index) => $"[{index}] {item}"));

            // Mostrar el contenido en un MessageBox
            //MessageBox.Show(contenido, "Contenido de datosProvedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Crear un diccionario con los campos del cliente
            var clienteDict = new Dictionary<string, object>
            {
            { "op_code", datosProvedor[0] },
            { "CedulaJudirica", datosProvedor[1] },
            { "Nombre", datosProvedor[2] },
            { "NombreContacto", datosProvedor[3] },
            { "Telefono", datosProvedor[4] },
            { "Correo", datosProvedor[5] },
            { "Estado", datosProvedor[6] }
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
