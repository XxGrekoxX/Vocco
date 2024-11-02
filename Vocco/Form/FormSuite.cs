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
    public partial class FormSuite : Form
    {
        private Timer timer;
        private List<Image> images;
        private int currentPicIndex;
        public FormSuite()
        {
            InitializeComponent();
            InitializeImageSlider();
            
        }
        private void InitializeImageSlider()
        {
            // Inicializo una lista con imagenes 
            images = new List<Image>
        {
            
            Properties.Resources.suite1,
            Properties.Resources.suite2,
            Properties.Resources.suite3

        };

            currentPicIndex = 0;
            picBoxDoubleRoom.Image = images[currentPicIndex];
            // Configuro el Timer para las fotos
            timer = new Timer();
            timer.Interval = 2000; // Cambia la imagen cada 2 segundos
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void cbmNights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBath_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDoubleRoom_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomFeatures_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmAdult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void picBoxDoubleRoom_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPicIndex++;
            if (currentPicIndex >= images.Count)
            {
                currentPicIndex = 0; // Reinicia al inicio
            }
            picBoxDoubleRoom.Image = images[currentPicIndex];
        }

        private void picBoxReturn_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
            this.Hide();
        }

        private void picBoxReturn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxReturn, "Volver a la ventana anterior");
        }
    }
}
