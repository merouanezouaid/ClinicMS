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
    public partial class Medicament : UserControl
    {
        public Medicament()
        {
            InitializeComponent();
        }
       
        
        private void Choisirmedicamentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Medicament_Load(object sender, EventArgs e)
        {
            Operations o = new Operations();
            dataGridmedicament.DataSource = o.DisplayMedicament();
        }

        private void searchmedicines_TextChanged(object sender, EventArgs e)
        {
            Operations op = new Operations();
            if (searchmedicines.Text == "")
            {
                dataGridmedicament.DataSource = op.DisplayMedicament();
            }
            else
            {

                dataGridmedicament.DataSource = op.SearchAttentebyMedicament(searchmedicines.Text);
            }
            
        }

        private void dataGridmedicament_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Operations op = new Operations();
            String medicines = dataGridmedicament.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
