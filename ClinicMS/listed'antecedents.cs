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
    public partial class listed_antecedents : UserControl
    {
        public listed_antecedents()
        {
            InitializeComponent();
        }

        

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ajouterunantecedentbtn_Click(object sender, EventArgs e)
        {
         
            addantecedent1.Visible = true;

        }

        private void listed_antecedents_Load(object sender, EventArgs e)
        {
            addantecedent1.Visible = false;
        }

        
    }
}
