using ConexionServidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestorJSON
{
    public class ProductoJSON
    {
        public void GenerarJson(List<object> datosCliente)
        {
            // Crear un diccionario con los campos del cliente
            var clienteDict = new Dictionary<string, object>
            {
            { "op_code", datosCliente[0] },
            { "Numero", datosCliente[1] },
            { "Nombre", datosCliente[2] },
            { "Precio", datosCliente[3] }
            };

            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(clienteDict, opciones);
            EnviarJson(jsonString);
        }
        private void EnviarJson(string json)
        {
            ConexionVerificador conV = new ConexionVerificador();

            try
            {
                conV.EnviarJson(json);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
