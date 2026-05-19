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
    public partial class FrmHabilitations : Form
    {
        private FrmHabilitationsController controller;

        public FrmHabilitations()
          {   
           InitializeComponent();
           controller = new FrmHabilitationsController();
            dgvPersonnel.DataSource = 
                controller.GetLesDeveloppeurs();
            
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
            dgvPersonnel.DataSource = null;
            dgvPersonnel.DataSource = controller.GetLesDeveloppeurs();
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

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string nom = txtnom.Text;
            string prenom = textpre.Text;
            string tel = texttel.Text;
            string mail = textmail.Text;

            int idservice = cmbserv.SelectedIndex + 1;

            controller.AjoutPersonnel(
                nom, prenom, tel, mail, idservice);
            dgvPersonnel.DataSource = null;
            dgvPersonnel.DataSource = controller.GetLesDeveloppeurs();
        }
    }
}
