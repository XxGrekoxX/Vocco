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
    public partial class FormCliente : Form
    {
        public string userName;
        public FormCliente()
        {
            InitializeComponent();
            panelColor1.BackColor = Color.FromArgb(54, 86, 94);
            panelColor2.BackColor = Color.FromArgb(93, 93, 93);
            btnDeluxe.BackColor = Color.FromArgb(63, 136, 143);
            btnDoubleRoom.BackColor = Color.FromArgb(192, 119, 112);
            btnSuit.BackColor = Color.FromArgb(105, 199, 183);


        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MovePanel(btnAboutUs);
            pictBoxAbout.Visible = true;
            panelPerfil.Visible = false;
            panelFondo.Visible = false;
            picboxBed.Visible = false;
            btnSuit.Visible = false;
            btnDoubleRoom.Visible = false;
            btnDeluxe.Visible = false;

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            MovePanel(btnService);
            pictBoxAbout.Visible = false;
            panelFondo.Visible = false;
            panel3.Visible = true;
            panelPerfil.Visible = false;
            picboxBed.Visible = true;
            btnSuit.Visible = true;
            btnDoubleRoom.Visible = true;
            btnDeluxe.Visible = true;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            panelFondo.Visible = true;
            panelPerfil.Visible = false;
            pictBoxAbout.Visible = false;
            picboxBed.Visible = false;
            btnSuit.Visible = false;
            btnDoubleRoom.Visible = false;
            btnDeluxe.Visible = false;
        }

        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            MovePanel(btnInfoUser);
            panelPerfil.Visible = false;
            //panelPerfil.Visible = true;
            panelFondo.Visible = false;
            pictBoxAbout.Visible = false;
            picboxBed.Visible = false;
            btnSuit.Visible = false;
            btnDoubleRoom.Visible = false;
            btnDeluxe.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblNameUser.Text = userName;
        }

        private void btnDoubleRoom_Click(object sender, EventArgs e)
        {
            FormHabitacionDoble fHabitacionDouble = new FormHabitacionDoble();
            fHabitacionDouble.Show();
            this.Hide();
        }

        private void btnSuit_Click(object sender, EventArgs e)
        {
            FormSuite fHSuite = new FormSuite();
            fHSuite.Show();
            this.Hide();
        }

        private void btnDeluxe_Click(object sender, EventArgs e)
        {
            FormDeluxe fDeluxe = new FormDeluxe();
            fDeluxe.Show();
            this.Hide();
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

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
