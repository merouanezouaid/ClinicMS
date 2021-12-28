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
    public partial class Visite : UserControl
    {
      
        public Visite()
        {
            InitializeComponent();
            
        }
       
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RedegerOrdanancebtn_Click(object sender, EventArgs e)
        {
            makeordonance1.Visible = true;
          
        }
         
        private void Visite_Load(object sender, EventArgs e)
        {
            consultation C = new consultation();
            idtxt.Text = C.share.ToString();
            makeordonance1.Visible = false;
        
        }

        private void validerlavisitebtn_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();
         ;
            makeordonance1.Visible = false;
            if(o.validervisite(int.Parse(idtxt.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, int.Parse(textBox7.Text), PayercomboBox.SelectedItem.ToString())==true)
            {
                MessageBox.Show("Visite bien Valider ");
                idtxt.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
               
            }
            else
            {
                MessageBox.Show("verifier les donnees!!");
            }
            
        }

        private void makeordonance1_Load(object sender, EventArgs e)
        {
            Operations o = new Operations();
            o.DisplayMedicament();
        }
    }
}
