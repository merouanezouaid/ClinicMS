using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicMS.Operations;

namespace ClinicMS
{
    public partial class consultation : Form
    {
        static int  ID = 0;
       
        public int share
        {
            get { return ID; }
        }
     

        public consultation()
        {
            InitializeComponent();
         
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Operations op = new Operations();
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
          
        }

        
      

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void consultation_Load(object sender, EventArgs e)
        {
            Operations op = new Operations();

            dataGridView1.DataSource = op.DisplayData();
        }

        //search by id
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            Operations op = new Operations();
            if (bunifuTextBox1.Text == "")
            {
                dataGridView1.DataSource = op.DisplayData();
            }
            else
            {
                int id = int.Parse(bunifuTextBox1.Text);
                dataGridView1.DataSource = op.SearchAttentebyid(id);
            }
           
        }
            //search by nom
        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
            Operations op = new Operations();
            if (bunifuTextBox5.Text == "")
            {
                dataGridView1.DataSource = op.DisplayData();
            }
            else
            {
                String nom = bunifuTextBox5.Text;
                dataGridView1.DataSource = op.SearchAttentebyNom(nom);
            }
        }
         //search by prenom
        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            Operations op = new Operations();
            if (bunifuTextBox2.Text == "")
            {
                dataGridView1.DataSource = op.DisplayData();
            }
            else
            {
                String prenom = bunifuTextBox2.Text;
                dataGridView1.DataSource = op.SearchAttentebyPrenom(prenom);
            }
        }
        //search by motif
        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            Operations op = new Operations();
            if (bunifuTextBox3.Text == "")
            {
                dataGridView1.DataSource = op.DisplayData();
            }
            else
            {
                String motif = bunifuTextBox3.Text;
                dataGridView1.DataSource = op.SearchAttentebymotif(motif);
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            op.SupprimerPatientAbsente(ID);
            dataGridView1.DataSource = op.DisplayData();
        }

        private void Passervisite_Click(object sender, EventArgs e)
        {
            visite1.Visible = true;
            
    }

        private void visite1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
