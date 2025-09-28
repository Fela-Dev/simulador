using System;
using System.Net.Sockets;
using System.Text;

namespace ConexionServidor
{
    public class ConexionVerificador
    {
        private string ipServidor="localhost";
        private int puerto=6666;


        
        public void EnviarJson(string json)
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
