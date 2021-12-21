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
    public partial class Visite : UserControl
    {
        public Visite()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RedegerOrdanancebtn_Click(object sender, EventArgs e)
        {
            makeordonance1.Visible = true;
            facture1.Visible = false;
        }

        private void Visite_Load(object sender, EventArgs e)
        {
            makeordonance1.Visible = false;
            facture1.Visible = false;
        }

        private void validerlavisitebtn_Click(object sender, EventArgs e)
        {
            facture1.Visible = true;
            makeordonance1.Visible = false;
        }
    }
}
