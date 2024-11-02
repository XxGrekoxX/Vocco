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
    public partial class FormDeluxe : Form
    {
        private Timer timer;
        private List<Image> images;
        private int currentPicIndex;
        public FormDeluxe()
        {
            InitializeComponent();
            InitializeImageSlider();
            
        }
        private void InitializeImageSlider()
        {
            // Inicializo una lista con imagenes 
            images = new List<Image>
        {

            Properties.Resources.deluxe1,
            Properties.Resources.deluxe2,
            Properties.Resources.deluxe3,
            Properties.Resources.deluxe

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
