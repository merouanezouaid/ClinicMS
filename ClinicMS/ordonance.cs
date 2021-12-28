using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMS
{
    public partial class Makeordonance : UserControl
    {
      
        public Makeordonance()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ajoutermedbtn_Click(object sender, EventArgs e)
        {
            medicament1.Visible = true;

        }

        private void Makeordonance_Load(object sender, EventArgs e)
        {
            medicament1.Visible = false;
        }


        private void medicament1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
           Operations o = new Operations();
          if( o.Prescrit(int.Parse(textBox6.Text), textBox2.Text, textBox1.Text, textBox5.Text, textBox4.Text, textBox3.Text) == true)
            {
                MessageBox.Show("Prescription bien ajouter ");
                textBox6.Clear();
                textBox2.Clear();
                textBox1.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox3.Clear();
                medtextbox.Clear();
                prescriptiongrid.DataSource=o.DisplayPrescription();
            }
            else
            {
                MessageBox.Show("verifier les donner ");
            }
            
        }

      
    }
    
}
