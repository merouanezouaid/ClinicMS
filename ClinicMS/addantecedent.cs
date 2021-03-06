using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicMS
{
    public partial class addantecedent : UserControl
    {
        public addantecedent()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            listed_antecedents a = new listed_antecedents();
            if(op.AjouterLANT(op.patient, typeant.Text, anttxtbox.Text, com.Text) == true)
            {
                MessageBox.Show("Antecedent ajoute avec succees!!", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez verifier les informations saisis", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            a.listed_antecedents_Load(sender, e);
        }
    }
}
