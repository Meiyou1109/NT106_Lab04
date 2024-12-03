using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEx01_Click(object sender, EventArgs e)
        {
            new Ex01().Show();
            this.Hide();
        }

        private void btnEx02_Click(object sender, EventArgs e)
        {
            new Ex02().Show();
            this.Hide();
        }

        private void btnEx03_Click(object sender, EventArgs e)
        {
            new Ex03().Show();
            this.Hide();
        }
    }
}
