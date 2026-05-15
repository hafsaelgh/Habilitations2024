using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Habilitations2024.controller;

namespace Habilitations2024.view
{
    public partial class textnom : Form
    {
        private FrmHabilitationsController controller;
       
          public textnom()
          {   
           InitializeComponent();
           controller = new FrmHabilitationsController();
            dgvPersonnel.DataSource = 
                controller.GetLesDeveloppeurs();
            MessageBox.Show("Nombre de développeurs : " + controller.GetLesDeveloppeurs().Count);
          }
            
        private void FrmHabilitations_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Modifier_Click(object sender, EventArgs e)
        {

        }
        private void supprimer_Click(object sender, EventArgs e)
        {

        }
        private void actualiser_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
