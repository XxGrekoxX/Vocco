using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Vocco
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        private static string path = "usuarios.xml";
        static void Main()
        {
            CrearArchivoXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            
            
        }
        private static void CrearArchivoXml()
        {
            if (!File.Exists(path))
            {

                XElement usuariosElement = new XElement("Usuarios");

                XElement usuarioElement = new XElement("Usuario",
                    new XElement("ID", 1),
                    new XElement("Nombre", "Juan"),
                    new XElement("Usuario", "juan123"),
                    new XElement("Contraseña", "1234"),
                    new XElement("Email", "juan@example.com"),
                    new XElement("Apellido", "Pérez"),
                    new XElement("Telefono", "555-1234"),
                    new XElement("Tipo", "Cliente")
                );

                usuariosElement.Add(usuarioElement);
                usuariosElement.Save(path);
            }
        }
    }
}
