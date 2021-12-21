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
    public partial class GestionPatients : UserControl
    {
        public GestionPatients()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            NouveauPatient p = new NouveauPatient();
            p.Show();
        }

        private void Reglerrdvbtn_Click(object sender, EventArgs e)
        {
            reglerRDV1.Visible= true;
        }

        private void GestionPatients_Load(object sender, EventArgs e)
        {
            reglerRDV1.Visible = false;
           
            listed_antecedents1.Visible = false;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reglerRDV1.Visible = true;
            
            listed_antecedents1.Visible = false;
        }

        private void Antécedentsbtn_Click(object sender, EventArgs e)
        {
           
            reglerRDV1.Visible = false;
            listed_antecedents1.Visible = true;
        }

       
    }
}
