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
    public partial class ReglerRDV : UserControl
    {
        public ReglerRDV()
        {
            InitializeComponent();
        }

        private void Annullerrdvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
