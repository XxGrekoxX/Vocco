using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocco
{
    public partial class FormLogin : Form
    {
        private UsuarioManager usuarioManager = new UsuarioManager();
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.BackColor = Color.FromArgb(67, 144, 165);
            btnRegistrer.ForeColor = Color.FromArgb(67, 144, 165);
            lblTexto.ForeColor = Color.FromArgb(67, 144, 165);
            lblWelcome.ForeColor = Color.FromArgb(67, 144, 165);
            panelLoginColor1.BackColor = Color.FromArgb(67, 144, 165);
            panelLoginColor2.BackColor = Color.FromArgb(67, 144, 165);
            panelLoginColor3.BackColor = Color.FromArgb(67, 144, 165);
            
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxClose, "Cerrar ventana");
            //Esto es para que cuando pasen el cursor sobre el icono muestre un mensaje de texto de la funcion que realiza el mismo
        }

        private void picBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxClose, "Minimizar ventana");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string user, out string password, out string selectedRole))
                return;

            if (!usuarioManager.VerificarUsuario(user, password))
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SwitchToRoleForm(selectedRole);
        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            FormRegistrer1 fRegister = new FormRegistrer1();
            fRegister.Show();
            this.Hide();
        }

        private void picBoxShowPassword_Click(object sender, EventArgs e)
        {
            picBoxShowPassword.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picBoxHidePassword.Show();
        }

        private void picBoxHidePassword_Click(object sender, EventArgs e)
        {
            picBoxHidePassword.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picBoxShowPassword.Show();
        }

        private void picBoxShowPassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxShowPassword, "Mostrar contraseña");
        }

        private void picBoxHidePassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxHidePassword, "Esconder contraseña");
        }
        private bool ValidateInputs(out string user, out string password, out string selectedRole)
        {
            user = txtUser.Text.Trim();
            password = txtPassword.Text.Trim();
            selectedRole = comboBoxType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Por favor, rellena la información solicitada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void SwitchToRoleForm(string selectedRole)
        {
            MessageBox.Show("Inicio de sesión exitoso.");

            Form nextForm = null;

            if (selectedRole == "Gerente")
            {
                nextForm = new FormGerente();
            }
            else if (selectedRole == "Cliente")
            {
                nextForm = new FormCliente();
            }
            else
            {
                MessageBox.Show("Rol no reconocido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salimos si el rol no es reconocido
            }

            // Si el formulario siguiente no es nulo, lo mostramos y ocultamos el formulario actual
            nextForm.Show();
            this.Hide();
        }
    }
}
