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
    public partial class FormHabitacionDoble : Form
    {
        private Timer timer;
        private List<Image> images;
        private int currentPicIndex;
        public FormHabitacionDoble()
        {
            InitializeComponent();
            InitializeImageSlider();
            lblDoubleRoom.ForeColor = Color.FromArgb(61, 111, 124);
            lblRoomFeatures.ForeColor = Color.FromArgb(61, 111, 124);
            lblBath.ForeColor = Color.FromArgb(61, 111, 124);
        }
        private void InitializeImageSlider()
        {
            // Inicializo una lista con imagenes 
            images = new List<Image>
        {
            Properties.Resources.image0,
            Properties.Resources.image1, 
            Properties.Resources.image2,
            Properties.Resources.image3
            
        };

            currentPicIndex = 0;
            picBoxDoubleRoom.Image = images[currentPicIndex];
            // Configuro el Timer para las fotos
            timer = new Timer();
            timer.Interval = 2000; // Cambia la imagen cada 2 segundos
            timer.Tick += timer1_Tick;
            timer.Start();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBoxReturn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBoxReturn, "Volver a la ventana anterior");
        }

        private void picBoxReturn_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
            this.Hide();
        }
    }
    
}
