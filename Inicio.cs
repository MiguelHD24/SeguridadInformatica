using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RansomWare
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Miguel Angel Mendez Lopez
        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalText principalText = new PrincipalText();
            principalText.Show();
            this.Hide();
        }
    }
}
