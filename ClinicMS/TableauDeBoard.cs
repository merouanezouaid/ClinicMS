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

            gestionPatients1.BringToFront();
        }

        private void consultationbtn_Click(object sender, EventArgs e)
        {
            gestionPatients1.Visible=false;
            consultation cst = new consultation();
            cst.Show();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            docteurs1.BringToFront();
        }
        
        private void dash1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            laboratoire1.BringToFront();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter l'application?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();

            }
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
