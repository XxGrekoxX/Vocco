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
    public partial class FormHabitaciones : Form
    {
        public FormHabitaciones()
        {
            InitializeComponent();
        }

        private void picBoxReturn_Click(object sender, EventArgs e)
        {
            FormGerente formGerente = new FormGerente();
            formGerente.Show();
            this.Hide();
        }
    }
}
