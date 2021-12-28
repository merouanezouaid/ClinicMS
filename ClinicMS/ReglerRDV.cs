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
    public partial class ReglerRDV : UserControl
    {
        public ReglerRDV()
        {
            InitializeComponent();
        }

        private void Annullerrdvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Operations o = new Operations();

            SqlCommand s = new SqlCommand("Select dateRDV, heureRDV from RDV where dateRDV = '" + bunifuDatepicker1.Value + "' AND heureRDV = '" + textBox2.Text + "'", o.cn);
            o.cn.Open();
            SqlDataReader reader = s.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Deja reservee.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                o.cn.Close();

            }
            else
            {
                if (o.reglerRDV(idtextbox.Text, bunifuDatepicker1.Value, textBox2.Text, textBox1.Text) == true)
                {
                    MessageBox.Show("RDV REGLE!!", "SUCCEES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Veuillez verifier les informations saisis", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReglerRDV_Load(object sender, EventArgs e)
        {
            GestionPatients p = new GestionPatients();
            idtextbox.Text = p.share.ToString();
        }
    }
}
