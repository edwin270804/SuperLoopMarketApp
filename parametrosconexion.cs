using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public class parametrosconexion
    {
        [DataMember(Order = 0)]
        public string servidor { get; set; }

        [DataMember(Order = 1)]
        public string baseDatos { get; set; }

        public string cadenaConexion =>
            $"Data Source={servidor}; Initial Catalog ={baseDatos}; Integrated Security = True;Encrypt =False";
    }

    public static class AdministrarConexion
    {
        private static readonly string carpeta =
            Path.Combine(Application.StartupPath, "config");

        private static readonly string archivo = Path.Combine(carpeta, "conexion.json");

        private static string rutaArchivo => archivo;

        public static void Guardar(parametrosconexion parametros)
        {
            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            var serializar = new DataContractJsonSerializer(typeof(parametrosconexion));
            using (var ms = new MemoryStream())
            {
                serializar.WriteObject(ms, parametros);
                File.WriteAllText(archivo, Encoding.UTF8.GetString(ms.ToArray()), Encoding.UTF8);

            }
        }
        public static parametrosconexion cargar()
        {
            if (!File.Exists(archivo))
                return new parametrosconexion();

            var json = File.ReadAllText(archivo, Encoding.UTF8);
            var bytes = Encoding.UTF8.GetBytes(json);
            using (var ms = new MemoryStream(bytes))
            {
                var serializer = new DataContractJsonSerializer(typeof(parametrosconexion));
                return (parametrosconexion)serializer.ReadObject(ms);
            }
        }

        public static bool ProbarConexion(parametrosconexion parametros, out string error)
        {
            try
            {
                using (var cn = new SqlConnection(parametros.cadenaConexion))
                {
                    cn.Open();
                    error = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}

