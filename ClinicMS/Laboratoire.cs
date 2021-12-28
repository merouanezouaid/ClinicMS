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
    public partial class Laboratoire : UserControl
    {
        int ID = 0;
        Operations p = new Operations();
        public Laboratoire()
        {
            InitializeComponent();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            p.cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO laboratoire values (@pid, @testnom, @testprix)", p.cn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pid", int.Parse(pidtxtbox.Text));
                cmd.Parameters.AddWithValue("@testnom", testname.Text);
                cmd.Parameters.AddWithValue("@testprix", prix.Text);
                cmd.ExecuteNonQuery();

                p.cn.Close();
                p.cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from laboratoire", p.cn);
                adapt.Fill(dt);
                p.cn.Close();
                LaboDataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                p.cn.Close();
            }
        }

        private void Laboratoire_Load(object sender, EventArgs e)
        {
            p.cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from laboratoire", p.cn);
            adapt.Fill(dt);
            p.cn.Close();
            LaboDataGridView1.DataSource = dt;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Etes vous Sure de Supprimer?", "Supprimer la record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    p.cn.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("delete from laboratoire where pid=@id", p.cn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    p.cn.Close();
                    p.cn.Open();
                    DataTable d = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("select * from laboratoire", p.cn);
                    adapt.Fill(d);
                    p.cn.Close();
                    LaboDataGridView1.DataSource = d;
                    MessageBox.Show("Record Deleted Successfully!");


                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
                p.cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from laboratoire", p.cn);
                adapt.Fill(dt);
                p.cn.Close();
                LaboDataGridView1.DataSource = dt;
            }
            
        }

        private void LaboDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(LaboDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            pidtxtbox.Text = ID.ToString();
            testname.Text = LaboDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            prix.Text = LaboDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
