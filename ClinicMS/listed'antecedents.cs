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
    public partial class listed_antecedents : UserControl
    {
        Operations op = new Operations();
        public listed_antecedents()
        {
            InitializeComponent();
        }

        

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Hide();
        }

        private void Ajouterunantecedentbtn_Click(object sender, EventArgs e)
        {
         
            addantecedent1.Visible = true;

        }

        public void listed_antecedents_Load(object sender, EventArgs e)
        {


            addantecedent1.Visible = false;
            SqlCommand s1 = new SqlCommand("select antecedents from Antecedents where typeAntecedents LIKE 'Familial' AND patientID = " + op.patient + "", op.cn);
            op.cn.Open();
            SqlDataReader DR1 = s1.ExecuteReader();
            if (DR1.Read())
            {
                idtextbox.Text = DR1.GetValue(0).ToString();
            }
            op.cn.Close();

           
           SqlCommand s2 = new SqlCommand("select antecedents from Antecedents where typeAntecedents LIKE 'Medical' AND patientID = " + op.patient + "", op.cn);
            op.cn.Open();
            SqlDataReader DR2 = s2.ExecuteReader();
            if (DR2.Read())
            {
                textBox1.Text = DR2.GetValue(0).ToString();
            }
            op.cn.Close();

            SqlCommand s3 = new SqlCommand("select antecedents from Antecedents where typeAntecedents LIKE 'Chirurgical' AND patientID = " + op.patient + "", op.cn);
            op.cn.Open();
            SqlDataReader DR3 = s3.ExecuteReader();
            if (DR3.Read())
            {
                textBox3.Text = DR3.GetValue(0).ToString();
            }
            op.cn.Close();

            this.Refresh();

        }

        private void idtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
