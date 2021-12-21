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
    public partial class consultation : Form
    {
        public consultation()
        {
            InitializeComponent();
            traiterlecas1.Visible = false;
        }

        private void traiterlecasbtn_Click(object sender, EventArgs e)
        {
            traiterlecas1.Visible = true;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
