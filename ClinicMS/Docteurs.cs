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
    public partial class Docteurs : UserControl
    {
        Operations o = new Operations();
        int ID = 0;
        public Docteurs()
        {
            InitializeComponent();
        }
        
        private void doc_id_searchbox_TextChanged(object sender, EventArgs e)
        {
 


        }

        private void Docteurs_Load(object sender, EventArgs e)
        {
        }


        private void DisplayData()
        {
            o.cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("select * from Docteur", o.cn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            o.cn.Close();
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            D_Cin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            D_Nom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            D_Prenom.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            D_Telephone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            D_Adresse.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            D_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Departement.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Specialite.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            DateAmbauche.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Grade.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Docteurs_Load_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            Boolean noproblem = true;

            try
            {

                if (D_Cin.Text == "")
                {
                    errorProvider2.SetError(D_Cin, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (D_Nom.Text == "")
                {
                    errorProvider2.SetError(D_Nom, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (D_Prenom.Text == "")
                {
                    errorProvider2.SetError(D_Prenom, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (D_Telephone.Text == "")
                {
                    errorProvider2.SetError(D_Telephone, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (D_Adresse.Text == "")
                {
                    errorProvider2.SetError(D_Adresse, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (D_Email.Text == "")
                {
                    errorProvider2.SetError(D_Email, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (Departement.Text == "")
                {
                    errorProvider2.SetError(Departement, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (Specialite.Text == "")
                {
                    errorProvider2.SetError(Specialite, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else if (Grade.Text == "")
                {
                    errorProvider2.SetError(Grade, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                }
                else
                {
                    //'SET THE ERROR PROVIDER TO BE CLEARED.
                    errorProvider2.SetError(D_Cin, "");
                    errorProvider2.SetError(D_Nom, "");
                    errorProvider2.SetError(D_Prenom, "");
                    errorProvider2.SetError(D_Telephone, "");
                    errorProvider2.SetError(D_Adresse, "");
                    errorProvider2.SetError(D_Email, "");
                    errorProvider2.SetError(Departement, "");
                    errorProvider2.SetError(Specialite, "");
                    errorProvider2.SetError(Grade, "");

                    if (!System.Text.RegularExpressions.Regex.IsMatch(D_Cin.Text, @"^[a-zA-Z0-9]+$"))
                    {

                        errorProvider2.SetError(D_Cin, "Cin accepte que les nombres et les characteres");
                        noproblem = false;
                    }
                    if (!System.Text.RegularExpressions.Regex.IsMatch(D_Nom.Text, @"^[a-zA-Z]+$"))
                    {

                        errorProvider2.SetError(D_Nom, "Nom  accepte que les characteres");
                        noproblem = false;
                    }
                    if (!System.Text.RegularExpressions.Regex.IsMatch(D_Prenom.Text, @"^[a-zA-Z]+$"))
                    {

                        errorProvider2.SetError(D_Prenom, "Prenom  accepte que les characteres");
                        noproblem = false;
                    }
                    if (!System.Text.RegularExpressions.Regex.IsMatch(D_Telephone.Text, "^[0-9]*$"))
                    {

                        errorProvider2.SetError(D_Telephone, "le num de telephone ne peut contient que des nombre");
                        noproblem = false;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(D_Email.Text, "[%@%]"))
                    {

                        errorProvider2.SetError(D_Email, "l'Email doit Contenir  @");
                        noproblem = false;
                    }
                    if (!System.Text.RegularExpressions.Regex.IsMatch(Departement.Text, @"^[a-zA-Z0-9]+$"))
                    {

                        errorProvider2.SetError(Departement, "Departement accepte que les nombres et les characteres");
                        noproblem = false;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(Specialite.Text, @"^[a-zA-Z]+$"))
                    {

                        errorProvider2.SetError(Specialite, "ce champ Accepte que les characteres");
                        noproblem = false;
                    }



                }
                if (noproblem == true)
                {
                    if (MessageBox.Show("Etes vous Sure d'Editer ?", "Editer le Docteur", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SqlCommand cmd;

                        o.cn.Open();
                        cmd = new SqlCommand("ModifierDocteur", o.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@D_Cin", D_Cin.Text);
                        cmd.Parameters.AddWithValue("@D_Nom", D_Nom.Text);
                        cmd.Parameters.AddWithValue("@D_Prenom", D_Prenom.Text);
                        cmd.Parameters.AddWithValue("@D_Telephone", D_Telephone.Text);
                        cmd.Parameters.AddWithValue("@D_Adresse", D_Adresse.Text);
                        cmd.Parameters.AddWithValue("@D_Email", D_Email.Text);
                        cmd.Parameters.AddWithValue("@Departement", Departement.Text);
                        cmd.Parameters.AddWithValue("@Specialite", Specialite.Text);
                        cmd.Parameters.AddWithValue("@Grade", Grade.Text);
                        cmd.Parameters.AddWithValue("@DateEmbauche", DateAmbauche.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Docteur Updated Successfully!");
                        o.cn.Close();
                        DisplayData();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Etes vous Sure de Supprimer?", "Supprimer la record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    o.cn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("delete Docteur where D_id=@id", o.cn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    o.cn.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();

                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
        }

        private void doc_id_searchbox_TextChanged_1(object sender, EventArgs e)
        {
            Boolean noproblem = true;

            try
            {
                if (doc_id_searchbox.Text == "")
                {
                    errorProvider2.SetError(doc_id_searchbox, "Cette case ne peut pas etre vide.");
                    noproblem = false;
                    DisplayData();
                }
                else
                {
                    errorProvider2.SetError(doc_id_searchbox, "");
                    if (!System.Text.RegularExpressions.Regex.IsMatch(doc_id_searchbox.Text, "^[0-9]*$"))
                    {

                        errorProvider2.SetError(doc_id_searchbox, "Entrer un nombre !!");
                        noproblem = false;
                        DisplayData();
                    }
                    if (noproblem == true)
                    {
                        int id = int.Parse(doc_id_searchbox.Text);
                        o.cn.Open();
                        string query = "select * from docteur where D_id='" + id + "'";
                        SqlCommand cmd = new SqlCommand(query, o.cn);
                        SqlDataAdapter dba;
                        dba = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dba.Fill(dt);
                        dataGridView1.DataSource = dt;
                        o.cn.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
