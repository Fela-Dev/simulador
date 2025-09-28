using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using ConexionServidor;
namespace GestorJSON
{
    public class RegistroVentaJSON
    {
        public void GenerarJSON(List<object> data, List<Producto> listaP)
        {
            // Crear el diccionario principal
            var compraDict = new Dictionary<string, object>
            {
                { "op_code", 5 },
                { "Id_cliente", data[0] },
                { "NumeroCompra", data[1] },
                { "Fecha", data[2] },
                { "NumeroTarjeta", data[3] },
                { "FechaVencimiento", data[4] },
                { "CodigoTarjeta", data[5] },
                { "Total", data[6] }
            };

            // Crear la lista de productos
            var listaProductos = new List<Dictionary<string, object>>();
            foreach (Producto p in listaP)
            {
                var producto = new Dictionary<string, object>
                {
                    { "Codigo", p.codigo },
                    { "Cantidad", p.cantidad }
                };
                        listaProductos.Add(producto);
            }

            // Agregar la lista de productos al diccionario principal
            compraDict.Add("ListaProductos", listaProductos);

            // Serializar a JSON
            string jsonString = JsonSerializer.Serialize(compraDict, new JsonSerializerOptions { WriteIndented = true });
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