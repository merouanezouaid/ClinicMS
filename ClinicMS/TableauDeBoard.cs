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
    public partial class TableauDeBoard : Form
    {
        public TableauDeBoard()
        {
            InitializeComponent();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {
        }

        private void TableauDeBoard_Load(object sender, EventArgs e)
        {
            gestionPatients1.Visible = false;
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            gestionPatients1.Visible = true;
        }

        private void consultationbtn_Click(object sender, EventArgs e)
        {
            gestionPatients1.Visible=false;
            consultation cst = new consultation();
            cst.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter l'application?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();

            }
        }
    }
}
