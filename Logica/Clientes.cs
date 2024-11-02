using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logica
{
    internal class Clientes
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string telef { get; set; }
        public string email { get; set; }
        public bool tipo { get; set; }
        public string password { get; set; }
    }
}
