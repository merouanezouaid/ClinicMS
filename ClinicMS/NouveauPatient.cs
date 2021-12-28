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
    public partial class NouveauPatient : Form
    {
        Operations p = new Operations();
        public NouveauPatient()
        {
            InitializeComponent();
            doc.DataSource = p.GetDocteur();
            doc.DisplayMember = "D_Nom";
            doc.ValueMember = "D_id";
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Veullez remplir les champs!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand s = new SqlCommand("Select cin from Patient where cin LIKE '" + cintextbox.Text + "'", p.cn);
                p.cn.Open();
                SqlDataReader reader = s.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Le CIN de patient existe deja.", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    p.cn.Close();

                }
                else
                {
                    p.cn.Close();
                    reader.Close();
                    if (p.AjouterPatient(nomtextbox.Text, prenomtextbox.Text, cintextbox.Text, gender.Text, datenais.Value,
                telephonetextbox.Text, situ.Text, mut.Text, ad.Text, DateTime.Now, Convert.ToInt32(doc.SelectedValue.ToString())) == true)
                    {
                        MessageBox.Show("Le patient est ajoute avec succes!!", "Patient ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Veuillez verifier les informations saisis", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
