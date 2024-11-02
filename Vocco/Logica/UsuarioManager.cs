using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vocco
{
    public class UsuarioManager
    {
        private string path = "usuarios.xml";
        public List<Usuario> CargarUsuarios()
        {
            var usuarios = new List<Usuario>();
            XElement xml = XElement.Load(path);

            foreach (var elemento in xml.Elements("Usuario"))
            {
                var usuario = new Usuario
                {
                    id = (int)elemento.Element("ID"),
                    name = (string)elemento.Element("Nombre"),
                    user = (string)elemento.Element("UsuarioName"),
                    password = (string)elemento.Element("Password"),
                    email = (string)elemento.Element("Email"),
                    lastName = (string)elemento.Element("Apellido"),
                    telef = (string)elemento.Element("Telefono"),
                    tipo = (string)elemento.Element("Rol")
                };
                usuarios.Add(usuario);
            }
            if (usuarios == null) 
            {
                return null;
            }
            return usuarios;
        }
        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            XElement xml = XElement.Load(path);
            XElement nuevoElemento = new XElement("Usuario",
                new XElement("ID", nuevoUsuario.id),
                new XElement("Nombre", nuevoUsuario.name),
                new XElement("Usuario", nuevoUsuario.user),
                new XElement("Contraseña", nuevoUsuario.password),
                new XElement("Email", nuevoUsuario.email),
                new XElement("Apellidos", nuevoUsuario.lastName),
                new XElement("Telefono", nuevoUsuario.telef),
                new XElement("Tipo", nuevoUsuario.tipo)
            );
            xml.Add(nuevoElemento);
            xml.Save(path);
        }
        public void ModificarUsuario(Usuario usuarioModificado)
        {
            XElement xml = XElement.Load(path);
            var usuario = xml.Elements("Usuario").FirstOrDefault(u => (int)u.Element("ID") == usuarioModificado.id);

            if (usuario != null)
            {
                usuario.Element("Nombre").Value = usuarioModificado.name;
                usuario.Element("Usuario").Value = usuarioModificado.user;
                usuario.Element("Contraseña").Value = usuarioModificado.password;
                usuario.Element("Email").Value = usuarioModificado.email;
                usuario.Element("Apellido").Value = usuarioModificado.lastName;
                usuario.Element("Telefono").Value = usuarioModificado.telef;
                usuario.Element("Tipo").Value = usuarioModificado.tipo;
                xml.Save(path);
            }
        }
        public void EliminarUsuario(int id)
        {
            XElement xml = XElement.Load(path);
            var usuario = xml.Elements("Usuario").FirstOrDefault(u => (int)u.Element("ID") == id);

            if (usuario != null)
            {
                usuario.Remove();
                xml.Save(path);
            }
        }
        public bool VerificarUsuario(string usuarioName, string password)
        {
            var usuarios = CargarUsuarios();
            return usuarios.Any(u => u.user == usuarioName && u.password == password);
        }
    }
}
