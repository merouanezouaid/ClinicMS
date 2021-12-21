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
    public partial class Makeordonance : UserControl
    {
        public Makeordonance()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ajoutermedbtn_Click(object sender, EventArgs e)
        {
            medicament1.Visible = true;
        }

        private void Makeordonance_Load(object sender, EventArgs e)
        {
            medicament1.Visible = false;
        }
    }
}
