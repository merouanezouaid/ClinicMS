using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicMS.Operations;

namespace ClinicMS
{
    public partial class GestionPatients : UserControl
    {
        Operations op = new Operations();

        static int id = 0;
        public int share
        {
            get
            {
                return id;
            }
        }

        public GestionPatients()
        {
            InitializeComponent();
            dataGridView1.DataSource = op.DisplayData();

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
            BindingSource bs = new BindingSource();
            bs.DataSource = op.DisplayData();

            dataGridView1.DataSource = bs;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(op.patient.ToString())) { 
                 MessageBox.Show("Veuillez choisir le patient", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            else
            {
                reglerRDV1.Visible = true;
                listed_antecedents1.Visible = false;
            }

        }

        private void Antécedentsbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(op.patient.ToString()))
            {
                MessageBox.Show("Veuillez choisir le patient", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                reglerRDV1.Visible = false;
                listed_antecedents1.Visible = true;
            }
        }

        private void listed_antecedents1_Load(object sender, EventArgs e)
        {
                    }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            String pcin = bunifuTextBox1.Text;
            dataGridView1.DataSource = op.DisplayData(pcin);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            prenomtextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            gender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cintextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            datenaissancetextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0, 10);
            telephonetextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            situ.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            mut.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            adressetextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            datedecreationtxtbox.Text  = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString().Substring(0, 10);
            op.patient = Convert.ToInt32(idtextbox.Text);
            id = int.Parse(idtextbox.Text);
            }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Veullez remplir les champs!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand s = new SqlCommand("Select cin from Patient where cin LIKE '" + cintextbox.Text + "'", op.cn);
                op.cn.Open();
                SqlDataReader reader = s.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Le CIN de patient existe deja.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    op.cn.Close();

                }
                else
                {
                    op.cn.Close();
                    reader.Close();
                    if (op.ModifierPatient(nomtextbox.Text, prenomtextbox.Text, cintextbox.Text, gender.Text, datenaissancetextbox.Text,
                    telephonetextbox.Text, situ.Text, mut.Text, adressetextbox.Text, op.patient) == true)
                    {
                        MessageBox.Show("Le patient a ete modifier avec succes!!", "Patient ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource= op.DisplayData();
                    }
                    else
                    {
                        dataGridView1.DataSource = op.DisplayData();
                        MessageBox.Show("Veuillez verifier les informations saisis", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
