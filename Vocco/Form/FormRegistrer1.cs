using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocco
{
    public partial class FormRegistrer1 : Form
    {
        public FormRegistrer1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelef.Text)
                )
            {
                MessageBox.Show("Por favor, rellene todos los espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UsuarioManager usuarioManager = new UsuarioManager();
                Usuario nuevoUsuario = new Usuario
                {
                    id = int.Parse(txtId.Text),
                    name = txtName.Text,
                    user = txtUser.Text,
                    password = txtPassword.Text,
                    email = txtEmail.Text,
                    lastName = txtLastName.Text,
                    telef = txtTelef.Text,
                    tipo = txtTipo.Text
                };
                usuarioManager.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario registrado con éxito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogin formLogin = new FormLogin(); 
                formLogin.Show();
                this.Close();
            }
        }
    }
}
