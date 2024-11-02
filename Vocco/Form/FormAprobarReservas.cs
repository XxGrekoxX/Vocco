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
    public partial class FormAprobarReservas : Form
    {
        public FormAprobarReservas()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                ListViewItem itemSeleccionad = listView1.SelectedItems[0];
                Rectangle item = listView1.GetItemRect(listView1.SelectedIndices[0]);
                comboBoxCambiarA.Location = new Point(item.Right, item.Top);
                comboBoxCambiarA.Visible = true;
                comboBoxCambiarA.SelectedIndex = comboBoxCambiarA.Items.IndexOf(itemSeleccionad.SubItems[2]);
            }

        }

        private void comboBoxCambiarA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                ListViewItem itemSeleccionad = listView1.SelectedItems[0];
                //Esto es para actualizar el estado en el listView
                itemSeleccionad.SubItems[1].Text=comboBoxCambiarA.SelectedItem.ToString();
                comboBoxCambiarA.Visible=false;// se va a ocultar el combobox luego de escoger si esta aprobada o no 
            }
        }

        private void comboBoxCambiarA_Leave(object sender, EventArgs e)
        {
            comboBoxCambiarA.Visible = false;
        }

        private void picBoxReturn_Click(object sender, EventArgs e)
        {
            FormGerente formGerente = new FormGerente();
            formGerente.Show();
            this.Hide();
        }
    }
}
