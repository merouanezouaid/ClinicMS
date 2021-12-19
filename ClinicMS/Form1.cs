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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (showPassword.Checked == true) 
                {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter l'application?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            String username = usernameTextbox.Text;
            String password = passwordTextBox.Text;

            if (username == "kaito" && password == "123")
            {
                //MessageBox.Show("Logged in successfully!!");

                this.Hide();
                TableauDeBoard tb = new TableauDeBoard();
                tb.Show();
            }

            else
            {
                MessageBox.Show("Nom d'utilisateur et/ou mot de passe incorrect", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
