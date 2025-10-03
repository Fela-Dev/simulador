using ConexionServidor;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestorJSON
{
    public class CompraProductoJSON
    {
        public void GenerarJSON(List<object> data, List<Producto> listaP)
        {
            // Crear el diccionario principal
            var compraDict = new Dictionary<string, object>
            {
                { "op_code", 7 },
                { "NumeroCompra", data[0] },
                { "Fecha", data[1] },
                { "CedulaJuridica", data[2] }
                
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
