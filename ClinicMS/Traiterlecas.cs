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
    public partial class Traiterlecas : UserControl
    {
        public Traiterlecas()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Annulercastraiterbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Creeretpasseralavisitebtn_Click(object sender, EventArgs e)
        {
            visite1.Visible = true;
        }

        private void Traiterlecas_Load(object sender, EventArgs e)
        {
            visite1.Visible = false;
        }
    }
}
