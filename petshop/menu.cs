using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petshop
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void buttoncadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telacpet = new cadastropet();
            telacpet.Closed += (s, args) => this.Close();
            telacpet.Show();
        }

        private void buttonpets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form telavpet = new verpets();
            telavpet.Closed += (s, args) => this.Close();
            telavpet.Show();
        }
    }
}
