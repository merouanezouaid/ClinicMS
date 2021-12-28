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
        Operations ope = new Operations();

        public Medicament()
        {
            InitializeComponent();
            dataGridmedicament.DataSource = ope.GetMedicament();
        }

        private void Choisirmedicamentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
