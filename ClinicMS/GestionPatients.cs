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
    public partial class GestionPatients : UserControl
    {
        public GestionPatients()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            NouveauPatient p = new NouveauPatient();
            p.Show();
        }
    }
}
