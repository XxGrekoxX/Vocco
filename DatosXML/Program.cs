using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DatosXML
{
    internal class Program
    {
        private static string path = "usuarios.xml";
        static void Main(string[] args)
        {
            //CrearArchivoXml();
        }
        private static void CrearArchivoXml()
        {
            if (!File.Exists(path))
            {
                
                XElement usuariosElement = new XElement("Usuarios");

                XElement usuarioElement = new XElement("Usuario",
                    new XElement("ID", 1),
                    new XElement("Nombre", "Juan"),
                    new XElement("UsuarioName", "juan123"),
                    new XElement("Password", "1234"),
                    new XElement("Email", "juan@example.com"),
                    new XElement("Apellido", "Pérez"),
                    new XElement("Telefono", "555-1234"),
                    new XElement("Rol", "Cliente")
                );

                usuariosElement.Add(usuarioElement);
                usuariosElement.Save(path);
            }
        }

    }
}
