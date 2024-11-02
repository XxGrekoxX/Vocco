using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vocco
{
    public partial class FormGerente : Form
    {
        public string userName;
        public FormGerente()
        {
            InitializeComponent();
            panelColor1.BackColor = Color.FromArgb(54, 86, 94);
            panelColor2.BackColor = Color.FromArgb(93, 93, 93);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            btnRooms.Visible = false;
            picBoxHabitaciones.Visible = false;
            btnClients.Visible = false;
            btnReservas1.Visible = true;
            picBoxRegistroReservas.Visible = true;
            picBoxVentanaClientes.Visible = false;
        }

        private void FormEmpleadocs_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblNameUser.Text = userName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
        }

        private void linkLblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FormRegistroClients fClientess = new FormRegistroClients();
            fClientess.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            FormHabitaciones fRooms = new FormHabitaciones();
            fRooms.Show();
            this.Hide();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            btnRooms.Visible = true;
            picBoxHabitaciones.Visible = true;
            btnClients.Visible = false;
            btnReservas1.Visible = false;
            picBoxRegistroReservas.Visible = false;
            picBoxVentanaClientes.Visible = false;
        }

        private void btnCatalogUser_Click(object sender, EventArgs e)
        {
            btnClients.Visible = true;
            picBoxVentanaClientes.Visible = true;
            btnRooms.Visible = false;
            picBoxHabitaciones.Visible = false;
            btnReservas1.Visible = false;
            picBoxRegistroReservas.Visible = false;
            picBoxVentanaClientes.Visible = false;

        }

        private void btnReservas1_Click(object sender, EventArgs e)
        {
            FormAprobarReservas fAprobarReservas = new FormAprobarReservas();
            fAprobarReservas.Show();
            this.Hide();
        }
    }
}
